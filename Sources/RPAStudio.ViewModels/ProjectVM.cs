using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.Business.Controls;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    public class ProjectVM : ItemViewModel
    {
        #region 实例变量

        private DateTime lastUpdateTime;

        #endregion

        #region 属性

        [DataGridColumn("名字")]
        public override string Name { get => base.Name; set => base.Name = value; }

        /// <summary>
        /// 最后一次更新时间
        /// </summary>
        [DataGridColumn("最后更新时间")]
        public DateTime LastUpdateTime
        {
            get { return this.lastUpdateTime; }
            set
            {
                this.lastUpdateTime = value;
                this.NotifyPropertyChanged("LastUpdateTime");
            }
        }

        #endregion
    }
}
