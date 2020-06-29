using System.Collections.Generic;
using System.Data;

namespace staff_qualification_Forms
{
    public interface IStaffRepository
    {
        Staffs GetAll();
        void Update(Staffs staffs);
    }
}
