using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsmartpaySyncinvoicebillinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsmartpaySyncinvoicebillinfoCreateModel : AopObject
    {
        /// <summary>
        /// 核销单DTO
        /// </summary>
        [XmlElement("invoice_bill_info_dto")]
        public BizInvoiceBillInfoDTO InvoiceBillInfoDto { get; set; }

        /// <summary>
        /// 影子标记
        /// </summary>
        [XmlElement("test_mode")]
        public bool TestMode { get; set; }
    }
}
