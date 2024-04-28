using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserGamecenterIncrementgameactionSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGamecenterIncrementgameactionSubmitModel : AopObject
    {
        /// <summary>
        /// 在第三方游戏中，用户在游戏中的行动编码。
        /// </summary>
        [XmlElement("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 在第三方游戏中，用户完成行动的渠道。
        /// </summary>
        [XmlElement("action_finish_channel")]
        public string ActionFinishChannel { get; set; }

        /// <summary>
        /// 在第三方游戏中，用户在游戏中完成该行动的时间。
        /// </summary>
        [XmlElement("action_finish_date")]
        public string ActionFinishDate { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 数据的全局唯一标识。用于幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
