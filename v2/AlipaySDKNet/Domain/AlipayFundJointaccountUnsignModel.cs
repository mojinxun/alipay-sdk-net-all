using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountUnsignModel : AopObject
    {
        /// <summary>
        /// 合花群ID<br> 补充说明：<br> 1. 该字段可在签约接口调用后，由alipay.fund. jointaccount.account.completed返回<br> 2. 该字段可在签约接口调用后，由alipay.fund. jointaccount.detail.query返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号<br> 补充说明：<br> 1. 该字段可在签约接口调用后，由alipay.fund. jointaccount.account.completed返回<br> 2. 该字段可在签约接口调用后，由alipay.fund. jointaccount.detail.query返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// {"k":"v"}
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// （发起人）账号类型，参考值如下<br> ALIPAY_USER_ID：支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
