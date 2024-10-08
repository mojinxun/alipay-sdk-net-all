using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskPointRankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskPointRankInfo : AopObject
    {
        /// <summary>
        /// 距离前一名积分差距，单位为名，100代表相差100名
        /// </summary>
        [XmlElement("difference")]
        public long Difference { get; set; }

        /// <summary>
        /// 当前排名，单位为第XX名，1代表第1名
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 总数，单位为个
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 排名类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
