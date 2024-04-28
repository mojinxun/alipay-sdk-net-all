using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierCompanyoverviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierCompanyoverviewQueryModel : AopObject
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 业务场景。不同业务场景，输出结果不同，请联系接口对接人，分配业务场景码。若无特殊要求，默认值：ex1688
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
