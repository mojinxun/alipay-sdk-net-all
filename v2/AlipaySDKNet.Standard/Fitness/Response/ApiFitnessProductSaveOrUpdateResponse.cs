using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessProductSaveOrUpdateResponse : AopResponse
{
    /// <summary>
    /// ²úÆ·±àºÅ
    /// </summary>
    [XmlElement("data")]
    public string Data { get; set; }
}
