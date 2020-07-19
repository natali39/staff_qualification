using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ProjectService
    {
        private readonly IProjectRepository repository;

        public ProjectService(IProjectRepository repository)
        {
            this.repository = repository;
        }

        public List<Project> GetData()
        {
            return repository.GetAll();
        }

        public void UpdateData(List<Project> projects)
        {
            repository.Update(projects);
        }
    }
}
