using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiangTestabc Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestabc : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("json")]
        public string Json { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ssddf")]
        public ApiInfoVO Ssddf { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss_2")]
        public ApiInfoVO Sss2 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t")]
        public string T { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t_openid")]
        public string TOpenid { get; set; }
    }
}
