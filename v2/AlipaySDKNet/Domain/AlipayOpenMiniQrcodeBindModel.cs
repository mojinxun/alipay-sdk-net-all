using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodeBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniQrcodeBindModel : AopObject
    {
        /// <summary>
        /// 匹配规则，仅支持EXACT（精确匹配）、FUZZY（模糊匹配）两个值。  精确匹配：根据填写的二维码地址精确匹配，地址完全一致时才能唤起小程序（如：配置二维码地址为https://www.alipay.com/my?id=123，当用户扫这个地址的二维码可唤起小程序）。  模糊匹配：根据填写的二维码地址模糊匹配，只要地址前缀匹配即可唤起小程序（如：配置二维码地址为https://www.alipay.com/my/，当用户扫的二维码地址为https://www.alipay.com/my/id=123,可唤起小程序）。
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 小程序功能页，配置扫描二维码后打开的小程序功能页面路径
        /// </summary>
        [XmlElement("page_redirection")]
        public string PageRedirection { get; set; }

        /// <summary>
        /// 模式，用于描述通用的路由url格式，适用于同一个host下面存在大量路由的场景，主要用于提升路由性能，其中{0}、{1} 代表路径中的变量
        /// </summary>
        [XmlElement("route_pattern")]
        public string RoutePattern { get; set; }

        /// <summary>
        /// 二维码域名，须通过ICP备案验证，支持http、https、ftp开头的链接
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }
    }
}
