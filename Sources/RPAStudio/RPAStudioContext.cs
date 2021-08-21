using DotNEToolkit;
using RPABase.DataModels;
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

        public BindableCollection<ProjectVM> ProjectList { get; private set; }

        /// <summary>
        /// 工作流树形列表ViewModel
        /// </summary>
        public WorkflowTreeVM WFTreeVM { get; private set; }

        /// <summary>
        /// 工作流树形列表上下文信息
        /// </summary>
        public TreeViewModelContext WFTreeContext { get; private set; }

        public override int Initialize() 
        {
            base.Initialize();

            this.Client = new JSONRPAClient();

            this.ProjectList = new BindableCollection<ProjectVM>();
            this.WFTreeVM = new WorkflowTreeVM();
            this.WFTreeContext = new TreeViewModelContext();

            this.InitializeGroupListVM();
            this.InitializeProjectList();

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

        private void InitializeProjectList()
        {
            this.ProjectList.Clear();

            IEnumerable<Project> projectList = this.Client.QueryAllProjects();

            foreach (Project project in projectList)
            {
                ProjectVM pvm = new ProjectVM()
                {
                    ID = project.ID,
                    Name = project.Name,
                    URI = project.URI,
                    Description = project.Description,
                    Creator = project.Creator,
                    CreationTime = project.CreationTime
                };

                this.ProjectList.Add(pvm);
            }
        }
    }
}
