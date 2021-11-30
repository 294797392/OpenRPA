using DotNEToolkit.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    /// <summary>
    /// 定义一个工作流的元数据
    /// </summary>
    public class WorkflowMetadata : ModelBase
    {
        /// <summary>
        /// 该工作流所属的分组ID
        /// </summary>
        [JsonProperty("groupId")]
        public string GroupID { get; set; }

        /// <summary>
        /// 工作流的入口类名
        /// </summary>
        [JsonProperty("className")]
        public string ClassName { get; set; }

        /// <summary>
        /// 工作流的所有输入参数
        /// </summary>
        [JsonProperty("input")]
        public List<InputOptions> InputOptions { get; private set; }
    }
}
