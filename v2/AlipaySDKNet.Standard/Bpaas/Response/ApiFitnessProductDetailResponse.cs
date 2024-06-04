using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessProductDetailResponse : AopResponse
{

    /// <summary>
    /// 商品描述
    /// </summary>
    [XmlElement("description")]
    public string Description { get; set; }

    /// <summary>
    /// 商品名称
    /// </summary>
    [XmlElement("productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// 适用门店信息列表
    /// </summary>
    [XmlArray("applicableShopInfoList")]
    [XmlArrayItem("applicableShopInfoList")]
    public List<ShopInfoDTO> ApplicableShopInfoList { get; set; }

    /// <summary>
    /// 商户名称
    /// </summary>
    [XmlElement("merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("expiryDate")]
    public int ExpiryDate { get; set; }

    /// <summary>
    /// 是否越用越优惠
    /// 系统默认值 否
    /// YES: 是
    /// NO: 否
    /// </summary>
    [XmlElement("moreUseMoreDiscount")]
    public string MoreUseMoreDiscount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 优惠后的单价
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// 前N期价格
    /// </summary>
    [XmlElement("downPayment")]
    public string DownPayment { get; set; }

    /// <summary>
    /// 每期价格信息
    /// “是否越用越优惠”参数为YES时必返
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
    public string MerchantPid { get; set; }

    /// <summary>
    /// 前N期金额期数
    /// </summary>
    [XmlElement("downPaymentPeriods")]
    public int DownPaymentPeriods { get; set; }

    /// <summary>
    /// 产品编号
    /// </summary>
    [XmlElement("productNo")]
    public string ProductNo { get; set; }

    /// <summary>
    /// 公域商品售卖起始时间
    /// </summary>
    [XmlElement("saleStartTime")]
    public string SaleStartTime { get; set; }

    /// <summary>
    /// 商品封面图URL
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
    /// 使用规则
    /// </summary>
    [XmlArray("purchaseNotesList")]
    [XmlArrayItem("purchaseNotesList")]
    public List<string> PurchaseNotesList { get; set; }

    /// <summary>
    /// 商品类目编码
    /// 公域使用（目前可以不填）
    /// </summary>
    [XmlElement("categoryCode")]
    public string CategoryCode { get; set; }

    /// <summary>
    /// 公域商品售卖结束时间
    /// </summary>
    [XmlElement("saleEndTime")]
    public string SaleEndTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subscriptionSecondType")]
    public string SubscriptionSecondType { get; set; }

    /// <summary>
    /// 商品现总价 所有期数优惠金额加起来
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
    /// 副标题
    /// </summary>
    [XmlElement("subhead")]
    public string SubHead { get; set; }



    /// <summary>
    /// 计费周期值（天数）
    /// 周期付-特有
    /// </summary>
    [XmlElement("deductionDays")]
    public int DeductionDays { get; set; }

    /// <summary>
    /// 商品计费周期值类型
    /// 行业周期付-需要
    /// USER_DESIGN 用户指定的固定日期
    /// FIXED_DATE 商家指定的固定日期
    /// </summary>
    [XmlElement("cycleChargeType")]
    public string CycleChargeType { get; set; }

    /// <summary>
    /// 原单价
    /// 原单价	月卡 MONTH、周卡 WEEK 没有此参数
    /// </summary>
    [XmlElement("originalPrice")]
    public string OriginalPrice { get; set; }

    /// <summary>
    /// 商品原价总金额
    /// 所有期数原价加起来
    /// 月卡 MONTH、周卡 WEEK 没有此参数
    /// </summary>
    [XmlElement("productOriginalPrice")]
    public string ProductOriginalPrice { get; set; }
}
