using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.agent.offlinepayment.sign
    /// </summary>
    public class AlipayOpenAgentOfflinepaymentSignRequest : IAopUploadRequest<AlipayOpenAgentOfflinepaymentSignResponse>
    {
        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.agent.create接口进行创建。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填
        /// </summary>
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码。若填写，请与以下营业执照图片、期限、一起提供。
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 送货地址
        /// </summary>
        public SignAddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// 所属MCCCode，可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“经营类目编码”
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 服务费率（%），0.38~3之间，精确到0.01
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        public SignAddressInfo ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺内景照片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，需要包括招牌信息。最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“需要的特殊资质证书”，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.agent.offlinepayment.sign";
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
            parameters.Add("batch_no", this.BatchNo);
            parameters.Add("business_license_mobile", this.BusinessLicenseMobile);
            parameters.Add("business_license_no", this.BusinessLicenseNo);
            parameters.Add("date_limitation", this.DateLimitation);
            parameters.Add("delivery_address", this.DeliveryAddress);
            parameters.Add("long_term", this.LongTerm);
            parameters.Add("mcc_code", this.MccCode);
            parameters.Add("rate", this.Rate);
            parameters.Add("shop_address", this.ShopAddress);
            parameters.Add("shop_name", this.ShopName);
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

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("business_license_pic", this.BusinessLicensePic);
            parameters.Add("shop_scene_pic", this.ShopScenePic);
            parameters.Add("shop_sign_board_pic", this.ShopSignBoardPic);
            parameters.Add("special_license_pic", this.SpecialLicensePic);
            return parameters;
        }

        #endregion
    }
}
