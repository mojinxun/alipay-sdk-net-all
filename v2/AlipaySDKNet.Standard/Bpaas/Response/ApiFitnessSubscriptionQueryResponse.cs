using Aop.Api;
using System.Collections.Generic;
using System.Xml.Serialization;

public class ApiFitnessSubscriptionQueryResponse : AopResponse
{
    /// <summary>
    /// �ۿ�ƻ�
    /// </summary>
    [XmlArray("data")]
    [XmlArrayItem("data")]
    public List<SubscriptionQueryDTO> Data { get; set; }
}
