using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IStaffRepository
    {
        List<StaffDb> GetAll();
        void Add(StaffDb staffDb);
        void Delete(StaffDb staffDb);
        void Update(StaffDb staffDb);

        //List<Staff> GetAll();
        //void Update(List<Staff> staffs);
    }
}
