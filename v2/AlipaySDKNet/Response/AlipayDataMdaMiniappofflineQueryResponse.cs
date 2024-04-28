using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniappofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniappofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 累计行程规划人数
        /// </summary>
        [XmlElement("journey_planning")]
        public long JourneyPlanning { get; set; }

        /// <summary>
        /// 累计行程规划人数趋势
        /// </summary>
        [XmlElement("journey_planning_trend")]
        public string JourneyPlanningTrend { get; set; }

        /// <summary>
        /// 赛事关注TOP5
        /// </summary>
        [XmlElement("match_focus")]
        public string MatchFocus { get; set; }

        /// <summary>
        /// 亚运PASS领码人数
        /// </summary>
        [XmlElement("obtain_pass")]
        public long ObtainPass { get; set; }

        /// <summary>
        /// 亚运PASS持票出行人数
        /// </summary>
        [XmlElement("pass_travel_user_cnt")]
        public long PassTravelUserCnt { get; set; }

        /// <summary>
        /// 亚运PASS持票出行人数分时图
        /// </summary>
        [XmlElement("pass_travel_user_trend")]
        public string PassTravelUserTrend { get; set; }

        /// <summary>
        /// 亚运PASS使用场景
        /// </summary>
        [XmlElement("pass_use_scene")]
        public string PassUseScene { get; set; }

        /// <summary>
        /// 票+服务
        /// </summary>
        [XmlElement("ticket_service")]
        public string TicketService { get; set; }

        /// <summary>
        /// 亚运PASS
        /// </summary>
        [XmlElement("use_pass")]
        public long UsePass { get; set; }

        /// <summary>
        /// 用户分布城市TOP5
        /// </summary>
        [XmlElement("user_distribution")]
        public string UserDistribution { get; set; }
    }
}
