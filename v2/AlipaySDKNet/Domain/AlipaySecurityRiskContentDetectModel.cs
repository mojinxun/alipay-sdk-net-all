using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentDetectModel : AopObject
    {
        /// <summary>
        /// 需要识别的文本。 注意： * 请勿传入包含特殊字符及双引号等，可能引起 json 格式化错误问题的字符。 * 目前暂仅针对国家涉政风险文案进行拦截，拦截规则将逐步升级。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
