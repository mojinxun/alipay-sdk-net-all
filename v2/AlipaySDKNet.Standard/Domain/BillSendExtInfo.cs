using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillSendExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillSendExtInfo : AopObject
    {
        /// <summary>
        /// 学校外标编号
        /// </summary>
        [XmlElement("ext_school_id")]
        public string ExtSchoolId { get; set; }

        /// <summary>
        /// 账单唤起收银台的方式： 1-手机wap;2-当面付。默认值为1（不传值或传非数字值）
        /// </summary>
        [XmlElement("order_pay_type")]
        public string OrderPayType { get; set; }

        /// <summary>
        /// 分账金额，单位：元
        /// </summary>
        [XmlElement("royalty_amount")]
        public string RoyaltyAmount { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 分账收入户PID
        /// </summary>
        [XmlElement("trans_in_pid")]
        public string TransInPid { get; set; }
    }
}
