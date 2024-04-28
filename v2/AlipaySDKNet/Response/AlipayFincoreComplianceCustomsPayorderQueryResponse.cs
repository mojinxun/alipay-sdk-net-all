using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceCustomsPayorderQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceCustomsPayorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// email+不唯一+海关推支付单+无+cif查询+内部菜鸟使用
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 清算交易号，如果没有被动清算时，返回空字符串
        /// </summary>
        [XmlElement("pay_transaction_id")]
        public string PayTransactionId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 清算机构号，YL、WL，没有时返回空字段串
        /// </summary>
        [XmlElement("ver_dept")]
        public string VerDept { get; set; }
    }
}
