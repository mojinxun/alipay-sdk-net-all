using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCreditCreditriskDataPutModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCreditCreditriskDataPutModel : AopObject
    {
        /// <summary>
        /// 数据类别,ISV注册成为网商银行的会员，达成数据合作服务，约定数据模型，由网商分配给ISV的数据模型的类别
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 外部机构编码(ISV注册成为网商银行的会员，ISV在网商的会员ID)
        /// </summary>
        [XmlElement("dataorgid")]
        public string Dataorgid { get; set; }

        /// <summary>
        /// 数据提供者,ISV注册成为网商银行的会员，达成数据合作服务，约定数据模型，由网商分配给ISV的机构代号
        /// </summary>
        [XmlElement("dataprovider")]
        public string Dataprovider { get; set; }

        /// <summary>
        /// 实体编码(ISV客户的支付宝数字ID)
        /// </summary>
        [XmlElement("entitycode")]
        public string Entitycode { get; set; }

        /// <summary>
        /// 实体名(ISV客户的支付宝登录号)
        /// </summary>
        [XmlElement("entityname")]
        public string Entityname { get; set; }

        /// <summary>
        /// 实体类型(固定为ALIPAY)
        /// </summary>
        [XmlElement("entitytype")]
        public string Entitytype { get; set; }

        /// <summary>
        /// 为满足网商银行数据跨域输出的合规要求，β计划中预付融资、赊呗、采购贷、池融资、网商贷等产品相关场景进行合规确权改造，确权方案中需在业务接口入参中加入auth_scene_code（授权场景码）和auth_token（授权令牌，用于鉴权）两个字段供调用方传入字段值
        /// </summary>
        [XmlElement("mybk_auth_scene_code")]
        public string MybkAuthSceneCode { get; set; }

        /// <summary>
        /// 为满足网商银行数据跨域输出的合规要求，β计划中预付融资、赊呗、采购贷、池融资、网商贷等产品相关场景进行合规确权改造，确权方案中需在业务接口入参中加入auth_scene_code（授权场景码）和auth_token（授权令牌，用于鉴权）两个字段供调用方传入字段值
        /// </summary>
        [XmlElement("mybk_auth_token")]
        public string MybkAuthToken { get; set; }

        /// <summary>
        /// Json格式,数据内容,ISV注册成为网商银行的会员，达成数据合作服务，约定json串字段和内容,ISV将数据给到网商，网商按照约定解析Json内容
        /// </summary>
        [XmlElement("objectcontent")]
        public string Objectcontent { get; set; }

        /// <summary>
        /// OpenId是某个用户在某个应用下的唯一用户标识， 对于同一个用户，不同应用拿到的OpenId是不同的，而且对于同一个应用，不同用户的OpenId是唯一的
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 采集任务ID
        /// </summary>
        [XmlElement("taskid")]
        public string Taskid { get; set; }
    }
}
