using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;

namespace staff_qualification_Forms
{
    public class StaffFileRepository : IStaffRepository
    {
        public Staffs GetAll()
        {
            var staffs = JsonConvert.DeserializeObject<Staffs>(ReadFromFile());
            return staffs;
        }

        public void Update(Staffs staffs)
        {
            var jsonStaffs = JsonConvert.SerializeObject(staffs);
            WriteToFile(jsonStaffs);
        }

        private string ReadFromFile()
        {
            if (!FileProvider.IsExist(FilePaths.StaffPath))
            {
                FileProvider.Create(FilePaths.StaffPath);
            }
            return FileProvider.Read(FilePaths.StaffPath);
        }

        private void WriteToFile(string value)
        {
            FileProvider.Write(FilePaths.StaffPath, value, false);
        }
    }
}
