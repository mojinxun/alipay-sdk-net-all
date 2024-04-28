using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrbeneficiaryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrbeneficiaryCreateModel : AopObject
    {
        /// <summary>
        /// business_partner机构信息
        /// </summary>
        [XmlElement("business_partner")]
        public string BusinessPartner { get; set; }

        /// <summary>
        /// 机构上架类型，包含了“全量上架”与“灰度上架”，用于区分是否灰度上架，避免机构直接全量上架导致的客诉与万求
        /// </summary>
        [XmlElement("grayscale_type")]
        public string GrayscaleType { get; set; }

        /// <summary>
        /// 机构类型
        /// </summary>
        [XmlElement("partner_type")]
        public string PartnerType { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 机构状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 可用状态
        /// </summary>
        [XmlElement("valid_status")]
        public string ValidStatus { get; set; }
    }
}
