using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspUserwithvidCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspUserwithvidCreateModel : AopObject
    {
        /// <summary>
        /// 组件编码，该参数与userInfoList配对使用。详见接入指南
        /// </summary>
        [XmlElement("component_out_id")]
        public string ComponentOutId { get; set; }

        /// <summary>
        /// ISV的PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 机构用户信息,isv需传vid
        /// </summary>
        [XmlArray("user_info_list")]
        [XmlArrayItem("iot_vsp_org_user_with_vid_add_user_info_request")]
        public List<IotVspOrgUserWithVidAddUserInfoRequest> UserInfoList { get; set; }
    }
}
