using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectSharetokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectSharetokenCreateModel : AopObject
    {
        /// <summary>
        /// 通过吱口令打开支付宝后的页面跳转链接，例如服务商支付页URL
        /// </summary>
        [XmlElement("biz_link")]
        public string BizLink { get; set; }

        /// <summary>
        /// 业务场景码定义，用以区分吱口令应用的业务场景。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务跟踪参数，用于串联用户业务行为的关系
        /// </summary>
        [XmlElement("biz_tracker")]
        public string BizTracker { get; set; }

        /// <summary>
        /// 渠道信息摘要标识，在APP内吱口令跳转时用到，用来标识吱口令关联的服务信息，比如红包、花呗工具。有两种方式获得：1.在于支付宝进行业务合作时，由平台侧分配；2.在咨询前置服务时由接口返回。
        /// </summary>
        [XmlElement("channel_info")]
        public string ChannelInfo { get; set; }

        /// <summary>
        /// 吱口令有效期，单位秒。例如:3600*24 (代表一天)
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 吱口令生成扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public ShareCodeCreateExtendParam ExtendParams { get; set; }

        /// <summary>
        /// 商户的名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 该参数为开放平台为服务商用户分配的用户唯一标识
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单需要支付的金额，单位为元(人民币)，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝间连商户SMID
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
