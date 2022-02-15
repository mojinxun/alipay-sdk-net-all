using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerZmcardInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerZmcardInfoQueryModel : AopObject
    {
        /// <summary>
        /// 查看者的证件号,A申请查看B的芝麻证信息，则传入A的证件号，若是自己查看自己的，则传入自己的证件号，无法确定查看者，则传入空
        /// </summary>
        [XmlElement("guest_cert_no")]
        public string GuestCertNo { get; set; }

        /// <summary>
        /// 芝麻证被查看人的证件号
        /// </summary>
        [XmlElement("host_cert_no")]
        public string HostCertNo { get; set; }

        /// <summary>
        /// 被查看者证件类型，取值如下： IDENTITY_CARD：身份证、 PASSPORT：护照、 BACK_HOMETOWN_CARD：回乡证、 HOME_VISIT_PERMIT_TAIWAN：台湾居民通行证、 HOME_VISIT_PERMIT_HK_MC：港澳来往通行证、 HK_MC_CARD：港澳证件，必填选项
        /// </summary>
        [XmlElement("host_cert_type")]
        public string HostCertType { get; set; }
    }
}