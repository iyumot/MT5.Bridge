#pragma once

#include "shared.h"






#include "CTraderWraper.h" 


#ifdef __cplusplus
extern "C" {
#endif


	CTP_API void* CTPCALL TdCreateApi(const char* pszFlowPath) {
		return new CTraderHandler(pszFlowPath);
	}


	CTP_API const char* STDCALL TdGetApiVersion() {
		return CThostFtdcMdApi::GetApiVersion();
	}


	CTP_API void STDCALL TdInit(void* pApi) {
		(static_cast<CTraderHandler*>(pApi))->Api()->Init();
	}



	CTP_API void STDCALL TdRegisterFront(void* pApi, char* pszFrontAddress, OnFrontConnectedHandler handler) {
		(static_cast<CTraderHandler*>(pApi))->SetOnFrontConnectedHandler(handler);
		(static_cast<CTraderHandler*>(pApi))->Api()->RegisterFront(pszFrontAddress);
	}

	/*CTP_API void STDCALL TdSetOnFrontConnectedHandler(void* pApi, OnFrontConnectedHandler handler) {
		(static_cast<CTraderHandler*>(pApi))->SetOnFrontConnected(handler);
	}*/



	CTP_API void STDCALL TdSubscribePrivateTopic(void* pApi, THOST_TE_RESUME_TYPE nResumeType) {
		(static_cast<CTraderHandler*>(pApi))->Api()->SubscribePrivateTopic(nResumeType);
	}

	CTP_API void STDCALL TdSubscribePublicTopic(void* pApi, THOST_TE_RESUME_TYPE nResumeType) {
		(static_cast<CTraderHandler*>(pApi))->Api()->SubscribePublicTopic(nResumeType);
	}



	CTP_API int STDCALL TdReqUserLogin(void* pApi, CThostFtdcReqUserLoginField* pReqUserLoginField, int nRequestID, OnUserLoginHandler handler) {
		(static_cast<CTraderHandler*>(pApi))->SetOnUserLoginHandler(handler);
		return (static_cast<CTraderHandler*>(pApi))->Api()->ReqUserLogin(pReqUserLoginField, nRequestID);
	}























#ifdef __cplusplus
}
#endif












