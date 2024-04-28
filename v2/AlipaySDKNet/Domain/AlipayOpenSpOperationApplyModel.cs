using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOperationApplyModel : AopObject
    {
        /// <summary>
        /// 接入的产品编号。 枚举如下： * OPENAPI_BIND_DEFAULT：操作类型为账号绑定。 * OPENAPI_AUTH_DEFAULT：操作类型为代运营授权时。
        /// </summary>
        [XmlElement("access_product_code")]
        public string AccessProductCode { get; set; }

        /// <summary>
        /// 支付宝登录账号，通常为手机号或者邮箱。 间连场景必填。 直连场景选填，特别注意merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2; 说明： * 本参数和access_product_code只需要传一个。 * 场景 + 权限Code含义：    SHOP_MANAGE:SHOP_MANAGE_BASE：管理门店信息    MINI_APP_OPER:MINI_APP_OPER_BASE：运营支付宝小程序    PROMOTION_MANAGE:PROMOTION_MANAGE_BASE：运营营销活动    OPERATION_POINTS:OPERATION_POINTS_BASE：管理运营积分    INCENTIVE_POINT_MANAGE:INCENTIVE_POINT_MANAGE_BASE：管理激励点数
        /// </summary>
        [XmlElement("isv_scene_permissions")]
        public string IsvScenePermissions { get; set; }

        /// <summary>
        /// 支付宝商户号。 间连场景，merchant_no必填，传入商户smid，特别注意仅支持2088开头的间连商户。 直连场景，merchant_no选填，传入商户支付宝pid，特别注意merchant_no和alipay_account不能同时为空，优先取merchant_no。
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 代运营操作类型。枚举如下： * ACCOUNT_BIND：代表绑定支付宝账号，仅对于间连商户。 * OPERATION_AUTH：代表代运营授权，支持间连和直连商户，其中间连场景包含绑定支付宝账号。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部操作流水，ISV自定义。每次操作需要确保唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
