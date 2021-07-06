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
    public class WorkflowVM : AbstractNodeVM
    {
        public WorkflowVM(TreeViewModelContext context, AbstractNodeVM parentNode) : base(context, parentNode)
        {
            
        }
    }
}
