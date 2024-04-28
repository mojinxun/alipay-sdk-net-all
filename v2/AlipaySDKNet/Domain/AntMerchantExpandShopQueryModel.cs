using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopQueryModel : AopObject
    {
        /// <summary>
        /// 行政区划版本，当前可传空值(取默认版本)、2022Q2、UPTODATE(取最新版本)，其中空值默认为：2020Q1版本（ address_version=''或null），想要查看版本是2022年2季度版本则传入:(address_version='2022Q2')，想要获取最新版本则传入:(address_version ='UPTODATE')
        /// </summary>
        [XmlElement("address_version")]
        public string AddressVersion { get; set; }

        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 门店不置信时，是否需要返回shop_recommend_info
        /// </summary>
        [XmlElement("need_recommend")]
        public string NeedRecommend { get; set; }

        /// <summary>
        /// 蚂蚁店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
