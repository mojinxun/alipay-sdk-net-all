using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TechriskInnovateMpcpromoBehaviorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class TechriskInnovateMpcpromoBehaviorSyncModel : AopObject
    {
        /// <summary>
        /// 行为类型：click（点击）、expose（曝光）、order（下单）、pay（支付）、collect（收藏）、like（点赞）、comment（评论）、share（分享）、cart（加购物车）、drawback（退款）、consult（咨询）、receive（券领取）、use（券核销）等
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 商家在蚂蚁创建的项目id；(个性化推荐场景项目id/智能搜索项目id/)
        /// </summary>
        [XmlElement("biz_project_id")]
        public string BizProjectId { get; set; }

        /// <summary>
        /// 对应返回的的traceid，用于关联推荐结果、搜索结果等和用户行为
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// 商家在蚂蚁创建的项目类型；ape（推荐）aos（搜索）
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 渠道：支付宝端（ALIPAY）、独立客户端（CUSTOM）等
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 行为对应的itemId列表，多个商品用,分割，如曝光的itemid、转化的itemid等。
        /// </summary>
        [XmlElement("item_id_list")]
        public string ItemIdList { get; set; }

        /// <summary>
        /// 订单内商品的购买数量（例如一笔订单内买了1包抽纸和2瓶水），多个商品的购买数量用,分割，顺序跟item_id_list的顺序保持一致，一般只有下单/支付行为携带该字段。
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 埋点上报时间戳、单位 ms
        /// </summary>
        [XmlElement("log_time")]
        public string LogTime { get; set; }

        /// <summary>
        /// 用户唯一标识id。后续user_id将不支持新接入使用，存量已对接的也将逐步回收。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单id，一般只有下单/支付行为携带该字段，用于统计效果数据（订单数，gmv指标）、或者归因层面标注conversion数据是否重复
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户在视频处的停留时长（单位为ms）
        /// </summary>
        [XmlElement("page_stay")]
        public string PageStay { get; set; }

        /// <summary>
        /// 订单的实际(待)支付金额，一般只有下单/支付行为携带该字段。单位元。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 每个item的展示位置序号position【非必要，最好有】，和item_id_list对应，逗号分割
        /// </summary>
        [XmlElement("pos")]
        public string Pos { get; set; }

        /// <summary>
        /// 订单评分（满分5）
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 行为场景，枚举值：home（首页）、goods_detail（商详页）、search（搜索）、order_detail（订单详情页）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// SPM(Super Position Model)全称超级位置模型，主要用于标识行为发生的位置。SPM位置编码由A/B/C/D四段构成， 各分段分别代表 A:业务， B:页面， C:页面区块， D:区块内点位。段之间用$##$分隔，即A$##$B$##$C$##$D，spm各段建议传明文。允许某一段为空，为空时以_代替。
        /// </summary>
        [XmlElement("spm")]
        public string Spm { get; set; }

        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid等
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id的类型，可选值：ALIPAY_UID（支付宝userid）、ALIPAY_OPENID（支付宝openid）、CUSTOM（商家自定义的userid）
        /// </summary>
        [XmlElement("user_id_type")]
        public string UserIdType { get; set; }

        /// <summary>
        /// 视频的总时长（单位为s）
        /// </summary>
        [XmlElement("video_duration")]
        public string VideoDuration { get; set; }

        /// <summary>
        /// 视频的播放时长（单位为ms）
        /// </summary>
        [XmlElement("video_play")]
        public string VideoPlay { get; set; }
    }
}
