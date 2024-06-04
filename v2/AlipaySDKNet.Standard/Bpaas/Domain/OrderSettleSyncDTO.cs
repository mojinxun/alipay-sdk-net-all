using System.Xml.Serialization;
using Aop.Api;

public class OrderSettleSyncDTO
{
    /// <summary>
    /// 结算的金额 单位：元
    /// </summary>
    [XmlElement("amount")]
    public string Amount { get; set; }

    /// <summary>
    /// 分账时间	yyyy-MM-dd HH:mm:ss
    /// </summary>
    [XmlElement("settleTime")]
    public string SettleTime { get; set; }

    /// <summary>
    /// 分账比例	最多两位小数。
    /// 示例值: 6.25
    /// </summary>
    [XmlElement("rate")]
    public string Rate { get; set; }

    /// <summary>
    /// 结算收款方账户	
    /// 平台商户分账：平台商户的PID
    /// 自定义账户：支付宝登录账号
    /// </summary>
    [XmlElement("transIn")]
    public string TransIn { get; set; }

    /// <summary>
    /// 分账失败原因
    /// </summary>
    [XmlElement("failReason")]
    public string FailReason { get; set; }

    /// <summary>
    /// 分账状态 
    /// 待分账 WAIT_SETTLE
    /// 分账中 SETTLING
    /// 分账成功 SUCCESS
    /// 分账失败 FAIL
    /// </summary>
    [XmlElement("status")]
    public string Status { get; set; }



}
