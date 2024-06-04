using System.Xml.Serialization;
using Aop.Api;
using System;

public class ActivityOpenApiPageVO
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("activityMode")]
    public string ActivityMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("smid")]
    public string SMId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("appName")]
    public string AppName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("isvPid")]
    public string IsvPId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pid")]
    public string PId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("plantActivityId")]
    public string PlantActivityId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("activityCode")]
    public string ActivityCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("totalAmount")]
    public string TotalAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("participantNumber")]
    public long ParticipantNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("appId")]
    public string AppId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("startTime")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("endTime")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("useAmount")]
    public string UseAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status")]
    public string Status { get; set; }
}
