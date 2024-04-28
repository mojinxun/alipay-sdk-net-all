using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRepaybillOrderCreateandpayModel : AopObject
    {
        /// <summary>
        /// 还款协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 扩展参数，json格式字符串。使用前需要和支付宝先约定key值。
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 还款外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// json格式字符串，公用回传参数。如果请求时传递了该参数，则异步通知商户时会回传该参数
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 还款付款方对应的蚂蚁统一id
        /// </summary>
        [XmlElement("payer_open_id")]
        public string PayerOpenId { get; set; }

        /// <summary>
        /// 还款的付款uid
        /// </summary>
        [XmlElement("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 还款请求金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 还款收款方名称
        /// </summary>
        [XmlElement("repay_payee_name")]
        public string RepayPayeeName { get; set; }

        /// <summary>
        /// 还款的收单产品码，支付宝定义
        /// </summary>
        [XmlElement("repay_product_code")]
        public string RepayProductCode { get; set; }

        /// <summary>
        /// 还款说明
        /// </summary>
        [XmlElement("repay_remark")]
        public string RepayRemark { get; set; }

        /// <summary>
        /// 该笔还款单允许的最晚还款时间，逾期将关闭订单。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [XmlElement("repay_timeout_express")]
        public string RepayTimeoutExpress { get; set; }

        /// <summary>
        /// 指定支付渠道，如果指定了渠道，用户只能用该渠道进行支付，具体渠道值由支付宝分配。
        /// </summary>
        [XmlElement("specify_pay_channels")]
        public string SpecifyPayChannels { get; set; }
    }
}
