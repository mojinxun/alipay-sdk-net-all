using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryModel : AopObject
    {
        /// <summary>
        /// 单品id列表, 单品券场景返回货品信息. 最大支持5个条形码
        /// </summary>
        [XmlArray("goods_ids")]
        [XmlArrayItem("string")]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 忽略不可用的券(已过期、已使用)
        /// </summary>
        [XmlElement("ignore_disabled_voucher")]
        public string IgnoreDisabledVoucher { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 是否只查询当前ISV报名的活动
        /// </summary>
        [XmlElement("only_current_isv")]
        public bool OnlyCurrentIsv { get; set; }
    }
}
