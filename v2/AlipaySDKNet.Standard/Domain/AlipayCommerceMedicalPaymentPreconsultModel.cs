using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPaymentPreconsultModel : AopObject
    {
        /// <summary>
        /// 定点医药机构所在地标准行政区划编码。可在<a href="http://xzqh.mca.gov.cn/map">民政部全国行政区划信息查询平台</a>查询
        /// </summary>
        [XmlElement("payment_city_code")]
        public string PaymentCityCode { get; set; }
    }
}
