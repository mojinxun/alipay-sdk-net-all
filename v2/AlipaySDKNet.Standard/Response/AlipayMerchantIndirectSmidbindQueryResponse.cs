using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectSmidbindQueryResponse.
    /// </summary>
    public class AlipayMerchantIndirectSmidbindQueryResponse : AopResponse
    {
        /// <summary>
        /// 确认状态，枚举：已完成确认（AUTHORIZED）/未完成确认（UNAUTHORIZED）/已销户（CLOSED）/sub_merchant_id不存在（SMID_NOT_EXIST）
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }
    }
}
