using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryContentInfo : AopObject
    {
        /// <summary>
        /// 活动对象。
        /// </summary>
        [XmlElement("delivery_activity_content")]
        public DeliveryActivityContentInfo DeliveryActivityContent { get; set; }

        /// <summary>
        /// 小程序对象
        /// </summary>
        [XmlElement("delivery_app_content")]
        public DeliveryMiniAppContentInfo DeliveryAppContent { get; set; }

        /// <summary>
        /// 运营内容类型。
        /// </summary>
        [XmlElement("delivery_content_type")]
        public string DeliveryContentType { get; set; }

        /// <summary>
        /// 对客内容表达
        /// </summary>
        [XmlElement("delivery_display_info")]
        public DeliveryDisplayInfo DeliveryDisplayInfo { get; set; }

        /// <summary>
        /// 商品对象
        /// </summary>
        [XmlElement("delivery_item_content")]
        public DeliveryItemContentInfo DeliveryItemContent { get; set; }
    }
}
