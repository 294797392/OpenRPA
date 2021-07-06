﻿using DotNEToolkit;
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
        private readonly string ProjectManifestFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProjectManifest.manifest");

        public int DeleteProject(string id)
        {
            return JSONDatabase.Delete<Project>(ProjectManifestFile, v => v.ID == id);
        }

        public int InsertProject(Project project)
        {
            return JSONDatabase.Insert<Project>(ProjectManifestFile, project);
        }

        public IEnumerable<Project> QueryAllProjects()
        {
            return JSONDatabase.SelectAll<Project>(ProjectManifestFile);
        }

        public int UpdateProject(Project project)
        {
            return JSONDatabase.Update<Project>(ProjectManifestFile, v => v.ID == project.ID, project);
        }


        public IEnumerable<Group> QueryGroups(string parentID)
        {
            throw new NotImplementedException();
        }
    }
}