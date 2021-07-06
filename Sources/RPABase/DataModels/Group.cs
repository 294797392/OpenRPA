using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    public class Group : ModelBase
    {
        /// <summary>
        /// 父分组ID
        /// </summary>
        public string ParentID { get; set; }
    }
}
