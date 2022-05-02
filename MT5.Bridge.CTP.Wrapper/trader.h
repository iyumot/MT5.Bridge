#pragma once

#include "shared.h"



class CTraderHandler : public CThostFtdcTraderSpi
{
private:
	CThostFtdcTraderApi* api;

	const char* m_flow_path;
 
public:
	CThostFtdcTraderApi* Api() { return api; }

public:
	CTraderHandler(const char* path) :m_flow_path(path)
	{
		api = CThostFtdcTraderApi::CreateFtdcTraderApi(path);
		api->RegisterSpi(this);
	}

	~CTraderHandler()
	{
		if (api != nullptr)
		{ 
			api->Release();
			api = nullptr;
		}
	}

private:

	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	OnFrontConnectedHandler _OnFrontConnectedHandler = nullptr;
	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	OnFrontDisconnectedHandler _OnFrontDisconnectedHandler = nullptr;
	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	OnHeartBeatWarningHandler _OnHeartBeatWarningHandler = nullptr;
	///客户端认证响应
	OnRspAuthenticateHandler _OnRspAuthenticateHandler = nullptr;
	///登录请求响应
	OnRspUserLoginHandler _OnRspUserLoginHandler = nullptr;
	///登出请求响应
	OnRspUserLogoutHandler _OnRspUserLogoutHandler = nullptr;
	///用户口令更新请求响应
	OnRspUserPasswordUpdateHandler _OnRspUserPasswordUpdateHandler = nullptr;
	///资金账户口令更新请求响应
	OnRspTradingAccountPasswordUpdateHandler _OnRspTradingAccountPasswordUpdateHandler = nullptr;
	///查询用户当前支持的认证模式的回复
	OnRspUserAuthMethodHandler _OnRspUserAuthMethodHandler = nullptr;
	///获取图形验证码请求的回复
	OnRspGenUserCaptchaHandler _OnRspGenUserCaptchaHandler = nullptr;
	///获取短信验证码请求的回复
	OnRspGenUserTextHandler _OnRspGenUserTextHandler = nullptr;
	///报单录入请求响应
	OnRspOrderInsertHandler _OnRspOrderInsertHandler = nullptr;
	///预埋单录入请求响应
	OnRspParkedOrderInsertHandler _OnRspParkedOrderInsertHandler = nullptr;
	///预埋撤单录入请求响应
	OnRspParkedOrderActionHandler _OnRspParkedOrderActionHandler = nullptr;
	///报单操作请求响应
	OnRspOrderActionHandler _OnRspOrderActionHandler = nullptr;
	///查询最大报单数量响应
	OnRspQryMaxOrderVolumeHandler _OnRspQryMaxOrderVolumeHandler = nullptr;
	///投资者结算结果确认响应
	OnRspSettlementInfoConfirmHandler _OnRspSettlementInfoConfirmHandler = nullptr;
	///删除预埋单响应
	OnRspRemoveParkedOrderHandler _OnRspRemoveParkedOrderHandler = nullptr;
	///删除预埋撤单响应
	OnRspRemoveParkedOrderActionHandler _OnRspRemoveParkedOrderActionHandler = nullptr;
	///执行宣告录入请求响应
	OnRspExecOrderInsertHandler _OnRspExecOrderInsertHandler = nullptr;
	///执行宣告操作请求响应
	OnRspExecOrderActionHandler _OnRspExecOrderActionHandler = nullptr;
	///询价录入请求响应
	OnRspForQuoteInsertHandler _OnRspForQuoteInsertHandler = nullptr;
	///报价录入请求响应
	OnRspQuoteInsertHandler _OnRspQuoteInsertHandler = nullptr;
	///报价操作请求响应
	OnRspQuoteActionHandler _OnRspQuoteActionHandler = nullptr;
	///批量报单操作请求响应
	OnRspBatchOrderActionHandler _OnRspBatchOrderActionHandler = nullptr;
	///期权自对冲录入请求响应
	OnRspOptionSelfCloseInsertHandler _OnRspOptionSelfCloseInsertHandler = nullptr;
	///期权自对冲操作请求响应
	OnRspOptionSelfCloseActionHandler _OnRspOptionSelfCloseActionHandler = nullptr;
	///申请组合录入请求响应
	OnRspCombActionInsertHandler _OnRspCombActionInsertHandler = nullptr;
	///请求查询报单响应
	OnRspQryOrderHandler _OnRspQryOrderHandler = nullptr;
	///请求查询成交响应
	OnRspQryTradeHandler _OnRspQryTradeHandler = nullptr;
	///请求查询投资者持仓响应
	OnRspQryInvestorPositionHandler _OnRspQryInvestorPositionHandler = nullptr;
	///请求查询资金账户响应
	OnRspQryTradingAccountHandler _OnRspQryTradingAccountHandler = nullptr;
	///请求查询投资者响应
	OnRspQryInvestorHandler _OnRspQryInvestorHandler = nullptr;
	///请求查询交易编码响应
	OnRspQryTradingCodeHandler _OnRspQryTradingCodeHandler = nullptr;
	///请求查询合约保证金率响应
	OnRspQryInstrumentMarginRateHandler _OnRspQryInstrumentMarginRateHandler = nullptr;
	///请求查询合约手续费率响应
	OnRspQryInstrumentCommissionRateHandler _OnRspQryInstrumentCommissionRateHandler = nullptr;
	///请求查询交易所响应
	OnRspQryExchangeHandler _OnRspQryExchangeHandler = nullptr;
	///请求查询产品响应
	OnRspQryProductHandler _OnRspQryProductHandler = nullptr;
	///请求查询合约响应
	OnRspQryInstrumentHandler _OnRspQryInstrumentHandler = nullptr;
	///请求查询行情响应
	OnRspQryDepthMarketDataHandler _OnRspQryDepthMarketDataHandler = nullptr;
	///请求查询交易员报盘机响应
	OnRspQryTraderOfferHandler _OnRspQryTraderOfferHandler = nullptr;
	///请求查询投资者结算结果响应
	OnRspQrySettlementInfoHandler _OnRspQrySettlementInfoHandler = nullptr;
	///请求查询转帐银行响应
	OnRspQryTransferBankHandler _OnRspQryTransferBankHandler = nullptr;
	///请求查询投资者持仓明细响应
	OnRspQryInvestorPositionDetailHandler _OnRspQryInvestorPositionDetailHandler = nullptr;
	///请求查询客户通知响应
	OnRspQryNoticeHandler _OnRspQryNoticeHandler = nullptr;
	///请求查询结算信息确认响应
	OnRspQrySettlementInfoConfirmHandler _OnRspQrySettlementInfoConfirmHandler = nullptr;
	///请求查询投资者持仓明细响应
	OnRspQryInvestorPositionCombineDetailHandler _OnRspQryInvestorPositionCombineDetailHandler = nullptr;
	///查询保证金监管系统经纪公司资金账户密钥响应
	OnRspQryCFMMCTradingAccountKeyHandler _OnRspQryCFMMCTradingAccountKeyHandler = nullptr;
	///请求查询仓单折抵信息响应
	OnRspQryEWarrantOffsetHandler _OnRspQryEWarrantOffsetHandler = nullptr;
	///请求查询投资者品种/跨品种保证金响应
	OnRspQryInvestorProductGroupMarginHandler _OnRspQryInvestorProductGroupMarginHandler = nullptr;
	///请求查询交易所保证金率响应
	OnRspQryExchangeMarginRateHandler _OnRspQryExchangeMarginRateHandler = nullptr;
	///请求查询交易所调整保证金率响应
	OnRspQryExchangeMarginRateAdjustHandler _OnRspQryExchangeMarginRateAdjustHandler = nullptr;
	///请求查询汇率响应
	OnRspQryExchangeRateHandler _OnRspQryExchangeRateHandler = nullptr;
	///请求查询二级代理操作员银期权限响应
	OnRspQrySecAgentACIDMapHandler _OnRspQrySecAgentACIDMapHandler = nullptr;
	///请求查询产品报价汇率
	OnRspQryProductExchRateHandler _OnRspQryProductExchRateHandler = nullptr;
	///请求查询产品组
	OnRspQryProductGroupHandler _OnRspQryProductGroupHandler = nullptr;
	///请求查询做市商合约手续费率响应
	OnRspQryMMInstrumentCommissionRateHandler _OnRspQryMMInstrumentCommissionRateHandler = nullptr;
	///请求查询做市商期权合约手续费响应
	OnRspQryMMOptionInstrCommRateHandler _OnRspQryMMOptionInstrCommRateHandler = nullptr;
	///请求查询报单手续费响应
	OnRspQryInstrumentOrderCommRateHandler _OnRspQryInstrumentOrderCommRateHandler = nullptr;
	///请求查询资金账户响应
	OnRspQrySecAgentTradingAccountHandler _OnRspQrySecAgentTradingAccountHandler = nullptr;
	///请求查询二级代理商资金校验模式响应
	OnRspQrySecAgentCheckModeHandler _OnRspQrySecAgentCheckModeHandler = nullptr;
	///请求查询二级代理商信息响应
	OnRspQrySecAgentTradeInfoHandler _OnRspQrySecAgentTradeInfoHandler = nullptr;
	///请求查询期权交易成本响应
	OnRspQryOptionInstrTradeCostHandler _OnRspQryOptionInstrTradeCostHandler = nullptr;
	///请求查询期权合约手续费响应
	OnRspQryOptionInstrCommRateHandler _OnRspQryOptionInstrCommRateHandler = nullptr;
	///请求查询执行宣告响应
	OnRspQryExecOrderHandler _OnRspQryExecOrderHandler = nullptr;
	///请求查询询价响应
	OnRspQryForQuoteHandler _OnRspQryForQuoteHandler = nullptr;
	///请求查询报价响应
	OnRspQryQuoteHandler _OnRspQryQuoteHandler = nullptr;
	///请求查询期权自对冲响应
	OnRspQryOptionSelfCloseHandler _OnRspQryOptionSelfCloseHandler = nullptr;
	///请求查询投资单元响应
	OnRspQryInvestUnitHandler _OnRspQryInvestUnitHandler = nullptr;
	///请求查询组合合约安全系数响应
	OnRspQryCombInstrumentGuardHandler _OnRspQryCombInstrumentGuardHandler = nullptr;
	///请求查询申请组合响应
	OnRspQryCombActionHandler _OnRspQryCombActionHandler = nullptr;
	///请求查询转帐流水响应
	OnRspQryTransferSerialHandler _OnRspQryTransferSerialHandler = nullptr;
	///请求查询银期签约关系响应
	OnRspQryAccountregisterHandler _OnRspQryAccountregisterHandler = nullptr;
	///错误应答
	OnRspErrorHandler _OnRspErrorHandler = nullptr;
	///报单通知
	OnRtnOrderHandler _OnRtnOrderHandler = nullptr;
	///成交通知
	OnRtnTradeHandler _OnRtnTradeHandler = nullptr;
	///报单录入错误回报
	OnErrRtnOrderInsertHandler _OnErrRtnOrderInsertHandler = nullptr;
	///报单操作错误回报
	OnErrRtnOrderActionHandler _OnErrRtnOrderActionHandler = nullptr;
	///合约交易状态通知
	OnRtnInstrumentStatusHandler _OnRtnInstrumentStatusHandler = nullptr;
	///交易所公告通知
	OnRtnBulletinHandler _OnRtnBulletinHandler = nullptr;
	///交易通知
	OnRtnTradingNoticeHandler _OnRtnTradingNoticeHandler = nullptr;
	///提示条件单校验错误
	OnRtnErrorConditionalOrderHandler _OnRtnErrorConditionalOrderHandler = nullptr;
	///执行宣告通知
	OnRtnExecOrderHandler _OnRtnExecOrderHandler = nullptr;
	///执行宣告录入错误回报
	OnErrRtnExecOrderInsertHandler _OnErrRtnExecOrderInsertHandler = nullptr;
	///执行宣告操作错误回报
	OnErrRtnExecOrderActionHandler _OnErrRtnExecOrderActionHandler = nullptr;
	///询价录入错误回报
	OnErrRtnForQuoteInsertHandler _OnErrRtnForQuoteInsertHandler = nullptr;
	///报价通知
	OnRtnQuoteHandler _OnRtnQuoteHandler = nullptr;
	///报价录入错误回报
	OnErrRtnQuoteInsertHandler _OnErrRtnQuoteInsertHandler = nullptr;
	///报价操作错误回报
	OnErrRtnQuoteActionHandler _OnErrRtnQuoteActionHandler = nullptr;
	///询价通知
	OnRtnForQuoteRspHandler _OnRtnForQuoteRspHandler = nullptr;
	///保证金监控中心用户令牌
	OnRtnCFMMCTradingAccountTokenHandler _OnRtnCFMMCTradingAccountTokenHandler = nullptr;
	///批量报单操作错误回报
	OnErrRtnBatchOrderActionHandler _OnErrRtnBatchOrderActionHandler = nullptr;
	///期权自对冲通知
	OnRtnOptionSelfCloseHandler _OnRtnOptionSelfCloseHandler = nullptr;
	///期权自对冲录入错误回报
	OnErrRtnOptionSelfCloseInsertHandler _OnErrRtnOptionSelfCloseInsertHandler = nullptr;
	///期权自对冲操作错误回报
	OnErrRtnOptionSelfCloseActionHandler _OnErrRtnOptionSelfCloseActionHandler = nullptr;
	///申请组合通知
	OnRtnCombActionHandler _OnRtnCombActionHandler = nullptr;
	///申请组合录入错误回报
	OnErrRtnCombActionInsertHandler _OnErrRtnCombActionInsertHandler = nullptr;
	///请求查询签约银行响应
	OnRspQryContractBankHandler _OnRspQryContractBankHandler = nullptr;
	///请求查询预埋单响应
	OnRspQryParkedOrderHandler _OnRspQryParkedOrderHandler = nullptr;
	///请求查询预埋撤单响应
	OnRspQryParkedOrderActionHandler _OnRspQryParkedOrderActionHandler = nullptr;
	///请求查询交易通知响应
	OnRspQryTradingNoticeHandler _OnRspQryTradingNoticeHandler = nullptr;
	///请求查询经纪公司交易参数响应
	OnRspQryBrokerTradingParamsHandler _OnRspQryBrokerTradingParamsHandler = nullptr;
	///请求查询经纪公司交易算法响应
	OnRspQryBrokerTradingAlgosHandler _OnRspQryBrokerTradingAlgosHandler = nullptr;
	///请求查询监控中心用户令牌
	OnRspQueryCFMMCTradingAccountTokenHandler _OnRspQueryCFMMCTradingAccountTokenHandler = nullptr;
	///银行发起银行资金转期货通知
	OnRtnFromBankToFutureByBankHandler _OnRtnFromBankToFutureByBankHandler = nullptr;
	///银行发起期货资金转银行通知
	OnRtnFromFutureToBankByBankHandler _OnRtnFromFutureToBankByBankHandler = nullptr;
	///银行发起冲正银行转期货通知
	OnRtnRepealFromBankToFutureByBankHandler _OnRtnRepealFromBankToFutureByBankHandler = nullptr;
	///银行发起冲正期货转银行通知
	OnRtnRepealFromFutureToBankByBankHandler _OnRtnRepealFromFutureToBankByBankHandler = nullptr;
	///期货发起银行资金转期货通知
	OnRtnFromBankToFutureByFutureHandler _OnRtnFromBankToFutureByFutureHandler = nullptr;
	///期货发起期货资金转银行通知
	OnRtnFromFutureToBankByFutureHandler _OnRtnFromFutureToBankByFutureHandler = nullptr;
	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	OnRtnRepealFromBankToFutureByFutureManualHandler _OnRtnRepealFromBankToFutureByFutureManualHandler = nullptr;
	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	OnRtnRepealFromFutureToBankByFutureManualHandler _OnRtnRepealFromFutureToBankByFutureManualHandler = nullptr;
	///期货发起查询银行余额通知
	OnRtnQueryBankBalanceByFutureHandler _OnRtnQueryBankBalanceByFutureHandler = nullptr;
	///期货发起银行资金转期货错误回报
	OnErrRtnBankToFutureByFutureHandler _OnErrRtnBankToFutureByFutureHandler = nullptr;
	///期货发起期货资金转银行错误回报
	OnErrRtnFutureToBankByFutureHandler _OnErrRtnFutureToBankByFutureHandler = nullptr;
	///系统运行时期货端手工发起冲正银行转期货错误回报
	OnErrRtnRepealBankToFutureByFutureManualHandler _OnErrRtnRepealBankToFutureByFutureManualHandler = nullptr;
	///系统运行时期货端手工发起冲正期货转银行错误回报
	OnErrRtnRepealFutureToBankByFutureManualHandler _OnErrRtnRepealFutureToBankByFutureManualHandler = nullptr;
	///期货发起查询银行余额错误回报
	OnErrRtnQueryBankBalanceByFutureHandler _OnErrRtnQueryBankBalanceByFutureHandler = nullptr;
	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	OnRtnRepealFromBankToFutureByFutureHandler _OnRtnRepealFromBankToFutureByFutureHandler = nullptr;
	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	OnRtnRepealFromFutureToBankByFutureHandler _OnRtnRepealFromFutureToBankByFutureHandler = nullptr;
	///期货发起银行资金转期货应答
	OnRspFromBankToFutureByFutureHandler _OnRspFromBankToFutureByFutureHandler = nullptr;
	///期货发起期货资金转银行应答
	OnRspFromFutureToBankByFutureHandler _OnRspFromFutureToBankByFutureHandler = nullptr;
	///期货发起查询银行余额应答
	OnRspQueryBankAccountMoneyByFutureHandler _OnRspQueryBankAccountMoneyByFutureHandler = nullptr;
	///银行发起银期开户通知
	OnRtnOpenAccountByBankHandler _OnRtnOpenAccountByBankHandler = nullptr;
	///银行发起银期销户通知
	OnRtnCancelAccountByBankHandler _OnRtnCancelAccountByBankHandler = nullptr;
	///银行发起变更银行账号通知
	OnRtnChangeAccountByBankHandler _OnRtnChangeAccountByBankHandler = nullptr;
	///请求查询分类合约响应
	OnRspQryClassifiedInstrumentHandler _OnRspQryClassifiedInstrumentHandler = nullptr;
	///请求组合优惠比例响应
	OnRspQryCombPromotionParamHandler _OnRspQryCombPromotionParamHandler = nullptr;
	///投资者风险结算持仓查询响应
	OnRspQryRiskSettleInvstPositionHandler _OnRspQryRiskSettleInvstPositionHandler = nullptr;
	///风险结算产品查询响应
	OnRspQryRiskSettleProductStatusHandler _OnRspQryRiskSettleProductStatusHandler = nullptr;

public:

	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	void SetOnFrontConnectedHandler(OnFrontConnectedHandler handler) {
		_OnFrontConnectedHandler = handler;
	}
	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	void SetOnFrontDisconnectedHandler(OnFrontDisconnectedHandler handler) {
		_OnFrontDisconnectedHandler = handler;
	}
	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	void SetOnHeartBeatWarningHandler(OnHeartBeatWarningHandler handler) {
		_OnHeartBeatWarningHandler = handler;
	}
	///客户端认证响应
	void SetOnRspAuthenticateHandler(OnRspAuthenticateHandler handler) {
		_OnRspAuthenticateHandler = handler;
	}
	///登录请求响应
	void SetOnRspUserLoginHandler(OnRspUserLoginHandler handler) {
		_OnRspUserLoginHandler = handler;
	}
	///登出请求响应
	void SetOnRspUserLogoutHandler(OnRspUserLogoutHandler handler) {
		_OnRspUserLogoutHandler = handler;
	}
	///用户口令更新请求响应
	void SetOnRspUserPasswordUpdateHandler(OnRspUserPasswordUpdateHandler handler) {
		_OnRspUserPasswordUpdateHandler = handler;
	}
	///资金账户口令更新请求响应
	void SetOnRspTradingAccountPasswordUpdateHandler(OnRspTradingAccountPasswordUpdateHandler handler) {
		_OnRspTradingAccountPasswordUpdateHandler = handler;
	}
	///查询用户当前支持的认证模式的回复
	void SetOnRspUserAuthMethodHandler(OnRspUserAuthMethodHandler handler) {
		_OnRspUserAuthMethodHandler = handler;
	}
	///获取图形验证码请求的回复
	void SetOnRspGenUserCaptchaHandler(OnRspGenUserCaptchaHandler handler) {
		_OnRspGenUserCaptchaHandler = handler;
	}
	///获取短信验证码请求的回复
	void SetOnRspGenUserTextHandler(OnRspGenUserTextHandler handler) {
		_OnRspGenUserTextHandler = handler;
	}
	///报单录入请求响应
	void SetOnRspOrderInsertHandler(OnRspOrderInsertHandler handler) {
		_OnRspOrderInsertHandler = handler;
	}
	///预埋单录入请求响应
	void SetOnRspParkedOrderInsertHandler(OnRspParkedOrderInsertHandler handler) {
		_OnRspParkedOrderInsertHandler = handler;
	}
	///预埋撤单录入请求响应
	void SetOnRspParkedOrderActionHandler(OnRspParkedOrderActionHandler handler) {
		_OnRspParkedOrderActionHandler = handler;
	}
	///报单操作请求响应
	void SetOnRspOrderActionHandler(OnRspOrderActionHandler handler) {
		_OnRspOrderActionHandler = handler;
	}
	///查询最大报单数量响应
	void SetOnRspQryMaxOrderVolumeHandler(OnRspQryMaxOrderVolumeHandler handler) {
		_OnRspQryMaxOrderVolumeHandler = handler;
	}
	///投资者结算结果确认响应
	void SetOnRspSettlementInfoConfirmHandler(OnRspSettlementInfoConfirmHandler handler) {
		_OnRspSettlementInfoConfirmHandler = handler;
	}
	///删除预埋单响应
	void SetOnRspRemoveParkedOrderHandler(OnRspRemoveParkedOrderHandler handler) {
		_OnRspRemoveParkedOrderHandler = handler;
	}
	///删除预埋撤单响应
	void SetOnRspRemoveParkedOrderActionHandler(OnRspRemoveParkedOrderActionHandler handler) {
		_OnRspRemoveParkedOrderActionHandler = handler;
	}
	///执行宣告录入请求响应
	void SetOnRspExecOrderInsertHandler(OnRspExecOrderInsertHandler handler) {
		_OnRspExecOrderInsertHandler = handler;
	}
	///执行宣告操作请求响应
	void SetOnRspExecOrderActionHandler(OnRspExecOrderActionHandler handler) {
		_OnRspExecOrderActionHandler = handler;
	}
	///询价录入请求响应
	void SetOnRspForQuoteInsertHandler(OnRspForQuoteInsertHandler handler) {
		_OnRspForQuoteInsertHandler = handler;
	}
	///报价录入请求响应
	void SetOnRspQuoteInsertHandler(OnRspQuoteInsertHandler handler) {
		_OnRspQuoteInsertHandler = handler;
	}
	///报价操作请求响应
	void SetOnRspQuoteActionHandler(OnRspQuoteActionHandler handler) {
		_OnRspQuoteActionHandler = handler;
	}
	///批量报单操作请求响应
	void SetOnRspBatchOrderActionHandler(OnRspBatchOrderActionHandler handler) {
		_OnRspBatchOrderActionHandler = handler;
	}
	///期权自对冲录入请求响应
	void SetOnRspOptionSelfCloseInsertHandler(OnRspOptionSelfCloseInsertHandler handler) {
		_OnRspOptionSelfCloseInsertHandler = handler;
	}
	///期权自对冲操作请求响应
	void SetOnRspOptionSelfCloseActionHandler(OnRspOptionSelfCloseActionHandler handler) {
		_OnRspOptionSelfCloseActionHandler = handler;
	}
	///申请组合录入请求响应
	void SetOnRspCombActionInsertHandler(OnRspCombActionInsertHandler handler) {
		_OnRspCombActionInsertHandler = handler;
	}
	///请求查询报单响应
	void SetOnRspQryOrderHandler(OnRspQryOrderHandler handler) {
		_OnRspQryOrderHandler = handler;
	}
	///请求查询成交响应
	void SetOnRspQryTradeHandler(OnRspQryTradeHandler handler) {
		_OnRspQryTradeHandler = handler;
	}
	///请求查询投资者持仓响应
	void SetOnRspQryInvestorPositionHandler(OnRspQryInvestorPositionHandler handler) {
		_OnRspQryInvestorPositionHandler = handler;
	}
	///请求查询资金账户响应
	void SetOnRspQryTradingAccountHandler(OnRspQryTradingAccountHandler handler) {
		_OnRspQryTradingAccountHandler = handler;
	}
	///请求查询投资者响应
	void SetOnRspQryInvestorHandler(OnRspQryInvestorHandler handler) {
		_OnRspQryInvestorHandler = handler;
	}
	///请求查询交易编码响应
	void SetOnRspQryTradingCodeHandler(OnRspQryTradingCodeHandler handler) {
		_OnRspQryTradingCodeHandler = handler;
	}
	///请求查询合约保证金率响应
	void SetOnRspQryInstrumentMarginRateHandler(OnRspQryInstrumentMarginRateHandler handler) {
		_OnRspQryInstrumentMarginRateHandler = handler;
	}
	///请求查询合约手续费率响应
	void SetOnRspQryInstrumentCommissionRateHandler(OnRspQryInstrumentCommissionRateHandler handler) {
		_OnRspQryInstrumentCommissionRateHandler = handler;
	}
	///请求查询交易所响应
	void SetOnRspQryExchangeHandler(OnRspQryExchangeHandler handler) {
		_OnRspQryExchangeHandler = handler;
	}
	///请求查询产品响应
	void SetOnRspQryProductHandler(OnRspQryProductHandler handler) {
		_OnRspQryProductHandler = handler;
	}
	///请求查询合约响应
	void SetOnRspQryInstrumentHandler(OnRspQryInstrumentHandler handler) {
		_OnRspQryInstrumentHandler = handler;
	}
	///请求查询行情响应
	void SetOnRspQryDepthMarketDataHandler(OnRspQryDepthMarketDataHandler handler) {
		_OnRspQryDepthMarketDataHandler = handler;
	}
	///请求查询交易员报盘机响应
	void SetOnRspQryTraderOfferHandler(OnRspQryTraderOfferHandler handler) {
		_OnRspQryTraderOfferHandler = handler;
	}
	///请求查询投资者结算结果响应
	void SetOnRspQrySettlementInfoHandler(OnRspQrySettlementInfoHandler handler) {
		_OnRspQrySettlementInfoHandler = handler;
	}
	///请求查询转帐银行响应
	void SetOnRspQryTransferBankHandler(OnRspQryTransferBankHandler handler) {
		_OnRspQryTransferBankHandler = handler;
	}
	///请求查询投资者持仓明细响应
	void SetOnRspQryInvestorPositionDetailHandler(OnRspQryInvestorPositionDetailHandler handler) {
		_OnRspQryInvestorPositionDetailHandler = handler;
	}
	///请求查询客户通知响应
	void SetOnRspQryNoticeHandler(OnRspQryNoticeHandler handler) {
		_OnRspQryNoticeHandler = handler;
	}
	///请求查询结算信息确认响应
	void SetOnRspQrySettlementInfoConfirmHandler(OnRspQrySettlementInfoConfirmHandler handler) {
		_OnRspQrySettlementInfoConfirmHandler = handler;
	}
	///请求查询投资者持仓明细响应
	void SetOnRspQryInvestorPositionCombineDetailHandler(OnRspQryInvestorPositionCombineDetailHandler handler) {
		_OnRspQryInvestorPositionCombineDetailHandler = handler;
	}
	///查询保证金监管系统经纪公司资金账户密钥响应
	void SetOnRspQryCFMMCTradingAccountKeyHandler(OnRspQryCFMMCTradingAccountKeyHandler handler) {
		_OnRspQryCFMMCTradingAccountKeyHandler = handler;
	}
	///请求查询仓单折抵信息响应
	void SetOnRspQryEWarrantOffsetHandler(OnRspQryEWarrantOffsetHandler handler) {
		_OnRspQryEWarrantOffsetHandler = handler;
	}
	///请求查询投资者品种/跨品种保证金响应
	void SetOnRspQryInvestorProductGroupMarginHandler(OnRspQryInvestorProductGroupMarginHandler handler) {
		_OnRspQryInvestorProductGroupMarginHandler = handler;
	}
	///请求查询交易所保证金率响应
	void SetOnRspQryExchangeMarginRateHandler(OnRspQryExchangeMarginRateHandler handler) {
		_OnRspQryExchangeMarginRateHandler = handler;
	}
	///请求查询交易所调整保证金率响应
	void SetOnRspQryExchangeMarginRateAdjustHandler(OnRspQryExchangeMarginRateAdjustHandler handler) {
		_OnRspQryExchangeMarginRateAdjustHandler = handler;
	}
	///请求查询汇率响应
	void SetOnRspQryExchangeRateHandler(OnRspQryExchangeRateHandler handler) {
		_OnRspQryExchangeRateHandler = handler;
	}
	///请求查询二级代理操作员银期权限响应
	void SetOnRspQrySecAgentACIDMapHandler(OnRspQrySecAgentACIDMapHandler handler) {
		_OnRspQrySecAgentACIDMapHandler = handler;
	}
	///请求查询产品报价汇率
	void SetOnRspQryProductExchRateHandler(OnRspQryProductExchRateHandler handler) {
		_OnRspQryProductExchRateHandler = handler;
	}
	///请求查询产品组
	void SetOnRspQryProductGroupHandler(OnRspQryProductGroupHandler handler) {
		_OnRspQryProductGroupHandler = handler;
	}
	///请求查询做市商合约手续费率响应
	void SetOnRspQryMMInstrumentCommissionRateHandler(OnRspQryMMInstrumentCommissionRateHandler handler) {
		_OnRspQryMMInstrumentCommissionRateHandler = handler;
	}
	///请求查询做市商期权合约手续费响应
	void SetOnRspQryMMOptionInstrCommRateHandler(OnRspQryMMOptionInstrCommRateHandler handler) {
		_OnRspQryMMOptionInstrCommRateHandler = handler;
	}
	///请求查询报单手续费响应
	void SetOnRspQryInstrumentOrderCommRateHandler(OnRspQryInstrumentOrderCommRateHandler handler) {
		_OnRspQryInstrumentOrderCommRateHandler = handler;
	}
	///请求查询资金账户响应
	void SetOnRspQrySecAgentTradingAccountHandler(OnRspQrySecAgentTradingAccountHandler handler) {
		_OnRspQrySecAgentTradingAccountHandler = handler;
	}
	///请求查询二级代理商资金校验模式响应
	void SetOnRspQrySecAgentCheckModeHandler(OnRspQrySecAgentCheckModeHandler handler) {
		_OnRspQrySecAgentCheckModeHandler = handler;
	}
	///请求查询二级代理商信息响应
	void SetOnRspQrySecAgentTradeInfoHandler(OnRspQrySecAgentTradeInfoHandler handler) {
		_OnRspQrySecAgentTradeInfoHandler = handler;
	}
	///请求查询期权交易成本响应
	void SetOnRspQryOptionInstrTradeCostHandler(OnRspQryOptionInstrTradeCostHandler handler) {
		_OnRspQryOptionInstrTradeCostHandler = handler;
	}
	///请求查询期权合约手续费响应
	void SetOnRspQryOptionInstrCommRateHandler(OnRspQryOptionInstrCommRateHandler handler) {
		_OnRspQryOptionInstrCommRateHandler = handler;
	}
	///请求查询执行宣告响应
	void SetOnRspQryExecOrderHandler(OnRspQryExecOrderHandler handler) {
		_OnRspQryExecOrderHandler = handler;
	}
	///请求查询询价响应
	void SetOnRspQryForQuoteHandler(OnRspQryForQuoteHandler handler) {
		_OnRspQryForQuoteHandler = handler;
	}
	///请求查询报价响应
	void SetOnRspQryQuoteHandler(OnRspQryQuoteHandler handler) {
		_OnRspQryQuoteHandler = handler;
	}
	///请求查询期权自对冲响应
	void SetOnRspQryOptionSelfCloseHandler(OnRspQryOptionSelfCloseHandler handler) {
		_OnRspQryOptionSelfCloseHandler = handler;
	}
	///请求查询投资单元响应
	void SetOnRspQryInvestUnitHandler(OnRspQryInvestUnitHandler handler) {
		_OnRspQryInvestUnitHandler = handler;
	}
	///请求查询组合合约安全系数响应
	void SetOnRspQryCombInstrumentGuardHandler(OnRspQryCombInstrumentGuardHandler handler) {
		_OnRspQryCombInstrumentGuardHandler = handler;
	}
	///请求查询申请组合响应
	void SetOnRspQryCombActionHandler(OnRspQryCombActionHandler handler) {
		_OnRspQryCombActionHandler = handler;
	}
	///请求查询转帐流水响应
	void SetOnRspQryTransferSerialHandler(OnRspQryTransferSerialHandler handler) {
		_OnRspQryTransferSerialHandler = handler;
	}
	///请求查询银期签约关系响应
	void SetOnRspQryAccountregisterHandler(OnRspQryAccountregisterHandler handler) {
		_OnRspQryAccountregisterHandler = handler;
	}
	///错误应答
	void SetOnRspErrorHandler(OnRspErrorHandler handler) {
		_OnRspErrorHandler = handler;
	}
	///报单通知
	void SetOnRtnOrderHandler(OnRtnOrderHandler handler) {
		_OnRtnOrderHandler = handler;
	}
	///成交通知
	void SetOnRtnTradeHandler(OnRtnTradeHandler handler) {
		_OnRtnTradeHandler = handler;
	}
	///报单录入错误回报
	void SetOnErrRtnOrderInsertHandler(OnErrRtnOrderInsertHandler handler) {
		_OnErrRtnOrderInsertHandler = handler;
	}
	///报单操作错误回报
	void SetOnErrRtnOrderActionHandler(OnErrRtnOrderActionHandler handler) {
		_OnErrRtnOrderActionHandler = handler;
	}
	///合约交易状态通知
	void SetOnRtnInstrumentStatusHandler(OnRtnInstrumentStatusHandler handler) {
		_OnRtnInstrumentStatusHandler = handler;
	}
	///交易所公告通知
	void SetOnRtnBulletinHandler(OnRtnBulletinHandler handler) {
		_OnRtnBulletinHandler = handler;
	}
	///交易通知
	void SetOnRtnTradingNoticeHandler(OnRtnTradingNoticeHandler handler) {
		_OnRtnTradingNoticeHandler = handler;
	}
	///提示条件单校验错误
	void SetOnRtnErrorConditionalOrderHandler(OnRtnErrorConditionalOrderHandler handler) {
		_OnRtnErrorConditionalOrderHandler = handler;
	}
	///执行宣告通知
	void SetOnRtnExecOrderHandler(OnRtnExecOrderHandler handler) {
		_OnRtnExecOrderHandler = handler;
	}
	///执行宣告录入错误回报
	void SetOnErrRtnExecOrderInsertHandler(OnErrRtnExecOrderInsertHandler handler) {
		_OnErrRtnExecOrderInsertHandler = handler;
	}
	///执行宣告操作错误回报
	void SetOnErrRtnExecOrderActionHandler(OnErrRtnExecOrderActionHandler handler) {
		_OnErrRtnExecOrderActionHandler = handler;
	}
	///询价录入错误回报
	void SetOnErrRtnForQuoteInsertHandler(OnErrRtnForQuoteInsertHandler handler) {
		_OnErrRtnForQuoteInsertHandler = handler;
	}
	///报价通知
	void SetOnRtnQuoteHandler(OnRtnQuoteHandler handler) {
		_OnRtnQuoteHandler = handler;
	}
	///报价录入错误回报
	void SetOnErrRtnQuoteInsertHandler(OnErrRtnQuoteInsertHandler handler) {
		_OnErrRtnQuoteInsertHandler = handler;
	}
	///报价操作错误回报
	void SetOnErrRtnQuoteActionHandler(OnErrRtnQuoteActionHandler handler) {
		_OnErrRtnQuoteActionHandler = handler;
	}
	///询价通知
	void SetOnRtnForQuoteRspHandler(OnRtnForQuoteRspHandler handler) {
		_OnRtnForQuoteRspHandler = handler;
	}
	///保证金监控中心用户令牌
	void SetOnRtnCFMMCTradingAccountTokenHandler(OnRtnCFMMCTradingAccountTokenHandler handler) {
		_OnRtnCFMMCTradingAccountTokenHandler = handler;
	}
	///批量报单操作错误回报
	void SetOnErrRtnBatchOrderActionHandler(OnErrRtnBatchOrderActionHandler handler) {
		_OnErrRtnBatchOrderActionHandler = handler;
	}
	///期权自对冲通知
	void SetOnRtnOptionSelfCloseHandler(OnRtnOptionSelfCloseHandler handler) {
		_OnRtnOptionSelfCloseHandler = handler;
	}
	///期权自对冲录入错误回报
	void SetOnErrRtnOptionSelfCloseInsertHandler(OnErrRtnOptionSelfCloseInsertHandler handler) {
		_OnErrRtnOptionSelfCloseInsertHandler = handler;
	}
	///期权自对冲操作错误回报
	void SetOnErrRtnOptionSelfCloseActionHandler(OnErrRtnOptionSelfCloseActionHandler handler) {
		_OnErrRtnOptionSelfCloseActionHandler = handler;
	}
	///申请组合通知
	void SetOnRtnCombActionHandler(OnRtnCombActionHandler handler) {
		_OnRtnCombActionHandler = handler;
	}
	///申请组合录入错误回报
	void SetOnErrRtnCombActionInsertHandler(OnErrRtnCombActionInsertHandler handler) {
		_OnErrRtnCombActionInsertHandler = handler;
	}
	///请求查询签约银行响应
	void SetOnRspQryContractBankHandler(OnRspQryContractBankHandler handler) {
		_OnRspQryContractBankHandler = handler;
	}
	///请求查询预埋单响应
	void SetOnRspQryParkedOrderHandler(OnRspQryParkedOrderHandler handler) {
		_OnRspQryParkedOrderHandler = handler;
	}
	///请求查询预埋撤单响应
	void SetOnRspQryParkedOrderActionHandler(OnRspQryParkedOrderActionHandler handler) {
		_OnRspQryParkedOrderActionHandler = handler;
	}
	///请求查询交易通知响应
	void SetOnRspQryTradingNoticeHandler(OnRspQryTradingNoticeHandler handler) {
		_OnRspQryTradingNoticeHandler = handler;
	}
	///请求查询经纪公司交易参数响应
	void SetOnRspQryBrokerTradingParamsHandler(OnRspQryBrokerTradingParamsHandler handler) {
		_OnRspQryBrokerTradingParamsHandler = handler;
	}
	///请求查询经纪公司交易算法响应
	void SetOnRspQryBrokerTradingAlgosHandler(OnRspQryBrokerTradingAlgosHandler handler) {
		_OnRspQryBrokerTradingAlgosHandler = handler;
	}
	///请求查询监控中心用户令牌
	void SetOnRspQueryCFMMCTradingAccountTokenHandler(OnRspQueryCFMMCTradingAccountTokenHandler handler) {
		_OnRspQueryCFMMCTradingAccountTokenHandler = handler;
	}
	///银行发起银行资金转期货通知
	void SetOnRtnFromBankToFutureByBankHandler(OnRtnFromBankToFutureByBankHandler handler) {
		_OnRtnFromBankToFutureByBankHandler = handler;
	}
	///银行发起期货资金转银行通知
	void SetOnRtnFromFutureToBankByBankHandler(OnRtnFromFutureToBankByBankHandler handler) {
		_OnRtnFromFutureToBankByBankHandler = handler;
	}
	///银行发起冲正银行转期货通知
	void SetOnRtnRepealFromBankToFutureByBankHandler(OnRtnRepealFromBankToFutureByBankHandler handler) {
		_OnRtnRepealFromBankToFutureByBankHandler = handler;
	}
	///银行发起冲正期货转银行通知
	void SetOnRtnRepealFromFutureToBankByBankHandler(OnRtnRepealFromFutureToBankByBankHandler handler) {
		_OnRtnRepealFromFutureToBankByBankHandler = handler;
	}
	///期货发起银行资金转期货通知
	void SetOnRtnFromBankToFutureByFutureHandler(OnRtnFromBankToFutureByFutureHandler handler) {
		_OnRtnFromBankToFutureByFutureHandler = handler;
	}
	///期货发起期货资金转银行通知
	void SetOnRtnFromFutureToBankByFutureHandler(OnRtnFromFutureToBankByFutureHandler handler) {
		_OnRtnFromFutureToBankByFutureHandler = handler;
	}
	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	void SetOnRtnRepealFromBankToFutureByFutureManualHandler(OnRtnRepealFromBankToFutureByFutureManualHandler handler) {
		_OnRtnRepealFromBankToFutureByFutureManualHandler = handler;
	}
	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	void SetOnRtnRepealFromFutureToBankByFutureManualHandler(OnRtnRepealFromFutureToBankByFutureManualHandler handler) {
		_OnRtnRepealFromFutureToBankByFutureManualHandler = handler;
	}
	///期货发起查询银行余额通知
	void SetOnRtnQueryBankBalanceByFutureHandler(OnRtnQueryBankBalanceByFutureHandler handler) {
		_OnRtnQueryBankBalanceByFutureHandler = handler;
	}
	///期货发起银行资金转期货错误回报
	void SetOnErrRtnBankToFutureByFutureHandler(OnErrRtnBankToFutureByFutureHandler handler) {
		_OnErrRtnBankToFutureByFutureHandler = handler;
	}
	///期货发起期货资金转银行错误回报
	void SetOnErrRtnFutureToBankByFutureHandler(OnErrRtnFutureToBankByFutureHandler handler) {
		_OnErrRtnFutureToBankByFutureHandler = handler;
	}
	///系统运行时期货端手工发起冲正银行转期货错误回报
	void SetOnErrRtnRepealBankToFutureByFutureManualHandler(OnErrRtnRepealBankToFutureByFutureManualHandler handler) {
		_OnErrRtnRepealBankToFutureByFutureManualHandler = handler;
	}
	///系统运行时期货端手工发起冲正期货转银行错误回报
	void SetOnErrRtnRepealFutureToBankByFutureManualHandler(OnErrRtnRepealFutureToBankByFutureManualHandler handler) {
		_OnErrRtnRepealFutureToBankByFutureManualHandler = handler;
	}
	///期货发起查询银行余额错误回报
	void SetOnErrRtnQueryBankBalanceByFutureHandler(OnErrRtnQueryBankBalanceByFutureHandler handler) {
		_OnErrRtnQueryBankBalanceByFutureHandler = handler;
	}
	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	void SetOnRtnRepealFromBankToFutureByFutureHandler(OnRtnRepealFromBankToFutureByFutureHandler handler) {
		_OnRtnRepealFromBankToFutureByFutureHandler = handler;
	}
	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	void SetOnRtnRepealFromFutureToBankByFutureHandler(OnRtnRepealFromFutureToBankByFutureHandler handler) {
		_OnRtnRepealFromFutureToBankByFutureHandler = handler;
	}
	///期货发起银行资金转期货应答
	void SetOnRspFromBankToFutureByFutureHandler(OnRspFromBankToFutureByFutureHandler handler) {
		_OnRspFromBankToFutureByFutureHandler = handler;
	}
	///期货发起期货资金转银行应答
	void SetOnRspFromFutureToBankByFutureHandler(OnRspFromFutureToBankByFutureHandler handler) {
		_OnRspFromFutureToBankByFutureHandler = handler;
	}
	///期货发起查询银行余额应答
	void SetOnRspQueryBankAccountMoneyByFutureHandler(OnRspQueryBankAccountMoneyByFutureHandler handler) {
		_OnRspQueryBankAccountMoneyByFutureHandler = handler;
	}
	///银行发起银期开户通知
	void SetOnRtnOpenAccountByBankHandler(OnRtnOpenAccountByBankHandler handler) {
		_OnRtnOpenAccountByBankHandler = handler;
	}
	///银行发起银期销户通知
	void SetOnRtnCancelAccountByBankHandler(OnRtnCancelAccountByBankHandler handler) {
		_OnRtnCancelAccountByBankHandler = handler;
	}
	///银行发起变更银行账号通知
	void SetOnRtnChangeAccountByBankHandler(OnRtnChangeAccountByBankHandler handler) {
		_OnRtnChangeAccountByBankHandler = handler;
	}
	///请求查询分类合约响应
	void SetOnRspQryClassifiedInstrumentHandler(OnRspQryClassifiedInstrumentHandler handler) {
		_OnRspQryClassifiedInstrumentHandler = handler;
	}
	///请求组合优惠比例响应
	void SetOnRspQryCombPromotionParamHandler(OnRspQryCombPromotionParamHandler handler) {
		_OnRspQryCombPromotionParamHandler = handler;
	}
	///投资者风险结算持仓查询响应
	void SetOnRspQryRiskSettleInvstPositionHandler(OnRspQryRiskSettleInvstPositionHandler handler) {
		_OnRspQryRiskSettleInvstPositionHandler = handler;
	}
	///风险结算产品查询响应
	void SetOnRspQryRiskSettleProductStatusHandler(OnRspQryRiskSettleProductStatusHandler handler) {
		_OnRspQryRiskSettleProductStatusHandler = handler;
	}

public:

	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	void OnFrontConnected() override{
		if(_OnFrontConnectedHandler) _OnFrontConnectedHandler();
	}
	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	void OnFrontDisconnected(int nReason) override{
		if(_OnFrontDisconnectedHandler) _OnFrontDisconnectedHandler(nReason);
	}
	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	void OnHeartBeatWarning(int nTimeLapse) override{
		if(_OnHeartBeatWarningHandler) _OnHeartBeatWarningHandler(nTimeLapse);
	}
	///客户端认证响应
	void OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspAuthenticateHandler) _OnRspAuthenticateHandler(pRspAuthenticateField,pRspInfo,nRequestID,bIsLast);
	}
	///登录请求响应
	void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUserLoginHandler) _OnRspUserLoginHandler(pRspUserLogin,pRspInfo,nRequestID,bIsLast);
	}
	///登出请求响应
	void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUserLogoutHandler) _OnRspUserLogoutHandler(pUserLogout,pRspInfo,nRequestID,bIsLast);
	}
	///用户口令更新请求响应
	void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUserPasswordUpdateHandler) _OnRspUserPasswordUpdateHandler(pUserPasswordUpdate,pRspInfo,nRequestID,bIsLast);
	}
	///资金账户口令更新请求响应
	void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspTradingAccountPasswordUpdateHandler) _OnRspTradingAccountPasswordUpdateHandler(pTradingAccountPasswordUpdate,pRspInfo,nRequestID,bIsLast);
	}
	///查询用户当前支持的认证模式的回复
	void OnRspUserAuthMethod(CThostFtdcRspUserAuthMethodField *pRspUserAuthMethod, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUserAuthMethodHandler) _OnRspUserAuthMethodHandler(pRspUserAuthMethod,pRspInfo,nRequestID,bIsLast);
	}
	///获取图形验证码请求的回复
	void OnRspGenUserCaptcha(CThostFtdcRspGenUserCaptchaField *pRspGenUserCaptcha, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspGenUserCaptchaHandler) _OnRspGenUserCaptchaHandler(pRspGenUserCaptcha,pRspInfo,nRequestID,bIsLast);
	}
	///获取短信验证码请求的回复
	void OnRspGenUserText(CThostFtdcRspGenUserTextField *pRspGenUserText, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspGenUserTextHandler) _OnRspGenUserTextHandler(pRspGenUserText,pRspInfo,nRequestID,bIsLast);
	}
	///报单录入请求响应
	void OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspOrderInsertHandler) _OnRspOrderInsertHandler(pInputOrder,pRspInfo,nRequestID,bIsLast);
	}
	///预埋单录入请求响应
	void OnRspParkedOrderInsert(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspParkedOrderInsertHandler) _OnRspParkedOrderInsertHandler(pParkedOrder,pRspInfo,nRequestID,bIsLast);
	}
	///预埋撤单录入请求响应
	void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspParkedOrderActionHandler) _OnRspParkedOrderActionHandler(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
	}
	///报单操作请求响应
	void OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspOrderActionHandler) _OnRspOrderActionHandler(pInputOrderAction,pRspInfo,nRequestID,bIsLast);
	}
	///查询最大报单数量响应
	void OnRspQryMaxOrderVolume(CThostFtdcQryMaxOrderVolumeField *pQryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryMaxOrderVolumeHandler) _OnRspQryMaxOrderVolumeHandler(pQryMaxOrderVolume,pRspInfo,nRequestID,bIsLast);
	}
	///投资者结算结果确认响应
	void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspSettlementInfoConfirmHandler) _OnRspSettlementInfoConfirmHandler(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
	}
	///删除预埋单响应
	void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspRemoveParkedOrderHandler) _OnRspRemoveParkedOrderHandler(pRemoveParkedOrder,pRspInfo,nRequestID,bIsLast);
	}
	///删除预埋撤单响应
	void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspRemoveParkedOrderActionHandler) _OnRspRemoveParkedOrderActionHandler(pRemoveParkedOrderAction,pRspInfo,nRequestID,bIsLast);
	}
	///执行宣告录入请求响应
	void OnRspExecOrderInsert(CThostFtdcInputExecOrderField *pInputExecOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspExecOrderInsertHandler) _OnRspExecOrderInsertHandler(pInputExecOrder,pRspInfo,nRequestID,bIsLast);
	}
	///执行宣告操作请求响应
	void OnRspExecOrderAction(CThostFtdcInputExecOrderActionField *pInputExecOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspExecOrderActionHandler) _OnRspExecOrderActionHandler(pInputExecOrderAction,pRspInfo,nRequestID,bIsLast);
	}
	///询价录入请求响应
	void OnRspForQuoteInsert(CThostFtdcInputForQuoteField *pInputForQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspForQuoteInsertHandler) _OnRspForQuoteInsertHandler(pInputForQuote,pRspInfo,nRequestID,bIsLast);
	}
	///报价录入请求响应
	void OnRspQuoteInsert(CThostFtdcInputQuoteField *pInputQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQuoteInsertHandler) _OnRspQuoteInsertHandler(pInputQuote,pRspInfo,nRequestID,bIsLast);
	}
	///报价操作请求响应
	void OnRspQuoteAction(CThostFtdcInputQuoteActionField *pInputQuoteAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQuoteActionHandler) _OnRspQuoteActionHandler(pInputQuoteAction,pRspInfo,nRequestID,bIsLast);
	}
	///批量报单操作请求响应
	void OnRspBatchOrderAction(CThostFtdcInputBatchOrderActionField *pInputBatchOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspBatchOrderActionHandler) _OnRspBatchOrderActionHandler(pInputBatchOrderAction,pRspInfo,nRequestID,bIsLast);
	}
	///期权自对冲录入请求响应
	void OnRspOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField *pInputOptionSelfClose, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspOptionSelfCloseInsertHandler) _OnRspOptionSelfCloseInsertHandler(pInputOptionSelfClose,pRspInfo,nRequestID,bIsLast);
	}
	///期权自对冲操作请求响应
	void OnRspOptionSelfCloseAction(CThostFtdcInputOptionSelfCloseActionField *pInputOptionSelfCloseAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspOptionSelfCloseActionHandler) _OnRspOptionSelfCloseActionHandler(pInputOptionSelfCloseAction,pRspInfo,nRequestID,bIsLast);
	}
	///申请组合录入请求响应
	void OnRspCombActionInsert(CThostFtdcInputCombActionField *pInputCombAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspCombActionInsertHandler) _OnRspCombActionInsertHandler(pInputCombAction,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询报单响应
	void OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryOrderHandler) _OnRspQryOrderHandler(pOrder,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询成交响应
	void OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTradeHandler) _OnRspQryTradeHandler(pTrade,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资者持仓响应
	void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInvestorPositionHandler) _OnRspQryInvestorPositionHandler(pInvestorPosition,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询资金账户响应
	void OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTradingAccountHandler) _OnRspQryTradingAccountHandler(pTradingAccount,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资者响应
	void OnRspQryInvestor(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInvestorHandler) _OnRspQryInvestorHandler(pInvestor,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询交易编码响应
	void OnRspQryTradingCode(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTradingCodeHandler) _OnRspQryTradingCodeHandler(pTradingCode,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询合约保证金率响应
	void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInstrumentMarginRateHandler) _OnRspQryInstrumentMarginRateHandler(pInstrumentMarginRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询合约手续费率响应
	void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInstrumentCommissionRateHandler) _OnRspQryInstrumentCommissionRateHandler(pInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询交易所响应
	void OnRspQryExchange(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryExchangeHandler) _OnRspQryExchangeHandler(pExchange,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询产品响应
	void OnRspQryProduct(CThostFtdcProductField *pProduct, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryProductHandler) _OnRspQryProductHandler(pProduct,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询合约响应
	void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInstrumentHandler) _OnRspQryInstrumentHandler(pInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询行情响应
	void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryDepthMarketDataHandler) _OnRspQryDepthMarketDataHandler(pDepthMarketData,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询交易员报盘机响应
	void OnRspQryTraderOffer(CThostFtdcTraderOfferField *pTraderOffer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTraderOfferHandler) _OnRspQryTraderOfferHandler(pTraderOffer,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资者结算结果响应
	void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQrySettlementInfoHandler) _OnRspQrySettlementInfoHandler(pSettlementInfo,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询转帐银行响应
	void OnRspQryTransferBank(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTransferBankHandler) _OnRspQryTransferBankHandler(pTransferBank,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资者持仓明细响应
	void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInvestorPositionDetailHandler) _OnRspQryInvestorPositionDetailHandler(pInvestorPositionDetail,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询客户通知响应
	void OnRspQryNotice(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryNoticeHandler) _OnRspQryNoticeHandler(pNotice,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询结算信息确认响应
	void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQrySettlementInfoConfirmHandler) _OnRspQrySettlementInfoConfirmHandler(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资者持仓明细响应
	void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInvestorPositionCombineDetailHandler) _OnRspQryInvestorPositionCombineDetailHandler(pInvestorPositionCombineDetail,pRspInfo,nRequestID,bIsLast);
	}
	///查询保证金监管系统经纪公司资金账户密钥响应
	void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryCFMMCTradingAccountKeyHandler) _OnRspQryCFMMCTradingAccountKeyHandler(pCFMMCTradingAccountKey,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询仓单折抵信息响应
	void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryEWarrantOffsetHandler) _OnRspQryEWarrantOffsetHandler(pEWarrantOffset,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资者品种/跨品种保证金响应
	void OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField *pInvestorProductGroupMargin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInvestorProductGroupMarginHandler) _OnRspQryInvestorProductGroupMarginHandler(pInvestorProductGroupMargin,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询交易所保证金率响应
	void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField *pExchangeMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryExchangeMarginRateHandler) _OnRspQryExchangeMarginRateHandler(pExchangeMarginRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询交易所调整保证金率响应
	void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField *pExchangeMarginRateAdjust, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryExchangeMarginRateAdjustHandler) _OnRspQryExchangeMarginRateAdjustHandler(pExchangeMarginRateAdjust,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询汇率响应
	void OnRspQryExchangeRate(CThostFtdcExchangeRateField *pExchangeRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryExchangeRateHandler) _OnRspQryExchangeRateHandler(pExchangeRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询二级代理操作员银期权限响应
	void OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField *pSecAgentACIDMap, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQrySecAgentACIDMapHandler) _OnRspQrySecAgentACIDMapHandler(pSecAgentACIDMap,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询产品报价汇率
	void OnRspQryProductExchRate(CThostFtdcProductExchRateField *pProductExchRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryProductExchRateHandler) _OnRspQryProductExchRateHandler(pProductExchRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询产品组
	void OnRspQryProductGroup(CThostFtdcProductGroupField *pProductGroup, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryProductGroupHandler) _OnRspQryProductGroupHandler(pProductGroup,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询做市商合约手续费率响应
	void OnRspQryMMInstrumentCommissionRate(CThostFtdcMMInstrumentCommissionRateField *pMMInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryMMInstrumentCommissionRateHandler) _OnRspQryMMInstrumentCommissionRateHandler(pMMInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询做市商期权合约手续费响应
	void OnRspQryMMOptionInstrCommRate(CThostFtdcMMOptionInstrCommRateField *pMMOptionInstrCommRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryMMOptionInstrCommRateHandler) _OnRspQryMMOptionInstrCommRateHandler(pMMOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询报单手续费响应
	void OnRspQryInstrumentOrderCommRate(CThostFtdcInstrumentOrderCommRateField *pInstrumentOrderCommRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInstrumentOrderCommRateHandler) _OnRspQryInstrumentOrderCommRateHandler(pInstrumentOrderCommRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询资金账户响应
	void OnRspQrySecAgentTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQrySecAgentTradingAccountHandler) _OnRspQrySecAgentTradingAccountHandler(pTradingAccount,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询二级代理商资金校验模式响应
	void OnRspQrySecAgentCheckMode(CThostFtdcSecAgentCheckModeField *pSecAgentCheckMode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQrySecAgentCheckModeHandler) _OnRspQrySecAgentCheckModeHandler(pSecAgentCheckMode,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询二级代理商信息响应
	void OnRspQrySecAgentTradeInfo(CThostFtdcSecAgentTradeInfoField *pSecAgentTradeInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQrySecAgentTradeInfoHandler) _OnRspQrySecAgentTradeInfoHandler(pSecAgentTradeInfo,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询期权交易成本响应
	void OnRspQryOptionInstrTradeCost(CThostFtdcOptionInstrTradeCostField *pOptionInstrTradeCost, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryOptionInstrTradeCostHandler) _OnRspQryOptionInstrTradeCostHandler(pOptionInstrTradeCost,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询期权合约手续费响应
	void OnRspQryOptionInstrCommRate(CThostFtdcOptionInstrCommRateField *pOptionInstrCommRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryOptionInstrCommRateHandler) _OnRspQryOptionInstrCommRateHandler(pOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询执行宣告响应
	void OnRspQryExecOrder(CThostFtdcExecOrderField *pExecOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryExecOrderHandler) _OnRspQryExecOrderHandler(pExecOrder,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询询价响应
	void OnRspQryForQuote(CThostFtdcForQuoteField *pForQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryForQuoteHandler) _OnRspQryForQuoteHandler(pForQuote,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询报价响应
	void OnRspQryQuote(CThostFtdcQuoteField *pQuote, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryQuoteHandler) _OnRspQryQuoteHandler(pQuote,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询期权自对冲响应
	void OnRspQryOptionSelfClose(CThostFtdcOptionSelfCloseField *pOptionSelfClose, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryOptionSelfCloseHandler) _OnRspQryOptionSelfCloseHandler(pOptionSelfClose,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询投资单元响应
	void OnRspQryInvestUnit(CThostFtdcInvestUnitField *pInvestUnit, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryInvestUnitHandler) _OnRspQryInvestUnitHandler(pInvestUnit,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询组合合约安全系数响应
	void OnRspQryCombInstrumentGuard(CThostFtdcCombInstrumentGuardField *pCombInstrumentGuard, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryCombInstrumentGuardHandler) _OnRspQryCombInstrumentGuardHandler(pCombInstrumentGuard,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询申请组合响应
	void OnRspQryCombAction(CThostFtdcCombActionField *pCombAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryCombActionHandler) _OnRspQryCombActionHandler(pCombAction,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询转帐流水响应
	void OnRspQryTransferSerial(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTransferSerialHandler) _OnRspQryTransferSerialHandler(pTransferSerial,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询银期签约关系响应
	void OnRspQryAccountregister(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryAccountregisterHandler) _OnRspQryAccountregisterHandler(pAccountregister,pRspInfo,nRequestID,bIsLast);
	}
	///错误应答
	void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspErrorHandler) _OnRspErrorHandler(pRspInfo,nRequestID,bIsLast);
	}
	///报单通知
	void OnRtnOrder(CThostFtdcOrderField *pOrder) override{
		if(_OnRtnOrderHandler) _OnRtnOrderHandler(pOrder);
	}
	///成交通知
	void OnRtnTrade(CThostFtdcTradeField *pTrade) override{
		if(_OnRtnTradeHandler) _OnRtnTradeHandler(pTrade);
	}
	///报单录入错误回报
	void OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnOrderInsertHandler) _OnErrRtnOrderInsertHandler(pInputOrder,pRspInfo);
	}
	///报单操作错误回报
	void OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnOrderActionHandler) _OnErrRtnOrderActionHandler(pOrderAction,pRspInfo);
	}
	///合约交易状态通知
	void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus) override{
		if(_OnRtnInstrumentStatusHandler) _OnRtnInstrumentStatusHandler(pInstrumentStatus);
	}
	///交易所公告通知
	void OnRtnBulletin(CThostFtdcBulletinField *pBulletin) override{
		if(_OnRtnBulletinHandler) _OnRtnBulletinHandler(pBulletin);
	}
	///交易通知
	void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) override{
		if(_OnRtnTradingNoticeHandler) _OnRtnTradingNoticeHandler(pTradingNoticeInfo);
	}
	///提示条件单校验错误
	void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) override{
		if(_OnRtnErrorConditionalOrderHandler) _OnRtnErrorConditionalOrderHandler(pErrorConditionalOrder);
	}
	///执行宣告通知
	void OnRtnExecOrder(CThostFtdcExecOrderField *pExecOrder) override{
		if(_OnRtnExecOrderHandler) _OnRtnExecOrderHandler(pExecOrder);
	}
	///执行宣告录入错误回报
	void OnErrRtnExecOrderInsert(CThostFtdcInputExecOrderField *pInputExecOrder, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnExecOrderInsertHandler) _OnErrRtnExecOrderInsertHandler(pInputExecOrder,pRspInfo);
	}
	///执行宣告操作错误回报
	void OnErrRtnExecOrderAction(CThostFtdcExecOrderActionField *pExecOrderAction, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnExecOrderActionHandler) _OnErrRtnExecOrderActionHandler(pExecOrderAction,pRspInfo);
	}
	///询价录入错误回报
	void OnErrRtnForQuoteInsert(CThostFtdcInputForQuoteField *pInputForQuote, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnForQuoteInsertHandler) _OnErrRtnForQuoteInsertHandler(pInputForQuote,pRspInfo);
	}
	///报价通知
	void OnRtnQuote(CThostFtdcQuoteField *pQuote) override{
		if(_OnRtnQuoteHandler) _OnRtnQuoteHandler(pQuote);
	}
	///报价录入错误回报
	void OnErrRtnQuoteInsert(CThostFtdcInputQuoteField *pInputQuote, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnQuoteInsertHandler) _OnErrRtnQuoteInsertHandler(pInputQuote,pRspInfo);
	}
	///报价操作错误回报
	void OnErrRtnQuoteAction(CThostFtdcQuoteActionField *pQuoteAction, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnQuoteActionHandler) _OnErrRtnQuoteActionHandler(pQuoteAction,pRspInfo);
	}
	///询价通知
	void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField *pForQuoteRsp) override{
		if(_OnRtnForQuoteRspHandler) _OnRtnForQuoteRspHandler(pForQuoteRsp);
	}
	///保证金监控中心用户令牌
	void OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField *pCFMMCTradingAccountToken) override{
		if(_OnRtnCFMMCTradingAccountTokenHandler) _OnRtnCFMMCTradingAccountTokenHandler(pCFMMCTradingAccountToken);
	}
	///批量报单操作错误回报
	void OnErrRtnBatchOrderAction(CThostFtdcBatchOrderActionField *pBatchOrderAction, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnBatchOrderActionHandler) _OnErrRtnBatchOrderActionHandler(pBatchOrderAction,pRspInfo);
	}
	///期权自对冲通知
	void OnRtnOptionSelfClose(CThostFtdcOptionSelfCloseField *pOptionSelfClose) override{
		if(_OnRtnOptionSelfCloseHandler) _OnRtnOptionSelfCloseHandler(pOptionSelfClose);
	}
	///期权自对冲录入错误回报
	void OnErrRtnOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField *pInputOptionSelfClose, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnOptionSelfCloseInsertHandler) _OnErrRtnOptionSelfCloseInsertHandler(pInputOptionSelfClose,pRspInfo);
	}
	///期权自对冲操作错误回报
	void OnErrRtnOptionSelfCloseAction(CThostFtdcOptionSelfCloseActionField *pOptionSelfCloseAction, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnOptionSelfCloseActionHandler) _OnErrRtnOptionSelfCloseActionHandler(pOptionSelfCloseAction,pRspInfo);
	}
	///申请组合通知
	void OnRtnCombAction(CThostFtdcCombActionField *pCombAction) override{
		if(_OnRtnCombActionHandler) _OnRtnCombActionHandler(pCombAction);
	}
	///申请组合录入错误回报
	void OnErrRtnCombActionInsert(CThostFtdcInputCombActionField *pInputCombAction, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnCombActionInsertHandler) _OnErrRtnCombActionInsertHandler(pInputCombAction,pRspInfo);
	}
	///请求查询签约银行响应
	void OnRspQryContractBank(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryContractBankHandler) _OnRspQryContractBankHandler(pContractBank,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询预埋单响应
	void OnRspQryParkedOrder(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryParkedOrderHandler) _OnRspQryParkedOrderHandler(pParkedOrder,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询预埋撤单响应
	void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryParkedOrderActionHandler) _OnRspQryParkedOrderActionHandler(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询交易通知响应
	void OnRspQryTradingNotice(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryTradingNoticeHandler) _OnRspQryTradingNoticeHandler(pTradingNotice,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询经纪公司交易参数响应
	void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryBrokerTradingParamsHandler) _OnRspQryBrokerTradingParamsHandler(pBrokerTradingParams,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询经纪公司交易算法响应
	void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryBrokerTradingAlgosHandler) _OnRspQryBrokerTradingAlgosHandler(pBrokerTradingAlgos,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询监控中心用户令牌
	void OnRspQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField *pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQueryCFMMCTradingAccountTokenHandler) _OnRspQueryCFMMCTradingAccountTokenHandler(pQueryCFMMCTradingAccountToken,pRspInfo,nRequestID,bIsLast);
	}
	///银行发起银行资金转期货通知
	void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField *pRspTransfer) override{
		if(_OnRtnFromBankToFutureByBankHandler) _OnRtnFromBankToFutureByBankHandler(pRspTransfer);
	}
	///银行发起期货资金转银行通知
	void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField *pRspTransfer) override{
		if(_OnRtnFromFutureToBankByBankHandler) _OnRtnFromFutureToBankByBankHandler(pRspTransfer);
	}
	///银行发起冲正银行转期货通知
	void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField *pRspRepeal) override{
		if(_OnRtnRepealFromBankToFutureByBankHandler) _OnRtnRepealFromBankToFutureByBankHandler(pRspRepeal);
	}
	///银行发起冲正期货转银行通知
	void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField *pRspRepeal) override{
		if(_OnRtnRepealFromFutureToBankByBankHandler) _OnRtnRepealFromFutureToBankByBankHandler(pRspRepeal);
	}
	///期货发起银行资金转期货通知
	void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField *pRspTransfer) override{
		if(_OnRtnFromBankToFutureByFutureHandler) _OnRtnFromBankToFutureByFutureHandler(pRspTransfer);
	}
	///期货发起期货资金转银行通知
	void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField *pRspTransfer) override{
		if(_OnRtnFromFutureToBankByFutureHandler) _OnRtnFromFutureToBankByFutureHandler(pRspTransfer);
	}
	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField *pRspRepeal) override{
		if(_OnRtnRepealFromBankToFutureByFutureManualHandler) _OnRtnRepealFromBankToFutureByFutureManualHandler(pRspRepeal);
	}
	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField *pRspRepeal) override{
		if(_OnRtnRepealFromFutureToBankByFutureManualHandler) _OnRtnRepealFromFutureToBankByFutureManualHandler(pRspRepeal);
	}
	///期货发起查询银行余额通知
	void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) override{
		if(_OnRtnQueryBankBalanceByFutureHandler) _OnRtnQueryBankBalanceByFutureHandler(pNotifyQueryAccount);
	}
	///期货发起银行资金转期货错误回报
	void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnBankToFutureByFutureHandler) _OnErrRtnBankToFutureByFutureHandler(pReqTransfer,pRspInfo);
	}
	///期货发起期货资金转银行错误回报
	void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnFutureToBankByFutureHandler) _OnErrRtnFutureToBankByFutureHandler(pReqTransfer,pRspInfo);
	}
	///系统运行时期货端手工发起冲正银行转期货错误回报
	void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnRepealBankToFutureByFutureManualHandler) _OnErrRtnRepealBankToFutureByFutureManualHandler(pReqRepeal,pRspInfo);
	}
	///系统运行时期货端手工发起冲正期货转银行错误回报
	void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnRepealFutureToBankByFutureManualHandler) _OnErrRtnRepealFutureToBankByFutureManualHandler(pReqRepeal,pRspInfo);
	}
	///期货发起查询银行余额错误回报
	void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) override{
		if(_OnErrRtnQueryBankBalanceByFutureHandler) _OnErrRtnQueryBankBalanceByFutureHandler(pReqQueryAccount,pRspInfo);
	}
	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField *pRspRepeal) override{
		if(_OnRtnRepealFromBankToFutureByFutureHandler) _OnRtnRepealFromBankToFutureByFutureHandler(pRspRepeal);
	}
	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField *pRspRepeal) override{
		if(_OnRtnRepealFromFutureToBankByFutureHandler) _OnRtnRepealFromFutureToBankByFutureHandler(pRspRepeal);
	}
	///期货发起银行资金转期货应答
	void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspFromBankToFutureByFutureHandler) _OnRspFromBankToFutureByFutureHandler(pReqTransfer,pRspInfo,nRequestID,bIsLast);
	}
	///期货发起期货资金转银行应答
	void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspFromFutureToBankByFutureHandler) _OnRspFromFutureToBankByFutureHandler(pReqTransfer,pRspInfo,nRequestID,bIsLast);
	}
	///期货发起查询银行余额应答
	void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQueryBankAccountMoneyByFutureHandler) _OnRspQueryBankAccountMoneyByFutureHandler(pReqQueryAccount,pRspInfo,nRequestID,bIsLast);
	}
	///银行发起银期开户通知
	void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField *pOpenAccount) override{
		if(_OnRtnOpenAccountByBankHandler) _OnRtnOpenAccountByBankHandler(pOpenAccount);
	}
	///银行发起银期销户通知
	void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField *pCancelAccount) override{
		if(_OnRtnCancelAccountByBankHandler) _OnRtnCancelAccountByBankHandler(pCancelAccount);
	}
	///银行发起变更银行账号通知
	void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField *pChangeAccount) override{
		if(_OnRtnChangeAccountByBankHandler) _OnRtnChangeAccountByBankHandler(pChangeAccount);
	}
	///请求查询分类合约响应
	void OnRspQryClassifiedInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryClassifiedInstrumentHandler) _OnRspQryClassifiedInstrumentHandler(pInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///请求组合优惠比例响应
	void OnRspQryCombPromotionParam(CThostFtdcCombPromotionParamField *pCombPromotionParam, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryCombPromotionParamHandler) _OnRspQryCombPromotionParamHandler(pCombPromotionParam,pRspInfo,nRequestID,bIsLast);
	}
	///投资者风险结算持仓查询响应
	void OnRspQryRiskSettleInvstPosition(CThostFtdcRiskSettleInvstPositionField *pRiskSettleInvstPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryRiskSettleInvstPositionHandler) _OnRspQryRiskSettleInvstPositionHandler(pRiskSettleInvstPosition,pRspInfo,nRequestID,bIsLast);
	}
	///风险结算产品查询响应
	void OnRspQryRiskSettleProductStatus(CThostFtdcRiskSettleProductStatusField *pRiskSettleProductStatus, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryRiskSettleProductStatusHandler) _OnRspQryRiskSettleProductStatusHandler(pRiskSettleProductStatus,pRspInfo,nRequestID,bIsLast);
	}
};
