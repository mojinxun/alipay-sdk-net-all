using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantOrderSyncResponse.
    /// </summary>
    public class AlipayMerchantOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// "分发结果 若未分发到场景侧，则会返回具体的未分发原因"
        /// </summary>
        [XmlArray("distribute_result")]
        [XmlArrayItem("order_data_distribute_info")]
        public List<OrderDataDistributeInfo> DistributeResult { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 同步订单记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 订单同步优化建议，供开发者参考
        /// </summary>
        [XmlArray("sync_suggestions")]
        [XmlArrayItem("order_data_sync_suggestion")]
        public List<OrderDataSyncSuggestion> SyncSuggestions { get; set; }
    }
}
