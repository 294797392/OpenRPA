using DotNEToolkit;
using RPAStudio.DataAccess;
using RPAStudio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio
{
    /// <summary>
    /// 存储整个应用程序的数据
    /// 整个应用程序中只有一个实例
    /// </summary>
    public class RPAStudioContext : SingletonObject<RPAStudioContext>
    {
        public IRPAClient Client { get; private set; }

        public ProjectListVM ProjectList { get; private set; }

        /// <summary>
        /// 工作流树形列表ViewModel
        /// </summary>
        public WorkflowTreeVM WFTreeVM { get; private set; }

        /// <summary>
        /// 工作流树形列表上下文信息
        /// </summary>
        public TreeViewModelContext WFTreeContext { get; private set; }

        public int Initialize() 
        {
            this.Client = new JSONRPAClient();

            this.ProjectList = new ProjectListVM();
            this.WFTreeVM = new WorkflowTreeVM();
            this.WFTreeContext = new TreeViewModelContext();

            this.InitializeGroupListVM();

            return DotNETCode.SUCCESS;
        }

        /// <summary>
        /// 初始化流程分组ViewModel（加载GroupListVM的数据）
        /// </summary>
        private void InitializeGroupListVM()
        {
            GroupVM root = new GroupVM(this.WFTreeContext) { Name = Guid.NewGuid().ToString() };
            this.WFTreeVM.Roots.Add(root);
        }
    }
}
