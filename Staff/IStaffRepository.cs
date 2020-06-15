using System.Data;

namespace staff_qualification_Forms
{
    interface IStaffRepository
    {
        DataTable GetAll();
        void Update(DataTable table);
        void Delete();
    }
}
