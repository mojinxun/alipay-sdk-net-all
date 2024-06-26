using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePrecreateResponse.
    /// </summary>
    public class AlipayTradePrecreateResponse : AopResponse
    {
        /// <summary>
        /// 商户的订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当前预下单请求生成的二维码码串，有效时间2小时，可以用二维码生成工具根据该码串值生成对应的二维码
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 当前预下单请求生成的吱口令码串，有效时间2小时，可以在支付宝app端访问对应内容
        /// </summary>
        [XmlElement("share_code")]
        public string ShareCode { get; set; }
    }
}
