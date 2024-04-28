using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IntlBrandInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntlBrandInfo : AopObject
    {
        /// <summary>
        /// 品牌多语言描述信息
        /// </summary>
        [XmlElement("brand_description")]
        public string BrandDescription { get; set; }

        /// <summary>
        /// 品牌的logo图片信息
        /// </summary>
        [XmlElement("brand_logo")]
        public PhotoInfo BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 版本信息
        /// </summary>
        [XmlElement("brand_version")]
        public long BrandVersion { get; set; }

        /// <summary>
        /// 简体中文的字段
        /// </summary>
        [XmlElement("cn_name")]
        public string CnName { get; set; }

        /// <summary>
        /// 扩展信息，map的格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlArray("label_names")]
        [XmlArrayItem("string")]
        public List<string> LabelNames { get; set; }

        /// <summary>
        /// 头图
        /// </summary>
        [XmlElement("master_photo")]
        public PhotoInfo MasterPhoto { get; set; }

        /// <summary>
        /// 售卖区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 视频地址
        /// </summary>
        [XmlElement("video_url")]
        public string VideoUrl { get; set; }
    }
}
