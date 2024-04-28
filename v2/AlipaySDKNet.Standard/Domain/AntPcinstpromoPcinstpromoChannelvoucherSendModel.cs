using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntPcinstpromoPcinstpromoChannelvoucherSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntPcinstpromoPcinstpromoChannelvoucherSendModel : AopObject
    {
        /// <summary>
        /// P站配置的活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 支付宝用户登录号 。user_id，logon_id，phone_id不能同时为空，优先级依次降低。 注：若手机号为非用户注册支付宝账号，则会发放失败。
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 映射user_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号用来保证幂等（同一个user_id(包含通过手机号和登录号关联的user_id)，activity_id，out_biz_no）均视为同意请求，返回相同结果
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 该参数将先匹配用户手机号对应支付宝账号，若存在且完成实名认证则以此支付宝账号发放，若该支付宝账号未完成实名认证则发放失败；若用户手机号对应支付宝账号不存在，则再匹配用户手机号绑定支付宝账号。若用户手机号绑定多个支付宝账号，则以系统判定的常用支付宝账号为准。请优先使用user_id和logon_id。
        /// </summary>
        [XmlElement("phone_id")]
        public string PhoneId { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id，logon_id，phone_id不能同时为空，优先级依次降低。 注：UID为用户唯一标识，可通过授权方式获取，具体见产品文档。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
