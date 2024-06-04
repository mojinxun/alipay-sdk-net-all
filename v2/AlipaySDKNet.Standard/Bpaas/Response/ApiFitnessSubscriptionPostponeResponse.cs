using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessSubscriptionPostponeResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlArray("data")]
    [XmlArrayItem("data")]
    public List<DeductionPlanQueryDTO> Data { get; set; }
}
