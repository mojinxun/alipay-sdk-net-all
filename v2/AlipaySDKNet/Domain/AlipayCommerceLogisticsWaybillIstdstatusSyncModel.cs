using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillIstdstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsWaybillIstdstatusSyncModel : AopObject
    {
        /// <summary>
        /// 事件发生时间点
        /// </summary>
        [XmlElement("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 骑手和消费者联系记录
        /// </summary>
        [XmlArray("contact_records")]
        [XmlArrayItem("contact_record")]
        public List<ContactRecord> ContactRecords { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 运单状态变更扩展信息
        /// </summary>
        [XmlElement("order_ext_istd")]
        public OrderChangeInfoExtIstd OrderExtIstd { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 预计还剩多久送达，单位：秒
        /// </summary>
        [XmlElement("reach_duration")]
        public long ReachDuration { get; set; }

        /// <summary>
        /// 骑手电话
        /// </summary>
        [XmlElement("rider_mobile_no")]
        public string RiderMobileNo { get; set; }

        /// <summary>
        /// 骑手姓名
        /// </summary>
        [XmlElement("rider_name")]
        public string RiderName { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
