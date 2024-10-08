using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketOrderQueryResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// true：开启；false：关闭；需要同步校验commodity_id，如果没有查询到订购信息的话，忽略该字段返回值
        /// </summary>
        [XmlElement("auto_upgrade")]
        public bool AutoUpgrade { get; set; }

        /// <summary>
        /// 订购服务商品ID
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前查询页（本接口支持最多查询100条记录）
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 订单明细列表
        /// </summary>
        [XmlArray("order_items")]
        [XmlArrayItem("order_item")]
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        /// 用于区分同一个服务的不同版本
        /// </summary>
        [XmlElement("specifications")]
        public string Specifications { get; set; }

        /// <summary>
        /// MERCHANT_ORDED（待服务商接单）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总记录数，例如1000条
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
