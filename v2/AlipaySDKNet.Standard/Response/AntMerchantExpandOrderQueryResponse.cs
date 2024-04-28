using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandOrderQueryResponse.
    /// </summary>
    public class AntMerchantExpandOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单创建时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 返回申请单相关参数。当前返回内容有cardAliasNo，smid
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户角色id。间连商户或平台商二级商户业务中，本字段表示smid。
        /// </summary>
        [XmlArray("ip_role_id")]
        [XmlArrayItem("string")]
        public List<string> IpRoleId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 申请单状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
