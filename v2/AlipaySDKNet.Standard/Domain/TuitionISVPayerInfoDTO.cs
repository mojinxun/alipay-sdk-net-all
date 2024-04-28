using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVPayerInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVPayerInfoDTO : AopObject
    {
        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 付款人身份证号
        /// </summary>
        [XmlElement("payer_identity_card_number")]
        public string PayerIdentityCardNumber { get; set; }

        /// <summary>
        /// 付款人支付宝绑定的手机号
        /// </summary>
        [XmlElement("payer_phone_number")]
        public string PayerPhoneNumber { get; set; }
    }
}
