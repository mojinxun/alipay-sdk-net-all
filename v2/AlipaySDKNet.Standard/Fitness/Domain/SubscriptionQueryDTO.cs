using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class SubscriptionQueryDTO
{
    /// <summary>
    /// 扣款计划
    /// </summary>
    [XmlArray("deductionPlanList")]
    [XmlArrayItem("deductionPlanList")]
    public List<DeductionPlanQueryDTO> DeductionPlanList { get; set; }

    /// <summary>
    /// 订购状态
    /// 正常 NORMAL，
    /// 已暂停 PAUSED，
    /// 已解约 SURRENDER，
    /// 已完结 END
    /// </summary>
    [XmlElement("subscriptionStatus")]
    public string SubscriptionStatus { get; set; }

    /// <summary>
    /// 订购编号
    /// </summary>
    [XmlElement("subscriptionNo")]
    public string SubscriptionNo { get; set; }

}
