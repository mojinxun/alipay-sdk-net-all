using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubVenueQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubVenueQueryInfo : AopObject
    {
        /// <summary>
        /// 入场要求
        /// </summary>
        [XmlElement("admission_requirement")]
        public string AdmissionRequirement { get; set; }

        /// <summary>
        /// 公告
        /// </summary>
        [XmlElement("announcement")]
        public string Announcement { get; set; }

        /// <summary>
        /// 是否可预定 Y/N （不传默认可预定）
        /// </summary>
        [XmlElement("bookable")]
        public string Bookable { get; set; }

        /// <summary>
        /// 场馆介绍
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 器材租赁信息
        /// </summary>
        [XmlElement("equipment_rental")]
        public string EquipmentRental { get; set; }

        /// <summary>
        /// 设施列表 场馆设施：1地板、2灯光、3淋浴、4餐饮、5WiFi 、6更衣室、7充电宝、8停车场、9休息区
        /// </summary>
        [XmlArray("facility_list")]
        [XmlArrayItem("number")]
        public List<long> FacilityList { get; set; }

        /// <summary>
        /// 场馆名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 营业时间，不传用主场馆的
        /// </summary>
        [XmlElement("opening_hours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// 服务商场馆ID
        /// </summary>
        [XmlElement("out_sub_venue_id")]
        public string OutSubVenueId { get; set; }

        /// <summary>
        /// 收款方支付宝账户
        /// </summary>
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款方式 account/空值：通过支付宝账号收款  smid：通过smid收款
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 收款方式（间连/直连）
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 联系电话，多个逗号隔开，不传用主场馆的
        /// </summary>
        [XmlArray("phone")]
        [XmlArrayItem("string")]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 场馆图片链接列表 最多5张
        /// </summary>
        [XmlArray("picture_list")]
        [XmlArrayItem("string")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// 场馆主图海报链接
        /// </summary>
        [XmlElement("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 场馆售卖产品类型集合，逗号隔开 calendar：价格日历 ticket：票券 course: 课程
        /// </summary>
        [XmlArray("product_type_list")]
        [XmlArrayItem("string")]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// 促销信息
        /// </summary>
        [XmlElement("promotion")]
        public string Promotion { get; set; }

        /// <summary>
        /// 支付宝子场馆ID
        /// </summary>
        [XmlElement("sub_venue_id")]
        public string SubVenueId { get; set; }

        /// <summary>
        /// 子场馆pid
        /// </summary>
        [XmlElement("sub_venue_pid")]
        public string SubVenuePid { get; set; }

        /// <summary>
        /// 子场馆商户二级smid（payment_method为smid时必传）
        /// </summary>
        [XmlElement("sub_venue_smid")]
        public string SubVenueSmid { get; set; }

        /// <summary>
        /// 场馆当前状态 安全审核中：infosec-audit 安全审核不通过：infosec-unpass 云验收中： cloud-audit 云验收不通过： cloud-unpass 上架： online 下架： offline 人工下架： manual-offline
        /// </summary>
        [XmlElement("sub_venue_status")]
        public string SubVenueStatus { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 培训信息
        /// </summary>
        [XmlElement("training")]
        public string Training { get; set; }

        /// <summary>
        /// 场馆类型， 01足球；02篮球；03乒乓球；04羽毛球；05台球；06射箭；07哒哒球；08游泳；09网球；10攀岩；11空手道；12跆拳道；14瑜伽；15搏击；16舞蹈；17艺术体操；18太极；19击剑；20水上运动；21滑雪；22健身；23滑冰；24排球；25门球；26轮滑；00其他运动
        /// </summary>
        [XmlElement("venue_type")]
        public string VenueType { get; set; }

        /// <summary>
        /// 会员卡信息
        /// </summary>
        [XmlElement("vip")]
        public string Vip { get; set; }
    }
}
