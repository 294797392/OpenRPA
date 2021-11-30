using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPABase.DataModels
{
    /// <summary>
    /// 描述工作流的选项类型
    /// </summary>
    public enum OptionTypes
    {
        /// <summary>
        /// 该选项是一个文本值
        /// </summary>
        Text = 1,

        /// <summary>
        /// 该选项是一个选择器
        /// </summary>
        Selector = 2,

        /// <summary>
        /// 该选项是一个开关
        /// </summary>
        Switches = 3
    }
}
