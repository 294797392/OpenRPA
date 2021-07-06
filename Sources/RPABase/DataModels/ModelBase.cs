using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    public class ModelBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creationTime")]
        public DateTime CreationTime { get; set; }
    }
}
