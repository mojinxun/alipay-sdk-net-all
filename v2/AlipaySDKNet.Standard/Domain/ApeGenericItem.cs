using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeGenericItem Data Structure.
    /// </summary>
    [Serializable]
    public class ApeGenericItem : AopObject
    {
        /// <summary>
        /// 物品的属性值，根据物品类型在APE接入文档中获取对应的物品属性定义。
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 物品的唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 数据类型，请从枚举值中选一个最适合自己数据类型传，如果不传，则会默认GOODS
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 状态，1为有效、0为无效
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
