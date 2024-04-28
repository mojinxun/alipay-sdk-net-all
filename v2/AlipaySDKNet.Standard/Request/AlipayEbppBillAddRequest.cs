using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.bill.add
    /// </summary>
    public class AlipayEbppBillAddRequest : IAopRequest<AlipayEbppBillAddResponse>
    {
        /// <summary>
        /// 外部订单号
        /// </summary>
        public string BankBillNo { get; set; }

        /// <summary>
        /// 账单的账期，格式为 yyyyMMdd。例如：202012表示2020年12月的账单。
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝订单类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 拥有该账单的用户姓名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 缴费金额。用户支付的总金额。单位为 元（人民币）。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 账单的服务费。
        /// </summary>
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 例如：WATER表示JF下面的水费。
        /// </summary>
        public string SubOrderType { get; set; }

        /// <summary>
        /// 交通违章地点，sub_order_type=TRAFFIC时填写。
        /// </summary>
        public string TrafficLocation { get; set; }

        /// <summary>
        /// 违章行为，sub_order_type=TRAFFIC时填写。
        /// </summary>
        public string TrafficRegulations { get; set; }

        #region IAopRequest Members
        private bool  needEncrypt=false;
        private string apiVersion = "1.0";
	    private string terminalType;
	    private string terminalInfo;
        private string prodCode;
	    private string notifyUrl;
        private string returnUrl;
	    private AopObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.ebpp.bill.add";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public void PutOtherTextParam(string key, string value) 
        {
            if(this.udfParams == null) 
            {
                this.udfParams = new Dictionary<string, string>();
            }
            this.udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("bank_bill_no", this.BankBillNo);
            parameters.Add("bill_date", this.BillDate);
            parameters.Add("bill_key", this.BillKey);
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("extend_field", this.ExtendField);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("owner_name", this.OwnerName);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("service_amount", this.ServiceAmount);
            parameters.Add("sub_order_type", this.SubOrderType);
            parameters.Add("traffic_location", this.TrafficLocation);
            parameters.Add("traffic_regulations", this.TrafficRegulations);
            if(udfParams != null) 
            {
                parameters.AddAll(this.udfParams);
            }
            return parameters;
        }

		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
