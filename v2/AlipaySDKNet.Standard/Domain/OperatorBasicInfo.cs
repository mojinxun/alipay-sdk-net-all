using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorBasicInfo : AopObject
    {
        /// <summary>
        /// 关联账号列表
        /// </summary>
        [XmlArray("accounts")]
        [XmlArrayItem("operator_account_v_o")]
        public List<OperatorAccountVO> Accounts { get; set; }

        /// <summary>
        /// 企业操作员业务类型。其它操作员没有该值
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作员联系方式列表
        /// </summary>
        [XmlArray("contacts")]
        [XmlArrayItem("operator_contact_v_o")]
        public List<OperatorContactVO> Contacts { get; set; }

        /// <summary>
        /// 操作员登录号。仅由登录号注册的操作员才有值。
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 操作员登录号类型。仅由登录号注册的操作员才有值。 枚举值参考LogonIdTypeEnum 1=手机 2=Email 3=企业操作员昵称方式
        /// </summary>
        [XmlElement("logon_id_type")]
        public string LogonIdType { get; set; }

        /// <summary>
        /// 操作员名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作员昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员所属主账号ID
        /// </summary>
        [XmlElement("rel_ip_role_id")]
        public string RelIpRoleId { get; set; }

        /// <summary>
        /// 操作员所属主账号类型。取值参考RelIpRoleTypeEnum。 1=支付宝商户客户customerId 2=支付宝商户PID 6=支付宝开放账号OID 7=蚂蚁通行证虚拟账号ID
        /// </summary>
        [XmlElement("rel_ip_role_type")]
        public string RelIpRoleType { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        [XmlArray("role_codes")]
        [XmlArrayItem("string")]
        public List<string> RoleCodes { get; set; }

        /// <summary>
        /// 操作员状态。枚举参考OperatorStatusEnum。 T=正常 W=未激活 B=已冻结 C=已删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作员所在租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 操作员类型 1=主操作员 2=子操作员
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
