using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票规则ID
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 开票规则名称
        /// </summary>
        [XmlElement("invoice_rule_name")]
        public string InvoiceRuleName { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_title_id")]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("receive_address")]
        public string ReceiveAddress { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receive_name")]
        public string ReceiveName { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        [XmlElement("receive_phone")]
        public string ReceivePhone { get; set; }

        /// <summary>
        /// 销方类型
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }
    }
}
