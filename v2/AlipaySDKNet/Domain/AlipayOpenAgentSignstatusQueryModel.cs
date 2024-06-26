using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentSignstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentSignstatusQueryModel : AopObject
    {
        /// <summary>
        /// isv要查询签约状态的商户账号，可以是支付宝账号pid（2088开头），也可以是商户的登录账号（邮箱或手机号）
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// isv要查询商户签约状态的产品码，产品码是支付宝内部对产品的唯一标识。目前支持查询产品及产品码详情参见 https://opendocs.alipay.com/isv/01cv77#%E8%83%BD%E5%8A%9B%E4%BA%A7%E5%93%81%E7%A0%81 。 
        /// </summary>
        [XmlArray("product_codes")]
        [XmlArrayItem("string")]
        public List<string> ProductCodes { get; set; }
    }
}
