using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceIntelligentRule Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceIntelligentRule : AopObject
    {
        /// <summary>
        /// 最大优惠金额，单位分
        /// </summary>
        [XmlElement("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 最小优惠金额，单位分
        /// </summary>
        [XmlElement("min_amount")]
        public long MinAmount { get; set; }

        /// <summary>
        /// 智能立减优惠目标 moreUsers:覆盖更多用户 lowerAvgPrice:平均金额更低
        /// </summary>
        [XmlElement("optimization_target")]
        public string OptimizationTarget { get; set; }
    }
}
