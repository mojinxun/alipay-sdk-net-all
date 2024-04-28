using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOrderPayResponse.
    /// </summary>
    public class AlipayTradeOrderPayResponse : AopResponse
    {
        /// <summary>
        /// 异步支付模式。订单使用异步支付模式时才有值。 目前有五种值： ASYNC_DELAY_PAY(异步延时付款); ASYNC_REALTIME_PAY(异步准实时付款); SYNC_DIRECT_PAY(同步直接扣款); NORMAL_ASYNC_PAY(纯异步付款); QUOTA_OCCUPYIED_ASYNC_PAY(异步支付并且预占了先享后付额度);
        /// </summary>
        [XmlElement("async_payment_mode")]
        public string AsyncPaymentMode { get; set; }

        /// <summary>
        /// 实际履约金额，单位（元）。仅履约场景才会返回
        /// </summary>
        [XmlElement("fulfillment_amount")]
        public string FulfillmentAmount { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商户请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单总金额。元为单元，精确到2位小数。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
