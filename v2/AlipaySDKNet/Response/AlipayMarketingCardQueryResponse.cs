using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardQueryResponse.
    /// </summary>
    public class AlipayMarketingCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户卡信息
        /// </summary>
        [XmlElement("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 付费外卡信息，只供特定业务使用，通常接入无需关注
        /// </summary>
        [XmlElement("paid_outer_card_info")]
        public PaidOuterCardExtraInfoDTO PaidOuterCardInfo { get; set; }

        /// <summary>
        /// 商家会员卡页面跳转到支付宝卡券详情页的pass_id，对应schema地址中的参数p， 主要用于小程序跳往会员卡详情的链接拼接
        /// </summary>
        [XmlElement("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 商家会员卡页面跳转到支付宝卡券详情页面的schema地址
        /// </summary>
        [XmlElement("schema_url")]
        public string SchemaUrl { get; set; }
    }
}
