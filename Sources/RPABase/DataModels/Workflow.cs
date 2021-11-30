using DotNEToolkit.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    /// <summary>
    /// 表示一个工作流
    /// </summary>
    public class Workflow : ModelBase
    {
        /// <summary>
        /// 该工作流的编号
        /// </summary>
        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        /// <summary>
        /// 元数据ID
        /// </summary>
        [JsonProperty("metadataID")]
        public string MetadataID { get; set; }

        /// <summary>
        /// 用户配置好了的输入参数
        /// </summary>
        [JsonProperty("input")]
        public Dictionary<string, object> Input { get; private set; }

        public Workflow()
        {
            this.Input = new Dictionary<string, object>();
        }
    }
}