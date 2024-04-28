using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsMarketingGiftSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingGiftSendModel : AopObject
    {
        /// <summary>
        /// 渠道规则编码
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用户点击入口
        /// </summary>
        [XmlElement("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 是否自动领取， true 不需要用户点击，自动到账 false 需要用户手动点击领取
        /// </summary>
        [XmlElement("gain_now")]
        public bool GainNow { get; set; }

        /// <summary>
        /// 赠险产品标志
        /// </summary>
        [XmlElement("gift_prod_code")]
        public string GiftProdCode { get; set; }

        /// <summary>
        /// 被保人uid，被保人是当前用户则选择当前user_id
        /// </summary>
        [XmlElement("insured_open_id")]
        public string InsuredOpenId { get; set; }

        /// <summary>
        /// 被保人uid，被保人是当前用户则选择当前user_id
        /// </summary>
        [XmlElement("insured_user_id")]
        public string InsuredUserId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 唯一性的外部业务号，幂等单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 和申请人的关系类型，1本人
        /// </summary>
        [XmlElement("relation_to_apply")]
        public long RelationToApply { get; set; }

        /// <summary>
        /// 赠险产品码列表
        /// </summary>
        [XmlArray("right_no_list")]
        [XmlArrayItem("string")]
        public List<string> RightNoList { get; set; }

        /// <summary>
        /// 调用来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
