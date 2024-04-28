using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneRatingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneRatingQueryModel : AopObject
    {
        /// <summary>
        /// 芝麻企业信用评估订单号，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.credit.ep.scene.rating.initialize">zhima.credit.ep.scene.rating.initialize</a>(芝麻企业信用信用评估初始化)接口进行信用评估初始化后获取。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
