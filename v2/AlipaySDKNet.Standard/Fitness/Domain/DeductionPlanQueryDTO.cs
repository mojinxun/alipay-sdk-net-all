using System.Xml.Serialization;
using Aop.Api;

public class DeductionPlanQueryDTO
{
    /// <summary>
    /// �û�ǩԼ�ɹ��Ķ�����
    /// </summary>
    [XmlElement("subscriptionNo")]
    public string SubscriptionNo { get; set; }

    /// <summary>
    /// �ƻ��ۿ�����
    /// </summary>
    [XmlElement("deductionDate")]
    public string DeductionDate { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    [XmlElement("period")]
    public string Period { get; set; }

    /// <summary>
    /// �ۿ���
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// ����״̬
    /// ����ͣ PAUSED��
    /// �µ��� ORDERING,
    /// �µ��ɹ� ORDERED��
    /// ֧���ɹ� PAID��
    /// �ۿ�ʧ�� PAY_FAILED,
    /// ��ȫ���˿� REFUNDED,
    /// δ���ɶ��� UNCREATED,
    /// ��ȡ�� CANCEL
    /// </summary>
    [XmlElement("status")]
    public string Status { get; set; }

    /// <summary>
    /// �׶���
    /// ��װ/���Ͷ�������ʹ��
    /// </summary>
    [XmlElement("stageName")]
    public string StageName { get; set; }

    /// <summary>
    /// ������ʱ����
    /// </summary>
    [XmlElement("verificationOverdueDays")]
    public string VerificationOverdueDays { get; set; }

    /// <summary>
    /// ��������
    /// �����ڿۿ: NORMAL
    /// �Ż�׷�ص�: DISCOUNT
    /// ΥԼ����DEFAULT
    /// </summary>
    [XmlElement("orderType")]
    public string OrderType { get; set; }

}
