using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiActivityQrcodeVerificationV2Response : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("activityId")]
    public string ActivityId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("status")]
    public bool Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("userId")]
    public string UserId { get; set; }
}
