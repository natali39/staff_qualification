using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staff_qualification_Forms
{
    class StaffService
    {

        public DataTable GetData(IStaffRepository repository)
        {
            return repository.GetAll();
        }

        public void UpdateData(IStaffRepository repository, DataTable table)
        {
            repository.Update(table);
        }
    }
}
