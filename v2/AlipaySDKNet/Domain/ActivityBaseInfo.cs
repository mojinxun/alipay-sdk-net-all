using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityBaseInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动操作状态。
        /// </summary>
        [XmlElement("activity_operation_status")]
        public string ActivityOperationStatus { get; set; }

        /// <summary>
        /// 券活动产品类型
        /// </summary>
        [XmlElement("activity_product_type")]
        public string ActivityProductType { get; set; }

        /// <summary>
        /// 活动状态 。 ACTIVE:活动已激活，表示活动已经生效，等到活动开始(publish_start_time)之后用户就可以参与活动。  PAUSE:活动已暂停，表示商户临时暂停该活动，该状态下用户不能参与活动。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商家券活动归属的商户信息。 说明： 如果该复杂对象不填。则默认为该商家券活动的归属者是调用者本人。 如果填写，则认为该商家券活动的归属者是该商户。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 码模式。   MERCHANT_UPLOAD：商户上传自定义code，发券时系统随机选取上传的券code发放  MERCHANT_API：发奖时指定券码发奖，此模式无须提前上传券码。
        /// </summary>
        [XmlElement("code_mode")]
        public string CodeMode { get; set; }

        /// <summary>
        /// 外部活动ID
        /// </summary>
        [XmlElement("out_activity_id")]
        public string OutActivityId { get; set; }
    }
}
