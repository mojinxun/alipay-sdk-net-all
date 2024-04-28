using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitBeneficialinfoQueryModel : AopObject
    {
        /// <summary>
        /// 相对于汇率的基准货币
        /// </summary>
        [XmlElement("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 外部单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款的金额
        /// </summary>
        [XmlElement("receive_amount")]
        public string ReceiveAmount { get; set; }

        /// <summary>
        /// 收款的金额币种
        /// </summary>
        [XmlElement("receive_currency")]
        public string ReceiveCurrency { get; set; }

        /// <summary>
        /// 用户的名，拼音
        /// </summary>
        [XmlElement("receiver_first_name")]
        public string ReceiverFirstName { get; set; }

        /// <summary>
        /// 用户的全名拼音
        /// </summary>
        [XmlElement("receiver_full_name")]
        public string ReceiverFullName { get; set; }

        /// <summary>
        /// 用户的姓，拼音
        /// </summary>
        [XmlElement("receiver_last_name")]
        public string ReceiverLastName { get; set; }

        /// <summary>
        /// 接收端的ID
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 用户中间的名字
        /// </summary>
        [XmlElement("receiver_middle_name")]
        public string ReceiverMiddleName { get; set; }

        /// <summary>
        /// 汇款用途
        /// </summary>
        [XmlElement("remit_purpose")]
        public string RemitPurpose { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        [XmlElement("send_amount")]
        public string SendAmount { get; set; }

        /// <summary>
        /// 汇款人国家，与sender_nationality不能同时为空
        /// </summary>
        [XmlElement("send_country")]
        public string SendCountry { get; set; }

        /// <summary>
        /// 汇款币种
        /// </summary>
        [XmlElement("send_currency")]
        public string SendCurrency { get; set; }

        /// <summary>
        /// 发端ID
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }

        /// <summary>
        /// 汇款人姓名
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 汇款人国籍，与send_country不能同时为空
        /// </summary>
        [XmlElement("sender_nationality")]
        public string SenderNationality { get; set; }
    }
}
