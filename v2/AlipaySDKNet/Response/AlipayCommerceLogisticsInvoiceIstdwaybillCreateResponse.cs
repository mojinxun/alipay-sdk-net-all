using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponse : AopResponse
    {
        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_fee")]
        public string InvoiceFee { get; set; }

        /// <summary>
        /// 整体的运单开票状态，0：处理中 1：开票成功 2：开票失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [XmlArray("waybill_invoices")]
        [XmlArrayItem("waybill_invoice_istd")]
        public List<WaybillInvoiceIstd> WaybillInvoices { get; set; }
    }
}
