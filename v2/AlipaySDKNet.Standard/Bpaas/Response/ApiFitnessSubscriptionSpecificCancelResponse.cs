using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessSubscriptionSpecificCancelResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlArray("data")]
    [XmlArrayItem("data")]
    public List<int> Data { get; set; }
}
