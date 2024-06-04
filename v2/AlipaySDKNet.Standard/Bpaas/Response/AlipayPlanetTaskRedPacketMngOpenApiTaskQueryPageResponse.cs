using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class AlipayPlanetTaskRedPacketMngOpenApiTaskQueryPageResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pageNumber")]
    public long PageNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("total")]
    public long Total { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pageSize")]
    public long PageSize { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("list")]
    [XmlArrayItem("list")]
    public List<TaskTemplateDetailVO> List { get; set; }
}
