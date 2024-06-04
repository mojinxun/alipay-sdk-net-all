using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiEquityQueryDetailResponse : AopResponse
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
		[XmlElement("name")]
		public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("redPacketAmount")]
		public decimal RedPacketAmount { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("equityTemplateCode")]
		public string EquityTemplateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("id")]
		public long Id { get; set; }
		
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
