using Aop.Api;
using System.Collections.Generic;
using System.Xml.Serialization;

public class ApiFitnessSubscriptionRegainResponse : AopResponse
{
    /// <summary>
    /// ¿Û¿î¼Æ»®
    /// </summary>
    [XmlArray("data")]
    [XmlArrayItem("data")]
    public List<DeductionPlanQueryDTO> Data { get; set; }

}
