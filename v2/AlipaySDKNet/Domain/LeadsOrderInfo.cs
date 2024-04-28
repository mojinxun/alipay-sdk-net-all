using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsOrderInfo : AopObject
    {
        /// <summary>
        /// 客资类型，如手艺人预约，直播客资，门店预约，商品购买等
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 参与的活动名称
        /// </summary>
        [XmlElement("camp_name")]
        public string CampName { get; set; }

        /// <summary>
        /// 客资渠道，例如口碑、支付宝、淘宝等
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 用户姓名，如示例值展示
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 客资创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 扩展字段，interest(兴趣)，sex（性别），age（年龄），campName（参与的活动名称）,businessExt（通话记录），activityName（活动名称（广告外投）），userNumber（预约人数），craftsmanNickName（手艺人昵称），careerName（手艺人职业名称），careerUserId（手艺人用户id），careerContactMobile（手艺人联系电话），activityTitle（直播预约标题），leadsType（leads类型）,prizeInfo(奖品信息)
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 领取的预约礼名称
        /// </summary>
        [XmlElement("gift_name")]
        public string GiftName { get; set; }

        /// <summary>
        /// 电话客资，是否接起，"是"或者"否"，仅电话客资会有值
        /// </summary>
        [XmlElement("is_answer")]
        public string IsAnswer { get; set; }

        /// <summary>
        /// 表名该客资的号码是否是隐私客资
        /// </summary>
        [XmlElement("is_x_phone")]
        public bool IsXPhone { get; set; }

        /// <summary>
        /// 购买的商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商家备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 指定商户号码，目前隐私号未AXB,必须用特定号码才能进行拨打
        /// </summary>
        [XmlElement("merchant_phone")]
        public string MerchantPhone { get; set; }

        /// <summary>
        /// 客资记录id
        /// </summary>
        [XmlElement("reservation_record_id")]
        public string ReservationRecordId { get; set; }

        /// <summary>
        /// 来源场景
        /// </summary>
        [XmlElement("scene_source")]
        public string SceneSource { get; set; }

        /// <summary>
        /// 店铺所在的城市
        /// </summary>
        [XmlElement("shop_city")]
        public string ShopCity { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 客资所属的门店名称，分店名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// PROCESSING("待跟进"), CUSTOMER_ACCEPTED("待到店"), CUSTOMER_ARRIVED("已到店")，CUSTOMER_REJECTED("无意向"),  IN_BLACK_LIST("黑名单")
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 客资有效截止时间
        /// </summary>
        [XmlElement("x_phone_effect_end")]
        public string XPhoneEffectEnd { get; set; }

        /// <summary>
        /// 隐私生效时间开始
        /// </summary>
        [XmlElement("x_phone_effect_start")]
        public string XPhoneEffectStart { get; set; }
    }
}
