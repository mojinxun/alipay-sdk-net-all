using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestPlantApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestPlantApplyModel : AopObject
    {
        /// <summary>
        /// 出账购买树种的账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 兑换类型，默认是ACCOUNT，走account账户扣能量
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 接口扩展参数，商户可透传一些信息进来，后续扩展或者透传等作用，json字符串目前需要传以下参数{"accountName":"钉钉",//账号名称，必填 "type":"class",// 合种类型:class/corp，必填 "corp":"111", // 公司名称 "cooperation":"222" , // 合种名称，type为class时为班级名称 }
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发起该行为的支付宝用户 蚂蚁统一会员ID，可选
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于幂等操作
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 兑换树种时当前合种的参与人数
        /// </summary>
        [XmlElement("participant")]
        public long Participant { get; set; }

        /// <summary>
        /// 项目id，需要配合其他查询接口，查询到相关的项目之后使用。不限于树种，还包括保护地等
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 发起该行为的支付宝用户 蚂蚁统一会员ID，可选
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
