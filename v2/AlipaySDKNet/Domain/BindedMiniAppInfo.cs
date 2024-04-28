using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BindedMiniAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BindedMiniAppInfo : AopObject
    {
        /// <summary>
        /// 开发者名称
        /// </summary>
        [XmlElement("dev_name")]
        public string DevName { get; set; }

        /// <summary>
        /// 当前进行锁定的版本号
        /// </summary>
        [XmlElement("locked_version")]
        public string LockedVersion { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序logo url地址
        /// </summary>
        [XmlElement("mini_app_logo")]
        public string MiniAppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 小程序的简介
        /// </summary>
        [XmlElement("mini_app_slogan")]
        public string MiniAppSlogan { get; set; }

        /// <summary>
        /// true：小程序在架 false：小程序当前未在架
        /// </summary>
        [XmlElement("online")]
        public bool Online { get; set; }

        /// <summary>
        /// 当前小程序在AMPE最新的上架可用版本
        /// </summary>
        [XmlElement("online_version")]
        public string OnlineVersion { get; set; }

        /// <summary>
        /// 当前小程序是否加入AMPE计划，小程序开发者可以自行进行AMPE的开通和关闭
        /// </summary>
        [XmlElement("support_ampe")]
        public bool SupportAmpe { get; set; }
    }
}
