using System;
using System.Runtime.InteropServices;


#region Types
///TFtdcTraderIDType是一个交易所交易员代码类型
using TThostFtdcTraderIDType = System.String;
///TFtdcInvestorIDType是一个投资者代码类型
using TThostFtdcInvestorIDType = System.String;
///TFtdcBrokerIDType是一个经纪公司代码类型
using TThostFtdcBrokerIDType = System.String;
///TFtdcBrokerAbbrType是一个经纪公司简称类型
using TThostFtdcBrokerAbbrType = System.String;
///TFtdcBrokerNameType是一个经纪公司名称类型
using TThostFtdcBrokerNameType = System.String;
///TFtdcOldExchangeInstIDType是一个合约在交易所的代码类型
using TThostFtdcOldExchangeInstIDType = System.String;
///TFtdcExchangeInstIDType是一个合约在交易所的代码类型
using TThostFtdcExchangeInstIDType = System.String;
///TFtdcOrderRefType是一个报单引用类型
using TThostFtdcOrderRefType = System.String;
///TFtdcParticipantIDType是一个会员代码类型
using TThostFtdcParticipantIDType = System.String;
///TFtdcUserIDType是一个用户代码类型
using TThostFtdcUserIDType = System.String;
///TFtdcPasswordType是一个密码类型
using TThostFtdcPasswordType = System.String;
///TFtdcClientIDType是一个交易编码类型
using TThostFtdcClientIDType = System.String;
///TFtdcInstrumentIDType是一个合约代码类型
using TThostFtdcInstrumentIDType = System.String;
///TFtdcOldInstrumentIDType是一个合约代码类型
using TThostFtdcOldInstrumentIDType = System.String;
///TFtdcInstrumentCodeType是一个合约标识码类型
using TThostFtdcInstrumentCodeType = System.String;
///TFtdcMarketIDType是一个市场代码类型
using TThostFtdcMarketIDType = System.String;
///TFtdcProductNameType是一个产品名称类型
using TThostFtdcProductNameType = System.String;
///TFtdcExchangeIDType是一个交易所代码类型
using TThostFtdcExchangeIDType = System.String;
///TFtdcExchangeNameType是一个交易所名称类型
using TThostFtdcExchangeNameType = System.String;
///TFtdcExchangeAbbrType是一个交易所简称类型
using TThostFtdcExchangeAbbrType = System.String;
///TFtdcExchangeFlagType是一个交易所标志类型
using TThostFtdcExchangeFlagType = System.String;
///TFtdcMacAddressType是一个Mac地址类型
using TThostFtdcMacAddressType = System.String;
///TFtdcSystemIDType是一个系统编号类型
using TThostFtdcSystemIDType = System.String;
///TFtdcClientLoginRemarkType是一个客户登录备注2类型
using TThostFtdcClientLoginRemarkType = System.String;
///TFtdcExchangePropertyType是一个交易所属性类型
using TThostFtdcExchangePropertyType = System.String;
///TFtdcDateType是一个日期类型
using TThostFtdcDateType = System.String;
///TFtdcTimeType是一个时间类型
using TThostFtdcTimeType = System.String;
///TFtdcLongTimeType是一个长时间类型
using TThostFtdcLongTimeType = System.String;
///TFtdcInstrumentNameType是一个合约名称类型
using TThostFtdcInstrumentNameType = System.String;
///TFtdcSettlementGroupIDType是一个结算组代码类型
using TThostFtdcSettlementGroupIDType = System.String;
///TFtdcOrderSysIDType是一个报单编号类型
using TThostFtdcOrderSysIDType = System.String;
///TFtdcTradeIDType是一个成交编号类型
using TThostFtdcTradeIDType = System.String;
///TFtdcCommandTypeType是一个DB命令类型类型
using TThostFtdcCommandTypeType = System.String;
///TFtdcOldIPAddressType是一个IP地址类型
using TThostFtdcOldIPAddressType = System.String;
///TFtdcIPAddressType是一个IP地址类型
using TThostFtdcIPAddressType = System.String;
///TFtdcIPPortType是一个IP端口类型
using TThostFtdcIPPortType = System.Int32;
///TFtdcProductInfoType是一个产品信息类型
using TThostFtdcProductInfoType = System.String;
///TFtdcProtocolInfoType是一个协议信息类型
using TThostFtdcProtocolInfoType = System.String;
///TFtdcBusinessUnitType是一个业务单元类型
using TThostFtdcBusinessUnitType = System.String;
///TFtdcDepositSeqNoType是一个出入金流水号类型
using TThostFtdcDepositSeqNoType = System.String;
///TFtdcIdentifiedCardNoType是一个证件号码类型
using TThostFtdcIdentifiedCardNoType = System.String;
///TFtdcIdCardTypeType是一个证件类型类型
using TThostFtdcIdCardTypeType = System.String;
///TFtdcOrderLocalIDType是一个本地报单编号类型
using TThostFtdcOrderLocalIDType = System.String;
///TFtdcUserNameType是一个用户名称类型
using TThostFtdcUserNameType = System.String;
///TFtdcPartyNameType是一个参与人名称类型
using TThostFtdcPartyNameType = System.String;
///TFtdcErrorMsgType是一个错误信息类型
using TThostFtdcErrorMsgType = System.String;
///TFtdcFieldNameType是一个字段名类型
using TThostFtdcFieldNameType = System.String;
///TFtdcFieldContentType是一个字段内容类型
using TThostFtdcFieldContentType = System.String;
///TFtdcSystemNameType是一个系统名称类型
using TThostFtdcSystemNameType = System.String;
///TFtdcContentType是一个消息正文类型
using TThostFtdcContentType = System.String;
///TFtdcInvestorRangeType是一个投资者范围类型
using TThostFtdcInvestorRangeType = System.String;
///TFtdcDepartmentRangeType是一个投资者范围类型
using TThostFtdcDepartmentRangeType = System.String;
///TFtdcDataSyncStatusType是一个数据同步状态类型
using TThostFtdcDataSyncStatusType = System.String;
///TFtdcBrokerDataSyncStatusType是一个经纪公司数据同步状态类型
using TThostFtdcBrokerDataSyncStatusType = System.String;
///TFtdcExchangeConnectStatusType是一个交易所连接状态类型
using TThostFtdcExchangeConnectStatusType = System.String;
///TFtdcTraderConnectStatusType是一个交易所交易员连接状态类型
using TThostFtdcTraderConnectStatusType = System.String;
///TFtdcFunctionCodeType是一个功能代码类型
using TThostFtdcFunctionCodeType = System.String;
///TFtdcBrokerFunctionCodeType是一个经纪公司功能代码类型
using TThostFtdcBrokerFunctionCodeType = System.String;
///TFtdcOrderActionStatusType是一个报单操作状态类型
using TThostFtdcOrderActionStatusType = System.String;
///TFtdcOrderStatusType是一个报单状态类型
using TThostFtdcOrderStatusType = System.String;
///TFtdcOrderSubmitStatusType是一个报单提交状态类型
using TThostFtdcOrderSubmitStatusType = System.String;
///TFtdcPositionDateType是一个持仓日期类型
using TThostFtdcPositionDateType = System.String;
///TFtdcPositionDateTypeType是一个持仓日期类型类型
using TThostFtdcPositionDateTypeType = System.String;
///TFtdcTradingRoleType是一个交易角色类型
using TThostFtdcTradingRoleType = System.String;
///TFtdcProductClassType是一个产品类型类型
using TThostFtdcProductClassType = System.String;
///TFtdcAPIProductClassType是一个产品类型类型
using TThostFtdcAPIProductClassType = System.String;
///TFtdcInstLifePhaseType是一个合约生命周期状态类型
using TThostFtdcInstLifePhaseType = System.String;
///TFtdcDirectionType是一个买卖方向类型
using TThostFtdcDirectionType = System.String;
///TFtdcPositionTypeType是一个持仓类型类型
using TThostFtdcPositionTypeType = System.String;
///TFtdcPosiDirectionType是一个持仓多空方向类型
using TThostFtdcPosiDirectionType = System.String;
///TFtdcSysSettlementStatusType是一个系统结算状态类型
using TThostFtdcSysSettlementStatusType = System.String;
///TFtdcRatioAttrType是一个费率属性类型
using TThostFtdcRatioAttrType = System.String;
///TFtdcHedgeFlagType是一个投机套保标志类型
using TThostFtdcHedgeFlagType = System.String;
///TFtdcBillHedgeFlagType是一个投机套保标志类型
using TThostFtdcBillHedgeFlagType = System.String;
///TFtdcClientIDTypeType是一个交易编码类型类型
using TThostFtdcClientIDTypeType = System.String;
///TFtdcOrderPriceTypeType是一个报单价格条件类型
using TThostFtdcOrderPriceTypeType = System.String;
///TFtdcOffsetFlagType是一个开平标志类型
using TThostFtdcOffsetFlagType = System.String;
///TFtdcForceCloseReasonType是一个强平原因类型
using TThostFtdcForceCloseReasonType = System.String;
///TFtdcOrderTypeType是一个报单类型类型
using TThostFtdcOrderTypeType = System.String;
///TFtdcTimeConditionType是一个有效期类型类型
using TThostFtdcTimeConditionType = System.String;
///TFtdcVolumeConditionType是一个成交量类型类型
using TThostFtdcVolumeConditionType = System.String;
///TFtdcContingentConditionType是一个触发条件类型
using TThostFtdcContingentConditionType = System.String;
///TFtdcActionFlagType是一个操作标志类型
using TThostFtdcActionFlagType = System.String;
///TFtdcTradingRightType是一个交易权限类型
using TThostFtdcTradingRightType = System.String;
///TFtdcOrderSourceType是一个报单来源类型
using TThostFtdcOrderSourceType = System.String;
///TFtdcTradeTypeType是一个成交类型类型
using TThostFtdcTradeTypeType = System.String;
///TFtdcSpecPosiTypeType是一个特殊持仓明细标识类型
using TThostFtdcSpecPosiTypeType = System.String;
///TFtdcPriceSourceType是一个成交价来源类型
using TThostFtdcPriceSourceType = System.String;
///TFtdcInstrumentStatusType是一个合约交易状态类型
using TThostFtdcInstrumentStatusType = System.String;
///TFtdcInstStatusEnterReasonType是一个品种进入交易状态原因类型
using TThostFtdcInstStatusEnterReasonType = System.String;
///TFtdcOrderActionRefType是一个报单操作引用类型
using TThostFtdcOrderActionRefType = System.Int32;
///TFtdcInstallCountType是一个安装数量类型
using TThostFtdcInstallCountType = System.Int32;
///TFtdcInstallIDType是一个安装编号类型
using TThostFtdcInstallIDType = System.Int32;
///TFtdcErrorIDType是一个错误代码类型
using TThostFtdcErrorIDType = System.Int32;
///TFtdcSettlementIDType是一个结算编号类型
using TThostFtdcSettlementIDType = System.Int32;
///TFtdcVolumeType是一个数量类型
using TThostFtdcVolumeType = System.Int32;
///TFtdcFrontIDType是一个前置编号类型
using TThostFtdcFrontIDType = System.Int32;
///TFtdcSessionIDType是一个会话编号类型
using TThostFtdcSessionIDType = System.Int32;
///TFtdcSequenceNoType是一个序号类型
using TThostFtdcSequenceNoType = System.Int32;
///TFtdcCommandNoType是一个DB命令序号类型
using TThostFtdcCommandNoType = System.Int32;
///TFtdcMillisecType是一个时间（毫秒）类型
using TThostFtdcMillisecType = System.Int32;
///TFtdcSecType是一个时间（秒）类型
using TThostFtdcSecType = System.Int32;
///TFtdcVolumeMultipleType是一个合约数量乘数类型
using TThostFtdcVolumeMultipleType = System.Int32;
///TFtdcTradingSegmentSNType是一个交易阶段编号类型
using TThostFtdcTradingSegmentSNType = System.Int32;
///TFtdcRequestIDType是一个请求编号类型
using TThostFtdcRequestIDType = System.Int32;
///TFtdcYearType是一个年份类型
using TThostFtdcYearType = System.Int32;
///TFtdcMonthType是一个月份类型
using TThostFtdcMonthType = System.Int32;
///TFtdcBoolType是一个布尔型类型
using TThostFtdcBoolType = System.Int32;
///TFtdcPriceType是一个价格类型
using TThostFtdcPriceType = System.Double;
///TFtdcCombOffsetFlagType是一个组合开平标志类型
using TThostFtdcCombOffsetFlagType = System.String;
///TFtdcCombHedgeFlagType是一个组合投机套保标志类型
using TThostFtdcCombHedgeFlagType = System.String;
///TFtdcRatioType是一个比率类型
using TThostFtdcRatioType = System.Double;
///TFtdcMoneyType是一个资金类型
using TThostFtdcMoneyType = System.Double;
///TFtdcLargeVolumeType是一个大额数量类型
using TThostFtdcLargeVolumeType = System.Double;
///TFtdcSequenceSeriesType是一个序列系列号类型
using TThostFtdcSequenceSeriesType = System.Int16;
///TFtdcCommPhaseNoType是一个通讯时段编号类型
using TThostFtdcCommPhaseNoType = System.Int16;
///TFtdcSequenceLabelType是一个序列编号类型
using TThostFtdcSequenceLabelType = System.String;
///TFtdcUnderlyingMultipleType是一个基础商品乘数类型
using TThostFtdcUnderlyingMultipleType = System.Double;
///TFtdcPriorityType是一个优先级类型
using TThostFtdcPriorityType = System.Int32;
///TFtdcContractCodeType是一个合同编号类型
using TThostFtdcContractCodeType = System.String;
///TFtdcCityType是一个市类型
using TThostFtdcCityType = System.String;
///TFtdcIsStockType是一个是否股民类型
using TThostFtdcIsStockType = System.String;
///TFtdcChannelType是一个渠道类型
using TThostFtdcChannelType = System.String;
///TFtdcAddressType是一个通讯地址类型
using TThostFtdcAddressType = System.String;
///TFtdcZipCodeType是一个邮政编码类型
using TThostFtdcZipCodeType = System.String;
///TFtdcTelephoneType是一个联系电话类型
using TThostFtdcTelephoneType = System.String;
///TFtdcFaxType是一个传真类型
using TThostFtdcFaxType = System.String;
///TFtdcMobileType是一个手机类型
using TThostFtdcMobileType = System.String;
///TFtdcEMailType是一个电子邮件类型
using TThostFtdcEMailType = System.String;
///TFtdcMemoType是一个备注类型
using TThostFtdcMemoType = System.String;
///TFtdcCompanyCodeType是一个企业代码类型
using TThostFtdcCompanyCodeType = System.String;
///TFtdcWebsiteType是一个网站地址类型
using TThostFtdcWebsiteType = System.String;
///TFtdcTaxNoType是一个税务登记号类型
using TThostFtdcTaxNoType = System.String;
///TFtdcBatchStatusType是一个处理状态类型
using TThostFtdcBatchStatusType = System.String;
///TFtdcPropertyIDType是一个属性代码类型
using TThostFtdcPropertyIDType = System.String;
///TFtdcPropertyNameType是一个属性名称类型
using TThostFtdcPropertyNameType = System.String;
///TFtdcLicenseNoType是一个营业执照号类型
using TThostFtdcLicenseNoType = System.String;
///TFtdcAgentIDType是一个经纪人代码类型
using TThostFtdcAgentIDType = System.String;
///TFtdcAgentNameType是一个经纪人名称类型
using TThostFtdcAgentNameType = System.String;
///TFtdcAgentGroupIDType是一个经纪人组代码类型
using TThostFtdcAgentGroupIDType = System.String;
///TFtdcAgentGroupNameType是一个经纪人组名称类型
using TThostFtdcAgentGroupNameType = System.String;
///TFtdcReturnStyleType是一个按品种返还方式类型
using TThostFtdcReturnStyleType = System.String;
///TFtdcReturnPatternType是一个返还模式类型
using TThostFtdcReturnPatternType = System.String;
///TFtdcReturnLevelType是一个返还级别类型
using TThostFtdcReturnLevelType = System.String;
///TFtdcReturnStandardType是一个返还标准类型
using TThostFtdcReturnStandardType = System.String;
///TFtdcMortgageTypeType是一个质押类型类型
using TThostFtdcMortgageTypeType = System.String;
///TFtdcInvestorSettlementParamIDType是一个投资者结算参数代码类型
using TThostFtdcInvestorSettlementParamIDType = System.String;
///TFtdcExchangeSettlementParamIDType是一个交易所结算参数代码类型
using TThostFtdcExchangeSettlementParamIDType = System.String;
///TFtdcSystemParamIDType是一个系统参数代码类型
using TThostFtdcSystemParamIDType = System.String;
///TFtdcTradeParamIDType是一个交易系统参数代码类型
using TThostFtdcTradeParamIDType = System.String;
///TFtdcSettlementParamValueType是一个参数代码值类型
using TThostFtdcSettlementParamValueType = System.String;
///TFtdcCounterIDType是一个计数器代码类型
using TThostFtdcCounterIDType = System.String;
///TFtdcInvestorGroupNameType是一个投资者分组名称类型
using TThostFtdcInvestorGroupNameType = System.String;
///TFtdcBrandCodeType是一个牌号类型
using TThostFtdcBrandCodeType = System.String;
///TFtdcWarehouseType是一个仓库类型
using TThostFtdcWarehouseType = System.String;
///TFtdcProductDateType是一个产期类型
using TThostFtdcProductDateType = System.String;
///TFtdcGradeType是一个等级类型
using TThostFtdcGradeType = System.String;
///TFtdcClassifyType是一个类别类型
using TThostFtdcClassifyType = System.String;
///TFtdcPositionType是一个货位类型
using TThostFtdcPositionType = System.String;
///TFtdcYieldlyType是一个产地类型
using TThostFtdcYieldlyType = System.String;
///TFtdcWeightType是一个公定重量类型
using TThostFtdcWeightType = System.String;
///TFtdcSubEntryFundNoType是一个分项资金流水号类型
using TThostFtdcSubEntryFundNoType = System.Int32;
///TFtdcFileIDType是一个文件标识类型
using TThostFtdcFileIDType = System.String;
///TFtdcFileNameType是一个文件名称类型
using TThostFtdcFileNameType = System.String;
///TFtdcFileTypeType是一个文件上传类型类型
using TThostFtdcFileTypeType = System.String;
///TFtdcFileFormatType是一个文件格式类型
using TThostFtdcFileFormatType = System.String;
///TFtdcFileUploadStatusType是一个文件状态类型
using TThostFtdcFileUploadStatusType = System.String;
///TFtdcTransferDirectionType是一个移仓方向类型
using TThostFtdcTransferDirectionType = System.String;
///TFtdcUploadModeType是一个上传文件类型类型
using TThostFtdcUploadModeType = System.String;
///TFtdcAccountIDType是一个投资者帐号类型
using TThostFtdcAccountIDType = System.String;
///TFtdcBankFlagType是一个银行统一标识类型类型
using TThostFtdcBankFlagType = System.String;
///TFtdcBankAccountType是一个银行账户类型
using TThostFtdcBankAccountType = System.String;
///TFtdcOpenNameType是一个银行账户的开户人名称类型
using TThostFtdcOpenNameType = System.String;
///TFtdcOpenBankType是一个银行账户的开户行类型
using TThostFtdcOpenBankType = System.String;
///TFtdcBankNameType是一个银行名称类型
using TThostFtdcBankNameType = System.String;
///TFtdcPublishPathType是一个发布路径类型
using TThostFtdcPublishPathType = System.String;
///TFtdcOperatorIDType是一个操作员代码类型
using TThostFtdcOperatorIDType = System.String;
///TFtdcMonthCountType是一个月份数量类型
using TThostFtdcMonthCountType = System.Int32;
///TFtdcAdvanceMonthArrayType是一个月份提前数组类型
using TThostFtdcAdvanceMonthArrayType = System.String;
///TFtdcDateExprType是一个日期表达式类型
using TThostFtdcDateExprType = System.String;
///TFtdcInstrumentIDExprType是一个合约代码表达式类型
using TThostFtdcInstrumentIDExprType = System.String;
///TFtdcInstrumentNameExprType是一个合约名称表达式类型
using TThostFtdcInstrumentNameExprType = System.String;
///TFtdcSpecialCreateRuleType是一个特殊的创建规则类型
using TThostFtdcSpecialCreateRuleType = System.String;
///TFtdcBasisPriceTypeType是一个挂牌基准价类型类型
using TThostFtdcBasisPriceTypeType = System.String;
///TFtdcProductLifePhaseType是一个产品生命周期状态类型
using TThostFtdcProductLifePhaseType = System.String;
///TFtdcDeliveryModeType是一个交割方式类型
using TThostFtdcDeliveryModeType = System.String;
///TFtdcLogLevelType是一个日志级别类型
using TThostFtdcLogLevelType = System.String;
///TFtdcProcessNameType是一个存储过程名称类型
using TThostFtdcProcessNameType = System.String;
///TFtdcOperationMemoType是一个操作摘要类型
using TThostFtdcOperationMemoType = System.String;
///TFtdcFundIOTypeType是一个出入金类型类型
using TThostFtdcFundIOTypeType = System.String;
///TFtdcFundTypeType是一个资金类型类型
using TThostFtdcFundTypeType = System.String;
///TFtdcFundDirectionType是一个出入金方向类型
using TThostFtdcFundDirectionType = System.String;
///TFtdcFundStatusType是一个资金状态类型
using TThostFtdcFundStatusType = System.String;
///TFtdcBillNoType是一个票据号类型
using TThostFtdcBillNoType = System.String;
///TFtdcBillNameType是一个票据名称类型
using TThostFtdcBillNameType = System.String;
///TFtdcPublishStatusType是一个发布状态类型
using TThostFtdcPublishStatusType = System.String;
///TFtdcEnumValueIDType是一个枚举值代码类型
using TThostFtdcEnumValueIDType = System.String;
///TFtdcEnumValueTypeType是一个枚举值类型类型
using TThostFtdcEnumValueTypeType = System.String;
///TFtdcEnumValueLabelType是一个枚举值名称类型
using TThostFtdcEnumValueLabelType = System.String;
///TFtdcEnumValueResultType是一个枚举值结果类型
using TThostFtdcEnumValueResultType = System.String;
///TFtdcSystemStatusType是一个系统状态类型
using TThostFtdcSystemStatusType = System.String;
///TFtdcSettlementStatusType是一个结算状态类型
using TThostFtdcSettlementStatusType = System.String;
///TFtdcRangeIntTypeType是一个限定值类型类型
using TThostFtdcRangeIntTypeType = System.String;
///TFtdcRangeIntFromType是一个限定值下限类型
using TThostFtdcRangeIntFromType = System.String;
///TFtdcRangeIntToType是一个限定值上限类型
using TThostFtdcRangeIntToType = System.String;
///TFtdcFunctionIDType是一个功能代码类型
using TThostFtdcFunctionIDType = System.String;
///TFtdcFunctionValueCodeType是一个功能编码类型
using TThostFtdcFunctionValueCodeType = System.String;
///TFtdcFunctionNameType是一个功能名称类型
using TThostFtdcFunctionNameType = System.String;
///TFtdcRoleIDType是一个角色编号类型
using TThostFtdcRoleIDType = System.String;
///TFtdcRoleNameType是一个角色名称类型
using TThostFtdcRoleNameType = System.String;
///TFtdcDescriptionType是一个描述类型
using TThostFtdcDescriptionType = System.String;
///TFtdcCombineIDType是一个组合编号类型
using TThostFtdcCombineIDType = System.String;
///TFtdcCombineTypeType是一个组合类型类型
using TThostFtdcCombineTypeType = System.String;
///TFtdcInvestorTypeType是一个投资者类型类型
using TThostFtdcInvestorTypeType = System.String;
///TFtdcBrokerTypeType是一个经纪公司类型类型
using TThostFtdcBrokerTypeType = System.String;
///TFtdcRiskLevelType是一个风险等级类型
using TThostFtdcRiskLevelType = System.String;
///TFtdcFeeAcceptStyleType是一个手续费收取方式类型
using TThostFtdcFeeAcceptStyleType = System.String;
///TFtdcPasswordTypeType是一个密码类型类型
using TThostFtdcPasswordTypeType = System.String;
///TFtdcAlgorithmType是一个盈亏算法类型
using TThostFtdcAlgorithmType = System.String;
///TFtdcIncludeCloseProfitType是一个是否包含平仓盈利类型
using TThostFtdcIncludeCloseProfitType = System.String;
///TFtdcAllWithoutTradeType是一个是否受可提比例限制类型
using TThostFtdcAllWithoutTradeType = System.String;
///TFtdcCommentType是一个盈亏算法说明类型
using TThostFtdcCommentType = System.String;
///TFtdcVersionType是一个版本号类型
using TThostFtdcVersionType = System.String;
///TFtdcTradeCodeType是一个交易代码类型
using TThostFtdcTradeCodeType = System.String;
///TFtdcTradeDateType是一个交易日期类型
using TThostFtdcTradeDateType = System.String;
///TFtdcTradeTimeType是一个交易时间类型
using TThostFtdcTradeTimeType = System.String;
///TFtdcTradeSerialType是一个发起方流水号类型
using TThostFtdcTradeSerialType = System.String;
///TFtdcTradeSerialNoType是一个发起方流水号类型
using TThostFtdcTradeSerialNoType = System.Int32;
///TFtdcFutureIDType是一个期货公司代码类型
using TThostFtdcFutureIDType = System.String;
///TFtdcBankIDType是一个银行代码类型
using TThostFtdcBankIDType = System.String;
///TFtdcBankBrchIDType是一个银行分中心代码类型
using TThostFtdcBankBrchIDType = System.String;
///TFtdcBankBranchIDType是一个分中心代码类型
using TThostFtdcBankBranchIDType = System.String;
///TFtdcOperNoType是一个交易柜员类型
using TThostFtdcOperNoType = System.String;
///TFtdcDeviceIDType是一个渠道标志类型
using TThostFtdcDeviceIDType = System.String;
///TFtdcRecordNumType是一个记录数类型
using TThostFtdcRecordNumType = System.String;
///TFtdcFutureAccountType是一个期货资金账号类型
using TThostFtdcFutureAccountType = System.String;
///TFtdcFuturePwdFlagType是一个资金密码核对标志类型
using TThostFtdcFuturePwdFlagType = System.String;
///TFtdcTransferTypeType是一个银期转账类型类型
using TThostFtdcTransferTypeType = System.String;
///TFtdcFutureAccPwdType是一个期货资金密码类型
using TThostFtdcFutureAccPwdType = System.String;
///TFtdcCurrencyCodeType是一个币种类型
using TThostFtdcCurrencyCodeType = System.String;
///TFtdcRetCodeType是一个响应代码类型
using TThostFtdcRetCodeType = System.String;
///TFtdcRetInfoType是一个响应信息类型
using TThostFtdcRetInfoType = System.String;
///TFtdcTradeAmtType是一个银行总余额类型
using TThostFtdcTradeAmtType = System.String;
///TFtdcUseAmtType是一个银行可用余额类型
using TThostFtdcUseAmtType = System.String;
///TFtdcFetchAmtType是一个银行可取余额类型
using TThostFtdcFetchAmtType = System.String;
///TFtdcTransferValidFlagType是一个转账有效标志类型
using TThostFtdcTransferValidFlagType = System.String;
///TFtdcCertCodeType是一个证件号码类型
using TThostFtdcCertCodeType = System.String;
///TFtdcReasonType是一个事由类型
using TThostFtdcReasonType = System.String;
///TFtdcFundProjectIDType是一个资金项目编号类型
using TThostFtdcFundProjectIDType = System.String;
///TFtdcSexType是一个性别类型
using TThostFtdcSexType = System.String;
///TFtdcProfessionType是一个职业类型
using TThostFtdcProfessionType = System.String;
///TFtdcNationalType是一个国籍类型
using TThostFtdcNationalType = System.String;
///TFtdcProvinceType是一个省类型
using TThostFtdcProvinceType = System.String;
///TFtdcRegionType是一个区类型
using TThostFtdcRegionType = System.String;
///TFtdcCountryType是一个国家类型
using TThostFtdcCountryType = System.String;
///TFtdcLicenseNOType是一个营业执照类型
using TThostFtdcLicenseNOType = System.String;
///TFtdcCompanyTypeType是一个企业性质类型
using TThostFtdcCompanyTypeType = System.String;
///TFtdcBusinessScopeType是一个经营范围类型
using TThostFtdcBusinessScopeType = System.String;
///TFtdcCapitalCurrencyType是一个注册资本币种类型
using TThostFtdcCapitalCurrencyType = System.String;
///TFtdcUserTypeType是一个用户类型类型
using TThostFtdcUserTypeType = System.String;
///TFtdcBranchIDType是一个营业部编号类型
using TThostFtdcBranchIDType = System.String;
///TFtdcRateTypeType是一个费率类型类型
using TThostFtdcRateTypeType = System.String;
///TFtdcNoteTypeType是一个通知类型类型
using TThostFtdcNoteTypeType = System.String;
///TFtdcSettlementStyleType是一个结算单方式类型
using TThostFtdcSettlementStyleType = System.String;
///TFtdcBrokerDNSType是一个域名类型
using TThostFtdcBrokerDNSType = System.String;
///TFtdcSentenceType是一个语句类型
using TThostFtdcSentenceType = System.String;
///TFtdcSettlementBillTypeType是一个结算单类型类型
using TThostFtdcSettlementBillTypeType = System.String;
///TFtdcUserRightTypeType是一个客户权限类型类型
using TThostFtdcUserRightTypeType = System.String;
///TFtdcMarginPriceTypeType是一个保证金价格类型类型
using TThostFtdcMarginPriceTypeType = System.String;
///TFtdcBillGenStatusType是一个结算单生成状态类型
using TThostFtdcBillGenStatusType = System.String;
///TFtdcAlgoTypeType是一个算法类型类型
using TThostFtdcAlgoTypeType = System.String;
///TFtdcHandlePositionAlgoIDType是一个持仓处理算法编号类型
using TThostFtdcHandlePositionAlgoIDType = System.String;
///TFtdcFindMarginRateAlgoIDType是一个寻找保证金率算法编号类型
using TThostFtdcFindMarginRateAlgoIDType = System.String;
///TFtdcHandleTradingAccountAlgoIDType是一个资金处理算法编号类型
using TThostFtdcHandleTradingAccountAlgoIDType = System.String;
///TFtdcPersonTypeType是一个联系人类型类型
using TThostFtdcPersonTypeType = System.String;
///TFtdcQueryInvestorRangeType是一个查询范围类型
using TThostFtdcQueryInvestorRangeType = System.String;
///TFtdcInvestorRiskStatusType是一个投资者风险状态类型
using TThostFtdcInvestorRiskStatusType = System.String;
///TFtdcLegIDType是一个单腿编号类型
using TThostFtdcLegIDType = System.Int32;
///TFtdcLegMultipleType是一个单腿乘数类型
using TThostFtdcLegMultipleType = System.Int32;
///TFtdcImplyLevelType是一个派生层数类型
using TThostFtdcImplyLevelType = System.Int32;
///TFtdcClearAccountType是一个结算账户类型
using TThostFtdcClearAccountType = System.String;
///TFtdcOrganNOType是一个结算账户类型
using TThostFtdcOrganNOType = System.String;
///TFtdcClearbarchIDType是一个结算账户联行号类型
using TThostFtdcClearbarchIDType = System.String;
///TFtdcUserEventTypeType是一个用户事件类型类型
using TThostFtdcUserEventTypeType = System.String;
///TFtdcUserEventInfoType是一个用户事件信息类型
using TThostFtdcUserEventInfoType = System.String;
///TFtdcCloseStyleType是一个平仓方式类型
using TThostFtdcCloseStyleType = System.String;
///TFtdcStatModeType是一个统计方式类型
using TThostFtdcStatModeType = System.String;
///TFtdcParkedOrderStatusType是一个预埋单状态类型
using TThostFtdcParkedOrderStatusType = System.String;
///TFtdcParkedOrderIDType是一个预埋报单编号类型
using TThostFtdcParkedOrderIDType = System.String;
///TFtdcParkedOrderActionIDType是一个预埋撤单编号类型
using TThostFtdcParkedOrderActionIDType = System.String;
///TFtdcVirDealStatusType是一个处理状态类型
using TThostFtdcVirDealStatusType = System.String;
///TFtdcOrgSystemIDType是一个原有系统代码类型
using TThostFtdcOrgSystemIDType = System.String;
///TFtdcVirTradeStatusType是一个交易状态类型
using TThostFtdcVirTradeStatusType = System.String;
///TFtdcVirBankAccTypeType是一个银行帐户类型类型
using TThostFtdcVirBankAccTypeType = System.String;
///TFtdcVirementStatusType是一个银行帐户类型类型
using TThostFtdcVirementStatusType = System.String;
///TFtdcVirementAvailAbilityType是一个有效标志类型
using TThostFtdcVirementAvailAbilityType = System.String;
///TFtdcVirementTradeCodeType是一个交易代码类型
using TThostFtdcVirementTradeCodeType = System.String;
///TFtdcPhotoTypeNameType是一个影像类型名称类型
using TThostFtdcPhotoTypeNameType = System.String;
///TFtdcPhotoTypeIDType是一个影像类型代码类型
using TThostFtdcPhotoTypeIDType = System.String;
///TFtdcPhotoNameType是一个影像名称类型
using TThostFtdcPhotoNameType = System.String;
///TFtdcTopicIDType是一个主题代码类型
using TThostFtdcTopicIDType = System.Int32;
///TFtdcReportTypeIDType是一个交易报告类型标识类型
using TThostFtdcReportTypeIDType = System.String;
///TFtdcCharacterIDType是一个交易特征代码类型
using TThostFtdcCharacterIDType = System.String;
///TFtdcAMLParamIDType是一个参数代码类型
using TThostFtdcAMLParamIDType = System.String;
///TFtdcAMLInvestorTypeType是一个投资者类型类型
using TThostFtdcAMLInvestorTypeType = System.String;
///TFtdcAMLIdCardTypeType是一个证件类型类型
using TThostFtdcAMLIdCardTypeType = System.String;
///TFtdcAMLTradeDirectType是一个资金进出方向类型
using TThostFtdcAMLTradeDirectType = System.String;
///TFtdcAMLTradeModelType是一个资金进出方式类型
using TThostFtdcAMLTradeModelType = System.String;
///TFtdcAMLOpParamValueType是一个业务参数代码值类型
using TThostFtdcAMLOpParamValueType = System.Double;
///TFtdcAMLCustomerCardTypeType是一个客户身份证件/证明文件类型类型
using TThostFtdcAMLCustomerCardTypeType = System.String;
///TFtdcAMLInstitutionNameType是一个金融机构网点名称类型
using TThostFtdcAMLInstitutionNameType = System.String;
///TFtdcAMLDistrictIDType是一个金融机构网点所在地区行政区划代码类型
using TThostFtdcAMLDistrictIDType = System.String;
///TFtdcAMLRelationShipType是一个金融机构网点与大额交易的关系类型
using TThostFtdcAMLRelationShipType = System.String;
///TFtdcAMLInstitutionTypeType是一个金融机构网点代码类型类型
using TThostFtdcAMLInstitutionTypeType = System.String;
///TFtdcAMLInstitutionIDType是一个金融机构网点代码类型
using TThostFtdcAMLInstitutionIDType = System.String;
///TFtdcAMLAccountTypeType是一个账户类型类型
using TThostFtdcAMLAccountTypeType = System.String;
///TFtdcAMLTradingTypeType是一个交易方式类型
using TThostFtdcAMLTradingTypeType = System.String;
///TFtdcAMLTransactClassType是一个涉外收支交易分类与代码类型
using TThostFtdcAMLTransactClassType = System.String;
///TFtdcAMLCapitalIOType是一个资金收付标识类型
using TThostFtdcAMLCapitalIOType = System.String;
///TFtdcAMLSiteType是一个交易地点类型
using TThostFtdcAMLSiteType = System.String;
///TFtdcAMLCapitalPurposeType是一个资金用途类型
using TThostFtdcAMLCapitalPurposeType = System.String;
///TFtdcAMLReportTypeType是一个报文类型类型
using TThostFtdcAMLReportTypeType = System.String;
///TFtdcAMLSerialNoType是一个编号类型
using TThostFtdcAMLSerialNoType = System.String;
///TFtdcAMLStatusType是一个状态类型
using TThostFtdcAMLStatusType = System.String;
///TFtdcAMLGenStatusType是一个Aml生成方式类型
using TThostFtdcAMLGenStatusType = System.String;
///TFtdcAMLSeqCodeType是一个业务标识号类型
using TThostFtdcAMLSeqCodeType = System.String;
///TFtdcAMLFileNameType是一个AML文件名类型
using TThostFtdcAMLFileNameType = System.String;
///TFtdcAMLMoneyType是一个反洗钱资金类型
using TThostFtdcAMLMoneyType = System.Double;
///TFtdcAMLFileAmountType是一个反洗钱资金类型
using TThostFtdcAMLFileAmountType = System.Int32;
///TFtdcCFMMCKeyType是一个密钥类型(保证金监管)类型
using TThostFtdcCFMMCKeyType = System.String;
///TFtdcCFMMCTokenType是一个令牌类型(保证金监管)类型
using TThostFtdcCFMMCTokenType = System.String;
///TFtdcCFMMCKeyKindType是一个动态密钥类别(保证金监管)类型
using TThostFtdcCFMMCKeyKindType = System.String;
///TFtdcAMLReportNameType是一个报文名称类型
using TThostFtdcAMLReportNameType = System.String;
///TFtdcIndividualNameType是一个个人姓名类型
using TThostFtdcIndividualNameType = System.String;
///TFtdcCurrencyIDType是一个币种代码类型
using TThostFtdcCurrencyIDType = System.String;
///TFtdcCustNumberType是一个客户编号类型
using TThostFtdcCustNumberType = System.String;
///TFtdcOrganCodeType是一个机构编码类型
using TThostFtdcOrganCodeType = System.String;
///TFtdcOrganNameType是一个机构名称类型
using TThostFtdcOrganNameType = System.String;
///TFtdcSuperOrganCodeType是一个上级机构编码,即期货公司总部、银行总行类型
using TThostFtdcSuperOrganCodeType = System.String;
///TFtdcSubBranchIDType是一个分支机构类型
using TThostFtdcSubBranchIDType = System.String;
///TFtdcSubBranchNameType是一个分支机构名称类型
using TThostFtdcSubBranchNameType = System.String;
///TFtdcBranchNetCodeType是一个机构网点号类型
using TThostFtdcBranchNetCodeType = System.String;
///TFtdcBranchNetNameType是一个机构网点名称类型
using TThostFtdcBranchNetNameType = System.String;
///TFtdcOrganFlagType是一个机构标识类型
using TThostFtdcOrganFlagType = System.String;
///TFtdcBankCodingForFutureType是一个银行对期货公司的编码类型
using TThostFtdcBankCodingForFutureType = System.String;
///TFtdcBankReturnCodeType是一个银行对返回码的定义类型
using TThostFtdcBankReturnCodeType = System.String;
///TFtdcPlateReturnCodeType是一个银期转帐平台对返回码的定义类型
using TThostFtdcPlateReturnCodeType = System.String;
///TFtdcBankSubBranchIDType是一个银行分支机构编码类型
using TThostFtdcBankSubBranchIDType = System.String;
///TFtdcFutureBranchIDType是一个期货分支机构编码类型
using TThostFtdcFutureBranchIDType = System.String;
///TFtdcReturnCodeType是一个返回代码类型
using TThostFtdcReturnCodeType = System.String;
///TFtdcOperatorCodeType是一个操作员类型
using TThostFtdcOperatorCodeType = System.String;
///TFtdcClearDepIDType是一个机构结算帐户机构号类型
using TThostFtdcClearDepIDType = System.String;
///TFtdcClearBrchIDType是一个机构结算帐户联行号类型
using TThostFtdcClearBrchIDType = System.String;
///TFtdcClearNameType是一个机构结算帐户名称类型
using TThostFtdcClearNameType = System.String;
///TFtdcBankAccountNameType是一个银行帐户名称类型
using TThostFtdcBankAccountNameType = System.String;
///TFtdcInvDepIDType是一个机构投资人账号机构号类型
using TThostFtdcInvDepIDType = System.String;
///TFtdcInvBrchIDType是一个机构投资人联行号类型
using TThostFtdcInvBrchIDType = System.String;
///TFtdcMessageFormatVersionType是一个信息格式版本类型
using TThostFtdcMessageFormatVersionType = System.String;
///TFtdcDigestType是一个摘要类型
using TThostFtdcDigestType = System.String;
///TFtdcAuthenticDataType是一个认证数据类型
using TThostFtdcAuthenticDataType = System.String;
///TFtdcPasswordKeyType是一个密钥类型
using TThostFtdcPasswordKeyType = System.String;
///TFtdcFutureAccountNameType是一个期货帐户名称类型
using TThostFtdcFutureAccountNameType = System.String;
///TFtdcMobilePhoneType是一个手机类型
using TThostFtdcMobilePhoneType = System.String;
///TFtdcFutureMainKeyType是一个期货公司主密钥类型
using TThostFtdcFutureMainKeyType = System.String;
///TFtdcFutureWorkKeyType是一个期货公司工作密钥类型
using TThostFtdcFutureWorkKeyType = System.String;
///TFtdcFutureTransKeyType是一个期货公司传输密钥类型
using TThostFtdcFutureTransKeyType = System.String;
///TFtdcBankMainKeyType是一个银行主密钥类型
using TThostFtdcBankMainKeyType = System.String;
///TFtdcBankWorkKeyType是一个银行工作密钥类型
using TThostFtdcBankWorkKeyType = System.String;
///TFtdcBankTransKeyType是一个银行传输密钥类型
using TThostFtdcBankTransKeyType = System.String;
///TFtdcBankServerDescriptionType是一个银行服务器描述信息类型
using TThostFtdcBankServerDescriptionType = System.String;
///TFtdcAddInfoType是一个附加信息类型
using TThostFtdcAddInfoType = System.String;
///TFtdcDescrInfoForReturnCodeType是一个返回码描述类型
using TThostFtdcDescrInfoForReturnCodeType = System.String;
///TFtdcCountryCodeType是一个国家代码类型
using TThostFtdcCountryCodeType = System.String;
///TFtdcSerialType是一个流水号类型
using TThostFtdcSerialType = System.Int32;
///TFtdcPlateSerialType是一个平台流水号类型
using TThostFtdcPlateSerialType = System.Int32;
///TFtdcBankSerialType是一个银行流水号类型
using TThostFtdcBankSerialType = System.String;
///TFtdcCorrectSerialType是一个被冲正交易流水号类型
using TThostFtdcCorrectSerialType = System.Int32;
///TFtdcFutureSerialType是一个期货公司流水号类型
using TThostFtdcFutureSerialType = System.Int32;
///TFtdcApplicationIDType是一个应用标识类型
using TThostFtdcApplicationIDType = System.Int32;
///TFtdcBankProxyIDType是一个银行代理标识类型
using TThostFtdcBankProxyIDType = System.Int32;
///TFtdcFBTCoreIDType是一个银期转帐核心系统标识类型
using TThostFtdcFBTCoreIDType = System.Int32;
///TFtdcServerPortType是一个服务端口号类型
using TThostFtdcServerPortType = System.Int32;
///TFtdcRepealedTimesType是一个已经冲正次数类型
using TThostFtdcRepealedTimesType = System.Int32;
///TFtdcRepealTimeIntervalType是一个冲正时间间隔类型
using TThostFtdcRepealTimeIntervalType = System.Int32;
///TFtdcTotalTimesType是一个每日累计转帐次数类型
using TThostFtdcTotalTimesType = System.Int32;
///TFtdcFBTRequestIDType是一个请求ID类型
using TThostFtdcFBTRequestIDType = System.Int32;
///TFtdcTIDType是一个交易ID类型
using TThostFtdcTIDType = System.Int32;
///TFtdcTradeAmountType是一个交易金额（元）类型
using TThostFtdcTradeAmountType = System.Double;
///TFtdcCustFeeType是一个应收客户费用（元）类型
using TThostFtdcCustFeeType = System.Double;
///TFtdcFutureFeeType是一个应收期货公司费用（元）类型
using TThostFtdcFutureFeeType = System.Double;
///TFtdcSingleMaxAmtType是一个单笔最高限额类型
using TThostFtdcSingleMaxAmtType = System.Double;
///TFtdcSingleMinAmtType是一个单笔最低限额类型
using TThostFtdcSingleMinAmtType = System.Double;
///TFtdcTotalAmtType是一个每日累计转帐额度类型
using TThostFtdcTotalAmtType = System.Double;
///TFtdcCertificationTypeType是一个证件类型类型
using TThostFtdcCertificationTypeType = System.String;
///TFtdcFileBusinessCodeType是一个文件业务功能类型
using TThostFtdcFileBusinessCodeType = System.String;
///TFtdcCashExchangeCodeType是一个汇钞标志类型
using TThostFtdcCashExchangeCodeType = System.String;
///TFtdcYesNoIndicatorType是一个是或否标识类型
using TThostFtdcYesNoIndicatorType = System.String;
///TFtdcBanlanceTypeType是一个余额类型类型
using TThostFtdcBanlanceTypeType = System.String;
///TFtdcGenderType是一个性别类型
using TThostFtdcGenderType = System.String;
///TFtdcFeePayFlagType是一个费用支付标志类型
using TThostFtdcFeePayFlagType = System.String;
///TFtdcPassWordKeyTypeType是一个密钥类型类型
using TThostFtdcPassWordKeyTypeType = System.String;
///TFtdcFBTPassWordTypeType是一个密码类型类型
using TThostFtdcFBTPassWordTypeType = System.String;
///TFtdcFBTEncryModeType是一个加密方式类型
using TThostFtdcFBTEncryModeType = System.String;
///TFtdcBankRepealFlagType是一个银行冲正标志类型
using TThostFtdcBankRepealFlagType = System.String;
///TFtdcBrokerRepealFlagType是一个期商冲正标志类型
using TThostFtdcBrokerRepealFlagType = System.String;
///TFtdcInstitutionTypeType是一个机构类别类型
using TThostFtdcInstitutionTypeType = System.String;
///TFtdcLastFragmentType是一个最后分片标志类型
using TThostFtdcLastFragmentType = System.String;
///TFtdcBankAccStatusType是一个银行账户状态类型
using TThostFtdcBankAccStatusType = System.String;
///TFtdcMoneyAccountStatusType是一个资金账户状态类型
using TThostFtdcMoneyAccountStatusType = System.String;
///TFtdcManageStatusType是一个存管状态类型
using TThostFtdcManageStatusType = System.String;
///TFtdcSystemTypeType是一个应用系统类型类型
using TThostFtdcSystemTypeType = System.String;
///TFtdcTxnEndFlagType是一个银期转帐划转结果标志类型
using TThostFtdcTxnEndFlagType = System.String;
///TFtdcProcessStatusType是一个银期转帐服务处理状态类型
using TThostFtdcProcessStatusType = System.String;
///TFtdcCustTypeType是一个客户类型类型
using TThostFtdcCustTypeType = System.String;
///TFtdcFBTTransferDirectionType是一个银期转帐方向类型
using TThostFtdcFBTTransferDirectionType = System.String;
///TFtdcOpenOrDestroyType是一个开销户类别类型
using TThostFtdcOpenOrDestroyType = System.String;
///TFtdcAvailabilityFlagType是一个有效标志类型
using TThostFtdcAvailabilityFlagType = System.String;
///TFtdcOrganTypeType是一个机构类型类型
using TThostFtdcOrganTypeType = System.String;
///TFtdcOrganLevelType是一个机构级别类型
using TThostFtdcOrganLevelType = System.String;
///TFtdcProtocalIDType是一个协议类型类型
using TThostFtdcProtocalIDType = System.String;
///TFtdcConnectModeType是一个套接字连接方式类型
using TThostFtdcConnectModeType = System.String;
///TFtdcSyncModeType是一个套接字通信方式类型
using TThostFtdcSyncModeType = System.String;
///TFtdcBankAccTypeType是一个银行帐号类型类型
using TThostFtdcBankAccTypeType = System.String;
///TFtdcFutureAccTypeType是一个期货公司帐号类型类型
using TThostFtdcFutureAccTypeType = System.String;
///TFtdcOrganStatusType是一个接入机构状态类型
using TThostFtdcOrganStatusType = System.String;
///TFtdcCCBFeeModeType是一个建行收费模式类型
using TThostFtdcCCBFeeModeType = System.String;
///TFtdcCommApiTypeType是一个通讯API类型类型
using TThostFtdcCommApiTypeType = System.String;
///TFtdcServiceIDType是一个服务编号类型
using TThostFtdcServiceIDType = System.Int32;
///TFtdcServiceLineNoType是一个服务线路编号类型
using TThostFtdcServiceLineNoType = System.Int32;
///TFtdcServiceNameType是一个服务名类型
using TThostFtdcServiceNameType = System.String;
///TFtdcLinkStatusType是一个连接状态类型
using TThostFtdcLinkStatusType = System.String;
///TFtdcCommApiPointerType是一个通讯API指针类型
using TThostFtdcCommApiPointerType = System.Int32;
///TFtdcPwdFlagType是一个密码核对标志类型
using TThostFtdcPwdFlagType = System.String;
///TFtdcSecuAccTypeType是一个期货帐号类型类型
using TThostFtdcSecuAccTypeType = System.String;
///TFtdcTransferStatusType是一个转账交易状态类型
using TThostFtdcTransferStatusType = System.String;
///TFtdcSponsorTypeType是一个发起方类型
using TThostFtdcSponsorTypeType = System.String;
///TFtdcReqRspTypeType是一个请求响应类别类型
using TThostFtdcReqRspTypeType = System.String;
///TFtdcFBTUserEventTypeType是一个银期转帐用户事件类型类型
using TThostFtdcFBTUserEventTypeType = System.String;
///TFtdcBankIDByBankType是一个银行自己的编码类型
using TThostFtdcBankIDByBankType = System.String;
///TFtdcBankOperNoType是一个银行操作员号类型
using TThostFtdcBankOperNoType = System.String;
///TFtdcBankCustNoType是一个银行客户号类型
using TThostFtdcBankCustNoType = System.String;
///TFtdcDBOPSeqNoType是一个递增的序列号类型
using TThostFtdcDBOPSeqNoType = System.Int32;
///TFtdcTableNameType是一个FBT表名类型
using TThostFtdcTableNameType = System.String;
///TFtdcPKNameType是一个FBT表操作主键名类型
using TThostFtdcPKNameType = System.String;
///TFtdcPKValueType是一个FBT表操作主键值类型
using TThostFtdcPKValueType = System.String;
///TFtdcDBOperationType是一个记录操作类型类型
using TThostFtdcDBOperationType = System.String;
///TFtdcSyncFlagType是一个同步标记类型
using TThostFtdcSyncFlagType = System.String;
///TFtdcTargetIDType是一个同步目标编号类型
using TThostFtdcTargetIDType = System.String;
///TFtdcSyncTypeType是一个同步类型类型
using TThostFtdcSyncTypeType = System.String;
///TFtdcFBETimeType是一个各种换汇时间类型
using TThostFtdcFBETimeType = System.String;
///TFtdcFBEBankNoType是一个换汇银行行号类型
using TThostFtdcFBEBankNoType = System.String;
///TFtdcFBECertNoType是一个换汇凭证号类型
using TThostFtdcFBECertNoType = System.String;
///TFtdcExDirectionType是一个换汇方向类型
using TThostFtdcExDirectionType = System.String;
///TFtdcFBEBankAccountType是一个换汇银行账户类型
using TThostFtdcFBEBankAccountType = System.String;
///TFtdcFBEBankAccountNameType是一个换汇银行账户名类型
using TThostFtdcFBEBankAccountNameType = System.String;
///TFtdcFBEAmtType是一个各种换汇金额类型
using TThostFtdcFBEAmtType = System.Double;
///TFtdcFBEBusinessTypeType是一个换汇业务类型类型
using TThostFtdcFBEBusinessTypeType = System.String;
///TFtdcFBEPostScriptType是一个换汇附言类型
using TThostFtdcFBEPostScriptType = System.String;
///TFtdcFBERemarkType是一个换汇备注类型
using TThostFtdcFBERemarkType = System.String;
///TFtdcExRateType是一个换汇汇率类型
using TThostFtdcExRateType = System.Double;
///TFtdcFBEResultFlagType是一个换汇成功标志类型
using TThostFtdcFBEResultFlagType = System.String;
///TFtdcFBERtnMsgType是一个换汇返回信息类型
using TThostFtdcFBERtnMsgType = System.String;
///TFtdcFBEExtendMsgType是一个换汇扩展信息类型
using TThostFtdcFBEExtendMsgType = System.String;
///TFtdcFBEBusinessSerialType是一个换汇记账流水号类型
using TThostFtdcFBEBusinessSerialType = System.String;
///TFtdcFBESystemSerialType是一个换汇流水号类型
using TThostFtdcFBESystemSerialType = System.String;
///TFtdcFBETotalExCntType是一个换汇交易总笔数类型
using TThostFtdcFBETotalExCntType = System.Int32;
///TFtdcFBEExchStatusType是一个换汇交易状态类型
using TThostFtdcFBEExchStatusType = System.String;
///TFtdcFBEFileFlagType是一个换汇文件标志类型
using TThostFtdcFBEFileFlagType = System.String;
///TFtdcFBEAlreadyTradeType是一个换汇已交易标志类型
using TThostFtdcFBEAlreadyTradeType = System.String;
///TFtdcFBEOpenBankType是一个换汇账户开户行类型
using TThostFtdcFBEOpenBankType = System.String;
///TFtdcFBEUserEventTypeType是一个银期换汇用户事件类型类型
using TThostFtdcFBEUserEventTypeType = System.String;
///TFtdcFBEFileNameType是一个换汇相关文件名类型
using TThostFtdcFBEFileNameType = System.String;
///TFtdcFBEBatchSerialType是一个换汇批次号类型
using TThostFtdcFBEBatchSerialType = System.String;
///TFtdcFBEReqFlagType是一个换汇发送标志类型
using TThostFtdcFBEReqFlagType = System.String;
///TFtdcNotifyClassType是一个风险通知类型类型
using TThostFtdcNotifyClassType = System.String;
///TFtdcRiskNofityInfoType是一个客户风险通知消息类型
using TThostFtdcRiskNofityInfoType = System.String;
///TFtdcForceCloseSceneIdType是一个强平场景编号类型
using TThostFtdcForceCloseSceneIdType = System.String;
///TFtdcForceCloseTypeType是一个强平单类型类型
using TThostFtdcForceCloseTypeType = System.String;
///TFtdcInstrumentIDsType是一个多个产品代码,用+分隔,如cu+zn类型
using TThostFtdcInstrumentIDsType = System.String;
///TFtdcRiskNotifyMethodType是一个风险通知途径类型
using TThostFtdcRiskNotifyMethodType = System.String;
///TFtdcRiskNotifyStatusType是一个风险通知状态类型
using TThostFtdcRiskNotifyStatusType = System.String;
///TFtdcRiskUserEventType是一个风控用户操作事件类型
using TThostFtdcRiskUserEventType = System.String;
///TFtdcParamIDType是一个参数代码类型
using TThostFtdcParamIDType = System.Int32;
///TFtdcParamNameType是一个参数名类型
using TThostFtdcParamNameType = System.String;
///TFtdcParamValueType是一个参数值类型
using TThostFtdcParamValueType = System.String;
///TFtdcConditionalOrderSortTypeType是一个条件单索引条件类型
using TThostFtdcConditionalOrderSortTypeType = System.String;
///TFtdcSendTypeType是一个报送状态类型
using TThostFtdcSendTypeType = System.String;
///TFtdcClientIDStatusType是一个交易编码状态类型
using TThostFtdcClientIDStatusType = System.String;
///TFtdcIndustryIDType是一个行业编码类型
using TThostFtdcIndustryIDType = System.String;
///TFtdcQuestionIDType是一个特有信息编号类型
using TThostFtdcQuestionIDType = System.String;
///TFtdcQuestionContentType是一个特有信息说明类型
using TThostFtdcQuestionContentType = System.String;
///TFtdcOptionIDType是一个选项编号类型
using TThostFtdcOptionIDType = System.String;
///TFtdcOptionContentType是一个选项说明类型
using TThostFtdcOptionContentType = System.String;
///TFtdcQuestionTypeType是一个特有信息类型类型
using TThostFtdcQuestionTypeType = System.String;
///TFtdcProcessIDType是一个业务流水号类型
using TThostFtdcProcessIDType = System.String;
///TFtdcSeqNoType是一个流水号类型
using TThostFtdcSeqNoType = System.Int32;
///TFtdcUOAProcessStatusType是一个流程状态类型
using TThostFtdcUOAProcessStatusType = System.String;
///TFtdcProcessTypeType是一个流程功能类型类型
using TThostFtdcProcessTypeType = System.String;
///TFtdcBusinessTypeType是一个业务类型类型
using TThostFtdcBusinessTypeType = System.String;
///TFtdcCfmmcReturnCodeType是一个监控中心返回码类型
using TThostFtdcCfmmcReturnCodeType = System.String;
///TFtdcExReturnCodeType是一个交易所返回码类型
using TThostFtdcExReturnCodeType = System.Int32;
///TFtdcClientTypeType是一个客户类型类型
using TThostFtdcClientTypeType = System.String;
///TFtdcExchangeIDTypeType是一个交易所编号类型
using TThostFtdcExchangeIDTypeType = System.String;
///TFtdcExClientIDTypeType是一个交易编码类型类型
using TThostFtdcExClientIDTypeType = System.String;
///TFtdcClientClassifyType是一个客户分类码类型
using TThostFtdcClientClassifyType = System.String;
///TFtdcUOAOrganTypeType是一个单位性质类型
using TThostFtdcUOAOrganTypeType = System.String;
///TFtdcUOACountryCodeType是一个国家代码类型
using TThostFtdcUOACountryCodeType = System.String;
///TFtdcAreaCodeType是一个区号类型
using TThostFtdcAreaCodeType = System.String;
///TFtdcFuturesIDType是一个监控中心为客户分配的代码类型
using TThostFtdcFuturesIDType = System.String;
///TFtdcCffmcDateType是一个日期类型
using TThostFtdcCffmcDateType = System.String;
///TFtdcCffmcTimeType是一个时间类型
using TThostFtdcCffmcTimeType = System.String;
///TFtdcNocIDType是一个组织机构代码类型
using TThostFtdcNocIDType = System.String;
///TFtdcUpdateFlagType是一个更新状态类型
using TThostFtdcUpdateFlagType = System.String;
///TFtdcApplyOperateIDType是一个申请动作类型
using TThostFtdcApplyOperateIDType = System.String;
///TFtdcApplyStatusIDType是一个申请状态类型
using TThostFtdcApplyStatusIDType = System.String;
///TFtdcSendMethodType是一个发送方式类型
using TThostFtdcSendMethodType = System.String;
///TFtdcEventTypeType是一个业务操作类型类型
using TThostFtdcEventTypeType = System.String;
///TFtdcEventModeType是一个操作方法类型
using TThostFtdcEventModeType = System.String;
///TFtdcUOAAutoSendType是一个统一开户申请自动发送类型
using TThostFtdcUOAAutoSendType = System.String;
///TFtdcQueryDepthType是一个查询深度类型
using TThostFtdcQueryDepthType = System.Int32;
///TFtdcDataCenterIDType是一个数据中心代码类型
using TThostFtdcDataCenterIDType = System.Int32;
///TFtdcFlowIDType是一个流程ID类型
using TThostFtdcFlowIDType = System.String;
///TFtdcCheckLevelType是一个复核级别类型
using TThostFtdcCheckLevelType = System.String;
///TFtdcCheckNoType是一个操作次数类型
using TThostFtdcCheckNoType = System.Int32;
///TFtdcCheckStatusType是一个复核级别类型
using TThostFtdcCheckStatusType = System.String;
///TFtdcUsedStatusType是一个生效状态类型
using TThostFtdcUsedStatusType = System.String;
///TFtdcRateTemplateNameType是一个模型名称类型
using TThostFtdcRateTemplateNameType = System.String;
///TFtdcPropertyStringType是一个用于查询的投资属性字段类型
using TThostFtdcPropertyStringType = System.String;
///TFtdcBankAcountOriginType是一个账户来源类型
using TThostFtdcBankAcountOriginType = System.String;
///TFtdcMonthBillTradeSumType是一个结算单月报成交汇总方式类型
using TThostFtdcMonthBillTradeSumType = System.String;
///TFtdcFBTTradeCodeEnumType是一个银期交易代码枚举类型
using TThostFtdcFBTTradeCodeEnumType = System.String;
///TFtdcRateTemplateIDType是一个模型代码类型
using TThostFtdcRateTemplateIDType = System.String;
///TFtdcRiskRateType是一个风险度类型
using TThostFtdcRiskRateType = System.String;
///TFtdcTimestampType是一个时间戳类型
using TThostFtdcTimestampType = System.Int32;
///TFtdcInvestorIDRuleNameType是一个号段规则名称类型
using TThostFtdcInvestorIDRuleNameType = System.String;
///TFtdcInvestorIDRuleExprType是一个号段规则表达式类型
using TThostFtdcInvestorIDRuleExprType = System.String;
///TFtdcLastDriftType是一个上次OTP漂移值类型
using TThostFtdcLastDriftType = System.Int32;
///TFtdcLastSuccessType是一个上次OTP成功值类型
using TThostFtdcLastSuccessType = System.Int32;
///TFtdcAuthKeyType是一个令牌密钥类型
using TThostFtdcAuthKeyType = System.String;
///TFtdcSerialNumberType是一个序列号类型
using TThostFtdcSerialNumberType = System.String;
///TFtdcOTPTypeType是一个动态令牌类型类型
using TThostFtdcOTPTypeType = System.String;
///TFtdcOTPVendorsIDType是一个动态令牌提供商类型
using TThostFtdcOTPVendorsIDType = System.String;
///TFtdcOTPVendorsNameType是一个动态令牌提供商名称类型
using TThostFtdcOTPVendorsNameType = System.String;
///TFtdcOTPStatusType是一个动态令牌状态类型
using TThostFtdcOTPStatusType = System.String;
///TFtdcBrokerUserTypeType是一个经济公司用户类型类型
using TThostFtdcBrokerUserTypeType = System.String;
///TFtdcFutureTypeType是一个期货类型类型
using TThostFtdcFutureTypeType = System.String;
///TFtdcFundEventTypeType是一个资金管理操作类型类型
using TThostFtdcFundEventTypeType = System.String;
///TFtdcAccountSourceTypeType是一个资金账户来源类型
using TThostFtdcAccountSourceTypeType = System.String;
///TFtdcCodeSourceTypeType是一个交易编码来源类型
using TThostFtdcCodeSourceTypeType = System.String;
///TFtdcUserRangeType是一个操作员范围类型
using TThostFtdcUserRangeType = System.String;
///TFtdcTimeSpanType是一个时间跨度类型
using TThostFtdcTimeSpanType = System.String;
///TFtdcImportSequenceIDType是一个动态令牌导入批次编号类型
using TThostFtdcImportSequenceIDType = System.String;
///TFtdcByGroupType是一个交易统计表按客户统计方式类型
using TThostFtdcByGroupType = System.String;
///TFtdcTradeSumStatModeType是一个交易统计表按范围统计方式类型
using TThostFtdcTradeSumStatModeType = System.String;
///TFtdcComTypeType是一个组合成交类型类型
using TThostFtdcComTypeType = System.Int32;
///TFtdcUserProductIDType是一个产品标识类型
using TThostFtdcUserProductIDType = System.String;
///TFtdcUserProductNameType是一个产品名称类型
using TThostFtdcUserProductNameType = System.String;
///TFtdcUserProductMemoType是一个产品说明类型
using TThostFtdcUserProductMemoType = System.String;
///TFtdcCSRCCancelFlagType是一个新增或变更标志类型
using TThostFtdcCSRCCancelFlagType = System.String;
///TFtdcCSRCDateType是一个日期类型
using TThostFtdcCSRCDateType = System.String;
///TFtdcCSRCInvestorNameType是一个客户名称类型
using TThostFtdcCSRCInvestorNameType = System.String;
///TFtdcCSRCOpenInvestorNameType是一个客户名称类型
using TThostFtdcCSRCOpenInvestorNameType = System.String;
///TFtdcCSRCInvestorIDType是一个客户代码类型
using TThostFtdcCSRCInvestorIDType = System.String;
///TFtdcCSRCIdentifiedCardNoType是一个证件号码类型
using TThostFtdcCSRCIdentifiedCardNoType = System.String;
///TFtdcCSRCClientIDType是一个交易编码类型
using TThostFtdcCSRCClientIDType = System.String;
///TFtdcCSRCBankFlagType是一个银行标识类型
using TThostFtdcCSRCBankFlagType = System.String;
///TFtdcCSRCBankAccountType是一个银行账户类型
using TThostFtdcCSRCBankAccountType = System.String;
///TFtdcCSRCOpenNameType是一个开户人类型
using TThostFtdcCSRCOpenNameType = System.String;
///TFtdcCSRCMemoType是一个说明类型
using TThostFtdcCSRCMemoType = System.String;
///TFtdcCSRCTimeType是一个时间类型
using TThostFtdcCSRCTimeType = System.String;
///TFtdcCSRCTradeIDType是一个成交流水号类型
using TThostFtdcCSRCTradeIDType = System.String;
///TFtdcCSRCExchangeInstIDType是一个合约代码类型
using TThostFtdcCSRCExchangeInstIDType = System.String;
///TFtdcCSRCMortgageNameType是一个质押品名称类型
using TThostFtdcCSRCMortgageNameType = System.String;
///TFtdcCSRCReasonType是一个事由类型
using TThostFtdcCSRCReasonType = System.String;
///TFtdcIsSettlementType是一个是否为非结算会员类型
using TThostFtdcIsSettlementType = System.String;
///TFtdcCSRCMoneyType是一个资金类型
using TThostFtdcCSRCMoneyType = System.Double;
///TFtdcCSRCPriceType是一个价格类型
using TThostFtdcCSRCPriceType = System.Double;
///TFtdcCSRCOptionsTypeType是一个期权类型类型
using TThostFtdcCSRCOptionsTypeType = System.String;
///TFtdcCSRCStrikePriceType是一个执行价类型
using TThostFtdcCSRCStrikePriceType = System.Double;
///TFtdcCSRCTargetProductIDType是一个标的品种类型
using TThostFtdcCSRCTargetProductIDType = System.String;
///TFtdcCSRCTargetInstrIDType是一个标的合约类型
using TThostFtdcCSRCTargetInstrIDType = System.String;
///TFtdcCommModelNameType是一个手续费率模板名称类型
using TThostFtdcCommModelNameType = System.String;
///TFtdcCommModelMemoType是一个手续费率模板备注类型
using TThostFtdcCommModelMemoType = System.String;
///TFtdcExprSetModeType是一个日期表达式设置类型类型
using TThostFtdcExprSetModeType = System.String;
///TFtdcRateInvestorRangeType是一个投资者范围类型
using TThostFtdcRateInvestorRangeType = System.String;
///TFtdcAgentBrokerIDType是一个代理经纪公司代码类型
using TThostFtdcAgentBrokerIDType = System.String;
///TFtdcDRIdentityIDType是一个交易中心代码类型
using TThostFtdcDRIdentityIDType = System.Int32;
///TFtdcDRIdentityNameType是一个交易中心名称类型
using TThostFtdcDRIdentityNameType = System.String;
///TFtdcDBLinkIDType是一个DBLink标识号类型
using TThostFtdcDBLinkIDType = System.String;
///TFtdcSyncDataStatusType是一个主次用系统数据同步状态类型
using TThostFtdcSyncDataStatusType = System.String;
///TFtdcTradeSourceType是一个成交来源类型
using TThostFtdcTradeSourceType = System.String;
///TFtdcFlexStatModeType是一个产品合约统计方式类型
using TThostFtdcFlexStatModeType = System.String;
///TFtdcByInvestorRangeType是一个投资者范围统计方式类型
using TThostFtdcByInvestorRangeType = System.String;
///TFtdcSRiskRateType是一个风险度类型
using TThostFtdcSRiskRateType = System.String;
///TFtdcSequenceNo12Type是一个序号类型
using TThostFtdcSequenceNo12Type = System.Int32;
///TFtdcPropertyInvestorRangeType是一个投资者范围类型
using TThostFtdcPropertyInvestorRangeType = System.String;
///TFtdcFileStatusType是一个文件状态类型
using TThostFtdcFileStatusType = System.String;
///TFtdcFileGenStyleType是一个文件生成方式类型
using TThostFtdcFileGenStyleType = System.String;
///TFtdcSysOperModeType是一个系统日志操作方法类型
using TThostFtdcSysOperModeType = System.String;
///TFtdcSysOperTypeType是一个系统日志操作类型类型
using TThostFtdcSysOperTypeType = System.String;
///TFtdcCSRCDataQueyTypeType是一个上报数据查询类型类型
using TThostFtdcCSRCDataQueyTypeType = System.String;
///TFtdcFreezeStatusType是一个休眠状态类型
using TThostFtdcFreezeStatusType = System.String;
///TFtdcStandardStatusType是一个规范状态类型
using TThostFtdcStandardStatusType = System.String;
///TFtdcCSRCFreezeStatusType是一个休眠状态类型
using TThostFtdcCSRCFreezeStatusType = System.String;
///TFtdcRightParamTypeType是一个配置类型类型
using TThostFtdcRightParamTypeType = System.String;
///TFtdcRightTemplateIDType是一个模板代码类型
using TThostFtdcRightTemplateIDType = System.String;
///TFtdcRightTemplateNameType是一个模板名称类型
using TThostFtdcRightTemplateNameType = System.String;
///TFtdcDataStatusType是一个反洗钱审核表数据状态类型
using TThostFtdcDataStatusType = System.String;
///TFtdcAMLCheckStatusType是一个审核状态类型
using TThostFtdcAMLCheckStatusType = System.String;
///TFtdcAmlDateTypeType是一个日期类型类型
using TThostFtdcAmlDateTypeType = System.String;
///TFtdcAmlCheckLevelType是一个审核级别类型
using TThostFtdcAmlCheckLevelType = System.String;
///TFtdcAmlCheckFlowType是一个反洗钱数据抽取审核流程类型
using TThostFtdcAmlCheckFlowType = System.String;
///TFtdcDataTypeType是一个数据类型类型
using TThostFtdcDataTypeType = System.String;
///TFtdcExportFileTypeType是一个导出文件类型类型
using TThostFtdcExportFileTypeType = System.String;
///TFtdcSettleManagerTypeType是一个结算配置类型类型
using TThostFtdcSettleManagerTypeType = System.String;
///TFtdcSettleManagerIDType是一个结算配置代码类型
using TThostFtdcSettleManagerIDType = System.String;
///TFtdcSettleManagerNameType是一个结算配置名称类型
using TThostFtdcSettleManagerNameType = System.String;
///TFtdcSettleManagerLevelType是一个结算配置等级类型
using TThostFtdcSettleManagerLevelType = System.String;
///TFtdcSettleManagerGroupType是一个模块分组类型
using TThostFtdcSettleManagerGroupType = System.String;
///TFtdcCheckResultMemoType是一个核对结果说明类型
using TThostFtdcCheckResultMemoType = System.String;
///TFtdcFunctionUrlType是一个功能链接类型
using TThostFtdcFunctionUrlType = System.String;
///TFtdcAuthInfoType是一个客户端认证信息类型
using TThostFtdcAuthInfoType = System.String;
///TFtdcAuthCodeType是一个客户端认证码类型
using TThostFtdcAuthCodeType = System.String;
///TFtdcLimitUseTypeType是一个保值额度使用类型类型
using TThostFtdcLimitUseTypeType = System.String;
///TFtdcDataResourceType是一个数据来源类型
using TThostFtdcDataResourceType = System.String;
///TFtdcMarginTypeType是一个保证金类型类型
using TThostFtdcMarginTypeType = System.String;
///TFtdcActiveTypeType是一个生效类型类型
using TThostFtdcActiveTypeType = System.String;
///TFtdcMarginRateTypeType是一个冲突保证金率类型类型
using TThostFtdcMarginRateTypeType = System.String;
///TFtdcBackUpStatusType是一个备份数据状态类型
using TThostFtdcBackUpStatusType = System.String;
///TFtdcInitSettlementType是一个结算初始化状态类型
using TThostFtdcInitSettlementType = System.String;
///TFtdcReportStatusType是一个报表数据生成状态类型
using TThostFtdcReportStatusType = System.String;
///TFtdcSaveStatusType是一个数据归档状态类型
using TThostFtdcSaveStatusType = System.String;
///TFtdcSettArchiveStatusType是一个结算确认数据归档状态类型
using TThostFtdcSettArchiveStatusType = System.String;
///TFtdcCTPTypeType是一个CTP交易系统类型类型
using TThostFtdcCTPTypeType = System.String;
///TFtdcToolIDType是一个工具代码类型
using TThostFtdcToolIDType = System.String;
///TFtdcToolNameType是一个工具名称类型
using TThostFtdcToolNameType = System.String;
///TFtdcCloseDealTypeType是一个平仓处理类型类型
using TThostFtdcCloseDealTypeType = System.String;
///TFtdcMortgageFundUseRangeType是一个货币质押资金可用范围类型
using TThostFtdcMortgageFundUseRangeType = System.String;
///TFtdcCurrencyUnitType是一个币种单位数量类型
using TThostFtdcCurrencyUnitType = System.Double;
///TFtdcExchangeRateType是一个汇率类型
using TThostFtdcExchangeRateType = System.Double;
///TFtdcSpecProductTypeType是一个特殊产品类型类型
using TThostFtdcSpecProductTypeType = System.String;
///TFtdcFundMortgageTypeType是一个货币质押类型类型
using TThostFtdcFundMortgageTypeType = System.String;
///TFtdcAccountSettlementParamIDType是一个投资者账户结算参数代码类型
using TThostFtdcAccountSettlementParamIDType = System.String;
///TFtdcCurrencyNameType是一个币种名称类型
using TThostFtdcCurrencyNameType = System.String;
///TFtdcCurrencySignType是一个币种符号类型
using TThostFtdcCurrencySignType = System.String;
///TFtdcFundMortDirectionType是一个货币质押方向类型
using TThostFtdcFundMortDirectionType = System.String;
///TFtdcBusinessClassType是一个换汇类别类型
using TThostFtdcBusinessClassType = System.String;
///TFtdcSwapSourceTypeType是一个换汇数据来源类型
using TThostFtdcSwapSourceTypeType = System.String;
///TFtdcCurrExDirectionType是一个换汇类型类型
using TThostFtdcCurrExDirectionType = System.String;
///TFtdcCurrencySwapStatusType是一个申请状态类型
using TThostFtdcCurrencySwapStatusType = System.String;
///TFtdcCurrExchCertNoType是一个凭证号类型
using TThostFtdcCurrExchCertNoType = System.String;
///TFtdcBatchSerialNoType是一个批次号类型
using TThostFtdcBatchSerialNoType = System.String;
///TFtdcReqFlagType是一个换汇发送标志类型
using TThostFtdcReqFlagType = System.String;
///TFtdcResFlagType是一个换汇返回成功标志类型
using TThostFtdcResFlagType = System.String;
///TFtdcPageControlType是一个换汇页面控制类型
using TThostFtdcPageControlType = System.String;
///TFtdcRecordCountType是一个记录数类型
using TThostFtdcRecordCountType = System.Int32;
///TFtdcCurrencySwapMemoType是一个换汇需确认信息类型
using TThostFtdcCurrencySwapMemoType = System.String;
///TFtdcExStatusType是一个修改状态类型
using TThostFtdcExStatusType = System.String;
///TFtdcClientRegionType是一个开户客户地域类型
using TThostFtdcClientRegionType = System.String;
///TFtdcWorkPlaceType是一个工作单位类型
using TThostFtdcWorkPlaceType = System.String;
///TFtdcBusinessPeriodType是一个经营期限类型
using TThostFtdcBusinessPeriodType = System.String;
///TFtdcWebSiteType是一个网址类型
using TThostFtdcWebSiteType = System.String;
///TFtdcUOAIdCardTypeType是一个统一开户证件类型类型
using TThostFtdcUOAIdCardTypeType = System.String;
///TFtdcClientModeType是一个开户模式类型
using TThostFtdcClientModeType = System.String;
///TFtdcInvestorFullNameType是一个投资者全称类型
using TThostFtdcInvestorFullNameType = System.String;
///TFtdcUOABrokerIDType是一个境外中介机构ID类型
using TThostFtdcUOABrokerIDType = System.String;
///TFtdcUOAZipCodeType是一个邮政编码类型
using TThostFtdcUOAZipCodeType = System.String;
///TFtdcUOAEMailType是一个电子邮箱类型
using TThostFtdcUOAEMailType = System.String;
///TFtdcOldCityType是一个城市类型
using TThostFtdcOldCityType = System.String;
///TFtdcCorporateIdentifiedCardNoType是一个法人代表证件号码类型
using TThostFtdcCorporateIdentifiedCardNoType = System.String;
///TFtdcHasBoardType是一个是否有董事会类型
using TThostFtdcHasBoardType = System.String;
///TFtdcStartModeType是一个启动模式类型
using TThostFtdcStartModeType = System.String;
///TFtdcTemplateTypeType是一个模型类型类型
using TThostFtdcTemplateTypeType = System.String;
///TFtdcLoginModeType是一个登录模式类型
using TThostFtdcLoginModeType = System.String;
///TFtdcPromptTypeType是一个日历提示类型类型
using TThostFtdcPromptTypeType = System.String;
///TFtdcLedgerManageIDType是一个分户管理资产编码类型
using TThostFtdcLedgerManageIDType = System.String;
///TFtdcInvestVarietyType是一个投资品种类型
using TThostFtdcInvestVarietyType = System.String;
///TFtdcBankAccountTypeType是一个账户类别类型
using TThostFtdcBankAccountTypeType = System.String;
///TFtdcLedgerManageBankType是一个开户银行类型
using TThostFtdcLedgerManageBankType = System.String;
///TFtdcCffexDepartmentNameType是一个开户营业部类型
using TThostFtdcCffexDepartmentNameType = System.String;
///TFtdcCffexDepartmentCodeType是一个营业部代码类型
using TThostFtdcCffexDepartmentCodeType = System.String;
///TFtdcHasTrusteeType是一个是否有托管人类型
using TThostFtdcHasTrusteeType = System.String;
///TFtdcCSRCMemo1Type是一个说明类型
using TThostFtdcCSRCMemo1Type = System.String;
///TFtdcAssetmgrCFullNameType是一个代理资产管理业务的期货公司全称类型
using TThostFtdcAssetmgrCFullNameType = System.String;
///TFtdcAssetmgrApprovalNOType是一个资产管理业务批文号类型
using TThostFtdcAssetmgrApprovalNOType = System.String;
///TFtdcAssetmgrMgrNameType是一个资产管理业务负责人姓名类型
using TThostFtdcAssetmgrMgrNameType = System.String;
///TFtdcAmTypeType是一个机构类型类型
using TThostFtdcAmTypeType = System.String;
///TFtdcCSRCAmTypeType是一个机构类型类型
using TThostFtdcCSRCAmTypeType = System.String;
///TFtdcCSRCFundIOTypeType是一个出入金类型类型
using TThostFtdcCSRCFundIOTypeType = System.String;
///TFtdcCusAccountTypeType是一个结算账户类型类型
using TThostFtdcCusAccountTypeType = System.String;
///TFtdcCSRCNationalType是一个国籍类型
using TThostFtdcCSRCNationalType = System.String;
///TFtdcCSRCSecAgentIDType是一个二级代理ID类型
using TThostFtdcCSRCSecAgentIDType = System.String;
///TFtdcLanguageTypeType是一个通知语言类型类型
using TThostFtdcLanguageTypeType = System.String;
///TFtdcAmAccountType是一个投资账户类型
using TThostFtdcAmAccountType = System.String;
///TFtdcAssetmgrClientTypeType是一个资产管理客户类型类型
using TThostFtdcAssetmgrClientTypeType = System.String;
///TFtdcAssetmgrTypeType是一个投资类型类型
using TThostFtdcAssetmgrTypeType = System.String;
///TFtdcUOMType是一个计量单位类型
using TThostFtdcUOMType = System.String;
///TFtdcSHFEInstLifePhaseType是一个上期所合约生命周期状态类型
using TThostFtdcSHFEInstLifePhaseType = System.String;
///TFtdcSHFEProductClassType是一个产品类型类型
using TThostFtdcSHFEProductClassType = System.String;
///TFtdcPriceDecimalType是一个价格小数位类型
using TThostFtdcPriceDecimalType = System.String;
///TFtdcInTheMoneyFlagType是一个平值期权标志类型
using TThostFtdcInTheMoneyFlagType = System.String;
///TFtdcCheckInstrTypeType是一个合约比较类型类型
using TThostFtdcCheckInstrTypeType = System.String;
///TFtdcDeliveryTypeType是一个交割类型类型
using TThostFtdcDeliveryTypeType = System.String;
///TFtdcBigMoneyType是一个资金类型
using TThostFtdcBigMoneyType = System.Double;
///TFtdcMaxMarginSideAlgorithmType是一个大额单边保证金算法类型
using TThostFtdcMaxMarginSideAlgorithmType = System.String;
///TFtdcDAClientTypeType是一个资产管理客户类型类型
using TThostFtdcDAClientTypeType = System.String;
///TFtdcCombinInstrIDType是一个套利合约代码类型
using TThostFtdcCombinInstrIDType = System.String;
///TFtdcCombinSettlePriceType是一个各腿结算价类型
using TThostFtdcCombinSettlePriceType = System.String;
///TFtdcDCEPriorityType是一个优先级类型
using TThostFtdcDCEPriorityType = System.Int32;
///TFtdcTradeGroupIDType是一个成交组号类型
using TThostFtdcTradeGroupIDType = System.Int32;
///TFtdcIsCheckPrepaType是一个是否校验开户可用资金类型
using TThostFtdcIsCheckPrepaType = System.Int32;
///TFtdcUOAAssetmgrTypeType是一个投资类型类型
using TThostFtdcUOAAssetmgrTypeType = System.String;
///TFtdcDirectionEnType是一个买卖方向类型
using TThostFtdcDirectionEnType = System.String;
///TFtdcOffsetFlagEnType是一个开平标志类型
using TThostFtdcOffsetFlagEnType = System.String;
///TFtdcHedgeFlagEnType是一个投机套保标志类型
using TThostFtdcHedgeFlagEnType = System.String;
///TFtdcFundIOTypeEnType是一个出入金类型类型
using TThostFtdcFundIOTypeEnType = System.String;
///TFtdcFundTypeEnType是一个资金类型类型
using TThostFtdcFundTypeEnType = System.String;
///TFtdcFundDirectionEnType是一个出入金方向类型
using TThostFtdcFundDirectionEnType = System.String;
///TFtdcFundMortDirectionEnType是一个货币质押方向类型
using TThostFtdcFundMortDirectionEnType = System.String;
///TFtdcSwapBusinessTypeType是一个换汇业务种类类型
using TThostFtdcSwapBusinessTypeType = System.String;
///TFtdcOptionsTypeType是一个期权类型类型
using TThostFtdcOptionsTypeType = System.String;
///TFtdcStrikeModeType是一个执行方式类型
using TThostFtdcStrikeModeType = System.String;
///TFtdcStrikeTypeType是一个执行类型类型
using TThostFtdcStrikeTypeType = System.String;
///TFtdcApplyTypeType是一个中金所期权放弃执行申请类型类型
using TThostFtdcApplyTypeType = System.String;
///TFtdcGiveUpDataSourceType是一个放弃执行申请数据来源类型
using TThostFtdcGiveUpDataSourceType = System.String;
///TFtdcExecOrderSysIDType是一个执行宣告系统编号类型
using TThostFtdcExecOrderSysIDType = System.String;
///TFtdcExecResultType是一个执行结果类型
using TThostFtdcExecResultType = System.String;
///TFtdcStrikeSequenceType是一个执行序号类型
using TThostFtdcStrikeSequenceType = System.Int32;
///TFtdcStrikeTimeType是一个执行时间类型
using TThostFtdcStrikeTimeType = System.String;
///TFtdcCombinationTypeType是一个组合类型类型
using TThostFtdcCombinationTypeType = System.String;
///TFtdcDceCombinationTypeType是一个组合类型类型
using TThostFtdcDceCombinationTypeType = System.String;
///TFtdcOptionRoyaltyPriceTypeType是一个期权权利金价格类型类型
using TThostFtdcOptionRoyaltyPriceTypeType = System.String;
///TFtdcBalanceAlgorithmType是一个权益算法类型
using TThostFtdcBalanceAlgorithmType = System.String;
///TFtdcActionTypeType是一个执行类型类型
using TThostFtdcActionTypeType = System.String;
///TFtdcForQuoteStatusType是一个询价状态类型
using TThostFtdcForQuoteStatusType = System.String;
///TFtdcValueMethodType是一个取值方式类型
using TThostFtdcValueMethodType = System.String;
///TFtdcExecOrderPositionFlagType是一个期权行权后是否保留期货头寸的标记类型
using TThostFtdcExecOrderPositionFlagType = System.String;
///TFtdcExecOrderCloseFlagType是一个期权行权后生成的头寸是否自动平仓类型
using TThostFtdcExecOrderCloseFlagType = System.String;
///TFtdcProductTypeType是一个产品类型类型
using TThostFtdcProductTypeType = System.String;
///TFtdcCZCEUploadFileNameType是一个郑商所结算文件名类型
using TThostFtdcCZCEUploadFileNameType = System.String;
///TFtdcDCEUploadFileNameType是一个大商所结算文件名类型
using TThostFtdcDCEUploadFileNameType = System.String;
///TFtdcSHFEUploadFileNameType是一个上期所结算文件名类型
using TThostFtdcSHFEUploadFileNameType = System.String;
///TFtdcCFFEXUploadFileNameType是一个中金所结算文件名类型
using TThostFtdcCFFEXUploadFileNameType = System.String;
///TFtdcCombDirectionType是一个组合指令方向类型
using TThostFtdcCombDirectionType = System.String;
///TFtdcStrikeOffsetTypeType是一个行权偏移类型类型
using TThostFtdcStrikeOffsetTypeType = System.String;
///TFtdcReserveOpenAccStasType是一个预约开户状态类型
using TThostFtdcReserveOpenAccStasType = System.String;
///TFtdcLoginRemarkType是一个登录备注类型
using TThostFtdcLoginRemarkType = System.String;
///TFtdcInvestUnitIDType是一个投资单元代码类型
using TThostFtdcInvestUnitIDType = System.String;
///TFtdcBulletinIDType是一个公告编号类型
using TThostFtdcBulletinIDType = System.Int32;
///TFtdcNewsTypeType是一个公告类型类型
using TThostFtdcNewsTypeType = System.String;
///TFtdcNewsUrgencyType是一个紧急程度类型
using TThostFtdcNewsUrgencyType = System.Char;
///TFtdcAbstractType是一个消息摘要类型
using TThostFtdcAbstractType = System.String;
///TFtdcComeFromType是一个消息来源类型
using TThostFtdcComeFromType = System.String;
///TFtdcURLLinkType是一个WEB地址类型
using TThostFtdcURLLinkType = System.String;
///TFtdcLongIndividualNameType是一个长个人姓名类型
using TThostFtdcLongIndividualNameType = System.String;
///TFtdcLongFBEBankAccountNameType是一个长换汇银行账户名类型
using TThostFtdcLongFBEBankAccountNameType = System.String;
///TFtdcDateTimeType是一个日期时间类型
using TThostFtdcDateTimeType = System.String;
///TFtdcWeakPasswordSourceType是一个弱密码来源类型
using TThostFtdcWeakPasswordSourceType = System.String;
///TFtdcRandomStringType是一个随机串类型
using TThostFtdcRandomStringType = System.String;
///TFtdcOptSelfCloseFlagType是一个期权行权的头寸是否自对冲类型
using TThostFtdcOptSelfCloseFlagType = System.String;
///TFtdcBizTypeType是一个业务类型类型
using TThostFtdcBizTypeType = System.String;
///TFtdcAppTypeType是一个用户App类型类型
using TThostFtdcAppTypeType = System.String;
///TFtdcAppIDType是一个App代码类型
using TThostFtdcAppIDType = System.String;
///TFtdcSystemInfoLenType是一个系统信息长度类型
using TThostFtdcSystemInfoLenType = System.Int32;
///TFtdcAdditionalInfoLenType是一个补充信息长度类型
using TThostFtdcAdditionalInfoLenType = System.Int32;
///TFtdcClientSystemInfoType是一个交易终端系统信息类型
using TThostFtdcClientSystemInfoType = System.String;
///TFtdcAdditionalInfoType是一个系统外部信息类型
using TThostFtdcAdditionalInfoType = System.String;
///TFtdcBase64ClientSystemInfoType是一个base64交易终端系统信息类型
using TThostFtdcBase64ClientSystemInfoType = System.String;
///TFtdcBase64AdditionalInfoType是一个base64系统外部信息类型
using TThostFtdcBase64AdditionalInfoType = System.String;
///TFtdcCurrentAuthMethodType是一个当前可用的认证模式，0代表无需认证模式 A从低位开始最后一位代表图片验证码，倒数第二位代表动态口令，倒数第三位代表短信验证码类型
using TThostFtdcCurrentAuthMethodType = System.Int32;
///TFtdcCaptchaInfoLenType是一个图片验证信息长度类型
using TThostFtdcCaptchaInfoLenType = System.Int32;
///TFtdcCaptchaInfoType是一个图片验证信息类型
using TThostFtdcCaptchaInfoType = System.String;
///TFtdcUserTextSeqType是一个用户短信验证码的编号类型
using TThostFtdcUserTextSeqType = System.Int32;
///TFtdcHandshakeDataType是一个握手数据内容类型
using TThostFtdcHandshakeDataType = System.String;
///TFtdcHandshakeDataLenType是一个握手数据内容长度类型
using TThostFtdcHandshakeDataLenType = System.Int32;
///TFtdcCryptoKeyVersionType是一个api与front通信密钥版本号类型
using TThostFtdcCryptoKeyVersionType = System.String;
///TFtdcRsaKeyVersionType是一个公钥版本号类型
using TThostFtdcRsaKeyVersionType = System.Int32;
///TFtdcSoftwareProviderIDType是一个交易软件商ID类型
using TThostFtdcSoftwareProviderIDType = System.String;
///TFtdcCollectTimeType是一个信息采集时间类型
using TThostFtdcCollectTimeType = System.String;
///TFtdcQueryFreqType是一个查询频率类型
using TThostFtdcQueryFreqType = System.Int32;
///TFtdcResponseValueType是一个应答类型类型
using TThostFtdcResponseValueType = System.String;
///TFtdcOTCTradeTypeType是一个OTC成交类型类型
using TThostFtdcOTCTradeTypeType = System.String;
///TFtdcMatchTypeType是一个期现风险匹配方式类型
using TThostFtdcMatchTypeType = System.String;
///TFtdcOTCTraderIDType是一个OTC交易员代码类型
using TThostFtdcOTCTraderIDType = System.String;
///TFtdcRiskValueType是一个期货风险值类型
using TThostFtdcRiskValueType = System.Double;
///TFtdcIDBNameType是一个握手数据内容类型
using TThostFtdcIDBNameType = System.String;
///TFtdcDiscountRatioType是一个折扣率类型
using TThostFtdcDiscountRatioType = System.Double;
///TFtdcAuthTypeType是一个用户终端认证方式类型
using TThostFtdcAuthTypeType = System.String;
///TFtdcClassTypeType是一个合约分类方式类型
using TThostFtdcClassTypeType = System.String;
///TFtdcTradingTypeType是一个合约交易状态分类方式类型
using TThostFtdcTradingTypeType = System.String;
///TFtdcProductStatusType是一个产品状态类型
using TThostFtdcProductStatusType = System.String;
///TFtdcSyncDeltaStatusType是一个追平状态类型
using TThostFtdcSyncDeltaStatusType = System.String;
///TFtdcActionDirectionType是一个操作标志类型
using TThostFtdcActionDirectionType = System.String;
///TFtdcOrderCancelAlgType是一个撤单时选择席位算法类型
using TThostFtdcOrderCancelAlgType = System.String;
///TFtdcSyncDescriptionType是一个追平描述类型
using TThostFtdcSyncDescriptionType = System.String;
///TFtdcCommonIntType是一个通用int类型类型
using TThostFtdcCommonIntType = System.Int32;
///TFtdcSysVersionType是一个系统版本类型
using TThostFtdcSysVersionType = System.String;
///TFtdcOpenLimitControlLevelType是一个开仓量限制粒度类型
using TThostFtdcOpenLimitControlLevelType = System.String;
///TFtdcOrderFreqControlLevelType是一个报单频率控制粒度类型
using TThostFtdcOrderFreqControlLevelType = System.String;
///TFtdcEnumBoolType是一个枚举bool类型类型
using TThostFtdcEnumBoolType = System.String;
#endregion


namespace Bridge.CTP
{
	#region Enums
    
    enum THOST_TE_RESUME_TYPE 
    {
        THOST_TERT_RESTART = 0,
        THOST_TERT_RESUME,
        THOST_TERT_QUICK,
        THOST_TERT_NONE
    }; 
	public enum TThostFtdcExchangePropertyType:byte
	{

		///正常
		THOST_FTDC_EXP_Normal = (byte)('0'),
		///根据成交生成报单
		THOST_FTDC_EXP_GenOrderByTrade = (byte)('1'),

	};

	public enum TThostFtdcIdCardTypeType:byte
	{

		///组织机构代码
		THOST_FTDC_ICT_EID = (byte)('0'),
		///中国公民身份证
		THOST_FTDC_ICT_IDCard = (byte)('1'),
		///军官证
		THOST_FTDC_ICT_OfficerIDCard = (byte)('2'),
		///警官证
		THOST_FTDC_ICT_PoliceIDCard = (byte)('3'),
		///士兵证
		THOST_FTDC_ICT_SoldierIDCard = (byte)('4'),
		///护照
		THOST_FTDC_ICT_Passport = (byte)('6'),
		///回乡证
		THOST_FTDC_ICT_HomeComingCard = (byte)('8'),
		///营业执照号
		THOST_FTDC_ICT_LicenseNo = (byte)('9'),
		///税务登记号/当地纳税ID
		THOST_FTDC_ICT_TaxNo = (byte)('A'),
		///台湾居民来往大陆通行证
		THOST_FTDC_ICT_TwMainlandTravelPermit = (byte)('C'),
		///驾照
		THOST_FTDC_ICT_DrivingLicense = (byte)('D'),
		///当地社保ID
		THOST_FTDC_ICT_SocialID = (byte)('F'),
		///当地身份证
		THOST_FTDC_ICT_LocalID = (byte)('G'),
		///港澳永久性居民身份证
		THOST_FTDC_ICT_HKMCIDCard = (byte)('I'),
		///人行开户许可证
		THOST_FTDC_ICT_AccountsPermits = (byte)('J'),
		///外国人永久居留证
		THOST_FTDC_ICT_FrgPrmtRdCard = (byte)('K'),
		///资管产品备案函
		THOST_FTDC_ICT_CptMngPrdLetter = (byte)('L'),
		///港澳台居民居住证
		THOST_FTDC_ICT_HKMCTwResidencePermit = (byte)('M'),
		///统一社会信用代码
		THOST_FTDC_ICT_UniformSocialCreditCode = (byte)('N'),
		///机构成立证明文件
		THOST_FTDC_ICT_CorporationCertNo = (byte)('O'),
		///其他证件
		THOST_FTDC_ICT_OtherCard = (byte)('x'),

	};

	public enum TThostFtdcInvestorRangeType:byte
	{

		///所有
		THOST_FTDC_IR_All = (byte)('1'),
		///投资者组
		THOST_FTDC_IR_Group = (byte)('2'),
		///单一投资者
		THOST_FTDC_IR_Single = (byte)('3'),

	};

	public enum TThostFtdcDepartmentRangeType:byte
	{

		///所有
		THOST_FTDC_DR_All = (byte)('1'),
		///组织架构
		THOST_FTDC_DR_Group = (byte)('2'),
		///单一投资者
		THOST_FTDC_DR_Single = (byte)('3'),

	};

	public enum TThostFtdcDataSyncStatusType:byte
	{

		///未同步
		THOST_FTDC_DS_Asynchronous = (byte)('1'),
		///同步中
		THOST_FTDC_DS_Synchronizing = (byte)('2'),
		///已同步
		THOST_FTDC_DS_Synchronized = (byte)('3'),

	};

	public enum TThostFtdcBrokerDataSyncStatusType:byte
	{

		///已同步
		THOST_FTDC_BDS_Synchronized = (byte)('1'),
		///同步中
		THOST_FTDC_BDS_Synchronizing = (byte)('2'),

	};

	public enum TThostFtdcExchangeConnectStatusType:byte
	{

		///没有任何连接
		THOST_FTDC_ECS_NoConnection = (byte)('1'),
		///已经发出合约查询请求
		THOST_FTDC_ECS_QryInstrumentSent = (byte)('2'),
		///已经获取信息
		THOST_FTDC_ECS_GotInformation = (byte)('9'),

	};

	public enum TThostFtdcTraderConnectStatusType:byte
	{

		///没有任何连接
		THOST_FTDC_TCS_NotConnected = (byte)('1'),
		///已经连接
		THOST_FTDC_TCS_Connected = (byte)('2'),
		///已经发出合约查询请求
		THOST_FTDC_TCS_QryInstrumentSent = (byte)('3'),
		///订阅私有流
		THOST_FTDC_TCS_SubPrivateFlow = (byte)('4'),

	};

	public enum TThostFtdcFunctionCodeType:byte
	{

		///数据异步化
		THOST_FTDC_FC_DataAsync = (byte)('1'),
		///强制用户登出
		THOST_FTDC_FC_ForceUserLogout = (byte)('2'),
		///变更管理用户口令
		THOST_FTDC_FC_UserPasswordUpdate = (byte)('3'),
		///变更经纪公司口令
		THOST_FTDC_FC_BrokerPasswordUpdate = (byte)('4'),
		///变更投资者口令
		THOST_FTDC_FC_InvestorPasswordUpdate = (byte)('5'),
		///报单插入
		THOST_FTDC_FC_OrderInsert = (byte)('6'),
		///报单操作
		THOST_FTDC_FC_OrderAction = (byte)('7'),
		///同步系统数据
		THOST_FTDC_FC_SyncSystemData = (byte)('8'),
		///同步经纪公司数据
		THOST_FTDC_FC_SyncBrokerData = (byte)('9'),
		///批量同步经纪公司数据
		THOST_FTDC_FC_BachSyncBrokerData = (byte)('A'),
		///超级查询
		THOST_FTDC_FC_SuperQuery = (byte)('B'),
		///预埋报单插入
		THOST_FTDC_FC_ParkedOrderInsert = (byte)('C'),
		///预埋报单操作
		THOST_FTDC_FC_ParkedOrderAction = (byte)('D'),
		///同步动态令牌
		THOST_FTDC_FC_SyncOTP = (byte)('E'),
		///删除未知单
		THOST_FTDC_FC_DeleteOrder = (byte)('F'),

	};

	public enum TThostFtdcBrokerFunctionCodeType:byte
	{

		///强制用户登出
		THOST_FTDC_BFC_ForceUserLogout = (byte)('1'),
		///变更用户口令
		THOST_FTDC_BFC_UserPasswordUpdate = (byte)('2'),
		///同步经纪公司数据
		THOST_FTDC_BFC_SyncBrokerData = (byte)('3'),
		///批量同步经纪公司数据
		THOST_FTDC_BFC_BachSyncBrokerData = (byte)('4'),
		///报单插入
		THOST_FTDC_BFC_OrderInsert = (byte)('5'),
		///报单操作
		THOST_FTDC_BFC_OrderAction = (byte)('6'),
		///全部查询
		THOST_FTDC_BFC_AllQuery = (byte)('7'),
		///系统功能：登入/登出/修改密码等
		THOST_FTDC_BFC_log = (byte)('a'),
		///基本查询：查询基础数据，如合约，交易所等常量
		THOST_FTDC_BFC_BaseQry = (byte)('b'),
		///交易查询：如查成交，委托
		THOST_FTDC_BFC_TradeQry = (byte)('c'),
		///交易功能：报单，撤单
		THOST_FTDC_BFC_Trade = (byte)('d'),
		///银期转账
		THOST_FTDC_BFC_Virement = (byte)('e'),
		///风险监控
		THOST_FTDC_BFC_Risk = (byte)('f'),
		///查询/管理：查询会话，踢人等
		THOST_FTDC_BFC_Session = (byte)('g'),
		///风控通知控制
		THOST_FTDC_BFC_RiskNoticeCtl = (byte)('h'),
		///风控通知发送
		THOST_FTDC_BFC_RiskNotice = (byte)('i'),
		///察看经纪公司资金权限
		THOST_FTDC_BFC_BrokerDeposit = (byte)('j'),
		///资金查询
		THOST_FTDC_BFC_QueryFund = (byte)('k'),
		///报单查询
		THOST_FTDC_BFC_QueryOrder = (byte)('l'),
		///成交查询
		THOST_FTDC_BFC_QueryTrade = (byte)('m'),
		///持仓查询
		THOST_FTDC_BFC_QueryPosition = (byte)('n'),
		///行情查询
		THOST_FTDC_BFC_QueryMarketData = (byte)('o'),
		///用户事件查询
		THOST_FTDC_BFC_QueryUserEvent = (byte)('p'),
		///风险通知查询
		THOST_FTDC_BFC_QueryRiskNotify = (byte)('q'),
		///出入金查询
		THOST_FTDC_BFC_QueryFundChange = (byte)('r'),
		///投资者信息查询
		THOST_FTDC_BFC_QueryInvestor = (byte)('s'),
		///交易编码查询
		THOST_FTDC_BFC_QueryTradingCode = (byte)('t'),
		///强平
		THOST_FTDC_BFC_ForceClose = (byte)('u'),
		///压力测试
		THOST_FTDC_BFC_PressTest = (byte)('v'),
		///权益反算
		THOST_FTDC_BFC_RemainCalc = (byte)('w'),
		///净持仓保证金指标
		THOST_FTDC_BFC_NetPositionInd = (byte)('x'),
		///风险预算
		THOST_FTDC_BFC_RiskPredict = (byte)('y'),
		///数据导出
		THOST_FTDC_BFC_DataExport = (byte)('z'),
		///风控指标设置
		THOST_FTDC_BFC_RiskTargetSetup = (byte)('A'),
		///行情预警
		THOST_FTDC_BFC_MarketDataWarn = (byte)('B'),
		///业务通知查询
		THOST_FTDC_BFC_QryBizNotice = (byte)('C'),
		///业务通知模板设置
		THOST_FTDC_BFC_CfgBizNotice = (byte)('D'),
		///同步动态令牌
		THOST_FTDC_BFC_SyncOTP = (byte)('E'),
		///发送业务通知
		THOST_FTDC_BFC_SendBizNotice = (byte)('F'),
		///风险级别标准设置
		THOST_FTDC_BFC_CfgRiskLevelStd = (byte)('G'),
		///交易终端应急功能
		THOST_FTDC_BFC_TbCommand = (byte)('H'),
		///删除未知单
		THOST_FTDC_BFC_DeleteOrder = (byte)('J'),
		///预埋报单插入
		THOST_FTDC_BFC_ParkedOrderInsert = (byte)('K'),
		///预埋报单操作
		THOST_FTDC_BFC_ParkedOrderAction = (byte)('L'),
		///资金不够仍允许行权
		THOST_FTDC_BFC_ExecOrderNoCheck = (byte)('M'),
		///指定
		THOST_FTDC_BFC_Designate = (byte)('N'),
		///证券处置
		THOST_FTDC_BFC_StockDisposal = (byte)('O'),
		///席位资金预警
		THOST_FTDC_BFC_BrokerDepositWarn = (byte)('Q'),
		///备兑不足预警
		THOST_FTDC_BFC_CoverWarn = (byte)('S'),
		///行权试算
		THOST_FTDC_BFC_PreExecOrder = (byte)('T'),
		///行权交收风险
		THOST_FTDC_BFC_ExecOrderRisk = (byte)('P'),
		///持仓限额预警
		THOST_FTDC_BFC_PosiLimitWarn = (byte)('U'),
		///持仓限额查询
		THOST_FTDC_BFC_QryPosiLimit = (byte)('V'),
		///银期签到签退
		THOST_FTDC_BFC_FBSign = (byte)('W'),
		///银期签约解约
		THOST_FTDC_BFC_FBAccount = (byte)('X'),

	};

	public enum TThostFtdcOrderActionStatusType:byte
	{

		///已经提交
		THOST_FTDC_OAS_Submitted = (byte)('a'),
		///已经接受
		THOST_FTDC_OAS_Accepted = (byte)('b'),
		///已经被拒绝
		THOST_FTDC_OAS_Rejected = (byte)('c'),

	};

	public enum TThostFtdcOrderStatusType:byte
	{

		///全部成交
		THOST_FTDC_OST_AllTraded = (byte)('0'),
		///部分成交还在队列中
		THOST_FTDC_OST_PartTradedQueueing = (byte)('1'),
		///部分成交不在队列中
		THOST_FTDC_OST_PartTradedNotQueueing = (byte)('2'),
		///未成交还在队列中
		THOST_FTDC_OST_NoTradeQueueing = (byte)('3'),
		///未成交不在队列中
		THOST_FTDC_OST_NoTradeNotQueueing = (byte)('4'),
		///撤单
		THOST_FTDC_OST_Canceled = (byte)('5'),
		///未知
		THOST_FTDC_OST_Unknown = (byte)('a'),
		///尚未触发
		THOST_FTDC_OST_NotTouched = (byte)('b'),
		///已触发
		THOST_FTDC_OST_Touched = (byte)('c'),

	};

	public enum TThostFtdcOrderSubmitStatusType:byte
	{

		///已经提交
		THOST_FTDC_OSS_InsertSubmitted = (byte)('0'),
		///撤单已经提交
		THOST_FTDC_OSS_CancelSubmitted = (byte)('1'),
		///修改已经提交
		THOST_FTDC_OSS_ModifySubmitted = (byte)('2'),
		///已经接受
		THOST_FTDC_OSS_Accepted = (byte)('3'),
		///报单已经被拒绝
		THOST_FTDC_OSS_InsertRejected = (byte)('4'),
		///撤单已经被拒绝
		THOST_FTDC_OSS_CancelRejected = (byte)('5'),
		///改单已经被拒绝
		THOST_FTDC_OSS_ModifyRejected = (byte)('6'),

	};

	public enum TThostFtdcPositionDateType:byte
	{

		///今日持仓
		THOST_FTDC_PSD_Today = (byte)('1'),
		///历史持仓
		THOST_FTDC_PSD_History = (byte)('2'),

	};

	public enum TThostFtdcPositionDateTypeType:byte
	{

		///使用历史持仓
		THOST_FTDC_PDT_UseHistory = (byte)('1'),
		///不使用历史持仓
		THOST_FTDC_PDT_NoUseHistory = (byte)('2'),

	};

	public enum TThostFtdcTradingRoleType:byte
	{

		///代理
		THOST_FTDC_ER_Broker = (byte)('1'),
		///自营
		THOST_FTDC_ER_Host = (byte)('2'),
		///做市商
		THOST_FTDC_ER_Maker = (byte)('3'),

	};

	public enum TThostFtdcProductClassType:byte
	{

		///期货
		THOST_FTDC_PC_Futures = (byte)('1'),
		///期货期权
		THOST_FTDC_PC_Options = (byte)('2'),
		///组合
		THOST_FTDC_PC_Combination = (byte)('3'),
		///即期
		THOST_FTDC_PC_Spot = (byte)('4'),
		///期转现
		THOST_FTDC_PC_EFP = (byte)('5'),
		///现货期权
		THOST_FTDC_PC_SpotOption = (byte)('6'),
		///TAS合约
		THOST_FTDC_PC_TAS = (byte)('7'),
		///金属指数
		THOST_FTDC_PC_MI = (byte)('I'),

	};

	public enum TThostFtdcAPIProductClassType:byte
	{

		///期货单一合约
		THOST_FTDC_APC_FutureSingle = (byte)('1'),
		///期权单一合约
		THOST_FTDC_APC_OptionSingle = (byte)('2'),
		///可交易期货(含期货组合和期货单一合约)
		THOST_FTDC_APC_Futures = (byte)('3'),
		///可交易期权(含期权组合和期权单一合约)
		THOST_FTDC_APC_Options = (byte)('4'),
		///可下单组合（目前包含DCE和ZCE的期货组合）
		THOST_FTDC_APC_TradingComb = (byte)('5'),
		///可申请的组合（dce可以申请的组合合约 包含dce可以交易的合约）
		THOST_FTDC_APC_UnTradingComb = (byte)('6'),
		///所有可以交易合约
		THOST_FTDC_APC_AllTrading = (byte)('7'),
		///所有合约（包含不能交易合约 慎用）
		THOST_FTDC_APC_All = (byte)('8'),

	};

	public enum TThostFtdcInstLifePhaseType:byte
	{

		///未上市
		THOST_FTDC_IP_NotStart = (byte)('0'),
		///上市
		THOST_FTDC_IP_Started = (byte)('1'),
		///停牌
		THOST_FTDC_IP_Pause = (byte)('2'),
		///到期
		THOST_FTDC_IP_Expired = (byte)('3'),

	};

	public enum TThostFtdcDirectionType:byte
	{

		///买
		THOST_FTDC_D_Buy = (byte)('0'),
		///卖
		THOST_FTDC_D_Sell = (byte)('1'),

	};

	public enum TThostFtdcPositionTypeType:byte
	{

		///净持仓
		THOST_FTDC_PT_Net = (byte)('1'),
		///综合持仓
		THOST_FTDC_PT_Gross = (byte)('2'),

	};

	public enum TThostFtdcPosiDirectionType:byte
	{

		///净
		THOST_FTDC_PD_Net = (byte)('1'),
		///多头
		THOST_FTDC_PD_Long = (byte)('2'),
		///空头
		THOST_FTDC_PD_Short = (byte)('3'),

	};

	public enum TThostFtdcSysSettlementStatusType:byte
	{

		///不活跃
		THOST_FTDC_SS_NonActive = (byte)('1'),
		///启动
		THOST_FTDC_SS_Startup = (byte)('2'),
		///操作
		THOST_FTDC_SS_Operating = (byte)('3'),
		///结算
		THOST_FTDC_SS_Settlement = (byte)('4'),
		///结算完成
		THOST_FTDC_SS_SettlementFinished = (byte)('5'),

	};

	public enum TThostFtdcRatioAttrType:byte
	{

		///交易费率
		THOST_FTDC_RA_Trade = (byte)('0'),
		///结算费率
		THOST_FTDC_RA_Settlement = (byte)('1'),

	};

	public enum TThostFtdcHedgeFlagType:byte
	{

		///投机
		THOST_FTDC_HF_Speculation = (byte)('1'),
		///套利
		THOST_FTDC_HF_Arbitrage = (byte)('2'),
		///套保
		THOST_FTDC_HF_Hedge = (byte)('3'),
		///做市商
		THOST_FTDC_HF_MarketMaker = (byte)('5'),
		///第一腿投机第二腿套保 大商所专用
		THOST_FTDC_HF_SpecHedge = (byte)('6'),
		///第一腿套保第二腿投机  大商所专用
		THOST_FTDC_HF_HedgeSpec = (byte)('7'),

	};

	public enum TThostFtdcBillHedgeFlagType:byte
	{

		///投机
		THOST_FTDC_BHF_Speculation = (byte)('1'),
		///套利
		THOST_FTDC_BHF_Arbitrage = (byte)('2'),
		///套保
		THOST_FTDC_BHF_Hedge = (byte)('3'),

	};

	public enum TThostFtdcClientIDTypeType:byte
	{

		///投机
		THOST_FTDC_CIDT_Speculation = (byte)('1'),
		///套利
		THOST_FTDC_CIDT_Arbitrage = (byte)('2'),
		///套保
		THOST_FTDC_CIDT_Hedge = (byte)('3'),
		///做市商
		THOST_FTDC_CIDT_MarketMaker = (byte)('5'),

	};

	public enum TThostFtdcOrderPriceTypeType:byte
	{

		///任意价
		THOST_FTDC_OPT_AnyPrice = (byte)('1'),
		///限价
		THOST_FTDC_OPT_LimitPrice = (byte)('2'),
		///最优价
		THOST_FTDC_OPT_BestPrice = (byte)('3'),
		///最新价
		THOST_FTDC_OPT_LastPrice = (byte)('4'),
		///最新价浮动上浮1个ticks
		THOST_FTDC_OPT_LastPricePlusOneTicks = (byte)('5'),
		///最新价浮动上浮2个ticks
		THOST_FTDC_OPT_LastPricePlusTwoTicks = (byte)('6'),
		///最新价浮动上浮3个ticks
		THOST_FTDC_OPT_LastPricePlusThreeTicks = (byte)('7'),
		///卖一价
		THOST_FTDC_OPT_AskPrice1 = (byte)('8'),
		///卖一价浮动上浮1个ticks
		THOST_FTDC_OPT_AskPrice1PlusOneTicks = (byte)('9'),
		///卖一价浮动上浮2个ticks
		THOST_FTDC_OPT_AskPrice1PlusTwoTicks = (byte)('A'),
		///卖一价浮动上浮3个ticks
		THOST_FTDC_OPT_AskPrice1PlusThreeTicks = (byte)('B'),
		///买一价
		THOST_FTDC_OPT_BidPrice1 = (byte)('C'),
		///买一价浮动上浮1个ticks
		THOST_FTDC_OPT_BidPrice1PlusOneTicks = (byte)('D'),
		///买一价浮动上浮2个ticks
		THOST_FTDC_OPT_BidPrice1PlusTwoTicks = (byte)('E'),
		///买一价浮动上浮3个ticks
		THOST_FTDC_OPT_BidPrice1PlusThreeTicks = (byte)('F'),
		///五档价
		THOST_FTDC_OPT_FiveLevelPrice = (byte)('G'),

	};

	public enum TThostFtdcOffsetFlagType:byte
	{

		///开仓
		THOST_FTDC_OF_Open = (byte)('0'),
		///平仓
		THOST_FTDC_OF_Close = (byte)('1'),
		///强平
		THOST_FTDC_OF_ForceClose = (byte)('2'),
		///平今
		THOST_FTDC_OF_CloseToday = (byte)('3'),
		///平昨
		THOST_FTDC_OF_CloseYesterday = (byte)('4'),
		///强减
		THOST_FTDC_OF_ForceOff = (byte)('5'),
		///本地强平
		THOST_FTDC_OF_LocalForceClose = (byte)('6'),

	};

	public enum TThostFtdcForceCloseReasonType:byte
	{

		///非强平
		THOST_FTDC_FCC_NotForceClose = (byte)('0'),
		///资金不足
		THOST_FTDC_FCC_LackDeposit = (byte)('1'),
		///客户超仓
		THOST_FTDC_FCC_ClientOverPositionLimit = (byte)('2'),
		///会员超仓
		THOST_FTDC_FCC_MemberOverPositionLimit = (byte)('3'),
		///持仓非整数倍
		THOST_FTDC_FCC_NotMultiple = (byte)('4'),
		///违规
		THOST_FTDC_FCC_Violation = (byte)('5'),
		///其它
		THOST_FTDC_FCC_Other = (byte)('6'),
		///自然人临近交割
		THOST_FTDC_FCC_PersonDeliv = (byte)('7'),
		///风控强平不验证资金
		THOST_FTDC_FCC_Notverifycapital = (byte)('8'),

	};

	public enum TThostFtdcOrderTypeType:byte
	{

		///正常
		THOST_FTDC_ORDT_Normal = (byte)('0'),
		///报价衍生
		THOST_FTDC_ORDT_DeriveFromQuote = (byte)('1'),
		///组合衍生
		THOST_FTDC_ORDT_DeriveFromCombination = (byte)('2'),
		///组合报单
		THOST_FTDC_ORDT_Combination = (byte)('3'),
		///条件单
		THOST_FTDC_ORDT_ConditionalOrder = (byte)('4'),
		///互换单
		THOST_FTDC_ORDT_Swap = (byte)('5'),
		///大宗交易成交衍生
		THOST_FTDC_ORDT_DeriveFromBlockTrade = (byte)('6'),
		///期转现成交衍生
		THOST_FTDC_ORDT_DeriveFromEFPTrade = (byte)('7'),

	};

	public enum TThostFtdcTimeConditionType:byte
	{

		///立即完成，否则撤销
		THOST_FTDC_TC_IOC = (byte)('1'),
		///本节有效
		THOST_FTDC_TC_GFS = (byte)('2'),
		///当日有效
		THOST_FTDC_TC_GFD = (byte)('3'),
		///指定日期前有效
		THOST_FTDC_TC_GTD = (byte)('4'),
		///撤销前有效
		THOST_FTDC_TC_GTC = (byte)('5'),
		///集合竞价有效
		THOST_FTDC_TC_GFA = (byte)('6'),

	};

	public enum TThostFtdcVolumeConditionType:byte
	{

		///任何数量
		THOST_FTDC_VC_AV = (byte)('1'),
		///最小数量
		THOST_FTDC_VC_MV = (byte)('2'),
		///全部数量
		THOST_FTDC_VC_CV = (byte)('3'),

	};

	public enum TThostFtdcContingentConditionType:byte
	{

		///立即
		THOST_FTDC_CC_Immediately = (byte)('1'),
		///止损
		THOST_FTDC_CC_Touch = (byte)('2'),
		///止赢
		THOST_FTDC_CC_TouchProfit = (byte)('3'),
		///预埋单
		THOST_FTDC_CC_ParkedOrder = (byte)('4'),
		///最新价大于条件价
		THOST_FTDC_CC_LastPriceGreaterThanStopPrice = (byte)('5'),
		///最新价大于等于条件价
		THOST_FTDC_CC_LastPriceGreaterEqualStopPrice = (byte)('6'),
		///最新价小于条件价
		THOST_FTDC_CC_LastPriceLesserThanStopPrice = (byte)('7'),
		///最新价小于等于条件价
		THOST_FTDC_CC_LastPriceLesserEqualStopPrice = (byte)('8'),
		///卖一价大于条件价
		THOST_FTDC_CC_AskPriceGreaterThanStopPrice = (byte)('9'),
		///卖一价大于等于条件价
		THOST_FTDC_CC_AskPriceGreaterEqualStopPrice = (byte)('A'),
		///卖一价小于条件价
		THOST_FTDC_CC_AskPriceLesserThanStopPrice = (byte)('B'),
		///卖一价小于等于条件价
		THOST_FTDC_CC_AskPriceLesserEqualStopPrice = (byte)('C'),
		///买一价大于条件价
		THOST_FTDC_CC_BidPriceGreaterThanStopPrice = (byte)('D'),
		///买一价大于等于条件价
		THOST_FTDC_CC_BidPriceGreaterEqualStopPrice = (byte)('E'),
		///买一价小于条件价
		THOST_FTDC_CC_BidPriceLesserThanStopPrice = (byte)('F'),
		///买一价小于等于条件价
		THOST_FTDC_CC_BidPriceLesserEqualStopPrice = (byte)('H'),

	};

	public enum TThostFtdcActionFlagType:byte
	{

		///删除
		THOST_FTDC_AF_Delete = (byte)('0'),
		///修改
		THOST_FTDC_AF_Modify = (byte)('3'),

	};

	public enum TThostFtdcTradingRightType:byte
	{

		///可以交易
		THOST_FTDC_TR_Allow = (byte)('0'),
		///只能平仓
		THOST_FTDC_TR_CloseOnly = (byte)('1'),
		///不能交易
		THOST_FTDC_TR_Forbidden = (byte)('2'),

	};

	public enum TThostFtdcOrderSourceType:byte
	{

		///来自参与者
		THOST_FTDC_OSRC_Participant = (byte)('0'),
		///来自管理员
		THOST_FTDC_OSRC_Administrator = (byte)('1'),

	};

	public enum TThostFtdcTradeTypeType:byte
	{

		///普通成交
		THOST_FTDC_TRDT_Common = (byte)('0'),
		///期权执行
		THOST_FTDC_TRDT_OptionsExecution = (byte)('1'),
		///OTC成交
		THOST_FTDC_TRDT_OTC = (byte)('2'),
		///期转现衍生成交
		THOST_FTDC_TRDT_EFPDerived = (byte)('3'),
		///组合衍生成交
		THOST_FTDC_TRDT_CombinationDerived = (byte)('4'),
		///大宗交易成交
		THOST_FTDC_TRDT_BlockTrade = (byte)('5'),

	};

	public enum TThostFtdcSpecPosiTypeType:byte
	{

		///TAS合约成交产生的标的合约持仓明细
		THOST_FTDC_SPOST_Tas = (byte)('0'),

	};

	public enum TThostFtdcPriceSourceType:byte
	{

		///前成交价
		THOST_FTDC_PSRC_LastPrice = (byte)('0'),
		///买委托价
		THOST_FTDC_PSRC_Buy = (byte)('1'),
		///卖委托价
		THOST_FTDC_PSRC_Sell = (byte)('2'),
		///场外成交价
		THOST_FTDC_PSRC_OTC = (byte)('3'),

	};

	public enum TThostFtdcInstrumentStatusType:byte
	{

		///开盘前
		THOST_FTDC_IS_BeforeTrading = (byte)('0'),
		///非交易
		THOST_FTDC_IS_NoTrading = (byte)('1'),
		///连续交易
		THOST_FTDC_IS_Continous = (byte)('2'),
		///集合竞价报单
		THOST_FTDC_IS_AuctionOrdering = (byte)('3'),
		///集合竞价价格平衡
		THOST_FTDC_IS_AuctionBalance = (byte)('4'),
		///集合竞价撮合
		THOST_FTDC_IS_AuctionMatch = (byte)('5'),
		///收盘
		THOST_FTDC_IS_Closed = (byte)('6'),

	};

	public enum TThostFtdcInstStatusEnterReasonType:byte
	{

		///自动切换
		THOST_FTDC_IER_Automatic = (byte)('1'),
		///手动切换
		THOST_FTDC_IER_Manual = (byte)('2'),
		///熔断
		THOST_FTDC_IER_Fuse = (byte)('3'),

	};

	public enum TThostFtdcBatchStatusType:byte
	{

		///未上传
		THOST_FTDC_BS_NoUpload = (byte)('1'),
		///已上传
		THOST_FTDC_BS_Uploaded = (byte)('2'),
		///审核失败
		THOST_FTDC_BS_Failed = (byte)('3'),

	};

	public enum TThostFtdcReturnStyleType:byte
	{

		///按所有品种
		THOST_FTDC_RS_All = (byte)('1'),
		///按品种
		THOST_FTDC_RS_ByProduct = (byte)('2'),

	};

	public enum TThostFtdcReturnPatternType:byte
	{

		///按成交手数
		THOST_FTDC_RP_ByVolume = (byte)('1'),
		///按留存手续费
		THOST_FTDC_RP_ByFeeOnHand = (byte)('2'),

	};

	public enum TThostFtdcReturnLevelType:byte
	{

		///级别1
		THOST_FTDC_RL_Level1 = (byte)('1'),
		///级别2
		THOST_FTDC_RL_Level2 = (byte)('2'),
		///级别3
		THOST_FTDC_RL_Level3 = (byte)('3'),
		///级别4
		THOST_FTDC_RL_Level4 = (byte)('4'),
		///级别5
		THOST_FTDC_RL_Level5 = (byte)('5'),
		///级别6
		THOST_FTDC_RL_Level6 = (byte)('6'),
		///级别7
		THOST_FTDC_RL_Level7 = (byte)('7'),
		///级别8
		THOST_FTDC_RL_Level8 = (byte)('8'),
		///级别9
		THOST_FTDC_RL_Level9 = (byte)('9'),

	};

	public enum TThostFtdcReturnStandardType:byte
	{

		///分阶段返还
		THOST_FTDC_RSD_ByPeriod = (byte)('1'),
		///按某一标准
		THOST_FTDC_RSD_ByStandard = (byte)('2'),

	};

	public enum TThostFtdcMortgageTypeType:byte
	{

		///质出
		THOST_FTDC_MT_Out = (byte)('0'),
		///质入
		THOST_FTDC_MT_In = (byte)('1'),

	};

	public enum TThostFtdcInvestorSettlementParamIDType:byte
	{

		///质押比例
		THOST_FTDC_ISPI_MortgageRatio = (byte)('4'),
		///保证金算法
		THOST_FTDC_ISPI_MarginWay = (byte)('5'),
		///结算单结存是否包含质押
		THOST_FTDC_ISPI_BillDeposit = (byte)('9'),

	};

	public enum TThostFtdcExchangeSettlementParamIDType:byte
	{

		///质押比例
		THOST_FTDC_ESPI_MortgageRatio = (byte)('1'),
		///分项资金导入项
		THOST_FTDC_ESPI_OtherFundItem = (byte)('2'),
		///分项资金入交易所出入金
		THOST_FTDC_ESPI_OtherFundImport = (byte)('3'),
		///中金所开户最低可用金额
		THOST_FTDC_ESPI_CFFEXMinPrepa = (byte)('6'),
		///郑商所结算方式
		THOST_FTDC_ESPI_CZCESettlementType = (byte)('7'),
		///交易所交割手续费收取方式
		THOST_FTDC_ESPI_ExchDelivFeeMode = (byte)('9'),
		///投资者交割手续费收取方式
		THOST_FTDC_ESPI_DelivFeeMode = (byte)('0'),
		///郑商所组合持仓保证金收取方式
		THOST_FTDC_ESPI_CZCEComMarginType = (byte)('A'),
		///大商所套利保证金是否优惠
		THOST_FTDC_ESPI_DceComMarginType = (byte)('B'),
		///虚值期权保证金优惠比率
		THOST_FTDC_ESPI_OptOutDisCountRate = (byte)('a'),
		///最低保障系数
		THOST_FTDC_ESPI_OptMiniGuarantee = (byte)('b'),

	};

	public enum TThostFtdcSystemParamIDType:byte
	{

		///投资者代码最小长度
		THOST_FTDC_SPI_InvestorIDMinLength = (byte)('1'),
		///投资者帐号代码最小长度
		THOST_FTDC_SPI_AccountIDMinLength = (byte)('2'),
		///投资者开户默认登录权限
		THOST_FTDC_SPI_UserRightLogon = (byte)('3'),
		///投资者交易结算单成交汇总方式
		THOST_FTDC_SPI_SettlementBillTrade = (byte)('4'),
		///统一开户更新交易编码方式
		THOST_FTDC_SPI_TradingCode = (byte)('5'),
		///结算是否判断存在未复核的出入金和分项资金
		THOST_FTDC_SPI_CheckFund = (byte)('6'),
		///是否启用手续费模板数据权限
		THOST_FTDC_SPI_CommModelRight = (byte)('7'),
		///是否启用保证金率模板数据权限
		THOST_FTDC_SPI_MarginModelRight = (byte)('9'),
		///是否规范用户才能激活
		THOST_FTDC_SPI_IsStandardActive = (byte)('8'),
		///上传的交易所结算文件路径
		THOST_FTDC_SPI_UploadSettlementFile = (byte)('U'),
		///上报保证金监控中心文件路径
		THOST_FTDC_SPI_DownloadCSRCFile = (byte)('D'),
		///生成的结算单文件路径
		THOST_FTDC_SPI_SettlementBillFile = (byte)('S'),
		///证监会文件标识
		THOST_FTDC_SPI_CSRCOthersFile = (byte)('C'),
		///投资者照片路径
		THOST_FTDC_SPI_InvestorPhoto = (byte)('P'),
		///全结经纪公司上传文件路径
		THOST_FTDC_SPI_CSRCData = (byte)('R'),
		///开户密码录入方式
		THOST_FTDC_SPI_InvestorPwdModel = (byte)('I'),
		///投资者中金所结算文件下载路径
		THOST_FTDC_SPI_CFFEXInvestorSettleFile = (byte)('F'),
		///投资者代码编码方式
		THOST_FTDC_SPI_InvestorIDType = (byte)('a'),
		///休眠户最高权益
		THOST_FTDC_SPI_FreezeMaxReMain = (byte)('r'),
		///手续费相关操作实时上场开关
		THOST_FTDC_SPI_IsSync = (byte)('A'),
		///解除开仓权限限制
		THOST_FTDC_SPI_RelieveOpenLimit = (byte)('O'),
		///是否规范用户才能休眠
		THOST_FTDC_SPI_IsStandardFreeze = (byte)('X'),
		///郑商所是否开放所有品种套保交易
		THOST_FTDC_SPI_CZCENormalProductHedge = (byte)('B'),

	};

	public enum TThostFtdcTradeParamIDType:byte
	{

		///系统加密算法
		THOST_FTDC_TPID_EncryptionStandard = (byte)('E'),
		///系统风险算法
		THOST_FTDC_TPID_RiskMode = (byte)('R'),
		///系统风险算法是否全局 0-否 1-是
		THOST_FTDC_TPID_RiskModeGlobal = (byte)('G'),
		///密码加密算法
		THOST_FTDC_TPID_modeEncode = (byte)('P'),
		///价格小数位数参数
		THOST_FTDC_TPID_tickMode = (byte)('T'),
		///用户最大会话数
		THOST_FTDC_TPID_SingleUserSessionMaxNum = (byte)('S'),
		///最大连续登录失败数
		THOST_FTDC_TPID_LoginFailMaxNum = (byte)('L'),
		///是否强制认证
		THOST_FTDC_TPID_IsAuthForce = (byte)('A'),
		///是否冻结证券持仓
		THOST_FTDC_TPID_IsPosiFreeze = (byte)('F'),
		///是否限仓
		THOST_FTDC_TPID_IsPosiLimit = (byte)('M'),
		///郑商所询价时间间隔
		THOST_FTDC_TPID_ForQuoteTimeInterval = (byte)('Q'),
		///是否期货限仓
		THOST_FTDC_TPID_IsFuturePosiLimit = (byte)('B'),
		///是否期货下单频率限制
		THOST_FTDC_TPID_IsFutureOrderFreq = (byte)('C'),
		///行权冻结是否计算盈利
		THOST_FTDC_TPID_IsExecOrderProfit = (byte)('H'),
		///银期开户是否验证开户银行卡号是否是预留银行账户
		THOST_FTDC_TPID_IsCheckBankAcc = (byte)('I'),
		///弱密码最后修改日期
		THOST_FTDC_TPID_PasswordDeadLine = (byte)('J'),
		///强密码校验
		THOST_FTDC_TPID_IsStrongPassword = (byte)('K'),
		///自有资金质押比
		THOST_FTDC_TPID_BalanceMorgage = (byte)('a'),
		///最小密码长度
		THOST_FTDC_TPID_MinPwdLen = (byte)('O'),
		///IP当日最大登陆失败次数
		THOST_FTDC_TPID_LoginFailMaxNumForIP = (byte)('U'),
		///密码有效期
		THOST_FTDC_TPID_PasswordPeriod = (byte)('V'),

	};

	public enum TThostFtdcFileIDType:byte
	{

		///资金数据
		THOST_FTDC_FI_SettlementFund = (byte)('F'),
		///成交数据
		THOST_FTDC_FI_Trade = (byte)('T'),
		///投资者持仓数据
		THOST_FTDC_FI_InvestorPosition = (byte)('P'),
		///投资者分项资金数据
		THOST_FTDC_FI_SubEntryFund = (byte)('O'),
		///组合持仓数据
		THOST_FTDC_FI_CZCECombinationPos = (byte)('C'),
		///上报保证金监控中心数据
		THOST_FTDC_FI_CSRCData = (byte)('R'),
		///郑商所平仓了结数据
		THOST_FTDC_FI_CZCEClose = (byte)('L'),
		///郑商所非平仓了结数据
		THOST_FTDC_FI_CZCENoClose = (byte)('N'),
		///持仓明细数据
		THOST_FTDC_FI_PositionDtl = (byte)('D'),
		///期权执行文件
		THOST_FTDC_FI_OptionStrike = (byte)('S'),
		///结算价比对文件
		THOST_FTDC_FI_SettlementPriceComparison = (byte)('M'),
		///上期所非持仓变动明细
		THOST_FTDC_FI_NonTradePosChange = (byte)('B'),

	};

	public enum TThostFtdcFileTypeType:byte
	{

		///结算
		THOST_FTDC_FUT_Settlement = (byte)('0'),
		///核对
		THOST_FTDC_FUT_Check = (byte)('1'),

	};

	public enum TThostFtdcFileFormatType:byte
	{

		///文本文件(.txt)
		THOST_FTDC_FFT_Txt = (byte)('0'),
		///压缩文件(.zip)
		THOST_FTDC_FFT_Zip = (byte)('1'),
		///DBF文件(.dbf)
		THOST_FTDC_FFT_DBF = (byte)('2'),

	};

	public enum TThostFtdcFileUploadStatusType:byte
	{

		///上传成功
		THOST_FTDC_FUS_SucceedUpload = (byte)('1'),
		///上传失败
		THOST_FTDC_FUS_FailedUpload = (byte)('2'),
		///导入成功
		THOST_FTDC_FUS_SucceedLoad = (byte)('3'),
		///导入部分成功
		THOST_FTDC_FUS_PartSucceedLoad = (byte)('4'),
		///导入失败
		THOST_FTDC_FUS_FailedLoad = (byte)('5'),

	};

	public enum TThostFtdcTransferDirectionType:byte
	{

		///移出
		THOST_FTDC_TD_Out = (byte)('0'),
		///移入
		THOST_FTDC_TD_In = (byte)('1'),

	};

	public enum TThostFtdcSpecialCreateRuleType:byte
	{

		///没有特殊创建规则
		THOST_FTDC_SC_NoSpecialRule = (byte)('0'),
		///不包含春节
		THOST_FTDC_SC_NoSpringFestival = (byte)('1'),

	};

	public enum TThostFtdcBasisPriceTypeType:byte
	{

		///上一合约结算价
		THOST_FTDC_IPT_LastSettlement = (byte)('1'),
		///上一合约收盘价
		THOST_FTDC_IPT_LaseClose = (byte)('2'),

	};

	public enum TThostFtdcProductLifePhaseType:byte
	{

		///活跃
		THOST_FTDC_PLP_Active = (byte)('1'),
		///不活跃
		THOST_FTDC_PLP_NonActive = (byte)('2'),
		///注销
		THOST_FTDC_PLP_Canceled = (byte)('3'),

	};

	public enum TThostFtdcDeliveryModeType:byte
	{

		///现金交割
		THOST_FTDC_DM_CashDeliv = (byte)('1'),
		///实物交割
		THOST_FTDC_DM_CommodityDeliv = (byte)('2'),

	};

	public enum TThostFtdcFundIOTypeType:byte
	{

		///出入金
		THOST_FTDC_FIOT_FundIO = (byte)('1'),
		///银期转帐
		THOST_FTDC_FIOT_Transfer = (byte)('2'),
		///银期换汇
		THOST_FTDC_FIOT_SwapCurrency = (byte)('3'),

	};

	public enum TThostFtdcFundTypeType:byte
	{

		///银行存款
		THOST_FTDC_FT_Deposite = (byte)('1'),
		///分项资金
		THOST_FTDC_FT_ItemFund = (byte)('2'),
		///公司调整
		THOST_FTDC_FT_Company = (byte)('3'),
		///资金内转
		THOST_FTDC_FT_InnerTransfer = (byte)('4'),

	};

	public enum TThostFtdcFundDirectionType:byte
	{

		///入金
		THOST_FTDC_FD_In = (byte)('1'),
		///出金
		THOST_FTDC_FD_Out = (byte)('2'),

	};

	public enum TThostFtdcFundStatusType:byte
	{

		///已录入
		THOST_FTDC_FS_Record = (byte)('1'),
		///已复核
		THOST_FTDC_FS_Check = (byte)('2'),
		///已冲销
		THOST_FTDC_FS_Charge = (byte)('3'),

	};

	public enum TThostFtdcPublishStatusType:byte
	{

		///未发布
		THOST_FTDC_PS_None = (byte)('1'),
		///正在发布
		THOST_FTDC_PS_Publishing = (byte)('2'),
		///已发布
		THOST_FTDC_PS_Published = (byte)('3'),

	};

	public enum TThostFtdcSystemStatusType:byte
	{

		///不活跃
		THOST_FTDC_ES_NonActive = (byte)('1'),
		///启动
		THOST_FTDC_ES_Startup = (byte)('2'),
		///交易开始初始化
		THOST_FTDC_ES_Initialize = (byte)('3'),
		///交易完成初始化
		THOST_FTDC_ES_Initialized = (byte)('4'),
		///收市开始
		THOST_FTDC_ES_Close = (byte)('5'),
		///收市完成
		THOST_FTDC_ES_Closed = (byte)('6'),
		///结算
		THOST_FTDC_ES_Settlement = (byte)('7'),

	};

	public enum TThostFtdcSettlementStatusType:byte
	{

		///初始
		THOST_FTDC_STS_Initialize = (byte)('0'),
		///结算中
		THOST_FTDC_STS_Settlementing = (byte)('1'),
		///已结算
		THOST_FTDC_STS_Settlemented = (byte)('2'),
		///结算完成
		THOST_FTDC_STS_Finished = (byte)('3'),

	};

	public enum TThostFtdcInvestorTypeType:byte
	{

		///自然人
		THOST_FTDC_CT_Person = (byte)('0'),
		///法人
		THOST_FTDC_CT_Company = (byte)('1'),
		///投资基金
		THOST_FTDC_CT_Fund = (byte)('2'),
		///特殊法人
		THOST_FTDC_CT_SpecialOrgan = (byte)('3'),
		///资管户
		THOST_FTDC_CT_Asset = (byte)('4'),

	};

	public enum TThostFtdcBrokerTypeType:byte
	{

		///交易会员
		THOST_FTDC_BT_Trade = (byte)('0'),
		///交易结算会员
		THOST_FTDC_BT_TradeSettle = (byte)('1'),

	};

	public enum TThostFtdcRiskLevelType:byte
	{

		///低风险客户
		THOST_FTDC_FAS_Low = (byte)('1'),
		///普通客户
		THOST_FTDC_FAS_Normal = (byte)('2'),
		///关注客户
		THOST_FTDC_FAS_Focus = (byte)('3'),
		///风险客户
		THOST_FTDC_FAS_Risk = (byte)('4'),

	};

	public enum TThostFtdcFeeAcceptStyleType:byte
	{

		///按交易收取
		THOST_FTDC_FAS_ByTrade = (byte)('1'),
		///按交割收取
		THOST_FTDC_FAS_ByDeliv = (byte)('2'),
		///不收
		THOST_FTDC_FAS_None = (byte)('3'),
		///按指定手续费收取
		THOST_FTDC_FAS_FixFee = (byte)('4'),

	};

	public enum TThostFtdcPasswordTypeType:byte
	{

		///交易密码
		THOST_FTDC_PWDT_Trade = (byte)('1'),
		///资金密码
		THOST_FTDC_PWDT_Account = (byte)('2'),

	};

	public enum TThostFtdcAlgorithmType:byte
	{

		///浮盈浮亏都计算
		THOST_FTDC_AG_All = (byte)('1'),
		///浮盈不计，浮亏计
		THOST_FTDC_AG_OnlyLost = (byte)('2'),
		///浮盈计，浮亏不计
		THOST_FTDC_AG_OnlyGain = (byte)('3'),
		///浮盈浮亏都不计算
		THOST_FTDC_AG_None = (byte)('4'),

	};

	public enum TThostFtdcIncludeCloseProfitType:byte
	{

		///包含平仓盈利
		THOST_FTDC_ICP_Include = (byte)('0'),
		///不包含平仓盈利
		THOST_FTDC_ICP_NotInclude = (byte)('2'),

	};

	public enum TThostFtdcAllWithoutTradeType:byte
	{

		///无仓无成交不受可提比例限制
		THOST_FTDC_AWT_Enable = (byte)('0'),
		///受可提比例限制
		THOST_FTDC_AWT_Disable = (byte)('2'),
		///无仓不受可提比例限制
		THOST_FTDC_AWT_NoHoldEnable = (byte)('3'),

	};

	public enum TThostFtdcFuturePwdFlagType:byte
	{

		///不核对
		THOST_FTDC_FPWD_UnCheck = (byte)('0'),
		///核对
		THOST_FTDC_FPWD_Check = (byte)('1'),

	};

	public enum TThostFtdcTransferTypeType:byte
	{

		///银行转期货
		THOST_FTDC_TT_BankToFuture = (byte)('0'),
		///期货转银行
		THOST_FTDC_TT_FutureToBank = (byte)('1'),

	};

	public enum TThostFtdcTransferValidFlagType:byte
	{

		///无效或失败
		THOST_FTDC_TVF_Invalid = (byte)('0'),
		///有效
		THOST_FTDC_TVF_Valid = (byte)('1'),
		///冲正
		THOST_FTDC_TVF_Reverse = (byte)('2'),

	};

	public enum TThostFtdcReasonType:byte
	{

		///错单
		THOST_FTDC_RN_CD = (byte)('0'),
		///资金在途
		THOST_FTDC_RN_ZT = (byte)('1'),
		///其它
		THOST_FTDC_RN_QT = (byte)('2'),

	};

	public enum TThostFtdcSexType:byte
	{

		///未知
		THOST_FTDC_SEX_None = (byte)('0'),
		///男
		THOST_FTDC_SEX_Man = (byte)('1'),
		///女
		THOST_FTDC_SEX_Woman = (byte)('2'),

	};

	public enum TThostFtdcUserTypeType:byte
	{

		///投资者
		THOST_FTDC_UT_Investor = (byte)('0'),
		///操作员
		THOST_FTDC_UT_Operator = (byte)('1'),
		///管理员
		THOST_FTDC_UT_SuperUser = (byte)('2'),

	};

	public enum TThostFtdcRateTypeType:byte
	{

		///保证金率
		THOST_FTDC_RATETYPE_MarginRate = (byte)('2'),

	};

	public enum TThostFtdcNoteTypeType:byte
	{

		///交易结算单
		THOST_FTDC_NOTETYPE_TradeSettleBill = (byte)('1'),
		///交易结算月报
		THOST_FTDC_NOTETYPE_TradeSettleMonth = (byte)('2'),
		///追加保证金通知书
		THOST_FTDC_NOTETYPE_CallMarginNotes = (byte)('3'),
		///强行平仓通知书
		THOST_FTDC_NOTETYPE_ForceCloseNotes = (byte)('4'),
		///成交通知书
		THOST_FTDC_NOTETYPE_TradeNotes = (byte)('5'),
		///交割通知书
		THOST_FTDC_NOTETYPE_DelivNotes = (byte)('6'),

	};

	public enum TThostFtdcSettlementStyleType:byte
	{

		///逐日盯市
		THOST_FTDC_SBS_Day = (byte)('1'),
		///逐笔对冲
		THOST_FTDC_SBS_Volume = (byte)('2'),

	};

	public enum TThostFtdcSettlementBillTypeType:byte
	{

		///日报
		THOST_FTDC_ST_Day = (byte)('0'),
		///月报
		THOST_FTDC_ST_Month = (byte)('1'),

	};

	public enum TThostFtdcUserRightTypeType:byte
	{

		///登录
		THOST_FTDC_URT_Logon = (byte)('1'),
		///银期转帐
		THOST_FTDC_URT_Transfer = (byte)('2'),
		///邮寄结算单
		THOST_FTDC_URT_EMail = (byte)('3'),
		///传真结算单
		THOST_FTDC_URT_Fax = (byte)('4'),
		///条件单
		THOST_FTDC_URT_ConditionOrder = (byte)('5'),

	};

	public enum TThostFtdcMarginPriceTypeType:byte
	{

		///昨结算价
		THOST_FTDC_MPT_PreSettlementPrice = (byte)('1'),
		///最新价
		THOST_FTDC_MPT_SettlementPrice = (byte)('2'),
		///成交均价
		THOST_FTDC_MPT_AveragePrice = (byte)('3'),
		///开仓价
		THOST_FTDC_MPT_OpenPrice = (byte)('4'),

	};

	public enum TThostFtdcBillGenStatusType:byte
	{

		///未生成
		THOST_FTDC_BGS_None = (byte)('0'),
		///生成中
		THOST_FTDC_BGS_NoGenerated = (byte)('1'),
		///已生成
		THOST_FTDC_BGS_Generated = (byte)('2'),

	};

	public enum TThostFtdcAlgoTypeType:byte
	{

		///持仓处理算法
		THOST_FTDC_AT_HandlePositionAlgo = (byte)('1'),
		///寻找保证金率算法
		THOST_FTDC_AT_FindMarginRateAlgo = (byte)('2'),

	};

	public enum TThostFtdcHandlePositionAlgoIDType:byte
	{

		///基本
		THOST_FTDC_HPA_Base = (byte)('1'),
		///大连商品交易所
		THOST_FTDC_HPA_DCE = (byte)('2'),
		///郑州商品交易所
		THOST_FTDC_HPA_CZCE = (byte)('3'),

	};

	public enum TThostFtdcFindMarginRateAlgoIDType:byte
	{

		///基本
		THOST_FTDC_FMRA_Base = (byte)('1'),
		///大连商品交易所
		THOST_FTDC_FMRA_DCE = (byte)('2'),
		///郑州商品交易所
		THOST_FTDC_FMRA_CZCE = (byte)('3'),

	};

	public enum TThostFtdcHandleTradingAccountAlgoIDType:byte
	{

		///基本
		THOST_FTDC_HTAA_Base = (byte)('1'),
		///大连商品交易所
		THOST_FTDC_HTAA_DCE = (byte)('2'),
		///郑州商品交易所
		THOST_FTDC_HTAA_CZCE = (byte)('3'),

	};

	public enum TThostFtdcPersonTypeType:byte
	{

		///指定下单人
		THOST_FTDC_PST_Order = (byte)('1'),
		///开户授权人
		THOST_FTDC_PST_Open = (byte)('2'),
		///资金调拨人
		THOST_FTDC_PST_Fund = (byte)('3'),
		///结算单确认人
		THOST_FTDC_PST_Settlement = (byte)('4'),
		///法人
		THOST_FTDC_PST_Company = (byte)('5'),
		///法人代表
		THOST_FTDC_PST_Corporation = (byte)('6'),
		///投资者联系人
		THOST_FTDC_PST_LinkMan = (byte)('7'),
		///分户管理资产负责人
		THOST_FTDC_PST_Ledger = (byte)('8'),
		///托（保）管人
		THOST_FTDC_PST_Trustee = (byte)('9'),
		///托（保）管机构法人代表
		THOST_FTDC_PST_TrusteeCorporation = (byte)('A'),
		///托（保）管机构开户授权人
		THOST_FTDC_PST_TrusteeOpen = (byte)('B'),
		///托（保）管机构联系人
		THOST_FTDC_PST_TrusteeContact = (byte)('C'),
		///境外自然人参考证件
		THOST_FTDC_PST_ForeignerRefer = (byte)('D'),
		///法人代表参考证件
		THOST_FTDC_PST_CorporationRefer = (byte)('E'),

	};

	public enum TThostFtdcQueryInvestorRangeType:byte
	{

		///所有
		THOST_FTDC_QIR_All = (byte)('1'),
		///查询分类
		THOST_FTDC_QIR_Group = (byte)('2'),
		///单一投资者
		THOST_FTDC_QIR_Single = (byte)('3'),

	};

	public enum TThostFtdcInvestorRiskStatusType:byte
	{

		///正常
		THOST_FTDC_IRS_Normal = (byte)('1'),
		///警告
		THOST_FTDC_IRS_Warn = (byte)('2'),
		///追保
		THOST_FTDC_IRS_Call = (byte)('3'),
		///强平
		THOST_FTDC_IRS_Force = (byte)('4'),
		///异常
		THOST_FTDC_IRS_Exception = (byte)('5'),

	};

	public enum TThostFtdcUserEventTypeType:byte
	{

		///登录
		THOST_FTDC_UET_Login = (byte)('1'),
		///登出
		THOST_FTDC_UET_Logout = (byte)('2'),
		///交易成功
		THOST_FTDC_UET_Trading = (byte)('3'),
		///交易失败
		THOST_FTDC_UET_TradingError = (byte)('4'),
		///修改密码
		THOST_FTDC_UET_UpdatePassword = (byte)('5'),
		///客户端认证
		THOST_FTDC_UET_Authenticate = (byte)('6'),
		///终端信息上报
		THOST_FTDC_UET_SubmitSysInfo = (byte)('7'),
		///转账
		THOST_FTDC_UET_Transfer = (byte)('8'),
		///其他
		THOST_FTDC_UET_Other = (byte)('9'),

	};

	public enum TThostFtdcCloseStyleType:byte
	{

		///先开先平
		THOST_FTDC_ICS_Close = (byte)('0'),
		///先平今再平昨
		THOST_FTDC_ICS_CloseToday = (byte)('1'),

	};

	public enum TThostFtdcStatModeType:byte
	{

		///----
		THOST_FTDC_SM_Non = (byte)('0'),
		///按合约统计
		THOST_FTDC_SM_Instrument = (byte)('1'),
		///按产品统计
		THOST_FTDC_SM_Product = (byte)('2'),
		///按投资者统计
		THOST_FTDC_SM_Investor = (byte)('3'),

	};

	public enum TThostFtdcParkedOrderStatusType:byte
	{

		///未发送
		THOST_FTDC_PAOS_NotSend = (byte)('1'),
		///已发送
		THOST_FTDC_PAOS_Send = (byte)('2'),
		///已删除
		THOST_FTDC_PAOS_Deleted = (byte)('3'),

	};

	public enum TThostFtdcVirDealStatusType:byte
	{

		///正在处理
		THOST_FTDC_VDS_Dealing = (byte)('1'),
		///处理成功
		THOST_FTDC_VDS_DeaclSucceed = (byte)('2'),

	};

	public enum TThostFtdcOrgSystemIDType:byte
	{

		///综合交易平台
		THOST_FTDC_ORGS_Standard = (byte)('0'),
		///易盛系统
		THOST_FTDC_ORGS_ESunny = (byte)('1'),
		///金仕达V6系统
		THOST_FTDC_ORGS_KingStarV6 = (byte)('2'),

	};

	public enum TThostFtdcVirTradeStatusType:byte
	{

		///正常处理中
		THOST_FTDC_VTS_NaturalDeal = (byte)('0'),
		///成功结束
		THOST_FTDC_VTS_SucceedEnd = (byte)('1'),
		///失败结束
		THOST_FTDC_VTS_FailedEND = (byte)('2'),
		///异常中
		THOST_FTDC_VTS_Exception = (byte)('3'),
		///已人工异常处理
		THOST_FTDC_VTS_ManualDeal = (byte)('4'),
		///通讯异常 ，请人工处理
		THOST_FTDC_VTS_MesException = (byte)('5'),
		///系统出错，请人工处理
		THOST_FTDC_VTS_SysException = (byte)('6'),

	};

	public enum TThostFtdcVirBankAccTypeType:byte
	{

		///存折
		THOST_FTDC_VBAT_BankBook = (byte)('1'),
		///储蓄卡
		THOST_FTDC_VBAT_BankCard = (byte)('2'),
		///信用卡
		THOST_FTDC_VBAT_CreditCard = (byte)('3'),

	};

	public enum TThostFtdcVirementStatusType:byte
	{

		///正常
		THOST_FTDC_VMS_Natural = (byte)('0'),
		///销户
		THOST_FTDC_VMS_Canceled = (byte)('9'),

	};

	public enum TThostFtdcVirementAvailAbilityType:byte
	{

		///未确认
		THOST_FTDC_VAA_NoAvailAbility = (byte)('0'),
		///有效
		THOST_FTDC_VAA_AvailAbility = (byte)('1'),
		///冲正
		THOST_FTDC_VAA_Repeal = (byte)('2'),

	};

	public enum TThostFtdcVirementTradeCodeType
	{

		///银行发起银行资金转期货
		THOST_FTDC_VTC_BankBankToFuture = 102001,
		///银行发起期货资金转银行
		THOST_FTDC_VTC_BankFutureToBank = 102002,
		///期货发起银行资金转期货
		THOST_FTDC_VTC_FutureBankToFuture = 202001,
		///期货发起期货资金转银行
		THOST_FTDC_VTC_FutureFutureToBank = 202002,

	};

	public enum TThostFtdcAMLGenStatusType:byte
	{

		///程序生成
		THOST_FTDC_GEN_Program = (byte)('0'),
		///人工生成
		THOST_FTDC_GEN_HandWork = (byte)('1'),

	};

	public enum TThostFtdcCFMMCKeyKindType:byte
	{

		///主动请求更新
		THOST_FTDC_CFMMCKK_REQUEST = (byte)('R'),
		///CFMMC自动更新
		THOST_FTDC_CFMMCKK_AUTO = (byte)('A'),
		///CFMMC手动更新
		THOST_FTDC_CFMMCKK_MANUAL = (byte)('M'),

	};

	public enum TThostFtdcCertificationTypeType:byte
	{

		///身份证
		THOST_FTDC_CFT_IDCard = (byte)('0'),
		///护照
		THOST_FTDC_CFT_Passport = (byte)('1'),
		///军官证
		THOST_FTDC_CFT_OfficerIDCard = (byte)('2'),
		///士兵证
		THOST_FTDC_CFT_SoldierIDCard = (byte)('3'),
		///回乡证
		THOST_FTDC_CFT_HomeComingCard = (byte)('4'),
		///营业执照号
		THOST_FTDC_CFT_LicenseNo = (byte)('6'),
		///组织机构代码证
		THOST_FTDC_CFT_InstitutionCodeCard = (byte)('7'),
		///临时营业执照号
		THOST_FTDC_CFT_TempLicenseNo = (byte)('8'),
		///民办非企业登记证书
		THOST_FTDC_CFT_NoEnterpriseLicenseNo = (byte)('9'),
		///其他证件
		THOST_FTDC_CFT_OtherCard = (byte)('x'),
		///主管部门批文
		THOST_FTDC_CFT_SuperDepAgree = (byte)('a'),

	};

	public enum TThostFtdcFileBusinessCodeType:byte
	{

		///其他
		THOST_FTDC_FBC_Others = (byte)('0'),
		///转账交易明细对账
		THOST_FTDC_FBC_TransferDetails = (byte)('1'),
		///客户账户状态对账
		THOST_FTDC_FBC_CustAccStatus = (byte)('2'),
		///账户类交易明细对账
		THOST_FTDC_FBC_AccountTradeDetails = (byte)('3'),
		///期货账户信息变更明细对账
		THOST_FTDC_FBC_FutureAccountChangeInfoDetails = (byte)('4'),
		///客户资金台账余额明细对账
		THOST_FTDC_FBC_CustMoneyDetail = (byte)('5'),
		///客户销户结息明细对账
		THOST_FTDC_FBC_CustCancelAccountInfo = (byte)('6'),
		///客户资金余额对账结果
		THOST_FTDC_FBC_CustMoneyResult = (byte)('7'),
		///其它对账异常结果文件
		THOST_FTDC_FBC_OthersExceptionResult = (byte)('8'),
		///客户结息净额明细
		THOST_FTDC_FBC_CustInterestNetMoneyDetails = (byte)('9'),
		///客户资金交收明细
		THOST_FTDC_FBC_CustMoneySendAndReceiveDetails = (byte)('a'),
		///法人存管银行资金交收汇总
		THOST_FTDC_FBC_CorporationMoneyTotal = (byte)('b'),
		///主体间资金交收汇总
		THOST_FTDC_FBC_MainbodyMoneyTotal = (byte)('c'),
		///总分平衡监管数据
		THOST_FTDC_FBC_MainPartMonitorData = (byte)('d'),
		///存管银行备付金余额
		THOST_FTDC_FBC_PreparationMoney = (byte)('e'),
		///协办存管银行资金监管数据
		THOST_FTDC_FBC_BankMoneyMonitorData = (byte)('f'),

	};

	public enum TThostFtdcCashExchangeCodeType:byte
	{

		///汇
		THOST_FTDC_CEC_Exchange = (byte)('1'),
		///钞
		THOST_FTDC_CEC_Cash = (byte)('2'),

	};

	public enum TThostFtdcYesNoIndicatorType:byte
	{

		///是
		THOST_FTDC_YNI_Yes = (byte)('0'),
		///否
		THOST_FTDC_YNI_No = (byte)('1'),

	};

	public enum TThostFtdcBanlanceTypeType:byte
	{

		///当前余额
		THOST_FTDC_BLT_CurrentMoney = (byte)('0'),
		///可用余额
		THOST_FTDC_BLT_UsableMoney = (byte)('1'),
		///可取余额
		THOST_FTDC_BLT_FetchableMoney = (byte)('2'),
		///冻结余额
		THOST_FTDC_BLT_FreezeMoney = (byte)('3'),

	};

	public enum TThostFtdcGenderType:byte
	{

		///未知状态
		THOST_FTDC_GD_Unknown = (byte)('0'),
		///男
		THOST_FTDC_GD_Male = (byte)('1'),
		///女
		THOST_FTDC_GD_Female = (byte)('2'),

	};

	public enum TThostFtdcFeePayFlagType:byte
	{

		///由受益方支付费用
		THOST_FTDC_FPF_BEN = (byte)('0'),
		///由发送方支付费用
		THOST_FTDC_FPF_OUR = (byte)('1'),
		///由发送方支付发起的费用，受益方支付接受的费用
		THOST_FTDC_FPF_SHA = (byte)('2'),

	};

	public enum TThostFtdcPassWordKeyTypeType:byte
	{

		///交换密钥
		THOST_FTDC_PWKT_ExchangeKey = (byte)('0'),
		///密码密钥
		THOST_FTDC_PWKT_PassWordKey = (byte)('1'),
		///MAC密钥
		THOST_FTDC_PWKT_MACKey = (byte)('2'),
		///报文密钥
		THOST_FTDC_PWKT_MessageKey = (byte)('3'),

	};

	public enum TThostFtdcFBTPassWordTypeType:byte
	{

		///查询
		THOST_FTDC_PWT_Query = (byte)('0'),
		///取款
		THOST_FTDC_PWT_Fetch = (byte)('1'),
		///转帐
		THOST_FTDC_PWT_Transfer = (byte)('2'),
		///交易
		THOST_FTDC_PWT_Trade = (byte)('3'),

	};

	public enum TThostFtdcFBTEncryModeType:byte
	{

		///不加密
		THOST_FTDC_EM_NoEncry = (byte)('0'),
		///DES
		THOST_FTDC_EM_DES = (byte)('1'),
		///3DES
		THOST_FTDC_EM_3DES = (byte)('2'),

	};

	public enum TThostFtdcBankRepealFlagType:byte
	{

		///银行无需自动冲正
		THOST_FTDC_BRF_BankNotNeedRepeal = (byte)('0'),
		///银行待自动冲正
		THOST_FTDC_BRF_BankWaitingRepeal = (byte)('1'),
		///银行已自动冲正
		THOST_FTDC_BRF_BankBeenRepealed = (byte)('2'),

	};

	public enum TThostFtdcBrokerRepealFlagType:byte
	{

		///期商无需自动冲正
		THOST_FTDC_BRORF_BrokerNotNeedRepeal = (byte)('0'),
		///期商待自动冲正
		THOST_FTDC_BRORF_BrokerWaitingRepeal = (byte)('1'),
		///期商已自动冲正
		THOST_FTDC_BRORF_BrokerBeenRepealed = (byte)('2'),

	};

	public enum TThostFtdcInstitutionTypeType:byte
	{

		///银行
		THOST_FTDC_TS_Bank = (byte)('0'),
		///期商
		THOST_FTDC_TS_Future = (byte)('1'),
		///券商
		THOST_FTDC_TS_Store = (byte)('2'),

	};

	public enum TThostFtdcLastFragmentType:byte
	{

		///是最后分片
		THOST_FTDC_LF_Yes = (byte)('0'),
		///不是最后分片
		THOST_FTDC_LF_No = (byte)('1'),

	};

	public enum TThostFtdcBankAccStatusType:byte
	{

		///正常
		THOST_FTDC_BAS_Normal = (byte)('0'),
		///冻结
		THOST_FTDC_BAS_Freeze = (byte)('1'),
		///挂失
		THOST_FTDC_BAS_ReportLoss = (byte)('2'),

	};

	public enum TThostFtdcMoneyAccountStatusType:byte
	{

		///正常
		THOST_FTDC_MAS_Normal = (byte)('0'),
		///销户
		THOST_FTDC_MAS_Cancel = (byte)('1'),

	};

	public enum TThostFtdcManageStatusType:byte
	{

		///指定存管
		THOST_FTDC_MSS_Point = (byte)('0'),
		///预指定
		THOST_FTDC_MSS_PrePoint = (byte)('1'),
		///撤销指定
		THOST_FTDC_MSS_CancelPoint = (byte)('2'),

	};

	public enum TThostFtdcSystemTypeType:byte
	{

		///银期转帐
		THOST_FTDC_SYT_FutureBankTransfer = (byte)('0'),
		///银证转帐
		THOST_FTDC_SYT_StockBankTransfer = (byte)('1'),
		///第三方存管
		THOST_FTDC_SYT_TheThirdPartStore = (byte)('2'),

	};

	public enum TThostFtdcTxnEndFlagType:byte
	{

		///正常处理中
		THOST_FTDC_TEF_NormalProcessing = (byte)('0'),
		///成功结束
		THOST_FTDC_TEF_Success = (byte)('1'),
		///失败结束
		THOST_FTDC_TEF_Failed = (byte)('2'),
		///异常中
		THOST_FTDC_TEF_Abnormal = (byte)('3'),
		///已人工异常处理
		THOST_FTDC_TEF_ManualProcessedForException = (byte)('4'),
		///通讯异常 ，请人工处理
		THOST_FTDC_TEF_CommuFailedNeedManualProcess = (byte)('5'),
		///系统出错，请人工处理
		THOST_FTDC_TEF_SysErrorNeedManualProcess = (byte)('6'),

	};

	public enum TThostFtdcProcessStatusType:byte
	{

		///未处理
		THOST_FTDC_PSS_NotProcess = (byte)('0'),
		///开始处理
		THOST_FTDC_PSS_StartProcess = (byte)('1'),
		///处理完成
		THOST_FTDC_PSS_Finished = (byte)('2'),

	};

	public enum TThostFtdcCustTypeType:byte
	{

		///自然人
		THOST_FTDC_CUSTT_Person = (byte)('0'),
		///机构户
		THOST_FTDC_CUSTT_Institution = (byte)('1'),

	};

	public enum TThostFtdcFBTTransferDirectionType:byte
	{

		///入金，银行转期货
		THOST_FTDC_FBTTD_FromBankToFuture = (byte)('1'),
		///出金，期货转银行
		THOST_FTDC_FBTTD_FromFutureToBank = (byte)('2'),

	};

	public enum TThostFtdcOpenOrDestroyType:byte
	{

		///开户
		THOST_FTDC_OOD_Open = (byte)('1'),
		///销户
		THOST_FTDC_OOD_Destroy = (byte)('0'),

	};

	public enum TThostFtdcAvailabilityFlagType:byte
	{

		///未确认
		THOST_FTDC_AVAF_Invalid = (byte)('0'),
		///有效
		THOST_FTDC_AVAF_Valid = (byte)('1'),
		///冲正
		THOST_FTDC_AVAF_Repeal = (byte)('2'),

	};

	public enum TThostFtdcOrganTypeType:byte
	{

		///银行代理
		THOST_FTDC_OT_Bank = (byte)('1'),
		///交易前置
		THOST_FTDC_OT_Future = (byte)('2'),
		///银期转帐平台管理
		THOST_FTDC_OT_PlateForm = (byte)('9'),

	};

	public enum TThostFtdcOrganLevelType:byte
	{

		///银行总行或期商总部
		THOST_FTDC_OL_HeadQuarters = (byte)('1'),
		///银行分中心或期货公司营业部
		THOST_FTDC_OL_Branch = (byte)('2'),

	};

	public enum TThostFtdcProtocalIDType:byte
	{

		///期商协议
		THOST_FTDC_PID_FutureProtocal = (byte)('0'),
		///工行协议
		THOST_FTDC_PID_ICBCProtocal = (byte)('1'),
		///农行协议
		THOST_FTDC_PID_ABCProtocal = (byte)('2'),
		///中国银行协议
		THOST_FTDC_PID_CBCProtocal = (byte)('3'),
		///建行协议
		THOST_FTDC_PID_CCBProtocal = (byte)('4'),
		///交行协议
		THOST_FTDC_PID_BOCOMProtocal = (byte)('5'),
		///银期转帐平台协议
		THOST_FTDC_PID_FBTPlateFormProtocal = (byte)('X'),

	};

	public enum TThostFtdcConnectModeType:byte
	{

		///短连接
		THOST_FTDC_CM_ShortConnect = (byte)('0'),
		///长连接
		THOST_FTDC_CM_LongConnect = (byte)('1'),

	};

	public enum TThostFtdcSyncModeType:byte
	{

		///异步
		THOST_FTDC_SRM_ASync = (byte)('0'),
		///同步
		THOST_FTDC_SRM_Sync = (byte)('1'),

	};

	public enum TThostFtdcBankAccTypeType:byte
	{

		///银行存折
		THOST_FTDC_BAT_BankBook = (byte)('1'),
		///储蓄卡
		THOST_FTDC_BAT_SavingCard = (byte)('2'),
		///信用卡
		THOST_FTDC_BAT_CreditCard = (byte)('3'),

	};

	public enum TThostFtdcFutureAccTypeType:byte
	{

		///银行存折
		THOST_FTDC_FAT_BankBook = (byte)('1'),
		///储蓄卡
		THOST_FTDC_FAT_SavingCard = (byte)('2'),
		///信用卡
		THOST_FTDC_FAT_CreditCard = (byte)('3'),

	};

	public enum TThostFtdcOrganStatusType:byte
	{

		///启用
		THOST_FTDC_OS_Ready = (byte)('0'),
		///签到
		THOST_FTDC_OS_CheckIn = (byte)('1'),
		///签退
		THOST_FTDC_OS_CheckOut = (byte)('2'),
		///对帐文件到达
		THOST_FTDC_OS_CheckFileArrived = (byte)('3'),
		///对帐
		THOST_FTDC_OS_CheckDetail = (byte)('4'),
		///日终清理
		THOST_FTDC_OS_DayEndClean = (byte)('5'),
		///注销
		THOST_FTDC_OS_Invalid = (byte)('9'),

	};

	public enum TThostFtdcCCBFeeModeType:byte
	{

		///按金额扣收
		THOST_FTDC_CCBFM_ByAmount = (byte)('1'),
		///按月扣收
		THOST_FTDC_CCBFM_ByMonth = (byte)('2'),

	};

	public enum TThostFtdcCommApiTypeType:byte
	{

		///客户端
		THOST_FTDC_CAPIT_Client = (byte)('1'),
		///服务端
		THOST_FTDC_CAPIT_Server = (byte)('2'),
		///交易系统的UserApi
		THOST_FTDC_CAPIT_UserApi = (byte)('3'),

	};

	public enum TThostFtdcLinkStatusType:byte
	{

		///已经连接
		THOST_FTDC_LS_Connected = (byte)('1'),
		///没有连接
		THOST_FTDC_LS_Disconnected = (byte)('2'),

	};

	public enum TThostFtdcPwdFlagType:byte
	{

		///不核对
		THOST_FTDC_BPWDF_NoCheck = (byte)('0'),
		///明文核对
		THOST_FTDC_BPWDF_BlankCheck = (byte)('1'),
		///密文核对
		THOST_FTDC_BPWDF_EncryptCheck = (byte)('2'),

	};

	public enum TThostFtdcSecuAccTypeType:byte
	{

		///资金帐号
		THOST_FTDC_SAT_AccountID = (byte)('1'),
		///资金卡号
		THOST_FTDC_SAT_CardID = (byte)('2'),
		///上海股东帐号
		THOST_FTDC_SAT_SHStockholderID = (byte)('3'),
		///深圳股东帐号
		THOST_FTDC_SAT_SZStockholderID = (byte)('4'),

	};

	public enum TThostFtdcTransferStatusType:byte
	{

		///正常
		THOST_FTDC_TRFS_Normal = (byte)('0'),
		///被冲正
		THOST_FTDC_TRFS_Repealed = (byte)('1'),

	};

	public enum TThostFtdcSponsorTypeType:byte
	{

		///期商
		THOST_FTDC_SPTYPE_Broker = (byte)('0'),
		///银行
		THOST_FTDC_SPTYPE_Bank = (byte)('1'),

	};

	public enum TThostFtdcReqRspTypeType:byte
	{

		///请求
		THOST_FTDC_REQRSP_Request = (byte)('0'),
		///响应
		THOST_FTDC_REQRSP_Response = (byte)('1'),

	};

	public enum TThostFtdcFBTUserEventTypeType:byte
	{

		///签到
		THOST_FTDC_FBTUET_SignIn = (byte)('0'),
		///银行转期货
		THOST_FTDC_FBTUET_FromBankToFuture = (byte)('1'),
		///期货转银行
		THOST_FTDC_FBTUET_FromFutureToBank = (byte)('2'),
		///开户
		THOST_FTDC_FBTUET_OpenAccount = (byte)('3'),
		///销户
		THOST_FTDC_FBTUET_CancelAccount = (byte)('4'),
		///变更银行账户
		THOST_FTDC_FBTUET_ChangeAccount = (byte)('5'),
		///冲正银行转期货
		THOST_FTDC_FBTUET_RepealFromBankToFuture = (byte)('6'),
		///冲正期货转银行
		THOST_FTDC_FBTUET_RepealFromFutureToBank = (byte)('7'),
		///查询银行账户
		THOST_FTDC_FBTUET_QueryBankAccount = (byte)('8'),
		///查询期货账户
		THOST_FTDC_FBTUET_QueryFutureAccount = (byte)('9'),
		///签退
		THOST_FTDC_FBTUET_SignOut = (byte)('A'),
		///密钥同步
		THOST_FTDC_FBTUET_SyncKey = (byte)('B'),
		///预约开户
		THOST_FTDC_FBTUET_ReserveOpenAccount = (byte)('C'),
		///撤销预约开户
		THOST_FTDC_FBTUET_CancelReserveOpenAccount = (byte)('D'),
		///预约开户确认
		THOST_FTDC_FBTUET_ReserveOpenAccountConfirm = (byte)('E'),
		///其他
		THOST_FTDC_FBTUET_Other = (byte)('Z'),

	};

	public enum TThostFtdcDBOperationType:byte
	{

		///插入
		THOST_FTDC_DBOP_Insert = (byte)('0'),
		///更新
		THOST_FTDC_DBOP_Update = (byte)('1'),
		///删除
		THOST_FTDC_DBOP_Delete = (byte)('2'),

	};

	public enum TThostFtdcSyncFlagType:byte
	{

		///已同步
		THOST_FTDC_SYNF_Yes = (byte)('0'),
		///未同步
		THOST_FTDC_SYNF_No = (byte)('1'),

	};

	public enum TThostFtdcSyncTypeType:byte
	{

		///一次同步
		THOST_FTDC_SYNT_OneOffSync = (byte)('0'),
		///定时同步
		THOST_FTDC_SYNT_TimerSync = (byte)('1'),
		///定时完全同步
		THOST_FTDC_SYNT_TimerFullSync = (byte)('2'),

	};

	public enum TThostFtdcExDirectionType:byte
	{

		///结汇
		THOST_FTDC_FBEDIR_Settlement = (byte)('0'),
		///售汇
		THOST_FTDC_FBEDIR_Sale = (byte)('1'),

	};

	public enum TThostFtdcFBEResultFlagType:byte
	{

		///成功
		THOST_FTDC_FBERES_Success = (byte)('0'),
		///账户余额不足
		THOST_FTDC_FBERES_InsufficientBalance = (byte)('1'),
		///交易结果未知
		THOST_FTDC_FBERES_UnknownTrading = (byte)('8'),
		///失败
		THOST_FTDC_FBERES_Fail = (byte)('x'),

	};

	public enum TThostFtdcFBEExchStatusType:byte
	{

		///正常
		THOST_FTDC_FBEES_Normal = (byte)('0'),
		///交易重发
		THOST_FTDC_FBEES_ReExchange = (byte)('1'),

	};

	public enum TThostFtdcFBEFileFlagType:byte
	{

		///数据包
		THOST_FTDC_FBEFG_DataPackage = (byte)('0'),
		///文件
		THOST_FTDC_FBEFG_File = (byte)('1'),

	};

	public enum TThostFtdcFBEAlreadyTradeType:byte
	{

		///未交易
		THOST_FTDC_FBEAT_NotTrade = (byte)('0'),
		///已交易
		THOST_FTDC_FBEAT_Trade = (byte)('1'),

	};

	public enum TThostFtdcFBEUserEventTypeType:byte
	{

		///签到
		THOST_FTDC_FBEUET_SignIn = (byte)('0'),
		///换汇
		THOST_FTDC_FBEUET_Exchange = (byte)('1'),
		///换汇重发
		THOST_FTDC_FBEUET_ReExchange = (byte)('2'),
		///银行账户查询
		THOST_FTDC_FBEUET_QueryBankAccount = (byte)('3'),
		///换汇明细查询
		THOST_FTDC_FBEUET_QueryExchDetial = (byte)('4'),
		///换汇汇总查询
		THOST_FTDC_FBEUET_QueryExchSummary = (byte)('5'),
		///换汇汇率查询
		THOST_FTDC_FBEUET_QueryExchRate = (byte)('6'),
		///对账文件通知
		THOST_FTDC_FBEUET_CheckBankAccount = (byte)('7'),
		///签退
		THOST_FTDC_FBEUET_SignOut = (byte)('8'),
		///其他
		THOST_FTDC_FBEUET_Other = (byte)('Z'),

	};

	public enum TThostFtdcFBEReqFlagType:byte
	{

		///未处理
		THOST_FTDC_FBERF_UnProcessed = (byte)('0'),
		///等待发送
		THOST_FTDC_FBERF_WaitSend = (byte)('1'),
		///发送成功
		THOST_FTDC_FBERF_SendSuccess = (byte)('2'),
		///发送失败
		THOST_FTDC_FBERF_SendFailed = (byte)('3'),
		///等待重发
		THOST_FTDC_FBERF_WaitReSend = (byte)('4'),

	};

	public enum TThostFtdcNotifyClassType:byte
	{

		///正常
		THOST_FTDC_NC_NOERROR = (byte)('0'),
		///警示
		THOST_FTDC_NC_Warn = (byte)('1'),
		///追保
		THOST_FTDC_NC_Call = (byte)('2'),
		///强平
		THOST_FTDC_NC_Force = (byte)('3'),
		///穿仓
		THOST_FTDC_NC_CHUANCANG = (byte)('4'),
		///异常
		THOST_FTDC_NC_Exception = (byte)('5'),

	};

	public enum TThostFtdcForceCloseTypeType:byte
	{

		///手工强平
		THOST_FTDC_FCT_Manual = (byte)('0'),
		///单一投资者辅助强平
		THOST_FTDC_FCT_Single = (byte)('1'),
		///批量投资者辅助强平
		THOST_FTDC_FCT_Group = (byte)('2'),

	};

	public enum TThostFtdcRiskNotifyMethodType:byte
	{

		///系统通知
		THOST_FTDC_RNM_System = (byte)('0'),
		///短信通知
		THOST_FTDC_RNM_SMS = (byte)('1'),
		///邮件通知
		THOST_FTDC_RNM_EMail = (byte)('2'),
		///人工通知
		THOST_FTDC_RNM_Manual = (byte)('3'),

	};

	public enum TThostFtdcRiskNotifyStatusType:byte
	{

		///未生成
		THOST_FTDC_RNS_NotGen = (byte)('0'),
		///已生成未发送
		THOST_FTDC_RNS_Generated = (byte)('1'),
		///发送失败
		THOST_FTDC_RNS_SendError = (byte)('2'),
		///已发送未接收
		THOST_FTDC_RNS_SendOk = (byte)('3'),
		///已接收未确认
		THOST_FTDC_RNS_Received = (byte)('4'),
		///已确认
		THOST_FTDC_RNS_Confirmed = (byte)('5'),

	};

	public enum TThostFtdcRiskUserEventType:byte
	{

		///导出数据
		THOST_FTDC_RUE_ExportData = (byte)('0'),

	};

	public enum TThostFtdcConditionalOrderSortTypeType:byte
	{

		///使用最新价升序
		THOST_FTDC_COST_LastPriceAsc = (byte)('0'),
		///使用最新价降序
		THOST_FTDC_COST_LastPriceDesc = (byte)('1'),
		///使用卖价升序
		THOST_FTDC_COST_AskPriceAsc = (byte)('2'),
		///使用卖价降序
		THOST_FTDC_COST_AskPriceDesc = (byte)('3'),
		///使用买价升序
		THOST_FTDC_COST_BidPriceAsc = (byte)('4'),
		///使用买价降序
		THOST_FTDC_COST_BidPriceDesc = (byte)('5'),

	};

	public enum TThostFtdcSendTypeType:byte
	{

		///未发送
		THOST_FTDC_UOAST_NoSend = (byte)('0'),
		///已发送
		THOST_FTDC_UOAST_Sended = (byte)('1'),
		///已生成
		THOST_FTDC_UOAST_Generated = (byte)('2'),
		///报送失败
		THOST_FTDC_UOAST_SendFail = (byte)('3'),
		///接收成功
		THOST_FTDC_UOAST_Success = (byte)('4'),
		///接收失败
		THOST_FTDC_UOAST_Fail = (byte)('5'),
		///取消报送
		THOST_FTDC_UOAST_Cancel = (byte)('6'),

	};

	public enum TThostFtdcClientIDStatusType:byte
	{

		///未申请
		THOST_FTDC_UOACS_NoApply = (byte)('1'),
		///已提交申请
		THOST_FTDC_UOACS_Submited = (byte)('2'),
		///已发送申请
		THOST_FTDC_UOACS_Sended = (byte)('3'),
		///完成
		THOST_FTDC_UOACS_Success = (byte)('4'),
		///拒绝
		THOST_FTDC_UOACS_Refuse = (byte)('5'),
		///已撤销编码
		THOST_FTDC_UOACS_Cancel = (byte)('6'),

	};

	public enum TThostFtdcQuestionTypeType:byte
	{

		///单选
		THOST_FTDC_QT_Radio = (byte)('1'),
		///多选
		THOST_FTDC_QT_Option = (byte)('2'),
		///填空
		THOST_FTDC_QT_Blank = (byte)('3'),

	};

	public enum TThostFtdcBusinessTypeType:byte
	{

		///请求
		THOST_FTDC_BT_Request = (byte)('1'),
		///应答
		THOST_FTDC_BT_Response = (byte)('2'),
		///通知
		THOST_FTDC_BT_Notice = (byte)('3'),

	};

	public enum TThostFtdcCfmmcReturnCodeType:byte
	{

		///成功
		THOST_FTDC_CRC_Success = (byte)('0'),
		///该客户已经有流程在处理中
		THOST_FTDC_CRC_Working = (byte)('1'),
		///监控中客户资料检查失败
		THOST_FTDC_CRC_InfoFail = (byte)('2'),
		///监控中实名制检查失败
		THOST_FTDC_CRC_IDCardFail = (byte)('3'),
		///其他错误
		THOST_FTDC_CRC_OtherFail = (byte)('4'),

	};

	public enum TThostFtdcClientTypeType:byte
	{

		///所有
		THOST_FTDC_CfMMCCT_All = (byte)('0'),
		///个人
		THOST_FTDC_CfMMCCT_Person = (byte)('1'),
		///单位
		THOST_FTDC_CfMMCCT_Company = (byte)('2'),
		///其他
		THOST_FTDC_CfMMCCT_Other = (byte)('3'),
		///特殊法人
		THOST_FTDC_CfMMCCT_SpecialOrgan = (byte)('4'),
		///资管户
		THOST_FTDC_CfMMCCT_Asset = (byte)('5'),

	};

	public enum TThostFtdcExchangeIDTypeType:byte
	{

		///上海期货交易所
		THOST_FTDC_EIDT_SHFE = (byte)('S'),
		///郑州商品交易所
		THOST_FTDC_EIDT_CZCE = (byte)('Z'),
		///大连商品交易所
		THOST_FTDC_EIDT_DCE = (byte)('D'),
		///中国金融期货交易所
		THOST_FTDC_EIDT_CFFEX = (byte)('J'),
		///上海国际能源交易中心股份有限公司
		THOST_FTDC_EIDT_INE = (byte)('N'),

	};

	public enum TThostFtdcExClientIDTypeType:byte
	{

		///套保
		THOST_FTDC_ECIDT_Hedge = (byte)('1'),
		///套利
		THOST_FTDC_ECIDT_Arbitrage = (byte)('2'),
		///投机
		THOST_FTDC_ECIDT_Speculation = (byte)('3'),

	};

	public enum TThostFtdcUpdateFlagType:byte
	{

		///未更新
		THOST_FTDC_UF_NoUpdate = (byte)('0'),
		///更新全部信息成功
		THOST_FTDC_UF_Success = (byte)('1'),
		///更新全部信息失败
		THOST_FTDC_UF_Fail = (byte)('2'),
		///更新交易编码成功
		THOST_FTDC_UF_TCSuccess = (byte)('3'),
		///更新交易编码失败
		THOST_FTDC_UF_TCFail = (byte)('4'),
		///已丢弃
		THOST_FTDC_UF_Cancel = (byte)('5'),

	};

	public enum TThostFtdcApplyOperateIDType:byte
	{

		///开户
		THOST_FTDC_AOID_OpenInvestor = (byte)('1'),
		///修改身份信息
		THOST_FTDC_AOID_ModifyIDCard = (byte)('2'),
		///修改一般信息
		THOST_FTDC_AOID_ModifyNoIDCard = (byte)('3'),
		///申请交易编码
		THOST_FTDC_AOID_ApplyTradingCode = (byte)('4'),
		///撤销交易编码
		THOST_FTDC_AOID_CancelTradingCode = (byte)('5'),
		///销户
		THOST_FTDC_AOID_CancelInvestor = (byte)('6'),
		///账户休眠
		THOST_FTDC_AOID_FreezeAccount = (byte)('8'),
		///激活休眠账户
		THOST_FTDC_AOID_ActiveFreezeAccount = (byte)('9'),

	};

	public enum TThostFtdcApplyStatusIDType:byte
	{

		///未补全
		THOST_FTDC_ASID_NoComplete = (byte)('1'),
		///已提交
		THOST_FTDC_ASID_Submited = (byte)('2'),
		///已审核
		THOST_FTDC_ASID_Checked = (byte)('3'),
		///已拒绝
		THOST_FTDC_ASID_Refused = (byte)('4'),
		///已删除
		THOST_FTDC_ASID_Deleted = (byte)('5'),

	};

	public enum TThostFtdcSendMethodType:byte
	{

		///文件发送
		THOST_FTDC_UOASM_ByAPI = (byte)('1'),
		///电子发送
		THOST_FTDC_UOASM_ByFile = (byte)('2'),

	};

	public enum TThostFtdcEventModeType:byte
	{

		///增加
		THOST_FTDC_EvM_ADD = (byte)('1'),
		///修改
		THOST_FTDC_EvM_UPDATE = (byte)('2'),
		///删除
		THOST_FTDC_EvM_DELETE = (byte)('3'),
		///复核
		THOST_FTDC_EvM_CHECK = (byte)('4'),
		///复制
		THOST_FTDC_EvM_COPY = (byte)('5'),
		///注销
		THOST_FTDC_EvM_CANCEL = (byte)('6'),
		///冲销
		THOST_FTDC_EvM_Reverse = (byte)('7'),

	};

	public enum TThostFtdcUOAAutoSendType:byte
	{

		///自动发送并接收
		THOST_FTDC_UOAA_ASR = (byte)('1'),
		///自动发送，不自动接收
		THOST_FTDC_UOAA_ASNR = (byte)('2'),
		///不自动发送，自动接收
		THOST_FTDC_UOAA_NSAR = (byte)('3'),
		///不自动发送，也不自动接收
		THOST_FTDC_UOAA_NSR = (byte)('4'),

	};

	public enum TThostFtdcFlowIDType:byte
	{

		///投资者对应投资者组设置
		THOST_FTDC_EvM_InvestorGroupFlow = (byte)('1'),
		///投资者手续费率设置
		THOST_FTDC_EvM_InvestorRate = (byte)('2'),
		///投资者手续费率模板关系设置
		THOST_FTDC_EvM_InvestorCommRateModel = (byte)('3'),

	};

	public enum TThostFtdcCheckLevelType:byte
	{

		///零级复核
		THOST_FTDC_CL_Zero = (byte)('0'),
		///一级复核
		THOST_FTDC_CL_One = (byte)('1'),
		///二级复核
		THOST_FTDC_CL_Two = (byte)('2'),

	};

	public enum TThostFtdcCheckStatusType:byte
	{

		///未复核
		THOST_FTDC_CHS_Init = (byte)('0'),
		///复核中
		THOST_FTDC_CHS_Checking = (byte)('1'),
		///已复核
		THOST_FTDC_CHS_Checked = (byte)('2'),
		///拒绝
		THOST_FTDC_CHS_Refuse = (byte)('3'),
		///作废
		THOST_FTDC_CHS_Cancel = (byte)('4'),

	};

	public enum TThostFtdcUsedStatusType:byte
	{

		///未生效
		THOST_FTDC_CHU_Unused = (byte)('0'),
		///已生效
		THOST_FTDC_CHU_Used = (byte)('1'),
		///生效失败
		THOST_FTDC_CHU_Fail = (byte)('2'),

	};

	public enum TThostFtdcBankAcountOriginType:byte
	{

		///手工录入
		THOST_FTDC_BAO_ByAccProperty = (byte)('0'),
		///银期转账
		THOST_FTDC_BAO_ByFBTransfer = (byte)('1'),

	};

	public enum TThostFtdcMonthBillTradeSumType:byte
	{

		///同日同合约
		THOST_FTDC_MBTS_ByInstrument = (byte)('0'),
		///同日同合约同价格
		THOST_FTDC_MBTS_ByDayInsPrc = (byte)('1'),
		///同合约
		THOST_FTDC_MBTS_ByDayIns = (byte)('2'),

	};

	public enum TThostFtdcFBTTradeCodeEnumType
	{

		///银行发起银行转期货
		THOST_FTDC_FTC_BankLaunchBankToBroker = 102001,
		///期货发起银行转期货
		THOST_FTDC_FTC_BrokerLaunchBankToBroker = 202001,
		///银行发起期货转银行
		THOST_FTDC_FTC_BankLaunchBrokerToBank = 102002,
		///期货发起期货转银行
		THOST_FTDC_FTC_BrokerLaunchBrokerToBank = 202002,

	};

	public enum TThostFtdcOTPTypeType:byte
	{

		///无动态令牌
		THOST_FTDC_OTP_NONE = (byte)('0'),
		///时间令牌
		THOST_FTDC_OTP_TOTP = (byte)('1'),

	};

	public enum TThostFtdcOTPStatusType:byte
	{

		///未使用
		THOST_FTDC_OTPS_Unused = (byte)('0'),
		///已使用
		THOST_FTDC_OTPS_Used = (byte)('1'),
		///注销
		THOST_FTDC_OTPS_Disuse = (byte)('2'),

	};

	public enum TThostFtdcBrokerUserTypeType:byte
	{

		///投资者
		THOST_FTDC_BUT_Investor = (byte)('1'),
		///操作员
		THOST_FTDC_BUT_BrokerUser = (byte)('2'),

	};

	public enum TThostFtdcFutureTypeType:byte
	{

		///商品期货
		THOST_FTDC_FUTT_Commodity = (byte)('1'),
		///金融期货
		THOST_FTDC_FUTT_Financial = (byte)('2'),

	};

	public enum TThostFtdcFundEventTypeType:byte
	{

		///转账限额
		THOST_FTDC_FET_Restriction = (byte)('0'),
		///当日转账限额
		THOST_FTDC_FET_TodayRestriction = (byte)('1'),
		///期商流水
		THOST_FTDC_FET_Transfer = (byte)('2'),
		///资金冻结
		THOST_FTDC_FET_Credit = (byte)('3'),
		///投资者可提资金比例
		THOST_FTDC_FET_InvestorWithdrawAlm = (byte)('4'),
		///单个银行帐户转账限额
		THOST_FTDC_FET_BankRestriction = (byte)('5'),
		///银期签约账户
		THOST_FTDC_FET_Accountregister = (byte)('6'),
		///交易所出入金
		THOST_FTDC_FET_ExchangeFundIO = (byte)('7'),
		///投资者出入金
		THOST_FTDC_FET_InvestorFundIO = (byte)('8'),

	};

	public enum TThostFtdcAccountSourceTypeType:byte
	{

		///银期同步
		THOST_FTDC_AST_FBTransfer = (byte)('0'),
		///手工录入
		THOST_FTDC_AST_ManualEntry = (byte)('1'),

	};

	public enum TThostFtdcCodeSourceTypeType:byte
	{

		///统一开户(已规范)
		THOST_FTDC_CST_UnifyAccount = (byte)('0'),
		///手工录入(未规范)
		THOST_FTDC_CST_ManualEntry = (byte)('1'),

	};

	public enum TThostFtdcUserRangeType:byte
	{

		///所有
		THOST_FTDC_UR_All = (byte)('0'),
		///单一操作员
		THOST_FTDC_UR_Single = (byte)('1'),

	};

	public enum TThostFtdcByGroupType:byte
	{

		///按投资者统计
		THOST_FTDC_BG_Investor = (byte)('2'),
		///按类统计
		THOST_FTDC_BG_Group = (byte)('1'),

	};

	public enum TThostFtdcTradeSumStatModeType:byte
	{

		///按合约统计
		THOST_FTDC_TSSM_Instrument = (byte)('1'),
		///按产品统计
		THOST_FTDC_TSSM_Product = (byte)('2'),
		///按交易所统计
		THOST_FTDC_TSSM_Exchange = (byte)('3'),

	};

	public enum TThostFtdcExprSetModeType:byte
	{

		///相对已有规则设置
		THOST_FTDC_ESM_Relative = (byte)('1'),
		///典型设置
		THOST_FTDC_ESM_Typical = (byte)('2'),

	};

	public enum TThostFtdcRateInvestorRangeType:byte
	{

		///公司标准
		THOST_FTDC_RIR_All = (byte)('1'),
		///模板
		THOST_FTDC_RIR_Model = (byte)('2'),
		///单一投资者
		THOST_FTDC_RIR_Single = (byte)('3'),

	};

	public enum TThostFtdcSyncDataStatusType:byte
	{

		///未同步
		THOST_FTDC_SDS_Initialize = (byte)('0'),
		///同步中
		THOST_FTDC_SDS_Settlementing = (byte)('1'),
		///已同步
		THOST_FTDC_SDS_Settlemented = (byte)('2'),

	};

	public enum TThostFtdcTradeSourceType:byte
	{

		///来自交易所普通回报
		THOST_FTDC_TSRC_NORMAL = (byte)('0'),
		///来自查询
		THOST_FTDC_TSRC_QUERY = (byte)('1'),

	};

	public enum TThostFtdcFlexStatModeType:byte
	{

		///产品统计
		THOST_FTDC_FSM_Product = (byte)('1'),
		///交易所统计
		THOST_FTDC_FSM_Exchange = (byte)('2'),
		///统计所有
		THOST_FTDC_FSM_All = (byte)('3'),

	};

	public enum TThostFtdcByInvestorRangeType:byte
	{

		///属性统计
		THOST_FTDC_BIR_Property = (byte)('1'),
		///统计所有
		THOST_FTDC_BIR_All = (byte)('2'),

	};

	public enum TThostFtdcPropertyInvestorRangeType:byte
	{

		///所有
		THOST_FTDC_PIR_All = (byte)('1'),
		///投资者属性
		THOST_FTDC_PIR_Property = (byte)('2'),
		///单一投资者
		THOST_FTDC_PIR_Single = (byte)('3'),

	};

	public enum TThostFtdcFileStatusType:byte
	{

		///未生成
		THOST_FTDC_FIS_NoCreate = (byte)('0'),
		///已生成
		THOST_FTDC_FIS_Created = (byte)('1'),
		///生成失败
		THOST_FTDC_FIS_Failed = (byte)('2'),

	};

	public enum TThostFtdcFileGenStyleType:byte
	{

		///下发
		THOST_FTDC_FGS_FileTransmit = (byte)('0'),
		///生成
		THOST_FTDC_FGS_FileGen = (byte)('1'),

	};

	public enum TThostFtdcSysOperModeType:byte
	{

		///增加
		THOST_FTDC_SoM_Add = (byte)('1'),
		///修改
		THOST_FTDC_SoM_Update = (byte)('2'),
		///删除
		THOST_FTDC_SoM_Delete = (byte)('3'),
		///复制
		THOST_FTDC_SoM_Copy = (byte)('4'),
		///激活
		THOST_FTDC_SoM_AcTive = (byte)('5'),
		///注销
		THOST_FTDC_SoM_CanCel = (byte)('6'),
		///重置
		THOST_FTDC_SoM_ReSet = (byte)('7'),

	};

	public enum TThostFtdcSysOperTypeType:byte
	{

		///修改操作员密码
		THOST_FTDC_SoT_UpdatePassword = (byte)('0'),
		///操作员组织架构关系
		THOST_FTDC_SoT_UserDepartment = (byte)('1'),
		///角色管理
		THOST_FTDC_SoT_RoleManager = (byte)('2'),
		///角色功能设置
		THOST_FTDC_SoT_RoleFunction = (byte)('3'),
		///基础参数设置
		THOST_FTDC_SoT_BaseParam = (byte)('4'),
		///设置操作员
		THOST_FTDC_SoT_SetUserID = (byte)('5'),
		///用户角色设置
		THOST_FTDC_SoT_SetUserRole = (byte)('6'),
		///用户IP限制
		THOST_FTDC_SoT_UserIpRestriction = (byte)('7'),
		///组织架构管理
		THOST_FTDC_SoT_DepartmentManager = (byte)('8'),
		///组织架构向查询分类复制
		THOST_FTDC_SoT_DepartmentCopy = (byte)('9'),
		///交易编码管理
		THOST_FTDC_SoT_Tradingcode = (byte)('A'),
		///投资者状态维护
		THOST_FTDC_SoT_InvestorStatus = (byte)('B'),
		///投资者权限管理
		THOST_FTDC_SoT_InvestorAuthority = (byte)('C'),
		///属性设置
		THOST_FTDC_SoT_PropertySet = (byte)('D'),
		///重置投资者密码
		THOST_FTDC_SoT_ReSetInvestorPasswd = (byte)('E'),
		///投资者个性信息维护
		THOST_FTDC_SoT_InvestorPersonalityInfo = (byte)('F'),

	};

	public enum TThostFtdcCSRCDataQueyTypeType:byte
	{

		///查询当前交易日报送的数据
		THOST_FTDC_CSRCQ_Current = (byte)('0'),
		///查询历史报送的代理经纪公司的数据
		THOST_FTDC_CSRCQ_History = (byte)('1'),

	};

	public enum TThostFtdcFreezeStatusType:byte
	{

		///活跃
		THOST_FTDC_FRS_Normal = (byte)('1'),
		///休眠
		THOST_FTDC_FRS_Freeze = (byte)('0'),

	};

	public enum TThostFtdcStandardStatusType:byte
	{

		///已规范
		THOST_FTDC_STST_Standard = (byte)('0'),
		///未规范
		THOST_FTDC_STST_NonStandard = (byte)('1'),

	};

	public enum TThostFtdcRightParamTypeType:byte
	{

		///休眠户
		THOST_FTDC_RPT_Freeze = (byte)('1'),
		///激活休眠户
		THOST_FTDC_RPT_FreezeActive = (byte)('2'),
		///开仓权限限制
		THOST_FTDC_RPT_OpenLimit = (byte)('3'),
		///解除开仓权限限制
		THOST_FTDC_RPT_RelieveOpenLimit = (byte)('4'),

	};

	public enum TThostFtdcDataStatusType:byte
	{

		///正常
		THOST_FTDC_AMLDS_Normal = (byte)('0'),
		///已删除
		THOST_FTDC_AMLDS_Deleted = (byte)('1'),

	};

	public enum TThostFtdcAMLCheckStatusType:byte
	{

		///未复核
		THOST_FTDC_AMLCHS_Init = (byte)('0'),
		///复核中
		THOST_FTDC_AMLCHS_Checking = (byte)('1'),
		///已复核
		THOST_FTDC_AMLCHS_Checked = (byte)('2'),
		///拒绝上报
		THOST_FTDC_AMLCHS_RefuseReport = (byte)('3'),

	};

	public enum TThostFtdcAmlDateTypeType:byte
	{

		///检查日期
		THOST_FTDC_AMLDT_DrawDay = (byte)('0'),
		///发生日期
		THOST_FTDC_AMLDT_TouchDay = (byte)('1'),

	};

	public enum TThostFtdcAmlCheckLevelType:byte
	{

		///零级审核
		THOST_FTDC_AMLCL_CheckLevel0 = (byte)('0'),
		///一级审核
		THOST_FTDC_AMLCL_CheckLevel1 = (byte)('1'),
		///二级审核
		THOST_FTDC_AMLCL_CheckLevel2 = (byte)('2'),
		///三级审核
		THOST_FTDC_AMLCL_CheckLevel3 = (byte)('3'),

	};

	public enum TThostFtdcExportFileTypeType:byte
	{

		///CSV
		THOST_FTDC_EFT_CSV = (byte)('0'),
		///Excel
		THOST_FTDC_EFT_EXCEL = (byte)('1'),
		///DBF
		THOST_FTDC_EFT_DBF = (byte)('2'),

	};

	public enum TThostFtdcSettleManagerTypeType:byte
	{

		///结算前准备
		THOST_FTDC_SMT_Before = (byte)('1'),
		///结算
		THOST_FTDC_SMT_Settlement = (byte)('2'),
		///结算后核对
		THOST_FTDC_SMT_After = (byte)('3'),
		///结算后处理
		THOST_FTDC_SMT_Settlemented = (byte)('4'),

	};

	public enum TThostFtdcSettleManagerLevelType:byte
	{

		///必要
		THOST_FTDC_SML_Must = (byte)('1'),
		///警告
		THOST_FTDC_SML_Alarm = (byte)('2'),
		///提示
		THOST_FTDC_SML_Prompt = (byte)('3'),
		///不检查
		THOST_FTDC_SML_Ignore = (byte)('4'),

	};

	public enum TThostFtdcSettleManagerGroupType:byte
	{

		///交易所核对
		THOST_FTDC_SMG_Exhcange = (byte)('1'),
		///内部核对
		THOST_FTDC_SMG_ASP = (byte)('2'),
		///上报数据核对
		THOST_FTDC_SMG_CSRC = (byte)('3'),

	};

	public enum TThostFtdcLimitUseTypeType:byte
	{

		///可重复使用
		THOST_FTDC_LUT_Repeatable = (byte)('1'),
		///不可重复使用
		THOST_FTDC_LUT_Unrepeatable = (byte)('2'),

	};

	public enum TThostFtdcDataResourceType:byte
	{

		///本系统
		THOST_FTDC_DAR_Settle = (byte)('1'),
		///交易所
		THOST_FTDC_DAR_Exchange = (byte)('2'),
		///报送数据
		THOST_FTDC_DAR_CSRC = (byte)('3'),

	};

	public enum TThostFtdcMarginTypeType:byte
	{

		///交易所保证金率
		THOST_FTDC_MGT_ExchMarginRate = (byte)('0'),
		///投资者保证金率
		THOST_FTDC_MGT_InstrMarginRate = (byte)('1'),
		///投资者交易保证金率
		THOST_FTDC_MGT_InstrMarginRateTrade = (byte)('2'),

	};

	public enum TThostFtdcActiveTypeType:byte
	{

		///仅当日生效
		THOST_FTDC_ACT_Intraday = (byte)('1'),
		///长期生效
		THOST_FTDC_ACT_Long = (byte)('2'),

	};

	public enum TThostFtdcMarginRateTypeType:byte
	{

		///交易所保证金率
		THOST_FTDC_MRT_Exchange = (byte)('1'),
		///投资者保证金率
		THOST_FTDC_MRT_Investor = (byte)('2'),
		///投资者交易保证金率
		THOST_FTDC_MRT_InvestorTrade = (byte)('3'),

	};

	public enum TThostFtdcBackUpStatusType:byte
	{

		///未生成备份数据
		THOST_FTDC_BUS_UnBak = (byte)('0'),
		///备份数据生成中
		THOST_FTDC_BUS_BakUp = (byte)('1'),
		///已生成备份数据
		THOST_FTDC_BUS_BakUped = (byte)('2'),
		///备份数据失败
		THOST_FTDC_BUS_BakFail = (byte)('3'),

	};

	public enum TThostFtdcInitSettlementType:byte
	{

		///结算初始化未开始
		THOST_FTDC_SIS_UnInitialize = (byte)('0'),
		///结算初始化中
		THOST_FTDC_SIS_Initialize = (byte)('1'),
		///结算初始化完成
		THOST_FTDC_SIS_Initialized = (byte)('2'),

	};

	public enum TThostFtdcReportStatusType:byte
	{

		///未生成报表数据
		THOST_FTDC_SRS_NoCreate = (byte)('0'),
		///报表数据生成中
		THOST_FTDC_SRS_Create = (byte)('1'),
		///已生成报表数据
		THOST_FTDC_SRS_Created = (byte)('2'),
		///生成报表数据失败
		THOST_FTDC_SRS_CreateFail = (byte)('3'),

	};

	public enum TThostFtdcSaveStatusType:byte
	{

		///归档未完成
		THOST_FTDC_SSS_UnSaveData = (byte)('0'),
		///归档完成
		THOST_FTDC_SSS_SaveDatad = (byte)('1'),

	};

	public enum TThostFtdcSettArchiveStatusType:byte
	{

		///未归档数据
		THOST_FTDC_SAS_UnArchived = (byte)('0'),
		///数据归档中
		THOST_FTDC_SAS_Archiving = (byte)('1'),
		///已归档数据
		THOST_FTDC_SAS_Archived = (byte)('2'),
		///归档数据失败
		THOST_FTDC_SAS_ArchiveFail = (byte)('3'),

	};

	public enum TThostFtdcCTPTypeType:byte
	{

		///未知类型
		THOST_FTDC_CTPT_Unkown = (byte)('0'),
		///主中心
		THOST_FTDC_CTPT_MainCenter = (byte)('1'),
		///备中心
		THOST_FTDC_CTPT_BackUp = (byte)('2'),

	};

	public enum TThostFtdcCloseDealTypeType:byte
	{

		///正常
		THOST_FTDC_CDT_Normal = (byte)('0'),
		///投机平仓优先
		THOST_FTDC_CDT_SpecFirst = (byte)('1'),

	};

	public enum TThostFtdcMortgageFundUseRangeType:byte
	{

		///不能使用
		THOST_FTDC_MFUR_None = (byte)('0'),
		///用于保证金
		THOST_FTDC_MFUR_Margin = (byte)('1'),
		///用于手续费、盈亏、保证金
		THOST_FTDC_MFUR_All = (byte)('2'),
		///人民币方案3
		THOST_FTDC_MFUR_CNY3 = (byte)('3'),

	};

	public enum TThostFtdcSpecProductTypeType:byte
	{

		///郑商所套保产品
		THOST_FTDC_SPT_CzceHedge = (byte)('1'),
		///货币质押产品
		THOST_FTDC_SPT_IneForeignCurrency = (byte)('2'),
		///大连短线开平仓产品
		THOST_FTDC_SPT_DceOpenClose = (byte)('3'),

	};

	public enum TThostFtdcFundMortgageTypeType:byte
	{

		///质押
		THOST_FTDC_FMT_Mortgage = (byte)('1'),
		///解质
		THOST_FTDC_FMT_Redemption = (byte)('2'),

	};

	public enum TThostFtdcAccountSettlementParamIDType:byte
	{

		///基础保证金
		THOST_FTDC_ASPI_BaseMargin = (byte)('1'),
		///最低权益标准
		THOST_FTDC_ASPI_LowestInterest = (byte)('2'),

	};

	public enum TThostFtdcFundMortDirectionType:byte
	{

		///货币质入
		THOST_FTDC_FMD_In = (byte)('1'),
		///货币质出
		THOST_FTDC_FMD_Out = (byte)('2'),

	};

	public enum TThostFtdcBusinessClassType:byte
	{

		///盈利
		THOST_FTDC_BT_Profit = (byte)('0'),
		///亏损
		THOST_FTDC_BT_Loss = (byte)('1'),
		///其他
		THOST_FTDC_BT_Other = (byte)('Z'),

	};

	public enum TThostFtdcSwapSourceTypeType:byte
	{

		///手工
		THOST_FTDC_SST_Manual = (byte)('0'),
		///自动生成
		THOST_FTDC_SST_Automatic = (byte)('1'),

	};

	public enum TThostFtdcCurrExDirectionType:byte
	{

		///结汇
		THOST_FTDC_CED_Settlement = (byte)('0'),
		///售汇
		THOST_FTDC_CED_Sale = (byte)('1'),

	};

	public enum TThostFtdcCurrencySwapStatusType:byte
	{

		///已录入
		THOST_FTDC_CSS_Entry = (byte)('1'),
		///已审核
		THOST_FTDC_CSS_Approve = (byte)('2'),
		///已拒绝
		THOST_FTDC_CSS_Refuse = (byte)('3'),
		///已撤销
		THOST_FTDC_CSS_Revoke = (byte)('4'),
		///已发送
		THOST_FTDC_CSS_Send = (byte)('5'),
		///换汇成功
		THOST_FTDC_CSS_Success = (byte)('6'),
		///换汇失败
		THOST_FTDC_CSS_Failure = (byte)('7'),

	};

	public enum TThostFtdcReqFlagType:byte
	{

		///未发送
		THOST_FTDC_REQF_NoSend = (byte)('0'),
		///发送成功
		THOST_FTDC_REQF_SendSuccess = (byte)('1'),
		///发送失败
		THOST_FTDC_REQF_SendFailed = (byte)('2'),
		///等待重发
		THOST_FTDC_REQF_WaitReSend = (byte)('3'),

	};

	public enum TThostFtdcResFlagType:byte
	{

		///成功
		THOST_FTDC_RESF_Success = (byte)('0'),
		///账户余额不足
		THOST_FTDC_RESF_InsuffiCient = (byte)('1'),
		///交易结果未知
		THOST_FTDC_RESF_UnKnown = (byte)('8'),

	};

	public enum TThostFtdcExStatusType:byte
	{

		///修改前
		THOST_FTDC_EXS_Before = (byte)('0'),
		///修改后
		THOST_FTDC_EXS_After = (byte)('1'),

	};

	public enum TThostFtdcClientRegionType:byte
	{

		///国内客户
		THOST_FTDC_CR_Domestic = (byte)('1'),
		///港澳台客户
		THOST_FTDC_CR_GMT = (byte)('2'),
		///国外客户
		THOST_FTDC_CR_Foreign = (byte)('3'),

	};

	public enum TThostFtdcHasBoardType:byte
	{

		///没有
		THOST_FTDC_HB_No = (byte)('0'),
		///有
		THOST_FTDC_HB_Yes = (byte)('1'),

	};

	public enum TThostFtdcStartModeType:byte
	{

		///正常
		THOST_FTDC_SM_Normal = (byte)('1'),
		///应急
		THOST_FTDC_SM_Emerge = (byte)('2'),
		///恢复
		THOST_FTDC_SM_Restore = (byte)('3'),

	};

	public enum TThostFtdcTemplateTypeType:byte
	{

		///全量
		THOST_FTDC_TPT_Full = (byte)('1'),
		///增量
		THOST_FTDC_TPT_Increment = (byte)('2'),
		///备份
		THOST_FTDC_TPT_BackUp = (byte)('3'),

	};

	public enum TThostFtdcLoginModeType:byte
	{

		///交易
		THOST_FTDC_LM_Trade = (byte)('0'),
		///转账
		THOST_FTDC_LM_Transfer = (byte)('1'),

	};

	public enum TThostFtdcPromptTypeType:byte
	{

		///合约上下市
		THOST_FTDC_CPT_Instrument = (byte)('1'),
		///保证金分段生效
		THOST_FTDC_CPT_Margin = (byte)('2'),

	};

	public enum TThostFtdcHasTrusteeType:byte
	{

		///有
		THOST_FTDC_HT_Yes = (byte)('1'),
		///没有
		THOST_FTDC_HT_No = (byte)('0'),

	};

	public enum TThostFtdcAmTypeType:byte
	{

		///银行
		THOST_FTDC_AMT_Bank = (byte)('1'),
		///证券公司
		THOST_FTDC_AMT_Securities = (byte)('2'),
		///基金公司
		THOST_FTDC_AMT_Fund = (byte)('3'),
		///保险公司
		THOST_FTDC_AMT_Insurance = (byte)('4'),
		///信托公司
		THOST_FTDC_AMT_Trust = (byte)('5'),
		///其他
		THOST_FTDC_AMT_Other = (byte)('9'),

	};

	public enum TThostFtdcCSRCFundIOTypeType:byte
	{

		///出入金
		THOST_FTDC_CFIOT_FundIO = (byte)('0'),
		///银期换汇
		THOST_FTDC_CFIOT_SwapCurrency = (byte)('1'),

	};

	public enum TThostFtdcCusAccountTypeType:byte
	{

		///期货结算账户
		THOST_FTDC_CAT_Futures = (byte)('1'),
		///纯期货资管业务下的资管结算账户
		THOST_FTDC_CAT_AssetmgrFuture = (byte)('2'),
		///综合类资管业务下的期货资管托管账户
		THOST_FTDC_CAT_AssetmgrTrustee = (byte)('3'),
		///综合类资管业务下的资金中转账户
		THOST_FTDC_CAT_AssetmgrTransfer = (byte)('4'),

	};

	public enum TThostFtdcLanguageTypeType:byte
	{

		///中文
		THOST_FTDC_LT_Chinese = (byte)('1'),
		///英文
		THOST_FTDC_LT_English = (byte)('2'),

	};

	public enum TThostFtdcAssetmgrClientTypeType:byte
	{

		///个人资管客户
		THOST_FTDC_AMCT_Person = (byte)('1'),
		///单位资管客户
		THOST_FTDC_AMCT_Organ = (byte)('2'),
		///特殊单位资管客户
		THOST_FTDC_AMCT_SpecialOrgan = (byte)('4'),

	};

	public enum TThostFtdcAssetmgrTypeType:byte
	{

		///期货类
		THOST_FTDC_ASST_Futures = (byte)('3'),
		///综合类
		THOST_FTDC_ASST_SpecialOrgan = (byte)('4'),

	};

	public enum TThostFtdcCheckInstrTypeType:byte
	{

		///合约交易所不存在
		THOST_FTDC_CIT_HasExch = (byte)('0'),
		///合约本系统不存在
		THOST_FTDC_CIT_HasATP = (byte)('1'),
		///合约比较不一致
		THOST_FTDC_CIT_HasDiff = (byte)('2'),

	};

	public enum TThostFtdcDeliveryTypeType:byte
	{

		///手工交割
		THOST_FTDC_DT_HandDeliv = (byte)('1'),
		///到期交割
		THOST_FTDC_DT_PersonDeliv = (byte)('2'),

	};

	public enum TThostFtdcMaxMarginSideAlgorithmType:byte
	{

		///不使用大额单边保证金算法
		THOST_FTDC_MMSA_NO = (byte)('0'),
		///使用大额单边保证金算法
		THOST_FTDC_MMSA_YES = (byte)('1'),

	};

	public enum TThostFtdcDAClientTypeType:byte
	{

		///自然人
		THOST_FTDC_CACT_Person = (byte)('0'),
		///法人
		THOST_FTDC_CACT_Company = (byte)('1'),
		///其他
		THOST_FTDC_CACT_Other = (byte)('2'),

	};

	public enum TThostFtdcUOAAssetmgrTypeType:byte
	{

		///期货类
		THOST_FTDC_UOAAT_Futures = (byte)('1'),
		///综合类
		THOST_FTDC_UOAAT_SpecialOrgan = (byte)('2'),

	};

	public enum TThostFtdcDirectionEnType:byte
	{

		///Buy
		THOST_FTDC_DEN_Buy = (byte)('0'),
		///Sell
		THOST_FTDC_DEN_Sell = (byte)('1'),

	};

	public enum TThostFtdcOffsetFlagEnType:byte
	{

		///Position Opening
		THOST_FTDC_OFEN_Open = (byte)('0'),
		///Position Close
		THOST_FTDC_OFEN_Close = (byte)('1'),
		///Forced Liquidation
		THOST_FTDC_OFEN_ForceClose = (byte)('2'),
		///Close Today
		THOST_FTDC_OFEN_CloseToday = (byte)('3'),
		///Close Prev.
		THOST_FTDC_OFEN_CloseYesterday = (byte)('4'),
		///Forced Reduction
		THOST_FTDC_OFEN_ForceOff = (byte)('5'),
		///Local Forced Liquidation
		THOST_FTDC_OFEN_LocalForceClose = (byte)('6'),

	};

	public enum TThostFtdcHedgeFlagEnType:byte
	{

		///Speculation
		THOST_FTDC_HFEN_Speculation = (byte)('1'),
		///Arbitrage
		THOST_FTDC_HFEN_Arbitrage = (byte)('2'),
		///Hedge
		THOST_FTDC_HFEN_Hedge = (byte)('3'),

	};

	public enum TThostFtdcFundIOTypeEnType:byte
	{

		///Deposit/Withdrawal
		THOST_FTDC_FIOTEN_FundIO = (byte)('1'),
		///Bank-Futures Transfer
		THOST_FTDC_FIOTEN_Transfer = (byte)('2'),
		///Bank-Futures FX Exchange
		THOST_FTDC_FIOTEN_SwapCurrency = (byte)('3'),

	};

	public enum TThostFtdcFundTypeEnType:byte
	{

		///Bank Deposit
		THOST_FTDC_FTEN_Deposite = (byte)('1'),
		///Payment/Fee
		THOST_FTDC_FTEN_ItemFund = (byte)('2'),
		///Brokerage Adj
		THOST_FTDC_FTEN_Company = (byte)('3'),
		///Internal Transfer
		THOST_FTDC_FTEN_InnerTransfer = (byte)('4'),

	};

	public enum TThostFtdcFundDirectionEnType:byte
	{

		///Deposit
		THOST_FTDC_FDEN_In = (byte)('1'),
		///Withdrawal
		THOST_FTDC_FDEN_Out = (byte)('2'),

	};

	public enum TThostFtdcFundMortDirectionEnType:byte
	{

		///Pledge
		THOST_FTDC_FMDEN_In = (byte)('1'),
		///Redemption
		THOST_FTDC_FMDEN_Out = (byte)('2'),

	};

	public enum TThostFtdcOptionsTypeType:byte
	{

		///看涨
		THOST_FTDC_CP_CallOptions = (byte)('1'),
		///看跌
		THOST_FTDC_CP_PutOptions = (byte)('2'),

	};

	public enum TThostFtdcStrikeModeType:byte
	{

		///欧式
		THOST_FTDC_STM_Continental = (byte)('0'),
		///美式
		THOST_FTDC_STM_American = (byte)('1'),
		///百慕大
		THOST_FTDC_STM_Bermuda = (byte)('2'),

	};

	public enum TThostFtdcStrikeTypeType:byte
	{

		///自身对冲
		THOST_FTDC_STT_Hedge = (byte)('0'),
		///匹配执行
		THOST_FTDC_STT_Match = (byte)('1'),

	};

	public enum TThostFtdcApplyTypeType:byte
	{

		///不执行数量
		THOST_FTDC_APPT_NotStrikeNum = (byte)('4'),

	};

	public enum TThostFtdcGiveUpDataSourceType:byte
	{

		///系统生成
		THOST_FTDC_GUDS_Gen = (byte)('0'),
		///手工添加
		THOST_FTDC_GUDS_Hand = (byte)('1'),

	};

	public enum TThostFtdcExecResultType:byte
	{

		///没有执行
		THOST_FTDC_OER_NoExec = (byte)('n'),
		///已经取消
		THOST_FTDC_OER_Canceled = (byte)('c'),
		///执行成功
		THOST_FTDC_OER_OK = (byte)('0'),
		///期权持仓不够
		THOST_FTDC_OER_NoPosition = (byte)('1'),
		///资金不够
		THOST_FTDC_OER_NoDeposit = (byte)('2'),
		///会员不存在
		THOST_FTDC_OER_NoParticipant = (byte)('3'),
		///客户不存在
		THOST_FTDC_OER_NoClient = (byte)('4'),
		///合约不存在
		THOST_FTDC_OER_NoInstrument = (byte)('6'),
		///没有执行权限
		THOST_FTDC_OER_NoRight = (byte)('7'),
		///不合理的数量
		THOST_FTDC_OER_InvalidVolume = (byte)('8'),
		///没有足够的历史成交
		THOST_FTDC_OER_NoEnoughHistoryTrade = (byte)('9'),
		///未知
		THOST_FTDC_OER_Unknown = (byte)('a'),

	};

	public enum TThostFtdcCombinationTypeType:byte
	{

		///期货组合
		THOST_FTDC_COMBT_Future = (byte)('0'),
		///垂直价差BUL
		THOST_FTDC_COMBT_BUL = (byte)('1'),
		///垂直价差BER
		THOST_FTDC_COMBT_BER = (byte)('2'),
		///跨式组合
		THOST_FTDC_COMBT_STD = (byte)('3'),
		///宽跨式组合
		THOST_FTDC_COMBT_STG = (byte)('4'),
		///备兑组合
		THOST_FTDC_COMBT_PRT = (byte)('5'),
		///时间价差组合
		THOST_FTDC_COMBT_CAS = (byte)('6'),
		///期权对锁组合
		THOST_FTDC_COMBT_OPL = (byte)('7'),
		///买备兑组合
		THOST_FTDC_COMBT_BFO = (byte)('8'),
		///买入期权垂直价差组合
		THOST_FTDC_COMBT_BLS = (byte)('9'),
		///卖出期权垂直价差组合
		THOST_FTDC_COMBT_BES = (byte)('a'),

	};

	public enum TThostFtdcDceCombinationTypeType:byte
	{

		///期货对锁组合
		THOST_FTDC_DCECOMBT_SPL = (byte)('0'),
		///期权对锁组合
		THOST_FTDC_DCECOMBT_OPL = (byte)('1'),
		///期货跨期组合
		THOST_FTDC_DCECOMBT_SP = (byte)('2'),
		///期货跨品种组合
		THOST_FTDC_DCECOMBT_SPC = (byte)('3'),
		///买入期权垂直价差组合
		THOST_FTDC_DCECOMBT_BLS = (byte)('4'),
		///卖出期权垂直价差组合
		THOST_FTDC_DCECOMBT_BES = (byte)('5'),
		///期权日历价差组合
		THOST_FTDC_DCECOMBT_CAS = (byte)('6'),
		///期权跨式组合
		THOST_FTDC_DCECOMBT_STD = (byte)('7'),
		///期权宽跨式组合
		THOST_FTDC_DCECOMBT_STG = (byte)('8'),
		///买入期货期权组合
		THOST_FTDC_DCECOMBT_BFO = (byte)('9'),
		///卖出期货期权组合
		THOST_FTDC_DCECOMBT_SFO = (byte)('a'),

	};

	public enum TThostFtdcOptionRoyaltyPriceTypeType:byte
	{

		///昨结算价
		THOST_FTDC_ORPT_PreSettlementPrice = (byte)('1'),
		///开仓价
		THOST_FTDC_ORPT_OpenPrice = (byte)('4'),
		///最新价与昨结算价较大值
		THOST_FTDC_ORPT_MaxPreSettlementPrice = (byte)('5'),

	};

	public enum TThostFtdcBalanceAlgorithmType:byte
	{

		///不计算期权市值盈亏
		THOST_FTDC_BLAG_Default = (byte)('1'),
		///计算期权市值亏损
		THOST_FTDC_BLAG_IncludeOptValLost = (byte)('2'),

	};

	public enum TThostFtdcActionTypeType:byte
	{

		///执行
		THOST_FTDC_ACTP_Exec = (byte)('1'),
		///放弃
		THOST_FTDC_ACTP_Abandon = (byte)('2'),

	};

	public enum TThostFtdcForQuoteStatusType:byte
	{

		///已经提交
		THOST_FTDC_FQST_Submitted = (byte)('a'),
		///已经接受
		THOST_FTDC_FQST_Accepted = (byte)('b'),
		///已经被拒绝
		THOST_FTDC_FQST_Rejected = (byte)('c'),

	};

	public enum TThostFtdcValueMethodType:byte
	{

		///按绝对值
		THOST_FTDC_VM_Absolute = (byte)('0'),
		///按比率
		THOST_FTDC_VM_Ratio = (byte)('1'),

	};

	public enum TThostFtdcExecOrderPositionFlagType:byte
	{

		///保留
		THOST_FTDC_EOPF_Reserve = (byte)('0'),
		///不保留
		THOST_FTDC_EOPF_UnReserve = (byte)('1'),

	};

	public enum TThostFtdcExecOrderCloseFlagType:byte
	{

		///自动平仓
		THOST_FTDC_EOCF_AutoClose = (byte)('0'),
		///免于自动平仓
		THOST_FTDC_EOCF_NotToClose = (byte)('1'),

	};

	public enum TThostFtdcProductTypeType:byte
	{

		///期货
		THOST_FTDC_PTE_Futures = (byte)('1'),
		///期权
		THOST_FTDC_PTE_Options = (byte)('2'),

	};

	public enum TThostFtdcCZCEUploadFileNameType:byte
	{

		///^\d{8}_zz_\d{4}
		THOST_FTDC_CUFN_CUFN_O = (byte)('O'),
		///^\d{8}成交表
		THOST_FTDC_CUFN_CUFN_T = (byte)('T'),
		///^\d{8}单腿持仓表new
		THOST_FTDC_CUFN_CUFN_P = (byte)('P'),
		///^\d{8}非平仓了结表
		THOST_FTDC_CUFN_CUFN_N = (byte)('N'),
		///^\d{8}平仓表
		THOST_FTDC_CUFN_CUFN_L = (byte)('L'),
		///^\d{8}资金表
		THOST_FTDC_CUFN_CUFN_F = (byte)('F'),
		///^\d{8}组合持仓表
		THOST_FTDC_CUFN_CUFN_C = (byte)('C'),
		///^\d{8}保证金参数表
		THOST_FTDC_CUFN_CUFN_M = (byte)('M'),

	};

	public enum TThostFtdcDCEUploadFileNameType:byte
	{

		///^\d{8}_dl_\d{3}
		THOST_FTDC_DUFN_DUFN_O = (byte)('O'),
		///^\d{8}_成交表
		THOST_FTDC_DUFN_DUFN_T = (byte)('T'),
		///^\d{8}_持仓表
		THOST_FTDC_DUFN_DUFN_P = (byte)('P'),
		///^\d{8}_资金结算表
		THOST_FTDC_DUFN_DUFN_F = (byte)('F'),
		///^\d{8}_优惠组合持仓明细表
		THOST_FTDC_DUFN_DUFN_C = (byte)('C'),
		///^\d{8}_持仓明细表
		THOST_FTDC_DUFN_DUFN_D = (byte)('D'),
		///^\d{8}_保证金参数表
		THOST_FTDC_DUFN_DUFN_M = (byte)('M'),
		///^\d{8}_期权执行表
		THOST_FTDC_DUFN_DUFN_S = (byte)('S'),

	};

	public enum TThostFtdcSHFEUploadFileNameType:byte
	{

		///^\d{4}_\d{8}_\d{8}_DailyFundChg
		THOST_FTDC_SUFN_SUFN_O = (byte)('O'),
		///^\d{4}_\d{8}_\d{8}_Trade
		THOST_FTDC_SUFN_SUFN_T = (byte)('T'),
		///^\d{4}_\d{8}_\d{8}_SettlementDetail
		THOST_FTDC_SUFN_SUFN_P = (byte)('P'),
		///^\d{4}_\d{8}_\d{8}_Capital
		THOST_FTDC_SUFN_SUFN_F = (byte)('F'),

	};

	public enum TThostFtdcCFFEXUploadFileNameType:byte
	{

		///^\d{4}_SG\d{1}_\d{8}_\d{1}_Trade
		THOST_FTDC_CFUFN_SUFN_T = (byte)('T'),
		///^\d{4}_SG\d{1}_\d{8}_\d{1}_SettlementDetail
		THOST_FTDC_CFUFN_SUFN_P = (byte)('P'),
		///^\d{4}_SG\d{1}_\d{8}_\d{1}_Capital
		THOST_FTDC_CFUFN_SUFN_F = (byte)('F'),
		///^\d{4}_SG\d{1}_\d{8}_\d{1}_OptionExec
		THOST_FTDC_CFUFN_SUFN_S = (byte)('S'),

	};

	public enum TThostFtdcCombDirectionType:byte
	{

		///申请组合
		THOST_FTDC_CMDR_Comb = (byte)('0'),
		///申请拆分
		THOST_FTDC_CMDR_UnComb = (byte)('1'),
		///操作员删组合单
		THOST_FTDC_CMDR_DelComb = (byte)('2'),

	};

	public enum TThostFtdcStrikeOffsetTypeType:byte
	{

		///实值额
		THOST_FTDC_STOV_RealValue = (byte)('1'),
		///盈利额
		THOST_FTDC_STOV_ProfitValue = (byte)('2'),
		///实值比例
		THOST_FTDC_STOV_RealRatio = (byte)('3'),
		///盈利比例
		THOST_FTDC_STOV_ProfitRatio = (byte)('4'),

	};

	public enum TThostFtdcReserveOpenAccStasType:byte
	{

		///等待处理中
		THOST_FTDC_ROAST_Processing = (byte)('0'),
		///已撤销
		THOST_FTDC_ROAST_Cancelled = (byte)('1'),
		///已开户
		THOST_FTDC_ROAST_Opened = (byte)('2'),
		///无效请求
		THOST_FTDC_ROAST_Invalid = (byte)('3'),

	};

	public enum TThostFtdcWeakPasswordSourceType:byte
	{

		///弱密码库
		THOST_FTDC_WPSR_Lib = (byte)('1'),
		///手工录入
		THOST_FTDC_WPSR_Manual = (byte)('2'),

	};

	public enum TThostFtdcOptSelfCloseFlagType:byte
	{

		///自对冲期权仓位
		THOST_FTDC_OSCF_CloseSelfOptionPosition = (byte)('1'),
		///保留期权仓位
		THOST_FTDC_OSCF_ReserveOptionPosition = (byte)('2'),
		///自对冲卖方履约后的期货仓位
		THOST_FTDC_OSCF_SellCloseSelfFuturePosition = (byte)('3'),
		///保留卖方履约后的期货仓位
		THOST_FTDC_OSCF_ReserveFuturePosition = (byte)('4'),

	};

	public enum TThostFtdcBizTypeType:byte
	{

		///期货
		THOST_FTDC_BZTP_Future = (byte)('1'),
		///证券
		THOST_FTDC_BZTP_Stock = (byte)('2'),

	};

	public enum TThostFtdcAppTypeType:byte
	{

		///直连的投资者
		THOST_FTDC_APP_TYPE_Investor = (byte)('1'),
		///为每个投资者都创建连接的中继
		THOST_FTDC_APP_TYPE_InvestorRelay = (byte)('2'),
		///所有投资者共享一个操作员连接的中继
		THOST_FTDC_APP_TYPE_OperatorRelay = (byte)('3'),
		///未知
		THOST_FTDC_APP_TYPE_UnKnown = (byte)('4'),

	};

	public enum TThostFtdcResponseValueType:byte
	{

		///检查成功
		THOST_FTDC_RV_Right = (byte)('0'),
		///检查失败
		THOST_FTDC_RV_Refuse = (byte)('1'),

	};

	public enum TThostFtdcOTCTradeTypeType:byte
	{

		///大宗交易
		THOST_FTDC_OTC_TRDT_Block = (byte)('0'),
		///期转现
		THOST_FTDC_OTC_TRDT_EFP = (byte)('1'),

	};

	public enum TThostFtdcMatchTypeType:byte
	{

		///基点价值
		THOST_FTDC_OTC_MT_DV01 = (byte)('1'),
		///面值
		THOST_FTDC_OTC_MT_ParValue = (byte)('2'),

	};

	public enum TThostFtdcAuthTypeType:byte
	{

		///白名单校验
		THOST_FTDC_AU_WHITE = (byte)('0'),
		///黑名单校验
		THOST_FTDC_AU_BLACK = (byte)('1'),

	};

	public enum TThostFtdcClassTypeType:byte
	{

		///所有合约
		THOST_FTDC_INS_ALL = (byte)('0'),
		///期货、即期、期转现、Tas、金属指数合约
		THOST_FTDC_INS_FUTURE = (byte)('1'),
		///期货、现货期权合约
		THOST_FTDC_INS_OPTION = (byte)('2'),
		///组合合约
		THOST_FTDC_INS_COMB = (byte)('3'),

	};

	public enum TThostFtdcTradingTypeType:byte
	{

		///所有状态
		THOST_FTDC_TD_ALL = (byte)('0'),
		///交易
		THOST_FTDC_TD_TRADE = (byte)('1'),
		///非交易
		THOST_FTDC_TD_UNTRADE = (byte)('2'),

	};

	public enum TThostFtdcProductStatusType:byte
	{

		///可交易
		THOST_FTDC_PS_tradeable = (byte)('1'),
		///不可交易
		THOST_FTDC_PS_untradeable = (byte)('2'),

	};

	public enum TThostFtdcSyncDeltaStatusType:byte
	{

		///交易可读
		THOST_FTDC_SDS_Readable = (byte)('1'),
		///交易在读
		THOST_FTDC_SDS_Reading = (byte)('2'),
		///交易读取完成
		THOST_FTDC_SDS_Readend = (byte)('3'),
		///追平失败 交易本地状态结算不存在
		THOST_FTDC_SDS_OptErr = (byte)('e'),

	};

	public enum TThostFtdcActionDirectionType:byte
	{

		///增加
		THOST_FTDC_ACD_Add = (byte)('1'),
		///删除
		THOST_FTDC_ACD_Del = (byte)('2'),
		///更新
		THOST_FTDC_ACD_Upd = (byte)('3'),

	};

	public enum TThostFtdcOrderCancelAlgType:byte
	{

		///轮询席位撤单
		THOST_FTDC_OAC_Balance = (byte)('1'),
		///优先原报单席位撤单
		THOST_FTDC_OAC_OrigFirst = (byte)('2'),

	};

	public enum TThostFtdcOpenLimitControlLevelType:byte
	{

		///不控制
		THOST_FTDC_PLCL_None = (byte)('0'),
		///产品级别
		THOST_FTDC_PLCL_Product = (byte)('1'),
		///合约级别
		THOST_FTDC_PLCL_Inst = (byte)('2'),

	};

	public enum TThostFtdcOrderFreqControlLevelType:byte
	{

		///不控制
		THOST_FTDC_OFCL_None = (byte)('0'),
		///产品级别
		THOST_FTDC_OFCL_Product = (byte)('1'),
		///合约级别
		THOST_FTDC_OFCL_Inst = (byte)('2'),

	};

	public enum TThostFtdcEnumBoolType:byte
	{

		///false
		THOST_FTDC_EBL_False = (byte)('0'),
		///true
		THOST_FTDC_EBL_True = (byte)('1'),

	};

	#endregion Enums


	#region Structs

	///信息分发
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcDisseminationField
	{
		///序列系列号
		public TThostFtdcSequenceSeriesType SequenceSeries;
		///序列号
		public TThostFtdcSequenceNoType SequenceNo;
	}

	///用户登录请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqUserLoginField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///动态密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OneTimePassword;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///终端IP端口
		public TThostFtdcIPPortType ClientIPPort;
		///终端IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientIPAddress;
	}

	///用户登录应答
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspUserLoginField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///登录成功时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LoginTime;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易系统名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcSystemNameType SystemName;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///最大报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType MaxOrderRef;
		///上期所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SHFETime;
		///大商所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType DCETime;
		///郑商所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CZCETime;
		///中金所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType FFEXTime;
		///能源中心时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType INETime;
		///后台版本信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcSysVersionType SysVersion;
	}

	///用户登出请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserLogoutField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///强制交易员退出
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcForceUserLogoutField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///客户端认证请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqAuthenticateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///认证码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcAuthCodeType AuthCode;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
	}

	///客户端认证响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspAuthenticateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
		///App类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAppTypeType AppType;
	}

	///客户端认证信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAuthenticationInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///认证信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAuthInfoType AuthInfo;
		///是否为认证结果
		public TThostFtdcBoolType IsResult;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
		///App类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAppTypeType AppType;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///终端IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientIPAddress;
	}

	///用户登录应答2
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspUserLogin2Field
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///登录成功时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LoginTime;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易系统名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcSystemNameType SystemName;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///最大报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType MaxOrderRef;
		///上期所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SHFETime;
		///大商所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType DCETime;
		///郑商所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CZCETime;
		///中金所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType FFEXTime;
		///能源中心时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType INETime;
		///随机串
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcRandomStringType RandomString;
	}

	///银期转帐报文头
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferHeaderField
	{
		///版本号，常量，1.0
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcVersionType Version;
		///交易代码，必填
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///交易日期，必填，格式：yyyymmdd
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间，必填，格式：hhmmss
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///发起方流水号，N/A
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeSerialType TradeSerial;
		///期货公司代码，必填
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcFutureIDType FutureID;
		///银行代码，根据查询银行得到，必填
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分中心代码，根据查询银行得到，必填
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBrchID;
		///操作员，N/A
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///交易设备类型，N/A
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///记录数，N/A
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcRecordNumType RecordNum;
		///会话编号，N/A
		public TThostFtdcSessionIDType SessionID;
		///请求编号，N/A
		public TThostFtdcRequestIDType RequestID;
	}

	///银行资金转期货请求，TradeCode=202001
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferBankToFutureReqField
	{
		///期货资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
		///密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFuturePwdFlagType FuturePwdFlag;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcFutureAccPwdType FutureAccPwd;
		///转账金额
		public TThostFtdcMoneyType TradeAmt;
		///客户手续费
		public TThostFtdcMoneyType CustFee;
		///币种：RMB-人民币 USD-美圆 HKD-港元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
	}

	///银行资金转期货请求响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferBankToFutureRspField
	{
		///响应代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcRetCodeType RetCode;
		///响应信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcRetInfoType RetInfo;
		///资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
		///转帐金额
		public TThostFtdcMoneyType TradeAmt;
		///应收客户手续费
		public TThostFtdcMoneyType CustFee;
		///币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
	}

	///期货资金转银行请求，TradeCode=202002
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferFutureToBankReqField
	{
		///期货资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
		///密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFuturePwdFlagType FuturePwdFlag;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcFutureAccPwdType FutureAccPwd;
		///转账金额
		public TThostFtdcMoneyType TradeAmt;
		///客户手续费
		public TThostFtdcMoneyType CustFee;
		///币种：RMB-人民币 USD-美圆 HKD-港元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
	}

	///期货资金转银行请求响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferFutureToBankRspField
	{
		///响应代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcRetCodeType RetCode;
		///响应信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcRetInfoType RetInfo;
		///资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
		///转帐金额
		public TThostFtdcMoneyType TradeAmt;
		///应收客户手续费
		public TThostFtdcMoneyType CustFee;
		///币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
	}

	///查询银行资金请求，TradeCode=204002
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferQryBankReqField
	{
		///期货资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
		///密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFuturePwdFlagType FuturePwdFlag;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcFutureAccPwdType FutureAccPwd;
		///币种：RMB-人民币 USD-美圆 HKD-港元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
	}

	///查询银行资金请求响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferQryBankRspField
	{
		///响应代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcRetCodeType RetCode;
		///响应信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcRetInfoType RetInfo;
		///资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
		///银行余额
		public TThostFtdcMoneyType TradeAmt;
		///银行可用余额
		public TThostFtdcMoneyType UseAmt;
		///银行可取余额
		public TThostFtdcMoneyType FetchAmt;
		///币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
	}

	///查询银行交易明细请求，TradeCode=204999
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferQryDetailReqField
	{
		///期货资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType FutureAccount;
	}

	///查询银行交易明细请求响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferQryDetailRspField
	{
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///交易代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///期货流水号
		public TThostFtdcTradeSerialNoType FutureSerial;
		///期货公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcFutureIDType FutureID;
		///资金帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
		public TThostFtdcFutureAccountType FutureAccount;
		///银行流水号
		public TThostFtdcTradeSerialNoType BankSerial;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分中心代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBrchID;
		///银行账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCertCodeType CertCode;
		///货币代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyCodeType CurrencyCode;
		///发生金额
		public TThostFtdcMoneyType TxAmount;
		///有效标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTransferValidFlagType Flag;
	}

	///响应信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspInfoField
	{
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///交易所
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
		public TThostFtdcExchangeNameType ExchangeName;
		///交易所属性
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExchangePropertyType ExchangeProperty;
	}

	///产品
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcProductField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///产品名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcProductNameType ProductName;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcProductClassType ProductClass;
		///合约数量乘数
		public TThostFtdcVolumeMultipleType VolumeMultiple;
		///最小变动价位
		public TThostFtdcPriceType PriceTick;
		///市价单最大下单量
		public TThostFtdcVolumeType MaxMarketOrderVolume;
		///市价单最小下单量
		public TThostFtdcVolumeType MinMarketOrderVolume;
		///限价单最大下单量
		public TThostFtdcVolumeType MaxLimitOrderVolume;
		///限价单最小下单量
		public TThostFtdcVolumeType MinLimitOrderVolume;
		///持仓类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionTypeType PositionType;
		///持仓日期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionDateTypeType PositionDateType;
		///平仓处理类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCloseDealTypeType CloseDealType;
		///交易币种类型
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType TradeCurrencyID;
		///质押资金可用范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMortgageFundUseRangeType MortgageFundUseRange;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///合约基础商品乘数
		public TThostFtdcUnderlyingMultipleType UnderlyingMultiple;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///交易所产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ExchangeProductID;
		///开仓量限制粒度
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOpenLimitControlLevelType OpenLimitControlLevel;
		///报单频率控制粒度
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderFreqControlLevelType OrderFreqControlLevel;
	}

	///合约
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcInstrumentNameType InstrumentName;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve3;
		///产品类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcProductClassType ProductClass;
		///交割年份
		public TThostFtdcYearType DeliveryYear;
		///交割月
		public TThostFtdcMonthType DeliveryMonth;
		///市价单最大下单量
		public TThostFtdcVolumeType MaxMarketOrderVolume;
		///市价单最小下单量
		public TThostFtdcVolumeType MinMarketOrderVolume;
		///限价单最大下单量
		public TThostFtdcVolumeType MaxLimitOrderVolume;
		///限价单最小下单量
		public TThostFtdcVolumeType MinLimitOrderVolume;
		///合约数量乘数
		public TThostFtdcVolumeMultipleType VolumeMultiple;
		///最小变动价位
		public TThostFtdcPriceType PriceTick;
		///创建日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType CreateDate;
		///上市日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///到期日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ExpireDate;
		///开始交割日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType StartDelivDate;
		///结束交割日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType EndDelivDate;
		///合约生命周期状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInstLifePhaseType InstLifePhase;
		///当前是否交易
		public TThostFtdcBoolType IsTrading;
		///持仓类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionTypeType PositionType;
		///持仓日期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionDateTypeType PositionDateType;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatio;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatio;
		///是否使用大额单边保证金算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMaxMarginSideAlgorithmType MaxMarginSideAlgorithm;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve4;
		///执行价
		public TThostFtdcPriceType StrikePrice;
		///期权类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOptionsTypeType OptionsType;
		///合约基础商品乘数
		public TThostFtdcUnderlyingMultipleType UnderlyingMultiple;
		///组合类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCombinationTypeType CombinationType;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///基础商品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType UnderlyingInstrID;
	}

	///经纪公司
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///经纪公司简称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBrokerAbbrType BrokerAbbr;
		///经纪公司名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcBrokerNameType BrokerName;
		///是否活跃
		public TThostFtdcBoolType IsActive;
	}

	///交易所交易员
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTraderField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装数量
		public TThostFtdcInstallCountType InstallCount;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///撤单时选择席位算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderCancelAlgType OrderCancelAlg;
	}

	///投资者
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorField
	{
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者分组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorGroupID;
		///投资者名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcPartyNameType InvestorName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdentifiedCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///是否活跃
		public TThostFtdcBoolType IsActive;
		///联系电话
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///通讯地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///开户日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcMobileType Mobile;
		///手续费率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType CommModelID;
		///保证金率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType MarginModelID;
		///是否频率控制
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcEnumBoolType IsOrderFreq;
		///是否开仓限制
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcEnumBoolType IsOpenVolLimit;
	}

	///交易编码
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingCodeField
	{
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///是否活跃
		public TThostFtdcBoolType IsActive;
		///交易编码类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcClientIDTypeType ClientIDType;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///业务类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBizTypeType BizType;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///会员编码和经纪公司编码对照表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcPartBrokerField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///是否活跃
		public TThostFtdcBoolType IsActive;
	}

	///管理用户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSuperUserField
	{
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcUserNameType UserName;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///是否活跃
		public TThostFtdcBoolType IsActive;
	}

	///管理用户功能权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSuperUserFunctionField
	{
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///功能代码
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFunctionCodeType FunctionCode;
	}

	///投资者组
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorGroupField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者分组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorGroupID;
		///投资者分组名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcInvestorGroupNameType InvestorGroupName;
	}

	///资金账户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingAccountField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///上次质押金额
		public TThostFtdcMoneyType PreMortgage;
		///上次信用额度
		public TThostFtdcMoneyType PreCredit;
		///上次存款额
		public TThostFtdcMoneyType PreDeposit;
		///上次结算准备金
		public TThostFtdcMoneyType PreBalance;
		///上次占用的保证金
		public TThostFtdcMoneyType PreMargin;
		///利息基数
		public TThostFtdcMoneyType InterestBase;
		///利息收入
		public TThostFtdcMoneyType Interest;
		///入金金额
		public TThostFtdcMoneyType Deposit;
		///出金金额
		public TThostFtdcMoneyType Withdraw;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///当前保证金总额
		public TThostFtdcMoneyType CurrMargin;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///手续费
		public TThostFtdcMoneyType Commission;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///期货结算准备金
		public TThostFtdcMoneyType Balance;
		///可用资金
		public TThostFtdcMoneyType Available;
		///可取资金
		public TThostFtdcMoneyType WithdrawQuota;
		///基本准备金
		public TThostFtdcMoneyType Reserve;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///信用额度
		public TThostFtdcMoneyType Credit;
		///质押金额
		public TThostFtdcMoneyType Mortgage;
		///交易所保证金
		public TThostFtdcMoneyType ExchangeMargin;
		///投资者交割保证金
		public TThostFtdcMoneyType DeliveryMargin;
		///交易所交割保证金
		public TThostFtdcMoneyType ExchangeDeliveryMargin;
		///保底期货结算准备金
		public TThostFtdcMoneyType ReserveBalance;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///上次货币质入金额
		public TThostFtdcMoneyType PreFundMortgageIn;
		///上次货币质出金额
		public TThostFtdcMoneyType PreFundMortgageOut;
		///货币质入金额
		public TThostFtdcMoneyType FundMortgageIn;
		///货币质出金额
		public TThostFtdcMoneyType FundMortgageOut;
		///货币质押余额
		public TThostFtdcMoneyType FundMortgageAvailable;
		///可质押货币金额
		public TThostFtdcMoneyType MortgageableFund;
		///特殊产品占用保证金
		public TThostFtdcMoneyType SpecProductMargin;
		///特殊产品冻结保证金
		public TThostFtdcMoneyType SpecProductFrozenMargin;
		///特殊产品手续费
		public TThostFtdcMoneyType SpecProductCommission;
		///特殊产品冻结手续费
		public TThostFtdcMoneyType SpecProductFrozenCommission;
		///特殊产品持仓盈亏
		public TThostFtdcMoneyType SpecProductPositionProfit;
		///特殊产品平仓盈亏
		public TThostFtdcMoneyType SpecProductCloseProfit;
		///根据持仓盈亏算法计算的特殊产品持仓盈亏
		public TThostFtdcMoneyType SpecProductPositionProfitByAlg;
		///特殊产品交易所保证金
		public TThostFtdcMoneyType SpecProductExchangeMargin;
		///业务类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBizTypeType BizType;
		///延时换汇冻结金额
		public TThostFtdcMoneyType FrozenSwap;
		///剩余换汇额度
		public TThostFtdcMoneyType RemainSwap;
	}

	///投资者持仓
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorPositionField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///持仓多空方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///持仓日期
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionDateType PositionDate;
		///上日持仓
		public TThostFtdcVolumeType YdPosition;
		///今日持仓
		public TThostFtdcVolumeType Position;
		///多头冻结
		public TThostFtdcVolumeType LongFrozen;
		///空头冻结
		public TThostFtdcVolumeType ShortFrozen;
		///开仓冻结金额
		public TThostFtdcMoneyType LongFrozenAmount;
		///开仓冻结金额
		public TThostFtdcMoneyType ShortFrozenAmount;
		///开仓量
		public TThostFtdcVolumeType OpenVolume;
		///平仓量
		public TThostFtdcVolumeType CloseVolume;
		///开仓金额
		public TThostFtdcMoneyType OpenAmount;
		///平仓金额
		public TThostFtdcMoneyType CloseAmount;
		///持仓成本
		public TThostFtdcMoneyType PositionCost;
		///上次占用的保证金
		public TThostFtdcMoneyType PreMargin;
		///占用的保证金
		public TThostFtdcMoneyType UseMargin;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///手续费
		public TThostFtdcMoneyType Commission;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///开仓成本
		public TThostFtdcMoneyType OpenCost;
		///交易所保证金
		public TThostFtdcMoneyType ExchangeMargin;
		///组合成交形成的持仓
		public TThostFtdcVolumeType CombPosition;
		///组合多头冻结
		public TThostFtdcVolumeType CombLongFrozen;
		///组合空头冻结
		public TThostFtdcVolumeType CombShortFrozen;
		///逐日盯市平仓盈亏
		public TThostFtdcMoneyType CloseProfitByDate;
		///逐笔对冲平仓盈亏
		public TThostFtdcMoneyType CloseProfitByTrade;
		///今日持仓
		public TThostFtdcVolumeType TodayPosition;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///执行冻结
		public TThostFtdcVolumeType StrikeFrozen;
		///执行冻结金额
		public TThostFtdcMoneyType StrikeFrozenAmount;
		///放弃执行冻结
		public TThostFtdcVolumeType AbandonFrozen;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行冻结的昨仓
		public TThostFtdcVolumeType YdStrikeFrozen;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///大商所持仓成本差值，只有大商所使用
		public TThostFtdcMoneyType PositionCostOffset;
		///tas持仓手数
		public TThostFtdcVolumeType TasPosition;
		///tas持仓成本
		public TThostFtdcMoneyType TasPositionCost;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///合约保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentMarginRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///是否相对交易所收取
		public TThostFtdcBoolType IsRelative;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///合约手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentCommissionRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///业务类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBizTypeType BizType;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///深度行情
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcDepthMarketDataField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///最新价
		public TThostFtdcPriceType LastPrice;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///昨收盘
		public TThostFtdcPriceType PreClosePrice;
		///昨持仓量
		public TThostFtdcLargeVolumeType PreOpenInterest;
		///今开盘
		public TThostFtdcPriceType OpenPrice;
		///最高价
		public TThostFtdcPriceType HighestPrice;
		///最低价
		public TThostFtdcPriceType LowestPrice;
		///数量
		public TThostFtdcVolumeType Volume;
		///成交金额
		public TThostFtdcMoneyType Turnover;
		///持仓量
		public TThostFtdcLargeVolumeType OpenInterest;
		///今收盘
		public TThostFtdcPriceType ClosePrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///涨停板价
		public TThostFtdcPriceType UpperLimitPrice;
		///跌停板价
		public TThostFtdcPriceType LowerLimitPrice;
		///昨虚实度
		public TThostFtdcRatioType PreDelta;
		///今虚实度
		public TThostFtdcRatioType CurrDelta;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///最后修改毫秒
		public TThostFtdcMillisecType UpdateMillisec;
		///申买价一
		public TThostFtdcPriceType BidPrice1;
		///申买量一
		public TThostFtdcVolumeType BidVolume1;
		///申卖价一
		public TThostFtdcPriceType AskPrice1;
		///申卖量一
		public TThostFtdcVolumeType AskVolume1;
		///申买价二
		public TThostFtdcPriceType BidPrice2;
		///申买量二
		public TThostFtdcVolumeType BidVolume2;
		///申卖价二
		public TThostFtdcPriceType AskPrice2;
		///申卖量二
		public TThostFtdcVolumeType AskVolume2;
		///申买价三
		public TThostFtdcPriceType BidPrice3;
		///申买量三
		public TThostFtdcVolumeType BidVolume3;
		///申卖价三
		public TThostFtdcPriceType AskPrice3;
		///申卖量三
		public TThostFtdcVolumeType AskVolume3;
		///申买价四
		public TThostFtdcPriceType BidPrice4;
		///申买量四
		public TThostFtdcVolumeType BidVolume4;
		///申卖价四
		public TThostFtdcPriceType AskPrice4;
		///申卖量四
		public TThostFtdcVolumeType AskVolume4;
		///申买价五
		public TThostFtdcPriceType BidPrice5;
		///申买量五
		public TThostFtdcVolumeType BidVolume5;
		///申卖价五
		public TThostFtdcPriceType AskPrice5;
		///申卖量五
		public TThostFtdcVolumeType AskVolume5;
		///当日均价
		public TThostFtdcPriceType AveragePrice;
		///业务日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDay;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///上带价
		public TThostFtdcPriceType BandingUpperPrice;
		///下带价
		public TThostFtdcPriceType BandingLowerPrice;
	}

	///投资者合约交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentTradingRightField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易权限
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradingRightType TradingRight;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///经纪公司用户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerUserField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcUserNameType UserName;
		///用户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcUserTypeType UserType;
		///是否活跃
		public TThostFtdcBoolType IsActive;
		///是否使用令牌
		public TThostFtdcBoolType IsUsingOTP;
		///是否强制终端认证
		public TThostFtdcBoolType IsAuthForce;
	}

	///经纪公司用户口令
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerUserPasswordField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///上次修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcDateTimeType LastUpdateTime;
		///上次登陆时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcDateTimeType LastLoginTime;
		///密码过期时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ExpireDate;
		///弱密码过期时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType WeakExpireDate;
	}

	///经纪公司用户功能权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerUserFunctionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///经纪公司功能代码
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBrokerFunctionCodeType BrokerFunctionCode;
	}

	///交易所交易员报盘机
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTraderOfferField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///交易所交易员连接状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTraderConnectStatusType TraderConnectStatus;
		///发出连接请求的日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ConnectRequestDate;
		///发出连接请求的时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ConnectRequestTime;
		///上次报告日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType LastReportDate;
		///上次报告时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LastReportTime;
		///完成连接日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ConnectDate;
		///完成连接时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ConnectTime;
		///启动日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType StartDate;
		///启动时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType StartTime;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///本席位最大成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType MaxTradeID;
		///本席位最大报单备拷
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcReturnCodeType MaxOrderMessageReference;
		///撤单时选择席位算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderCancelAlgType OrderCancelAlg;
	}

	///投资者结算结果
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSettlementInfoField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///消息正文
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
		public TThostFtdcContentType Content;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///合约保证金率调整
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentMarginRateAdjustField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///是否相对交易所收取
		public TThostFtdcBoolType IsRelative;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeMarginRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所保证金率调整
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeMarginRateAdjustField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///跟随交易所投资者多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///跟随交易所投资者多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///跟随交易所投资者空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///跟随交易所投资者空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///交易所多头保证金率
		public TThostFtdcRatioType ExchLongMarginRatioByMoney;
		///交易所多头保证金费
		public TThostFtdcMoneyType ExchLongMarginRatioByVolume;
		///交易所空头保证金率
		public TThostFtdcRatioType ExchShortMarginRatioByMoney;
		///交易所空头保证金费
		public TThostFtdcMoneyType ExchShortMarginRatioByVolume;
		///不跟随交易所投资者多头保证金率
		public TThostFtdcRatioType NoLongMarginRatioByMoney;
		///不跟随交易所投资者多头保证金费
		public TThostFtdcMoneyType NoLongMarginRatioByVolume;
		///不跟随交易所投资者空头保证金率
		public TThostFtdcRatioType NoShortMarginRatioByMoney;
		///不跟随交易所投资者空头保证金费
		public TThostFtdcMoneyType NoShortMarginRatioByVolume;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///汇率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///源币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType FromCurrencyID;
		///源币种单位数量
		public TThostFtdcCurrencyUnitType FromCurrencyUnit;
		///目标币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType ToCurrencyID;
		///汇率
		public TThostFtdcExchangeRateType ExchangeRate;
	}

	///结算引用
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSettlementRefField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
	}

	///当前时间
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCurrentTimeField
	{
		///当前交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType CurrDate;
		///当前时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CurrTime;
		///当前时间（毫秒）
		public TThostFtdcMillisecType CurrMillisec;
		///自然日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDay;
	}

	///通讯阶段
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCommPhaseField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///通讯时段编号
		public TThostFtdcCommPhaseNoType CommPhaseNo;
		///系统编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcSystemIDType SystemID;
	}

	///登录信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcLoginInfoField
	{
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///登录日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType LoginDate;
		///登录时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LoginTime;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///系统名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcSystemNameType SystemName;
		///密码,已弃用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType PasswordDeprecated;
		///最大报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType MaxOrderRef;
		///上期所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SHFETime;
		///大商所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType DCETime;
		///郑商所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CZCETime;
		///中金所时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType FFEXTime;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///动态密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OneTimePassword;
		///能源中心时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType INETime;
		///查询时是否需要流控
		public TThostFtdcBoolType IsQryControl;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///登录信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcLogoutAllField
	{
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///系统名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcSystemNameType SystemName;
	}

	///前置状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcFrontStatusField
	{
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///上次报告日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType LastReportDate;
		///上次报告时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LastReportTime;
		///是否活跃
		public TThostFtdcBoolType IsActive;
	}

	///用户口令变更
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserPasswordUpdateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///原来的口令
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OldPassword;
		///新的口令
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType NewPassword;
	}

	///输入报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///报单价格条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderPriceTypeType OrderPriceType;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///组合开平标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombOffsetFlagType CombOffsetFlag;
		///组合投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量
		public TThostFtdcVolumeType VolumeTotalOriginal;
		///有效期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTimeConditionType TimeCondition;
		///GTD日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType GTDDate;
		///成交量类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcVolumeConditionType VolumeCondition;
		///最小成交量
		public TThostFtdcVolumeType MinVolume;
		///触发条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcContingentConditionType ContingentCondition;
		///止损价
		public TThostFtdcPriceType StopPrice;
		///强平原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForceCloseReasonType ForceCloseReason;
		///自动挂起标志
		public TThostFtdcBoolType IsAutoSuspend;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///用户强评标志
		public TThostFtdcBoolType UserForceClose;
		///互换单标志
		public TThostFtdcBoolType IsSwapOrder;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///报单价格条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderPriceTypeType OrderPriceType;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///组合开平标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombOffsetFlagType CombOffsetFlag;
		///组合投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量
		public TThostFtdcVolumeType VolumeTotalOriginal;
		///有效期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTimeConditionType TimeCondition;
		///GTD日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType GTDDate;
		///成交量类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcVolumeConditionType VolumeCondition;
		///最小成交量
		public TThostFtdcVolumeType MinVolume;
		///触发条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcContingentConditionType ContingentCondition;
		///止损价
		public TThostFtdcPriceType StopPrice;
		///强平原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForceCloseReasonType ForceCloseReason;
		///自动挂起标志
		public TThostFtdcBoolType IsAutoSuspend;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报单提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///报单来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSourceType OrderSource;
		///报单状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderStatusType OrderStatus;
		///报单类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderTypeType OrderType;
		///今成交数量
		public TThostFtdcVolumeType VolumeTraded;
		///剩余数量
		public TThostFtdcVolumeType VolumeTotal;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///委托时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///激活时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActiveTime;
		///挂起时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SuspendTime;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///最后修改交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType ActiveTraderID;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///用户强评标志
		public TThostFtdcBoolType UserForceClose;
		///操作用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType ActiveUserID;
		///经纪公司报单编号
		public TThostFtdcSequenceNoType BrokerOrderSeq;
		///相关报单
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType RelativeOrderSysID;
		///郑商所成交数量
		public TThostFtdcVolumeType ZCETotalTradedVolume;
		///互换单标志
		public TThostFtdcBoolType IsSwapOrder;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeOrderField
	{
		///报单价格条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderPriceTypeType OrderPriceType;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///组合开平标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombOffsetFlagType CombOffsetFlag;
		///组合投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量
		public TThostFtdcVolumeType VolumeTotalOriginal;
		///有效期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTimeConditionType TimeCondition;
		///GTD日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType GTDDate;
		///成交量类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcVolumeConditionType VolumeCondition;
		///最小成交量
		public TThostFtdcVolumeType MinVolume;
		///触发条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcContingentConditionType ContingentCondition;
		///止损价
		public TThostFtdcPriceType StopPrice;
		///强平原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForceCloseReasonType ForceCloseReason;
		///自动挂起标志
		public TThostFtdcBoolType IsAutoSuspend;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报单提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///报单来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSourceType OrderSource;
		///报单状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderStatusType OrderStatus;
		///报单类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderTypeType OrderType;
		///今成交数量
		public TThostFtdcVolumeType VolumeTraded;
		///剩余数量
		public TThostFtdcVolumeType VolumeTotal;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///委托时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///激活时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActiveTime;
		///挂起时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SuspendTime;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///最后修改交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType ActiveTraderID;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所报单插入失败
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeOrderInsertErrorField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///输入报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报单操作引用
		public TThostFtdcOrderActionRefType OrderActionRef;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量变化
		public TThostFtdcVolumeType VolumeChange;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报单操作引用
		public TThostFtdcOrderActionRefType OrderActionRef;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量变化
		public TThostFtdcVolumeType VolumeChange;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeOrderActionField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量变化
		public TThostFtdcVolumeType VolumeChange;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所报单操作失败
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeOrderActionErrorField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///交易所成交
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeTradeField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///交易角色
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradingRoleType TradingRole;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///价格
		public TThostFtdcPriceType Price;
		///数量
		public TThostFtdcVolumeType Volume;
		///成交时期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradeDate;
		///成交时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType TradeTime;
		///成交类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeTypeType TradeType;
		///成交价来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPriceSourceType PriceSource;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///成交来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeSourceType TradeSource;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///成交
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///交易角色
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradingRoleType TradingRole;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///价格
		public TThostFtdcPriceType Price;
		///数量
		public TThostFtdcVolumeType Volume;
		///成交时期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradeDate;
		///成交时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType TradeTime;
		///成交类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeTypeType TradeType;
		///成交价来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPriceSourceType PriceSource;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///经纪公司报单编号
		public TThostFtdcSequenceNoType BrokerOrderSeq;
		///成交来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeSourceType TradeSource;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///用户会话
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserSessionField
	{
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///登录日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType LoginDate;
		///登录时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LoginTime;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询最大报单数量
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMaxOrderVolumeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///最大允许报单数量
		public TThostFtdcVolumeType MaxVolume;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///投资者结算结果确认信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSettlementInfoConfirmField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///确认日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ConfirmDate;
		///确认时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ConfirmTime;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///出入金同步
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDepositField
	{
		///出入金流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType DepositSeqNo;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///入金金额
		public TThostFtdcMoneyType Deposit;
		///是否强制进行
		public TThostFtdcBoolType IsForce;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///是否是个股期权内转
		public TThostFtdcBoolType IsFromSopt;
		///资金密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType TradingPassword;
	}

	///货币质押同步
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncFundMortgageField
	{
		///货币质押流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType MortgageSeqNo;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///源币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType FromCurrencyID;
		///质押金额
		public TThostFtdcMoneyType MortgageAmount;
		///目标币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType ToCurrencyID;
	}

	///经纪公司同步
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerSyncField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
	}

	///正在同步中的投资者
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingInvestorField
	{
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者分组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorGroupID;
		///投资者名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcPartyNameType InvestorName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdentifiedCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///是否活跃
		public TThostFtdcBoolType IsActive;
		///联系电话
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///通讯地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///开户日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcMobileType Mobile;
		///手续费率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType CommModelID;
		///保证金率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType MarginModelID;
		///是否频率控制
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcEnumBoolType IsOrderFreq;
		///是否开仓限制
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcEnumBoolType IsOpenVolLimit;
	}

	///正在同步中的交易代码
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingTradingCodeField
	{
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///是否活跃
		public TThostFtdcBoolType IsActive;
		///交易编码类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcClientIDTypeType ClientIDType;
	}

	///正在同步中的投资者分组
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingInvestorGroupField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者分组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorGroupID;
		///投资者分组名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcInvestorGroupNameType InvestorGroupName;
	}

	///正在同步中的交易账号
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingTradingAccountField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///上次质押金额
		public TThostFtdcMoneyType PreMortgage;
		///上次信用额度
		public TThostFtdcMoneyType PreCredit;
		///上次存款额
		public TThostFtdcMoneyType PreDeposit;
		///上次结算准备金
		public TThostFtdcMoneyType PreBalance;
		///上次占用的保证金
		public TThostFtdcMoneyType PreMargin;
		///利息基数
		public TThostFtdcMoneyType InterestBase;
		///利息收入
		public TThostFtdcMoneyType Interest;
		///入金金额
		public TThostFtdcMoneyType Deposit;
		///出金金额
		public TThostFtdcMoneyType Withdraw;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///当前保证金总额
		public TThostFtdcMoneyType CurrMargin;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///手续费
		public TThostFtdcMoneyType Commission;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///期货结算准备金
		public TThostFtdcMoneyType Balance;
		///可用资金
		public TThostFtdcMoneyType Available;
		///可取资金
		public TThostFtdcMoneyType WithdrawQuota;
		///基本准备金
		public TThostFtdcMoneyType Reserve;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///信用额度
		public TThostFtdcMoneyType Credit;
		///质押金额
		public TThostFtdcMoneyType Mortgage;
		///交易所保证金
		public TThostFtdcMoneyType ExchangeMargin;
		///投资者交割保证金
		public TThostFtdcMoneyType DeliveryMargin;
		///交易所交割保证金
		public TThostFtdcMoneyType ExchangeDeliveryMargin;
		///保底期货结算准备金
		public TThostFtdcMoneyType ReserveBalance;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///上次货币质入金额
		public TThostFtdcMoneyType PreFundMortgageIn;
		///上次货币质出金额
		public TThostFtdcMoneyType PreFundMortgageOut;
		///货币质入金额
		public TThostFtdcMoneyType FundMortgageIn;
		///货币质出金额
		public TThostFtdcMoneyType FundMortgageOut;
		///货币质押余额
		public TThostFtdcMoneyType FundMortgageAvailable;
		///可质押货币金额
		public TThostFtdcMoneyType MortgageableFund;
		///特殊产品占用保证金
		public TThostFtdcMoneyType SpecProductMargin;
		///特殊产品冻结保证金
		public TThostFtdcMoneyType SpecProductFrozenMargin;
		///特殊产品手续费
		public TThostFtdcMoneyType SpecProductCommission;
		///特殊产品冻结手续费
		public TThostFtdcMoneyType SpecProductFrozenCommission;
		///特殊产品持仓盈亏
		public TThostFtdcMoneyType SpecProductPositionProfit;
		///特殊产品平仓盈亏
		public TThostFtdcMoneyType SpecProductCloseProfit;
		///根据持仓盈亏算法计算的特殊产品持仓盈亏
		public TThostFtdcMoneyType SpecProductPositionProfitByAlg;
		///特殊产品交易所保证金
		public TThostFtdcMoneyType SpecProductExchangeMargin;
		///延时换汇冻结金额
		public TThostFtdcMoneyType FrozenSwap;
		///剩余换汇额度
		public TThostFtdcMoneyType RemainSwap;
	}

	///正在同步中的投资者持仓
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingInvestorPositionField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///持仓多空方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///持仓日期
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionDateType PositionDate;
		///上日持仓
		public TThostFtdcVolumeType YdPosition;
		///今日持仓
		public TThostFtdcVolumeType Position;
		///多头冻结
		public TThostFtdcVolumeType LongFrozen;
		///空头冻结
		public TThostFtdcVolumeType ShortFrozen;
		///开仓冻结金额
		public TThostFtdcMoneyType LongFrozenAmount;
		///开仓冻结金额
		public TThostFtdcMoneyType ShortFrozenAmount;
		///开仓量
		public TThostFtdcVolumeType OpenVolume;
		///平仓量
		public TThostFtdcVolumeType CloseVolume;
		///开仓金额
		public TThostFtdcMoneyType OpenAmount;
		///平仓金额
		public TThostFtdcMoneyType CloseAmount;
		///持仓成本
		public TThostFtdcMoneyType PositionCost;
		///上次占用的保证金
		public TThostFtdcMoneyType PreMargin;
		///占用的保证金
		public TThostFtdcMoneyType UseMargin;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///手续费
		public TThostFtdcMoneyType Commission;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///开仓成本
		public TThostFtdcMoneyType OpenCost;
		///交易所保证金
		public TThostFtdcMoneyType ExchangeMargin;
		///组合成交形成的持仓
		public TThostFtdcVolumeType CombPosition;
		///组合多头冻结
		public TThostFtdcVolumeType CombLongFrozen;
		///组合空头冻结
		public TThostFtdcVolumeType CombShortFrozen;
		///逐日盯市平仓盈亏
		public TThostFtdcMoneyType CloseProfitByDate;
		///逐笔对冲平仓盈亏
		public TThostFtdcMoneyType CloseProfitByTrade;
		///今日持仓
		public TThostFtdcVolumeType TodayPosition;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///执行冻结
		public TThostFtdcVolumeType StrikeFrozen;
		///执行冻结金额
		public TThostFtdcMoneyType StrikeFrozenAmount;
		///放弃执行冻结
		public TThostFtdcVolumeType AbandonFrozen;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行冻结的昨仓
		public TThostFtdcVolumeType YdStrikeFrozen;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///大商所持仓成本差值，只有大商所使用
		public TThostFtdcMoneyType PositionCostOffset;
		///tas持仓手数
		public TThostFtdcVolumeType TasPosition;
		///tas持仓成本
		public TThostFtdcMoneyType TasPositionCost;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///正在同步中的合约保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingInstrumentMarginRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///是否相对交易所收取
		public TThostFtdcBoolType IsRelative;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///正在同步中的合约手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingInstrumentCommissionRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///正在同步中的合约交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncingInstrumentTradingRightField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易权限
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradingRightType TradingRight;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeEnd;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询成交
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTradeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType TradeTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType TradeTimeEnd;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询投资者持仓
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestorPositionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询资金账户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTradingAccountField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///业务类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBizTypeType BizType;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
	}

	///查询投资者
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestorField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///查询交易编码
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTradingCodeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///交易编码类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcClientIDTypeType ClientIDType;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///查询投资者组
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestorGroupField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
	}

	///查询合约保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInstrumentMarginRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInstrumentCommissionRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询合约交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInstrumentTradingRightField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询经纪公司
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBrokerField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
	}

	///查询交易员
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTraderField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
	}

	///查询管理用户功能权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySuperUserFunctionField
	{
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///查询用户会话
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryUserSessionField
	{
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///查询经纪公司会员代码
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryPartBrokerField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
	}

	///查询前置状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryFrontStatusField
	{
		///前置编号
		public TThostFtdcFrontIDType FrontID;
	}

	///查询交易所报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeOrderField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///查询报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///查询交易所报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeOrderActionField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
	}

	///查询管理用户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySuperUserField
	{
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///查询交易所
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///查询产品
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryProductField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///产品类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcProductClassType ProductClass;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///查询合约
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInstrumentField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve3;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///查询行情
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryDepthMarketDataField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询经纪公司用户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBrokerUserField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///查询经纪公司用户权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBrokerUserFunctionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///查询交易员报盘机
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTraderOfferField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
	}

	///查询出入金流水
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySyncDepositField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///出入金流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType DepositSeqNo;
	}

	///查询投资者结算结果
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySettlementInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///查询交易所保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeMarginRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询交易所调整保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeMarginRateAdjustField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询汇率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///源币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType FromCurrencyID;
		///目标币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType ToCurrencyID;
	}

	///查询货币质押流水
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySyncFundMortgageField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///货币质押流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType MortgageSeqNo;
	}

	///查询报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryHisOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeEnd;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///当前期权合约最小保证金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionInstrMiniMarginField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///单位（手）期权合约最小保证金
		public TThostFtdcMoneyType MinMargin;
		///取值方式
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcValueMethodType ValueMethod;
		///是否跟随交易所收取
		public TThostFtdcBoolType IsRelative;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///当前期权合约保证金调整系数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionInstrMarginAdjustField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机空头保证金调整系数
		public TThostFtdcRatioType SShortMarginRatioByMoney;
		///投机空头保证金调整系数
		public TThostFtdcMoneyType SShortMarginRatioByVolume;
		///保值空头保证金调整系数
		public TThostFtdcRatioType HShortMarginRatioByMoney;
		///保值空头保证金调整系数
		public TThostFtdcMoneyType HShortMarginRatioByVolume;
		///套利空头保证金调整系数
		public TThostFtdcRatioType AShortMarginRatioByMoney;
		///套利空头保证金调整系数
		public TThostFtdcMoneyType AShortMarginRatioByVolume;
		///是否跟随交易所收取
		public TThostFtdcBoolType IsRelative;
		///做市商空头保证金调整系数
		public TThostFtdcRatioType MShortMarginRatioByMoney;
		///做市商空头保证金调整系数
		public TThostFtdcMoneyType MShortMarginRatioByVolume;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///当前期权合约手续费的详细内容
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionInstrCommRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///执行手续费率
		public TThostFtdcRatioType StrikeRatioByMoney;
		///执行手续费
		public TThostFtdcRatioType StrikeRatioByVolume;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///期权交易成本
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionInstrTradeCostField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///期权合约保证金不变部分
		public TThostFtdcMoneyType FixedMargin;
		///期权合约最小保证金
		public TThostFtdcMoneyType MiniMargin;
		///期权合约权利金
		public TThostFtdcMoneyType Royalty;
		///交易所期权合约保证金不变部分
		public TThostFtdcMoneyType ExchFixedMargin;
		///交易所期权合约最小保证金
		public TThostFtdcMoneyType ExchMiniMargin;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///期权交易成本查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOptionInstrTradeCostField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///期权合约报价
		public TThostFtdcPriceType InputPrice;
		///标的价格,填0则用昨结算价
		public TThostFtdcPriceType UnderlyingPrice;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///期权手续费率查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOptionInstrCommRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///股指现货指数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcIndexPriceField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///指数现货收盘价
		public TThostFtdcPriceType ClosePrice;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///输入的执行宣告
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputExecOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///执行宣告引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ExecOrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///执行类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionTypeType ActionType;
		///保留头寸申请的持仓方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///期权行权后是否保留期货头寸的标记,该字段已废弃
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderPositionFlagType ReservePositionFlag;
		///期权行权后生成的头寸是否自动平仓
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderCloseFlagType CloseFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///输入执行宣告操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputExecOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///执行宣告操作引用
		public TThostFtdcOrderActionRefType ExecOrderActionRef;
		///执行宣告引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ExecOrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行宣告操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///执行宣告
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExecOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///执行宣告引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ExecOrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///执行类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionTypeType ActionType;
		///保留头寸申请的持仓方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///期权行权后是否保留期货头寸的标记,该字段已废弃
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderPositionFlagType ReservePositionFlag;
		///期权行权后生成的头寸是否自动平仓
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderCloseFlagType CloseFlag;
		///本地执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ExecOrderLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///执行宣告提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///执行结果
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecResultType ExecResult;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///操作用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType ActiveUserID;
		///经纪公司报单编号
		public TThostFtdcSequenceNoType BrokerExecOrderSeq;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///执行宣告操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExecOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///执行宣告操作引用
		public TThostFtdcOrderActionRefType ExecOrderActionRef;
		///执行宣告引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ExecOrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行宣告操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ExecOrderLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///执行类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionTypeType ActionType;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///执行宣告查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExecOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeEnd;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所执行宣告信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeExecOrderField
	{
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///执行类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionTypeType ActionType;
		///保留头寸申请的持仓方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///期权行权后是否保留期货头寸的标记,该字段已废弃
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderPositionFlagType ReservePositionFlag;
		///期权行权后生成的头寸是否自动平仓
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderCloseFlagType CloseFlag;
		///本地执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ExecOrderLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///执行宣告提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///执行结果
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecResultType ExecResult;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所执行宣告查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeExecOrderField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///执行宣告操作查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExecOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///交易所执行宣告操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeExecOrderActionField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行宣告操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地执行宣告编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ExecOrderLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///执行类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionTypeType ActionType;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///数量
		public TThostFtdcVolumeType Volume;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///交易所执行宣告操作查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeExecOrderActionField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
	}

	///错误执行宣告
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcErrExecOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///执行宣告引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ExecOrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///执行类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionTypeType ActionType;
		///保留头寸申请的持仓方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///期权行权后是否保留期货头寸的标记,该字段已废弃
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderPositionFlagType ReservePositionFlag;
		///期权行权后生成的头寸是否自动平仓
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecOrderCloseFlagType CloseFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询错误执行宣告
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryErrExecOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///错误执行宣告操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcErrExecOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///执行宣告操作引用
		public TThostFtdcOrderActionRefType ExecOrderActionRef;
		///执行宣告引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ExecOrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行宣告操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcExecOrderSysIDType ExecOrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询错误执行宣告操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryErrExecOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///投资者期权合约交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionInstrTradingRightField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///交易权限
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradingRightType TradingRight;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询期权合约交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOptionInstrTradingRightField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///输入的询价
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputForQuoteField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///询价引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ForQuoteRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///询价
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcForQuoteField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///询价引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType ForQuoteRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///本地询价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ForQuoteLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///询价状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForQuoteStatusType ForQuoteStatus;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///操作用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType ActiveUserID;
		///经纪公司询价编号
		public TThostFtdcSequenceNoType BrokerForQutoSeq;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///询价查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryForQuoteField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeEnd;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所询价信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeForQuoteField
	{
		///本地询价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ForQuoteLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///询价状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForQuoteStatusType ForQuoteStatus;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所询价查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeForQuoteField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///输入的报价
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputQuoteField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报价引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType QuoteRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///卖价格
		public TThostFtdcPriceType AskPrice;
		///买价格
		public TThostFtdcPriceType BidPrice;
		///卖数量
		public TThostFtdcVolumeType AskVolume;
		///买数量
		public TThostFtdcVolumeType BidVolume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///卖开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType AskOffsetFlag;
		///买开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType BidOffsetFlag;
		///卖投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType AskHedgeFlag;
		///买投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType BidHedgeFlag;
		///衍生卖报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType AskOrderRef;
		///衍生买报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType BidOrderRef;
		///应价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType ForQuoteSysID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
		///被顶单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType ReplaceSysID;
	}

	///输入报价操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputQuoteActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报价操作引用
		public TThostFtdcOrderActionRefType QuoteActionRef;
		///报价引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType QuoteRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报价操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType QuoteSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///报价
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQuoteField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报价引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType QuoteRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///卖价格
		public TThostFtdcPriceType AskPrice;
		///买价格
		public TThostFtdcPriceType BidPrice;
		///卖数量
		public TThostFtdcVolumeType AskVolume;
		///买数量
		public TThostFtdcVolumeType BidVolume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///卖开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType AskOffsetFlag;
		///买开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType BidOffsetFlag;
		///卖投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType AskHedgeFlag;
		///买投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType BidHedgeFlag;
		///本地报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType QuoteLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报价提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///报价提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType QuoteSysID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///报价状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderStatusType QuoteStatus;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///卖方报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType AskOrderSysID;
		///买方报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType BidOrderSysID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///操作用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType ActiveUserID;
		///经纪公司报价编号
		public TThostFtdcSequenceNoType BrokerQuoteSeq;
		///衍生卖报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType AskOrderRef;
		///衍生买报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType BidOrderRef;
		///应价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType ForQuoteSysID;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
		///被顶单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType ReplaceSysID;
	}

	///报价操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQuoteActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报价操作引用
		public TThostFtdcOrderActionRefType QuoteActionRef;
		///报价引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType QuoteRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报价操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType QuoteSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType QuoteLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///报价查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryQuoteField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType QuoteSysID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeEnd;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所报价信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeQuoteField
	{
		///卖价格
		public TThostFtdcPriceType AskPrice;
		///买价格
		public TThostFtdcPriceType BidPrice;
		///卖数量
		public TThostFtdcVolumeType AskVolume;
		///买数量
		public TThostFtdcVolumeType BidVolume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///卖开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType AskOffsetFlag;
		///买开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType BidOffsetFlag;
		///卖投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType AskHedgeFlag;
		///买投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType BidHedgeFlag;
		///本地报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType QuoteLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报价提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///报价提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType QuoteSysID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///报价状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderStatusType QuoteStatus;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///卖方报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType AskOrderSysID;
		///买方报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType BidOrderSysID;
		///应价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType ForQuoteSysID;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所报价查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeQuoteField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///报价操作查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryQuoteActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///交易所报价操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeQuoteActionField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报价操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType QuoteSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType QuoteLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所报价操作查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeQuoteActionField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
	}

	///期权合约delta值
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionInstrDeltaField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///Delta值
		public TThostFtdcRatioType Delta;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///发给做市商的询价请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcForQuoteRspField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///询价编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType ForQuoteSysID;
		///询价时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ForQuoteTime;
		///业务日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDay;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///当前期权合约执行偏移值的详细内容
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcStrikeOffsetField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///执行偏移值
		public TThostFtdcMoneyType Offset;
		///执行偏移类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcStrikeOffsetTypeType OffsetType;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///期权执行偏移值查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryStrikeOffsetField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///输入批量报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputBatchOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报单操作引用
		public TThostFtdcOrderActionRefType OrderActionRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///批量报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBatchOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报单操作引用
		public TThostFtdcOrderActionRefType OrderActionRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所批量报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeBatchOrderActionField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询批量报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBatchOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///组合合约安全系数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCombInstrumentGuardField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///
		public TThostFtdcRatioType GuarantRatio;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///组合合约安全系数查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCombInstrumentGuardField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///输入的申请组合
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputCombActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///组合引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType CombActionRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///数量
		public TThostFtdcVolumeType Volume;
		///组合指令方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCombDirectionType CombDirection;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///申请组合
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCombActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///组合引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType CombActionRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///数量
		public TThostFtdcVolumeType Volume;
		///组合指令方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCombDirectionType CombDirection;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///本地申请组合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///组合状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType ActionStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///组合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType ComTradeID;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///申请组合查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCombActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所申请组合信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeCombActionField
	{
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///数量
		public TThostFtdcVolumeType Volume;
		///组合指令方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCombDirectionType CombDirection;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///本地申请组合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///组合状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType ActionStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///组合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType ComTradeID;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///交易所申请组合查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeCombActionField
	{
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///产品报价汇率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcProductExchRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报价币种类型
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType QuoteCurrencyID;
		///汇率
		public TThostFtdcExchangeRateType ExchangeRate;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///产品报价汇率查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryProductExchRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///查询询价价差参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryForQuoteParamField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///询价价差参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcForQuoteParamField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///最新价
		public TThostFtdcPriceType LastPrice;
		///价差
		public TThostFtdcPriceType PriceInterval;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///当前做市商期权合约手续费的详细内容
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMMOptionInstrCommRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///执行手续费率
		public TThostFtdcRatioType StrikeRatioByMoney;
		///执行手续费
		public TThostFtdcRatioType StrikeRatioByVolume;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///做市商期权手续费率查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMMOptionInstrCommRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///做市商合约手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMMInstrumentCommissionRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询做市商合约手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMMInstrumentCommissionRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///当前报单手续费的详细内容
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentOrderCommRateField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///报单手续费
		public TThostFtdcRatioType OrderCommByVolume;
		///撤单手续费
		public TThostFtdcRatioType OrderActionCommByVolume;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///报单手续费
		public TThostFtdcRatioType OrderCommByTrade;
		///撤单手续费
		public TThostFtdcRatioType OrderActionCommByTrade;
	}

	///报单手续费率查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInstrumentOrderCommRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradeParamField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///参数代码
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeParamIDType TradeParamID;
		///参数代码值
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public TThostFtdcSettlementParamValueType TradeParamValue;
		///备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcMemoType Memo;
	}

	///合约保证金率调整
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentMarginRateULField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///期货持仓限制参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcFutureLimitPosiParamField
	{
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///当日投机开仓数量限制
		public TThostFtdcVolumeType SpecOpenVolume;
		///当日套利开仓数量限制
		public TThostFtdcVolumeType ArbiOpenVolume;
		///当日投机+套利开仓数量限制
		public TThostFtdcVolumeType OpenVolume;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///禁止登录IP
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcLoginForbiddenIPField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///IP列表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcIPListField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///是否白名单
		public TThostFtdcBoolType IsWhite;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///输入的期权自对冲
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputOptionSelfCloseField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///期权自对冲引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OptionSelfCloseRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///期权行权的头寸是否自对冲
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOptSelfCloseFlagType OptSelfCloseFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///输入期权自对冲操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInputOptionSelfCloseActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///期权自对冲操作引用
		public TThostFtdcOrderActionRefType OptionSelfCloseActionRef;
		///期权自对冲引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OptionSelfCloseRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///期权自对冲操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OptionSelfCloseSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///期权自对冲
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionSelfCloseField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///期权自对冲引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OptionSelfCloseRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///期权行权的头寸是否自对冲
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOptSelfCloseFlagType OptSelfCloseFlag;
		///本地期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OptionSelfCloseLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///期权自对冲提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OptionSelfCloseSysID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///自对冲结果
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecResultType ExecResult;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///操作用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType ActiveUserID;
		///经纪公司报单编号
		public TThostFtdcSequenceNoType BrokerOptionSelfCloseSeq;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///期权自对冲操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOptionSelfCloseActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///期权自对冲操作引用
		public TThostFtdcOrderActionRefType OptionSelfCloseActionRef;
		///期权自对冲引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OptionSelfCloseRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///期权自对冲操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OptionSelfCloseSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OptionSelfCloseLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///期权自对冲查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOptionSelfCloseField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OptionSelfCloseSysID;
		///开始时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeStart;
		///结束时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTimeEnd;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///交易所期权自对冲信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeOptionSelfCloseField
	{
		///数量
		public TThostFtdcVolumeType Volume;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///期权行权的头寸是否自对冲
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOptSelfCloseFlagType OptSelfCloseFlag;
		///本地期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OptionSelfCloseLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///期权自对冲提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OptionSelfCloseSysID;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///插入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///自对冲结果
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcExecResultType ExecResult;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///期权自对冲操作查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryOptionSelfCloseActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///交易所期权自对冲操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeOptionSelfCloseActionField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///期权自对冲操作编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OptionSelfCloseSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地期权自对冲编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OptionSelfCloseLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///期权行权的头寸是否自对冲
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOptSelfCloseFlagType OptSelfCloseFlag;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///延时换汇同步
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDelaySwapField
	{
		///换汇流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType DelaySwapSeqNo;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///源币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType FromCurrencyID;
		///源金额
		public TThostFtdcMoneyType FromAmount;
		///源换汇冻结金额(可用冻结)
		public TThostFtdcMoneyType FromFrozenSwap;
		///源剩余换汇额度(可提冻结)
		public TThostFtdcMoneyType FromRemainSwap;
		///目标币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType ToCurrencyID;
		///目标金额
		public TThostFtdcMoneyType ToAmount;
		///是否手工换汇
		public TThostFtdcBoolType IsManualSwap;
		///是否将所有外币的剩余换汇额度设置为0
		public TThostFtdcBoolType IsAllRemainSetZero;
	}

	///查询延时换汇同步
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySyncDelaySwapField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///延时换汇流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType DelaySwapSeqNo;
	}

	///投资单元
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestUnitField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///投资者单元名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcPartyNameType InvestorUnitName;
		///投资者分组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorGroupID;
		///手续费率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType CommModelID;
		///保证金率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType MarginModelID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///查询投资单元
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestUnitField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///二级代理商资金校验模式
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSecAgentCheckModeField
	{
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///境外中介机构资金帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType BrokerSecAgentID;
		///是否需要校验自己的资金账户
		public TThostFtdcBoolType CheckSelfAccount;
	}

	///二级代理商信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSecAgentTradeInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///境外中介机构资金帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType BrokerSecAgentID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///二级代理商姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///市场行情
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///最新价
		public TThostFtdcPriceType LastPrice;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///昨收盘
		public TThostFtdcPriceType PreClosePrice;
		///昨持仓量
		public TThostFtdcLargeVolumeType PreOpenInterest;
		///今开盘
		public TThostFtdcPriceType OpenPrice;
		///最高价
		public TThostFtdcPriceType HighestPrice;
		///最低价
		public TThostFtdcPriceType LowestPrice;
		///数量
		public TThostFtdcVolumeType Volume;
		///成交金额
		public TThostFtdcMoneyType Turnover;
		///持仓量
		public TThostFtdcLargeVolumeType OpenInterest;
		///今收盘
		public TThostFtdcPriceType ClosePrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///涨停板价
		public TThostFtdcPriceType UpperLimitPrice;
		///跌停板价
		public TThostFtdcPriceType LowerLimitPrice;
		///昨虚实度
		public TThostFtdcRatioType PreDelta;
		///今虚实度
		public TThostFtdcRatioType CurrDelta;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///最后修改毫秒
		public TThostFtdcMillisecType UpdateMillisec;
		///业务日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDay;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///行情基础属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataBaseField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///昨收盘
		public TThostFtdcPriceType PreClosePrice;
		///昨持仓量
		public TThostFtdcLargeVolumeType PreOpenInterest;
		///昨虚实度
		public TThostFtdcRatioType PreDelta;
	}

	///行情静态属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataStaticField
	{
		///今开盘
		public TThostFtdcPriceType OpenPrice;
		///最高价
		public TThostFtdcPriceType HighestPrice;
		///最低价
		public TThostFtdcPriceType LowestPrice;
		///今收盘
		public TThostFtdcPriceType ClosePrice;
		///涨停板价
		public TThostFtdcPriceType UpperLimitPrice;
		///跌停板价
		public TThostFtdcPriceType LowerLimitPrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///今虚实度
		public TThostFtdcRatioType CurrDelta;
	}

	///行情最新成交属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataLastMatchField
	{
		///最新价
		public TThostFtdcPriceType LastPrice;
		///数量
		public TThostFtdcVolumeType Volume;
		///成交金额
		public TThostFtdcMoneyType Turnover;
		///持仓量
		public TThostFtdcLargeVolumeType OpenInterest;
	}

	///行情最优价属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataBestPriceField
	{
		///申买价一
		public TThostFtdcPriceType BidPrice1;
		///申买量一
		public TThostFtdcVolumeType BidVolume1;
		///申卖价一
		public TThostFtdcPriceType AskPrice1;
		///申卖量一
		public TThostFtdcVolumeType AskVolume1;
	}

	///行情申买二、三属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataBid23Field
	{
		///申买价二
		public TThostFtdcPriceType BidPrice2;
		///申买量二
		public TThostFtdcVolumeType BidVolume2;
		///申买价三
		public TThostFtdcPriceType BidPrice3;
		///申买量三
		public TThostFtdcVolumeType BidVolume3;
	}

	///行情申卖二、三属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataAsk23Field
	{
		///申卖价二
		public TThostFtdcPriceType AskPrice2;
		///申卖量二
		public TThostFtdcVolumeType AskVolume2;
		///申卖价三
		public TThostFtdcPriceType AskPrice3;
		///申卖量三
		public TThostFtdcVolumeType AskVolume3;
	}

	///行情申买四、五属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataBid45Field
	{
		///申买价四
		public TThostFtdcPriceType BidPrice4;
		///申买量四
		public TThostFtdcVolumeType BidVolume4;
		///申买价五
		public TThostFtdcPriceType BidPrice5;
		///申买量五
		public TThostFtdcVolumeType BidVolume5;
	}

	///行情申卖四、五属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataAsk45Field
	{
		///申卖价四
		public TThostFtdcPriceType AskPrice4;
		///申卖量四
		public TThostFtdcVolumeType AskVolume4;
		///申卖价五
		public TThostFtdcPriceType AskPrice5;
		///申卖量五
		public TThostFtdcVolumeType AskVolume5;
	}

	///行情更新时间属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataUpdateTimeField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///最后修改毫秒
		public TThostFtdcMillisecType UpdateMillisec;
		///业务日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDay;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///行情上下带价
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataBandingPriceField
	{
		///上带价
		public TThostFtdcPriceType BandingUpperPrice;
		///下带价
		public TThostFtdcPriceType BandingLowerPrice;
	}

	///行情交易所代码属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataExchangeField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///指定的合约
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSpecificInstrumentField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///合约状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInstrumentStatusField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///结算组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcSettlementGroupIDType SettlementGroupID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///合约交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInstrumentStatusType InstrumentStatus;
		///交易阶段编号
		public TThostFtdcTradingSegmentSNType TradingSegmentSN;
		///进入本状态时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType EnterTime;
		///进入本状态原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInstStatusEnterReasonType EnterReason;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询合约状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInstrumentStatusField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve1;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
	}

	///投资者账户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorAccountField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///浮动盈亏算法
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcPositionProfitAlgorithmField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///盈亏算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAlgorithmType Algorithm;
		///备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcMemoType Memo;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///会员资金折扣
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcDiscountField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///资金折扣比例
		public TThostFtdcRatioType Discount;
	}

	///查询转帐银行
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTransferBankField
	{
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分中心代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBrchID;
	}

	///转帐银行
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferBankField
	{
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分中心代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBrchID;
		///银行名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcBankNameType BankName;
		///是否活跃
		public TThostFtdcBoolType IsActive;
	}

	///查询投资者持仓明细
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestorPositionDetailField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///投资者持仓明细
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorPositionDetailField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///买卖
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///开仓日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///数量
		public TThostFtdcVolumeType Volume;
		///开仓价
		public TThostFtdcPriceType OpenPrice;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///成交类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeTypeType TradeType;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///逐日盯市平仓盈亏
		public TThostFtdcMoneyType CloseProfitByDate;
		///逐笔对冲平仓盈亏
		public TThostFtdcMoneyType CloseProfitByTrade;
		///逐日盯市持仓盈亏
		public TThostFtdcMoneyType PositionProfitByDate;
		///逐笔对冲持仓盈亏
		public TThostFtdcMoneyType PositionProfitByTrade;
		///投资者保证金
		public TThostFtdcMoneyType Margin;
		///交易所保证金
		public TThostFtdcMoneyType ExchMargin;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///昨结算价
		public TThostFtdcPriceType LastSettlementPrice;
		///结算价
		public TThostFtdcPriceType SettlementPrice;
		///平仓量
		public TThostFtdcVolumeType CloseVolume;
		///平仓金额
		public TThostFtdcMoneyType CloseAmount;
		///先开先平剩余数量（DCE）
		public TThostFtdcVolumeType TimeFirstVolume;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///特殊持仓标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcSpecPosiTypeType SpecPosiType;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///组合合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
	}

	///资金账户口令域
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingAccountPasswordField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///交易所行情报盘机
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMDTraderOfferField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///交易所交易员连接状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTraderConnectStatusType TraderConnectStatus;
		///发出连接请求的日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ConnectRequestDate;
		///发出连接请求的时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ConnectRequestTime;
		///上次报告日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType LastReportDate;
		///上次报告时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType LastReportTime;
		///完成连接日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ConnectDate;
		///完成连接时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ConnectTime;
		///启动日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType StartDate;
		///启动时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType StartTime;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///本席位最大成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType MaxTradeID;
		///本席位最大报单备拷
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcReturnCodeType MaxOrderMessageReference;
		///撤单时选择席位算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderCancelAlgType OrderCancelAlg;
	}

	///查询行情报盘机
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMDTraderOfferField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
	}

	///查询客户通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryNoticeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
	}

	///客户通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcNoticeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///消息正文
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
		public TThostFtdcContentType Content;
		///经纪公司通知内容序列号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
		public TThostFtdcSequenceLabelType SequenceLabel;
	}

	///用户权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserRightField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///客户权限类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcUserRightTypeType UserRightType;
		///是否禁止
		public TThostFtdcBoolType IsForbidden;
	}

	///查询结算信息确认域
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySettlementInfoConfirmField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///装载结算信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcLoadSettlementInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
	}

	///经纪公司可提资金算法表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerWithdrawAlgorithmField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///可提资金算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAlgorithmType WithdrawAlgorithm;
		///资金使用率
		public TThostFtdcRatioType UsingRatio;
		///可提是否包含平仓盈利
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIncludeCloseProfitType IncludeCloseProfit;
		///本日无仓且无成交客户是否受可提比例限制
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAllWithoutTradeType AllWithoutTrade;
		///可用是否包含平仓盈利
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIncludeCloseProfitType AvailIncludeCloseProfit;
		///是否启用用户事件
		public TThostFtdcBoolType IsBrokerUserEvent;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///货币质押比率
		public TThostFtdcRatioType FundMortgageRatio;
		///权益算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBalanceAlgorithmType BalanceAlgorithm;
	}

	///资金账户口令变更域
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingAccountPasswordUpdateV1Field
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///原来的口令
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OldPassword;
		///新的口令
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType NewPassword;
	}

	///资金账户口令变更域
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingAccountPasswordUpdateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///原来的口令
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OldPassword;
		///新的口令
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType NewPassword;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///查询组合合约分腿
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCombinationLegField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///单腿编号
		public TThostFtdcLegIDType LegID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///组合合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
		///单腿合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType LegInstrumentID;
	}

	///查询组合合约分腿
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySyncStatusField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
	}

	///组合交易合约的单腿
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCombinationLegField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///单腿编号
		public TThostFtdcLegIDType LegID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///单腿乘数
		public TThostFtdcLegMultipleType LegMultiple;
		///派生层数
		public TThostFtdcImplyLevelType ImplyLevel;
		///组合合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
		///单腿合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType LegInstrumentID;
	}

	///数据同步状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncStatusField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///数据同步状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDataSyncStatusType DataSyncStatus;
	}

	///查询联系人
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryLinkManField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///联系人
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcLinkManField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///联系人类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPersonTypeType PersonType;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdentifiedCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcPartyNameType PersonName;
		///联系电话
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///通讯地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮政编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///优先级
		public TThostFtdcPriorityType Priority;
		///开户邮政编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcUOAZipCodeType UOAZipCode;
		///全称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcInvestorFullNameType PersonFullName;
	}

	///查询经纪公司用户事件
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBrokerUserEventField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户事件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcUserEventTypeType UserEventType;
	}

	///查询经纪公司用户事件
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerUserEventField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户事件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcUserEventTypeType UserEventType;
		///用户事件序号
		public TThostFtdcSequenceNoType EventSequenceNo;
		///事件发生日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType EventDate;
		///事件发生时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType EventTime;
		///用户事件信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
		public TThostFtdcUserEventInfoType UserEventInfo;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询签约银行请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryContractBankField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分中心代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBrchID;
	}

	///查询签约银行响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcContractBankField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分中心代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBrchID;
		///银行名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcBankNameType BankName;
	}

	///投资者组合持仓明细
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorPositionCombineDetailField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///开仓日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///组合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType ComTradeID;
		///撮合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///买卖
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///持仓量
		public TThostFtdcVolumeType TotalAmt;
		///投资者保证金
		public TThostFtdcMoneyType Margin;
		///交易所保证金
		public TThostFtdcMoneyType ExchMargin;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///单腿编号
		public TThostFtdcLegIDType LegID;
		///单腿乘数
		public TThostFtdcLegMultipleType LegMultiple;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///成交组号
		public TThostFtdcTradeGroupIDType TradeGroupID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///组合持仓合约编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
	}

	///预埋单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcParkedOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///报单价格条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderPriceTypeType OrderPriceType;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///组合开平标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombOffsetFlagType CombOffsetFlag;
		///组合投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量
		public TThostFtdcVolumeType VolumeTotalOriginal;
		///有效期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTimeConditionType TimeCondition;
		///GTD日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType GTDDate;
		///成交量类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcVolumeConditionType VolumeCondition;
		///最小成交量
		public TThostFtdcVolumeType MinVolume;
		///触发条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcContingentConditionType ContingentCondition;
		///止损价
		public TThostFtdcPriceType StopPrice;
		///强平原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForceCloseReasonType ForceCloseReason;
		///自动挂起标志
		public TThostFtdcBoolType IsAutoSuspend;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///用户强评标志
		public TThostFtdcBoolType UserForceClose;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///预埋报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcParkedOrderIDType ParkedOrderID;
		///用户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcUserTypeType UserType;
		///预埋单状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcParkedOrderStatusType Status;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///互换单标志
		public TThostFtdcBoolType IsSwapOrder;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///输入预埋单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcParkedOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报单操作引用
		public TThostFtdcOrderActionRefType OrderActionRef;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量变化
		public TThostFtdcVolumeType VolumeChange;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///预埋撤单单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcParkedOrderActionIDType ParkedOrderActionID;
		///用户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcUserTypeType UserType;
		///预埋撤单状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcParkedOrderStatusType Status;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询预埋单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryParkedOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询预埋撤单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryParkedOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///删除预埋单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRemoveParkedOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///预埋报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcParkedOrderIDType ParkedOrderID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///删除预埋撤单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRemoveParkedOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///预埋撤单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcParkedOrderActionIDType ParkedOrderActionID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///经纪公司可提资金算法表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorWithdrawAlgorithmField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///可提资金比例
		public TThostFtdcRatioType UsingRatio;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///货币质押比率
		public TThostFtdcRatioType FundMortgageRatio;
	}

	///查询组合持仓明细
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestorPositionCombineDetailField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///组合持仓合约编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
	}

	///成交均价
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarketDataAveragePriceField
	{
		///当日均价
		public TThostFtdcPriceType AveragePrice;
	}

	///校验投资者密码
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcVerifyInvestorPasswordField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
	}

	///用户IP
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserIPField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
		///IP地址掩码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPMask;
	}

	///用户事件通知信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingNoticeInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///发送时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SendTime;
		///消息正文
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
		public TThostFtdcContentType FieldContent;
		///序列系列号
		public TThostFtdcSequenceSeriesType SequenceSeries;
		///序列号
		public TThostFtdcSequenceNoType SequenceNo;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///用户事件通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingNoticeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///序列系列号
		public TThostFtdcSequenceSeriesType SequenceSeries;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///发送时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SendTime;
		///序列号
		public TThostFtdcSequenceNoType SequenceNo;
		///消息正文
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
		public TThostFtdcContentType FieldContent;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///查询交易事件通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTradingNoticeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///查询错误报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryErrOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///错误报单
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcErrOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///报单价格条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderPriceTypeType OrderPriceType;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///组合开平标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombOffsetFlagType CombOffsetFlag;
		///组合投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量
		public TThostFtdcVolumeType VolumeTotalOriginal;
		///有效期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTimeConditionType TimeCondition;
		///GTD日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType GTDDate;
		///成交量类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcVolumeConditionType VolumeCondition;
		///最小成交量
		public TThostFtdcVolumeType MinVolume;
		///触发条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcContingentConditionType ContingentCondition;
		///止损价
		public TThostFtdcPriceType StopPrice;
		///强平原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForceCloseReasonType ForceCloseReason;
		///自动挂起标志
		public TThostFtdcBoolType IsAutoSuspend;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///用户强评标志
		public TThostFtdcBoolType UserForceClose;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///互换单标志
		public TThostFtdcBoolType IsSwapOrder;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询错误报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcErrorConditionalOrderField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///报单价格条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderPriceTypeType OrderPriceType;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///组合开平标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombOffsetFlagType CombOffsetFlag;
		///组合投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量
		public TThostFtdcVolumeType VolumeTotalOriginal;
		///有效期类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTimeConditionType TimeCondition;
		///GTD日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType GTDDate;
		///成交量类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcVolumeConditionType VolumeCondition;
		///最小成交量
		public TThostFtdcVolumeType MinVolume;
		///触发条件
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcContingentConditionType ContingentCondition;
		///止损价
		public TThostFtdcPriceType StopPrice;
		///强平原因
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcForceCloseReasonType ForceCloseReason;
		///自动挂起标志
		public TThostFtdcBoolType IsAutoSuspend;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldExchangeInstIDType reserve2;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///报单提交状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
		///报单提示序号
		public TThostFtdcSequenceNoType NotifySequence;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///报单来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderSourceType OrderSource;
		///报单状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderStatusType OrderStatus;
		///报单类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderTypeType OrderType;
		///今成交数量
		public TThostFtdcVolumeType VolumeTraded;
		///剩余数量
		public TThostFtdcVolumeType VolumeTotal;
		///报单日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType InsertDate;
		///委托时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType InsertTime;
		///激活时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActiveTime;
		///挂起时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SuspendTime;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///撤销时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CancelTime;
		///最后修改交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType ActiveTraderID;
		///结算会员编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ClearingPartID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///用户强评标志
		public TThostFtdcBoolType UserForceClose;
		///操作用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType ActiveUserID;
		///经纪公司报单编号
		public TThostFtdcSequenceNoType BrokerOrderSeq;
		///相关报单
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType RelativeOrderSysID;
		///郑商所成交数量
		public TThostFtdcVolumeType ZCETotalTradedVolume;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///互换单标志
		public TThostFtdcBoolType IsSwapOrder;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///资金账号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve3;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询错误报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryErrOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///错误报单操作
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcErrOrderActionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///报单操作引用
		public TThostFtdcOrderActionRefType OrderActionRef;
		///报单引用
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderRefType OrderRef;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///前置编号
		public TThostFtdcFrontIDType FrontID;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcOrderSysIDType OrderSysID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionFlagType ActionFlag;
		///价格
		public TThostFtdcPriceType LimitPrice;
		///数量变化
		public TThostFtdcVolumeType VolumeChange;
		///操作日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDate;
		///操作时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ActionTime;
		///交易所交易员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTraderIDType TraderID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///本地报单编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType OrderLocalID;
		///操作本地编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcOrderLocalIDType ActionLocalID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///客户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcClientIDType ClientID;
		///业务单元
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcBusinessUnitType BusinessUnit;
		///报单操作状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOrderActionStatusType OrderActionStatus;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///状态信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType StatusMsg;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///营业部编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcBranchIDType BranchID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve2;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询交易所状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryExchangeSequenceField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///交易所状态
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcExchangeSequenceField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///序号
		public TThostFtdcSequenceNoType SequenceNo;
		///合约交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInstrumentStatusType MarketStatus;
	}

	///根据价格查询最大报单数量
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMaxOrderVolumeWithPriceField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///开平标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOffsetFlagType OffsetFlag;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///最大允许报单数量
		public TThostFtdcVolumeType MaxVolume;
		///报单价格
		public TThostFtdcPriceType Price;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询经纪公司交易参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBrokerTradingParamsField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
	}

	///经纪公司交易参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerTradingParamsField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保证金价格类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMarginPriceTypeType MarginPriceType;
		///盈亏算法
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAlgorithmType Algorithm;
		///可用是否包含平仓盈利
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIncludeCloseProfitType AvailIncludeCloseProfit;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///期权权利金价格类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOptionRoyaltyPriceTypeType OptionRoyaltyPriceType;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
	}

	///查询经纪公司交易算法
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBrokerTradingAlgosField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///经纪公司交易算法
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerTradingAlgosField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///持仓处理算法编号
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHandlePositionAlgoIDType HandlePositionAlgoID;
		///寻找保证金率算法编号
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFindMarginRateAlgoIDType FindMarginRateAlgoID;
		///资金处理算法编号
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHandleTradingAccountAlgoIDType HandleTradingAccountAlgoID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询经纪公司资金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQueryBrokerDepositField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
	}

	///经纪公司资金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerDepositField
	{
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///会员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///上次结算准备金
		public TThostFtdcMoneyType PreBalance;
		///当前保证金总额
		public TThostFtdcMoneyType CurrMargin;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///期货结算准备金
		public TThostFtdcMoneyType Balance;
		///入金金额
		public TThostFtdcMoneyType Deposit;
		///出金金额
		public TThostFtdcMoneyType Withdraw;
		///可提资金
		public TThostFtdcMoneyType Available;
		///基本准备金
		public TThostFtdcMoneyType Reserve;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
	}

	///查询保证金监管系统经纪公司密钥
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCFMMCBrokerKeyField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
	}

	///保证金监管系统经纪公司密钥
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCFMMCBrokerKeyField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///经纪公司统一编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///密钥生成日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType CreateDate;
		///密钥生成时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType CreateTime;
		///密钥编号
		public TThostFtdcSequenceNoType KeyID;
		///动态密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCFMMCKeyType CurrentKey;
		///动态密钥类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCFMMCKeyKindType KeyKind;
	}

	///保证金监管系统经纪公司资金账户密钥
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCFMMCTradingAccountKeyField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///经纪公司统一编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///密钥编号
		public TThostFtdcSequenceNoType KeyID;
		///动态密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCFMMCKeyType CurrentKey;
	}

	///请求查询保证金监管系统经纪公司资金账户密钥
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCFMMCTradingAccountKeyField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///用户动态令牌参数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerUserOTPParamField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///动态令牌提供商
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
		public TThostFtdcOTPVendorsIDType OTPVendorsID;
		///动态令牌序列号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcSerialNumberType SerialNumber;
		///令牌密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcAuthKeyType AuthKey;
		///漂移值
		public TThostFtdcLastDriftType LastDrift;
		///成功值
		public TThostFtdcLastSuccessType LastSuccess;
		///动态令牌类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOTPTypeType OTPType;
	}

	///手工同步用户动态令牌
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcManualSyncBrokerUserOTPField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///动态令牌类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOTPTypeType OTPType;
		///第一个动态密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType FirstOTP;
		///第二个动态密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType SecondOTP;
	}

	///投资者手续费率模板
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCommRateModelField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///手续费率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType CommModelID;
		///模板名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcCommModelNameType CommModelName;
	}

	///请求查询投资者手续费率模板
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCommRateModelField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///手续费率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType CommModelID;
	}

	///投资者保证金率模板
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMarginModelField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保证金率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType MarginModelID;
		///模板名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcCommModelNameType MarginModelName;
	}

	///请求查询投资者保证金率模板
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMarginModelField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///保证金率模板代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType MarginModelID;
	}

	///仓单折抵信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcEWarrantOffsetField
	{
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///数量
		public TThostFtdcVolumeType Volume;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询仓单折抵信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryEWarrantOffsetField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///查询投资者品种/跨品种保证金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryInvestorProductGroupMarginField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///品种/跨品种标示
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductGroupID;
	}

	///投资者品种/跨品种保证金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcInvestorProductGroupMarginField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///多头冻结的保证金
		public TThostFtdcMoneyType LongFrozenMargin;
		///空头冻结的保证金
		public TThostFtdcMoneyType ShortFrozenMargin;
		///占用的保证金
		public TThostFtdcMoneyType UseMargin;
		///多头保证金
		public TThostFtdcMoneyType LongUseMargin;
		///空头保证金
		public TThostFtdcMoneyType ShortUseMargin;
		///交易所保证金
		public TThostFtdcMoneyType ExchMargin;
		///交易所多头保证金
		public TThostFtdcMoneyType LongExchMargin;
		///交易所空头保证金
		public TThostFtdcMoneyType ShortExchMargin;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///手续费
		public TThostFtdcMoneyType Commission;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///折抵总金额
		public TThostFtdcMoneyType OffsetAmount;
		///多头折抵总金额
		public TThostFtdcMoneyType LongOffsetAmount;
		///空头折抵总金额
		public TThostFtdcMoneyType ShortOffsetAmount;
		///交易所折抵总金额
		public TThostFtdcMoneyType ExchOffsetAmount;
		///交易所多头折抵总金额
		public TThostFtdcMoneyType LongExchOffsetAmount;
		///交易所空头折抵总金额
		public TThostFtdcMoneyType ShortExchOffsetAmount;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///品种/跨品种标示
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductGroupID;
	}

	///查询监控中心用户令牌
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQueryCFMMCTradingAccountTokenField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
	}

	///监控中心用户令牌
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCFMMCTradingAccountTokenField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///经纪公司统一编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcParticipantIDType ParticipantID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///密钥编号
		public TThostFtdcSequenceNoType KeyID;
		///动态令牌
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCFMMCTokenType Token;
	}

	///查询产品组
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryProductGroupField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///投资者品种/跨品种保证金产品组
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcProductGroupField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve2;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///产品组代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductGroupID;
	}

	///交易所公告
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBulletinField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///公告编号
		public TThostFtdcBulletinIDType BulletinID;
		///序列号
		public TThostFtdcSequenceNoType SequenceNo;
		///公告类型
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcNewsTypeType NewsType;
		///紧急程度
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcNewsUrgencyType NewsUrgency;
		///发送时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType SendTime;
		///消息摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcAbstractType Abstract;
		///消息来源
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcComeFromType ComeFrom;
		///消息正文
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
		public TThostFtdcContentType Content;
		///WEB地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 201)]
		public TThostFtdcURLLinkType URLLink;
		///市场代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcMarketIDType MarketID;
	}

	///查询交易所公告
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryBulletinField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///公告编号
		public TThostFtdcBulletinIDType BulletinID;
		///序列号
		public TThostFtdcSequenceNoType SequenceNo;
		///公告类型
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcNewsTypeType NewsType;
		///紧急程度
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcNewsUrgencyType NewsUrgency;
	}

	///MulticastInstrument
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcMulticastInstrumentField
	{
		///主题号
		public TThostFtdcInstallIDType TopicID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约编号
		public TThostFtdcInstallIDType InstrumentNo;
		///基准价
		public TThostFtdcPriceType CodePrice;
		///合约数量乘数
		public TThostFtdcVolumeMultipleType VolumeMultiple;
		///最小变动价位
		public TThostFtdcPriceType PriceTick;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///QryMulticastInstrument
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryMulticastInstrumentField
	{
		///主题号
		public TThostFtdcInstallIDType TopicID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcOldInstrumentIDType reserve1;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///App客户端权限分配
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAppIDAuthAssignField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
		///交易中心代码
		public TThostFtdcDRIdentityIDType DRIdentityID;
	}

	///转帐开户请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqOpenAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///汇钞标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCashExchangeCodeType CashExchangeCode;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///交易ID
		public TThostFtdcTIDType TID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///转帐销户请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqCancelAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///汇钞标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCashExchangeCodeType CashExchangeCode;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///交易ID
		public TThostFtdcTIDType TID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///变更银行账户请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqChangeAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///新银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType NewBankAccount;
		///新银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType NewBankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易ID
		public TThostFtdcTIDType TID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///转账请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqTransferField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///转帐金额
		public TThostFtdcTradeAmountType TradeAmount;
		///期货可取金额
		public TThostFtdcTradeAmountType FutureFetchAmount;
		///费用支付标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFeePayFlagType FeePayFlag;
		///应收客户费用
		public TThostFtdcCustFeeType CustFee;
		///应收期货公司费用
		public TThostFtdcFutureFeeType BrokerFee;
		///发送方给接收方的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///转账交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTransferStatusType TransferStatus;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///银行发起银行资金转期货响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspTransferField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///转帐金额
		public TThostFtdcTradeAmountType TradeAmount;
		///期货可取金额
		public TThostFtdcTradeAmountType FutureFetchAmount;
		///费用支付标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFeePayFlagType FeePayFlag;
		///应收客户费用
		public TThostFtdcCustFeeType CustFee;
		///应收期货公司费用
		public TThostFtdcFutureFeeType BrokerFee;
		///发送方给接收方的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///转账交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTransferStatusType TransferStatus;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///冲正请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqRepealField
	{
		///冲正时间间隔
		public TThostFtdcRepealTimeIntervalType RepealTimeInterval;
		///已经冲正次数
		public TThostFtdcRepealedTimesType RepealedTimes;
		///银行冲正标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankRepealFlagType BankRepealFlag;
		///期商冲正标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBrokerRepealFlagType BrokerRepealFlag;
		///被冲正平台流水号
		public TThostFtdcPlateSerialType PlateRepealSerial;
		///被冲正银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankRepealSerial;
		///被冲正期货流水号
		public TThostFtdcFutureSerialType FutureRepealSerial;
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///转帐金额
		public TThostFtdcTradeAmountType TradeAmount;
		///期货可取金额
		public TThostFtdcTradeAmountType FutureFetchAmount;
		///费用支付标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFeePayFlagType FeePayFlag;
		///应收客户费用
		public TThostFtdcCustFeeType CustFee;
		///应收期货公司费用
		public TThostFtdcFutureFeeType BrokerFee;
		///发送方给接收方的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///转账交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTransferStatusType TransferStatus;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///冲正响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspRepealField
	{
		///冲正时间间隔
		public TThostFtdcRepealTimeIntervalType RepealTimeInterval;
		///已经冲正次数
		public TThostFtdcRepealedTimesType RepealedTimes;
		///银行冲正标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankRepealFlagType BankRepealFlag;
		///期商冲正标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBrokerRepealFlagType BrokerRepealFlag;
		///被冲正平台流水号
		public TThostFtdcPlateSerialType PlateRepealSerial;
		///被冲正银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankRepealSerial;
		///被冲正期货流水号
		public TThostFtdcFutureSerialType FutureRepealSerial;
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///转帐金额
		public TThostFtdcTradeAmountType TradeAmount;
		///期货可取金额
		public TThostFtdcTradeAmountType FutureFetchAmount;
		///费用支付标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFeePayFlagType FeePayFlag;
		///应收客户费用
		public TThostFtdcCustFeeType CustFee;
		///应收期货公司费用
		public TThostFtdcFutureFeeType BrokerFee;
		///发送方给接收方的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///转账交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTransferStatusType TransferStatus;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///查询账户信息请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqQueryAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///查询账户信息响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspQueryAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///银行可用金额
		public TThostFtdcTradeAmountType BankUseAmount;
		///银行可取金额
		public TThostFtdcTradeAmountType BankFetchAmount;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///期商签到签退
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcFutureSignIOField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
	}

	///期商签到响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspFutureSignInField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///PIN密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcPasswordKeyType PinKey;
		///MAC密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcPasswordKeyType MacKey;
	}

	///期商签退请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqFutureSignOutField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
	}

	///期商签退响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspFutureSignOutField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///查询指定流水号的交易结果请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqQueryTradeResultBySerialField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///流水号
		public TThostFtdcSerialType Reference;
		///本流水号发布者的机构类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInstitutionTypeType RefrenceIssureType;
		///本流水号发布者机构编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcOrganCodeType RefrenceIssure;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///转帐金额
		public TThostFtdcTradeAmountType TradeAmount;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///查询指定流水号的交易结果响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspQueryTradeResultBySerialField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///流水号
		public TThostFtdcSerialType Reference;
		///本流水号发布者的机构类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInstitutionTypeType RefrenceIssureType;
		///本流水号发布者机构编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcOrganCodeType RefrenceIssure;
		///原始返回代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcReturnCodeType OriginReturnCode;
		///原始返回码描述
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcDescrInfoForReturnCodeType OriginDescrInfoForReturnCode;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///转帐金额
		public TThostFtdcTradeAmountType TradeAmount;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
	}

	///日终文件就绪请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqDayEndFileReadyField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///文件业务功能
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFileBusinessCodeType FileBusinessCode;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
	}

	///返回结果
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReturnResultField
	{
		///返回代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcReturnCodeType ReturnCode;
		///返回码描述
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcDescrInfoForReturnCodeType DescrInfoForReturnCode;
	}

	///验证期货资金密码
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcVerifyFuturePasswordField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///交易ID
		public TThostFtdcTIDType TID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///验证客户信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcVerifyCustInfoField
	{
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///验证期货资金密码和客户信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcVerifyFuturePasswordAndCustInfoField
	{
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///验证期货资金密码和客户信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcDepositResultInformField
	{
		///出入金流水号，该流水号为银期报盘返回的流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType DepositSeqNo;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///入金金额
		public TThostFtdcMoneyType Deposit;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///返回代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcReturnCodeType ReturnCode;
		///返回码描述
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcDescrInfoForReturnCodeType DescrInfoForReturnCode;
	}

	///交易核心向银期报盘发出密钥同步请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqSyncKeyField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易核心给银期报盘的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
	}

	///交易核心向银期报盘发出密钥同步响应
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspSyncKeyField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易核心给银期报盘的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///查询账户信息通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcNotifyQueryAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///银行可用金额
		public TThostFtdcTradeAmountType BankUseAmount;
		///银行可取金额
		public TThostFtdcTradeAmountType BankFetchAmount;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///银期转账交易流水表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTransferSerialField
	{
		///平台流水号
		public TThostFtdcPlateSerialType PlateSerial;
		///交易发起方日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///交易代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///会话编号
		public TThostFtdcSessionIDType SessionID;
		///银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///期货公司编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///期货公司帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcFutureAccTypeType FutureAccType;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///期货公司流水号
		public TThostFtdcFutureSerialType FutureSerial;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///交易金额
		public TThostFtdcTradeAmountType TradeAmount;
		///应收客户费用
		public TThostFtdcCustFeeType CustFee;
		///应收期货公司费用
		public TThostFtdcFutureFeeType BrokerFee;
		///有效标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAvailabilityFlagType AvailabilityFlag;
		///操作员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperatorCodeType OperatorCode;
		///新银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankNewAccount;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///请求查询转帐流水
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryTransferSerialField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///期商签到通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcNotifyFutureSignInField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///PIN密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcPasswordKeyType PinKey;
		///MAC密钥
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcPasswordKeyType MacKey;
	}

	///期商签退通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcNotifyFutureSignOutField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///交易核心向银期报盘发出密钥同步处理结果的通知
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcNotifySyncKeyField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易核心给银期报盘的消息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public TThostFtdcAddInfoType Message;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///请求编号
		public TThostFtdcRequestIDType RequestID;
		///交易ID
		public TThostFtdcTIDType TID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///请求查询银期签约关系
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryAccountregisterField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///客户开销户信息表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAccountregisterField
	{
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDay;
		///银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///期货公司编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期货公司分支机构编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///开销户类别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcOpenOrDestroyType OpenOrDestroy;
		///签约日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType RegDate;
		///解约日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType OutDate;
		///交易ID
		public TThostFtdcTIDType TID;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///银期开户信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcOpenAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///汇钞标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCashExchangeCodeType CashExchangeCode;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///交易ID
		public TThostFtdcTIDType TID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///银期销户信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCancelAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///汇钞标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCashExchangeCodeType CashExchangeCode;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///渠道标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		public TThostFtdcDeviceIDType DeviceID;
		///期货单位帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankSecuAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///期货单位帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankSecuAcc;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易柜员
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcOperNoType OperNo;
		///交易ID
		public TThostFtdcTIDType TID;
		///用户标识
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///银期变更银行账号信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcChangeAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///新银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType NewBankAccount;
		///新银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType NewBankPassWord;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///银行密码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType BankPwdFlag;
		///期货资金密码核对标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPwdFlagType SecuPwdFlag;
		///交易ID
		public TThostFtdcTIDType TID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
		///长客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType LongCustomerName;
	}

	///二级代理操作员银期权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSecAgentACIDMapField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///境外中介机构资金帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType BrokerSecAgentID;
	}

	///二级代理操作员银期权限查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySecAgentACIDMapField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///资金账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///灾备中心交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserRightsAssignField
	{
		///应用单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///交易中心代码
		public TThostFtdcDRIdentityIDType DRIdentityID;
	}

	///经济公司是否有在本标示的交易权限
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcBrokerUserRightAssignField
	{
		///应用单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///交易中心代码
		public TThostFtdcDRIdentityIDType DRIdentityID;
		///能否交易
		public TThostFtdcBoolType Tradeable;
	}

	///灾备交易转换报文
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcDRTransferField
	{
		///原交易中心代码
		public TThostFtdcDRIdentityIDType OrigDRIdentityID;
		///目标交易中心代码
		public TThostFtdcDRIdentityIDType DestDRIdentityID;
		///原应用单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType OrigBrokerID;
		///目标易用单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType DestBrokerID;
	}

	///Fens用户信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcFensUserInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///登录模式
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLoginModeType LoginMode;
	}

	///当前银期所属交易中心
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCurrTransferIdentityField
	{
		///交易中心代码
		public TThostFtdcDRIdentityIDType IdentityID;
	}

	///禁止登录用户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcLoginForbiddenUserField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询禁止登录用户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryLoginForbiddenUserField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///资金账户基本准备金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcTradingAccountReserveField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///基本准备金
		public TThostFtdcMoneyType Reserve;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///查询禁止登录IP
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryLoginForbiddenIPField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询IP列表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryIPListField
	{
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询用户下单权限分配表
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryUserRightsAssignField
	{
		///应用单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///银期预约开户确认请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReserveOpenAccountConfirmField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易ID
		public TThostFtdcTIDType TID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///期货密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///预约开户银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankReserveOpenSeq;
		///预约开户日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType BookDate;
		///预约开户验证密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BookPsw;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///银期预约开户
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReserveOpenAccountField
	{
		///业务功能码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcTradeCodeType TradeCode;
		///银行代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcBankBrchIDType BankBranchID;
		///期商代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///期商分支机构代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcFutureBranchIDType BrokerBranchID;
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradeDate;
		///交易时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeTimeType TradeTime;
		///银行流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcBankSerialType BankSerial;
		///交易系统日期 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///银期平台消息流水号
		public TThostFtdcSerialType PlateSerial;
		///最后分片标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcLastFragmentType LastFragment;
		///会话号
		public TThostFtdcSessionIDType SessionID;
		///客户姓名
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
		public TThostFtdcLongIndividualNameType CustomerName;
		///证件类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcIdCardTypeType IdCardType;
		///证件号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		public TThostFtdcIdentifiedCardNoType IdentifiedCardNo;
		///性别
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcGenderType Gender;
		///国家代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcCountryCodeType CountryCode;
		///客户类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcCustTypeType CustType;
		///地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcAddressType Address;
		///邮编
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
		public TThostFtdcZipCodeType ZipCode;
		///电话号码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcTelephoneType Telephone;
		///手机
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMobilePhoneType MobilePhone;
		///传真
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcFaxType Fax;
		///电子邮件
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcEMailType EMail;
		///资金账户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
		///银行帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType BankPassWord;
		///安装编号
		public TThostFtdcInstallIDType InstallID;
		///验证客户证件号码标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///摘要
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcDigestType Digest;
		///银行帐号类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcBankAccTypeType BankAccType;
		///期货公司银行编码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcBankCodingForFutureType BrokerIDByBank;
		///交易ID
		public TThostFtdcTIDType TID;
		///预约开户状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcReserveOpenAccStasType ReserveOpenAccStas;
		///错误代码
		public TThostFtdcErrorIDType ErrorID;
		///错误信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcErrorMsgType ErrorMsg;
	}

	///银行账户属性
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAccountPropertyField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///银行统一标识类型
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcBankIDType BankID;
		///银行账户
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcBankAccountType BankAccount;
		///银行账户的开户人名称
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcInvestorFullNameType OpenName;
		///银行账户的开户行
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public TThostFtdcOpenBankType OpenBank;
		///是否活跃
		public TThostFtdcBoolType IsActive;
		///账户来源
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAccountSourceTypeType AccountSourceType;
		///开户日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///注销日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType CancelDate;
		///录入员代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
		public TThostFtdcOperatorIDType OperatorID;
		///录入日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OperateDate;
		///录入时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType OperateTime;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
	}

	///查询当前交易中心
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCurrDRIdentityField
	{
		///交易中心代码
		public TThostFtdcDRIdentityIDType DRIdentityID;
	}

	///当前交易中心
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCurrDRIdentityField
	{
		///交易中心代码
		public TThostFtdcDRIdentityIDType DRIdentityID;
	}

	///查询二级代理商资金校验模式
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySecAgentCheckModeField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///查询二级代理商信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQrySecAgentTradeInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///境外中介机构资金帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType BrokerSecAgentID;
	}

	///用户发出获取安全安全登陆方法请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqUserAuthMethodField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///用户发出获取安全安全登陆方法回复
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspUserAuthMethodField
	{
		///当前可以用的认证模式
		public TThostFtdcCurrentAuthMethodType UsableAuthMethod;
	}

	///用户发出获取安全安全登陆方法请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqGenUserCaptchaField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///生成的图片验证码信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspGenUserCaptchaField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///图片信息长度
		public TThostFtdcCaptchaInfoLenType CaptchaInfoLen;
		///图片信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2561)]
		public TThostFtdcCaptchaInfoType CaptchaInfo;
	}

	///用户发出获取安全安全登陆方法请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqGenUserTextField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
	}

	///短信验证码生成的回复
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspGenUserTextField
	{
		///短信验证码序号
		public TThostFtdcUserTextSeqType UserTextSeq;
	}

	///用户发出带图形验证码的登录请求请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqUserLoginWithCaptchaField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///图形验证码的文字内容
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Captcha;
		///终端IP端口
		public TThostFtdcIPPortType ClientIPPort;
		///终端IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientIPAddress;
	}

	///用户发出带短信验证码的登录请求请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqUserLoginWithTextField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///短信验证码文字内容
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Text;
		///终端IP端口
		public TThostFtdcIPPortType ClientIPPort;
		///终端IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientIPAddress;
	}

	///用户发出带动态验证码的登录请求请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqUserLoginWithOTPField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///OTP密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OTPPassword;
		///终端IP端口
		public TThostFtdcIPPortType ClientIPPort;
		///终端IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientIPAddress;
	}

	///api握手请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqApiHandshakeField
	{
		///api与front通信密钥版本号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
		public TThostFtdcCryptoKeyVersionType CryptoKeyVersion;
	}

	///front发给api的握手回复
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRspApiHandshakeField
	{
		///握手回复数据长度
		public TThostFtdcHandshakeDataLenType FrontHandshakeDataLen;
		///握手回复数据
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 301)]
		public TThostFtdcHandshakeDataType FrontHandshakeData;
		///API认证是否开启
		public TThostFtdcBoolType IsApiAuthEnabled;
	}

	///api给front的验证key的请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqVerifyApiKeyField
	{
		///握手回复数据长度
		public TThostFtdcHandshakeDataLenType ApiHandshakeDataLen;
		///握手回复数据
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 301)]
		public TThostFtdcHandshakeDataType ApiHandshakeData;
	}

	///操作员组织架构关系
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcDepartmentUserField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDepartmentRangeType InvestorRange;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
	}

	///查询频率，每秒查询比数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQueryFreqField
	{
		///查询频率
		public TThostFtdcQueryFreqType QueryFreq;
	}

	///禁止认证IP
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAuthForbiddenIPField
	{
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询禁止认证IP
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryAuthForbiddenIPField
	{
		///IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///换汇可提冻结
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDelaySwapFrozenField
	{
		///换汇流水号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
		public TThostFtdcDepositSeqNoType DelaySwapSeqNo;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///源币种
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType FromCurrencyID;
		///源剩余换汇额度(可提冻结)
		public TThostFtdcMoneyType FromRemainSwap;
		///是否手工换汇
		public TThostFtdcBoolType IsManualSwap;
	}

	///用户系统信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcUserSystemInfoField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///用户端系统内部信息长度
		public TThostFtdcSystemInfoLenType ClientSystemInfoLen;
		///用户端系统内部信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 273)]
		public TThostFtdcClientSystemInfoType ClientSystemInfo;
		///保留的无效字段
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcOldIPAddressType reserve1;
		///终端IP端口
		public TThostFtdcIPPortType ClientIPPort;
		///登录成功时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType ClientLoginTime;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType ClientAppID;
		///用户公网IP
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientPublicIP;
		///客户登录备注2
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 151)]
		public TThostFtdcClientLoginRemarkType ClientLoginRemark;
	}

	///终端用户绑定信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAuthUserIDField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///校验类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcAuthTypeType AuthType;
	}

	///用户IP绑定信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcAuthIPField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType IPAddress;
	}

	///查询分类合约
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryClassifiedInstrumentField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///合约交易状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradingTypeType TradingType;
		///合约分类类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcClassTypeType ClassType;
	}

	///查询组合优惠比例
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryCombPromotionParamField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///组合优惠比例
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcCombPromotionParamField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投机套保标志
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		public TThostFtdcCombHedgeFlagType CombHedgeFlag;
		///期权组合保证金比例
		public TThostFtdcDiscountRatioType Xparameter;
	}

	///国密用户登录请求
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcReqUserLoginSCField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///用户代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public TThostFtdcUserIDType UserID;
		///密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType Password;
		///用户端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType UserProductInfo;
		///接口端产品信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProductInfoType InterfaceProductInfo;
		///协议信息
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcProtocolInfoType ProtocolInfo;
		///Mac地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcMacAddressType MacAddress;
		///动态密码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
		public TThostFtdcPasswordType OneTimePassword;
		///终端IP地址
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcIPAddressType ClientIPAddress;
		///登录备注
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
		public TThostFtdcLoginRemarkType LoginRemark;
		///终端IP端口
		public TThostFtdcIPPortType ClientIPPort;
		///认证码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcAuthCodeType AuthCode;
		///App代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		public TThostFtdcAppIDType AppID;
	}

	///投资者风险结算持仓查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryRiskSettleInvstPositionField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
	}

	///风险结算产品查询
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcQryRiskSettleProductStatusField
	{
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
	}

	///投资者风险结算持仓
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRiskSettleInvstPositionField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///持仓多空方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPosiDirectionType PosiDirection;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///持仓日期
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcPositionDateType PositionDate;
		///上日持仓
		public TThostFtdcVolumeType YdPosition;
		///今日持仓
		public TThostFtdcVolumeType Position;
		///多头冻结
		public TThostFtdcVolumeType LongFrozen;
		///空头冻结
		public TThostFtdcVolumeType ShortFrozen;
		///开仓冻结金额
		public TThostFtdcMoneyType LongFrozenAmount;
		///开仓冻结金额
		public TThostFtdcMoneyType ShortFrozenAmount;
		///开仓量
		public TThostFtdcVolumeType OpenVolume;
		///平仓量
		public TThostFtdcVolumeType CloseVolume;
		///开仓金额
		public TThostFtdcMoneyType OpenAmount;
		///平仓金额
		public TThostFtdcMoneyType CloseAmount;
		///持仓成本
		public TThostFtdcMoneyType PositionCost;
		///上次占用的保证金
		public TThostFtdcMoneyType PreMargin;
		///占用的保证金
		public TThostFtdcMoneyType UseMargin;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///手续费
		public TThostFtdcMoneyType Commission;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///开仓成本
		public TThostFtdcMoneyType OpenCost;
		///交易所保证金
		public TThostFtdcMoneyType ExchangeMargin;
		///组合成交形成的持仓
		public TThostFtdcVolumeType CombPosition;
		///组合多头冻结
		public TThostFtdcVolumeType CombLongFrozen;
		///组合空头冻结
		public TThostFtdcVolumeType CombShortFrozen;
		///逐日盯市平仓盈亏
		public TThostFtdcMoneyType CloseProfitByDate;
		///逐笔对冲平仓盈亏
		public TThostFtdcMoneyType CloseProfitByTrade;
		///今日持仓
		public TThostFtdcVolumeType TodayPosition;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///执行冻结
		public TThostFtdcVolumeType StrikeFrozen;
		///执行冻结金额
		public TThostFtdcMoneyType StrikeFrozenAmount;
		///放弃执行冻结
		public TThostFtdcVolumeType AbandonFrozen;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///执行冻结的昨仓
		public TThostFtdcVolumeType YdStrikeFrozen;
		///投资单元代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public TThostFtdcInvestUnitIDType InvestUnitID;
		///大商所持仓成本差值，只有大商所使用
		public TThostFtdcMoneyType PositionCostOffset;
		///tas持仓手数
		public TThostFtdcVolumeType TasPosition;
		///tas持仓成本
		public TThostFtdcMoneyType TasPositionCost;
	}

	///风险品种
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcRiskSettleProductStatusField
	{
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///产品结算状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcProductStatusType ProductStatus;
	}

	///风险结算追平信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInfoField
	{
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
		///追平状态
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcSyncDeltaStatusType SyncDeltaStatus;
		///追平描述
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
		public TThostFtdcSyncDescriptionType SyncDescription;
		///是否只有资金追平
		public TThostFtdcBoolType IsOnlyTrdDelta;
	}

	///风险结算追平产品信息
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaProductStatusField
	{
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///是否允许交易
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcProductStatusType ProductStatus;
	}

	///风险结算追平持仓明细
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInvstPosDtlField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///买卖
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///开仓日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///成交编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///数量
		public TThostFtdcVolumeType Volume;
		///开仓价
		public TThostFtdcPriceType OpenPrice;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///成交类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcTradeTypeType TradeType;
		///组合合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///逐日盯市平仓盈亏
		public TThostFtdcMoneyType CloseProfitByDate;
		///逐笔对冲平仓盈亏
		public TThostFtdcMoneyType CloseProfitByTrade;
		///逐日盯市持仓盈亏
		public TThostFtdcMoneyType PositionProfitByDate;
		///逐笔对冲持仓盈亏
		public TThostFtdcMoneyType PositionProfitByTrade;
		///投资者保证金
		public TThostFtdcMoneyType Margin;
		///交易所保证金
		public TThostFtdcMoneyType ExchMargin;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///昨结算价
		public TThostFtdcPriceType LastSettlementPrice;
		///结算价
		public TThostFtdcPriceType SettlementPrice;
		///平仓量
		public TThostFtdcVolumeType CloseVolume;
		///平仓金额
		public TThostFtdcMoneyType CloseAmount;
		///先开先平剩余数量（DCE）
		public TThostFtdcVolumeType TimeFirstVolume;
		///特殊持仓标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcSpecPosiTypeType SpecPosiType;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平组合持仓明细
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInvstPosCombDtlField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///开仓日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType OpenDate;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///组合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType ComTradeID;
		///撮合编号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		public TThostFtdcTradeIDType TradeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///买卖
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///持仓量
		public TThostFtdcVolumeType TotalAmt;
		///投资者保证金
		public TThostFtdcMoneyType Margin;
		///交易所保证金
		public TThostFtdcMoneyType ExchMargin;
		///保证金率
		public TThostFtdcRatioType MarginRateByMoney;
		///保证金率(按手数)
		public TThostFtdcRatioType MarginRateByVolume;
		///单腿编号
		public TThostFtdcLegIDType LegID;
		///单腿乘数
		public TThostFtdcLegMultipleType LegMultiple;
		///成交组号
		public TThostFtdcTradeGroupIDType TradeGroupID;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平资金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaTradingAccountField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者帐号
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcAccountIDType AccountID;
		///上次质押金额
		public TThostFtdcMoneyType PreMortgage;
		///上次信用额度
		public TThostFtdcMoneyType PreCredit;
		///上次存款额
		public TThostFtdcMoneyType PreDeposit;
		///上次结算准备金
		public TThostFtdcMoneyType PreBalance;
		///上次占用的保证金
		public TThostFtdcMoneyType PreMargin;
		///利息基数
		public TThostFtdcMoneyType InterestBase;
		///利息收入
		public TThostFtdcMoneyType Interest;
		///入金金额
		public TThostFtdcMoneyType Deposit;
		///出金金额
		public TThostFtdcMoneyType Withdraw;
		///冻结的保证金
		public TThostFtdcMoneyType FrozenMargin;
		///冻结的资金
		public TThostFtdcMoneyType FrozenCash;
		///冻结的手续费
		public TThostFtdcMoneyType FrozenCommission;
		///当前保证金总额
		public TThostFtdcMoneyType CurrMargin;
		///资金差额
		public TThostFtdcMoneyType CashIn;
		///手续费
		public TThostFtdcMoneyType Commission;
		///平仓盈亏
		public TThostFtdcMoneyType CloseProfit;
		///持仓盈亏
		public TThostFtdcMoneyType PositionProfit;
		///期货结算准备金
		public TThostFtdcMoneyType Balance;
		///可用资金
		public TThostFtdcMoneyType Available;
		///可取资金
		public TThostFtdcMoneyType WithdrawQuota;
		///基本准备金
		public TThostFtdcMoneyType Reserve;
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///结算编号
		public TThostFtdcSettlementIDType SettlementID;
		///信用额度
		public TThostFtdcMoneyType Credit;
		///质押金额
		public TThostFtdcMoneyType Mortgage;
		///交易所保证金
		public TThostFtdcMoneyType ExchangeMargin;
		///投资者交割保证金
		public TThostFtdcMoneyType DeliveryMargin;
		///交易所交割保证金
		public TThostFtdcMoneyType ExchangeDeliveryMargin;
		///保底期货结算准备金
		public TThostFtdcMoneyType ReserveBalance;
		///币种代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType CurrencyID;
		///上次货币质入金额
		public TThostFtdcMoneyType PreFundMortgageIn;
		///上次货币质出金额
		public TThostFtdcMoneyType PreFundMortgageOut;
		///货币质入金额
		public TThostFtdcMoneyType FundMortgageIn;
		///货币质出金额
		public TThostFtdcMoneyType FundMortgageOut;
		///货币质押余额
		public TThostFtdcMoneyType FundMortgageAvailable;
		///可质押货币金额
		public TThostFtdcMoneyType MortgageableFund;
		///特殊产品占用保证金
		public TThostFtdcMoneyType SpecProductMargin;
		///特殊产品冻结保证金
		public TThostFtdcMoneyType SpecProductFrozenMargin;
		///特殊产品手续费
		public TThostFtdcMoneyType SpecProductCommission;
		///特殊产品冻结手续费
		public TThostFtdcMoneyType SpecProductFrozenCommission;
		///特殊产品持仓盈亏
		public TThostFtdcMoneyType SpecProductPositionProfit;
		///特殊产品平仓盈亏
		public TThostFtdcMoneyType SpecProductCloseProfit;
		///根据持仓盈亏算法计算的特殊产品持仓盈亏
		public TThostFtdcMoneyType SpecProductPositionProfitByAlg;
		///特殊产品交易所保证金
		public TThostFtdcMoneyType SpecProductExchangeMargin;
		///延时换汇冻结金额
		public TThostFtdcMoneyType FrozenSwap;
		///剩余换汇额度
		public TThostFtdcMoneyType RemainSwap;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///投资者风险结算总保证金
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInitInvstMarginField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///追平前总风险保证金
		public TThostFtdcMoneyType LastRiskTotalInvstMargin;
		///追平前交易所总风险保证金
		public TThostFtdcMoneyType LastRiskTotalExchMargin;
		///本次追平品种总保证金
		public TThostFtdcMoneyType ThisSyncInvstMargin;
		///本次追平品种交易所总保证金
		public TThostFtdcMoneyType ThisSyncExchMargin;
		///本次未追平品种总保证金
		public TThostFtdcMoneyType RemainRiskInvstMargin;
		///本次未追平品种交易所总保证金
		public TThostFtdcMoneyType RemainRiskExchMargin;
		///追平前总特殊产品风险保证金
		public TThostFtdcMoneyType LastRiskSpecTotalInvstMargin;
		///追平前总特殊产品交易所风险保证金
		public TThostFtdcMoneyType LastRiskSpecTotalExchMargin;
		///本次追平品种特殊产品总保证金
		public TThostFtdcMoneyType ThisSyncSpecInvstMargin;
		///本次追平品种特殊产品交易所总保证金
		public TThostFtdcMoneyType ThisSyncSpecExchMargin;
		///本次未追平品种特殊产品总保证金
		public TThostFtdcMoneyType RemainRiskSpecInvstMargin;
		///本次未追平品种特殊产品交易所总保证金
		public TThostFtdcMoneyType RemainRiskSpecExchMargin;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平组合优先级
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaDceCombInstrumentField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType CombInstrumentID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///成交组号
		public TThostFtdcTradeGroupIDType TradeGroupID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType CombHedgeFlag;
		///组合类型
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDceCombinationTypeType CombinationType;
		///买卖
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///期权组合保证金比例
		public TThostFtdcDiscountRatioType Xparameter;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平投资者期货保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInvstMarginRateField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///是否相对交易所收取
		public TThostFtdcBoolType IsRelative;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平交易所期货保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaExchMarginRateField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平中金现货期权交易所保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaOptExchMarginField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投机空头保证金调整系数
		public TThostFtdcRatioType SShortMarginRatioByMoney;
		///投机空头保证金调整系数
		public TThostFtdcMoneyType SShortMarginRatioByVolume;
		///保值空头保证金调整系数
		public TThostFtdcRatioType HShortMarginRatioByMoney;
		///保值空头保证金调整系数
		public TThostFtdcMoneyType HShortMarginRatioByVolume;
		///套利空头保证金调整系数
		public TThostFtdcRatioType AShortMarginRatioByMoney;
		///套利空头保证金调整系数
		public TThostFtdcMoneyType AShortMarginRatioByVolume;
		///做市商空头保证金调整系数
		public TThostFtdcRatioType MShortMarginRatioByMoney;
		///做市商空头保证金调整系数
		public TThostFtdcMoneyType MShortMarginRatioByVolume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平中金现货期权投资者保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaOptInvstMarginField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机空头保证金调整系数
		public TThostFtdcRatioType SShortMarginRatioByMoney;
		///投机空头保证金调整系数
		public TThostFtdcMoneyType SShortMarginRatioByVolume;
		///保值空头保证金调整系数
		public TThostFtdcRatioType HShortMarginRatioByMoney;
		///保值空头保证金调整系数
		public TThostFtdcMoneyType HShortMarginRatioByVolume;
		///套利空头保证金调整系数
		public TThostFtdcRatioType AShortMarginRatioByMoney;
		///套利空头保证金调整系数
		public TThostFtdcMoneyType AShortMarginRatioByVolume;
		///是否跟随交易所收取
		public TThostFtdcBoolType IsRelative;
		///做市商空头保证金调整系数
		public TThostFtdcRatioType MShortMarginRatioByMoney;
		///做市商空头保证金调整系数
		public TThostFtdcMoneyType MShortMarginRatioByVolume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平期权标的调整保证金率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInvstMarginRateULField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///多头保证金率
		public TThostFtdcRatioType LongMarginRatioByMoney;
		///多头保证金费
		public TThostFtdcMoneyType LongMarginRatioByVolume;
		///空头保证金率
		public TThostFtdcRatioType ShortMarginRatioByMoney;
		///空头保证金费
		public TThostFtdcMoneyType ShortMarginRatioByVolume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平期权手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaOptInvstCommRateField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///执行手续费率
		public TThostFtdcRatioType StrikeRatioByMoney;
		///执行手续费
		public TThostFtdcRatioType StrikeRatioByVolume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平期货手续费率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaInvstCommRateField
	{
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///投资者范围
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcInvestorRangeType InvestorRange;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///开仓手续费率
		public TThostFtdcRatioType OpenRatioByMoney;
		///开仓手续费
		public TThostFtdcRatioType OpenRatioByVolume;
		///平仓手续费率
		public TThostFtdcRatioType CloseRatioByMoney;
		///平仓手续费
		public TThostFtdcRatioType CloseRatioByVolume;
		///平今手续费率
		public TThostFtdcRatioType CloseTodayRatioByMoney;
		///平今手续费
		public TThostFtdcRatioType CloseTodayRatioByVolume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平交叉汇率
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaProductExchRateField
	{
		///产品代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType ProductID;
		///报价币种类型
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public TThostFtdcCurrencyIDType QuoteCurrencyID;
		///汇率
		public TThostFtdcExchangeRateType ExchangeRate;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平行情
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaDepthMarketDataField
	{
		///交易日
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType TradingDay;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约在交易所的代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcExchangeInstIDType ExchangeInstID;
		///最新价
		public TThostFtdcPriceType LastPrice;
		///上次结算价
		public TThostFtdcPriceType PreSettlementPrice;
		///昨收盘
		public TThostFtdcPriceType PreClosePrice;
		///昨持仓量
		public TThostFtdcLargeVolumeType PreOpenInterest;
		///今开盘
		public TThostFtdcPriceType OpenPrice;
		///最高价
		public TThostFtdcPriceType HighestPrice;
		///最低价
		public TThostFtdcPriceType LowestPrice;
		///数量
		public TThostFtdcVolumeType Volume;
		///成交金额
		public TThostFtdcMoneyType Turnover;
		///持仓量
		public TThostFtdcLargeVolumeType OpenInterest;
		///今收盘
		public TThostFtdcPriceType ClosePrice;
		///本次结算价
		public TThostFtdcPriceType SettlementPrice;
		///涨停板价
		public TThostFtdcPriceType UpperLimitPrice;
		///跌停板价
		public TThostFtdcPriceType LowerLimitPrice;
		///昨虚实度
		public TThostFtdcRatioType PreDelta;
		///今虚实度
		public TThostFtdcRatioType CurrDelta;
		///最后修改时间
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTimeType UpdateTime;
		///最后修改毫秒
		public TThostFtdcMillisecType UpdateMillisec;
		///申买价一
		public TThostFtdcPriceType BidPrice1;
		///申买量一
		public TThostFtdcVolumeType BidVolume1;
		///申卖价一
		public TThostFtdcPriceType AskPrice1;
		///申卖量一
		public TThostFtdcVolumeType AskVolume1;
		///申买价二
		public TThostFtdcPriceType BidPrice2;
		///申买量二
		public TThostFtdcVolumeType BidVolume2;
		///申卖价二
		public TThostFtdcPriceType AskPrice2;
		///申卖量二
		public TThostFtdcVolumeType AskVolume2;
		///申买价三
		public TThostFtdcPriceType BidPrice3;
		///申买量三
		public TThostFtdcVolumeType BidVolume3;
		///申卖价三
		public TThostFtdcPriceType AskPrice3;
		///申卖量三
		public TThostFtdcVolumeType AskVolume3;
		///申买价四
		public TThostFtdcPriceType BidPrice4;
		///申买量四
		public TThostFtdcVolumeType BidVolume4;
		///申卖价四
		public TThostFtdcPriceType AskPrice4;
		///申卖量四
		public TThostFtdcVolumeType AskVolume4;
		///申买价五
		public TThostFtdcPriceType BidPrice5;
		///申买量五
		public TThostFtdcVolumeType BidVolume5;
		///申卖价五
		public TThostFtdcPriceType AskPrice5;
		///申卖量五
		public TThostFtdcVolumeType AskVolume5;
		///当日均价
		public TThostFtdcPriceType AveragePrice;
		///业务日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcDateType ActionDay;
		///上带价
		public TThostFtdcPriceType BandingUpperPrice;
		///下带价
		public TThostFtdcPriceType BandingLowerPrice;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平现货指数
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaIndexPriceField
	{
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///指数现货收盘价
		public TThostFtdcPriceType ClosePrice;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}

	///风险结算追平仓单折抵
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]
	public class CThostFtdcSyncDeltaEWarrantOffsetField
	{
		///交易日期
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcTradeDateType TradingDay;
		///经纪公司代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
		public TThostFtdcBrokerIDType BrokerID;
		///投资者代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public TThostFtdcInvestorIDType InvestorID;
		///交易所代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public TThostFtdcExchangeIDType ExchangeID;
		///合约代码
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public TThostFtdcInstrumentIDType InstrumentID;
		///买卖方向
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcDirectionType Direction;
		///投机套保标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcHedgeFlagType HedgeFlag;
		///数量
		public TThostFtdcVolumeType Volume;
		///操作标志
		[MarshalAs(UnmanagedType.I1)]
		public TThostFtdcActionDirectionType ActionDirection;
		///追平序号
		public TThostFtdcSequenceNoType SyncDeltaSequenceNo;
	}
	#endregion Structs


}
