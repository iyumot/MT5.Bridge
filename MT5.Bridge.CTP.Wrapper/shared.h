#pragma once

#ifdef _WIN64
#include "./ctp/x64/ThostFtdcUserApiDataType.h"
#include "./ctp/x64/ThostFtdcUserApiStruct.h"
#include "./ctp/x64/ThostFtdcMdApi.h"
#include "./ctp/x64/ThostFtdcTraderApi.h"
#else
#include "./ctp/x86/ThostFtdcUserApiDataType.h "
#include "./ctp/x86/ThostFtdcUserApiStruct.h"
#include "./ctp/x86/ThostFtdcMdApi.h"
#include "./ctp/x86/ThostFtdcTraderApi.h"
#endif


#define CTP_API extern __declspec(dllexport) 
#define CTPCALL	__stdcall 


///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
typedef void(CTPCALL *OnFrontConnectedHandler)();
///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
///@param nReason 错误原因
///        0x1001 网络读失败
///        0x1002 网络写失败
///        0x2001 接收心跳超时
///        0x2002 发送心跳失败
///        0x2003 收到错误报文
typedef void(CTPCALL *OnFrontDisconnectedHandler)(int nReason);
///心跳超时警告。当长时间未收到报文时，该方法被调用。
///@param nTimeLapse 距离上次接收报文的时间
typedef void(CTPCALL *OnHeartBeatWarningHandler)(int nTimeLapse);
///客户端认证响应
typedef void(CTPCALL *OnRspAuthenticateHandler)(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///登录请求响应
typedef void(CTPCALL *OnRspUserLoginHandler)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///登出请求响应
typedef void(CTPCALL *OnRspUserLogoutHandler)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///用户口令更新请求响应
typedef void(CTPCALL *OnRspUserPasswordUpdateHandler)(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///资金账户口令更新请求响应
typedef void(CTPCALL *OnRspTradingAccountPasswordUpdateHandler)(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///查询用户当前支持的认证模式的回复
typedef void(CTPCALL *OnRspUserAuthMethodHandler)(CThostFtdcRspUserAuthMethodField *pRspUserAuthMethod, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///获取图形验证码请求的回复
typedef void(CTPCALL *OnRspGenUserCaptchaHandler)(CThostFtdcRspGenUserCaptchaField *pRspGenUserCaptcha, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///获取短信验证码请求的回复
typedef void(CTPCALL *OnRspGenUserTextHandler)(CThostFtdcRspGenUserTextField *pRspGenUserText, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///报单录入请求响应
typedef void(CTPCALL *OnRspOrderInsertHandler)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///预埋单录入请求响应
typedef void(CTPCALL *OnRspParkedOrderInsertHandler)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///预埋撤单录入请求响应
typedef void(CTPCALL *OnRspParkedOrderActionHandler)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///报单操作请求响应
typedef void(CTPCALL *OnRspOrderActionHandler)(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///查询最大报单数量响应
typedef void(CTPCALL *OnRspQryMaxOrderVolumeHandler)(CThostFtdcQryMaxOrderVolumeField *pQryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///投资者结算结果确认响应
typedef void(CTPCALL *OnRspSettlementInfoConfirmHandler)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///删除预埋单响应
typedef void(CTPCALL *OnRspRemoveParkedOrderHandler)(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///删除预埋撤单响应
typedef void(CTPCALL *OnRspRemoveParkedOrderActionHandler)(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///执行宣告录入请求响应
typedef void(CTPCALL *OnRspExecOrderInsertHandler)(CThostFtdcInputExecOrderField *pInputExecOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///执行宣告操作请求响应
typedef void(CTPCALL *OnRspExecOrderActionHandler)(CThostFtdcInputExecOrderActionField *pInputExecOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///询价录入请求响应
typedef void(CTPCALL *OnRspForQuoteInsertHandler)(CThostFtdcInputForQuoteField *pInputForQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///报价录入请求响应
typedef void(CTPCALL *OnRspQuoteInsertHandler)(CThostFtdcInputQuoteField *pInputQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///报价操作请求响应
typedef void(CTPCALL *OnRspQuoteActionHandler)(CThostFtdcInputQuoteActionField *pInputQuoteAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///批量报单操作请求响应
typedef void(CTPCALL *OnRspBatchOrderActionHandler)(CThostFtdcInputBatchOrderActionField *pInputBatchOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///期权自对冲录入请求响应
typedef void(CTPCALL *OnRspOptionSelfCloseInsertHandler)(CThostFtdcInputOptionSelfCloseField *pInputOptionSelfClose, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///期权自对冲操作请求响应
typedef void(CTPCALL *OnRspOptionSelfCloseActionHandler)(CThostFtdcInputOptionSelfCloseActionField *pInputOptionSelfCloseAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///申请组合录入请求响应
typedef void(CTPCALL *OnRspCombActionInsertHandler)(CThostFtdcInputCombActionField *pInputCombAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询报单响应
typedef void(CTPCALL *OnRspQryOrderHandler)(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询成交响应
typedef void(CTPCALL *OnRspQryTradeHandler)(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资者持仓响应
typedef void(CTPCALL *OnRspQryInvestorPositionHandler)(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询资金账户响应
typedef void(CTPCALL *OnRspQryTradingAccountHandler)(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资者响应
typedef void(CTPCALL *OnRspQryInvestorHandler)(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询交易编码响应
typedef void(CTPCALL *OnRspQryTradingCodeHandler)(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询合约保证金率响应
typedef void(CTPCALL *OnRspQryInstrumentMarginRateHandler)(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询合约手续费率响应
typedef void(CTPCALL *OnRspQryInstrumentCommissionRateHandler)(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询交易所响应
typedef void(CTPCALL *OnRspQryExchangeHandler)(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询产品响应
typedef void(CTPCALL *OnRspQryProductHandler)(CThostFtdcProductField *pProduct, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询合约响应
typedef void(CTPCALL *OnRspQryInstrumentHandler)(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询行情响应
typedef void(CTPCALL *OnRspQryDepthMarketDataHandler)(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询交易员报盘机响应
typedef void(CTPCALL *OnRspQryTraderOfferHandler)(CThostFtdcTraderOfferField *pTraderOffer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资者结算结果响应
typedef void(CTPCALL *OnRspQrySettlementInfoHandler)(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询转帐银行响应
typedef void(CTPCALL *OnRspQryTransferBankHandler)(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资者持仓明细响应
typedef void(CTPCALL *OnRspQryInvestorPositionDetailHandler)(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询客户通知响应
typedef void(CTPCALL *OnRspQryNoticeHandler)(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询结算信息确认响应
typedef void(CTPCALL *OnRspQrySettlementInfoConfirmHandler)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资者持仓明细响应
typedef void(CTPCALL *OnRspQryInvestorPositionCombineDetailHandler)(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///查询保证金监管系统经纪公司资金账户密钥响应
typedef void(CTPCALL *OnRspQryCFMMCTradingAccountKeyHandler)(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询仓单折抵信息响应
typedef void(CTPCALL *OnRspQryEWarrantOffsetHandler)(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资者品种/跨品种保证金响应
typedef void(CTPCALL *OnRspQryInvestorProductGroupMarginHandler)(CThostFtdcInvestorProductGroupMarginField *pInvestorProductGroupMargin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询交易所保证金率响应
typedef void(CTPCALL *OnRspQryExchangeMarginRateHandler)(CThostFtdcExchangeMarginRateField *pExchangeMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询交易所调整保证金率响应
typedef void(CTPCALL *OnRspQryExchangeMarginRateAdjustHandler)(CThostFtdcExchangeMarginRateAdjustField *pExchangeMarginRateAdjust, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询汇率响应
typedef void(CTPCALL *OnRspQryExchangeRateHandler)(CThostFtdcExchangeRateField *pExchangeRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询二级代理操作员银期权限响应
typedef void(CTPCALL *OnRspQrySecAgentACIDMapHandler)(CThostFtdcSecAgentACIDMapField *pSecAgentACIDMap, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询产品报价汇率
typedef void(CTPCALL *OnRspQryProductExchRateHandler)(CThostFtdcProductExchRateField *pProductExchRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询产品组
typedef void(CTPCALL *OnRspQryProductGroupHandler)(CThostFtdcProductGroupField *pProductGroup, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询做市商合约手续费率响应
typedef void(CTPCALL *OnRspQryMMInstrumentCommissionRateHandler)(CThostFtdcMMInstrumentCommissionRateField *pMMInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询做市商期权合约手续费响应
typedef void(CTPCALL *OnRspQryMMOptionInstrCommRateHandler)(CThostFtdcMMOptionInstrCommRateField *pMMOptionInstrCommRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询报单手续费响应
typedef void(CTPCALL *OnRspQryInstrumentOrderCommRateHandler)(CThostFtdcInstrumentOrderCommRateField *pInstrumentOrderCommRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询资金账户响应
typedef void(CTPCALL *OnRspQrySecAgentTradingAccountHandler)(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询二级代理商资金校验模式响应
typedef void(CTPCALL *OnRspQrySecAgentCheckModeHandler)(CThostFtdcSecAgentCheckModeField *pSecAgentCheckMode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询二级代理商信息响应
typedef void(CTPCALL *OnRspQrySecAgentTradeInfoHandler)(CThostFtdcSecAgentTradeInfoField *pSecAgentTradeInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询期权交易成本响应
typedef void(CTPCALL *OnRspQryOptionInstrTradeCostHandler)(CThostFtdcOptionInstrTradeCostField *pOptionInstrTradeCost, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询期权合约手续费响应
typedef void(CTPCALL *OnRspQryOptionInstrCommRateHandler)(CThostFtdcOptionInstrCommRateField *pOptionInstrCommRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询执行宣告响应
typedef void(CTPCALL *OnRspQryExecOrderHandler)(CThostFtdcExecOrderField *pExecOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询询价响应
typedef void(CTPCALL *OnRspQryForQuoteHandler)(CThostFtdcForQuoteField *pForQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询报价响应
typedef void(CTPCALL *OnRspQryQuoteHandler)(CThostFtdcQuoteField *pQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询期权自对冲响应
typedef void(CTPCALL *OnRspQryOptionSelfCloseHandler)(CThostFtdcOptionSelfCloseField *pOptionSelfClose, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询投资单元响应
typedef void(CTPCALL *OnRspQryInvestUnitHandler)(CThostFtdcInvestUnitField *pInvestUnit, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询组合合约安全系数响应
typedef void(CTPCALL *OnRspQryCombInstrumentGuardHandler)(CThostFtdcCombInstrumentGuardField *pCombInstrumentGuard, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询申请组合响应
typedef void(CTPCALL *OnRspQryCombActionHandler)(CThostFtdcCombActionField *pCombAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询转帐流水响应
typedef void(CTPCALL *OnRspQryTransferSerialHandler)(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询银期签约关系响应
typedef void(CTPCALL *OnRspQryAccountregisterHandler)(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///错误应答
typedef void(CTPCALL *OnRspErrorHandler)(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///报单通知
typedef void(CTPCALL *OnRtnOrderHandler)(CThostFtdcOrderField *pOrder);
///成交通知
typedef void(CTPCALL *OnRtnTradeHandler)(CThostFtdcTradeField *pTrade);
///报单录入错误回报
typedef void(CTPCALL *OnErrRtnOrderInsertHandler)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo);
///报单操作错误回报
typedef void(CTPCALL *OnErrRtnOrderActionHandler)(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo);
///合约交易状态通知
typedef void(CTPCALL *OnRtnInstrumentStatusHandler)(CThostFtdcInstrumentStatusField *pInstrumentStatus);
///交易所公告通知
typedef void(CTPCALL *OnRtnBulletinHandler)(CThostFtdcBulletinField *pBulletin);
///交易通知
typedef void(CTPCALL *OnRtnTradingNoticeHandler)(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo);
///提示条件单校验错误
typedef void(CTPCALL *OnRtnErrorConditionalOrderHandler)(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder);
///执行宣告通知
typedef void(CTPCALL *OnRtnExecOrderHandler)(CThostFtdcExecOrderField *pExecOrder);
///执行宣告录入错误回报
typedef void(CTPCALL *OnErrRtnExecOrderInsertHandler)(CThostFtdcInputExecOrderField *pInputExecOrder, CThostFtdcRspInfoField *pRspInfo);
///执行宣告操作错误回报
typedef void(CTPCALL *OnErrRtnExecOrderActionHandler)(CThostFtdcExecOrderActionField *pExecOrderAction, CThostFtdcRspInfoField *pRspInfo);
///询价录入错误回报
typedef void(CTPCALL *OnErrRtnForQuoteInsertHandler)(CThostFtdcInputForQuoteField *pInputForQuote, CThostFtdcRspInfoField *pRspInfo);
///报价通知
typedef void(CTPCALL *OnRtnQuoteHandler)(CThostFtdcQuoteField *pQuote);
///报价录入错误回报
typedef void(CTPCALL *OnErrRtnQuoteInsertHandler)(CThostFtdcInputQuoteField *pInputQuote, CThostFtdcRspInfoField *pRspInfo);
///报价操作错误回报
typedef void(CTPCALL *OnErrRtnQuoteActionHandler)(CThostFtdcQuoteActionField *pQuoteAction, CThostFtdcRspInfoField *pRspInfo);
///询价通知
typedef void(CTPCALL *OnRtnForQuoteRspHandler)(CThostFtdcForQuoteRspField *pForQuoteRsp);
///保证金监控中心用户令牌
typedef void(CTPCALL *OnRtnCFMMCTradingAccountTokenHandler)(CThostFtdcCFMMCTradingAccountTokenField *pCFMMCTradingAccountToken);
///批量报单操作错误回报
typedef void(CTPCALL *OnErrRtnBatchOrderActionHandler)(CThostFtdcBatchOrderActionField *pBatchOrderAction, CThostFtdcRspInfoField *pRspInfo);
///期权自对冲通知
typedef void(CTPCALL *OnRtnOptionSelfCloseHandler)(CThostFtdcOptionSelfCloseField *pOptionSelfClose);
///期权自对冲录入错误回报
typedef void(CTPCALL *OnErrRtnOptionSelfCloseInsertHandler)(CThostFtdcInputOptionSelfCloseField *pInputOptionSelfClose, CThostFtdcRspInfoField *pRspInfo);
///期权自对冲操作错误回报
typedef void(CTPCALL *OnErrRtnOptionSelfCloseActionHandler)(CThostFtdcOptionSelfCloseActionField *pOptionSelfCloseAction, CThostFtdcRspInfoField *pRspInfo);
///申请组合通知
typedef void(CTPCALL *OnRtnCombActionHandler)(CThostFtdcCombActionField *pCombAction);
///申请组合录入错误回报
typedef void(CTPCALL *OnErrRtnCombActionInsertHandler)(CThostFtdcInputCombActionField *pInputCombAction, CThostFtdcRspInfoField *pRspInfo);
///请求查询签约银行响应
typedef void(CTPCALL *OnRspQryContractBankHandler)(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询预埋单响应
typedef void(CTPCALL *OnRspQryParkedOrderHandler)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询预埋撤单响应
typedef void(CTPCALL *OnRspQryParkedOrderActionHandler)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询交易通知响应
typedef void(CTPCALL *OnRspQryTradingNoticeHandler)(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询经纪公司交易参数响应
typedef void(CTPCALL *OnRspQryBrokerTradingParamsHandler)(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询经纪公司交易算法响应
typedef void(CTPCALL *OnRspQryBrokerTradingAlgosHandler)(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询监控中心用户令牌
typedef void(CTPCALL *OnRspQueryCFMMCTradingAccountTokenHandler)(CThostFtdcQueryCFMMCTradingAccountTokenField *pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///银行发起银行资金转期货通知
typedef void(CTPCALL *OnRtnFromBankToFutureByBankHandler)(CThostFtdcRspTransferField *pRspTransfer);
///银行发起期货资金转银行通知
typedef void(CTPCALL *OnRtnFromFutureToBankByBankHandler)(CThostFtdcRspTransferField *pRspTransfer);
///银行发起冲正银行转期货通知
typedef void(CTPCALL *OnRtnRepealFromBankToFutureByBankHandler)(CThostFtdcRspRepealField *pRspRepeal);
///银行发起冲正期货转银行通知
typedef void(CTPCALL *OnRtnRepealFromFutureToBankByBankHandler)(CThostFtdcRspRepealField *pRspRepeal);
///期货发起银行资金转期货通知
typedef void(CTPCALL *OnRtnFromBankToFutureByFutureHandler)(CThostFtdcRspTransferField *pRspTransfer);
///期货发起期货资金转银行通知
typedef void(CTPCALL *OnRtnFromFutureToBankByFutureHandler)(CThostFtdcRspTransferField *pRspTransfer);
///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
typedef void(CTPCALL *OnRtnRepealFromBankToFutureByFutureManualHandler)(CThostFtdcRspRepealField *pRspRepeal);
///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
typedef void(CTPCALL *OnRtnRepealFromFutureToBankByFutureManualHandler)(CThostFtdcRspRepealField *pRspRepeal);
///期货发起查询银行余额通知
typedef void(CTPCALL *OnRtnQueryBankBalanceByFutureHandler)(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount);
///期货发起银行资金转期货错误回报
typedef void(CTPCALL *OnErrRtnBankToFutureByFutureHandler)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo);
///期货发起期货资金转银行错误回报
typedef void(CTPCALL *OnErrRtnFutureToBankByFutureHandler)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo);
///系统运行时期货端手工发起冲正银行转期货错误回报
typedef void(CTPCALL *OnErrRtnRepealBankToFutureByFutureManualHandler)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo);
///系统运行时期货端手工发起冲正期货转银行错误回报
typedef void(CTPCALL *OnErrRtnRepealFutureToBankByFutureManualHandler)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo);
///期货发起查询银行余额错误回报
typedef void(CTPCALL *OnErrRtnQueryBankBalanceByFutureHandler)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo);
///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
typedef void(CTPCALL *OnRtnRepealFromBankToFutureByFutureHandler)(CThostFtdcRspRepealField *pRspRepeal);
///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
typedef void(CTPCALL *OnRtnRepealFromFutureToBankByFutureHandler)(CThostFtdcRspRepealField *pRspRepeal);
///期货发起银行资金转期货应答
typedef void(CTPCALL *OnRspFromBankToFutureByFutureHandler)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///期货发起期货资金转银行应答
typedef void(CTPCALL *OnRspFromFutureToBankByFutureHandler)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///期货发起查询银行余额应答
typedef void(CTPCALL *OnRspQueryBankAccountMoneyByFutureHandler)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///银行发起银期开户通知
typedef void(CTPCALL *OnRtnOpenAccountByBankHandler)(CThostFtdcOpenAccountField *pOpenAccount);
///银行发起银期销户通知
typedef void(CTPCALL *OnRtnCancelAccountByBankHandler)(CThostFtdcCancelAccountField *pCancelAccount);
///银行发起变更银行账号通知
typedef void(CTPCALL *OnRtnChangeAccountByBankHandler)(CThostFtdcChangeAccountField *pChangeAccount);
///请求查询分类合约响应
typedef void(CTPCALL *OnRspQryClassifiedInstrumentHandler)(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求组合优惠比例响应
typedef void(CTPCALL *OnRspQryCombPromotionParamHandler)(CThostFtdcCombPromotionParamField *pCombPromotionParam, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///投资者风险结算持仓查询响应
typedef void(CTPCALL *OnRspQryRiskSettleInvstPositionHandler)(CThostFtdcRiskSettleInvstPositionField *pRiskSettleInvstPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///风险结算产品查询响应
typedef void(CTPCALL *OnRspQryRiskSettleProductStatusHandler)(CThostFtdcRiskSettleProductStatusField *pRiskSettleProductStatus, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///请求查询组播合约响应
typedef void(CTPCALL *OnRspQryMulticastInstrumentHandler)(CThostFtdcMulticastInstrumentField *pMulticastInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///订阅行情应答
typedef void(CTPCALL *OnRspSubMarketDataHandler)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///取消订阅行情应答
typedef void(CTPCALL *OnRspUnSubMarketDataHandler)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///订阅询价应答
typedef void(CTPCALL *OnRspSubForQuoteRspHandler)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///取消订阅询价应答
typedef void(CTPCALL *OnRspUnSubForQuoteRspHandler)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///深度行情通知
typedef void(CTPCALL *OnRtnDepthMarketDataHandler)(CThostFtdcDepthMarketDataField *pDepthMarketData);
