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
        /// 根据父节点查询子节点分组列表
        /// </summary>
        /// <param name="parentID"></param>
        /// <returns></returns>
        IEnumerable<Group> QueryGroups(string parentID);

        #endregion
    }
}
