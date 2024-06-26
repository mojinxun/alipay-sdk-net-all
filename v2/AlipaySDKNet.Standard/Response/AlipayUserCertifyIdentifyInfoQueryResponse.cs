using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyInfoQueryResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 如果是个人账号，就是个人的名字，如果是企业账号，就是企业名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 认证等级
        /// </summary>
        [XmlElement("certify_grade")]
        public string CertifyGrade { get; set; }

        /// <summary>
        /// 格式是yyyyMMdd HH:mm:ss
        /// </summary>
        [XmlElement("certify_time")]
        public string CertifyTime { get; set; }

        /// <summary>
        /// havana id
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// T表示认证，F表示未认证
        /// </summary>
        [XmlElement("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// T表示已释放，F表示未释放
        /// </summary>
        [XmlElement("is_released")]
        public string IsReleased { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户在应用（AppId）下的用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 企业客户维度的证件有效期，格式为yyyyMMdd或者“长期”
        /// </summary>
        [XmlElement("org_customer_expire_date")]
        public string OrgCustomerExpireDate { get; set; }

        /// <summary>
        /// 企业是否注销，T表示注销，F表示不注销
        /// </summary>
        [XmlElement("org_customer_is_cancelled")]
        public string OrgCustomerIsCancelled { get; set; }

        /// <summary>
        /// 企业是否异常名录，T表示异常，F表示不异常
        /// </summary>
        [XmlElement("org_customer_is_exception")]
        public string OrgCustomerIsException { get; set; }

        /// <summary>
        /// 企业是否违法经营，T表示违法，F表示不违法
        /// </summary>
        [XmlElement("org_customer_is_in_black_list")]
        public string OrgCustomerIsInBlackList { get; set; }

        /// <summary>
        /// 企业是否吊销，T是吊销，F是不吊销
        /// </summary>
        [XmlElement("org_customer_is_revoked")]
        public string OrgCustomerIsRevoked { get; set; }

        /// <summary>
        /// 企业客户的证件签发时间，格式为yyyyMMdd或者“长期”
        /// </summary>
        [XmlElement("org_customer_issue_date")]
        public string OrgCustomerIssueDate { get; set; }

        /// <summary>
        /// 企业客户维度的法人代表名称
        /// </summary>
        [XmlElement("org_customer_legal_person_cert_name")]
        public string OrgCustomerLegalPersonCertName { get; set; }

        /// <summary>
        /// 企业客户维度的法人代表证件号码
        /// </summary>
        [XmlElement("org_customer_legal_person_cert_no")]
        public string OrgCustomerLegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业客户维度的法人代表证件类型
        /// </summary>
        [XmlElement("org_customer_legal_person_cert_type")]
        public string OrgCustomerLegalPersonCertType { get; set; }

        /// <summary>
        /// 企业客户维度的证件有效期，格式为yyyyMMdd或者“长期”
        /// </summary>
        [XmlElement("org_customer_legal_person_expire_date")]
        public string OrgCustomerLegalPersonExpireDate { get; set; }

        /// <summary>
        /// 企业客户维度的法人代表证件图片，可以通过alipay.user.certify.identify.file.query获取具体的图片文件
        /// </summary>
        [XmlArray("org_customer_legal_person_pictures")]
        [XmlArrayItem("string")]
        public List<string> OrgCustomerLegalPersonPictures { get; set; }

        /// <summary>
        /// 企业客户维度的企业性质
        /// </summary>
        [XmlElement("org_customer_nature")]
        public string OrgCustomerNature { get; set; }

        /// <summary>
        /// 企业客户维度的企业成立时间
        /// </summary>
        [XmlElement("org_customer_open_date")]
        public string OrgCustomerOpenDate { get; set; }

        /// <summary>
        /// 企业客户维度的证件图片，可以通过alipay.user.certify.identify.file.query获取具体的图片文件
        /// </summary>
        [XmlArray("org_customer_pictures")]
        [XmlArrayItem("string")]
        public List<string> OrgCustomerPictures { get; set; }

        /// <summary>
        /// 企业客户维度的注册资金
        /// </summary>
        [XmlElement("org_customer_registered_capital")]
        public string OrgCustomerRegisteredCapital { get; set; }

        /// <summary>
        /// 企业客户维度的经营范围
        /// </summary>
        [XmlElement("org_customer_scope")]
        public string OrgCustomerScope { get; set; }

        /// <summary>
        /// 个人客户维度的证件有效期，格式为yyyyMMdd或者“长期”
        /// </summary>
        [XmlElement("person_customer_expire_date")]
        public string PersonCustomerExpireDate { get; set; }

        /// <summary>
        /// 个人客户维度的证件图片，可以通过alipay.user.certify.identify.file.query获取具体的图片文件
        /// </summary>
        [XmlArray("person_customer_pictures")]
        [XmlArrayItem("string")]
        public List<string> PersonCustomerPictures { get; set; }

        /// <summary>
        /// 个人用户维度的证件有效期，格式为yyyyMMdd或者“长期”
        /// </summary>
        [XmlElement("person_user_expire_date")]
        public string PersonUserExpireDate { get; set; }

        /// <summary>
        /// 个人用户维度的证件图片，可以通过alipay.user.certify.identify.file.query获取具体的图片文件
        /// </summary>
        [XmlArray("person_user_pictures")]
        [XmlArrayItem("string")]
        public List<string> PersonUserPictures { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户类型，个人是2，企业是1
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
