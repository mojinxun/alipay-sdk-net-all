using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MyxiaojinFinanceAtsbudgetBbaremainamountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MyxiaojinFinanceAtsbudgetBbaremainamountQueryModel : AopObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [XmlElement("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }
    }
}
