using System.Collections.Generic;
using System.Data;

namespace staff_qualification_Forms
{
    public interface IStaffRepository
    {
        List<Staff> GetAll();
        void Update(List<Staff> staffs);
    }
}
