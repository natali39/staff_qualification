using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ProjectFileRepository
    {
        public List<Project> GetAll()
        {
            var projects = JsonHelper.Deserialize<List<Project>>(ReadFromFile());
            if (projects == null)
                projects = new List<Project>();
            return projects;
        }
            
        public void Update(List<Project> projects)
        {
            var jsonProjects = JsonHelper.Serialize<List<Project>>(projects);
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
