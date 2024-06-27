using System.Xml.Serialization;
using Aop.Api;

public class TaskTemplateDetailVOV2
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subTaskTypeName")]
    public string SubTaskTypeName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("minLimitAmount")]
    public string MinLimitAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("tradeNum")]
    public int TradeNum { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("dayNum")]
    public int DayNum { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("jumpLink")]
    public string JumpLink { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type")]
    public string Type { get; set; }

}
