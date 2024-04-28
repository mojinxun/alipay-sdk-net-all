using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletTokenCreateModel : AopObject
    {
        /// <summary>
        /// alipay.user.agreement.page.sign返回的代扣签约串
        /// </summary>
        [XmlElement("agreement_pay_sign")]
        public string AgreementPaySign { get; set; }

        /// <summary>
        /// 1. 格式必须为： https://开头域名链接地址 或者 alipays://开头的支付宝小程序链接。 2. 需要保证传入的 returnUrl 链接能够有效访问
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 如果是ALIPAY_USER_ID，则传用户账号；如果是ALIPAY_LOGON_ID，则传手机号
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 登陆类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 如果账号类型是ALIPAY_LOGON_ID，则必传用户真实姓名，进行信息校验
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 是否跳过结果页,true为跳过，false为不跳过。默认不跳过
        /// </summary>
        [XmlElement("skip_result")]
        public bool SkipResult { get; set; }

        /// <summary>
        /// 场景钱包模版id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
