using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseFrastressQueryriskdomainQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseFrastressQueryriskdomainQueryModel : AopObject
    {
        /// <summary>
        /// 是否需要递归【基础树】获取风险域的子节点 有默认值false
        /// </summary>
        [XmlElement("need_child_domain")]
        public bool NeedChildDomain { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 树id
        /// </summary>
        [XmlElement("tree_id")]
        public string TreeId { get; set; }

        /// <summary>
        /// 用户id，可不传
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 视图可不传
        /// </summary>
        [XmlElement("view")]
        public string View { get; set; }
    }
}
