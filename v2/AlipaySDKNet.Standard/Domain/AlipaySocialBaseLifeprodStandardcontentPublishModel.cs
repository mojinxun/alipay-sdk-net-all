using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifeprodStandardcontentPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifeprodStandardcontentPublishModel : AopObject
    {
        /// <summary>
        /// 内容分发范围。whole - 所有人可见，part - 分发范围受限。
        /// </summary>
        [XmlElement("permission_status")]
        public string PermissionStatus { get; set; }

        /// <summary>
        /// 生活号+号ID。如果发送类型=自研/三方发送，不要传入；发送类型=mcn发送，请传入public_id【mcn机构绑定达人号ID】
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 作者；预留字段，当前不对用户透出
        /// </summary>
        [XmlElement("source_author")]
        public string SourceAuthor { get; set; }

        /// <summary>
        /// 来源文章的原始链接地址
        /// </summary>
        [XmlElement("source_link")]
        public string SourceLink { get; set; }

        /// <summary>
        /// 图片和视频素材列表
        /// </summary>
        [XmlArray("source_media_infos")]
        [XmlArrayItem("source_media_info")]
        public List<SourceMediaInfo> SourceMediaInfos { get; set; }

        /// <summary>
        /// 内容关联服务，1个内容最多关联1个服务；offerId为关联的服务ID，支持小程序/小程序服务/优惠券活动
        /// </summary>
        [XmlArray("source_offers")]
        [XmlArrayItem("source_offer")]
        public List<SourceOffer> SourceOffers { get; set; }

        /// <summary>
        /// 文章发布时间 仅支持 yyyy-MM-dd HH:mm:ss 格式
        /// </summary>
        [XmlElement("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// 文章摘要；预留字段，当前不对用户透出
        /// </summary>
        [XmlElement("source_summary")]
        public string SourceSummary { get; set; }

        /// <summary>
        /// 内容正文。类型为长图文，支持富文本。
        /// </summary>
        [XmlElement("source_text")]
        public string SourceText { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [XmlElement("source_title")]
        public string SourceTitle { get; set; }

        /// <summary>
        /// 内容类型（IMAGE-CONTENT：长图文）
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
