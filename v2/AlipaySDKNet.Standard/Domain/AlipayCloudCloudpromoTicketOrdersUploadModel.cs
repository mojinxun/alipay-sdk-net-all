using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTicketOrdersUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTicketOrdersUploadModel : AopObject
    {
        /// <summary>
        /// 实付金额,单位元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("contacter_cert_no")]
        public string ContacterCertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("contacter_cert_type")]
        public string ContacterCertType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("contacter_mobile_no")]
        public string ContacterMobileNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("contacter_name")]
        public string ContacterName { get; set; }

        /// <summary>
        /// 支付宝userId.格式:2088xxxxxx
        /// </summary>
        [XmlElement("contacter_uid")]
        public string ContacterUid { get; set; }

        /// <summary>
        /// 优惠金额,单位元,优惠金额=订单总金额-实付金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 门票有效期结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 入园结束时间
        /// </summary>
        [XmlElement("entry_end_time")]
        public string EntryEndTime { get; set; }

        /// <summary>
        /// 入园开始时间
        /// </summary>
        [XmlElement("entry_start_time")]
        public string EntryStartTime { get; set; }

        /// <summary>
        /// 门票描述信息
        /// </summary>
        [XmlElement("good_desc")]
        public string GoodDesc { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("good_id")]
        public string GoodId { get; set; }

        /// <summary>
        /// 门票中文描述
        /// </summary>
        [XmlElement("good_name")]
        public string GoodName { get; set; }

        /// <summary>
        /// 不可用日期,数组表示,如["2024-08-09 00:00:00","2024-08-11 00:00:00"] 表示2024-08-09，2024-08-11 这2天不可用
        /// </summary>
        [XmlArray("invalid_dates")]
        [XmlArrayItem("string")]
        public List<string> InvalidDates { get; set; }

        /// <summary>
        /// 一周内不可用日期,1-7表示星期一到星期日
        /// </summary>
        [XmlArray("invalid_day_in_week")]
        [XmlArrayItem("string")]
        public List<string> InvalidDayInWeek { get; set; }

        /// <summary>
        /// 景区的中文描述
        /// </summary>
        [XmlElement("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 门票数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单总金额,单位元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单明细信息.存在套票则设置多个订单明细.
        /// </summary>
        [XmlArray("order_details")]
        [XmlArrayItem("sub_order_detail_info")]
        public List<SubOrderDetailInfo> OrderDetails { get; set; }

        /// <summary>
        /// 门票订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 门票有效期开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 门票状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门票类型:山水，人文，乐园，寺庙，博物馆，其他
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 门票单价,单位元
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
