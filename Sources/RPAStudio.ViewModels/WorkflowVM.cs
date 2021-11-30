using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    /// <summary>
    /// 工作流ViewModel
    /// </summary>
    public abstract class WorkflowVM : ItemViewModel
    {
        #region 实例变量

        private int ordinal;
        private object summary;

        #endregion

        #region 属性

        /// <summary>
        /// 工作流编号
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

        public object Summary
        {
            get { return this.summary; }
            set
            {
                this.summary = value;
                this.NotifyPropertyChanged("Summary");
            }
        }

        /// <summary>
        /// 所有的输入参数列表
        /// </summary>
        public BindableCollection<OptionVM> OptionList { get; private set; }

        #endregion

        #region 构造方法

        public WorkflowVM(Workflow workflow, WorkflowMetadata metadata)
        {
            this.ID = workflow.ID;
            this.Name = workflow.Name;
            this.Description = workflow.Description;
            this.Ordinal = workflow.Ordinal;
            this.OptionList = new BindableCollection<OptionVM>();
            this.InitializeOptions(workflow, metadata);
        }

        #endregion

        #region 实例方法

        public void InitializeOptions(Workflow workflow, WorkflowMetadata metadata)
        {
            foreach (InputOptions option in metadata.InputOptions)
            {
                OptionVM ovm = new OptionVM()
                {
                    ID = option.ID,
                    Name = option.Name,
                    Description = option.Description,
                    Key = option.Key,
                    Type = (OptionTypes)option.Type
                };
                this.OptionList.Add(ovm);
            }
        }

        #endregion
    }
}


