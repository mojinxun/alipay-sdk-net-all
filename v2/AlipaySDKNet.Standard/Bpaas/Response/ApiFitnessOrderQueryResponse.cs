using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessOrderQueryResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlArray("data")]
    [XmlArrayItem("data")]
    public List<OrderQueryDTO> Data { get; set; }
}
