using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.sign.add
    /// </summary>
    public class AlipayEbppPdeductSignAddRequest : IAopRequest<AlipayEbppPdeductSignAddResponse>
    {
        /// <summary>
        /// 机构签约代扣来源渠道  PUBLICPLATFORM：服务窗
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 从服务窗发起则为publicId的值
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。 *IND：保险缴费。
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 代扣产品码。 缴费业务场景中，传入INST_DIRECT_DEDUCT。保险业务场景中, 传入INSURANCE_MERCHANT_DEDUCT。
        /// </summary>
        public string DeductProdCode { get; set; }

        /// <summary>
        /// 签约类型可为空
        /// </summary>
        public string DeductType { get; set; }

        /// <summary>
        /// 外部用户实名认证相关信息, 用于做签约时的实名校验。   注：     name: 姓名  cert_type: 身份证：IDENTITY_CARD、护照：PASSPORT、军官证：OFFICER_CARD、士兵证：SOLDIER_CARD、户口本：HOKOU等  cert_no: 证件号码  need_check_info取值 T/F，只有为T时才做强制校验。  mobile:手机号，目前暂不使用此字段做校验  min_age: 允许的最小买家年龄,min_age为整数，必须大于等于0.
        /// </summary>
        public string ExtUserInfo { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置，可为空
        /// </summary>
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 外部产生的协议ID
        /// </summary>
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 户名，户主真实姓名
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// 支付工具设置，目前可为空
        /// </summary>
        public string PayConfig { get; set; }

        /// <summary>
        /// 支付密码鉴权token，需要用户首先处于登陆态，然后访问https://ebppprod.alipay.com/deduct/enterMobileicPayPassword.htm?cb=自己指定的回跳连接地址，访问页面后会进到独立密码校验页，用户输入密码校验成功后，会生成token回调到指定的回跳地址，如果设置cb=www.alipay.com则最后回调的内容是www.alipay.com?token=312314ADFDSFAS，然后签约时直接取得地址后token的值即可。
        /// </summary>
        public string PayPasswordToken { get; set; }

        /// <summary>
        /// 商户id，商户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 签约到期时间。空表示无限期，一期固定传空。
        /// </summary>
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 业务子类型。业务子类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *TRAFFIC：缴交通罚款。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 *CAR：车险。 *LIFE：寿险。 *HEALTH：健康险。 例如：WATER表示JF下面的水费。
        /// </summary>
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.ebpp.pdeduct.sign.add";
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
            parameters.Add("agent_channel", this.AgentChannel);
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("bill_key", this.BillKey);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("deduct_prod_code", this.DeductProdCode);
            parameters.Add("deduct_type", this.DeductType);
            parameters.Add("ext_user_info", this.ExtUserInfo);
            parameters.Add("extend_field", this.ExtendField);
            parameters.Add("notify_config", this.NotifyConfig);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("out_agreement_id", this.OutAgreementId);
            parameters.Add("owner_name", this.OwnerName);
            parameters.Add("pay_config", this.PayConfig);
            parameters.Add("pay_password_token", this.PayPasswordToken);
            parameters.Add("pid", this.Pid);
            parameters.Add("sign_expire_date", this.SignExpireDate);
            parameters.Add("sub_biz_type", this.SubBizType);
            parameters.Add("user_id", this.UserId);
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
