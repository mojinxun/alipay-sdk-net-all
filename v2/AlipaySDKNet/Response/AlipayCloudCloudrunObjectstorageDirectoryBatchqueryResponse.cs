using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageDirectoryBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageDirectoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 文件夹列表
        /// </summary>
        [XmlArray("directory_list")]
        [XmlArrayItem("oss_directory_detail")]
        public List<OssDirectoryDetail> DirectoryList { get; set; }

        /// <summary>
        /// 分页游标下一页标记
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
