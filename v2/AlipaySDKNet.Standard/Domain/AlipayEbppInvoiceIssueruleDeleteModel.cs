using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceIssueruleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceIssueruleDeleteModel : AopObject
    {
        /// <summary>
        /// 共同账户id
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
        /// 需要删除的发放规则id列表
        /// </summary>
        [XmlArray("issue_rule_id_list")]
        [XmlArrayItem("string")]
        public List<string> IssueRuleIdList { get; set; }

        /// <summary>
        /// 目标值id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 发放规则关联的目标类型
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
