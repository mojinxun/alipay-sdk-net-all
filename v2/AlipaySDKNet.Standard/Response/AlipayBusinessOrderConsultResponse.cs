using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBusinessOrderConsultResponse.
    /// </summary>
    public class AlipayBusinessOrderConsultResponse : AopResponse
    {
        /// <summary>
        /// 用户详细信息列表，对于会员互通场景，可一次性返回商户、支付宝、平台等用户信息。
        /// </summary>
        [XmlElement("buyer_info")]
        public UserDetailInfo BuyerInfo { get; set; }

        /// <summary>
        /// 订单咨询返回的营销信息。voucher_list中的description、valid_time 以及expired_time信息的返回与否与券本身是否有该信息有关，若券本身不包含该信息则不返回
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("voucher_info_detail")]
        public List<VoucherInfoDetail> VoucherList { get; set; }
    }
}
