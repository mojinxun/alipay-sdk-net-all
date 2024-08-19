using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryTargetRule Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryTargetRule : AopObject
    {
        /// <summary>
        /// 指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id
        /// </summary>
        [XmlArray("brand_id_list")]
        [XmlArrayItem("string")]
        public List<string> BrandIdList { get; set; }

        /// <summary>
        /// 投放可用范围，当delivery_recall_mode=CITY_RECALL的时候必填。填写时deliveryAvailableScopeType必填。
        /// </summary>
        [XmlElement("delivery_available_scope")]
        public DeliveryAvailableScope DeliveryAvailableScope { get; set; }

        /// <summary>
        /// 推广城市规则
        /// </summary>
        [XmlElement("delivery_city_code_rule")]
        public DeliveryCityCodeRule DeliveryCityCodeRule { get; set; }

        /// <summary>
        /// 指定人群
        /// </summary>
        [XmlElement("delivery_crowd_rule")]
        public DeliveryCrowdRule DeliveryCrowdRule { get; set; }

        /// <summary>
        /// "曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号"
        /// </summary>
        [XmlArray("delivery_merchant_infos")]
        [XmlArrayItem("delivery_merchant_info")]
        public List<DeliveryMerchantInfo> DeliveryMerchantInfos { get; set; }

        /// <summary>
        /// 指定支付成功页模式。
        /// </summary>
        [XmlElement("delivery_merchant_mode")]
        public string DeliveryMerchantMode { get; set; }

        /// <summary>
        /// 指定支付有礼曝光商户规则。
        /// </summary>
        [XmlElement("delivery_merchant_rule")]
        public DeliveryMerchantRule DeliveryMerchantRule { get; set; }

        /// <summary>
        /// 推荐定向曝光订单优惠标记。 1. 创建交易订单时，上传符合的订单优惠标。在业务参数信息“business_params”的子字段“delivery_promo_tags”填充订单优惠标。“统一收单交易支付接口”详情查看：<a href ="https://opendocs.alipay.com/open/02ekfp?scene=32"> https://opendocs.alipay.com/open/02ekfp?scene=32</a>  2. 订单优惠标，检验规则： * 单个优惠标最大长度32字节。多个标记值以英文逗号分隔。 * 单个优惠标仅支持字母/数字/下划线。 3. 订单优惠标规则和其他推荐规则同时叠加。
        /// </summary>
        [XmlElement("delivery_promo_tags")]
        public string DeliveryPromoTags { get; set; }

        /// <summary>
        /// 投放召回模式，现在支持CITY_RECALL（城市召回)和SHOP_RECALL（门店召回)两种模式。
        /// </summary>
        [XmlElement("delivery_recall_mode")]
        public string DeliveryRecallMode { get; set; }

        /// <summary>
        /// 指定搜索直达投放区块
        /// </summary>
        [XmlElement("delivery_search_box_rule")]
        public DeliverySearchBoxRule DeliverySearchBoxRule { get; set; }

        /// <summary>
        /// 推广消息模版规则
        /// </summary>
        [XmlElement("delivery_template_rule")]
        public DeliveryTemplateRule DeliveryTemplateRule { get; set; }

        /// <summary>
        /// 小程序推广可用。
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }
    }
}
