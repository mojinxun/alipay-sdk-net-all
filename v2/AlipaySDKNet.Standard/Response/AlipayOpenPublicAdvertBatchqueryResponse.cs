using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 广告位列表 。目前只有一个广告位。
        /// </summary>
        [XmlArray("advert_list")]
        [XmlArrayItem("advert")]
        public List<Advert> AdvertList { get; set; }

        /// <summary>
        /// 广告组数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
