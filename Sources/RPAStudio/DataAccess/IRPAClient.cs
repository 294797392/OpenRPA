using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPAStudio.DataAccess
{
    public interface IRPAClient
    {
        #region 项目列表

        IEnumerable<Project> QueryAllProjects();

        int InsertProject(Project project);

        int DeleteProject(string id);

        int UpdateProject(Project project);

        #endregion

        #region 分组管理

        /// <summary>
        /// 根据父分组的ID查询子分组列表
        /// </summary>
        /// <param name="parentID">父分组的ID</param>
        /// <returns></returns>
        IEnumerable<Group> QueryGroups(string parentID);

        #endregion

        #region 工作流管理

        /// <summary>
        /// 根据分组ID查询该分组下的工作流列表
        /// </summary>
        /// <param name="groupID">要查询的分组ID</param>
        /// <returns></returns>
        IEnumerable<Workflow> QueryWorkflows(string groupID);

        #endregion
    }
}
