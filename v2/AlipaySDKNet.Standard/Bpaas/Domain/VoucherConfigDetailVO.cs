using System.Xml.Serialization;
using Aop.Api;

public class VoucherConfigDetailVO
{
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("activityId")]
		private string ActivityId { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("amount")]
		private decimal Amount { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("serialVersionUID")]
		private long SerialVersionUID { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("voucherType")]
		private string VoucherType { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("activityName")]
		private string ActivityName { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("discount")]
		private string Discount { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("id")]
		private long Id { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("originPrice")]
		private decimal OriginPrice { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("useRuleInfo")]
		private string UseRuleInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("specialPrice")]
		private decimal SpecialPrice { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("useThreshold")]
		private decimal UseThreshold { get; set; }
		
	

}
