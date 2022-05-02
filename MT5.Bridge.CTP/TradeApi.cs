using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Bridge.CTP
{
    public class TradeApi : IDisposable
    {
        private int _RequestID = 0;
        private IntPtr Handle;

        private IBroker Broker { get; set; }

        public string User { get; init; }

        private string Password { get; init; }

        public string DataFolder { get; init; }

        private SQLiteConnection NewMT5DbConnection() => new SQLiteConnection($"Data Source={DataFolder}\\mt5.db");

        /// <summary>
        /// ǰ�û��Ƿ�Ϊ��
        /// </summary>
        public bool IsFrontBlank { get; private set; } = true;


        private string InvesterID { get; set; }

        private ulong TimeStamp => (ulong)(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

        public TradeApi(IBroker broker, string user, string password)
        {
            Broker = broker;
            User = user;
            Password = password;

            DataFolder = string.Join("", MD5.HashData(Encoding.Default.GetBytes(broker.Name)).Select(x => x.ToString("X")).ToArray());
            DataFolder = $"ctp\\{DataFolder}";

            var di = Directory.CreateDirectory($"{DataFolder}");
            InitializeDatabase();
            Handle = TdCreateApi(di.FullName + "\\");

            TdSubscribePrivateTopic(Handle, THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
            TdSubscribePublicTopic(Handle, THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);

            foreach (var ip in broker.TradeFront)
                RegisterFront(ip);

            InitCallback();

            OnRspError += (a, b, c) => { Console.WriteLine($"OnRspError ID:{b} islast:{c} {a.ErrorID} {a.ErrorMsg}"); };
        }

        private bool InitializeDatabase()
        {
            using (var db = NewMT5DbConnection())
            {
                db.Open();

                db.Execute("CREATE TABLE IF NOT EXISTS Orders ( Ticket INTEGER PRIMARY KEY AUTOINCREMENT, TimeSetup INTEGER, Type INTEGER, State INTEGER, TimeExpiration INTEGER, TimeDone INTEGER, TimeSetupMsc INTEGER, TimeDoneMsc INTEGER," +
                    " TypeFilling INTEGER, TypeTime INTEGER, Magic INTEGER, Reason INTEGER, PositionID INTEGER, PositionByID INTEGER, VolumeInital DOUBLE, VolumeCurrent DOUBLE, PriceOpen DOUBLE, SL DOUBLE, TP DOUBLE," +
                    " PriceCurrent DOUBLE, PriceStopLimit DOUBLE, Symbol STRING, Comment STRING, ExternalID STRING UNIQUE);");

                db.Execute("CREATE TABLE IF NOT EXISTS HistoryOrders ( Ticket INTEGER PRIMARY KEY, TimeSetup INTEGER, Type INTEGER, State INTEGER, TimeExpiration INTEGER, TimeDone INTEGER, TimeSetupMsc INTEGER, TimeDoneMsc INTEGER," +
                    " TypeFilling INTEGER, TypeTime INTEGER, Magic INTEGER, Reason INTEGER, PositionID INTEGER, PositionByID INTEGER, VolumeInital DOUBLE, VolumeCurrent DOUBLE, PriceOpen DOUBLE, SL DOUBLE, TP DOUBLE," +
                    " PriceCurrent DOUBLE, PriceStopLimit DOUBLE, Symbol STRING, Comment STRING, ExternalID STRING );");

                db.Execute("CREATE TABLE IF NOT EXISTS Positions ( Ticket INTEGER PRIMARY KEY AUTOINCREMENT, Time INTEGER, TimeMsc INTEGER, TimeUpdate INTEGER, TimeUpdateMsc INTEGER, Type INTEGER, Magic INTEGER, " +
                    "Identifier INTEGER, Reason INTEGER, Volume DOUBLE, PriceOpen DOUBLE, SL DOUBLE, TP DOUBLE, PriceCurrent DOUBLE, Swap DOUBLE, Profit DOUBLE, Symbol STRING, Comment STRING, ExternalID STRING );");

                db.Execute("CREATE TABLE IF NOT EXISTS HistoryDeals ( Ticket INTEGER PRIMARY KEY AUTOINCREMENT, OrderID INTEGER, Time INTEGER, TimeMsc INTEGER, Type INTEGER, Entry INTEGER, Magic INTEGER, Reason INTEGER," +
                    " PositionID INTEGER, Volume DOUBLE, Price DOUBLE, Commission DOUBLE, Swap DOUBLE, Profit DOUBLE, Fee DOUBLE, SL DOUBLE, TP DOUBLE, Symbol STRING, Comment STRING, ExternalID STRING );");

                db.Execute("CREATE TABLE IF NOT EXISTS OrderChanges ( Ticket INTEGER PRIMARY KEY AUTOINCREMENT, Time DATATIME, State INTEGER);");
                db.Execute("CREATE TRIGGER IF NOT EXISTS StateTrack AFTER UPDATE OF State ON Orders FOR EACH ROW BEGIN INSERT INTO OrderChanges (Ticket, Time, State ) VALUES (new.Ticket, time('now'), new.State ); END;");

                db.Execute("CREATE TRIGGER IF NOT EXISTS OrderActed AFTER UPDATE OF State ON Orders FOR EACH ROW WHEN(new.State >= 2 AND new.State <= 6) OR new.State == 9 " +
                    "BEGIN INSERT INTO HistoryOrders SELECT* FROM Orders WHERE Ticket = new.Ticket;DELETE FROM Orders WHERE Ticket = new.Ticket; END;");
            }

            return true;
        }


        private int GetRequestID() => ++_RequestID;


        /// <summary>
        /// API Version
        /// </summary>
        public string? Version => Marshal.PtrToStringAnsi(TdGetApiVersion());


        public void RegisterFront(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                throw new ArgumentException($"��{nameof(ip)}������Ϊ null ��հס�", nameof(ip));
            if (!Regex.IsMatch(ip, @"\w+://\d+.\d+.\d+.\d+(?:\:\d+)*") &&
                !Regex.IsMatch(ip, @"\w+://[a-zA-Z\d]+\:\:[a-zA-Z\d]+\:\:[a-zA-Z\d]+\:\:[a-zA-Z\d]+(?:\:\d+)*"))
                throw new ArgumentException($"��{nameof(ip)}����ʽ����ȷ", nameof(ip));

            TdRegisterFront(Handle, ip);
            IsFrontBlank = false;
        }


        /// <summary>
        /// ����ǰ�û�
        /// </summary> 
        /// <returns>
        /// </returns>
        public async Task<bool> ConnectFrontAsync(int timeout = 1000)
        {
            if (IsFrontBlank) return false;

            var sync = new AutoResetEvent(false);
            var callback = new OnFrontConnectedHandler(() => sync.Set());
            OnFrontConnected += callback;

            TdInit(Handle);
            //Task.Run(() => TdJoin(Handle));
            //TdJoin(Handle);

            var r = await Task.Run(() => sync.WaitOne(timeout));
            OnFrontConnected -= callback;
            sync.Close();
            return r;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="brokerid"></param>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<(bool IsSuccessed, CThostFtdcRspUserLoginField loginField, CThostFtdcRspInfoField response)> LoginAsync()
        {
            var param = new CThostFtdcReqUserLoginField() { BrokerID = Broker.ID, UserID = User, Password = Password };

            var sync = new AutoResetEvent(false);
            CThostFtdcRspUserLoginField pRspUserLogin = new CThostFtdcRspUserLoginField();
            CThostFtdcRspInfoField pRspInfo = new CThostFtdcRspInfoField();
            int nRequestID = 0;
            bool bIsLast = false;

            var callback = new OnRspUserLoginHandler((aa, bb, cc, dd) => { pRspUserLogin = aa; pRspInfo = bb; nRequestID = cc; bIsLast = dd; sync.Set(); });
            OnRspUserLogin += callback;

            int ret = TdReqUserLogin(Handle, param, 0);
            if (ret != 0)
                return (false, default, default);

            await Task.Run(() => sync.WaitOne());
            sync.Close();
            OnRspUserLogin -= callback;

            InvesterID = pRspUserLogin.UserID;
            return (true, pRspUserLogin, pRspInfo);
        }

        public async Task<CThostFtdcExchangeField[]> QueryExchangeAsync()
        {
            int rid = GetRequestID();
            var sync = new AutoResetEvent(false);
            var list = new List<CThostFtdcExchangeField>();

            var callback = new OnRspQryExchangeHandler((pExchange, pRspInfo, nRequestID, bIsLast) =>
            {
                if (nRequestID != rid) return;

                list.Add(pExchange);

                if (nRequestID == rid && bIsLast) sync.Set();
            });
            OnRspQryExchange += callback;
            TdReqQryExchange(Handle, new CThostFtdcQryExchangeField { }, rid);

            await Task.Run(() => sync.WaitOne());
            OnRspQryExchange -= callback;
            return list.ToArray();
        }

        public async Task<CThostFtdcInstrumentField[]> ReqQryInstrument()
        {
            int rid = GetRequestID();
            var sync = new AutoResetEvent(false);
            var list = new List<CThostFtdcInstrumentField>();

            var callback = new OnRspQryInstrumentHandler((pResult, pRspInfo, nRequestID, bIsLast) =>
            {
                if (nRequestID != rid) return;

                list.Add(pResult);

                if (nRequestID == rid && bIsLast) sync.Set();
            });
            OnRspQryInstrument += (a, b, c, d) => { sync.Set(); };


            TdReqQryInstrument(Handle, new CThostFtdcQryInstrumentField { }, rid);

            await Task.Run(() => sync.WaitOne());
            OnRspQryInstrument -= callback;
            return list.ToArray();
        }

        public async Task<bool> SendOrderAsync()
        {
            int rid = GetRequestID();
            var sync = new AutoResetEvent(false);
            var input = new CThostFtdcInputOrderField();
            input.BrokerID = Broker.ID;
            input.InvestorID = InvesterID;
            input.ExchangeID = "SHFE";
            input.InstrumentID = "au2206";
            input.OrderRef = TimeStamp.ToString();
            input.OrderPriceType = TThostFtdcOrderPriceTypeType.THOST_FTDC_OPT_AnyPrice;
            input.Direction = TThostFtdcDirectionType.THOST_FTDC_D_Buy;
            input.CombOffsetFlag = ((char)TThostFtdcOffsetFlagType.THOST_FTDC_OF_Open).ToString();
            input.CombHedgeFlag = ((char)TThostFtdcHedgeFlagType.THOST_FTDC_HF_Speculation).ToString();
            input.LimitPrice = 3000;
            input.VolumeTotalOriginal = 1;
            input.TimeCondition = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD;///������Ч
			input.VolumeCondition = TThostFtdcVolumeConditionType.THOST_FTDC_VC_AV;///��������
			input.MinVolume = 1;
            input.ContingentCondition = TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately;
            input.StopPrice = 0;
            input.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;
            input.IsAutoSuspend = 0;
            input.IsSwapOrder = 0;


            var callback = new OnRspOrderInsertHandler((pResult, pRspInfo, nRequestID, bIsLast) =>
            {
                if (nRequestID != rid) return;

                //EnumTThostFtdcOrderStatusType status = (EnumTThostFtdcOrderStatusType)pResult.OrderStatus;

                //���ɱ��ؼ�¼
                using (var db = NewMT5DbConnection())
                {
                    db.Execute("INSERT INTO Orders(ExternalID) VALUES(@eid)", new { eid = input.OrderRef });
                }

                if (nRequestID == rid && bIsLast) sync.Set();
            });
            var callback2 = new OnErrRtnOrderInsertHandler((pResult, pRspInfo) =>
            {
                //EnumTThostFtdcOrderStatusType status = (EnumTThostFtdcOrderStatusType)pResult.OrderStatus;

            });
            var callback3 = new OnRtnTradeHandler((pResult) =>
            {
                //EnumTThostFtdcOrderStatusType status = (EnumTThostFtdcOrderStatusType)pResult.OrderStatus;

            });
            var callback4 = new OnRtnOrderHandler((pResult) =>
            {
                MT5.Order order = pResult;

                //���ɱ��ؼ�¼

                using (var db = NewMT5DbConnection())
                {
                    switch (order.State)
                    {
                        case MT5.OrderState.Started:
                            db.Execute("INSERT INTO Orders(TimeSetup,Type,State,TimeExpiration,TimeSetupMsc,TypeFilling,TypeTime,Magic," +
                                        "Reason,VolumeInital,VolumeCurrent,PriceOpen,SL,TP,PriceCurrent,PriceStopLimit,Symbol,Comment,ExternalID)" +
                                        " VALUES(@TimeSetup,@Type,@State,@TimeExpiration,@TimeSetupMsc,@TypeFilling,@TypeTime,@Magic,@Reason," +
                                        "@VolumeInital,@VolumeCurrent,@PriceOpen,@SL,@TP,@PriceCurrent,@PriceStopLimit,@Symbol,@Comment,@ExternalID)", order);
                            break;
                        default:
                            db.Execute("UPDATE Orders SET State=@State WHERE ExternalID=@ExternalID;", order);
                            break; 
                    }

                }
            });
            OnRspOrderInsert += callback;
            OnErrRtnOrderInsert += callback2;
            OnRtnTrade += callback3;
            OnRtnOrder += callback4;



            TdReqOrderInsert(Handle, input, rid);


            await Task.Run(() => sync.WaitOne());
            OnRspOrderInsert -= callback;
            OnErrRtnOrderInsert -= callback2;
            OnRtnTrade -= callback3;
            OnRtnOrder -= callback4;
            return true;

        }


        /// <summary>
        /// ȷ�Ͻ����� 
        /// </summary>
        public async Task<bool> ConfirmSettlementInfo()
        {
            int rid = GetRequestID();
            var sync = new AutoResetEvent(false);
            bool success = false;
            var callback = new OnRspSettlementInfoConfirmHandler((pResult, pRspInfo, nRequestID, bIsLast) =>
            {
                if (nRequestID != rid) return;
                success = pRspInfo.ErrorID == 0;
                if (nRequestID == rid && bIsLast) sync.Set();
            });
            OnRspSettlementInfoConfirm += callback;

            var input = new CThostFtdcSettlementInfoConfirmField
            {
                BrokerID = Broker.ID,
                InvestorID = InvesterID
            };
            TdReqSettlementInfoConfirm(Handle, input, rid);

            await Task.Run(() => sync.WaitOne());
            OnRspSettlementInfoConfirm -= callback;

            return success;
        }










        /// <summary>
        /// �ͷ�
        /// </summary>
        public void Dispose()
        {
            TdRelease(Handle);
        }



























        #region �ص����
        void InitCallback()
        {
            TdSetOnFrontConnectedHandler(Handle, () => OnFrontConnected?.Invoke());
            TdSetOnFrontDisconnectedHandler(Handle, (nReason) => OnFrontDisconnected?.Invoke(nReason));
            TdSetOnHeartBeatWarningHandler(Handle, (nTimeLapse) => OnHeartBeatWarning?.Invoke(nTimeLapse));
            TdSetOnRspAuthenticateHandler(Handle, (pRspAuthenticateField, pRspInfo, nRequestID, bIsLast) => OnRspAuthenticate?.Invoke(pRspAuthenticateField, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspUserLoginHandler(Handle, (pRspUserLogin, pRspInfo, nRequestID, bIsLast) => OnRspUserLogin?.Invoke(pRspUserLogin, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspUserLogoutHandler(Handle, (pUserLogout, pRspInfo, nRequestID, bIsLast) => OnRspUserLogout?.Invoke(pUserLogout, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspUserPasswordUpdateHandler(Handle, (pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast) => OnRspUserPasswordUpdate?.Invoke(pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspTradingAccountPasswordUpdateHandler(Handle, (pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast) => OnRspTradingAccountPasswordUpdate?.Invoke(pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspUserAuthMethodHandler(Handle, (pRspUserAuthMethod, pRspInfo, nRequestID, bIsLast) => OnRspUserAuthMethod?.Invoke(pRspUserAuthMethod, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspGenUserCaptchaHandler(Handle, (pRspGenUserCaptcha, pRspInfo, nRequestID, bIsLast) => OnRspGenUserCaptcha?.Invoke(pRspGenUserCaptcha, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspGenUserTextHandler(Handle, (pRspGenUserText, pRspInfo, nRequestID, bIsLast) => OnRspGenUserText?.Invoke(pRspGenUserText, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspOrderInsertHandler(Handle, (pInputOrder, pRspInfo, nRequestID, bIsLast) => OnRspOrderInsert?.Invoke(pInputOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspParkedOrderInsertHandler(Handle, (pParkedOrder, pRspInfo, nRequestID, bIsLast) => OnRspParkedOrderInsert?.Invoke(pParkedOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspParkedOrderActionHandler(Handle, (pParkedOrderAction, pRspInfo, nRequestID, bIsLast) => OnRspParkedOrderAction?.Invoke(pParkedOrderAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspOrderActionHandler(Handle, (pInputOrderAction, pRspInfo, nRequestID, bIsLast) => OnRspOrderAction?.Invoke(pInputOrderAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryMaxOrderVolumeHandler(Handle, (pQryMaxOrderVolume, pRspInfo, nRequestID, bIsLast) => OnRspQryMaxOrderVolume?.Invoke(pQryMaxOrderVolume, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspSettlementInfoConfirmHandler(Handle, (pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast) => OnRspSettlementInfoConfirm?.Invoke(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspRemoveParkedOrderHandler(Handle, (pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast) => OnRspRemoveParkedOrder?.Invoke(pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspRemoveParkedOrderActionHandler(Handle, (pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast) => OnRspRemoveParkedOrderAction?.Invoke(pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspExecOrderInsertHandler(Handle, (pInputExecOrder, pRspInfo, nRequestID, bIsLast) => OnRspExecOrderInsert?.Invoke(pInputExecOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspExecOrderActionHandler(Handle, (pInputExecOrderAction, pRspInfo, nRequestID, bIsLast) => OnRspExecOrderAction?.Invoke(pInputExecOrderAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspForQuoteInsertHandler(Handle, (pInputForQuote, pRspInfo, nRequestID, bIsLast) => OnRspForQuoteInsert?.Invoke(pInputForQuote, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQuoteInsertHandler(Handle, (pInputQuote, pRspInfo, nRequestID, bIsLast) => OnRspQuoteInsert?.Invoke(pInputQuote, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQuoteActionHandler(Handle, (pInputQuoteAction, pRspInfo, nRequestID, bIsLast) => OnRspQuoteAction?.Invoke(pInputQuoteAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspBatchOrderActionHandler(Handle, (pInputBatchOrderAction, pRspInfo, nRequestID, bIsLast) => OnRspBatchOrderAction?.Invoke(pInputBatchOrderAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspOptionSelfCloseInsertHandler(Handle, (pInputOptionSelfClose, pRspInfo, nRequestID, bIsLast) => OnRspOptionSelfCloseInsert?.Invoke(pInputOptionSelfClose, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspOptionSelfCloseActionHandler(Handle, (pInputOptionSelfCloseAction, pRspInfo, nRequestID, bIsLast) => OnRspOptionSelfCloseAction?.Invoke(pInputOptionSelfCloseAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspCombActionInsertHandler(Handle, (pInputCombAction, pRspInfo, nRequestID, bIsLast) => OnRspCombActionInsert?.Invoke(pInputCombAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryOrderHandler(Handle, (pOrder, pRspInfo, nRequestID, bIsLast) => OnRspQryOrder?.Invoke(pOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTradeHandler(Handle, (pTrade, pRspInfo, nRequestID, bIsLast) => OnRspQryTrade?.Invoke(pTrade, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInvestorPositionHandler(Handle, (pInvestorPosition, pRspInfo, nRequestID, bIsLast) => OnRspQryInvestorPosition?.Invoke(pInvestorPosition, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTradingAccountHandler(Handle, (pTradingAccount, pRspInfo, nRequestID, bIsLast) => OnRspQryTradingAccount?.Invoke(pTradingAccount, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInvestorHandler(Handle, (pInvestor, pRspInfo, nRequestID, bIsLast) => OnRspQryInvestor?.Invoke(pInvestor, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTradingCodeHandler(Handle, (pTradingCode, pRspInfo, nRequestID, bIsLast) => OnRspQryTradingCode?.Invoke(pTradingCode, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInstrumentMarginRateHandler(Handle, (pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast) => OnRspQryInstrumentMarginRate?.Invoke(pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInstrumentCommissionRateHandler(Handle, (pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast) => OnRspQryInstrumentCommissionRate?.Invoke(pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryExchangeHandler(Handle, (pExchange, pRspInfo, nRequestID, bIsLast) => OnRspQryExchange?.Invoke(pExchange, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryProductHandler(Handle, (pProduct, pRspInfo, nRequestID, bIsLast) => OnRspQryProduct?.Invoke(pProduct, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInstrumentHandler(Handle, (pInstrument, pRspInfo, nRequestID, bIsLast) => OnRspQryInstrument?.Invoke(pInstrument, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryDepthMarketDataHandler(Handle, (pDepthMarketData, pRspInfo, nRequestID, bIsLast) => OnRspQryDepthMarketData?.Invoke(pDepthMarketData, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTraderOfferHandler(Handle, (pTraderOffer, pRspInfo, nRequestID, bIsLast) => OnRspQryTraderOffer?.Invoke(pTraderOffer, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQrySettlementInfoHandler(Handle, (pSettlementInfo, pRspInfo, nRequestID, bIsLast) => OnRspQrySettlementInfo?.Invoke(pSettlementInfo, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTransferBankHandler(Handle, (pTransferBank, pRspInfo, nRequestID, bIsLast) => OnRspQryTransferBank?.Invoke(pTransferBank, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInvestorPositionDetailHandler(Handle, (pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast) => OnRspQryInvestorPositionDetail?.Invoke(pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryNoticeHandler(Handle, (pNotice, pRspInfo, nRequestID, bIsLast) => OnRspQryNotice?.Invoke(pNotice, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQrySettlementInfoConfirmHandler(Handle, (pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast) => OnRspQrySettlementInfoConfirm?.Invoke(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInvestorPositionCombineDetailHandler(Handle, (pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast) => OnRspQryInvestorPositionCombineDetail?.Invoke(pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryCFMMCTradingAccountKeyHandler(Handle, (pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast) => OnRspQryCFMMCTradingAccountKey?.Invoke(pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryEWarrantOffsetHandler(Handle, (pEWarrantOffset, pRspInfo, nRequestID, bIsLast) => OnRspQryEWarrantOffset?.Invoke(pEWarrantOffset, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInvestorProductGroupMarginHandler(Handle, (pInvestorProductGroupMargin, pRspInfo, nRequestID, bIsLast) => OnRspQryInvestorProductGroupMargin?.Invoke(pInvestorProductGroupMargin, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryExchangeMarginRateHandler(Handle, (pExchangeMarginRate, pRspInfo, nRequestID, bIsLast) => OnRspQryExchangeMarginRate?.Invoke(pExchangeMarginRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryExchangeMarginRateAdjustHandler(Handle, (pExchangeMarginRateAdjust, pRspInfo, nRequestID, bIsLast) => OnRspQryExchangeMarginRateAdjust?.Invoke(pExchangeMarginRateAdjust, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryExchangeRateHandler(Handle, (pExchangeRate, pRspInfo, nRequestID, bIsLast) => OnRspQryExchangeRate?.Invoke(pExchangeRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQrySecAgentACIDMapHandler(Handle, (pSecAgentACIDMap, pRspInfo, nRequestID, bIsLast) => OnRspQrySecAgentACIDMap?.Invoke(pSecAgentACIDMap, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryProductExchRateHandler(Handle, (pProductExchRate, pRspInfo, nRequestID, bIsLast) => OnRspQryProductExchRate?.Invoke(pProductExchRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryProductGroupHandler(Handle, (pProductGroup, pRspInfo, nRequestID, bIsLast) => OnRspQryProductGroup?.Invoke(pProductGroup, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryMMInstrumentCommissionRateHandler(Handle, (pMMInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast) => OnRspQryMMInstrumentCommissionRate?.Invoke(pMMInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryMMOptionInstrCommRateHandler(Handle, (pMMOptionInstrCommRate, pRspInfo, nRequestID, bIsLast) => OnRspQryMMOptionInstrCommRate?.Invoke(pMMOptionInstrCommRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInstrumentOrderCommRateHandler(Handle, (pInstrumentOrderCommRate, pRspInfo, nRequestID, bIsLast) => OnRspQryInstrumentOrderCommRate?.Invoke(pInstrumentOrderCommRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQrySecAgentTradingAccountHandler(Handle, (pTradingAccount, pRspInfo, nRequestID, bIsLast) => OnRspQrySecAgentTradingAccount?.Invoke(pTradingAccount, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQrySecAgentCheckModeHandler(Handle, (pSecAgentCheckMode, pRspInfo, nRequestID, bIsLast) => OnRspQrySecAgentCheckMode?.Invoke(pSecAgentCheckMode, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQrySecAgentTradeInfoHandler(Handle, (pSecAgentTradeInfo, pRspInfo, nRequestID, bIsLast) => OnRspQrySecAgentTradeInfo?.Invoke(pSecAgentTradeInfo, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryOptionInstrTradeCostHandler(Handle, (pOptionInstrTradeCost, pRspInfo, nRequestID, bIsLast) => OnRspQryOptionInstrTradeCost?.Invoke(pOptionInstrTradeCost, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryOptionInstrCommRateHandler(Handle, (pOptionInstrCommRate, pRspInfo, nRequestID, bIsLast) => OnRspQryOptionInstrCommRate?.Invoke(pOptionInstrCommRate, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryExecOrderHandler(Handle, (pExecOrder, pRspInfo, nRequestID, bIsLast) => OnRspQryExecOrder?.Invoke(pExecOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryForQuoteHandler(Handle, (pForQuote, pRspInfo, nRequestID, bIsLast) => OnRspQryForQuote?.Invoke(pForQuote, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryQuoteHandler(Handle, (pQuote, pRspInfo, nRequestID, bIsLast) => OnRspQryQuote?.Invoke(pQuote, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryOptionSelfCloseHandler(Handle, (pOptionSelfClose, pRspInfo, nRequestID, bIsLast) => OnRspQryOptionSelfClose?.Invoke(pOptionSelfClose, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryInvestUnitHandler(Handle, (pInvestUnit, pRspInfo, nRequestID, bIsLast) => OnRspQryInvestUnit?.Invoke(pInvestUnit, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryCombInstrumentGuardHandler(Handle, (pCombInstrumentGuard, pRspInfo, nRequestID, bIsLast) => OnRspQryCombInstrumentGuard?.Invoke(pCombInstrumentGuard, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryCombActionHandler(Handle, (pCombAction, pRspInfo, nRequestID, bIsLast) => OnRspQryCombAction?.Invoke(pCombAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTransferSerialHandler(Handle, (pTransferSerial, pRspInfo, nRequestID, bIsLast) => OnRspQryTransferSerial?.Invoke(pTransferSerial, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryAccountregisterHandler(Handle, (pAccountregister, pRspInfo, nRequestID, bIsLast) => OnRspQryAccountregister?.Invoke(pAccountregister, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspErrorHandler(Handle, (pRspInfo, nRequestID, bIsLast) => OnRspError?.Invoke(pRspInfo, nRequestID, bIsLast));
            TdSetOnRtnOrderHandler(Handle, (pOrder) => OnRtnOrder?.Invoke(pOrder));
            TdSetOnRtnTradeHandler(Handle, (pTrade) => OnRtnTrade?.Invoke(pTrade));
            TdSetOnErrRtnOrderInsertHandler(Handle, (pInputOrder, pRspInfo) => OnErrRtnOrderInsert?.Invoke(pInputOrder, pRspInfo));
            TdSetOnErrRtnOrderActionHandler(Handle, (pOrderAction, pRspInfo) => OnErrRtnOrderAction?.Invoke(pOrderAction, pRspInfo));
            TdSetOnRtnInstrumentStatusHandler(Handle, (pInstrumentStatus) => OnRtnInstrumentStatus?.Invoke(pInstrumentStatus));
            TdSetOnRtnBulletinHandler(Handle, (pBulletin) => OnRtnBulletin?.Invoke(pBulletin));
            TdSetOnRtnTradingNoticeHandler(Handle, (pTradingNoticeInfo) => OnRtnTradingNotice?.Invoke(pTradingNoticeInfo));
            TdSetOnRtnErrorConditionalOrderHandler(Handle, (pErrorConditionalOrder) => OnRtnErrorConditionalOrder?.Invoke(pErrorConditionalOrder));
            TdSetOnRtnExecOrderHandler(Handle, (pExecOrder) => OnRtnExecOrder?.Invoke(pExecOrder));
            TdSetOnErrRtnExecOrderInsertHandler(Handle, (pInputExecOrder, pRspInfo) => OnErrRtnExecOrderInsert?.Invoke(pInputExecOrder, pRspInfo));
            TdSetOnErrRtnExecOrderActionHandler(Handle, (pExecOrderAction, pRspInfo) => OnErrRtnExecOrderAction?.Invoke(pExecOrderAction, pRspInfo));
            TdSetOnErrRtnForQuoteInsertHandler(Handle, (pInputForQuote, pRspInfo) => OnErrRtnForQuoteInsert?.Invoke(pInputForQuote, pRspInfo));
            TdSetOnRtnQuoteHandler(Handle, (pQuote) => OnRtnQuote?.Invoke(pQuote));
            TdSetOnErrRtnQuoteInsertHandler(Handle, (pInputQuote, pRspInfo) => OnErrRtnQuoteInsert?.Invoke(pInputQuote, pRspInfo));
            TdSetOnErrRtnQuoteActionHandler(Handle, (pQuoteAction, pRspInfo) => OnErrRtnQuoteAction?.Invoke(pQuoteAction, pRspInfo));
            TdSetOnRtnForQuoteRspHandler(Handle, (pForQuoteRsp) => OnRtnForQuoteRsp?.Invoke(pForQuoteRsp));
            TdSetOnRtnCFMMCTradingAccountTokenHandler(Handle, (pCFMMCTradingAccountToken) => OnRtnCFMMCTradingAccountToken?.Invoke(pCFMMCTradingAccountToken));
            TdSetOnErrRtnBatchOrderActionHandler(Handle, (pBatchOrderAction, pRspInfo) => OnErrRtnBatchOrderAction?.Invoke(pBatchOrderAction, pRspInfo));
            TdSetOnRtnOptionSelfCloseHandler(Handle, (pOptionSelfClose) => OnRtnOptionSelfClose?.Invoke(pOptionSelfClose));
            TdSetOnErrRtnOptionSelfCloseInsertHandler(Handle, (pInputOptionSelfClose, pRspInfo) => OnErrRtnOptionSelfCloseInsert?.Invoke(pInputOptionSelfClose, pRspInfo));
            TdSetOnErrRtnOptionSelfCloseActionHandler(Handle, (pOptionSelfCloseAction, pRspInfo) => OnErrRtnOptionSelfCloseAction?.Invoke(pOptionSelfCloseAction, pRspInfo));
            TdSetOnRtnCombActionHandler(Handle, (pCombAction) => OnRtnCombAction?.Invoke(pCombAction));
            TdSetOnErrRtnCombActionInsertHandler(Handle, (pInputCombAction, pRspInfo) => OnErrRtnCombActionInsert?.Invoke(pInputCombAction, pRspInfo));
            TdSetOnRspQryContractBankHandler(Handle, (pContractBank, pRspInfo, nRequestID, bIsLast) => OnRspQryContractBank?.Invoke(pContractBank, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryParkedOrderHandler(Handle, (pParkedOrder, pRspInfo, nRequestID, bIsLast) => OnRspQryParkedOrder?.Invoke(pParkedOrder, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryParkedOrderActionHandler(Handle, (pParkedOrderAction, pRspInfo, nRequestID, bIsLast) => OnRspQryParkedOrderAction?.Invoke(pParkedOrderAction, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryTradingNoticeHandler(Handle, (pTradingNotice, pRspInfo, nRequestID, bIsLast) => OnRspQryTradingNotice?.Invoke(pTradingNotice, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryBrokerTradingParamsHandler(Handle, (pBrokerTradingParams, pRspInfo, nRequestID, bIsLast) => OnRspQryBrokerTradingParams?.Invoke(pBrokerTradingParams, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryBrokerTradingAlgosHandler(Handle, (pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast) => OnRspQryBrokerTradingAlgos?.Invoke(pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQueryCFMMCTradingAccountTokenHandler(Handle, (pQueryCFMMCTradingAccountToken, pRspInfo, nRequestID, bIsLast) => OnRspQueryCFMMCTradingAccountToken?.Invoke(pQueryCFMMCTradingAccountToken, pRspInfo, nRequestID, bIsLast));
            TdSetOnRtnFromBankToFutureByBankHandler(Handle, (pRspTransfer) => OnRtnFromBankToFutureByBank?.Invoke(pRspTransfer));
            TdSetOnRtnFromFutureToBankByBankHandler(Handle, (pRspTransfer) => OnRtnFromFutureToBankByBank?.Invoke(pRspTransfer));
            TdSetOnRtnRepealFromBankToFutureByBankHandler(Handle, (pRspRepeal) => OnRtnRepealFromBankToFutureByBank?.Invoke(pRspRepeal));
            TdSetOnRtnRepealFromFutureToBankByBankHandler(Handle, (pRspRepeal) => OnRtnRepealFromFutureToBankByBank?.Invoke(pRspRepeal));
            TdSetOnRtnFromBankToFutureByFutureHandler(Handle, (pRspTransfer) => OnRtnFromBankToFutureByFuture?.Invoke(pRspTransfer));
            TdSetOnRtnFromFutureToBankByFutureHandler(Handle, (pRspTransfer) => OnRtnFromFutureToBankByFuture?.Invoke(pRspTransfer));
            TdSetOnRtnRepealFromBankToFutureByFutureManualHandler(Handle, (pRspRepeal) => OnRtnRepealFromBankToFutureByFutureManual?.Invoke(pRspRepeal));
            TdSetOnRtnRepealFromFutureToBankByFutureManualHandler(Handle, (pRspRepeal) => OnRtnRepealFromFutureToBankByFutureManual?.Invoke(pRspRepeal));
            TdSetOnRtnQueryBankBalanceByFutureHandler(Handle, (pNotifyQueryAccount) => OnRtnQueryBankBalanceByFuture?.Invoke(pNotifyQueryAccount));
            TdSetOnErrRtnBankToFutureByFutureHandler(Handle, (pReqTransfer, pRspInfo) => OnErrRtnBankToFutureByFuture?.Invoke(pReqTransfer, pRspInfo));
            TdSetOnErrRtnFutureToBankByFutureHandler(Handle, (pReqTransfer, pRspInfo) => OnErrRtnFutureToBankByFuture?.Invoke(pReqTransfer, pRspInfo));
            TdSetOnErrRtnRepealBankToFutureByFutureManualHandler(Handle, (pReqRepeal, pRspInfo) => OnErrRtnRepealBankToFutureByFutureManual?.Invoke(pReqRepeal, pRspInfo));
            TdSetOnErrRtnRepealFutureToBankByFutureManualHandler(Handle, (pReqRepeal, pRspInfo) => OnErrRtnRepealFutureToBankByFutureManual?.Invoke(pReqRepeal, pRspInfo));
            TdSetOnErrRtnQueryBankBalanceByFutureHandler(Handle, (pReqQueryAccount, pRspInfo) => OnErrRtnQueryBankBalanceByFuture?.Invoke(pReqQueryAccount, pRspInfo));
            TdSetOnRtnRepealFromBankToFutureByFutureHandler(Handle, (pRspRepeal) => OnRtnRepealFromBankToFutureByFuture?.Invoke(pRspRepeal));
            TdSetOnRtnRepealFromFutureToBankByFutureHandler(Handle, (pRspRepeal) => OnRtnRepealFromFutureToBankByFuture?.Invoke(pRspRepeal));
            TdSetOnRspFromBankToFutureByFutureHandler(Handle, (pReqTransfer, pRspInfo, nRequestID, bIsLast) => OnRspFromBankToFutureByFuture?.Invoke(pReqTransfer, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspFromFutureToBankByFutureHandler(Handle, (pReqTransfer, pRspInfo, nRequestID, bIsLast) => OnRspFromFutureToBankByFuture?.Invoke(pReqTransfer, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQueryBankAccountMoneyByFutureHandler(Handle, (pReqQueryAccount, pRspInfo, nRequestID, bIsLast) => OnRspQueryBankAccountMoneyByFuture?.Invoke(pReqQueryAccount, pRspInfo, nRequestID, bIsLast));
            TdSetOnRtnOpenAccountByBankHandler(Handle, (pOpenAccount) => OnRtnOpenAccountByBank?.Invoke(pOpenAccount));
            TdSetOnRtnCancelAccountByBankHandler(Handle, (pCancelAccount) => OnRtnCancelAccountByBank?.Invoke(pCancelAccount));
            TdSetOnRtnChangeAccountByBankHandler(Handle, (pChangeAccount) => OnRtnChangeAccountByBank?.Invoke(pChangeAccount));
            TdSetOnRspQryClassifiedInstrumentHandler(Handle, (pInstrument, pRspInfo, nRequestID, bIsLast) => OnRspQryClassifiedInstrument?.Invoke(pInstrument, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryCombPromotionParamHandler(Handle, (pCombPromotionParam, pRspInfo, nRequestID, bIsLast) => OnRspQryCombPromotionParam?.Invoke(pCombPromotionParam, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryRiskSettleInvstPositionHandler(Handle, (pRiskSettleInvstPosition, pRspInfo, nRequestID, bIsLast) => OnRspQryRiskSettleInvstPosition?.Invoke(pRiskSettleInvstPosition, pRspInfo, nRequestID, bIsLast));
            TdSetOnRspQryRiskSettleProductStatusHandler(Handle, (pRiskSettleProductStatus, pRspInfo, nRequestID, bIsLast) => OnRspQryRiskSettleProductStatus?.Invoke(pRiskSettleProductStatus, pRspInfo, nRequestID, bIsLast));
        }


        ///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnFrontConnectedHandler();
        public event OnFrontConnectedHandler OnFrontConnected;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnFrontConnectedHandler(IntPtr spi, OnFrontConnectedHandler handler);


        ///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
        ///@param nReason ����ԭ��
        ///        0x1001 �����ʧ��
        ///        0x1002 ����дʧ��
        ///        0x2001 ����������ʱ
        ///        0x2002 ��������ʧ��
        ///        0x2003 �յ�������
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnFrontDisconnectedHandler(int nReason);
        public event OnFrontDisconnectedHandler OnFrontDisconnected;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnFrontDisconnectedHandler(IntPtr spi, OnFrontDisconnectedHandler handler);


        ///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
        ///@param nTimeLapse �����ϴν��ձ��ĵ�ʱ��
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnHeartBeatWarningHandler(int nTimeLapse);
        public event OnHeartBeatWarningHandler OnHeartBeatWarning;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnHeartBeatWarningHandler(IntPtr spi, OnHeartBeatWarningHandler handler);


        ///�ͻ�����֤��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspAuthenticateHandler(CThostFtdcRspAuthenticateField pRspAuthenticateField, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspAuthenticateHandler OnRspAuthenticate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspAuthenticateHandler(IntPtr spi, OnRspAuthenticateHandler handler);


        ///��¼������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspUserLoginHandler(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspUserLoginHandler OnRspUserLogin;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspUserLoginHandler(IntPtr spi, OnRspUserLoginHandler handler);


        ///�ǳ�������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspUserLogoutHandler(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspUserLogoutHandler OnRspUserLogout;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspUserLogoutHandler(IntPtr spi, OnRspUserLogoutHandler handler);


        ///�û��������������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspUserPasswordUpdateHandler(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspUserPasswordUpdateHandler OnRspUserPasswordUpdate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspUserPasswordUpdateHandler(IntPtr spi, OnRspUserPasswordUpdateHandler handler);


        ///�ʽ��˻��������������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspTradingAccountPasswordUpdateHandler(CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspTradingAccountPasswordUpdateHandler OnRspTradingAccountPasswordUpdate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspTradingAccountPasswordUpdateHandler(IntPtr spi, OnRspTradingAccountPasswordUpdateHandler handler);


        ///��ѯ�û���ǰ֧�ֵ���֤ģʽ�Ļظ�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspUserAuthMethodHandler(CThostFtdcRspUserAuthMethodField pRspUserAuthMethod, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspUserAuthMethodHandler OnRspUserAuthMethod;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspUserAuthMethodHandler(IntPtr spi, OnRspUserAuthMethodHandler handler);


        ///��ȡͼ����֤������Ļظ�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspGenUserCaptchaHandler(CThostFtdcRspGenUserCaptchaField pRspGenUserCaptcha, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspGenUserCaptchaHandler OnRspGenUserCaptcha;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspGenUserCaptchaHandler(IntPtr spi, OnRspGenUserCaptchaHandler handler);


        ///��ȡ������֤������Ļظ�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspGenUserTextHandler(CThostFtdcRspGenUserTextField pRspGenUserText, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspGenUserTextHandler OnRspGenUserText;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspGenUserTextHandler(IntPtr spi, OnRspGenUserTextHandler handler);


        ///����¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspOrderInsertHandler(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspOrderInsertHandler OnRspOrderInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspOrderInsertHandler(IntPtr spi, OnRspOrderInsertHandler handler);


        ///Ԥ��¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspParkedOrderInsertHandler(CThostFtdcParkedOrderField pParkedOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspParkedOrderInsertHandler OnRspParkedOrderInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspParkedOrderInsertHandler(IntPtr spi, OnRspParkedOrderInsertHandler handler);


        ///Ԥ�񳷵�¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspParkedOrderActionHandler(CThostFtdcParkedOrderActionField pParkedOrderAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspParkedOrderActionHandler OnRspParkedOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspParkedOrderActionHandler(IntPtr spi, OnRspParkedOrderActionHandler handler);


        ///��������������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspOrderActionHandler(CThostFtdcInputOrderActionField pInputOrderAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspOrderActionHandler OnRspOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspOrderActionHandler(IntPtr spi, OnRspOrderActionHandler handler);


        ///��ѯ��󱨵�������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryMaxOrderVolumeHandler(CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryMaxOrderVolumeHandler OnRspQryMaxOrderVolume;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryMaxOrderVolumeHandler(IntPtr spi, OnRspQryMaxOrderVolumeHandler handler);


        ///Ͷ���߽�����ȷ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspSettlementInfoConfirmHandler(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspSettlementInfoConfirmHandler OnRspSettlementInfoConfirm;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspSettlementInfoConfirmHandler(IntPtr spi, OnRspSettlementInfoConfirmHandler handler);


        ///ɾ��Ԥ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspRemoveParkedOrderHandler(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspRemoveParkedOrderHandler OnRspRemoveParkedOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspRemoveParkedOrderHandler(IntPtr spi, OnRspRemoveParkedOrderHandler handler);


        ///ɾ��Ԥ�񳷵���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspRemoveParkedOrderActionHandler(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspRemoveParkedOrderActionHandler OnRspRemoveParkedOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspRemoveParkedOrderActionHandler(IntPtr spi, OnRspRemoveParkedOrderActionHandler handler);


        ///ִ������¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspExecOrderInsertHandler(CThostFtdcInputExecOrderField pInputExecOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspExecOrderInsertHandler OnRspExecOrderInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspExecOrderInsertHandler(IntPtr spi, OnRspExecOrderInsertHandler handler);


        ///ִ���������������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspExecOrderActionHandler(CThostFtdcInputExecOrderActionField pInputExecOrderAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspExecOrderActionHandler OnRspExecOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspExecOrderActionHandler(IntPtr spi, OnRspExecOrderActionHandler handler);


        ///ѯ��¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspForQuoteInsertHandler(CThostFtdcInputForQuoteField pInputForQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspForQuoteInsertHandler OnRspForQuoteInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspForQuoteInsertHandler(IntPtr spi, OnRspForQuoteInsertHandler handler);


        ///����¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQuoteInsertHandler(CThostFtdcInputQuoteField pInputQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQuoteInsertHandler OnRspQuoteInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQuoteInsertHandler(IntPtr spi, OnRspQuoteInsertHandler handler);


        ///���۲���������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQuoteActionHandler(CThostFtdcInputQuoteActionField pInputQuoteAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQuoteActionHandler OnRspQuoteAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQuoteActionHandler(IntPtr spi, OnRspQuoteActionHandler handler);


        ///������������������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspBatchOrderActionHandler(CThostFtdcInputBatchOrderActionField pInputBatchOrderAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspBatchOrderActionHandler OnRspBatchOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspBatchOrderActionHandler(IntPtr spi, OnRspBatchOrderActionHandler handler);


        ///��Ȩ�ԶԳ�¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspOptionSelfCloseInsertHandler(CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspOptionSelfCloseInsertHandler OnRspOptionSelfCloseInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspOptionSelfCloseInsertHandler(IntPtr spi, OnRspOptionSelfCloseInsertHandler handler);


        ///��Ȩ�ԶԳ����������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspOptionSelfCloseActionHandler(CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspOptionSelfCloseActionHandler OnRspOptionSelfCloseAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspOptionSelfCloseActionHandler(IntPtr spi, OnRspOptionSelfCloseActionHandler handler);


        ///�������¼��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspCombActionInsertHandler(CThostFtdcInputCombActionField pInputCombAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspCombActionInsertHandler OnRspCombActionInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspCombActionInsertHandler(IntPtr spi, OnRspCombActionInsertHandler handler);


        ///�����ѯ������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryOrderHandler(CThostFtdcOrderField pOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryOrderHandler OnRspQryOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryOrderHandler(IntPtr spi, OnRspQryOrderHandler handler);


        ///�����ѯ�ɽ���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTradeHandler(CThostFtdcTradeField pTrade, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTradeHandler OnRspQryTrade;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTradeHandler(IntPtr spi, OnRspQryTradeHandler handler);


        ///�����ѯͶ���ֲ߳���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInvestorPositionHandler(CThostFtdcInvestorPositionField pInvestorPosition, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInvestorPositionHandler OnRspQryInvestorPosition;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInvestorPositionHandler(IntPtr spi, OnRspQryInvestorPositionHandler handler);


        ///�����ѯ�ʽ��˻���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTradingAccountHandler(CThostFtdcTradingAccountField pTradingAccount, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTradingAccountHandler OnRspQryTradingAccount;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTradingAccountHandler(IntPtr spi, OnRspQryTradingAccountHandler handler);


        ///�����ѯͶ������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInvestorHandler(CThostFtdcInvestorField pInvestor, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInvestorHandler OnRspQryInvestor;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInvestorHandler(IntPtr spi, OnRspQryInvestorHandler handler);


        ///�����ѯ���ױ�����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTradingCodeHandler(CThostFtdcTradingCodeField pTradingCode, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTradingCodeHandler OnRspQryTradingCode;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTradingCodeHandler(IntPtr spi, OnRspQryTradingCodeHandler handler);


        ///�����ѯ��Լ��֤������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInstrumentMarginRateHandler(CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInstrumentMarginRateHandler OnRspQryInstrumentMarginRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInstrumentMarginRateHandler(IntPtr spi, OnRspQryInstrumentMarginRateHandler handler);


        ///�����ѯ��Լ����������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInstrumentCommissionRateHandler(CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInstrumentCommissionRateHandler OnRspQryInstrumentCommissionRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInstrumentCommissionRateHandler(IntPtr spi, OnRspQryInstrumentCommissionRateHandler handler);


        ///�����ѯ��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryExchangeHandler(CThostFtdcExchangeField pExchange, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryExchangeHandler OnRspQryExchange;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryExchangeHandler(IntPtr spi, OnRspQryExchangeHandler handler);


        ///�����ѯ��Ʒ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryProductHandler(CThostFtdcProductField pProduct, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryProductHandler OnRspQryProduct;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryProductHandler(IntPtr spi, OnRspQryProductHandler handler);


        ///�����ѯ��Լ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInstrumentHandler(CThostFtdcInstrumentField pInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInstrumentHandler OnRspQryInstrument;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInstrumentHandler(IntPtr spi, OnRspQryInstrumentHandler handler);


        ///�����ѯ������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryDepthMarketDataHandler(CThostFtdcDepthMarketDataField pDepthMarketData, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryDepthMarketDataHandler OnRspQryDepthMarketData;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryDepthMarketDataHandler(IntPtr spi, OnRspQryDepthMarketDataHandler handler);


        ///�����ѯ����Ա���̻���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTraderOfferHandler(CThostFtdcTraderOfferField pTraderOffer, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTraderOfferHandler OnRspQryTraderOffer;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTraderOfferHandler(IntPtr spi, OnRspQryTraderOfferHandler handler);


        ///�����ѯͶ���߽�������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQrySettlementInfoHandler(CThostFtdcSettlementInfoField pSettlementInfo, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQrySettlementInfoHandler OnRspQrySettlementInfo;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQrySettlementInfoHandler(IntPtr spi, OnRspQrySettlementInfoHandler handler);


        ///�����ѯת��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTransferBankHandler(CThostFtdcTransferBankField pTransferBank, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTransferBankHandler OnRspQryTransferBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTransferBankHandler(IntPtr spi, OnRspQryTransferBankHandler handler);


        ///�����ѯͶ���ֲ߳���ϸ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInvestorPositionDetailHandler(CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInvestorPositionDetailHandler OnRspQryInvestorPositionDetail;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInvestorPositionDetailHandler(IntPtr spi, OnRspQryInvestorPositionDetailHandler handler);


        ///�����ѯ�ͻ�֪ͨ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryNoticeHandler(CThostFtdcNoticeField pNotice, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryNoticeHandler OnRspQryNotice;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryNoticeHandler(IntPtr spi, OnRspQryNoticeHandler handler);


        ///�����ѯ������Ϣȷ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQrySettlementInfoConfirmHandler(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQrySettlementInfoConfirmHandler OnRspQrySettlementInfoConfirm;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQrySettlementInfoConfirmHandler(IntPtr spi, OnRspQrySettlementInfoConfirmHandler handler);


        ///�����ѯͶ���ֲ߳���ϸ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInvestorPositionCombineDetailHandler(CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInvestorPositionCombineDetailHandler OnRspQryInvestorPositionCombineDetail;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInvestorPositionCombineDetailHandler(IntPtr spi, OnRspQryInvestorPositionCombineDetailHandler handler);


        ///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryCFMMCTradingAccountKeyHandler(CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryCFMMCTradingAccountKeyHandler OnRspQryCFMMCTradingAccountKey;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryCFMMCTradingAccountKeyHandler(IntPtr spi, OnRspQryCFMMCTradingAccountKeyHandler handler);


        ///�����ѯ�ֵ��۵���Ϣ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryEWarrantOffsetHandler(CThostFtdcEWarrantOffsetField pEWarrantOffset, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryEWarrantOffsetHandler OnRspQryEWarrantOffset;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryEWarrantOffsetHandler(IntPtr spi, OnRspQryEWarrantOffsetHandler handler);


        ///�����ѯͶ����Ʒ��/��Ʒ�ֱ�֤����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInvestorProductGroupMarginHandler(CThostFtdcInvestorProductGroupMarginField pInvestorProductGroupMargin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInvestorProductGroupMarginHandler OnRspQryInvestorProductGroupMargin;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInvestorProductGroupMarginHandler(IntPtr spi, OnRspQryInvestorProductGroupMarginHandler handler);


        ///�����ѯ��������֤������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryExchangeMarginRateHandler(CThostFtdcExchangeMarginRateField pExchangeMarginRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryExchangeMarginRateHandler OnRspQryExchangeMarginRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryExchangeMarginRateHandler(IntPtr spi, OnRspQryExchangeMarginRateHandler handler);


        ///�����ѯ������������֤������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryExchangeMarginRateAdjustHandler(CThostFtdcExchangeMarginRateAdjustField pExchangeMarginRateAdjust, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryExchangeMarginRateAdjustHandler OnRspQryExchangeMarginRateAdjust;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryExchangeMarginRateAdjustHandler(IntPtr spi, OnRspQryExchangeMarginRateAdjustHandler handler);


        ///�����ѯ������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryExchangeRateHandler(CThostFtdcExchangeRateField pExchangeRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryExchangeRateHandler OnRspQryExchangeRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryExchangeRateHandler(IntPtr spi, OnRspQryExchangeRateHandler handler);


        ///�����ѯ�����������Ա����Ȩ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQrySecAgentACIDMapHandler(CThostFtdcSecAgentACIDMapField pSecAgentACIDMap, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQrySecAgentACIDMapHandler OnRspQrySecAgentACIDMap;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQrySecAgentACIDMapHandler(IntPtr spi, OnRspQrySecAgentACIDMapHandler handler);


        ///�����ѯ��Ʒ���ۻ���
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryProductExchRateHandler(CThostFtdcProductExchRateField pProductExchRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryProductExchRateHandler OnRspQryProductExchRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryProductExchRateHandler(IntPtr spi, OnRspQryProductExchRateHandler handler);


        ///�����ѯ��Ʒ��
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryProductGroupHandler(CThostFtdcProductGroupField pProductGroup, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryProductGroupHandler OnRspQryProductGroup;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryProductGroupHandler(IntPtr spi, OnRspQryProductGroupHandler handler);


        ///�����ѯ�����̺�Լ����������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryMMInstrumentCommissionRateHandler(CThostFtdcMMInstrumentCommissionRateField pMMInstrumentCommissionRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryMMInstrumentCommissionRateHandler OnRspQryMMInstrumentCommissionRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryMMInstrumentCommissionRateHandler(IntPtr spi, OnRspQryMMInstrumentCommissionRateHandler handler);


        ///�����ѯ��������Ȩ��Լ��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryMMOptionInstrCommRateHandler(CThostFtdcMMOptionInstrCommRateField pMMOptionInstrCommRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryMMOptionInstrCommRateHandler OnRspQryMMOptionInstrCommRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryMMOptionInstrCommRateHandler(IntPtr spi, OnRspQryMMOptionInstrCommRateHandler handler);


        ///�����ѯ������������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInstrumentOrderCommRateHandler(CThostFtdcInstrumentOrderCommRateField pInstrumentOrderCommRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInstrumentOrderCommRateHandler OnRspQryInstrumentOrderCommRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInstrumentOrderCommRateHandler(IntPtr spi, OnRspQryInstrumentOrderCommRateHandler handler);


        ///�����ѯ�ʽ��˻���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQrySecAgentTradingAccountHandler(CThostFtdcTradingAccountField pTradingAccount, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQrySecAgentTradingAccountHandler OnRspQrySecAgentTradingAccount;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQrySecAgentTradingAccountHandler(IntPtr spi, OnRspQrySecAgentTradingAccountHandler handler);


        ///�����ѯ�����������ʽ�У��ģʽ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQrySecAgentCheckModeHandler(CThostFtdcSecAgentCheckModeField pSecAgentCheckMode, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQrySecAgentCheckModeHandler OnRspQrySecAgentCheckMode;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQrySecAgentCheckModeHandler(IntPtr spi, OnRspQrySecAgentCheckModeHandler handler);


        ///�����ѯ������������Ϣ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQrySecAgentTradeInfoHandler(CThostFtdcSecAgentTradeInfoField pSecAgentTradeInfo, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQrySecAgentTradeInfoHandler OnRspQrySecAgentTradeInfo;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQrySecAgentTradeInfoHandler(IntPtr spi, OnRspQrySecAgentTradeInfoHandler handler);


        ///�����ѯ��Ȩ���׳ɱ���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryOptionInstrTradeCostHandler(CThostFtdcOptionInstrTradeCostField pOptionInstrTradeCost, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryOptionInstrTradeCostHandler OnRspQryOptionInstrTradeCost;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryOptionInstrTradeCostHandler(IntPtr spi, OnRspQryOptionInstrTradeCostHandler handler);


        ///�����ѯ��Ȩ��Լ��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryOptionInstrCommRateHandler(CThostFtdcOptionInstrCommRateField pOptionInstrCommRate, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryOptionInstrCommRateHandler OnRspQryOptionInstrCommRate;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryOptionInstrCommRateHandler(IntPtr spi, OnRspQryOptionInstrCommRateHandler handler);


        ///�����ѯִ��������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryExecOrderHandler(CThostFtdcExecOrderField pExecOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryExecOrderHandler OnRspQryExecOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryExecOrderHandler(IntPtr spi, OnRspQryExecOrderHandler handler);


        ///�����ѯѯ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryForQuoteHandler(CThostFtdcForQuoteField pForQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryForQuoteHandler OnRspQryForQuote;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryForQuoteHandler(IntPtr spi, OnRspQryForQuoteHandler handler);


        ///�����ѯ������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryQuoteHandler(CThostFtdcQuoteField pQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryQuoteHandler OnRspQryQuote;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryQuoteHandler(IntPtr spi, OnRspQryQuoteHandler handler);


        ///�����ѯ��Ȩ�ԶԳ���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryOptionSelfCloseHandler(CThostFtdcOptionSelfCloseField pOptionSelfClose, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryOptionSelfCloseHandler OnRspQryOptionSelfClose;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryOptionSelfCloseHandler(IntPtr spi, OnRspQryOptionSelfCloseHandler handler);


        ///�����ѯͶ�ʵ�Ԫ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryInvestUnitHandler(CThostFtdcInvestUnitField pInvestUnit, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryInvestUnitHandler OnRspQryInvestUnit;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryInvestUnitHandler(IntPtr spi, OnRspQryInvestUnitHandler handler);


        ///�����ѯ��Ϻ�Լ��ȫϵ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryCombInstrumentGuardHandler(CThostFtdcCombInstrumentGuardField pCombInstrumentGuard, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryCombInstrumentGuardHandler OnRspQryCombInstrumentGuard;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryCombInstrumentGuardHandler(IntPtr spi, OnRspQryCombInstrumentGuardHandler handler);


        ///�����ѯ���������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryCombActionHandler(CThostFtdcCombActionField pCombAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryCombActionHandler OnRspQryCombAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryCombActionHandler(IntPtr spi, OnRspQryCombActionHandler handler);


        ///�����ѯת����ˮ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTransferSerialHandler(CThostFtdcTransferSerialField pTransferSerial, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTransferSerialHandler OnRspQryTransferSerial;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTransferSerialHandler(IntPtr spi, OnRspQryTransferSerialHandler handler);


        ///�����ѯ����ǩԼ��ϵ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryAccountregisterHandler(CThostFtdcAccountregisterField pAccountregister, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryAccountregisterHandler OnRspQryAccountregister;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryAccountregisterHandler(IntPtr spi, OnRspQryAccountregisterHandler handler);


        ///����Ӧ��
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspErrorHandler(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspErrorHandler OnRspError;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspErrorHandler(IntPtr spi, OnRspErrorHandler handler);


        ///����֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnOrderHandler(CThostFtdcOrderField pOrder);
        public event OnRtnOrderHandler OnRtnOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnOrderHandler(IntPtr spi, OnRtnOrderHandler handler);


        ///�ɽ�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnTradeHandler(CThostFtdcTradeField pTrade);
        public event OnRtnTradeHandler OnRtnTrade;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnTradeHandler(IntPtr spi, OnRtnTradeHandler handler);


        ///����¼�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnOrderInsertHandler(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnOrderInsertHandler OnErrRtnOrderInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnOrderInsertHandler(IntPtr spi, OnErrRtnOrderInsertHandler handler);


        ///������������ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnOrderActionHandler(CThostFtdcOrderActionField pOrderAction, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnOrderActionHandler OnErrRtnOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnOrderActionHandler(IntPtr spi, OnErrRtnOrderActionHandler handler);


        ///��Լ����״̬֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnInstrumentStatusHandler(CThostFtdcInstrumentStatusField pInstrumentStatus);
        public event OnRtnInstrumentStatusHandler OnRtnInstrumentStatus;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnInstrumentStatusHandler(IntPtr spi, OnRtnInstrumentStatusHandler handler);


        ///����������֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnBulletinHandler(CThostFtdcBulletinField pBulletin);
        public event OnRtnBulletinHandler OnRtnBulletin;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnBulletinHandler(IntPtr spi, OnRtnBulletinHandler handler);


        ///����֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnTradingNoticeHandler(CThostFtdcTradingNoticeInfoField pTradingNoticeInfo);
        public event OnRtnTradingNoticeHandler OnRtnTradingNotice;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnTradingNoticeHandler(IntPtr spi, OnRtnTradingNoticeHandler handler);


        ///��ʾ������У�����
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnErrorConditionalOrderHandler(CThostFtdcErrorConditionalOrderField pErrorConditionalOrder);
        public event OnRtnErrorConditionalOrderHandler OnRtnErrorConditionalOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnErrorConditionalOrderHandler(IntPtr spi, OnRtnErrorConditionalOrderHandler handler);


        ///ִ������֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnExecOrderHandler(CThostFtdcExecOrderField pExecOrder);
        public event OnRtnExecOrderHandler OnRtnExecOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnExecOrderHandler(IntPtr spi, OnRtnExecOrderHandler handler);


        ///ִ������¼�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnExecOrderInsertHandler(CThostFtdcInputExecOrderField pInputExecOrder, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnExecOrderInsertHandler OnErrRtnExecOrderInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnExecOrderInsertHandler(IntPtr spi, OnErrRtnExecOrderInsertHandler handler);


        ///ִ�������������ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnExecOrderActionHandler(CThostFtdcExecOrderActionField pExecOrderAction, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnExecOrderActionHandler OnErrRtnExecOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnExecOrderActionHandler(IntPtr spi, OnErrRtnExecOrderActionHandler handler);


        ///ѯ��¼�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnForQuoteInsertHandler(CThostFtdcInputForQuoteField pInputForQuote, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnForQuoteInsertHandler OnErrRtnForQuoteInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnForQuoteInsertHandler(IntPtr spi, OnErrRtnForQuoteInsertHandler handler);


        ///����֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnQuoteHandler(CThostFtdcQuoteField pQuote);
        public event OnRtnQuoteHandler OnRtnQuote;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnQuoteHandler(IntPtr spi, OnRtnQuoteHandler handler);


        ///����¼�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnQuoteInsertHandler(CThostFtdcInputQuoteField pInputQuote, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnQuoteInsertHandler OnErrRtnQuoteInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnQuoteInsertHandler(IntPtr spi, OnErrRtnQuoteInsertHandler handler);


        ///���۲�������ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnQuoteActionHandler(CThostFtdcQuoteActionField pQuoteAction, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnQuoteActionHandler OnErrRtnQuoteAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnQuoteActionHandler(IntPtr spi, OnErrRtnQuoteActionHandler handler);


        ///ѯ��֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnForQuoteRspHandler(CThostFtdcForQuoteRspField pForQuoteRsp);
        public event OnRtnForQuoteRspHandler OnRtnForQuoteRsp;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnForQuoteRspHandler(IntPtr spi, OnRtnForQuoteRspHandler handler);


        ///��֤���������û�����
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnCFMMCTradingAccountTokenHandler(CThostFtdcCFMMCTradingAccountTokenField pCFMMCTradingAccountToken);
        public event OnRtnCFMMCTradingAccountTokenHandler OnRtnCFMMCTradingAccountToken;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnCFMMCTradingAccountTokenHandler(IntPtr spi, OnRtnCFMMCTradingAccountTokenHandler handler);


        ///����������������ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnBatchOrderActionHandler(CThostFtdcBatchOrderActionField pBatchOrderAction, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnBatchOrderActionHandler OnErrRtnBatchOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnBatchOrderActionHandler(IntPtr spi, OnErrRtnBatchOrderActionHandler handler);


        ///��Ȩ�ԶԳ�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnOptionSelfCloseHandler(CThostFtdcOptionSelfCloseField pOptionSelfClose);
        public event OnRtnOptionSelfCloseHandler OnRtnOptionSelfClose;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnOptionSelfCloseHandler(IntPtr spi, OnRtnOptionSelfCloseHandler handler);


        ///��Ȩ�ԶԳ�¼�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnOptionSelfCloseInsertHandler(CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnOptionSelfCloseInsertHandler OnErrRtnOptionSelfCloseInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnOptionSelfCloseInsertHandler(IntPtr spi, OnErrRtnOptionSelfCloseInsertHandler handler);


        ///��Ȩ�ԶԳ��������ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnOptionSelfCloseActionHandler(CThostFtdcOptionSelfCloseActionField pOptionSelfCloseAction, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnOptionSelfCloseActionHandler OnErrRtnOptionSelfCloseAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnOptionSelfCloseActionHandler(IntPtr spi, OnErrRtnOptionSelfCloseActionHandler handler);


        ///�������֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnCombActionHandler(CThostFtdcCombActionField pCombAction);
        public event OnRtnCombActionHandler OnRtnCombAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnCombActionHandler(IntPtr spi, OnRtnCombActionHandler handler);


        ///�������¼�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnCombActionInsertHandler(CThostFtdcInputCombActionField pInputCombAction, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnCombActionInsertHandler OnErrRtnCombActionInsert;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnCombActionInsertHandler(IntPtr spi, OnErrRtnCombActionInsertHandler handler);


        ///�����ѯǩԼ������Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryContractBankHandler(CThostFtdcContractBankField pContractBank, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryContractBankHandler OnRspQryContractBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryContractBankHandler(IntPtr spi, OnRspQryContractBankHandler handler);


        ///�����ѯԤ����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryParkedOrderHandler(CThostFtdcParkedOrderField pParkedOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryParkedOrderHandler OnRspQryParkedOrder;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryParkedOrderHandler(IntPtr spi, OnRspQryParkedOrderHandler handler);


        ///�����ѯԤ�񳷵���Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryParkedOrderActionHandler(CThostFtdcParkedOrderActionField pParkedOrderAction, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryParkedOrderActionHandler OnRspQryParkedOrderAction;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryParkedOrderActionHandler(IntPtr spi, OnRspQryParkedOrderActionHandler handler);


        ///�����ѯ����֪ͨ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryTradingNoticeHandler(CThostFtdcTradingNoticeField pTradingNotice, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryTradingNoticeHandler OnRspQryTradingNotice;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryTradingNoticeHandler(IntPtr spi, OnRspQryTradingNoticeHandler handler);


        ///�����ѯ���͹�˾���ײ�����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryBrokerTradingParamsHandler(CThostFtdcBrokerTradingParamsField pBrokerTradingParams, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryBrokerTradingParamsHandler OnRspQryBrokerTradingParams;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryBrokerTradingParamsHandler(IntPtr spi, OnRspQryBrokerTradingParamsHandler handler);


        ///�����ѯ���͹�˾�����㷨��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryBrokerTradingAlgosHandler(CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryBrokerTradingAlgosHandler OnRspQryBrokerTradingAlgos;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryBrokerTradingAlgosHandler(IntPtr spi, OnRspQryBrokerTradingAlgosHandler handler);


        ///�����ѯ��������û�����
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQueryCFMMCTradingAccountTokenHandler(CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQueryCFMMCTradingAccountTokenHandler OnRspQueryCFMMCTradingAccountToken;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQueryCFMMCTradingAccountTokenHandler(IntPtr spi, OnRspQueryCFMMCTradingAccountTokenHandler handler);


        ///���з��������ʽ�ת�ڻ�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnFromBankToFutureByBankHandler(CThostFtdcRspTransferField pRspTransfer);
        public event OnRtnFromBankToFutureByBankHandler OnRtnFromBankToFutureByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnFromBankToFutureByBankHandler(IntPtr spi, OnRtnFromBankToFutureByBankHandler handler);


        ///���з����ڻ��ʽ�ת����֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnFromFutureToBankByBankHandler(CThostFtdcRspTransferField pRspTransfer);
        public event OnRtnFromFutureToBankByBankHandler OnRtnFromFutureToBankByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnFromFutureToBankByBankHandler(IntPtr spi, OnRtnFromFutureToBankByBankHandler handler);


        ///���з����������ת�ڻ�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnRepealFromBankToFutureByBankHandler(CThostFtdcRspRepealField pRspRepeal);
        public event OnRtnRepealFromBankToFutureByBankHandler OnRtnRepealFromBankToFutureByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnRepealFromBankToFutureByBankHandler(IntPtr spi, OnRtnRepealFromBankToFutureByBankHandler handler);


        ///���з�������ڻ�ת����֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnRepealFromFutureToBankByBankHandler(CThostFtdcRspRepealField pRspRepeal);
        public event OnRtnRepealFromFutureToBankByBankHandler OnRtnRepealFromFutureToBankByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnRepealFromFutureToBankByBankHandler(IntPtr spi, OnRtnRepealFromFutureToBankByBankHandler handler);


        ///�ڻ����������ʽ�ת�ڻ�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnFromBankToFutureByFutureHandler(CThostFtdcRspTransferField pRspTransfer);
        public event OnRtnFromBankToFutureByFutureHandler OnRtnFromBankToFutureByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnFromBankToFutureByFutureHandler(IntPtr spi, OnRtnFromBankToFutureByFutureHandler handler);


        ///�ڻ������ڻ��ʽ�ת����֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnFromFutureToBankByFutureHandler(CThostFtdcRspTransferField pRspTransfer);
        public event OnRtnFromFutureToBankByFutureHandler OnRtnFromFutureToBankByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnFromFutureToBankByFutureHandler(IntPtr spi, OnRtnFromFutureToBankByFutureHandler handler);


        ///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnRepealFromBankToFutureByFutureManualHandler(CThostFtdcRspRepealField pRspRepeal);
        public event OnRtnRepealFromBankToFutureByFutureManualHandler OnRtnRepealFromBankToFutureByFutureManual;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnRepealFromBankToFutureByFutureManualHandler(IntPtr spi, OnRtnRepealFromBankToFutureByFutureManualHandler handler);


        ///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnRepealFromFutureToBankByFutureManualHandler(CThostFtdcRspRepealField pRspRepeal);
        public event OnRtnRepealFromFutureToBankByFutureManualHandler OnRtnRepealFromFutureToBankByFutureManual;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnRepealFromFutureToBankByFutureManualHandler(IntPtr spi, OnRtnRepealFromFutureToBankByFutureManualHandler handler);


        ///�ڻ������ѯ�������֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnQueryBankBalanceByFutureHandler(CThostFtdcNotifyQueryAccountField pNotifyQueryAccount);
        public event OnRtnQueryBankBalanceByFutureHandler OnRtnQueryBankBalanceByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnQueryBankBalanceByFutureHandler(IntPtr spi, OnRtnQueryBankBalanceByFutureHandler handler);


        ///�ڻ����������ʽ�ת�ڻ�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnBankToFutureByFutureHandler(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnBankToFutureByFutureHandler OnErrRtnBankToFutureByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnBankToFutureByFutureHandler(IntPtr spi, OnErrRtnBankToFutureByFutureHandler handler);


        ///�ڻ������ڻ��ʽ�ת���д���ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnFutureToBankByFutureHandler(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnFutureToBankByFutureHandler OnErrRtnFutureToBankByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnFutureToBankByFutureHandler(IntPtr spi, OnErrRtnFutureToBankByFutureHandler handler);


        ///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnRepealBankToFutureByFutureManualHandler(CThostFtdcReqRepealField pReqRepeal, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnRepealBankToFutureByFutureManualHandler OnErrRtnRepealBankToFutureByFutureManual;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnRepealBankToFutureByFutureManualHandler(IntPtr spi, OnErrRtnRepealBankToFutureByFutureManualHandler handler);


        ///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnRepealFutureToBankByFutureManualHandler(CThostFtdcReqRepealField pReqRepeal, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnRepealFutureToBankByFutureManualHandler OnErrRtnRepealFutureToBankByFutureManual;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnRepealFutureToBankByFutureManualHandler(IntPtr spi, OnErrRtnRepealFutureToBankByFutureManualHandler handler);


        ///�ڻ������ѯ����������ر�
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnErrRtnQueryBankBalanceByFutureHandler(CThostFtdcReqQueryAccountField pReqQueryAccount, CThostFtdcRspInfoField pRspInfo);
        public event OnErrRtnQueryBankBalanceByFutureHandler OnErrRtnQueryBankBalanceByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnErrRtnQueryBankBalanceByFutureHandler(IntPtr spi, OnErrRtnQueryBankBalanceByFutureHandler handler);


        ///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnRepealFromBankToFutureByFutureHandler(CThostFtdcRspRepealField pRspRepeal);
        public event OnRtnRepealFromBankToFutureByFutureHandler OnRtnRepealFromBankToFutureByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnRepealFromBankToFutureByFutureHandler(IntPtr spi, OnRtnRepealFromBankToFutureByFutureHandler handler);


        ///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnRepealFromFutureToBankByFutureHandler(CThostFtdcRspRepealField pRspRepeal);
        public event OnRtnRepealFromFutureToBankByFutureHandler OnRtnRepealFromFutureToBankByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnRepealFromFutureToBankByFutureHandler(IntPtr spi, OnRtnRepealFromFutureToBankByFutureHandler handler);


        ///�ڻ����������ʽ�ת�ڻ�Ӧ��
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspFromBankToFutureByFutureHandler(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspFromBankToFutureByFutureHandler OnRspFromBankToFutureByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspFromBankToFutureByFutureHandler(IntPtr spi, OnRspFromBankToFutureByFutureHandler handler);


        ///�ڻ������ڻ��ʽ�ת����Ӧ��
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspFromFutureToBankByFutureHandler(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspFromFutureToBankByFutureHandler OnRspFromFutureToBankByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspFromFutureToBankByFutureHandler(IntPtr spi, OnRspFromFutureToBankByFutureHandler handler);


        ///�ڻ������ѯ�������Ӧ��
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQueryBankAccountMoneyByFutureHandler(CThostFtdcReqQueryAccountField pReqQueryAccount, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQueryBankAccountMoneyByFutureHandler OnRspQueryBankAccountMoneyByFuture;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQueryBankAccountMoneyByFutureHandler(IntPtr spi, OnRspQueryBankAccountMoneyByFutureHandler handler);


        ///���з������ڿ���֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnOpenAccountByBankHandler(CThostFtdcOpenAccountField pOpenAccount);
        public event OnRtnOpenAccountByBankHandler OnRtnOpenAccountByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnOpenAccountByBankHandler(IntPtr spi, OnRtnOpenAccountByBankHandler handler);


        ///���з�����������֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnCancelAccountByBankHandler(CThostFtdcCancelAccountField pCancelAccount);
        public event OnRtnCancelAccountByBankHandler OnRtnCancelAccountByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnCancelAccountByBankHandler(IntPtr spi, OnRtnCancelAccountByBankHandler handler);


        ///���з����������˺�֪ͨ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRtnChangeAccountByBankHandler(CThostFtdcChangeAccountField pChangeAccount);
        public event OnRtnChangeAccountByBankHandler OnRtnChangeAccountByBank;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRtnChangeAccountByBankHandler(IntPtr spi, OnRtnChangeAccountByBankHandler handler);


        ///�����ѯ�����Լ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryClassifiedInstrumentHandler(CThostFtdcInstrumentField pInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryClassifiedInstrumentHandler OnRspQryClassifiedInstrument;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryClassifiedInstrumentHandler(IntPtr spi, OnRspQryClassifiedInstrumentHandler handler);


        ///��������Żݱ�����Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryCombPromotionParamHandler(CThostFtdcCombPromotionParamField pCombPromotionParam, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryCombPromotionParamHandler OnRspQryCombPromotionParam;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryCombPromotionParamHandler(IntPtr spi, OnRspQryCombPromotionParamHandler handler);


        ///Ͷ���߷��ս���ֲֲ�ѯ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryRiskSettleInvstPositionHandler(CThostFtdcRiskSettleInvstPositionField pRiskSettleInvstPosition, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryRiskSettleInvstPositionHandler OnRspQryRiskSettleInvstPosition;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryRiskSettleInvstPositionHandler(IntPtr spi, OnRspQryRiskSettleInvstPositionHandler handler);


        ///���ս����Ʒ��ѯ��Ӧ
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OnRspQryRiskSettleProductStatusHandler(CThostFtdcRiskSettleProductStatusField pRiskSettleProductStatus, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event OnRspQryRiskSettleProductStatusHandler OnRspQryRiskSettleProductStatus;
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSetOnRspQryRiskSettleProductStatusHandler(IntPtr spi, OnRspQryRiskSettleProductStatusHandler handler);


        #endregion �ص����


        #region Dll Functions
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr TdCreateApi(string pszFlowPath);

        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr TdGetApiVersion();

        ///ɾ���ӿڶ�����
        ///@remark ����ʹ�ñ��ӿڶ���ʱ,���øú���ɾ���ӿڶ���
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdRelease(IntPtr api);

        ///��ʼ��
        ///@remark ��ʼ�����л���,ֻ�е��ú�,�ӿڲſ�ʼ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdInit(IntPtr api);

        ///�ȴ��ӿ��߳̽�������
        ///@return �߳��˳�����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdJoin(IntPtr api);

        ///��ȡ��ǰ������
        ///@retrun ��ȡ���Ľ�����
        ///@remark ֻ�е�¼�ɹ���,���ܵõ���ȷ�Ľ�����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr TdGetTradingDay(IntPtr api);

        ///ע��ǰ�û������ַ
        ///@param pszFrontAddress��ǰ�û������ַ��
        ///@remark �����ַ�ĸ�ʽΪ����protocol://ipaddress:port�����磺��tcp://127.0.0.1:17001���� 
        ///@remark ��tcp��������Э�飬��127.0.0.1�������������ַ����17001������������˿ںš�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdRegisterFront(IntPtr api, string pszFrontAddress);

        ///ע�����ַ����������ַ
        ///@param pszNsAddress�����ַ����������ַ��
        ///@remark �����ַ�ĸ�ʽΪ����protocol://ipaddress:port�����磺��tcp://127.0.0.1:12001���� 
        ///@remark ��tcp��������Э�飬��127.0.0.1�������������ַ����12001������������˿ںš�
        ///@remark RegisterNameServer������RegisterFront
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdRegisterNameServer(IntPtr api, string pszNsAddress);

        ///ע�����ַ������û���Ϣ
        ///@param pFensUserInfo���û���Ϣ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdRegisterFensUserInfo(IntPtr api, CThostFtdcFensUserInfoField pFensUserInfo);

        ///����˽������
        ///@param nResumeType ˽�����ش���ʽ  
        ///        THOST_TERT_RESTART:�ӱ������տ�ʼ�ش�
        ///        THOST_TERT_RESUME:���ϴ��յ�������
        ///        THOST_TERT_QUICK:ֻ���͵�¼��˽����������
        ///@remark �÷���Ҫ��Init����ǰ���á����������򲻻��յ�˽���������ݡ�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSubscribePrivateTopic(IntPtr api, THOST_TE_RESUME_TYPE nResumeType);

        ///���Ĺ�������
        ///@param nResumeType �������ش���ʽ  
        ///        THOST_TERT_RESTART:�ӱ������տ�ʼ�ش�
        ///        THOST_TERT_RESUME:���ϴ��յ�������
        ///        THOST_TERT_QUICK:ֻ���͵�¼�󹫹���������
        ///        THOST_TERT_NONE:ȡ�����Ĺ�����
        ///@remark �÷���Ҫ��Init����ǰ���á����������򲻻��յ������������ݡ�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void TdSubscribePublicTopic(IntPtr api, THOST_TE_RESUME_TYPE nResumeType);

        ///�ͻ�����֤����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqAuthenticate(IntPtr api, CThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID);

        ///ע���û��ն���Ϣ�������м̷�����������ģʽ
        ///��Ҫ���ն���֤�ɹ����û���¼ǰ���øýӿ�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdRegisterUserSystemInfo(IntPtr api, CThostFtdcUserSystemInfoField pUserSystemInfo);

        ///�ϱ��û��ն���Ϣ�������м̷���������Ա��¼ģʽ
        ///����Ա��¼�󣬿��Զ�ε��øýӿ��ϱ��ͻ���Ϣ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdSubmitUserSystemInfo(IntPtr api, CThostFtdcUserSystemInfoField pUserSystemInfo);

        ///�û���¼����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserLogin(IntPtr api, CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        ///�ǳ�����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserLogout(IntPtr api, CThostFtdcUserLogoutField pUserLogout, int nRequestID);

        ///�û������������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserPasswordUpdate(IntPtr api, CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);

        ///�ʽ��˻������������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqTradingAccountPasswordUpdate(IntPtr api, CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID);

        ///��ѯ�û���ǰ֧�ֵ���֤ģʽ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserAuthMethod(IntPtr api, CThostFtdcReqUserAuthMethodField pReqUserAuthMethod, int nRequestID);

        ///�û�������ȡͼ����֤������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqGenUserCaptcha(IntPtr api, CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha, int nRequestID);

        ///�û�������ȡ������֤������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqGenUserText(IntPtr api, CThostFtdcReqGenUserTextField pReqGenUserText, int nRequestID);

        ///�û���������ͼƬ��֤��ĵ�½����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserLoginWithCaptcha(IntPtr api, CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha, int nRequestID);

        ///�û��������ж�����֤��ĵ�½����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserLoginWithText(IntPtr api, CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText, int nRequestID);

        ///�û��������ж�̬����ĵ�½����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqUserLoginWithOTP(IntPtr api, CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP, int nRequestID);

        ///����¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqOrderInsert(IntPtr api, CThostFtdcInputOrderField pInputOrder, int nRequestID);

        ///Ԥ��¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqParkedOrderInsert(IntPtr api, CThostFtdcParkedOrderField pParkedOrder, int nRequestID);

        ///Ԥ�񳷵�¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqParkedOrderAction(IntPtr api, CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID);

        ///������������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqOrderAction(IntPtr api, CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID);

        ///��ѯ��󱨵���������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryMaxOrderVolume(IntPtr api, CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume, int nRequestID);

        ///Ͷ���߽�����ȷ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqSettlementInfoConfirm(IntPtr api, CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID);

        ///����ɾ��Ԥ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqRemoveParkedOrder(IntPtr api, CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID);

        ///����ɾ��Ԥ�񳷵�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqRemoveParkedOrderAction(IntPtr api, CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID);

        ///ִ������¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqExecOrderInsert(IntPtr api, CThostFtdcInputExecOrderField pInputExecOrder, int nRequestID);

        ///ִ�������������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqExecOrderAction(IntPtr api, CThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID);

        ///ѯ��¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqForQuoteInsert(IntPtr api, CThostFtdcInputForQuoteField pInputForQuote, int nRequestID);

        ///����¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQuoteInsert(IntPtr api, CThostFtdcInputQuoteField pInputQuote, int nRequestID);

        ///���۲�������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQuoteAction(IntPtr api, CThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID);

        ///����������������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqBatchOrderAction(IntPtr api, CThostFtdcInputBatchOrderActionField pInputBatchOrderAction, int nRequestID);

        ///��Ȩ�ԶԳ�¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqOptionSelfCloseInsert(IntPtr api, CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, int nRequestID);

        ///��Ȩ�ԶԳ��������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqOptionSelfCloseAction(IntPtr api, CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction, int nRequestID);

        ///�������¼������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqCombActionInsert(IntPtr api, CThostFtdcInputCombActionField pInputCombAction, int nRequestID);

        ///�����ѯ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryOrder(IntPtr api, CThostFtdcQryOrderField pQryOrder, int nRequestID);

        ///�����ѯ�ɽ�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTrade(IntPtr api, CThostFtdcQryTradeField pQryTrade, int nRequestID);

        ///�����ѯͶ���ֲ߳�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInvestorPosition(IntPtr api, CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);

        ///�����ѯ�ʽ��˻�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTradingAccount(IntPtr api, CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);

        ///�����ѯͶ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInvestor(IntPtr api, CThostFtdcQryInvestorField pQryInvestor, int nRequestID);

        ///�����ѯ���ױ���
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTradingCode(IntPtr api, CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);

        ///�����ѯ��Լ��֤����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInstrumentMarginRate(IntPtr api, CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID);

        ///�����ѯ��Լ��������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInstrumentCommissionRate(IntPtr api, CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID);

        ///�����ѯ������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryExchange(IntPtr api, CThostFtdcQryExchangeField pQryExchange, int nRequestID);

        ///�����ѯ��Ʒ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryProduct(IntPtr api, CThostFtdcQryProductField pQryProduct, int nRequestID);

        ///�����ѯ��Լ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInstrument(IntPtr api, CThostFtdcQryInstrumentField pQryInstrument, int nRequestID);

        ///�����ѯ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryDepthMarketData(IntPtr api, CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);

        ///�����ѯ����Ա���̻�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTraderOffer(IntPtr api, CThostFtdcQryTraderOfferField pQryTraderOffer, int nRequestID);

        ///�����ѯͶ���߽�����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQrySettlementInfo(IntPtr api, CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID);

        ///�����ѯת������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTransferBank(IntPtr api, CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID);

        ///�����ѯͶ���ֲ߳���ϸ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInvestorPositionDetail(IntPtr api, CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID);

        ///�����ѯ�ͻ�֪ͨ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryNotice(IntPtr api, CThostFtdcQryNoticeField pQryNotice, int nRequestID);

        ///�����ѯ������Ϣȷ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQrySettlementInfoConfirm(IntPtr api, CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID);

        ///�����ѯͶ���ֲ߳���ϸ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInvestorPositionCombineDetail(IntPtr api, CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID);

        ///�����ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryCFMMCTradingAccountKey(IntPtr api, CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID);

        ///�����ѯ�ֵ��۵���Ϣ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryEWarrantOffset(IntPtr api, CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID);

        ///�����ѯͶ����Ʒ��/��Ʒ�ֱ�֤��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInvestorProductGroupMargin(IntPtr api, CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID);

        ///�����ѯ��������֤����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryExchangeMarginRate(IntPtr api, CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID);

        ///�����ѯ������������֤����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryExchangeMarginRateAdjust(IntPtr api, CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust, int nRequestID);

        ///�����ѯ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryExchangeRate(IntPtr api, CThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID);

        ///�����ѯ�����������Ա����Ȩ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQrySecAgentACIDMap(IntPtr api, CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID);

        ///�����ѯ��Ʒ���ۻ���
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryProductExchRate(IntPtr api, CThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID);

        ///�����ѯ��Ʒ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryProductGroup(IntPtr api, CThostFtdcQryProductGroupField pQryProductGroup, int nRequestID);

        ///�����ѯ�����̺�Լ��������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryMMInstrumentCommissionRate(IntPtr api, CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate, int nRequestID);

        ///�����ѯ��������Ȩ��Լ������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryMMOptionInstrCommRate(IntPtr api, CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate, int nRequestID);

        ///�����ѯ����������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInstrumentOrderCommRate(IntPtr api, CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate, int nRequestID);

        ///�����ѯ�ʽ��˻�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQrySecAgentTradingAccount(IntPtr api, CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);

        ///�����ѯ�����������ʽ�У��ģʽ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQrySecAgentCheckMode(IntPtr api, CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode, int nRequestID);

        ///�����ѯ������������Ϣ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQrySecAgentTradeInfo(IntPtr api, CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo, int nRequestID);

        ///�����ѯ��Ȩ���׳ɱ�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryOptionInstrTradeCost(IntPtr api, CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost, int nRequestID);

        ///�����ѯ��Ȩ��Լ������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryOptionInstrCommRate(IntPtr api, CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate, int nRequestID);

        ///�����ѯִ������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryExecOrder(IntPtr api, CThostFtdcQryExecOrderField pQryExecOrder, int nRequestID);

        ///�����ѯѯ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryForQuote(IntPtr api, CThostFtdcQryForQuoteField pQryForQuote, int nRequestID);

        ///�����ѯ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryQuote(IntPtr api, CThostFtdcQryQuoteField pQryQuote, int nRequestID);

        ///�����ѯ��Ȩ�ԶԳ�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryOptionSelfClose(IntPtr api, CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose, int nRequestID);

        ///�����ѯͶ�ʵ�Ԫ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryInvestUnit(IntPtr api, CThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID);

        ///�����ѯ��Ϻ�Լ��ȫϵ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryCombInstrumentGuard(IntPtr api, CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard, int nRequestID);

        ///�����ѯ�������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryCombAction(IntPtr api, CThostFtdcQryCombActionField pQryCombAction, int nRequestID);

        ///�����ѯת����ˮ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTransferSerial(IntPtr api, CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID);

        ///�����ѯ����ǩԼ��ϵ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryAccountregister(IntPtr api, CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID);

        ///�����ѯǩԼ����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryContractBank(IntPtr api, CThostFtdcQryContractBankField pQryContractBank, int nRequestID);

        ///�����ѯԤ��
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryParkedOrder(IntPtr api, CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID);

        ///�����ѯԤ�񳷵�
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryParkedOrderAction(IntPtr api, CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID);

        ///�����ѯ����֪ͨ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryTradingNotice(IntPtr api, CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID);

        ///�����ѯ���͹�˾���ײ���
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryBrokerTradingParams(IntPtr api, CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID);

        ///�����ѯ���͹�˾�����㷨
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryBrokerTradingAlgos(IntPtr api, CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID);

        ///�����ѯ��������û�����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQueryCFMMCTradingAccountToken(IntPtr api, CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID);

        ///�ڻ����������ʽ�ת�ڻ�����
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqFromBankToFutureByFuture(IntPtr api, CThostFtdcReqTransferField pReqTransfer, int nRequestID);

        ///�ڻ������ڻ��ʽ�ת��������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqFromFutureToBankByFuture(IntPtr api, CThostFtdcReqTransferField pReqTransfer, int nRequestID);

        ///�ڻ������ѯ�����������
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQueryBankAccountMoneyByFuture(IntPtr api, CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID);

        ///�����ѯ�����Լ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryClassifiedInstrument(IntPtr api, CThostFtdcQryClassifiedInstrumentField pQryClassifiedInstrument, int nRequestID);

        ///��������Żݱ���
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryCombPromotionParam(IntPtr api, CThostFtdcQryCombPromotionParamField pQryCombPromotionParam, int nRequestID);

        ///Ͷ���߷��ս���ֲֲ�ѯ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryRiskSettleInvstPosition(IntPtr api, CThostFtdcQryRiskSettleInvstPositionField pQryRiskSettleInvstPosition, int nRequestID);

        ///���ս����Ʒ��ѯ
        [DllImport("Bridge.CTP.Wrapped.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int TdReqQryRiskSettleProductStatus(IntPtr api, CThostFtdcQryRiskSettleProductStatusField pQryRiskSettleProductStatus, int nRequestID);

        #endregion Dll Functions


















    }
}

















