using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUselogBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegeUselogBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务结束时间，包含该业务时间点，开始时间和结束时间不能超过一年
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 该字段已废弃，请通过 user_id 进行查询
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询的页数，从1开始，最大100
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示的大小，最小1，最大20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询的业务开始时间，包含起始时间点，开始时间和结束时间不能超过一年
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
