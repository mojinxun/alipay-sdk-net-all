using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountCashpoolCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolCreateResponse : AopResponse
    {
        /// <summary>
        /// 资金池唯一标志
        /// </summary>
        [XmlElement("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 资金池名称回显
        /// </summary>
        [XmlElement("cash_pool_name")]
        public string CashPoolName { get; set; }
    }
}
