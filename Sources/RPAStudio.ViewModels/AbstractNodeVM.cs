using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    public abstract class AbstractNodeVM : TreeNodeViewModel
    {
        public AbstractNodeVM(TreeViewModelContext context, object data = null) :
            base(context, data)
        {

        }

        public AbstractNodeVM(TreeNodeViewModel parent, object data = null) :
            base(parent, data)
        {

        }
    }
}
