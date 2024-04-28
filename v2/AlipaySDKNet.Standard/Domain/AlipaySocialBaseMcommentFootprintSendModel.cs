using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseMcommentFootprintSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseMcommentFootprintSendModel : AopObject
    {
        /// <summary>
        /// 足迹服务分配的业务码
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展字段，某些特殊业务需要传，JSON格式
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 足迹内容的模版号
        /// </summary>
        [XmlElement("footprint_model_code")]
        public string FootprintModelCode { get; set; }

        /// <summary>
        /// 模板内容，JSON格式
        /// </summary>
        [XmlElement("footprint_model_data")]
        public string FootprintModelData { get; set; }

        /// <summary>
        /// 产生足迹的unix毫秒时间戳
        /// </summary>
        [XmlElement("footprint_time")]
        public long FootprintTime { get; set; }

        /// <summary>
        /// 业务场景下的唯一键，例如店铺id，访问对象的id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用于openId的改造，将openId转成支付宝内部的userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 上报数据来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
