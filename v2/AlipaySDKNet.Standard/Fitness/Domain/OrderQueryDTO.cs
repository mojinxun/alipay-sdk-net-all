using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class OrderQueryDTO
{
    /// <summary>
    /// �������
    /// </summary>
    [XmlElement("orderNo")]
    public string OrderNo { get; set; }

    /// <summary>
    /// �������
    /// </summary>
    [XmlElement("subscriptionNo")]
    public string SubscriptionNo { get; set; }

    /// <summary>
    /// �û�UID
    /// </summary>
    [XmlElement("userId")]
    public string UserId { get; set; }

    /// <summary>
    /// ��Ʒ���
    /// </summary>
    [XmlElement("productNo")]
    public string ProductNo { get; set; }

    /// <summary>
    /// �̻�PID
    /// </summary>
    [XmlElement("merchantPid")]
    public string MerchantPId { get; set; }

    /// <summary>
    /// ����״̬
    /// �µ��� ORDERING��
    /// ���µ� ORDERED��
    /// ֧����PAYING��
    /// ��֧��PAID��
    /// ֧��ʧ��PAY_FAILED��
    /// ��ȡ��CANCEL��
    /// ���˿�REFUNDED��
    /// ����ͣPAUSED��
    /// </summary>
    [XmlElement("orderStatus")]
    public string OrderStatus { get; set; }

    /// <summary>
    /// �µ�ʱ��
    /// </summary>
    [XmlElement("orderDate")]
    public string OrderDate { get; set; }

    /// <summary>
    /// �ƻ��ۿ�ʱ��
    /// yyyy-MM-dd HH:mm:ss
    /// </summary>
    [XmlElement("planDeductionTime")]
    public string PlanDeductionTime { get; set; }

    /// <summary>
    /// ʵ�ʿۿ�ʱ��
    /// yyyy-MM-dd HH:mm:ss
    /// </summary>
    [XmlElement("actualDeductionTime")]
    public string ActualDeductionTime { get; set; }

    /// <summary>
    /// �ۿ����λԪ
    /// </summary>
    [XmlElement("deductionAmount")]
    public string DeductionAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>

    [XmlElement("deductionFailTimes")]
    public int DeductionFailTimes { get; set; }

    /// <summary>
    /// �ۿ�ʧ��ԭ��
    /// </summary>
    [XmlElement("deductionFailReason")]
    public string DeductionFailReason { get; set; }

    /// <summary>
    /// �����ƻ�����
    /// </summary>
    [XmlElement("period")]
    public string Period { get; set; }

    /// <summary>
    /// ������
    /// </summary>
    [XmlElement("verificationCode")]
    public string VerificationCode { get; set; }

    /// <summary>
    /// ������״̬
    /// UNUSE δ���� USED �Ѻ���
    /// </summary>
    [XmlElement("verificationCodeStatus")]
    public string VerificationCodeStatus { get; set; }

    /// <summary>
    /// ����״̬
    /// ������ WAIT_SETTLE
    /// ������ SETTLING
    /// ���˹� SETTLE_SUCCESS
    /// ����ʧ��:SETTLE_FAIL
    /// </summary>
    [XmlElement("orderSettleStatus")]
    public string OrderSettleStatus { get; set; }

    /// <summary>
    /// ���˳ɹ�ʱ��
    /// </summary>
    [XmlElement("settleTime")]
    public string SettleTime { get; set; }

    /// <summary>
    /// ����ʧ�ܴ���
    /// </summary>
    [XmlElement("settleFailTimes")]
    public int SettleFailTimes { get; set; }

    /// <summary>
    /// ����ʧ��ԭ��
    /// </summary>
    [XmlElement("settleFailReason")]
    public string SettleFailReason { get; set; }

    /// <summary>
    /// ������ϸ
    /// </summary>
    [XmlArray("settleDetails")]
    [XmlArrayItem("settleDetails")]
    public List<OrderSettleSyncDTO> SettleDetails { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("stageName")]
    public string StageName { get; set; }

    /// <summary>
    /// �̻��׶�ȷ��
    /// ������װ�ޡ���������
    /// </summary>
    [XmlElement("merchantStageConfirm")]
    public string MerchantStageConfirm { get; set; }

    /// <summary>
    /// ������ʱ����
    /// yyyy-MM-dd HH:mm:ss
    /// ������װ�ޡ���������
    /// </summary>
    [XmlElement("verificationOverdueTime")]
    public string VerificationOverdueTime { get; set; }

    /// <summary>
    /// ֧������
    /// �û�����֧�� APP
    /// ϵͳ�Զ�֧�� AUTO
    /// </summary>
    [XmlElement("payChannel")]
    public string PayChannel { get; set; }

}
