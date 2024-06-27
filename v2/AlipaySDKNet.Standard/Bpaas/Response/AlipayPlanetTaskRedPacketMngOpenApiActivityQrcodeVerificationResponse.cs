using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiActivityQrcodeVerificationResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("data")]
    public bool Data { get; set; }
}
