using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiActivityCreateResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("activityMode")]
    public string ActivityMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("taskTemplateDetail")]
    public TaskTemplateDetailVO TaskTemplateDetail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("equityTemplateDetail")]
    public EquityTemplateDetailVO EquityTemplateDetail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("appName")]
    public string AppName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("description")]
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("rule")]
    public string Rule { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pid")]
    public string PId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("title")]
    public string Title { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("plantActivityId")]
    public string PlantActivityId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("bannerConfig")]
    [XmlArrayItem("bannerConfig")]
    public List<BannerConfigDetailVO> BannerConfig { get; set; }

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
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("copywriting")]
    public string Copywriting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("bannerPic")]
    public string BannerPic { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("voucherConfig")]
    [XmlArrayItem("voucherConfig")]
    public List<VoucherConfigDetailVO> VoucherConfig { get; set; }

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
    [XmlElement("status")]
    public string Status { get; set; }
}
