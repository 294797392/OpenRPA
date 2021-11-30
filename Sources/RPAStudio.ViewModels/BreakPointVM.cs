using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    public class BreakPointVM : ItemViewModel
    {
        private string workflowID;
        private int ordinal;

        /// <summary>
        /// 断点所对应的工作流ID
        /// </summary>
        public string WorkflowID
        {
            get { return this.workflowID; }
            set
            {
                this.workflowID = value;
                this.NotifyPropertyChanged("WorkflowID");
            }
        }

        /// <summary>
        /// 当前工作流的序号
        /// </summary>
        public int Ordinal
        {
            get { return this.ordinal; }
            set 
            {
                this.ordinal = value;
                this.NotifyPropertyChanged("Ordinal");
            }
        }

        public BreakPointVM(Workflow flow)
        {
            this.WorkflowID = flow.ID;
            this.Ordinal = flow.Ordinal;
        }
    }
}

