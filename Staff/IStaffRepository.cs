using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IStaffRepository
    {
        List<Staff> GetAll();
        void Update(List<Staff> staffs);
    }
}
