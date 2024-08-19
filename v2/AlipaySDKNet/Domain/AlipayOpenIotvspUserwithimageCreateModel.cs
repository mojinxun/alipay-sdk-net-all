using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUserwithimageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUserwithimageCreateModel : AopObject
    {
        /// <summary>
        /// false-不下发本地库 true-下发本地库
        /// </summary>
        [XmlElement("bio_in_client")]
        public bool BioInClient { get; set; }

        /// <summary>
        /// 姓名，三要素入库必填
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，枚举支持：IDENTITY_CARD身份证，PASS_PORT护照，STU_NUM学生学号，COMPANY_NUM工号，TAIWAN_CARD台胞证，HK_MC_CARD港澳证件
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 组件编码，详见接入指南
        /// </summary>
        [XmlElement("component_out_id")]
        public string ComponentOutId { get; set; }

        /// <summary>
        /// 扩展信息，服务商自定义，如无可为空
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 刷脸的ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 人脸图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 服务商传入服务商的PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 自定义标签
        /// </summary>
        [XmlElement("label_out_no")]
        public string LabelOutNo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// isv自定义的用户唯一标识
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
