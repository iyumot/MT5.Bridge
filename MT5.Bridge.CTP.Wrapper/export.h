#pragma once

#include "shared.h"
#include "trader.h"
#include "quoter.h"


#ifdef __cplusplus
extern "C" {
#endif


	CTP_API void* CTPCALL TdCreateApi(const char* pszFlowPath){{
		return new CTraderHandler(pszFlowPath);
	}}
	CTP_API const char* CTPCALL TdGetApiVersion(){{
		return CThostFtdcMdApi::GetApiVersion();
	}}

    ///删除接口对象本身
	///@remark 不再使用本接口对象时,调用该函数删除接口对象
    CTP_API void CTPCALL TdRelease(void * spi) {
        if(spi) delete spi;
    }

    ///初始化
	///@remark 初始化运行环境,只有调用后,接口才开始工作
    CTP_API void CTPCALL TdInit(void * spi) {
        (static_cast<CTraderHandler*>(spi))->Api()->Init();
    }

    ///等待接口线程结束运行
	///@return 线程退出代码
    CTP_API int CTPCALL TdJoin(void * spi) {
        return (static_cast<CTraderHandler*>(spi))->Api()->Join();
    }

    ///获取当前交易日
	///@retrun 获取到的交易日
	///@remark 只有登录成功后,才能得到正确的交易日
    CTP_API const char* CTPCALL TdGetTradingDay(void * spi) {
        return (static_cast<CTraderHandler*>(spi))->Api()->GetTradingDay();
    }

    ///注册前置机网络地址
	///@param pszFrontAddress：前置机网络地址。
	///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。 
	///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
    CTP_API void CTPCALL TdRegisterFront(void * spi,char *pszFrontAddress) {
        (static_cast<CTraderHandler*>(spi))->Api()->RegisterFront(pszFrontAddress);
    }

    ///注册名字服务器网络地址
	///@param pszNsAddress：名字服务器网络地址。
	///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。 
	///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
	///@remark RegisterNameServer优先于RegisterFront
    CTP_API void CTPCALL TdRegisterNameServer(void * spi,char *pszNsAddress) {
        (static_cast<CTraderHandler*>(spi))->Api()->RegisterNameServer(pszNsAddress);
    }

    ///注册名字服务器用户信息
	///@param pFensUserInfo：用户信息。
    CTP_API void CTPCALL TdRegisterFensUserInfo(void * spi,CThostFtdcFensUserInfoField * pFensUserInfo) {
        (static_cast<CTraderHandler*>(spi))->Api()->RegisterFensUserInfo(pFensUserInfo);
    }

    ///注册回调接口
	///@param pSpi 派生自回调接口类的实例
    CTP_API void CTPCALL TdRegisterSpi(void * spi,CThostFtdcTraderSpi *pSpi) {
        (static_cast<CTraderHandler*>(spi))->Api()->RegisterSpi(pSpi);
    }

    ///订阅私有流。
	///@param nResumeType 私有流重传方式  
	///        THOST_TERT_RESTART:从本交易日开始重传
	///        THOST_TERT_RESUME:从上次收到的续传
	///        THOST_TERT_QUICK:只传送登录后私有流的内容
	///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
    CTP_API void CTPCALL TdSubscribePrivateTopic(void * spi,THOST_TE_RESUME_TYPE nResumeType) {
        (static_cast<CTraderHandler*>(spi))->Api()->SubscribePrivateTopic(nResumeType);
    }

    ///订阅公共流。
	///@param nResumeType 公共流重传方式  
	///        THOST_TERT_RESTART:从本交易日开始重传
	///        THOST_TERT_RESUME:从上次收到的续传
	///        THOST_TERT_QUICK:只传送登录后公共流的内容
	///        THOST_TERT_NONE:取消订阅公共流
	///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
    CTP_API void CTPCALL TdSubscribePublicTopic(void * spi,THOST_TE_RESUME_TYPE nResumeType) {
        (static_cast<CTraderHandler*>(spi))->Api()->SubscribePublicTopic(nResumeType);
    }

    ///客户端认证请求
    CTP_API int CTPCALL TdReqAuthenticate(void * spi,CThostFtdcReqAuthenticateField *pReqAuthenticateField, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqAuthenticate(pReqAuthenticateField,nRequestID);
    }

    ///注册用户终端信息，用于中继服务器多连接模式
	///需要在终端认证成功后，用户登录前调用该接口
    CTP_API int CTPCALL TdRegisterUserSystemInfo(void * spi,CThostFtdcUserSystemInfoField *pUserSystemInfo) {
        return (static_cast<CTraderHandler*>(spi))->Api()->RegisterUserSystemInfo(pUserSystemInfo);
    }

    ///上报用户终端信息，用于中继服务器操作员登录模式
	///操作员登录后，可以多次调用该接口上报客户信息
    CTP_API int CTPCALL TdSubmitUserSystemInfo(void * spi,CThostFtdcUserSystemInfoField *pUserSystemInfo) {
        return (static_cast<CTraderHandler*>(spi))->Api()->SubmitUserSystemInfo(pUserSystemInfo);
    }

    ///用户登录请求
    CTP_API int CTPCALL TdReqUserLogin(void * spi,CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserLogin(pReqUserLoginField,nRequestID);
    }

    ///登出请求
    CTP_API int CTPCALL TdReqUserLogout(void * spi,CThostFtdcUserLogoutField *pUserLogout, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserLogout(pUserLogout,nRequestID);
    }

    ///用户口令更新请求
    CTP_API int CTPCALL TdReqUserPasswordUpdate(void * spi,CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserPasswordUpdate(pUserPasswordUpdate,nRequestID);
    }

    ///资金账户口令更新请求
    CTP_API int CTPCALL TdReqTradingAccountPasswordUpdate(void * spi,CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate,nRequestID);
    }

    ///查询用户当前支持的认证模式
    CTP_API int CTPCALL TdReqUserAuthMethod(void * spi,CThostFtdcReqUserAuthMethodField *pReqUserAuthMethod, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserAuthMethod(pReqUserAuthMethod,nRequestID);
    }

    ///用户发出获取图形验证码请求
    CTP_API int CTPCALL TdReqGenUserCaptcha(void * spi,CThostFtdcReqGenUserCaptchaField *pReqGenUserCaptcha, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqGenUserCaptcha(pReqGenUserCaptcha,nRequestID);
    }

    ///用户发出获取短信验证码请求
    CTP_API int CTPCALL TdReqGenUserText(void * spi,CThostFtdcReqGenUserTextField *pReqGenUserText, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqGenUserText(pReqGenUserText,nRequestID);
    }

    ///用户发出带有图片验证码的登陆请求
    CTP_API int CTPCALL TdReqUserLoginWithCaptcha(void * spi,CThostFtdcReqUserLoginWithCaptchaField *pReqUserLoginWithCaptcha, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserLoginWithCaptcha(pReqUserLoginWithCaptcha,nRequestID);
    }

    ///用户发出带有短信验证码的登陆请求
    CTP_API int CTPCALL TdReqUserLoginWithText(void * spi,CThostFtdcReqUserLoginWithTextField *pReqUserLoginWithText, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserLoginWithText(pReqUserLoginWithText,nRequestID);
    }

    ///用户发出带有动态口令的登陆请求
    CTP_API int CTPCALL TdReqUserLoginWithOTP(void * spi,CThostFtdcReqUserLoginWithOTPField *pReqUserLoginWithOTP, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqUserLoginWithOTP(pReqUserLoginWithOTP,nRequestID);
    }

    ///报单录入请求
    CTP_API int CTPCALL TdReqOrderInsert(void * spi,CThostFtdcInputOrderField *pInputOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqOrderInsert(pInputOrder,nRequestID);
    }

    ///预埋单录入请求
    CTP_API int CTPCALL TdReqParkedOrderInsert(void * spi,CThostFtdcParkedOrderField *pParkedOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqParkedOrderInsert(pParkedOrder,nRequestID);
    }

    ///预埋撤单录入请求
    CTP_API int CTPCALL TdReqParkedOrderAction(void * spi,CThostFtdcParkedOrderActionField *pParkedOrderAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqParkedOrderAction(pParkedOrderAction,nRequestID);
    }

    ///报单操作请求
    CTP_API int CTPCALL TdReqOrderAction(void * spi,CThostFtdcInputOrderActionField *pInputOrderAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqOrderAction(pInputOrderAction,nRequestID);
    }

    ///查询最大报单数量请求
    CTP_API int CTPCALL TdReqQryMaxOrderVolume(void * spi,CThostFtdcQryMaxOrderVolumeField *pQryMaxOrderVolume, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryMaxOrderVolume(pQryMaxOrderVolume,nRequestID);
    }

    ///投资者结算结果确认
    CTP_API int CTPCALL TdReqSettlementInfoConfirm(void * spi,CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqSettlementInfoConfirm(pSettlementInfoConfirm,nRequestID);
    }

    ///请求删除预埋单
    CTP_API int CTPCALL TdReqRemoveParkedOrder(void * spi,CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqRemoveParkedOrder(pRemoveParkedOrder,nRequestID);
    }

    ///请求删除预埋撤单
    CTP_API int CTPCALL TdReqRemoveParkedOrderAction(void * spi,CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction,nRequestID);
    }

    ///执行宣告录入请求
    CTP_API int CTPCALL TdReqExecOrderInsert(void * spi,CThostFtdcInputExecOrderField *pInputExecOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqExecOrderInsert(pInputExecOrder,nRequestID);
    }

    ///执行宣告操作请求
    CTP_API int CTPCALL TdReqExecOrderAction(void * spi,CThostFtdcInputExecOrderActionField *pInputExecOrderAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqExecOrderAction(pInputExecOrderAction,nRequestID);
    }

    ///询价录入请求
    CTP_API int CTPCALL TdReqForQuoteInsert(void * spi,CThostFtdcInputForQuoteField *pInputForQuote, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqForQuoteInsert(pInputForQuote,nRequestID);
    }

    ///报价录入请求
    CTP_API int CTPCALL TdReqQuoteInsert(void * spi,CThostFtdcInputQuoteField *pInputQuote, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQuoteInsert(pInputQuote,nRequestID);
    }

    ///报价操作请求
    CTP_API int CTPCALL TdReqQuoteAction(void * spi,CThostFtdcInputQuoteActionField *pInputQuoteAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQuoteAction(pInputQuoteAction,nRequestID);
    }

    ///批量报单操作请求
    CTP_API int CTPCALL TdReqBatchOrderAction(void * spi,CThostFtdcInputBatchOrderActionField *pInputBatchOrderAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqBatchOrderAction(pInputBatchOrderAction,nRequestID);
    }

    ///期权自对冲录入请求
    CTP_API int CTPCALL TdReqOptionSelfCloseInsert(void * spi,CThostFtdcInputOptionSelfCloseField *pInputOptionSelfClose, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqOptionSelfCloseInsert(pInputOptionSelfClose,nRequestID);
    }

    ///期权自对冲操作请求
    CTP_API int CTPCALL TdReqOptionSelfCloseAction(void * spi,CThostFtdcInputOptionSelfCloseActionField *pInputOptionSelfCloseAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqOptionSelfCloseAction(pInputOptionSelfCloseAction,nRequestID);
    }

    ///申请组合录入请求
    CTP_API int CTPCALL TdReqCombActionInsert(void * spi,CThostFtdcInputCombActionField *pInputCombAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqCombActionInsert(pInputCombAction,nRequestID);
    }

    ///请求查询报单
    CTP_API int CTPCALL TdReqQryOrder(void * spi,CThostFtdcQryOrderField *pQryOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryOrder(pQryOrder,nRequestID);
    }

    ///请求查询成交
    CTP_API int CTPCALL TdReqQryTrade(void * spi,CThostFtdcQryTradeField *pQryTrade, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTrade(pQryTrade,nRequestID);
    }

    ///请求查询投资者持仓
    CTP_API int CTPCALL TdReqQryInvestorPosition(void * spi,CThostFtdcQryInvestorPositionField *pQryInvestorPosition, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInvestorPosition(pQryInvestorPosition,nRequestID);
    }

    ///请求查询资金账户
    CTP_API int CTPCALL TdReqQryTradingAccount(void * spi,CThostFtdcQryTradingAccountField *pQryTradingAccount, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTradingAccount(pQryTradingAccount,nRequestID);
    }

    ///请求查询投资者
    CTP_API int CTPCALL TdReqQryInvestor(void * spi,CThostFtdcQryInvestorField *pQryInvestor, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInvestor(pQryInvestor,nRequestID);
    }

    ///请求查询交易编码
    CTP_API int CTPCALL TdReqQryTradingCode(void * spi,CThostFtdcQryTradingCodeField *pQryTradingCode, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTradingCode(pQryTradingCode,nRequestID);
    }

    ///请求查询合约保证金率
    CTP_API int CTPCALL TdReqQryInstrumentMarginRate(void * spi,CThostFtdcQryInstrumentMarginRateField *pQryInstrumentMarginRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate,nRequestID);
    }

    ///请求查询合约手续费率
    CTP_API int CTPCALL TdReqQryInstrumentCommissionRate(void * spi,CThostFtdcQryInstrumentCommissionRateField *pQryInstrumentCommissionRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate,nRequestID);
    }

    ///请求查询交易所
    CTP_API int CTPCALL TdReqQryExchange(void * spi,CThostFtdcQryExchangeField *pQryExchange, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryExchange(pQryExchange,nRequestID);
    }

    ///请求查询产品
    CTP_API int CTPCALL TdReqQryProduct(void * spi,CThostFtdcQryProductField *pQryProduct, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryProduct(pQryProduct,nRequestID);
    }

    ///请求查询合约
    CTP_API int CTPCALL TdReqQryInstrument(void * spi,CThostFtdcQryInstrumentField *pQryInstrument, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInstrument(pQryInstrument,nRequestID);
    }

    ///请求查询行情
    CTP_API int CTPCALL TdReqQryDepthMarketData(void * spi,CThostFtdcQryDepthMarketDataField *pQryDepthMarketData, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryDepthMarketData(pQryDepthMarketData,nRequestID);
    }

    ///请求查询交易员报盘机
    CTP_API int CTPCALL TdReqQryTraderOffer(void * spi,CThostFtdcQryTraderOfferField *pQryTraderOffer, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTraderOffer(pQryTraderOffer,nRequestID);
    }

    ///请求查询投资者结算结果
    CTP_API int CTPCALL TdReqQrySettlementInfo(void * spi,CThostFtdcQrySettlementInfoField *pQrySettlementInfo, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQrySettlementInfo(pQrySettlementInfo,nRequestID);
    }

    ///请求查询转帐银行
    CTP_API int CTPCALL TdReqQryTransferBank(void * spi,CThostFtdcQryTransferBankField *pQryTransferBank, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTransferBank(pQryTransferBank,nRequestID);
    }

    ///请求查询投资者持仓明细
    CTP_API int CTPCALL TdReqQryInvestorPositionDetail(void * spi,CThostFtdcQryInvestorPositionDetailField *pQryInvestorPositionDetail, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail,nRequestID);
    }

    ///请求查询客户通知
    CTP_API int CTPCALL TdReqQryNotice(void * spi,CThostFtdcQryNoticeField *pQryNotice, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryNotice(pQryNotice,nRequestID);
    }

    ///请求查询结算信息确认
    CTP_API int CTPCALL TdReqQrySettlementInfoConfirm(void * spi,CThostFtdcQrySettlementInfoConfirmField *pQrySettlementInfoConfirm, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm,nRequestID);
    }

    ///请求查询投资者持仓明细
    CTP_API int CTPCALL TdReqQryInvestorPositionCombineDetail(void * spi,CThostFtdcQryInvestorPositionCombineDetailField *pQryInvestorPositionCombineDetail, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail,nRequestID);
    }

    ///请求查询保证金监管系统经纪公司资金账户密钥
    CTP_API int CTPCALL TdReqQryCFMMCTradingAccountKey(void * spi,CThostFtdcQryCFMMCTradingAccountKeyField *pQryCFMMCTradingAccountKey, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey,nRequestID);
    }

    ///请求查询仓单折抵信息
    CTP_API int CTPCALL TdReqQryEWarrantOffset(void * spi,CThostFtdcQryEWarrantOffsetField *pQryEWarrantOffset, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryEWarrantOffset(pQryEWarrantOffset,nRequestID);
    }

    ///请求查询投资者品种/跨品种保证金
    CTP_API int CTPCALL TdReqQryInvestorProductGroupMargin(void * spi,CThostFtdcQryInvestorProductGroupMarginField *pQryInvestorProductGroupMargin, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin,nRequestID);
    }

    ///请求查询交易所保证金率
    CTP_API int CTPCALL TdReqQryExchangeMarginRate(void * spi,CThostFtdcQryExchangeMarginRateField *pQryExchangeMarginRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryExchangeMarginRate(pQryExchangeMarginRate,nRequestID);
    }

    ///请求查询交易所调整保证金率
    CTP_API int CTPCALL TdReqQryExchangeMarginRateAdjust(void * spi,CThostFtdcQryExchangeMarginRateAdjustField *pQryExchangeMarginRateAdjust, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust,nRequestID);
    }

    ///请求查询汇率
    CTP_API int CTPCALL TdReqQryExchangeRate(void * spi,CThostFtdcQryExchangeRateField *pQryExchangeRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryExchangeRate(pQryExchangeRate,nRequestID);
    }

    ///请求查询二级代理操作员银期权限
    CTP_API int CTPCALL TdReqQrySecAgentACIDMap(void * spi,CThostFtdcQrySecAgentACIDMapField *pQrySecAgentACIDMap, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQrySecAgentACIDMap(pQrySecAgentACIDMap,nRequestID);
    }

    ///请求查询产品报价汇率
    CTP_API int CTPCALL TdReqQryProductExchRate(void * spi,CThostFtdcQryProductExchRateField *pQryProductExchRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryProductExchRate(pQryProductExchRate,nRequestID);
    }

    ///请求查询产品组
    CTP_API int CTPCALL TdReqQryProductGroup(void * spi,CThostFtdcQryProductGroupField *pQryProductGroup, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryProductGroup(pQryProductGroup,nRequestID);
    }

    ///请求查询做市商合约手续费率
    CTP_API int CTPCALL TdReqQryMMInstrumentCommissionRate(void * spi,CThostFtdcQryMMInstrumentCommissionRateField *pQryMMInstrumentCommissionRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryMMInstrumentCommissionRate(pQryMMInstrumentCommissionRate,nRequestID);
    }

    ///请求查询做市商期权合约手续费
    CTP_API int CTPCALL TdReqQryMMOptionInstrCommRate(void * spi,CThostFtdcQryMMOptionInstrCommRateField *pQryMMOptionInstrCommRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryMMOptionInstrCommRate(pQryMMOptionInstrCommRate,nRequestID);
    }

    ///请求查询报单手续费
    CTP_API int CTPCALL TdReqQryInstrumentOrderCommRate(void * spi,CThostFtdcQryInstrumentOrderCommRateField *pQryInstrumentOrderCommRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInstrumentOrderCommRate(pQryInstrumentOrderCommRate,nRequestID);
    }

    ///请求查询资金账户
    CTP_API int CTPCALL TdReqQrySecAgentTradingAccount(void * spi,CThostFtdcQryTradingAccountField *pQryTradingAccount, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQrySecAgentTradingAccount(pQryTradingAccount,nRequestID);
    }

    ///请求查询二级代理商资金校验模式
    CTP_API int CTPCALL TdReqQrySecAgentCheckMode(void * spi,CThostFtdcQrySecAgentCheckModeField *pQrySecAgentCheckMode, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQrySecAgentCheckMode(pQrySecAgentCheckMode,nRequestID);
    }

    ///请求查询二级代理商信息
    CTP_API int CTPCALL TdReqQrySecAgentTradeInfo(void * spi,CThostFtdcQrySecAgentTradeInfoField *pQrySecAgentTradeInfo, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQrySecAgentTradeInfo(pQrySecAgentTradeInfo,nRequestID);
    }

    ///请求查询期权交易成本
    CTP_API int CTPCALL TdReqQryOptionInstrTradeCost(void * spi,CThostFtdcQryOptionInstrTradeCostField *pQryOptionInstrTradeCost, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost,nRequestID);
    }

    ///请求查询期权合约手续费
    CTP_API int CTPCALL TdReqQryOptionInstrCommRate(void * spi,CThostFtdcQryOptionInstrCommRateField *pQryOptionInstrCommRate, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryOptionInstrCommRate(pQryOptionInstrCommRate,nRequestID);
    }

    ///请求查询执行宣告
    CTP_API int CTPCALL TdReqQryExecOrder(void * spi,CThostFtdcQryExecOrderField *pQryExecOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryExecOrder(pQryExecOrder,nRequestID);
    }

    ///请求查询询价
    CTP_API int CTPCALL TdReqQryForQuote(void * spi,CThostFtdcQryForQuoteField *pQryForQuote, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryForQuote(pQryForQuote,nRequestID);
    }

    ///请求查询报价
    CTP_API int CTPCALL TdReqQryQuote(void * spi,CThostFtdcQryQuoteField *pQryQuote, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryQuote(pQryQuote,nRequestID);
    }

    ///请求查询期权自对冲
    CTP_API int CTPCALL TdReqQryOptionSelfClose(void * spi,CThostFtdcQryOptionSelfCloseField *pQryOptionSelfClose, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryOptionSelfClose(pQryOptionSelfClose,nRequestID);
    }

    ///请求查询投资单元
    CTP_API int CTPCALL TdReqQryInvestUnit(void * spi,CThostFtdcQryInvestUnitField *pQryInvestUnit, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryInvestUnit(pQryInvestUnit,nRequestID);
    }

    ///请求查询组合合约安全系数
    CTP_API int CTPCALL TdReqQryCombInstrumentGuard(void * spi,CThostFtdcQryCombInstrumentGuardField *pQryCombInstrumentGuard, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryCombInstrumentGuard(pQryCombInstrumentGuard,nRequestID);
    }

    ///请求查询申请组合
    CTP_API int CTPCALL TdReqQryCombAction(void * spi,CThostFtdcQryCombActionField *pQryCombAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryCombAction(pQryCombAction,nRequestID);
    }

    ///请求查询转帐流水
    CTP_API int CTPCALL TdReqQryTransferSerial(void * spi,CThostFtdcQryTransferSerialField *pQryTransferSerial, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTransferSerial(pQryTransferSerial,nRequestID);
    }

    ///请求查询银期签约关系
    CTP_API int CTPCALL TdReqQryAccountregister(void * spi,CThostFtdcQryAccountregisterField *pQryAccountregister, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryAccountregister(pQryAccountregister,nRequestID);
    }

    ///请求查询签约银行
    CTP_API int CTPCALL TdReqQryContractBank(void * spi,CThostFtdcQryContractBankField *pQryContractBank, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryContractBank(pQryContractBank,nRequestID);
    }

    ///请求查询预埋单
    CTP_API int CTPCALL TdReqQryParkedOrder(void * spi,CThostFtdcQryParkedOrderField *pQryParkedOrder, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryParkedOrder(pQryParkedOrder,nRequestID);
    }

    ///请求查询预埋撤单
    CTP_API int CTPCALL TdReqQryParkedOrderAction(void * spi,CThostFtdcQryParkedOrderActionField *pQryParkedOrderAction, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryParkedOrderAction(pQryParkedOrderAction,nRequestID);
    }

    ///请求查询交易通知
    CTP_API int CTPCALL TdReqQryTradingNotice(void * spi,CThostFtdcQryTradingNoticeField *pQryTradingNotice, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryTradingNotice(pQryTradingNotice,nRequestID);
    }

    ///请求查询经纪公司交易参数
    CTP_API int CTPCALL TdReqQryBrokerTradingParams(void * spi,CThostFtdcQryBrokerTradingParamsField *pQryBrokerTradingParams, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryBrokerTradingParams(pQryBrokerTradingParams,nRequestID);
    }

    ///请求查询经纪公司交易算法
    CTP_API int CTPCALL TdReqQryBrokerTradingAlgos(void * spi,CThostFtdcQryBrokerTradingAlgosField *pQryBrokerTradingAlgos, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos,nRequestID);
    }

    ///请求查询监控中心用户令牌
    CTP_API int CTPCALL TdReqQueryCFMMCTradingAccountToken(void * spi,CThostFtdcQueryCFMMCTradingAccountTokenField *pQueryCFMMCTradingAccountToken, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken,nRequestID);
    }

    ///期货发起银行资金转期货请求
    CTP_API int CTPCALL TdReqFromBankToFutureByFuture(void * spi,CThostFtdcReqTransferField *pReqTransfer, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqFromBankToFutureByFuture(pReqTransfer,nRequestID);
    }

    ///期货发起期货资金转银行请求
    CTP_API int CTPCALL TdReqFromFutureToBankByFuture(void * spi,CThostFtdcReqTransferField *pReqTransfer, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqFromFutureToBankByFuture(pReqTransfer,nRequestID);
    }

    ///期货发起查询银行余额请求
    CTP_API int CTPCALL TdReqQueryBankAccountMoneyByFuture(void * spi,CThostFtdcReqQueryAccountField *pReqQueryAccount, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount,nRequestID);
    }

    ///请求查询分类合约
    CTP_API int CTPCALL TdReqQryClassifiedInstrument(void * spi,CThostFtdcQryClassifiedInstrumentField *pQryClassifiedInstrument, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryClassifiedInstrument(pQryClassifiedInstrument,nRequestID);
    }

    ///请求组合优惠比例
    CTP_API int CTPCALL TdReqQryCombPromotionParam(void * spi,CThostFtdcQryCombPromotionParamField *pQryCombPromotionParam, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryCombPromotionParam(pQryCombPromotionParam,nRequestID);
    }

    ///投资者风险结算持仓查询
    CTP_API int CTPCALL TdReqQryRiskSettleInvstPosition(void * spi,CThostFtdcQryRiskSettleInvstPositionField *pQryRiskSettleInvstPosition, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryRiskSettleInvstPosition(pQryRiskSettleInvstPosition,nRequestID);
    }

    ///风险结算产品查询
    CTP_API int CTPCALL TdReqQryRiskSettleProductStatus(void * spi,CThostFtdcQryRiskSettleProductStatusField *pQryRiskSettleProductStatus, int nRequestID) {
        return (static_cast<CTraderHandler*>(spi))->Api()->ReqQryRiskSettleProductStatus(pQryRiskSettleProductStatus,nRequestID);
    }
	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	CTP_API void CTPCALL TdSetOnFrontConnectedHandler(void* spi, OnFrontConnectedHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnFrontConnectedHandler(handler);
	}

	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	CTP_API void CTPCALL TdSetOnFrontDisconnectedHandler(void* spi, OnFrontDisconnectedHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnFrontDisconnectedHandler(handler);
	}

	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	CTP_API void CTPCALL TdSetOnHeartBeatWarningHandler(void* spi, OnHeartBeatWarningHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnHeartBeatWarningHandler(handler);
	}

	///客户端认证响应
	CTP_API void CTPCALL TdSetOnRspAuthenticateHandler(void* spi, OnRspAuthenticateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspAuthenticateHandler(handler);
	}

	///登录请求响应
	CTP_API void CTPCALL TdSetOnRspUserLoginHandler(void* spi, OnRspUserLoginHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspUserLoginHandler(handler);
	}

	///登出请求响应
	CTP_API void CTPCALL TdSetOnRspUserLogoutHandler(void* spi, OnRspUserLogoutHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspUserLogoutHandler(handler);
	}

	///用户口令更新请求响应
	CTP_API void CTPCALL TdSetOnRspUserPasswordUpdateHandler(void* spi, OnRspUserPasswordUpdateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspUserPasswordUpdateHandler(handler);
	}

	///资金账户口令更新请求响应
	CTP_API void CTPCALL TdSetOnRspTradingAccountPasswordUpdateHandler(void* spi, OnRspTradingAccountPasswordUpdateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspTradingAccountPasswordUpdateHandler(handler);
	}

	///查询用户当前支持的认证模式的回复
	CTP_API void CTPCALL TdSetOnRspUserAuthMethodHandler(void* spi, OnRspUserAuthMethodHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspUserAuthMethodHandler(handler);
	}

	///获取图形验证码请求的回复
	CTP_API void CTPCALL TdSetOnRspGenUserCaptchaHandler(void* spi, OnRspGenUserCaptchaHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspGenUserCaptchaHandler(handler);
	}

	///获取短信验证码请求的回复
	CTP_API void CTPCALL TdSetOnRspGenUserTextHandler(void* spi, OnRspGenUserTextHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspGenUserTextHandler(handler);
	}

	///报单录入请求响应
	CTP_API void CTPCALL TdSetOnRspOrderInsertHandler(void* spi, OnRspOrderInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspOrderInsertHandler(handler);
	}

	///预埋单录入请求响应
	CTP_API void CTPCALL TdSetOnRspParkedOrderInsertHandler(void* spi, OnRspParkedOrderInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspParkedOrderInsertHandler(handler);
	}

	///预埋撤单录入请求响应
	CTP_API void CTPCALL TdSetOnRspParkedOrderActionHandler(void* spi, OnRspParkedOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspParkedOrderActionHandler(handler);
	}

	///报单操作请求响应
	CTP_API void CTPCALL TdSetOnRspOrderActionHandler(void* spi, OnRspOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspOrderActionHandler(handler);
	}

	///查询最大报单数量响应
	CTP_API void CTPCALL TdSetOnRspQryMaxOrderVolumeHandler(void* spi, OnRspQryMaxOrderVolumeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryMaxOrderVolumeHandler(handler);
	}

	///投资者结算结果确认响应
	CTP_API void CTPCALL TdSetOnRspSettlementInfoConfirmHandler(void* spi, OnRspSettlementInfoConfirmHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspSettlementInfoConfirmHandler(handler);
	}

	///删除预埋单响应
	CTP_API void CTPCALL TdSetOnRspRemoveParkedOrderHandler(void* spi, OnRspRemoveParkedOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspRemoveParkedOrderHandler(handler);
	}

	///删除预埋撤单响应
	CTP_API void CTPCALL TdSetOnRspRemoveParkedOrderActionHandler(void* spi, OnRspRemoveParkedOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspRemoveParkedOrderActionHandler(handler);
	}

	///执行宣告录入请求响应
	CTP_API void CTPCALL TdSetOnRspExecOrderInsertHandler(void* spi, OnRspExecOrderInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspExecOrderInsertHandler(handler);
	}

	///执行宣告操作请求响应
	CTP_API void CTPCALL TdSetOnRspExecOrderActionHandler(void* spi, OnRspExecOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspExecOrderActionHandler(handler);
	}

	///询价录入请求响应
	CTP_API void CTPCALL TdSetOnRspForQuoteInsertHandler(void* spi, OnRspForQuoteInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspForQuoteInsertHandler(handler);
	}

	///报价录入请求响应
	CTP_API void CTPCALL TdSetOnRspQuoteInsertHandler(void* spi, OnRspQuoteInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQuoteInsertHandler(handler);
	}

	///报价操作请求响应
	CTP_API void CTPCALL TdSetOnRspQuoteActionHandler(void* spi, OnRspQuoteActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQuoteActionHandler(handler);
	}

	///批量报单操作请求响应
	CTP_API void CTPCALL TdSetOnRspBatchOrderActionHandler(void* spi, OnRspBatchOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspBatchOrderActionHandler(handler);
	}

	///期权自对冲录入请求响应
	CTP_API void CTPCALL TdSetOnRspOptionSelfCloseInsertHandler(void* spi, OnRspOptionSelfCloseInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspOptionSelfCloseInsertHandler(handler);
	}

	///期权自对冲操作请求响应
	CTP_API void CTPCALL TdSetOnRspOptionSelfCloseActionHandler(void* spi, OnRspOptionSelfCloseActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspOptionSelfCloseActionHandler(handler);
	}

	///申请组合录入请求响应
	CTP_API void CTPCALL TdSetOnRspCombActionInsertHandler(void* spi, OnRspCombActionInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspCombActionInsertHandler(handler);
	}

	///请求查询报单响应
	CTP_API void CTPCALL TdSetOnRspQryOrderHandler(void* spi, OnRspQryOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryOrderHandler(handler);
	}

	///请求查询成交响应
	CTP_API void CTPCALL TdSetOnRspQryTradeHandler(void* spi, OnRspQryTradeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTradeHandler(handler);
	}

	///请求查询投资者持仓响应
	CTP_API void CTPCALL TdSetOnRspQryInvestorPositionHandler(void* spi, OnRspQryInvestorPositionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInvestorPositionHandler(handler);
	}

	///请求查询资金账户响应
	CTP_API void CTPCALL TdSetOnRspQryTradingAccountHandler(void* spi, OnRspQryTradingAccountHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTradingAccountHandler(handler);
	}

	///请求查询投资者响应
	CTP_API void CTPCALL TdSetOnRspQryInvestorHandler(void* spi, OnRspQryInvestorHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInvestorHandler(handler);
	}

	///请求查询交易编码响应
	CTP_API void CTPCALL TdSetOnRspQryTradingCodeHandler(void* spi, OnRspQryTradingCodeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTradingCodeHandler(handler);
	}

	///请求查询合约保证金率响应
	CTP_API void CTPCALL TdSetOnRspQryInstrumentMarginRateHandler(void* spi, OnRspQryInstrumentMarginRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInstrumentMarginRateHandler(handler);
	}

	///请求查询合约手续费率响应
	CTP_API void CTPCALL TdSetOnRspQryInstrumentCommissionRateHandler(void* spi, OnRspQryInstrumentCommissionRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInstrumentCommissionRateHandler(handler);
	}

	///请求查询交易所响应
	CTP_API void CTPCALL TdSetOnRspQryExchangeHandler(void* spi, OnRspQryExchangeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryExchangeHandler(handler);
	}

	///请求查询产品响应
	CTP_API void CTPCALL TdSetOnRspQryProductHandler(void* spi, OnRspQryProductHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryProductHandler(handler);
	}

	///请求查询合约响应
	CTP_API void CTPCALL TdSetOnRspQryInstrumentHandler(void* spi, OnRspQryInstrumentHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInstrumentHandler(handler);
	}

	///请求查询行情响应
	CTP_API void CTPCALL TdSetOnRspQryDepthMarketDataHandler(void* spi, OnRspQryDepthMarketDataHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryDepthMarketDataHandler(handler);
	}

	///请求查询交易员报盘机响应
	CTP_API void CTPCALL TdSetOnRspQryTraderOfferHandler(void* spi, OnRspQryTraderOfferHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTraderOfferHandler(handler);
	}

	///请求查询投资者结算结果响应
	CTP_API void CTPCALL TdSetOnRspQrySettlementInfoHandler(void* spi, OnRspQrySettlementInfoHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQrySettlementInfoHandler(handler);
	}

	///请求查询转帐银行响应
	CTP_API void CTPCALL TdSetOnRspQryTransferBankHandler(void* spi, OnRspQryTransferBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTransferBankHandler(handler);
	}

	///请求查询投资者持仓明细响应
	CTP_API void CTPCALL TdSetOnRspQryInvestorPositionDetailHandler(void* spi, OnRspQryInvestorPositionDetailHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInvestorPositionDetailHandler(handler);
	}

	///请求查询客户通知响应
	CTP_API void CTPCALL TdSetOnRspQryNoticeHandler(void* spi, OnRspQryNoticeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryNoticeHandler(handler);
	}

	///请求查询结算信息确认响应
	CTP_API void CTPCALL TdSetOnRspQrySettlementInfoConfirmHandler(void* spi, OnRspQrySettlementInfoConfirmHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQrySettlementInfoConfirmHandler(handler);
	}

	///请求查询投资者持仓明细响应
	CTP_API void CTPCALL TdSetOnRspQryInvestorPositionCombineDetailHandler(void* spi, OnRspQryInvestorPositionCombineDetailHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInvestorPositionCombineDetailHandler(handler);
	}

	///查询保证金监管系统经纪公司资金账户密钥响应
	CTP_API void CTPCALL TdSetOnRspQryCFMMCTradingAccountKeyHandler(void* spi, OnRspQryCFMMCTradingAccountKeyHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryCFMMCTradingAccountKeyHandler(handler);
	}

	///请求查询仓单折抵信息响应
	CTP_API void CTPCALL TdSetOnRspQryEWarrantOffsetHandler(void* spi, OnRspQryEWarrantOffsetHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryEWarrantOffsetHandler(handler);
	}

	///请求查询投资者品种/跨品种保证金响应
	CTP_API void CTPCALL TdSetOnRspQryInvestorProductGroupMarginHandler(void* spi, OnRspQryInvestorProductGroupMarginHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInvestorProductGroupMarginHandler(handler);
	}

	///请求查询交易所保证金率响应
	CTP_API void CTPCALL TdSetOnRspQryExchangeMarginRateHandler(void* spi, OnRspQryExchangeMarginRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryExchangeMarginRateHandler(handler);
	}

	///请求查询交易所调整保证金率响应
	CTP_API void CTPCALL TdSetOnRspQryExchangeMarginRateAdjustHandler(void* spi, OnRspQryExchangeMarginRateAdjustHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryExchangeMarginRateAdjustHandler(handler);
	}

	///请求查询汇率响应
	CTP_API void CTPCALL TdSetOnRspQryExchangeRateHandler(void* spi, OnRspQryExchangeRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryExchangeRateHandler(handler);
	}

	///请求查询二级代理操作员银期权限响应
	CTP_API void CTPCALL TdSetOnRspQrySecAgentACIDMapHandler(void* spi, OnRspQrySecAgentACIDMapHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQrySecAgentACIDMapHandler(handler);
	}

	///请求查询产品报价汇率
	CTP_API void CTPCALL TdSetOnRspQryProductExchRateHandler(void* spi, OnRspQryProductExchRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryProductExchRateHandler(handler);
	}

	///请求查询产品组
	CTP_API void CTPCALL TdSetOnRspQryProductGroupHandler(void* spi, OnRspQryProductGroupHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryProductGroupHandler(handler);
	}

	///请求查询做市商合约手续费率响应
	CTP_API void CTPCALL TdSetOnRspQryMMInstrumentCommissionRateHandler(void* spi, OnRspQryMMInstrumentCommissionRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryMMInstrumentCommissionRateHandler(handler);
	}

	///请求查询做市商期权合约手续费响应
	CTP_API void CTPCALL TdSetOnRspQryMMOptionInstrCommRateHandler(void* spi, OnRspQryMMOptionInstrCommRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryMMOptionInstrCommRateHandler(handler);
	}

	///请求查询报单手续费响应
	CTP_API void CTPCALL TdSetOnRspQryInstrumentOrderCommRateHandler(void* spi, OnRspQryInstrumentOrderCommRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInstrumentOrderCommRateHandler(handler);
	}

	///请求查询资金账户响应
	CTP_API void CTPCALL TdSetOnRspQrySecAgentTradingAccountHandler(void* spi, OnRspQrySecAgentTradingAccountHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQrySecAgentTradingAccountHandler(handler);
	}

	///请求查询二级代理商资金校验模式响应
	CTP_API void CTPCALL TdSetOnRspQrySecAgentCheckModeHandler(void* spi, OnRspQrySecAgentCheckModeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQrySecAgentCheckModeHandler(handler);
	}

	///请求查询二级代理商信息响应
	CTP_API void CTPCALL TdSetOnRspQrySecAgentTradeInfoHandler(void* spi, OnRspQrySecAgentTradeInfoHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQrySecAgentTradeInfoHandler(handler);
	}

	///请求查询期权交易成本响应
	CTP_API void CTPCALL TdSetOnRspQryOptionInstrTradeCostHandler(void* spi, OnRspQryOptionInstrTradeCostHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryOptionInstrTradeCostHandler(handler);
	}

	///请求查询期权合约手续费响应
	CTP_API void CTPCALL TdSetOnRspQryOptionInstrCommRateHandler(void* spi, OnRspQryOptionInstrCommRateHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryOptionInstrCommRateHandler(handler);
	}

	///请求查询执行宣告响应
	CTP_API void CTPCALL TdSetOnRspQryExecOrderHandler(void* spi, OnRspQryExecOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryExecOrderHandler(handler);
	}

	///请求查询询价响应
	CTP_API void CTPCALL TdSetOnRspQryForQuoteHandler(void* spi, OnRspQryForQuoteHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryForQuoteHandler(handler);
	}

	///请求查询报价响应
	CTP_API void CTPCALL TdSetOnRspQryQuoteHandler(void* spi, OnRspQryQuoteHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryQuoteHandler(handler);
	}

	///请求查询期权自对冲响应
	CTP_API void CTPCALL TdSetOnRspQryOptionSelfCloseHandler(void* spi, OnRspQryOptionSelfCloseHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryOptionSelfCloseHandler(handler);
	}

	///请求查询投资单元响应
	CTP_API void CTPCALL TdSetOnRspQryInvestUnitHandler(void* spi, OnRspQryInvestUnitHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryInvestUnitHandler(handler);
	}

	///请求查询组合合约安全系数响应
	CTP_API void CTPCALL TdSetOnRspQryCombInstrumentGuardHandler(void* spi, OnRspQryCombInstrumentGuardHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryCombInstrumentGuardHandler(handler);
	}

	///请求查询申请组合响应
	CTP_API void CTPCALL TdSetOnRspQryCombActionHandler(void* spi, OnRspQryCombActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryCombActionHandler(handler);
	}

	///请求查询转帐流水响应
	CTP_API void CTPCALL TdSetOnRspQryTransferSerialHandler(void* spi, OnRspQryTransferSerialHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTransferSerialHandler(handler);
	}

	///请求查询银期签约关系响应
	CTP_API void CTPCALL TdSetOnRspQryAccountregisterHandler(void* spi, OnRspQryAccountregisterHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryAccountregisterHandler(handler);
	}

	///错误应答
	CTP_API void CTPCALL TdSetOnRspErrorHandler(void* spi, OnRspErrorHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspErrorHandler(handler);
	}

	///报单通知
	CTP_API void CTPCALL TdSetOnRtnOrderHandler(void* spi, OnRtnOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnOrderHandler(handler);
	}

	///成交通知
	CTP_API void CTPCALL TdSetOnRtnTradeHandler(void* spi, OnRtnTradeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnTradeHandler(handler);
	}

	///报单录入错误回报
	CTP_API void CTPCALL TdSetOnErrRtnOrderInsertHandler(void* spi, OnErrRtnOrderInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnOrderInsertHandler(handler);
	}

	///报单操作错误回报
	CTP_API void CTPCALL TdSetOnErrRtnOrderActionHandler(void* spi, OnErrRtnOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnOrderActionHandler(handler);
	}

	///合约交易状态通知
	CTP_API void CTPCALL TdSetOnRtnInstrumentStatusHandler(void* spi, OnRtnInstrumentStatusHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnInstrumentStatusHandler(handler);
	}

	///交易所公告通知
	CTP_API void CTPCALL TdSetOnRtnBulletinHandler(void* spi, OnRtnBulletinHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnBulletinHandler(handler);
	}

	///交易通知
	CTP_API void CTPCALL TdSetOnRtnTradingNoticeHandler(void* spi, OnRtnTradingNoticeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnTradingNoticeHandler(handler);
	}

	///提示条件单校验错误
	CTP_API void CTPCALL TdSetOnRtnErrorConditionalOrderHandler(void* spi, OnRtnErrorConditionalOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnErrorConditionalOrderHandler(handler);
	}

	///执行宣告通知
	CTP_API void CTPCALL TdSetOnRtnExecOrderHandler(void* spi, OnRtnExecOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnExecOrderHandler(handler);
	}

	///执行宣告录入错误回报
	CTP_API void CTPCALL TdSetOnErrRtnExecOrderInsertHandler(void* spi, OnErrRtnExecOrderInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnExecOrderInsertHandler(handler);
	}

	///执行宣告操作错误回报
	CTP_API void CTPCALL TdSetOnErrRtnExecOrderActionHandler(void* spi, OnErrRtnExecOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnExecOrderActionHandler(handler);
	}

	///询价录入错误回报
	CTP_API void CTPCALL TdSetOnErrRtnForQuoteInsertHandler(void* spi, OnErrRtnForQuoteInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnForQuoteInsertHandler(handler);
	}

	///报价通知
	CTP_API void CTPCALL TdSetOnRtnQuoteHandler(void* spi, OnRtnQuoteHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnQuoteHandler(handler);
	}

	///报价录入错误回报
	CTP_API void CTPCALL TdSetOnErrRtnQuoteInsertHandler(void* spi, OnErrRtnQuoteInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnQuoteInsertHandler(handler);
	}

	///报价操作错误回报
	CTP_API void CTPCALL TdSetOnErrRtnQuoteActionHandler(void* spi, OnErrRtnQuoteActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnQuoteActionHandler(handler);
	}

	///询价通知
	CTP_API void CTPCALL TdSetOnRtnForQuoteRspHandler(void* spi, OnRtnForQuoteRspHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnForQuoteRspHandler(handler);
	}

	///保证金监控中心用户令牌
	CTP_API void CTPCALL TdSetOnRtnCFMMCTradingAccountTokenHandler(void* spi, OnRtnCFMMCTradingAccountTokenHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnCFMMCTradingAccountTokenHandler(handler);
	}

	///批量报单操作错误回报
	CTP_API void CTPCALL TdSetOnErrRtnBatchOrderActionHandler(void* spi, OnErrRtnBatchOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnBatchOrderActionHandler(handler);
	}

	///期权自对冲通知
	CTP_API void CTPCALL TdSetOnRtnOptionSelfCloseHandler(void* spi, OnRtnOptionSelfCloseHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnOptionSelfCloseHandler(handler);
	}

	///期权自对冲录入错误回报
	CTP_API void CTPCALL TdSetOnErrRtnOptionSelfCloseInsertHandler(void* spi, OnErrRtnOptionSelfCloseInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnOptionSelfCloseInsertHandler(handler);
	}

	///期权自对冲操作错误回报
	CTP_API void CTPCALL TdSetOnErrRtnOptionSelfCloseActionHandler(void* spi, OnErrRtnOptionSelfCloseActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnOptionSelfCloseActionHandler(handler);
	}

	///申请组合通知
	CTP_API void CTPCALL TdSetOnRtnCombActionHandler(void* spi, OnRtnCombActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnCombActionHandler(handler);
	}

	///申请组合录入错误回报
	CTP_API void CTPCALL TdSetOnErrRtnCombActionInsertHandler(void* spi, OnErrRtnCombActionInsertHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnCombActionInsertHandler(handler);
	}

	///请求查询签约银行响应
	CTP_API void CTPCALL TdSetOnRspQryContractBankHandler(void* spi, OnRspQryContractBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryContractBankHandler(handler);
	}

	///请求查询预埋单响应
	CTP_API void CTPCALL TdSetOnRspQryParkedOrderHandler(void* spi, OnRspQryParkedOrderHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryParkedOrderHandler(handler);
	}

	///请求查询预埋撤单响应
	CTP_API void CTPCALL TdSetOnRspQryParkedOrderActionHandler(void* spi, OnRspQryParkedOrderActionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryParkedOrderActionHandler(handler);
	}

	///请求查询交易通知响应
	CTP_API void CTPCALL TdSetOnRspQryTradingNoticeHandler(void* spi, OnRspQryTradingNoticeHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryTradingNoticeHandler(handler);
	}

	///请求查询经纪公司交易参数响应
	CTP_API void CTPCALL TdSetOnRspQryBrokerTradingParamsHandler(void* spi, OnRspQryBrokerTradingParamsHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryBrokerTradingParamsHandler(handler);
	}

	///请求查询经纪公司交易算法响应
	CTP_API void CTPCALL TdSetOnRspQryBrokerTradingAlgosHandler(void* spi, OnRspQryBrokerTradingAlgosHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryBrokerTradingAlgosHandler(handler);
	}

	///请求查询监控中心用户令牌
	CTP_API void CTPCALL TdSetOnRspQueryCFMMCTradingAccountTokenHandler(void* spi, OnRspQueryCFMMCTradingAccountTokenHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQueryCFMMCTradingAccountTokenHandler(handler);
	}

	///银行发起银行资金转期货通知
	CTP_API void CTPCALL TdSetOnRtnFromBankToFutureByBankHandler(void* spi, OnRtnFromBankToFutureByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnFromBankToFutureByBankHandler(handler);
	}

	///银行发起期货资金转银行通知
	CTP_API void CTPCALL TdSetOnRtnFromFutureToBankByBankHandler(void* spi, OnRtnFromFutureToBankByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnFromFutureToBankByBankHandler(handler);
	}

	///银行发起冲正银行转期货通知
	CTP_API void CTPCALL TdSetOnRtnRepealFromBankToFutureByBankHandler(void* spi, OnRtnRepealFromBankToFutureByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnRepealFromBankToFutureByBankHandler(handler);
	}

	///银行发起冲正期货转银行通知
	CTP_API void CTPCALL TdSetOnRtnRepealFromFutureToBankByBankHandler(void* spi, OnRtnRepealFromFutureToBankByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnRepealFromFutureToBankByBankHandler(handler);
	}

	///期货发起银行资金转期货通知
	CTP_API void CTPCALL TdSetOnRtnFromBankToFutureByFutureHandler(void* spi, OnRtnFromBankToFutureByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnFromBankToFutureByFutureHandler(handler);
	}

	///期货发起期货资金转银行通知
	CTP_API void CTPCALL TdSetOnRtnFromFutureToBankByFutureHandler(void* spi, OnRtnFromFutureToBankByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnFromFutureToBankByFutureHandler(handler);
	}

	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	CTP_API void CTPCALL TdSetOnRtnRepealFromBankToFutureByFutureManualHandler(void* spi, OnRtnRepealFromBankToFutureByFutureManualHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnRepealFromBankToFutureByFutureManualHandler(handler);
	}

	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	CTP_API void CTPCALL TdSetOnRtnRepealFromFutureToBankByFutureManualHandler(void* spi, OnRtnRepealFromFutureToBankByFutureManualHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnRepealFromFutureToBankByFutureManualHandler(handler);
	}

	///期货发起查询银行余额通知
	CTP_API void CTPCALL TdSetOnRtnQueryBankBalanceByFutureHandler(void* spi, OnRtnQueryBankBalanceByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnQueryBankBalanceByFutureHandler(handler);
	}

	///期货发起银行资金转期货错误回报
	CTP_API void CTPCALL TdSetOnErrRtnBankToFutureByFutureHandler(void* spi, OnErrRtnBankToFutureByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnBankToFutureByFutureHandler(handler);
	}

	///期货发起期货资金转银行错误回报
	CTP_API void CTPCALL TdSetOnErrRtnFutureToBankByFutureHandler(void* spi, OnErrRtnFutureToBankByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnFutureToBankByFutureHandler(handler);
	}

	///系统运行时期货端手工发起冲正银行转期货错误回报
	CTP_API void CTPCALL TdSetOnErrRtnRepealBankToFutureByFutureManualHandler(void* spi, OnErrRtnRepealBankToFutureByFutureManualHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnRepealBankToFutureByFutureManualHandler(handler);
	}

	///系统运行时期货端手工发起冲正期货转银行错误回报
	CTP_API void CTPCALL TdSetOnErrRtnRepealFutureToBankByFutureManualHandler(void* spi, OnErrRtnRepealFutureToBankByFutureManualHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnRepealFutureToBankByFutureManualHandler(handler);
	}

	///期货发起查询银行余额错误回报
	CTP_API void CTPCALL TdSetOnErrRtnQueryBankBalanceByFutureHandler(void* spi, OnErrRtnQueryBankBalanceByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnErrRtnQueryBankBalanceByFutureHandler(handler);
	}

	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	CTP_API void CTPCALL TdSetOnRtnRepealFromBankToFutureByFutureHandler(void* spi, OnRtnRepealFromBankToFutureByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnRepealFromBankToFutureByFutureHandler(handler);
	}

	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	CTP_API void CTPCALL TdSetOnRtnRepealFromFutureToBankByFutureHandler(void* spi, OnRtnRepealFromFutureToBankByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnRepealFromFutureToBankByFutureHandler(handler);
	}

	///期货发起银行资金转期货应答
	CTP_API void CTPCALL TdSetOnRspFromBankToFutureByFutureHandler(void* spi, OnRspFromBankToFutureByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspFromBankToFutureByFutureHandler(handler);
	}

	///期货发起期货资金转银行应答
	CTP_API void CTPCALL TdSetOnRspFromFutureToBankByFutureHandler(void* spi, OnRspFromFutureToBankByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspFromFutureToBankByFutureHandler(handler);
	}

	///期货发起查询银行余额应答
	CTP_API void CTPCALL TdSetOnRspQueryBankAccountMoneyByFutureHandler(void* spi, OnRspQueryBankAccountMoneyByFutureHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQueryBankAccountMoneyByFutureHandler(handler);
	}

	///银行发起银期开户通知
	CTP_API void CTPCALL TdSetOnRtnOpenAccountByBankHandler(void* spi, OnRtnOpenAccountByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnOpenAccountByBankHandler(handler);
	}

	///银行发起银期销户通知
	CTP_API void CTPCALL TdSetOnRtnCancelAccountByBankHandler(void* spi, OnRtnCancelAccountByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnCancelAccountByBankHandler(handler);
	}

	///银行发起变更银行账号通知
	CTP_API void CTPCALL TdSetOnRtnChangeAccountByBankHandler(void* spi, OnRtnChangeAccountByBankHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRtnChangeAccountByBankHandler(handler);
	}

	///请求查询分类合约响应
	CTP_API void CTPCALL TdSetOnRspQryClassifiedInstrumentHandler(void* spi, OnRspQryClassifiedInstrumentHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryClassifiedInstrumentHandler(handler);
	}

	///请求组合优惠比例响应
	CTP_API void CTPCALL TdSetOnRspQryCombPromotionParamHandler(void* spi, OnRspQryCombPromotionParamHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryCombPromotionParamHandler(handler);
	}

	///投资者风险结算持仓查询响应
	CTP_API void CTPCALL TdSetOnRspQryRiskSettleInvstPositionHandler(void* spi, OnRspQryRiskSettleInvstPositionHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryRiskSettleInvstPositionHandler(handler);
	}

	///风险结算产品查询响应
	CTP_API void CTPCALL TdSetOnRspQryRiskSettleProductStatusHandler(void* spi, OnRspQryRiskSettleProductStatusHandler handler) {
		(static_cast<CTraderHandler*>(spi))->SetOnRspQryRiskSettleProductStatusHandler(handler);
	}


    ///删除接口对象本身
	///@remark 不再使用本接口对象时,调用该函数删除接口对象
    CTP_API void CTPCALL MdRelease(void * spi) {
        if(spi) delete spi;
    }

    CTP_API void CTPCALL MdInit(void * spi) {
        (static_cast<CQuoterHandler*>(spi))->Api()->Init();
    }

    CTP_API int CTPCALL MdJoin(void * spi) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->Join();
    }

    CTP_API const char* CTPCALL MdGetTradingDay(void * spi) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->GetTradingDay();
    }

    CTP_API void CTPCALL MdRegisterFront(void * spi,char *pszFrontAddress) {
        (static_cast<CQuoterHandler*>(spi))->Api()->RegisterFront(pszFrontAddress);
    }

    CTP_API void CTPCALL MdRegisterNameServer(void * spi,char *pszNsAddress) {
        (static_cast<CQuoterHandler*>(spi))->Api()->RegisterNameServer(pszNsAddress);
    }

    CTP_API void CTPCALL MdRegisterFensUserInfo(void * spi,CThostFtdcFensUserInfoField * pFensUserInfo) {
        (static_cast<CQuoterHandler*>(spi))->Api()->RegisterFensUserInfo(pFensUserInfo);
    }

    CTP_API void CTPCALL MdRegisterSpi(void * spi,CThostFtdcMdSpi *pSpi) {
        (static_cast<CQuoterHandler*>(spi))->Api()->RegisterSpi(pSpi);
    }

    CTP_API int CTPCALL MdSubscribeMarketData(void * spi,char *ppInstrumentID[], int nCount) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->SubscribeMarketData(ppInstrumentID,nCount);
    }

    CTP_API int CTPCALL MdUnSubscribeMarketData(void * spi,char *ppInstrumentID[], int nCount) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->UnSubscribeMarketData(ppInstrumentID,nCount);
    }

    CTP_API int CTPCALL MdSubscribeForQuoteRsp(void * spi,char *ppInstrumentID[], int nCount) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->SubscribeForQuoteRsp(ppInstrumentID,nCount);
    }

    CTP_API int CTPCALL MdUnSubscribeForQuoteRsp(void * spi,char *ppInstrumentID[], int nCount) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->UnSubscribeForQuoteRsp(ppInstrumentID,nCount);
    }

    CTP_API int CTPCALL MdReqUserLogin(void * spi,CThostFtdcReqUserLoginField *pReqUserLoginField, int nRequestID) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->ReqUserLogin(pReqUserLoginField,nRequestID);
    }

    CTP_API int CTPCALL MdReqUserLogout(void * spi,CThostFtdcUserLogoutField *pUserLogout, int nRequestID) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->ReqUserLogout(pUserLogout,nRequestID);
    }

    CTP_API int CTPCALL MdReqQryMulticastInstrument(void * spi,CThostFtdcQryMulticastInstrumentField *pQryMulticastInstrument, int nRequestID) {
        return (static_cast<CQuoterHandler*>(spi))->Api()->ReqQryMulticastInstrument(pQryMulticastInstrument,nRequestID);
    }
	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	CTP_API void CTPCALL MdSetOnFrontConnectedHandler(void* spi, OnFrontConnectedHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnFrontConnectedHandler(handler);
	}

	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	CTP_API void CTPCALL MdSetOnFrontDisconnectedHandler(void* spi, OnFrontDisconnectedHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnFrontDisconnectedHandler(handler);
	}

	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	CTP_API void CTPCALL MdSetOnHeartBeatWarningHandler(void* spi, OnHeartBeatWarningHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnHeartBeatWarningHandler(handler);
	}

	///登录请求响应
	CTP_API void CTPCALL MdSetOnRspUserLoginHandler(void* spi, OnRspUserLoginHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspUserLoginHandler(handler);
	}

	///登出请求响应
	CTP_API void CTPCALL MdSetOnRspUserLogoutHandler(void* spi, OnRspUserLogoutHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspUserLogoutHandler(handler);
	}

	///请求查询组播合约响应
	CTP_API void CTPCALL MdSetOnRspQryMulticastInstrumentHandler(void* spi, OnRspQryMulticastInstrumentHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspQryMulticastInstrumentHandler(handler);
	}

	///错误应答
	CTP_API void CTPCALL MdSetOnRspErrorHandler(void* spi, OnRspErrorHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspErrorHandler(handler);
	}

	///订阅行情应答
	CTP_API void CTPCALL MdSetOnRspSubMarketDataHandler(void* spi, OnRspSubMarketDataHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspSubMarketDataHandler(handler);
	}

	///取消订阅行情应答
	CTP_API void CTPCALL MdSetOnRspUnSubMarketDataHandler(void* spi, OnRspUnSubMarketDataHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspUnSubMarketDataHandler(handler);
	}

	///订阅询价应答
	CTP_API void CTPCALL MdSetOnRspSubForQuoteRspHandler(void* spi, OnRspSubForQuoteRspHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspSubForQuoteRspHandler(handler);
	}

	///取消订阅询价应答
	CTP_API void CTPCALL MdSetOnRspUnSubForQuoteRspHandler(void* spi, OnRspUnSubForQuoteRspHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRspUnSubForQuoteRspHandler(handler);
	}

	///深度行情通知
	CTP_API void CTPCALL MdSetOnRtnDepthMarketDataHandler(void* spi, OnRtnDepthMarketDataHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRtnDepthMarketDataHandler(handler);
	}

	///询价通知
	CTP_API void CTPCALL MdSetOnRtnForQuoteRspHandler(void* spi, OnRtnForQuoteRspHandler handler) {
		(static_cast<CQuoterHandler*>(spi))->SetOnRtnForQuoteRspHandler(handler);
	}



#ifdef __cplusplus
}
#endif
