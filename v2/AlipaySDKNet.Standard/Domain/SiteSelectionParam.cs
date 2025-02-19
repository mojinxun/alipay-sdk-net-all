using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteSelectionParam Data Structure.
    /// </summary>
    [Serializable]
    public class SiteSelectionParam : AopObject
    {
        /// <summary>
        /// 全国统一城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 数据起始日期
        /// </summary>
        [XmlElement("date_from")]
        public string DateFrom { get; set; }

        /// <summary>
        /// 数据截止日期，请晚于起始日期
        /// </summary>
        [XmlElement("date_to")]
        public string DateTo { get; set; }

        /// <summary>
        /// 1. H3坐标网格编码（编码为8级，六边形面积约为0.7373km2） 2. 若为预测场站价格时，请传入场站编码
        /// </summary>
        [XmlArray("index_list")]
        [XmlArrayItem("string")]
        public List<string> IndexList { get; set; }

        /// <summary>
        /// 经纬度列表
        /// </summary>
        [XmlArray("lng_lat_list")]
        [XmlArrayItem("lng_and_lat_param")]
        public List<LngAndLatParam> LngLatList { get; set; }

        /// <summary>
        /// 最短停留时长，单位为分钟。当获取停留车辆数据「T_RESIDENT_VEHICLE」时，必传。
        /// </summary>
        [XmlElement("min_parking_period")]
        public long MinParkingPeriod { get; set; }

        /// <summary>
        /// 车辆停留天数（单位：天）。当获取停留车辆数据「template_code = T_RESIDENT_VEHICLE」时，必传。
        /// </summary>
        [XmlElement("parking_days")]
        public long ParkingDays { get; set; }
    }
}
