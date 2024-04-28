using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDisplayPatternInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDisplayPatternInfo : AopObject
    {
        /// <summary>
        /// 商家logo 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值。
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商家品牌logo链接
        /// </summary>
        [XmlElement("brand_logo_url")]
        public string BrandLogoUrl { get; set; }

        /// <summary>
        /// 商户品牌名称。
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 客服电话。
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 客服链接。
        /// </summary>
        [XmlElement("customer_service_url")]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 券详细使用说明。
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券详情链接
        /// </summary>
        [XmlArray("voucher_detail_image_urls")]
        [XmlArrayItem("string")]
        public List<string> VoucherDetailImageUrls { get; set; }

        /// <summary>
        /// 券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。
        /// </summary>
        [XmlArray("voucher_detail_images")]
        [XmlArrayItem("string")]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 券详情页封面图，会展示在用户支付宝卡包券详情页。 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。
        /// </summary>
        [XmlElement("voucher_image")]
        public string VoucherImage { get; set; }

        /// <summary>
        /// 券封面链接
        /// </summary>
        [XmlElement("voucher_image_url")]
        public string VoucherImageUrl { get; set; }

        /// <summary>
        /// 券名称。
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }
    }
}
