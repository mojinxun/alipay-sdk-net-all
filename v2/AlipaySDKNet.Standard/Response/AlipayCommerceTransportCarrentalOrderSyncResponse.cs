using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarrentalOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportCarrentalOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步订单记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
