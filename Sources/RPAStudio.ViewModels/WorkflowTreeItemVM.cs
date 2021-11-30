using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    /// <summary>
    /// 流程ViewModel
    /// </summary>
    public class WorkflowTreeItemVM : AbstractNodeVM
    {
        #region 实例变量

        private string className;

        #endregion

        #region 构造方法

        public WorkflowTreeItemVM(TreeViewModelContext context, object data = null) :
            base(context, data)
        {
        }

        public WorkflowTreeItemVM(TreeNodeViewModel parent, object data = null) :
            base(parent, data)
        {
        }

        #endregion

        #region 属性

        public string ClassName
        {
            get { return this.className; }
            set
            {
                this.className = value;
                this.NotifyPropertyChanged("ClassName");
            }
        }

        #endregion
    }
}