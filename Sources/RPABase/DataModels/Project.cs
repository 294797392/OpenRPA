using DotNEToolkit.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    /// <summary>
    /// 表示一个自动化项目
    /// </summary>
    public class Project : ModelBase
    {
        ///// <summary>
        ///// 项目文件的地址
        ///// </summary>
        //[JsonProperty("uri")]
        //public string URI { get; set; }

        /// <summary>
        /// 该项目下的所有工作流列表
        /// </summary>
        [JsonProperty("workflows")]
        public List<Workflow> Workflows { get; private set; }

        public Project()
        {
            this.Workflows = new List<Workflow>();
        }
    }
}
