using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniPackageInfo : AopObject
    {
        /// <summary>
        /// 功能包文档地址
        /// </summary>
        [XmlElement("doc_url")]
        public string DocUrl { get; set; }

        /// <summary>
        /// 功能包描述
        /// </summary>
        [XmlElement("package_desc")]
        public string PackageDesc { get; set; }

        /// <summary>
        /// 功能包名称
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 功能包开通方式
        /// </summary>
        [XmlElement("package_open_type")]
        public string PackageOpenType { get; set; }

        /// <summary>
        /// 功能包签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
