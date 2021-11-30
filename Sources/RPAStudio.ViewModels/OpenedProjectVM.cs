using RPABase;
using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    /// <summary>
    /// 存储当前已经打开了的项目信息
    /// </summary>
    public class OpenedProjectVM : ViewModelBase
    {
        #region 实例变量

        private bool isOpened;

        #endregion

        #region 属性

        /// <summary>
        /// 所有的断点列表
        /// </summary>
        public BreakPointListVM BreakPointList { get; private set; }

        /// <summary>
        /// 项目里的所有的工作流列表
        /// </summary>
        public WorkflowListVM WorkflowList { get; private set; }

        /// <summary>
        /// 是否已经打开了项目
        /// </summary>
        public bool IsOpened
        {
            get { return this.isOpened; }
            set
            {
                this.isOpened = true;
                this.NotifyPropertyChanged("IsOpened");
            }
        }

        /// <summary>
        /// 当前已经打开了的项目
        /// </summary>
        public Project Project { get; set; }

        #endregion

        #region 构造方法

        public OpenedProjectVM()
        {
            this.WorkflowList = new WorkflowListVM();
            this.BreakPointList = new BreakPointListVM();
        }

        #endregion

        #region 公开接口

        #endregion

        #region 实例方法

        #endregion
    }
}
