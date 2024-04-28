using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonGuidedcodeReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonGuidedcodeReceiveModel : AopObject
    {
        /// <summary>
        /// 导购员id
        /// </summary>
        [XmlElement("hunter_id")]
        public string HunterId { get; set; }

        /// <summary>
        /// 导购员openId
        /// </summary>
        [XmlElement("hunter_open_id")]
        public string HunterOpenId { get; set; }

        /// <summary>
        /// 代运营商户Id
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 淘客领取任务实例id,等于taskInstanceId
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
