using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderItemCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderItemCompleteModel : AopObject
    {
        /// <summary>
        /// 订购服务插件订单号
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一小程序的APPID，如果该订单为蚂蚁服务市场发布的小程序插件服务所产生的订单，则此字段必填
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一门店的ID。若该订单： 为支付宝服务市场发布的服务所产生订单则该参数可选。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
