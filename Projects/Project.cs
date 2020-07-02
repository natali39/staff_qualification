using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Project
    {
        int id;
        public string Name { get; set; }
        public List<Model> Models;

        public Project(string name)
        {
            this.Name = name;
        }

        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();
            projects.Add(new Project("Audi"));
            projects.Add(new Project("VW"));
            projects.Add(new Project("BMW"));
            return projects;
        }

        public List<Model> GetModels()
        {
            List<Model> models = new List<Model>();
            models.Add(new Model("model1"));
            models.Add(new Model("model2"));
            return models;
        }
    }
}
