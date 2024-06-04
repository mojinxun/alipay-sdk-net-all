using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiEquityUpdateResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
	  [XmlElement("data")]
	  public bool Data { get; set; }	
}
