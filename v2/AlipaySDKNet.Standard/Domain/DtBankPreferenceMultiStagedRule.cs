using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceMultiStagedRule Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceMultiStagedRule : AopObject
    {
        /// <summary>
        /// 所有区间内最大立减优惠金额值，单位:分 如果是减至场景，则最大立减优惠金额=门槛阈值最大值-减至金额值
        /// </summary>
        [XmlElement("max_reduce_amount")]
        public long MaxReduceAmount { get; set; }

        /// <summary>
        /// 阶梯立减优惠类型下，多区间优惠配置列表
        /// </summary>
        [XmlElement("staged_discount_list")]
        public DtBankStagedThresholdInfo StagedDiscountList { get; set; }
    }
}
