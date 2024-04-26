using Aop.Api;
using System.Collections.Generic;
using System.Xml.Serialization;

public class ApiFitnessSubscriptionQueryResponse : AopResponse
{
    /// <summary>
    /// ¿Û¿î¼Æ»®
    /// </summary>
    [XmlArray("data")]
    [XmlArrayItem("data")]
    public List<SubscriptionQueryDTO> Data { get; set; }
}
