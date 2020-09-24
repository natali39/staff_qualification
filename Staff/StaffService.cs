using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class StaffService
    {
        private readonly IStaffRepository repository;

        public StaffService(IStaffRepository repository)
        {
            this.repository = repository;
        }

        public List<Staff> GetData()
        {
            return repository.GetAll();
        }

        public void AddStaff(Staff staff)
        {
            repository.Add(staff);
        }

        public void RemoveStaff(Staff staff)
        {
            repository.Delete(staff);
        }

        public void UpdateStaff(Staff staff)
        {
            repository.Update(staff);
        }
    }
}
