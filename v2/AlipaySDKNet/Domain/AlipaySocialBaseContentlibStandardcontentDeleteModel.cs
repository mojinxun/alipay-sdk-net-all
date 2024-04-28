using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibStandardcontentDeleteModel : AopObject
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 生活号+号ID，只有MCN机构为达人号ID删除内容才需要传入
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
