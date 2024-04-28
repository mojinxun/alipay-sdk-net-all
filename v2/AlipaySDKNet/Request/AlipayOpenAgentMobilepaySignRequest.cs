using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.agent.mobilepay.sign
    /// </summary>
    public class AlipayOpenAgentMobilepaySignRequest : IAopUploadRequest<AlipayOpenAgentMobilepaySignResponse>
    {
        /// <summary>
        /// APP授权函图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppAuthPic { get; set; }

        /// <summary>
        /// APP demo，格式为.apk；或者应用说明文档, 格式为.doc .docx .pdf格式
        /// </summary>
        public FileItem AppDemo { get; set; }

        /// <summary>
        /// 应用首页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppHomeScreenshot { get; set; }

        /// <summary>
        /// 商品或服务页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppItemScreenshot { get; set; }

        /// <summary>
        /// 应用在哪些市场上架，枚举值为：苹果,应用宝,华为,360,小米,豌豆荚,其他
        /// </summary>
        public List<string> AppMarket { get; set; }

        /// <summary>
        /// 商户的APP应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 应用内支付页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppPayScreenshot { get; set; }

        /// <summary>
        /// 应用上架状态，枚举值为 已上线，未上线
        /// </summary>
        public string AppStatus { get; set; }

        /// <summary>
        /// 可以登录该应用的测试账户
        /// </summary>
        public string AppTestAccount { get; set; }

        /// <summary>
        /// 可以登录此应用的账户的密码。对应app_test_account的登录密码
        /// </summary>
        public string AppTestAccountPassword { get; set; }

        /// <summary>
        /// 应用类型，枚举值为：IOS，安卓
        /// </summary>
        public List<string> AppType { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.isv.agent.create接口进行创建。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照法人手机号码
        /// </summary>
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码。
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 应用下载链接
        /// </summary>
        public string DownloadLink { get; set; }

        /// <summary>
        /// 应用首页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem HomeScreenshot { get; set; }

        /// <summary>
        /// 应用内截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem InAppScreenshot { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// 所属MCCCode，详情可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“经营类目编码”
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 传参：APP，代表设备类型是APP
        /// </summary>
        public string MobileType { get; set; }

        /// <summary>
        /// 应用内支付页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem PayScreenshot { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“需要的特殊资质证书”，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

        /// <summary>
        /// 传参：mobile，代表交易场景是移动设备
        /// </summary>
        public string TradeScene { get; set; }

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
            return "alipay.open.agent.mobilepay.sign";
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
            parameters.Add("app_market", this.AppMarket);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_status", this.AppStatus);
            parameters.Add("app_test_account", this.AppTestAccount);
            parameters.Add("app_test_account_password", this.AppTestAccountPassword);
            parameters.Add("app_type", this.AppType);
            parameters.Add("batch_no", this.BatchNo);
            parameters.Add("business_license_mobile", this.BusinessLicenseMobile);
            parameters.Add("business_license_no", this.BusinessLicenseNo);
            parameters.Add("date_limitation", this.DateLimitation);
            parameters.Add("download_link", this.DownloadLink);
            parameters.Add("long_term", this.LongTerm);
            parameters.Add("mcc_code", this.MccCode);
            parameters.Add("mobile_type", this.MobileType);
            parameters.Add("trade_scene", this.TradeScene);
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
            parameters.Add("app_auth_pic", this.AppAuthPic);
            parameters.Add("app_demo", this.AppDemo);
            parameters.Add("app_home_screenshot", this.AppHomeScreenshot);
            parameters.Add("app_item_screenshot", this.AppItemScreenshot);
            parameters.Add("app_pay_screenshot", this.AppPayScreenshot);
            parameters.Add("business_license_auth_pic", this.BusinessLicenseAuthPic);
            parameters.Add("business_license_pic", this.BusinessLicensePic);
            parameters.Add("home_screenshot", this.HomeScreenshot);
            parameters.Add("in_app_screenshot", this.InAppScreenshot);
            parameters.Add("pay_screenshot", this.PayScreenshot);
            parameters.Add("special_license_pic", this.SpecialLicensePic);
            return parameters;
        }

        #endregion
    }
}
