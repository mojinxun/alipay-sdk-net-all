using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcTripSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcTripSyncModel : AopObject
    {
        /// <summary>
        /// 垫资状态（ 0：无垫资； 1：有垫资； 2：垫资已偿还；）
        /// </summary>
        [XmlElement("advance_status")]
        public string AdvanceStatus { get; set; }

        /// <summary>
        /// 高速场景数据
        /// </summary>
        [XmlElement("highway_data")]
        public HighwaySceneData HighwayData { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，对应用户该笔ETC申请单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部订单号,商户端唯一
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 车牌颜色： 0：蓝； 1：黄； 2：黑； 3：白； 4：绿；5：黄绿
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号。仅包括省份+车牌，不包括特殊字符。
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 发行方id，一般为ETC卡号前缀：  "3701", "山东省"； "6201", "甘肃省"； "3201", "江苏省"； "1101", "北京"； "5301", "云南省"； "4601", "海南省"； "3301", "浙江省"； "3101", "上海"； "6101", "陕西省"； "1201", "天津"； "6501", "新疆维吾尔自治区"； "5201", "贵州省"； "3401", "安徽省"； "8201", "澳门特别行政区"； "4301", "湖南省"； "1301", "河北省"； "8101", "香港特别行政区"； "2101", "辽宁省"； "5101", "四川省"； "6401", "宁夏回族自治区"； "2201", "吉林省"； "3501", "福建省"； "4201", "湖北省"； "4401", "广东省"； "5001", "重庆"； "1401", "山西省"； "3601", "江西省"； "2301", "黑龙江省"； "6301", "青海省"； "4101", "河南省"； "7101", "台湾省"； "1501", "内蒙古自治区"； "5401", "西藏自治区"； "4501", "广西壮族自治区"；
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易单号，通过支付宝扣款的订单，这个参数必传。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝交易状态（S：扣款成功； R: 退款成功）银行交易状态（IN_PROCESSING：处理中，PROCESS_SUCCESS：受理成功；PROCESS_FAIL：受理失败；）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
