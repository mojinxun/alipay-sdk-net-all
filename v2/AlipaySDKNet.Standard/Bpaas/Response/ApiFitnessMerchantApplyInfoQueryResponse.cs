using System.Xml.Serialization;
using Aop.Api;

/// <summary>
/// 
/// </summary>
public class ApiFitnessMerchantApplyInfoQueryResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
	[XmlElement("smid")]
	public string SMId { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[XmlElement("appJumpLink")]
	public string AppJumpLink { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[XmlElement("serialVersionUID")]
	public long SerialVersionUID { get; set; }
	
    /// <summary>
    /// 
    /// </summary>
	[XmlElement("phone")]
	public string Phone { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[XmlElement("merchantPid")]
	public string MerchantPId { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[XmlElement("zhimaOrderNo")]
	public string ZhimaOrderNo { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[XmlElement("logoUrl")]
	public string LogoUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
	[XmlElement("merchantName")]
	public string MerchantName { get; set; }
}
