using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationContentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationContentApplyModel : AopObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [XmlElement("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 活动 id 加密串
        /// </summary>
        [XmlElement("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展参数 , json 串 , 可选的 key 列表 :     prize_id : 奖品 id , ( 指定奖品返奖场景 )
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 蚂蚁统一open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 运营场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 展台
        /// </summary>
        [XmlElement("touch_point")]
        public string TouchPoint { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
