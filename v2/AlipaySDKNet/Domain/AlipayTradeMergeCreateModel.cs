using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeMergeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeMergeCreateModel : AopObject
    {
        /// <summary>
        /// 2088102146225135 买家支付宝用户ID。 2088开头的16位纯数字，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/introduce/authcode" target="_blank">用户授权</a>。注：交易的买家与卖家不能相同。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 小程序支付中，商户实际经营主体的小程序应用的appid，也即最终唤起收银台支付所在的小程序的应用id
        /// </summary>
        [XmlElement("op_app_id")]
        public string OpAppId { get; set; }

        /// <summary>
        /// 子订单详情
        /// </summary>
        [XmlArray("order_details")]
        [XmlArrayItem("order_detail")]
        public List<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// 外部合并单号，必传
        /// </summary>
        [XmlElement("out_merge_no")]
        public string OutMergeNo { get; set; }

        /// <summary>
        /// 订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注： time_expire和timeout_express两者只需传入一个或者都不传，两者均传入时，优先使用time_expire。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 合并支付订单相对超时时间。从商户合并预下单请求时间开始计算。 请求合并的所有订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 默认值为15d。 注：time_expire和timeout_express两者只需传入一个或者都不传，两者均传入时，优先使用time_expire。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
