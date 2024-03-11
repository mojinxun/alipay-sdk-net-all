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
    /// 纬度
    /// </summary>
    [XmlElement("latitude")]
    public string Latitude { get; set; }

    /// <summary>
    /// 门店名称
    /// </summary>
    [XmlElement("shopName")]
    public string ShopName { get; set; }

    /// <summary>
    /// 蚂蚁门店ID
    /// </summary>
    [XmlElement("shopId")]
    public string ShopId { get; set; }

    /// <summary>
    /// 门店地址
    /// </summary>
    [XmlElement("shopAddress")]
    public string ShopAddress { get; set; }

    /// <summary>
    /// 经度
    /// </summary>
    [XmlElement("longitude")]
    public string Longitude { get; set; }
}
