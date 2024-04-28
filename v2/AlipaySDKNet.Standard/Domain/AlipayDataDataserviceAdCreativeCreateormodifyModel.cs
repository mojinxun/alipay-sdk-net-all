using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdCreativeCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 创意交互行为属性实例值
        /// </summary>
        [XmlArray("action_property_list")]
        [XmlArrayItem("action_property")]
        public List<ActionProperty> ActionPropertyList { get; set; }

        /// <summary>
        /// 落地页动作类型，NO_ACTION-无动作；LP-普通落地页；OPEN_TINYAPP-打开小程序；OPEN_CHANNELS-打开生活号；COLLECT_TINYAPP-收藏小程序；
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 转化监控URL，如留资等
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 创意补充资质
        /// </summary>
        [XmlArray("attachment_list")]
        [XmlArrayItem("outer_attachment")]
        public List<OuterAttachment> AttachmentList { get; set; }

        /// <summary>
        /// 创意分组标识，多个创意可按业务逻辑标识为一个分组
        /// </summary>
        [XmlElement("batch_tag")]
        public string BatchTag { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 点击监控URL
        /// </summary>
        [XmlElement("click_track_url")]
        public string ClickTrackUrl { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [XmlElement("creative_outer_id")]
        public string CreativeOuterId { get; set; }

        /// <summary>
        /// 交易ID（灯火平台生成，请联系灯火运营获取）
        /// </summary>
        [XmlElement("deal_id")]
        public string DealId { get; set; }

        /// <summary>
        /// 交易类型，如果是ReachMax公司，固定传字符串"ReachMax"
        /// </summary>
        [XmlElement("deal_type")]
        public string DealType { get; set; }

        /// <summary>
        /// 创意业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放单元对应的外部资源ID
        /// </summary>
        [XmlElement("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 展现监控URL
        /// </summary>
        [XmlElement("impression_track_url")]
        public string ImpressionTrackUrl { get; set; }

        /// <summary>
        /// 门店LBS信息，目前仅口碑使用，格式为：经度:纬度:半径(单位:KM,无半径限制直接设置为0)
        /// </summary>
        [XmlArray("lbs_list")]
        [XmlArrayItem("string")]
        public List<string> LbsList { get; set; }

        /// <summary>
        /// 创意关联物料元素列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_unit")]
        public List<MaterialUnit> MaterialList { get; set; }

        /// <summary>
        /// 创意名称，同一单元下的创意名称不能重复，默认设置为门店名称+outer_id
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放订单对应的外部订单ID
        /// </summary>
        [XmlElement("order_outer_id")]
        public string OrderOuterId { get; set; }

        /// <summary>
        /// 套餐ID（灯火平台生成，请联系灯火运营获取）
        /// </summary>
        [XmlElement("profile_id")]
        public long ProfileId { get; set; }

        /// <summary>
        /// 门店创意关联的城市ID列表，目前仅口碑使用
        /// </summary>
        [XmlArray("region_list")]
        [XmlArrayItem("string")]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// 广告关联rta请求编号
        /// </summary>
        [XmlElement("rta_id")]
        public string RtaId { get; set; }

        /// <summary>
        /// 创意状态，ENABLE-生效；PAUSE-暂停
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店创意关联门店ID，目前仅口碑使用
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 落地页关联的支付宝生活号或小程序关联appId
        /// </summary>
        [XmlElement("target_app_id")]
        public string TargetAppId { get; set; }

        /// <summary>
        /// 创意落地页url地址
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 创意关联模板ID，由投放平台管理生成
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 三方监控链接
        /// </summary>
        [XmlArray("third_track_url_list")]
        [XmlArrayItem("third_track_url_unit")]
        public List<ThirdTrackUrlUnit> ThirdTrackUrlList { get; set; }
    }
}
