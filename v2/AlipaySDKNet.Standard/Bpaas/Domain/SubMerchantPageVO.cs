using System.Xml.Serialization;
using Aop.Api;
using System;

public class SubMerchantPageVO
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("smid")]
    public string SMId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subMerchantLogoUrl")]
    public string SubMerchantLogoUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("gmtModified")]
    public DateTime GmtModified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subMerchantId")]
    public string SubMerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("isvPid")]
    public string IsvPId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("gmtCreate")]
    public DateTime GmtCreate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("reviewComments")]
    public string ReviewComments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subMerchantName")]
    public string SubMerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subMerchantJumpLink")]
    public string SubMerchantJumpLink { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subPid")]
    public string SubPId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subMerchantContactNumber")]
    public string SubMerchantContactNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("tenantId")]
    public string TenantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serviceId")]
    public string ServiceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("syncStatus")]
    public string SyncStatus { get; set; }




}
