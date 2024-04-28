using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSafeboxConditionQueryResponse.
    /// </summary>
    public class AlipayUserSafeboxConditionQueryResponse : AopResponse
    {
        /// <summary>
        /// 产品是否紧急下线状态。true：紧急下线，false：未紧急下线。
        /// </summary>
        [XmlElement("emergency_offline")]
        public bool EmergencyOffline { get; set; }

        /// <summary>
        /// 是否用户已经签约。已经签约：true，未签约：false。
        /// </summary>
        [XmlElement("has_agreement")]
        public bool HasAgreement { get; set; }
    }
}
