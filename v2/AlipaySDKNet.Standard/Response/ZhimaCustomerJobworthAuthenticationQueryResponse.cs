using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthAuthenticationQueryResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS代表可信，FAILED代表不可信，WAITING_VERIFY代表未知需要等待结果
        /// </summary>
        [XmlElement("identity_result")]
        public string IdentityResult { get; set; }

        /// <summary>
        /// 身份认证查询结果页面的小程序链接，有芝麻提供，用户在端内可直接访问
        /// </summary>
        [XmlElement("identity_result_skip_url")]
        public string IdentityResultSkipUrl { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 代表订单状态
        /// </summary>
        [XmlElement("token_status")]
        public string TokenStatus { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
