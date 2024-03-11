using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ProductPageRespDTO
{
    /// <summary>
    /// 公域商品售卖起始时间
    /// </summary>
    [XmlElement("saleStartTime")]
    public string SaleStartTime { get; set; }

    /// <summary>
    /// 商品原价总金额
    /// </summary>
    [XmlElement("productOriginalPrice")]
    public string ProductOriginalPrice { get; set; }

    /// <summary>
    /// 原单价
    /// </summary>
    [XmlElement("originalPrice")]
    public string OriginalPrice { get; set; }

    /// <summary>
    /// 商品图片
    /// </summary>
    [XmlElement("productCoverPicUrl")]
    public string ProductCoverPicUrl { get; set; }

    /// <summary>
    /// 商品状态
    /// PRODUCT_UP 已上架
    /// WAIT_UP 待上架
    /// PRODUCT_DOWN 已下架
    /// </summary>
    [XmlElement("productStatus")]
    public string ProductStatus { get; set; }

    /// <summary>
    /// 商品计费周期值类型
    /// USER_DESIGN 用户指定的固定日期
    /// FIXED_DATE 商家指定的固定日期
    /// </summary>
    [XmlElement("cycleChargeType")]
    public string CycleChargeType { get; set; }

    /// <summary>
    /// 商品类目编码
    /// </summary>
    [XmlElement("categoryCode")]
    public string CategoryCode { get; set; }

    /// <summary>
    /// 计费周期值（天数）
    /// 周期付-特有
    /// </summary>
    [XmlElement("deductionDays")]
    public int DeductionDays { get; set; }

    /// <summary>
    /// 商品名称
    /// </summary>
    [XmlElement("productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Y	商户名称
    /// </summary>
    [XmlElement("merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// 推广渠道
    /// </summary>
    [XmlArray("promoteChannelNames")]
    [XmlArrayItem("promoteChannelNames")]
    public List<string> PromoteChannelNames { get; set; }

    /// <summary>
    /// 公域商品售卖结束时间
    /// </summary>
    [XmlElement("saleEndTime")]
    public string SaleEndTime { get; set; }

    /// <summary>
    /// 是否越用越优惠
    /// 系统默认值 否
    /// YES: 是
    /// NO: 否
    /// </summary>
    [XmlElement("moreUseMoreDiscount")]
    public string NoreUseMoreDiscount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subscriptionSecondType")]
    public string SubscriptionSecondType { get; set; }

    /// <summary>
    /// 优惠后的单价
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// 商品优惠价总金额
    /// </summary>
    [XmlElement("productDiscountPrice")]
    public string ProductDiscountPrice { get; set; }

    /// <summary>
    /// 订购类型
    /// DISCOUNT_TIME 优惠次卡
    /// </summary>
    [XmlElement("subscriptionType")]
    public string SubscriptionType { get; set; }

    /// <summary>
    /// 每期价格信息
    /// </summary>
    [XmlArray("perPeriodPriceArray")]
    [XmlArrayItem("perPeriodPriceArray")]
    public List<string> PerPeriodPriceArray { get; set; }

    /// <summary>
    /// 开通总周期数
    /// </summary>
    [XmlElement("periods")]
    public int Periods { get; set; }

    /// <summary>
    /// 商户pid
    /// </summary>
    [XmlElement("merchantPid")]
    public string merchantPid { get; set; }


    /// <summary>
    /// 产品编号
    /// </summary>
    [XmlElement("productNo")]
    public string productNo { get; set; }

}
