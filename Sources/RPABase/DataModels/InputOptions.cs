using DotNEToolkit.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    /// <summary>
    /// 描述工作流的一个输入参数
    /// </summary>
    public class InputOptions : OptionBase
    {
        /// <summary>
        /// 输入参数的类型
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 该选项下的子选项
        /// </summary>
        [JsonProperty("child")]
        public List<InputOptions> Children { get; set; }
    }
}
