using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingPaymentinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingPaymentinfoSyncModel : AopObject
    {
        /// <summary>
        /// 停车场内缴费后，允许出场的免费时长分钟数
        /// </summary>
        [XmlElement("free_exit_minutes")]
        public string FreeExitMinutes { get; set; }

        /// <summary>
        /// 车牌是否加密，true为加密，false为不加密，默认为false
        /// </summary>
        [XmlElement("is_encrypt_plate_no")]
        public bool IsEncryptPlateNo { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID对应的归属应用appid
        /// </summary>
        [XmlElement("open_appid")]
        public string OpenAppid { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 场内缴费时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制，请保证服务器时间准确，场内缴费不应晚于当前网络时间
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 支付方式 ALIPAY：支付宝支付 CASH：现金 OTHER：其他渠道 FREE：免费
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号（支持加密格式）
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId=2021001102642986&page=pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId=2021001102642986&page=%2Fpages%2Fparking-bill%2Findex
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
