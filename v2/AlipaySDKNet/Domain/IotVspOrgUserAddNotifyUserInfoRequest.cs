using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotVspOrgUserAddNotifyUserInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class IotVspOrgUserAddNotifyUserInfoRequest : AopObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 扩展信息，ISV自定义，如无可为空
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 返回状态描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 返回入库状态（1：成功，2：失败）
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }

        /// <summary>
        /// 机构用户ID
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
