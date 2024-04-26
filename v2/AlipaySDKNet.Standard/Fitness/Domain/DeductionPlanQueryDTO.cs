using System.Xml.Serialization;
using Aop.Api;

public class DeductionPlanQueryDTO
{
    /// <summary>
    /// 用户签约成功的订购号
    /// </summary>
    [XmlElement("subscriptionNo")]
    public string SubscriptionNo { get; set; }

    /// <summary>
    /// 计划扣款日期
    /// </summary>
    [XmlElement("deductionDate")]
    public string DeductionDate { get; set; }

    /// <summary>
    /// 期数
    /// </summary>
    [XmlElement("period")]
    public string Period { get; set; }

    /// <summary>
    /// 扣款金额
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// 订单状态
    /// 已暂停 PAUSED，
    /// 下单中 ORDERING,
    /// 下单成功 ORDERED，
    /// 支付成功 PAID，
    /// 扣款失败 PAY_FAILED,
    /// 已全额退款 REFUNDED,
    /// 未生成订单 UNCREATED,
    /// 已取消 CANCEL
    /// </summary>
    [XmlElement("status")]
    public string Status { get; set; }

    /// <summary>
    /// 阶段名
    /// 家装/配送订购类型使用
    /// </summary>
    [XmlElement("stageName")]
    public string StageName { get; set; }

    /// <summary>
    /// 核销超时天数
    /// </summary>
    [XmlElement("verificationOverdueDays")]
    public string VerificationOverdueDays { get; set; }

    /// <summary>
    /// 订单类型
    /// 正常期扣款单: NORMAL
    /// 优惠追回单: DISCOUNT
    /// 违约单：DEFAULT
    /// </summary>
    [XmlElement("orderType")]
    public string OrderType { get; set; }

}
