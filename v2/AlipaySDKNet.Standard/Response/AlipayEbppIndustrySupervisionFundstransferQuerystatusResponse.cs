using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFundstransferQuerystatusResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionFundstransferQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 资金划拨的金额（单位分）
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 资金划拨币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 外部流水号确保每一笔资金划拨请求幂等。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易成功时有值
        /// </summary>
        [XmlElement("pay_finish_time")]
        public string PayFinishTime { get; set; }

        /// <summary>
        /// 保证金退款场景下，填收方账户类型，本次写02，代表对公户
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 保证金退款场景下，填收方账户所在行的联行号，本次为支付宝联行号
        /// </summary>
        [XmlElement("payee_contact_line")]
        public string PayeeContactLine { get; set; }

        /// <summary>
        /// 收方参与者ID
        /// </summary>
        [XmlElement("payee_participant_id")]
        public string PayeeParticipantId { get; set; }

        /// <summary>
        /// 保证金退款场景下，收方户名必填
        /// </summary>
        [XmlElement("payee_participant_name")]
        public string PayeeParticipantName { get; set; }

        /// <summary>
        /// 收方参与者类型
        /// </summary>
        [XmlElement("payee_participant_type")]
        public string PayeeParticipantType { get; set; }

        /// <summary>
        /// 付方参与者ID
        /// </summary>
        [XmlElement("payer_participant_id")]
        public string PayerParticipantId { get; set; }

        /// <summary>
        /// 付款方账户类型
        /// </summary>
        [XmlElement("payer_participant_type")]
        public string PayerParticipantType { get; set; }

        /// <summary>
        /// 保证金退保至支付宝ACS账户时需要经过监管子户过桥。该场景下，当前字段需要填写驾校监管子户号
        /// </summary>
        [XmlElement("relate_participant_id")]
        public string RelateParticipantId { get; set; }

        /// <summary>
        /// 在保证金退回场景下，需要有监管子户过桥。 当前字段必填且为驾校监管子户
        /// </summary>
        [XmlElement("relate_participant_type")]
        public string RelateParticipantType { get; set; }

        /// <summary>
        /// 资金划拨请求备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 资金划拨场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 资金划拨结果描述，比如余额不足，账户被冻结
        /// </summary>
        [XmlElement("transfer_msg")]
        public string TransferMsg { get; set; }

        /// <summary>
        /// SUCCESS: 成功 FAIL: 失败 DEALING: 处理中 CLOSED: 已关闭
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }
    }
}
