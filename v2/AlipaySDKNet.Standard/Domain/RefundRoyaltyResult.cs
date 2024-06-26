using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundRoyaltyResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRoyaltyResult : AopObject
    {
        /// <summary>
        /// 商户请求的转入账号
        /// </summary>
        [XmlElement("ori_trans_in")]
        public string OriTransIn { get; set; }

        /// <summary>
        /// 商户请求的转出账号
        /// </summary>
        [XmlElement("ori_trans_out")]
        public string OriTransOut { get; set; }

        /// <summary>
        /// 退分账金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分账结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 分账类型. 字段为空默认为普通分账类型transfer
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号
        /// </summary>
        [XmlElement("trans_in_email")]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID
        /// </summary>
        [XmlElement("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号
        /// </summary>
        [XmlElement("trans_out_email")]
        public string TransOutEmail { get; set; }
    }
}
