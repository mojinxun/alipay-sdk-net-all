using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyShopTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelFliggyShopTransferModel : AopObject
    {
        /// <summary>
        /// 同步数据类型与实际数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 用户id，与user_id_type配合使用，暂时仅支持集团havanaId和支付宝2088开头的16位数字ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求唯一id，只能是大小写字母及数字。不带业务含义，可以由uuid等随机生成，用于唯一标识一笔业务，方便与外部排查问题
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 用户id，与user_id_type配合使用，暂时仅支持集团havanaId和支付宝2088开头的16位数字ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id类型枚举，与user_id配合使用。取值说明：HAVANA为集团havanaId，ALIPAY为支付宝2088开头用户id
        /// </summary>
        [XmlElement("user_id_type")]
        public string UserIdType { get; set; }
    }
}
