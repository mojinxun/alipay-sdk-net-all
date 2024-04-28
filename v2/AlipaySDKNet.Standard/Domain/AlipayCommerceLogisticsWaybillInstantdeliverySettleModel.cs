using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillInstantdeliverySettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWaybillInstantdeliverySettleModel : AopObject
    {
        /// <summary>
        /// 取消上门费
        /// </summary>
        [XmlElement("cancel_fee")]
        public string CancelFee { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 结算请求流水号
        /// </summary>
        [XmlElement("out_settle_request_no")]
        public string OutSettleRequestNo { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [XmlElement("waybill_status")]
        public string WaybillStatus { get; set; }
    }
}
