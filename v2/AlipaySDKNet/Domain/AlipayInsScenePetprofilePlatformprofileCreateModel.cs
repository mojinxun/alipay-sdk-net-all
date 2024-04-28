using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsScenePetprofilePlatformprofileCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsScenePetprofilePlatformprofileCreateModel : AopObject
    {
        /// <summary>
        /// 生日 档案生日不能早于2000年，且不能晚于当天
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 宠物性别 1 公; 2 母
        /// </summary>
        [XmlElement("gender")]
        public long Gender { get; set; }

        /// <summary>
        /// 宠物昵称 不能包含字母、数字和中文以外的字符
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 外部业务单号，用于幂等处理，避免多次建档
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 宠物照片列表
        /// </summary>
        [XmlArray("photos")]
        [XmlArrayItem("pet_photo")]
        public List<PetPhoto> Photos { get; set; }

        /// <summary>
        /// 是否绝育，0 否；1 是；2 未知
        /// </summary>
        [XmlElement("sterilization")]
        public long Sterilization { get; set; }

        /// <summary>
        /// 宠物类型：狗(2000)/猫(1000)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
