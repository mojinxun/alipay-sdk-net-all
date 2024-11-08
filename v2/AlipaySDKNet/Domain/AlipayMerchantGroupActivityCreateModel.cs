using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupActivityCreateModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 自定义活动顶部运营位内容
        /// </summary>
        [XmlElement("custom_content")]
        public CustomActivityContentVO CustomContent { get; set; }

        /// <summary>
        /// 活动截止时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 展示优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }
    }
}
