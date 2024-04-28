using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIAmortizeExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIAmortizeExtInfo : AopObject
    {
        /// <summary>
        /// 待摊销金额。（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [XmlElement("amortize_amount")]
        public string AmortizeAmount { get; set; }

        /// <summary>
        /// 摊销频率
        /// </summary>
        [XmlElement("amortize_period_type")]
        public string AmortizePeriodType { get; set; }

        /// <summary>
        /// 摊销总天数
        /// </summary>
        [XmlElement("amortize_total_day")]
        public string AmortizeTotalDay { get; set; }

        /// <summary>
        /// 摊销类型
        /// </summary>
        [XmlElement("amortize_type")]
        public string AmortizeType { get; set; }

        /// <summary>
        /// 待摊销业务量
        /// </summary>
        [XmlElement("amortize_volume")]
        public long AmortizeVolume { get; set; }

        /// <summary>
        /// 摊销失效时间。（GMT+8时区，精确到天，暂不支持小时分秒等粒度）
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 摊销生效时间。（GMT+8时区，精确到天，暂不支持小时分秒等粒度）
        /// </summary>
        [XmlElement("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 同 out_business_no 下业财已受理的总摊销金额（单位：各币种的“元”单位，精确到小数点后两位）
        /// </summary>
        [XmlElement("total_amortize_amount")]
        public string TotalAmortizeAmount { get; set; }
    }
}
