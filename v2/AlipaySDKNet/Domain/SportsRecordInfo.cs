using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SportsRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SportsRecordInfo : AopObject
    {
        /// <summary>
        /// 消耗卡路里，实际为 decimal类型，有小数
        /// </summary>
        [XmlElement("calorie")]
        public string Calorie { get; set; }

        /// <summary>
        /// 单位米，实际为 decimal类型，有小数
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 运动时长，单位秒，整数
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 结束时人脸比对是否通过，没有值表示没有发起过刷脸
        /// </summary>
        [XmlElement("finish_face_verify_pass")]
        public bool FinishFaceVerifyPass { get; set; }

        /// <summary>
        /// 运动结束时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 来源应用ID
        /// </summary>
        [XmlElement("from_app_id")]
        public string FromAppId { get; set; }

        /// <summary>
        /// 最高海拔，单位米
        /// </summary>
        [XmlElement("max_altitude")]
        public string MaxAltitude { get; set; }

        /// <summary>
        /// 最低海拔，单位米
        /// </summary>
        [XmlElement("min_altitude")]
        public string MinAltitude { get; set; }

        /// <summary>
        /// 外部业务编码，标识一个appId下面的一个特定的业务
        /// </summary>
        [XmlElement("out_biz_code")]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 运动流水的发生日期
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 运动流水ID，标识一次运动
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 运动速度，单位 km/h，实际为 decimal类型，有小数
        /// </summary>
        [XmlElement("speed")]
        public string Speed { get; set; }

        /// <summary>
        /// 运动状态
        /// </summary>
        [XmlElement("sport_status")]
        public string SportStatus { get; set; }

        /// <summary>
        /// 运动类型
        /// </summary>
        [XmlElement("sport_type")]
        public string SportType { get; set; }

        /// <summary>
        /// 开始时刷脸是否通过，没有值表示没有发起过刷脸
        /// </summary>
        [XmlElement("start_face_verify_pass")]
        public bool StartFaceVerifyPass { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 步数
        /// </summary>
        [XmlElement("step_count")]
        public string StepCount { get; set; }

        /// <summary>
        /// 步频，一分钟多少步
        /// </summary>
        [XmlElement("step_frequency")]
        public string StepFrequency { get; set; }

        /// <summary>
        /// 步数信息是否有效； true有效，false无效
        /// </summary>
        [XmlElement("step_info_valid")]
        public bool StepInfoValid { get; set; }

        /// <summary>
        /// 步幅，一步多少米
        /// </summary>
        [XmlElement("step_stride")]
        public string StepStride { get; set; }
    }
}
