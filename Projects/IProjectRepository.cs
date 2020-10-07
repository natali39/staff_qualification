using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IProjectRepository
    {
        List<ProjectDb> GetAll();
        void Add(ProjectDb projectDb);
        void Delete(ProjectDb projectDb);
        void Update(ProjectDb projectDb);
    }
}
