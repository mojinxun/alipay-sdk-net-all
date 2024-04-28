using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardOperator Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardOperator : AopObject
    {
        /// <summary>
        /// 当op_type=spcenter_isv_op(SSB代运营场景)时，对应的op_id是代运营服务商S2的操作员账号，ext_op_id是代运营服务商S2的主账号，主账号需要先获取商家的代运营授权。
        /// </summary>
        [XmlElement("ext_op_id")]
        public string ExtOpId { get; set; }

        /// <summary>
        /// 用于指定当前操作人的id，当op_type为以下4种情况时： self：商家自运营场景，op_id需要和应用主体pid一致。 spcenter_isv：服务商代运营场景，op_id是代运营服务商的主账号，该账号需要先获取商家的代运营授权。 spcenter_isv_op：SSB代运营场景，op_id是代运营服务商S2的操作员账号，对应ext_op_id是代运营服务商S2的主账号，主账号需要先获取商家的代运营授权。 custom：服务商代运营场景，op_id为服务商自有账号体系的账号，支付宝将在开通/修改安心充配置时，调用spi.ant.merchant.expand.membercard.configauth.consult（咨询代运营服务商和商家之间的授权关系）接口，校验代运营服务商op_id和商家之间的授权关系。
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 用于指定当前操作人的角色类型，支持以下4种： self：商家自运营场景，对应op_id需要和应用主体pid一致。 spcenter_isv：服务商代运营场景，对应op_id是代运营服务商的主账号，该账号需要先获取商家的代运营授权。 spcenter_isv_op：SSB代运营场景，对应的op_id是代运营服务商S2的操作员账号，对应ext_op_id是代运营服务商S2的主账号，主账号需要先获取商家的代运营授权。 custom：服务商代运营场景，对应op_id为服务商自有账号体系的账号，支付宝将在开通/修改安心充配置时，调用spi.ant.merchant.expand.membercard.configauth.consult（咨询代运营服务商和商家之间的授权关系）接口，校验代运营服务商op_id和商家之间的授权关系。
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }
    }
}
