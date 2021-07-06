using DotNEToolkit;
using RPAStudio.DataAccess;
using RPAStudio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPAStudio
{
    public class RPAStudioContext : SingletonObject<RPAStudioContext>
    {
        public IRPAClient Client { get; private set; }

        public ProjectListVM ProjectList { get; private set; }

        public int Initialize() 
        {
            this.Client = new LocalRPAClient();

            this.ProjectList = new ProjectListVM();

            return DotNETCode.SUCCESS;
        }
    }
}
