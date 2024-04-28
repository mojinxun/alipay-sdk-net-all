using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCloudEnvDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCloudEnvDeleteModel : AopObject
    {
        /// <summary>
        /// 云id
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 调用的应用id
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }
    }
}
