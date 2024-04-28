using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniappBrandAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class MiniappBrandAuditResult : AopObject
    {
        /// <summary>
        /// 小程序提交品牌认证时的品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 小程序提交品牌认证时的品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 小程序提交品牌认证后的认证状态
        /// </summary>
        [XmlElement("brand_status")]
        public string BrandStatus { get; set; }

        /// <summary>
        /// 小程序提交品牌认证是否认证成功
        /// </summary>
        [XmlElement("has_brand")]
        public string HasBrand { get; set; }

        /// <summary>
        /// 失效原因
        /// </summary>
        [XmlElement("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
