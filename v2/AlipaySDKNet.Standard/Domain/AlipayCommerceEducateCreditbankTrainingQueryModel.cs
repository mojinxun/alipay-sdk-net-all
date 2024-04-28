using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankTrainingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCreditbankTrainingQueryModel : AopObject
    {
        /// <summary>
        /// 学分银行ID
        /// </summary>
        [XmlElement("cb_id")]
        public string CbId { get; set; }

        /// <summary>
        /// 渠道，默认值：shcreditbank(上海学分银行)
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
