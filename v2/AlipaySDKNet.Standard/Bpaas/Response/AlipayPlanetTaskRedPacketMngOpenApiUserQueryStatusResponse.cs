using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiUserQueryStatusResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("receiveTime")]
		public string ReceiveTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("serialVersionUID")]
		public long SerialVersionUID { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("redPacketStatus")]
		public string RedPacketStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("taskCompleteTime")]
		public string TaskCompleteTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("redPacketAmount")]
		public string RedPacketAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("taskStatus")]
		public string TaskStatus { get; set; }

}
