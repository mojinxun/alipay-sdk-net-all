using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ApiFitnessProductDetailResponse : AopResponse
{

    /// <summary>
    /// ��Ʒ����
    /// </summary>
    [XmlElement("description")]
    public string Description { get; set; }

    /// <summary>
    /// ��Ʒ����
    /// </summary>
    [XmlElement("productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// �����ŵ���Ϣ�б�
    /// </summary>
    [XmlArray("applicableShopInfoList")]
    [XmlArrayItem("applicableShopInfoList")]
    public List<ShopInfoDTO> ApplicableShopInfoList { get; set; }

    /// <summary>
    /// �̻�����
    /// </summary>
    [XmlElement("merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("expiryDate")]
    public int ExpiryDate { get; set; }

    /// <summary>
    /// �Ƿ�Խ��Խ�Ż�
    /// ϵͳĬ��ֵ ��
    /// YES: ��
    /// NO: ��
    /// </summary>
    [XmlElement("moreUseMoreDiscount")]
    public string MoreUseMoreDiscount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// �Żݺ�ĵ���
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// ǰN�ڼ۸�
    /// </summary>
    [XmlElement("downPayment")]
    public string DownPayment { get; set; }

    /// <summary>
    /// ÿ�ڼ۸���Ϣ
    /// ���Ƿ�Խ��Խ�Żݡ�����ΪYESʱ�ط�
    /// </summary>
    [XmlArray("perPeriodPriceArray")]
    [XmlArrayItem("perPeriodPriceArray")]
    public List<string> PerPeriodPriceArray { get; set; }

    /// <summary>
    /// ��ͨ��������
    /// </summary>
    [XmlElement("periods")]
    public int Periods { get; set; }

    /// <summary>
    /// �̻�pid
    /// </summary>
    [XmlElement("merchantPid")]
    public string MerchantPid { get; set; }

    /// <summary>
    /// ǰN�ڽ������
    /// </summary>
    [XmlElement("downPaymentPeriods")]
    public int DownPaymentPeriods { get; set; }

    /// <summary>
    /// ��Ʒ���
    /// </summary>
    [XmlElement("productNo")]
    public string ProductNo { get; set; }

    /// <summary>
    /// ������Ʒ������ʼʱ��
    /// </summary>
    [XmlElement("saleStartTime")]
    public string SaleStartTime { get; set; }

    /// <summary>
    /// ��Ʒ����ͼURL
    /// </summary>
    [XmlElement("productCoverPicUrl")]
    public string ProductCoverPicUrl { get; set; }

    /// <summary>
    /// ��Ʒ״̬
    /// PRODUCT_UP ���ϼ�
    /// WAIT_UP ���ϼ�
    /// PRODUCT_DOWN ���¼�
    /// </summary>
    [XmlElement("productStatus")]
    public string ProductStatus { get; set; }

    /// <summary>
    /// ʹ�ù���
    /// </summary>
    [XmlArray("purchaseNotesList")]
    [XmlArrayItem("purchaseNotesList")]
    public List<string> PurchaseNotesList { get; set; }

    /// <summary>
    /// ��Ʒ��Ŀ����
    /// ����ʹ�ã�Ŀǰ���Բ��
    /// </summary>
    [XmlElement("categoryCode")]
    public string CategoryCode { get; set; }

    /// <summary>
    /// ������Ʒ��������ʱ��
    /// </summary>
    [XmlElement("saleEndTime")]
    public string SaleEndTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subscriptionSecondType")]
    public string SubscriptionSecondType { get; set; }

    /// <summary>
    /// ��Ʒ���ܼ� ���������Żݽ�������
    /// </summary>
    [XmlElement("productDiscountPrice")]
    public string ProductDiscountPrice { get; set; }

    /// <summary>
    /// ��������	
    /// DISCOUNT_TIME �Żݴο�
    /// </summary>
    [XmlElement("subscriptionType")]
    public string SubscriptionType { get; set; }

    /// <summary>
    /// ������
    /// </summary>
    [XmlElement("subhead")]
    public string SubHead { get; set; }



    /// <summary>
    /// �Ʒ�����ֵ��������
    /// ���ڸ�-����
    /// </summary>
    [XmlElement("deductionDays")]
    public int DeductionDays { get; set; }

    /// <summary>
    /// ��Ʒ�Ʒ�����ֵ����
    /// ��ҵ���ڸ�-��Ҫ
    /// USER_DESIGN �û�ָ���Ĺ̶�����
    /// FIXED_DATE �̼�ָ���Ĺ̶�����
    /// </summary>
    [XmlElement("cycleChargeType")]
    public string CycleChargeType { get; set; }

    /// <summary>
    /// ԭ����
    /// ԭ����	�¿� MONTH���ܿ� WEEK û�д˲���
    /// </summary>
    [XmlElement("originalPrice")]
    public string OriginalPrice { get; set; }

    /// <summary>
    /// ��Ʒԭ���ܽ��
    /// ��������ԭ�ۼ�����
    /// �¿� MONTH���ܿ� WEEK û�д˲���
    /// </summary>
    [XmlElement("productOriginalPrice")]
    public string ProductOriginalPrice { get; set; }
}
