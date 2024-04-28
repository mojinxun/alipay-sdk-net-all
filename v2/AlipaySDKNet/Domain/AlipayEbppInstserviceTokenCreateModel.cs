using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceTokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceTokenCreateModel : AopObject
    {
        /// <summary>
        /// 签约来源渠道，接入时与代扣约定
        /// </summary>
        [XmlElement("agent_channel")]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 签约来源渠道，接入时与代扣约定
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号（缴费场景是户号，话费场景是手机号）
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 可传：固定充/低额充/账单充（ 低额充：THRESHOLD_DEDUCT、 固定充：REGULAR_QUOTA_DEDUCT、 账单充：BILL_DEDUCT )，仅支持传英文
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 业务场景：flow(流量)、voice(语音话费)、telephone(固话)
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务类型（例如通信，缴费，还款）
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 发起代扣的面额（可以和代扣时金额不一致，例如打折活动）
        /// </summary>
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 代扣产品码（由技术同学分配）
        /// </summary>
        [XmlElement("ededuct_product_code")]
        public string EdeductProductCode { get; set; }

        /// <summary>
        /// 代扣日期
        /// </summary>
        [XmlElement("execute_date")]
        public string ExecuteDate { get; set; }

        /// <summary>
        /// 机构ID（支付宝侧分配）
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 外部协议号
        /// </summary>
        [XmlElement("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// PREPAID预付费，POSTPAID后付费
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 签约的服务描述
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 二级业务类型（例如话费，流量，水费，电费）
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 发起代扣的阈值
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
