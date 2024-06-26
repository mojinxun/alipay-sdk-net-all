using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantCreditserviceLogoUploadResponse.
    /// </summary>
    public class ZhimaMerchantCreditserviceLogoUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传图片后生成的图片地址
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
