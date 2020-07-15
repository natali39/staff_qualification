using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staff_qualification_Forms
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        void Update(List<Project> projects);
    }
}
