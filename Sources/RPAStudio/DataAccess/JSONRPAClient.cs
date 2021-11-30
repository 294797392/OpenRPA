using DotNEToolkit;
using Newtonsoft.Json;
using RPABase;
using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPAStudio.DataAccess
{
    /// <summary>
    /// 访问JSON文件里的数据
    /// </summary>
    public class JSONRPAClient : IRPAClient
    {
        #region 实例变量

        private JSONDatabaseInstance db;

        #endregion

        #region IRPAClient

        public int Initialize()
        {
            string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsondb");
            this.db = JSONDatabaseInstance.Create(baseDir);
            return ResponseCode.SUCCESS;
        }

        public void Release()
        { }

        public int DeleteProject(string id)
        {
            this.db.Delete<Project>(v => v.ID == id);
            return ResponseCode.SUCCESS;
        }

        public int InsertProject(Project project)
        {
            this.db.Insert<Project>(project);
            return ResponseCode.SUCCESS;
        }

        public IEnumerable<Project> QueryAllProjects()
        {
            return this.db.SelectAll<Project>();
        }

        public int UpdateProject(Project project)
        {
            return this.db.Update<Project>(v => v.ID == project.ID, project);
        }

        public IEnumerable<Group> QueryGroups(string parentID)
        {
            return this.db.SelectAll<Group>(v => v.ParentID == parentID);
        }

        #endregion

        #region 预定义工作流管理

        public IEnumerable<WorkflowMetadata> QueryWorkflowMetadata(string groupID)
        {
            return this.db.SelectAll<WorkflowMetadata>(v => v.GroupID == groupID);
        }

        #endregion
    }
}
