using DotNEToolkit;
using Newtonsoft.Json;
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
        public int DeleteProject(string id)
        {
            return JSONDatabase.Delete<Project>(v => v.ID == id);
        }

        public int InsertProject(Project project)
        {
            return JSONDatabase.Insert<Project>(project);
        }

        public IEnumerable<Project> QueryAllProjects()
        {
            return JSONDatabase.SelectAll<Project>();
        }

        public int UpdateProject(Project project)
        {
            return JSONDatabase.Update<Project>(v => v.ID == project.ID, project);
        }

        public IEnumerable<Group> QueryGroups(string parentID)
        {
            return JSONDatabase.SelectAll<Group>(v => v.ParentID == parentID);
        }

        public IEnumerable<Workflow> QueryWorkflows(string groupID)
        {
            return JSONDatabase.SelectAll<Workflow>(v => v.GroupID == groupID);
        }
    }
}
