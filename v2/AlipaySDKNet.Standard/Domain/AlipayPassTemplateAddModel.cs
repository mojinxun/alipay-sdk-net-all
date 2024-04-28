using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPassTemplateAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPassTemplateAddModel : AopObject
    {
        /// <summary>
        /// 模板内容信息，遵循JSON规范，详情参见tpl_content <a href="https://opendocs.alipay.com/open/016d5g">参数详细说明</a>。
        /// </summary>
        [XmlElement("tpl_content")]
        public string TplContent { get; set; }

        /// <summary>
        /// 商户用于控制模版的唯一性。（可以使用时间戳保证唯一性）
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
