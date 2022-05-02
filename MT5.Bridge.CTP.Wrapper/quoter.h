#pragma once

#include "shared.h"



class CQuoterHandler : public CThostFtdcMdSpi
{
private:
	CThostFtdcMdApi* api;

	const char* m_flow_path;
 
public:
	CThostFtdcMdApi* Api() { return api; }

public:
	CQuoterHandler(const char* path, const bool bIsUsingUdp=false, const bool bIsMulticast=false):m_flow_path(path)
	{
		api = CThostFtdcMdApi::CreateFtdcMdApi(path);
		api->RegisterSpi(this);
	}

	~CQuoterHandler()
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
	///登录请求响应
	OnRspUserLoginHandler _OnRspUserLoginHandler = nullptr;
	///登出请求响应
	OnRspUserLogoutHandler _OnRspUserLogoutHandler = nullptr;
	///请求查询组播合约响应
	OnRspQryMulticastInstrumentHandler _OnRspQryMulticastInstrumentHandler = nullptr;
	///错误应答
	OnRspErrorHandler _OnRspErrorHandler = nullptr;
	///订阅行情应答
	OnRspSubMarketDataHandler _OnRspSubMarketDataHandler = nullptr;
	///取消订阅行情应答
	OnRspUnSubMarketDataHandler _OnRspUnSubMarketDataHandler = nullptr;
	///订阅询价应答
	OnRspSubForQuoteRspHandler _OnRspSubForQuoteRspHandler = nullptr;
	///取消订阅询价应答
	OnRspUnSubForQuoteRspHandler _OnRspUnSubForQuoteRspHandler = nullptr;
	///深度行情通知
	OnRtnDepthMarketDataHandler _OnRtnDepthMarketDataHandler = nullptr;
	///询价通知
	OnRtnForQuoteRspHandler _OnRtnForQuoteRspHandler = nullptr;

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
	///登录请求响应
	void SetOnRspUserLoginHandler(OnRspUserLoginHandler handler) {
		_OnRspUserLoginHandler = handler;
	}
	///登出请求响应
	void SetOnRspUserLogoutHandler(OnRspUserLogoutHandler handler) {
		_OnRspUserLogoutHandler = handler;
	}
	///请求查询组播合约响应
	void SetOnRspQryMulticastInstrumentHandler(OnRspQryMulticastInstrumentHandler handler) {
		_OnRspQryMulticastInstrumentHandler = handler;
	}
	///错误应答
	void SetOnRspErrorHandler(OnRspErrorHandler handler) {
		_OnRspErrorHandler = handler;
	}
	///订阅行情应答
	void SetOnRspSubMarketDataHandler(OnRspSubMarketDataHandler handler) {
		_OnRspSubMarketDataHandler = handler;
	}
	///取消订阅行情应答
	void SetOnRspUnSubMarketDataHandler(OnRspUnSubMarketDataHandler handler) {
		_OnRspUnSubMarketDataHandler = handler;
	}
	///订阅询价应答
	void SetOnRspSubForQuoteRspHandler(OnRspSubForQuoteRspHandler handler) {
		_OnRspSubForQuoteRspHandler = handler;
	}
	///取消订阅询价应答
	void SetOnRspUnSubForQuoteRspHandler(OnRspUnSubForQuoteRspHandler handler) {
		_OnRspUnSubForQuoteRspHandler = handler;
	}
	///深度行情通知
	void SetOnRtnDepthMarketDataHandler(OnRtnDepthMarketDataHandler handler) {
		_OnRtnDepthMarketDataHandler = handler;
	}
	///询价通知
	void SetOnRtnForQuoteRspHandler(OnRtnForQuoteRspHandler handler) {
		_OnRtnForQuoteRspHandler = handler;
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
	///登录请求响应
	void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUserLoginHandler) _OnRspUserLoginHandler(pRspUserLogin,pRspInfo,nRequestID,bIsLast);
	}
	///登出请求响应
	void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUserLogoutHandler) _OnRspUserLogoutHandler(pUserLogout,pRspInfo,nRequestID,bIsLast);
	}
	///请求查询组播合约响应
	void OnRspQryMulticastInstrument(CThostFtdcMulticastInstrumentField *pMulticastInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspQryMulticastInstrumentHandler) _OnRspQryMulticastInstrumentHandler(pMulticastInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///错误应答
	void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspErrorHandler) _OnRspErrorHandler(pRspInfo,nRequestID,bIsLast);
	}
	///订阅行情应答
	void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspSubMarketDataHandler) _OnRspSubMarketDataHandler(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///取消订阅行情应答
	void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUnSubMarketDataHandler) _OnRspUnSubMarketDataHandler(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///订阅询价应答
	void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspSubForQuoteRspHandler) _OnRspSubForQuoteRspHandler(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///取消订阅询价应答
	void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) override{
		if(_OnRspUnSubForQuoteRspHandler) _OnRspUnSubForQuoteRspHandler(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
	}
	///深度行情通知
	void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) override{
		if(_OnRtnDepthMarketDataHandler) _OnRtnDepthMarketDataHandler(pDepthMarketData);
	}
	///询价通知
	void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField *pForQuoteRsp) override{
		if(_OnRtnForQuoteRspHandler) _OnRtnForQuoteRspHandler(pForQuoteRsp);
	}
};
