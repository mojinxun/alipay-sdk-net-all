using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class OrderQueryDTO
{
    /// <summary>
    /// 订单编号
    /// </summary>
    [XmlElement("orderNo")]
    public string OrderNo { get; set; }

    /// <summary>
    /// 订购编号
    /// </summary>
    [XmlElement("subscriptionNo")]
    public string SubscriptionNo { get; set; }

    /// <summary>
    /// 用户UID
    /// </summary>
    [XmlElement("userId")]
    public string UserId { get; set; }

    /// <summary>
    /// 产品编号
    /// </summary>
    [XmlElement("productNo")]
    public string ProductNo { get; set; }

    /// <summary>
    /// 商户PID
    /// </summary>
    [XmlElement("merchantPid")]
    public string MerchantPId { get; set; }

    /// <summary>
    /// 订单状态
    /// 下单中 ORDERING，
    /// 已下单 ORDERED，
    /// 支付中PAYING，
    /// 已支付PAID，
    /// 支付失败PAY_FAILED，
    /// 已取消CANCEL，
    /// 已退款REFUNDED，
    /// 已暂停PAUSED，
    /// </summary>
    [XmlElement("orderStatus")]
    public string OrderStatus { get; set; }

    /// <summary>
    /// 下单时间
    /// </summary>
    [XmlElement("orderDate")]
    public string OrderDate { get; set; }

    /// <summary>
    /// 计划扣款时间
    /// yyyy-MM-dd HH:mm:ss
    /// </summary>
    [XmlElement("planDeductionTime")]
    public string PlanDeductionTime { get; set; }

    /// <summary>
    /// 实际扣款时间
    /// yyyy-MM-dd HH:mm:ss
    /// </summary>
    [XmlElement("actualDeductionTime")]
    public string ActualDeductionTime { get; set; }

    /// <summary>
    /// 扣款金额，单位元
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>

    [XmlElement("deductionFailTimes")]
    public int DeductionFailTimes { get; set; }

    /// <summary>
    /// 扣款失败原因
    /// </summary>
    [XmlElement("deductionFailReason")]
    public string DeductionFailReason { get; set; }

    /// <summary>
    /// 订购计划期数
    /// </summary>
    [XmlElement("period")]
    public string Period { get; set; }

    /// <summary>
    /// 核销码
    /// </summary>
    [XmlElement("verificationCode")]
    public string VerificationCode { get; set; }

    /// <summary>
    /// 核销码状态
    /// UNUSE 未核销 USED 已核销
    /// </summary>
    [XmlElement("verificationCodeStatus")]
    public string VerificationCodeStatus { get; set; }

    /// <summary>
    /// 分账状态
    /// 待分账 WAIT_SETTLE
    /// 分账中 SETTLING
    /// 分账功 SETTLE_SUCCESS
    /// 分账失败:SETTLE_FAIL
    /// </summary>
    [XmlElement("orderSettleStatus")]
    public string OrderSettleStatus { get; set; }

    /// <summary>
    /// 分账成功时间
    /// </summary>
    [XmlElement("settleTime")]
    public string SettleTime { get; set; }

    /// <summary>
    /// 分账失败次数
    /// </summary>
    [XmlElement("settleFailTimes")]
    public int SettleFailTimes { get; set; }

    /// <summary>
    /// 分账失败原因
    /// </summary>
    [XmlElement("settleFailReason")]
    public string SettleFailReason { get; set; }

    /// <summary>
    /// 分账明细
    /// </summary>
    [XmlArray("settleDetails")]
    [XmlArrayItem("settleDetails")]
    public List<OrderSettleSyncDTO> SettleDetails { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("stageName")]
    public string StageName { get; set; }

    /// <summary>
    /// 商户阶段确认
    /// 仅适用装修、配送类型
    /// </summary>
    [XmlElement("merchantStageConfirm")]
    public string MerchantStageConfirm { get; set; }

    /// <summary>
    /// 核销超时日期
    /// yyyy-MM-dd HH:mm:ss
    /// 仅适用装修、配送类型
    /// </summary>
    [XmlElement("verificationOverdueTime")]
    public string VerificationOverdueTime { get; set; }

    /// <summary>
    /// 支付渠道
    /// 用户主动支付 APP
    /// 系统自动支付 AUTO
    /// </summary>
    [XmlElement("payChannel")]
    public string PayChannel { get; set; }

}
