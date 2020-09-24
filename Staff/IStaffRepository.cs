using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IStaffRepository
    {
        List<Staff> GetAll();
        void Add(Staff staff);
        void Delete(Staff staff);
        void Update(Staff staff);
    }
}
