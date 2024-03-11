using System.Xml.Serialization;
using Aop.Api;

public class OrderSettleSyncDTO
{
    /// <summary>
    /// ����Ľ�� ��λ��Ԫ
    /// </summary>
    [XmlElement("amount")]
    public string Amount { get; set; }

    /// <summary>
    /// ����ʱ��	yyyy-MM-dd HH:mm:ss
    /// </summary>
    [XmlElement("settleTime")]
    public string SettleTime { get; set; }

    /// <summary>
    /// ���˱���	�����λС����
    /// ʾ��ֵ: 6.25
    /// </summary>
    [XmlElement("rate")]
    public string Rate { get; set; }

    /// <summary>
    /// �����տ�˻�	
    /// ƽ̨�̻����ˣ�ƽ̨�̻���PID
    /// �Զ����˻���֧������¼�˺�
    /// </summary>
    [XmlElement("transIn")]
    public string TransIn { get; set; }

    /// <summary>
    /// ����ʧ��ԭ��
    /// </summary>
    [XmlElement("failReason")]
    public string FailReason { get; set; }

    /// <summary>
    /// ����״̬ 
    /// ������ WAIT_SETTLE
    /// ������ SETTLING
    /// ���˳ɹ� SUCCESS
    /// ����ʧ�� FAIL
    /// </summary>
    [XmlElement("status")]
    public string Status { get; set; }



}
