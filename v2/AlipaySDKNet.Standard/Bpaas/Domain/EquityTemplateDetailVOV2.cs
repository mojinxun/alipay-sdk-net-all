using System.Xml.Serialization;
using Aop.Api;

public class EquityTemplateDetailVOV2
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("num")]
    public int Num { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("redPacketAmount")]
    public string RedPacketAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("configType")]
    public string ConfigType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("type")]
    public string Type { get; set; }




}
