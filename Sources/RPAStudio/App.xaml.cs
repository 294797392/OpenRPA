using DotNEToolkit;
using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace RPAStudio
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            RPAStudioContext.Context.Initialize();
            Project p = JSONHelper.ParseFile<Project>("project.demo.json");
            RPAStudioContext.Context.OpenProject(p);
        }
    }
}
