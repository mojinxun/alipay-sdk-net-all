using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InqueryDoctorData Data Structure.
    /// </summary>
    [Serializable]
    public class InqueryDoctorData : AopObject
    {
        /// <summary>
        /// 医生是否认证 1 已认证 0 未认证
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 医生头像
        /// </summary>
        [XmlElement("avator")]
        public string Avator { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 执业医院科室（多个科室时用英文逗号分隔）
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生个人简介
        /// </summary>
        [XmlElement("doctor_desc")]
        public string DoctorDesc { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 教育职称
        /// </summary>
        [XmlElement("educate_grade")]
        public string EducateGrade { get; set; }

        /// <summary>
        /// 可以与支付宝侧关联的外部标准科室id
        /// </summary>
        [XmlElement("ext_depart_id")]
        public string ExtDepartId { get; set; }

        /// <summary>
        /// 可以与支付宝侧关联的外部标准疾病id列表
        /// </summary>
        [XmlArray("ext_disease_id_list")]
        [XmlArrayItem("string")]
        public List<string> ExtDiseaseIdList { get; set; }

        /// <summary>
        /// 外部自己医生的唯一标识
        /// </summary>
        [XmlElement("ext_doctor_id")]
        public string ExtDoctorId { get; set; }

        /// <summary>
        /// 可以与支付宝侧关联的外部标准医院id
        /// </summary>
        [XmlElement("ext_hospital_id")]
        public string ExtHospitalId { get; set; }

        /// <summary>
        /// 医生性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 执业医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 身份证号（医生执医许可证编号和身份证号至少填一项）
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 执医年限，单位年
        /// </summary>
        [XmlElement("practice_year")]
        public string PracticeYear { get; set; }

        /// <summary>
        /// 医生执医许可证编号（医生执医许可证编号和身份证号至少填一项）
        /// </summary>
        [XmlElement("practicing_doctor_certificate_no")]
        public string PracticingDoctorCertificateNo { get; set; }

        /// <summary>
        /// 医生擅长描述
        /// </summary>
        [XmlElement("skilled_desc")]
        public string SkilledDesc { get; set; }

        /// <summary>
        /// 医生擅长疾病（多个擅长疾病时用英文逗号分隔）
        /// </summary>
        [XmlElement("skilled_disease")]
        public string SkilledDisease { get; set; }

        /// <summary>
        /// 医生专业标签（多个标签时用英文逗号分隔） 专业标签数量不固定
        /// </summary>
        [XmlElement("special_tags")]
        public string SpecialTags { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
