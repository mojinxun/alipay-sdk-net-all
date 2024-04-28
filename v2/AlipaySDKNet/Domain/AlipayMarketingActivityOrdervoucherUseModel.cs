using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherUseModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部优惠券的核销时间，用于流水记录。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 商品明细信息
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail_d_t_o")]
        public List<GoodsDetailDTO> GoodsDetail { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户核销优惠券的代运营商业关系门店id，调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中real_shop_ids中的门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 用户核销优惠券的支付门店id,调用接口<a href="https://opendocs.alipay.com/open/03s3jk?pathHash=04312530&scene=common" target="_blank">ant.merchant.expand.shop.create</a>创建门店返回的门店id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中shop_ids中的门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 交易渠道。
        /// </summary>
        [XmlElement("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。 注意：若用户使用支付宝为交易的渠道，本参数必填。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 待核销的券码。
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }

        /// <summary>
        /// 券核销详情
        /// </summary>
        [XmlElement("voucher_use_detail_info")]
        public VoucherUseDetailInfo VoucherUseDetailInfo { get; set; }
    }
}
