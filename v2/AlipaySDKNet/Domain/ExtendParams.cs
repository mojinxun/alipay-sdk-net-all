using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendParams : AopObject
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 使用花呗分期要进行的分期数
        /// </summary>
        [XmlElement("hb_fq_num")]
        public string HbFqNum { get; set; }

        /// <summary>
        /// 使用花呗分期需要卖家承担的手续费比例的百分值，传入100代表100%
        /// </summary>
        [XmlElement("hb_fq_seller_percent")]
        public string HbFqSellerPercent { get; set; }

        /// <summary>
        /// 行业数据回流信息, 详见：地铁支付接口参数补充说明
        /// </summary>
        [XmlElement("industry_reflux_info")]
        public string IndustryRefluxInfo { get; set; }

        /// <summary>
        /// 是否进行资金冻结，用于后续分账，true表示资金冻结，false或不传表示资金不冻结
        /// </summary>
        [XmlElement("royalty_freeze")]
        public string RoyaltyFreeze { get; set; }

        /// <summary>
        /// 特殊场景下，允许商户指定交易展示的卖家名称
        /// </summary>
        [XmlElement("specified_seller_name")]
        public string SpecifiedSellerName { get; set; }

        /// <summary>
        /// 系统商编号  该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 公域商品交易分期单ID，小程序交易组件订单特殊场景使用，请传入 订单分期接口(alipay.open.mini.order.installment.create)中返回的installment_order_id
        /// </summary>
        [XmlElement("tc_installment_order_id")]
        public string TcInstallmentOrderId { get; set; }

        /// <summary>
        /// 公域商品交易业务订单ID
        /// </summary>
        [XmlElement("trade_component_order_id")]
        public string TradeComponentOrderId { get; set; }
    }
}
