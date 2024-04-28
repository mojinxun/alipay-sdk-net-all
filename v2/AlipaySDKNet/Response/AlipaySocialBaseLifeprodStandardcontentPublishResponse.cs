using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifeprodStandardcontentPublishResponse.
    /// </summary>
    public class AlipaySocialBaseLifeprodStandardcontentPublishResponse : AopResponse
    {
        /// <summary>
        /// 内容发布后生成的ID，请业务方保存到本地（用于关联查询内容详情、删除内容等其他开放接口）
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
