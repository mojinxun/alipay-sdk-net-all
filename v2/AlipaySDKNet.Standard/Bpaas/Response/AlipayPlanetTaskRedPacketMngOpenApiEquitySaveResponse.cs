using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiEquitySaveResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
	  [XmlElement("data")]
	  public string Data { get; set; }	
}
