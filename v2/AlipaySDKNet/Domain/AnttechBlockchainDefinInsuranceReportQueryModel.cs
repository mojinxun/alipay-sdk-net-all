using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinInsuranceReportQueryModel : AopObject
    {
        /// <summary>
        /// 统一客户平台的业务线编码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 统一客户平台的会员类型
        /// </summary>
        [XmlElement("platform_access_type")]
        public string PlatformAccessType { get; set; }

        /// <summary>
        /// 统一客户平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品运营中心开通的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [XmlElement("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 原报案流水号
        /// </summary>
        [XmlElement("report_trade_no")]
        public string ReportTradeNo { get; set; }

        /// <summary>
        /// 唯一交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
