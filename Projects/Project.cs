using Newtonsoft.Json;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Project
    {
        int id;
        public string Name { get; set; }
        public List<Model> Models;

        public Project()
        {
            Models = new List<Model>();
        }

        //public static List<Project> GetAll()
        //{
        //    var projects = JsonConvert.DeserializeObject<List<Project>>(ReadFromFile());
        //    return projects;
        //}

        //public static void Update(List<Project> projects)
        //{
        //    var jsonProjects = JsonConvert.SerializeObject(projects);
        //    WriteToFile(jsonProjects);
        //}

        //private static string ReadFromFile()
        //{
        //    if (!FileProvider.IsExist(FilePaths.ProjectPath))
        //    {
        //        FileProvider.Create(FilePaths.ProjectPath);
        //    }
        //    return FileProvider.Read(FilePaths.ProjectPath);
        //}

        //private static void WriteToFile(string value)
        //{
        //    FileProvider.Write(FilePaths.ProjectPath, value, false);
        //}
    }
}
