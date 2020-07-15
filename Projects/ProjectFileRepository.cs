using Newtonsoft.Json;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ProjectFileRepository : IProjectRepository
    {
        public List<Project> GetAll()
        {
            return JsonConvert.DeserializeObject<List<Project>>(ReadFromFile());
        }
            
        public void Update(List<Project> projects)
        {
            var jsonProjects = JsonConvert.SerializeObject(projects);
            WriteToFile(jsonProjects);
        }

        private string ReadFromFile()
        {
            if (!FileProvider.IsExist(FilePaths.ProjectPath))
            {
                FileProvider.Create(FilePaths.ProjectPath);
            }
            return FileProvider.Read(FilePaths.ProjectPath);
        }

        private void WriteToFile(string value)
        {
            FileProvider.Write(FilePaths.ProjectPath, value, false);
        }
    }
}
