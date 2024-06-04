using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessProductPageResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pageNumber")]
    public long PageNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("totalSize")]
    public long TotalSize { get; set; }

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
    public List<ProductPageRespDTO> List { get; set; }
}
