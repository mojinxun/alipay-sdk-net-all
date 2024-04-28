using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseUsercenterBaseinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseUsercenterBaseinfoQueryModel : AopObject
    {
        /// <summary>
        /// 登录态
        /// </summary>
        [XmlElement("authorization")]
        public string Authorization { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
