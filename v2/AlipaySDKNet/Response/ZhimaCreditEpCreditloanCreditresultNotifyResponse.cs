using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditloanCreditresultNotifyResponse.
    /// </summary>
    public class ZhimaCreditEpCreditloanCreditresultNotifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果。结构视data_type的不同而定
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }
    }
}
