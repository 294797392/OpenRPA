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
        IEnumerable<Project> QueryAllProjects();

        int InsertProject(Project project);

        int DeleteProject(string id);

        int UpdateProject(Project project);
    }
}
