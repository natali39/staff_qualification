using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void UpdateData(List<Staff> staffs)
        {
            repository.Update(staffs);
        }
    }
}
