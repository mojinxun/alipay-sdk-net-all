using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessProductSaveOrUpdateResponse : AopResponse
{
    /// <summary>
    /// ��Ʒ���
    /// </summary>
    [XmlElement("data")]
    public string Data { get; set; }
}
