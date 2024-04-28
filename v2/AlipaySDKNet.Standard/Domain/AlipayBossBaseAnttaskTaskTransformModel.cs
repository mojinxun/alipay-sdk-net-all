using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseAnttaskTaskTransformModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseAnttaskTaskTransformModel : AopObject
    {
        /// <summary>
        /// 接入时的systemType
        /// </summary>
        [XmlElement("auth_key")]
        public string AuthKey { get; set; }

        /// <summary>
        /// 接入系统信息，包括system_type和source_id
        /// </summary>
        [XmlElement("business_id")]
        public BusinessId BusinessId { get; set; }

        /// <summary>
        /// 时间戳，到期时间
        /// </summary>
        [XmlElement("date_time")]
        public string DateTime { get; set; }

        /// <summary>
        /// 签名信息，不在此展示
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 转交人工号，需要6位工号，不足6位需要补0
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
