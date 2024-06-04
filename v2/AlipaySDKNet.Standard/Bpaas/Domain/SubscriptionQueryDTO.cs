using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api;

public class SubscriptionQueryDTO
{
    /// <summary>
    /// �ۿ�ƻ�
    /// </summary>
    [XmlArray("deductionPlanList")]
    [XmlArrayItem("deductionPlanList")]
    public List<DeductionPlanQueryDTO> DeductionPlanList { get; set; }

    /// <summary>
    /// ����״̬
    /// ���� NORMAL��
    /// ����ͣ PAUSED��
    /// �ѽ�Լ SURRENDER��
    /// ����� END
    /// </summary>
    [XmlElement("subscriptionStatus")]
    public string SubscriptionStatus { get; set; }

    /// <summary>
    /// �������
    /// </summary>
    [XmlElement("subscriptionNo")]
    public string SubscriptionNo { get; set; }

}
