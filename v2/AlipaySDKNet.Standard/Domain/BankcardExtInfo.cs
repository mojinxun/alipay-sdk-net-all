using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankcardExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankcardExtInfo : AopObject
    {
        /// <summary>
        /// 收款账户类型。 1：对公（在金融机构开设的公司账户） 2：对私（在金融机构开设的个人账户）
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行支行联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 收款银行所属支行
        /// </summary>
        [XmlElement("inst_branch_name")]
        public string InstBranchName { get; set; }

        /// <summary>
        /// 收款银行所在市
        /// </summary>
        [XmlElement("inst_city")]
        public string InstCity { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 银行所在省
        /// </summary>
        [XmlElement("inst_province")]
        public string InstProvince { get; set; }
    }
}
