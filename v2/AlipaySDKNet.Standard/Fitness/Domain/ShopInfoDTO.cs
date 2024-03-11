using System.Xml.Serialization;
using Aop.Api;

public class ShopInfoDTO
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("serialVersionUID")]
    public long SerialVersionUID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("distance")]
    public int Distance { get; set; }

    /// <summary>
    /// γ��
    /// </summary>
    [XmlElement("latitude")]
    public string Latitude { get; set; }

    /// <summary>
    /// �ŵ�����
    /// </summary>
    [XmlElement("shopName")]
    public string ShopName { get; set; }

    /// <summary>
    /// �����ŵ�ID
    /// </summary>
    [XmlElement("shopId")]
    public string ShopId { get; set; }

    /// <summary>
    /// �ŵ��ַ
    /// </summary>
    [XmlElement("shopAddress")]
    public string ShopAddress { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    [XmlElement("longitude")]
    public string Longitude { get; set; }
}
