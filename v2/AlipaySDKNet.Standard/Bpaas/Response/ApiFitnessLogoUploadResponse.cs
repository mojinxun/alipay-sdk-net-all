using System.Xml.Serialization;
using Aop.Api;

/// <summary>
/// 
/// </summary>
public class ApiFitnessLogoUploadResponse : AopResponse
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("pictureUrl")]
    public string PictureUrl { get; set; }
}
