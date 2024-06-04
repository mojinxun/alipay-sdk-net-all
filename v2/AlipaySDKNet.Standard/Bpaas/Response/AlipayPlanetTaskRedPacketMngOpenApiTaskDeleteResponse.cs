using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiTaskDeleteResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
	  [XmlElement("data")]
	  public bool Data { get; set; }	
}
