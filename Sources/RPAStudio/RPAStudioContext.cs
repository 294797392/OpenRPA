using DotNEToolkit;
using RPABase;
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
        #region 类变量

        private static log4net.ILog logger = log4net.LogManager.GetLogger("RPAStudioContext");

        #endregion

        #region 属性

        public IRPAClient Client { get; private set; }

        public BindableCollection<ProjectVM> ProjectList { get; private set; }

        /// <summary>
        /// 工作流树形列表ViewModel
        /// </summary>
        public WorkflowTreeVM MetadataTree { get; private set; }

        /// <summary>
        /// 当前打开的项目
        /// </summary>
        public OpenedProjectVM OpenedProject { get; private set; }

        #endregion

        #region 公开接口

        public override int Initialize()
        {
            base.Initialize();

            this.Client = new JSONRPAClient();
            this.Client.Initialize();

            this.ProjectList = new BindableCollection<ProjectVM>();
            this.MetadataTree = new WorkflowTreeVM();

            this.OpenedProject = new OpenedProjectVM();

            this.InitializeMetadataTree();
            //this.InitializeProjectList();

            return ResponseCode.SUCCESS;
        }

        public int OpenProject(Project project)
        {
            foreach (Workflow workflow in project.Workflows)
            {
                WorkflowVM wvm = this.CreateWorkflowViewModel(workflow);
                this.OpenedProject.WorkflowList.Add(wvm);

                BreakPointVM point = new BreakPointVM(workflow);
                this.OpenedProject.BreakPointList.Add(point);
            }

            this.OpenedProject.Project = project;

            this.OpenedProject.IsOpened = true;

            return ResponseCode.SUCCESS;
        }

        /// <summary>
        /// 关闭当前已打开的项目
        /// </summary>
        public void CloseProject()
        {
            this.OpenedProject.WorkflowList.Clear();
            this.OpenedProject.BreakPointList.Clear();

            this.OpenedProject.Project = null;

            this.OpenedProject.IsOpened = false;
        }

        #endregion

        #region 实例方法

        /// <summary>
        /// 初始化流程分组ViewModel（加载GroupListVM的数据）
        /// </summary>
        private void InitializeMetadataTree()
        {
            GroupVM root = new GroupVM(this.MetadataTree.Context) { ID = string.Empty, Name = "根节点" };
            this.MetadataTree.AddRootNode(root);
            this.LoadGroupList(root);
        }

        private void LoadGroupList(GroupVM parentGroup)
        {
            // 加载工作流分组列表
            IEnumerable<Group> childGroups = this.Client.QueryGroups(parentGroup.ID.ToString());
            foreach (Group childGroup in childGroups)
            {
                GroupVM vm = new GroupVM(parentGroup)
                {
                    ID = childGroup.ID,
                    Name = childGroup.Name,
                    Description = childGroup.Description,
                };
                parentGroup.AddChildNode(vm);

                // 加载该分组下的工作流
                this.LoadMetadataList(vm);

                // 加载该分组下的子分组
                this.LoadGroupList(vm);
            }
        }

        private void LoadMetadataList(GroupVM group)
        {
            IEnumerable<WorkflowMetadata> workflows = this.Client.QueryWorkflowMetadata(group.ID.ToString());

            foreach (WorkflowMetadata workflow in workflows)
            {
                WorkflowTreeItemVM vm = new WorkflowTreeItemVM(group, workflow)
                {
                    ID = workflow.ID,
                    Name = workflow.Name,
                    Description = workflow.Description,
                    ClassName = workflow.ClassName
                };
                group.AddChildNode(vm);
            }
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
                    Description = project.Description,
                    Creator = project.Creator,
                    CreationTime = project.CreationTime
                };

                this.ProjectList.Add(pvm);
            }
        }

        private WorkflowVM CreateWorkflowViewModel(Workflow workflow)
        {
            TreeNodeViewModel node;
            if (!this.MetadataTree.TryGetNode(workflow.MetadataID, out node))
            {
                logger.ErrorFormat("查找WorkflowMetadata失败, 不存在MetadataID, {0}", workflow.MetadataID);
                return null;
            }

            WorkflowMetadata metadata = node.Data as WorkflowMetadata;
            try
            {
                return ConfigFactory<WorkflowVM>.CreateInstance(metadata.ClassName, workflow, metadata);
            }
            catch (Exception ex)
            {
                logger.Error("创建WorkflowVM实例异常", ex);
                return null;
            }
        }

        #endregion
    }
}
