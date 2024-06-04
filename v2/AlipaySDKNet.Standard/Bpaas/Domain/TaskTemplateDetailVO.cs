using System.Xml.Serialization;
using Aop.Api;

public class TaskTemplateDetailVO 
{
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("serialVersionUID")]
		public long SerialVersionUID { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("subTaskTypeName")]
		public string SubTaskTypeName { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("taskTemplateCode")]
		public string TaskTemplateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("minLimitAmount")]
		public decimal MinLimitAmount { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("tradeNum")]
		public int TradeNum { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("name")]
		public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("dayNum")]
		public int DayNum { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("description")]
		public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("type")]
		public string Type { get; set; }
}
