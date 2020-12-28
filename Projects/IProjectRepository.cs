using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IProjectRepository
    {
        List<ProjectDb> GetAll();
        ProjectDb Add(ProjectDb projectDb);
        void Delete(ProjectDb projectDb);
        ProjectDb Update(ProjectDb projectDb);
    }
}
