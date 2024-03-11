using Aop.Api;
using Aop.Api.Response;
using System.Collections.Generic;

public class ApiFitnessDefaultOrderCancelRequest : IAopRequest<ApiFitnessDefaultOrderCancelResponse>
{
	private bool needEncrypt;
    private string apiVersion = "1.0";
    private string terminalType;
    private string terminalInfo;
    private string prodCode;
    private string notifyUrl;
    private string returnUrl;
    private AopObject bizModel;
    private Dictionary<string, string> udfParams;

    public string BizContent { get; set; }

    public void SetNeedEncrypt(bool needEncrypt) => this.needEncrypt = needEncrypt;

    public bool GetNeedEncrypt() => this.needEncrypt;

    public void SetNotifyUrl(string notifyUrl) => this.notifyUrl = notifyUrl;

    public string GetNotifyUrl() => this.notifyUrl;

    public void SetReturnUrl(string returnUrl) => this.returnUrl = returnUrl;

    public string GetReturnUrl() => this.returnUrl;

    public void SetTerminalType(string terminalType) => this.terminalType = terminalType;

    public string GetTerminalType() => this.terminalType;

    public void SetTerminalInfo(string terminalInfo) => this.terminalInfo = terminalInfo;

    public string GetTerminalInfo() => this.terminalInfo;

    public void SetProdCode(string prodCode) => this.prodCode = prodCode;

    public string GetProdCode() => this.prodCode;

    public string GetApiName() => "api.fitness.defaultOrderCancel";

    public void SetApiVersion(string apiVersion) => this.apiVersion = apiVersion;

    public string GetApiVersion() => this.apiVersion;

    public void PutOtherTextParam(string key, string value)
    {
      if (this.udfParams == null)
        this.udfParams = new Dictionary<string, string>();
      	this.udfParams.Add(key, value);
    }

    public IDictionary<string, string> GetParameters()
    {
      AopDictionary parameters = new AopDictionary();
      parameters.Add("biz_content", this.BizContent);
      parameters.Add("service", this.GetApiName());
      if (this.udfParams != null)
        parameters.AddAll(this.udfParams);
      return (IDictionary<string, string>) parameters;
    }

    public AopObject GetBizModel() => this.bizModel;

    public void SetBizModel(AopObject bizModel) => this.bizModel = bizModel;
}