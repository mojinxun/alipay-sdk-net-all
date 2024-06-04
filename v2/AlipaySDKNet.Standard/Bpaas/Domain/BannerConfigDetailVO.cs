using System.Xml.Serialization;
using Aop.Api;

public class BannerConfigDetailVO
{
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("picPath")]
		private string PicPath { get; set; }

    /// <summary>
    /// 
    /// </summary>
		[XmlElement("serialVersionUID")]
		private long SerialVersionUID { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("id")]
		private long Id { get; set; }
		
    /// <summary>
    /// 
    /// </summary>
		[XmlElement("skipUrl")]
		private string SkipUrl { get; set; }

		
	

}
