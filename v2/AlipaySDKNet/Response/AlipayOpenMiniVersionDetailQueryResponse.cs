using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionDetailQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        [XmlElement("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [XmlElement("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 准入审核结果 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("base_audit")]
        public string BaseAudit { get; set; }

        /// <summary>
        /// 准入审核驳回原因 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("base_audit_record")]
        public MiniAppAuditReason BaseAuditRecord { get; set; }

        /// <summary>
        /// 是否可上架 true：可上架 false：不可上架 （version_status 为PROMOTE_AUDIT_REJECT有值） （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("can_release")]
        public string CanRelease { get; set; }

        /// <summary>
        /// 小程序版本提交审核的时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_apply_audit")]
        public string GmtApplyAudit { get; set; }

        /// <summary>
        /// 小程序版本审核结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_audit_end")]
        public string GmtAuditEnd { get; set; }

        /// <summary>
        /// 小程序版本创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 小程序版本下架时间
        /// </summary>
        [XmlElement("gmt_offline")]
        public string GmtOffline { get; set; }

        /// <summary>
        /// 小程序版本上架时间
        /// </summary>
        [XmlElement("gmt_online")]
        public string GmtOnline { get; set; }

        /// <summary>
        /// 小程序灰度比例值，p10-10%的用户，p30-30%的用户，p50-50%的用户
        /// </summary>
        [XmlElement("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [XmlArray("mini_app_category_info_list")]
        [XmlArrayItem("mini_app_category_info")]
        public List<MiniAppCategoryInfo> MiniAppCategoryInfoList { get; set; }

        /// <summary>
        /// 新小程序类目列表
        /// </summary>
        [XmlArray("mini_category_info_list")]
        [XmlArrayItem("mini_app_category_info")]
        public List<MiniAppCategoryInfo> MiniCategoryInfoList { get; set; }

        /// <summary>
        /// 小程序功能包列表
        /// </summary>
        [XmlArray("package_info_list")]
        [XmlArrayItem("mini_package_info")]
        public List<MiniPackageInfo> PackageInfoList { get; set; }

        /// <summary>
        /// 营销审核结果： PASS：通过 REJECT：驳回 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("promote_audit")]
        public string PromoteAudit { get; set; }

        /// <summary>
        /// 营销审核驳回原因 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("promote_audit_record")]
        public MiniAppAuditReason PromoteAuditRecord { get; set; }

        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 安全扫描结果，True-安全扫描通过，False-安全扫描不通过，NAN-扫描中
        /// </summary>
        [XmlElement("scan_result")]
        public string ScanResult { get; set; }

        /// <summary>
        /// 小程序版本截图，多个截图以逗号隔开
        /// </summary>
        [XmlArray("screen_shot_list")]
        [XmlArrayItem("string")]
        public List<string> ScreenShotList { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [XmlElement("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 小程序服务区域信息，当服务区域类型是LOCATION时，这里明确指出具体的服务区域信息
        /// </summary>
        [XmlArray("service_region_info")]
        [XmlArrayItem("region_info")]
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 小程序服务区域类型
        /// </summary>
        [XmlElement("service_region_type")]
        public string ServiceRegionType { get; set; }

        /// <summary>
        /// 小程序版本状态，INIT-开发中，AUDITING-审核中，WAIT_RELEASE-待上架，BASE_AUDIT_PASS-准入不可营销，AUDIT_REJECT-审核驳回，RELEASE-已上架，GRAY-灰度中，OFFLINE-已下架，AUDIT_OFFLINE-已被强制下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 小程序版本描述
        /// </summary>
        [XmlElement("version_desc")]
        public string VersionDesc { get; set; }
    }
}
