using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IStaffRepository
    {
        List<StaffDb> GetAll();
        StaffDb Add(StaffDb staffDb);
        void Delete(StaffDb staffDb);
        void Update(StaffDb staffDb);
    }
}
