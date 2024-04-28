using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasOneloginWebInitializeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasOneloginWebInitializeResponse : AopResponse
    {
        /// <summary>
        /// 一键登录流水ID，请保留方便排查问题
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
