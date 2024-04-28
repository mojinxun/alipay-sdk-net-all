using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherBudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherBudgetInfo : AopObject
    {
        /// <summary>
        /// 营销资金预算,单位元。 总预算=优惠金额*总发券张数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 营销资金预算类型 1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。 2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// "预充值详情 限制: 1、budget_type为RECAHRGE时必传"
        /// </summary>
        [XmlElement("recharge_info")]
        public PaymentVoucherRechargeInfo RechargeInfo { get; set; }
    }
}
