using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasItapUserConfirmResponse.
    /// </summary>
    public class AlipayMsaasItapUserConfirmResponse : AopResponse
    {
        /// <summary>
        /// Itap统一返回结果模型
        /// </summary>
        [XmlArray("payload")]
        [XmlArrayItem("itap_response_payload")]
        public List<ItapResponsePayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
