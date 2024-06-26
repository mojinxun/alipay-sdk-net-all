using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCardMsgInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCardMsgInfo : AopObject
    {
        /// <summary>
        /// 本次消息通知的变动积分，积分必须为数字型（可为浮点型，带2位小数点），格式非法则不发送消息。例如： 100，则代表增加100积分。 -100，则代表减少100积分。
        /// </summary>
        [XmlElement("changed_point")]
        public string ChangedPoint { get; set; }
    }
}
