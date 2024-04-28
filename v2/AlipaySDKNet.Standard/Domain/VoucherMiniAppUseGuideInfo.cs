using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherMiniAppUseGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherMiniAppUseGuideInfo : AopObject
    {
        /// <summary>
        /// 小程序服务编码。取值来源：通过<a href="https://opendocs.alipay.com/mini/03cgoq?pathHash=49cde24b&scene=common&highlight_field=service_code" target="_blank">alipay.open.app.service.apply(小程序服务创建)</a>接口创建服务后获取。
        /// </summary>
        [XmlArray("mini_app_service_codes")]
        [XmlArrayItem("string")]
        public List<string> MiniAppServiceCodes { get; set; }

        /// <summary>
        /// 小程序核销链接
        /// </summary>
        [XmlElement("mini_app_url")]
        public string MiniAppUrl { get; set; }
    }
}
