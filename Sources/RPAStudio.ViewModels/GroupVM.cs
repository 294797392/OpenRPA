using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    /// <summary>
    /// 流程分组ViewModel
    /// </summary>
    public class GroupVM : AbstractNodeVM
    {
        public GroupVM(TreeViewModelContext context, AbstractNodeVM parent = null) : base(context, parent)
        {

        }
    }
}
