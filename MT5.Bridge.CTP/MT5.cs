using Bridge.CTP;
using System;
using System.Text.RegularExpressions;

namespace MT5
{
    public enum OrderType
    {
        Buy,
        Sell,
        BuyLimit,
        SellLimit,
        BuyStop,
        SellStop,
        BuyStopLimit,
        SellStopLimit,
    }

    public enum PositionType
    {
        Buy,
        Sell
    }

    public enum OrderState
    {
        Started,
        Placed,
        Canceled,
        Partial,
        Filled,
        Rejected,
        Expired,
        RequestAdd,
        RequestModify,
        RequestCancel,

    }



    public static class Utility
    {
        private static readonly DateTime StampStart = new DateTime(1970, 1, 1);

        public static string SymbolToCTPSymbol(string symbol, string exchange)
        {
            if (exchange == "CZCE")
                return Regex.Replace(symbol, @"(\w+)\d(\d{3})", "$1$2").ToUpper();
            else if (exchange == "CFFEX")
                return symbol.ToUpper();
            else
                return symbol.ToLower();
        }

        public static string CTPSymbolToSymbol(string symbol, string exchange)
        {
            if (exchange == "CZCE")
            {
                var y = DateTime.Now.Year % 100 / 10;

                string prod = Regex.Match(symbol, @"\w+").Value;
                return symbol.Replace(prod, prod + y).ToUpper();
            }
            return symbol.ToUpper();
        }

        public static long TimeStamp(DateTime time)
        {
            return (long)(time - StampStart).TotalSeconds;
        }

        public static long TimeStampMsc(DateTime time)
        {
            return (long)(time - StampStart).TotalMilliseconds;
        }
    }



    public class Order
    {
        #region Property
        public long Ticket { get; set; }
        public long TimeSetup { get; set; }
        public OrderType Type { get; set; }
        public OrderState State { get; set; }
        public long TimeExpiration { get; set; }
        public long TimeDone { get; set; }
        public long TimeSetupMsc { get; set; }
        public long TimeDoneMsc { get; set; }
        public long TypeFilling { get; set; }
        public long TypeTime { get; set; }
        public long Magic { get; set; }
        public long Reason { get; set; }
        public long PositionID { get; set; }
        public long PositionByID { get; set; }

        public double VolumeInital { get; set; }
        public double VolumeCurrent { get; set; }
        public double PriceOpen { get; set; }
        public double SL { get; set; }
        public double TP { get; set; }
        public double PriceCurrent { get; set; }
        public double PriceStopLimit { get; set; }

        public string Symbol { get; init; }
        public string? Comment { get; set; }
        public string? ExternalID { get; set; }
        #endregion


        public static implicit operator Order(CThostFtdcOrderField v)
        {
            OrderType orderType = default;
            if (v.Direction == TThostFtdcDirectionType.THOST_FTDC_D_Buy)
            {
                switch (v.ContingentCondition)
                {
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately:
                        orderType = OrderType.Buy;
                        break;
                    //case TThostFtdcContingentConditionType.THOST_FTDC_CC_Touch:
                    //    break;
                    //case TThostFtdcContingentConditionType.THOST_FTDC_CC_TouchProfit:
                    //    break; 
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceGreaterThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceGreaterEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceGreaterThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceGreaterEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceGreaterThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceGreaterEqualStopPrice:
                        orderType = OrderType.BuyStop;
                        break;
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceLesserThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceLesserEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceLesserThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceLesserEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceLesserThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceLesserEqualStopPrice:
                        orderType = OrderType.BuyLimit;
                        break;
                    default:
                        return null;
                }
            }
            else if (v.Direction == TThostFtdcDirectionType.THOST_FTDC_D_Sell)
            {
                switch (v.ContingentCondition)
                {
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately:
                        orderType = OrderType.Sell;
                        break;
                    //case TThostFtdcContingentConditionType.THOST_FTDC_CC_Touch:
                    //    break;
                    //case TThostFtdcContingentConditionType.THOST_FTDC_CC_TouchProfit:
                    //    break; 
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceGreaterThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceGreaterEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceGreaterThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceGreaterEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceGreaterThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceGreaterEqualStopPrice:
                        orderType = OrderType.SellLimit;
                        break;
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceLesserThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_LastPriceLesserEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceLesserThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_AskPriceLesserEqualStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceLesserThanStopPrice:
                    case TThostFtdcContingentConditionType.THOST_FTDC_CC_BidPriceLesserEqualStopPrice:
                        orderType = OrderType.SellStop;
                        break;
                    default:
                        return null;
                }
            }

            OrderState orderState = default;
            switch (v.OrderStatus)
            {
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_AllTraded:
                    orderState = OrderState.Filled;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_PartTradedQueueing:
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_PartTradedNotQueueing:
                    orderState = OrderState.Partial;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_NoTradeQueueing:
                    orderState = OrderState.RequestAdd;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_NoTradeNotQueueing:
                    orderState = OrderState.Placed;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_Canceled:
                    if (v.OrderSubmitStatus == TThostFtdcOrderSubmitStatusType.THOST_FTDC_OSS_InsertRejected)
                        orderState = OrderState.Rejected;
                    else
                        orderState = OrderState.RequestCancel;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_Unknown:
                    if (v.OrderSubmitStatus == TThostFtdcOrderSubmitStatusType.THOST_FTDC_OSS_InsertSubmitted)
                        orderState = OrderState.Started;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_NotTouched:
                    orderState = OrderState.Placed;
                    break;
                case TThostFtdcOrderStatusType.THOST_FTDC_OST_Touched:
                    orderState = OrderState.Placed;
                    break;
            }

            DateTime.TryParseExact(v.InsertDate + v.InsertTime, "yyyyMMddHH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime inserttime);

            Order order = new Order
            {
                Symbol = Utility.CTPSymbolToSymbol(v.InstrumentID, v.ExchangeID),
                ExternalID = v.OrderRef,
                TimeSetup = Utility.TimeStamp(inserttime),
                TimeSetupMsc = Utility.TimeStampMsc(inserttime),
                //TimeDone = Utility.TimeStamp(DateTime.Parse(v.ActiveTime)),
                //TimeDoneMsc = Utility.TimeStampMsc(DateTime.Parse(v.ActiveTime)),
                Type = orderType,
                PriceOpen = v.LimitPrice,
                State = orderState
            };
            return order;
        }
    }
}
