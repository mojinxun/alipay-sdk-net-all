using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountMemberBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountMemberBindModel : AopObject
    {
        /// <summary>
        /// 账本ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 额度模型
        /// </summary>
        [XmlElement("account_quota")]
        public JointAccountQuotaDTO AccountQuota { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 关联代扣协议签约串
        /// </summary>
        [XmlElement("agreement_sign_info")]
        public string AgreementSignInfo { get; set; }

        /// <summary>
        /// 业务场景，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员邀请接口扩展字段
        /// </summary>
        [XmlElement("business_params")]
        public InviteMemberBusinessParamsDTO BusinessParams { get; set; }

        /// <summary>
        /// 该字段为被邀请方账号ID： 当identity_type为ALIPAY_USER_ID时，需要填支付宝ID；当identity_type为ALIPAY_LOGON_ID时，需要填支付宝登录号；当identity_type为ALIPAY_OPEN_ID时，需要填支付宝openId
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openId
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 被邀请人的身份信息
        /// </summary>
        [XmlElement("identity_verified_info")]
        public IdentityVerifiedInfoDTO IdentityVerifiedInfo { get; set; }

        /// <summary>
        /// 成员姓名，账号类型为ALIPAY_LOGON_ID时必填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
