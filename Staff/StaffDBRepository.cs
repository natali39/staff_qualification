using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staff_qualification_Forms
{
    class StaffDBRepository : IStaffRepository
    {
        DataTable table;

        public DataTable GetAll()
        {
            return table;
        }

        public void Update(DataTable table)
        {

        }

        public void Delete()
        {

        }
    }
}
