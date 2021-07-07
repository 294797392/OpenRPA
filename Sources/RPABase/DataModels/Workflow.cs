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
        /// 该工作流所属的分组ID
        /// </summary>
        [JsonProperty("groupId")]
        public string GroupID { get; set; }
    }
}
