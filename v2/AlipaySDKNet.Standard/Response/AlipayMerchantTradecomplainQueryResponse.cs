using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantTradecomplainQueryResponse.
    /// </summary>
    public class AlipayMerchantTradecomplainQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 用户投诉原因
        /// </summary>
        [XmlElement("complain_reason")]
        public string ComplainReason { get; set; }

        /// <summary>
        /// 用户投诉内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 投诉单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 投诉单完结时间
        /// </summary>
        [XmlElement("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 投诉单修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投诉图片
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 用户投诉诉求
        /// </summary>
        [XmlElement("leaf_category_name")]
        public string LeafCategoryName { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 投诉人电话号码
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 用户与商家之间的协商记录
        /// </summary>
        [XmlArray("reply_detail_infos")]
        [XmlArrayItem("reply_record_response")]
        public List<ReplyRecordResponse> ReplyDetailInfos { get; set; }

        /// <summary>
        /// 状态  待处理：MERCHANT_PROCESSING  已处理：MERCHANT_FEEDBACKED  投诉完结：FINISHED  投诉关闭：CANCELLED  客服处理中：PLATFORM_PROCESSING  客服处理完结：PLATFORM_FINISH  投诉关闭：CLOSED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用id，例如小程序id、生活号id、商家pid
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 例如小程序：APPID 生活号：PUBLICID 商家账户：PID
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 交易金额，单位元
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
