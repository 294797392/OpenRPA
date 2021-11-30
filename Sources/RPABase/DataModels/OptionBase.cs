using DotNEToolkit.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    public abstract class OptionBase : ModelBase
    {
        /// <summary>
        /// 该选项的键名字
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该选项的值
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
