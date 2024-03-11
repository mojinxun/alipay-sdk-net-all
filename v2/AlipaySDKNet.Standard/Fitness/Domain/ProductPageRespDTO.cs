using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class ProductPageRespDTO
{
    /// <summary>
    /// ������Ʒ������ʼʱ��
    /// </summary>
    [XmlElement("saleStartTime")]
    public string SaleStartTime { get; set; }

    /// <summary>
    /// ��Ʒԭ���ܽ��
    /// </summary>
    [XmlElement("productOriginalPrice")]
    public string ProductOriginalPrice { get; set; }

    /// <summary>
    /// ԭ����
    /// </summary>
    [XmlElement("originalPrice")]
    public string OriginalPrice { get; set; }

    /// <summary>
    /// ��ƷͼƬ
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
    /// ��Ʒ�Ʒ�����ֵ����
    /// USER_DESIGN �û�ָ���Ĺ̶�����
    /// FIXED_DATE �̼�ָ���Ĺ̶�����
    /// </summary>
    [XmlElement("cycleChargeType")]
    public string CycleChargeType { get; set; }

    /// <summary>
    /// ��Ʒ��Ŀ����
    /// </summary>
    [XmlElement("categoryCode")]
    public string CategoryCode { get; set; }

    /// <summary>
    /// �Ʒ�����ֵ��������
    /// ���ڸ�-����
    /// </summary>
    [XmlElement("deductionDays")]
    public int DeductionDays { get; set; }

    /// <summary>
    /// ��Ʒ����
    /// </summary>
    [XmlElement("productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Y	�̻�����
    /// </summary>
    [XmlElement("merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// �ƹ�����
    /// </summary>
    [XmlArray("promoteChannelNames")]
    [XmlArrayItem("promoteChannelNames")]
    public List<string> PromoteChannelNames { get; set; }

    /// <summary>
    /// ������Ʒ��������ʱ��
    /// </summary>
    [XmlElement("saleEndTime")]
    public string SaleEndTime { get; set; }

    /// <summary>
    /// �Ƿ�Խ��Խ�Ż�
    /// ϵͳĬ��ֵ ��
    /// YES: ��
    /// NO: ��
    /// </summary>
    [XmlElement("moreUseMoreDiscount")]
    public string NoreUseMoreDiscount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("subscriptionSecondType")]
    public string SubscriptionSecondType { get; set; }

    /// <summary>
    /// �Żݺ�ĵ���
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// ��Ʒ�Żݼ��ܽ��
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
    /// ÿ�ڼ۸���Ϣ
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
    public string merchantPid { get; set; }


    /// <summary>
    /// ��Ʒ���
    /// </summary>
    [XmlElement("productNo")]
    public string productNo { get; set; }

}
