using Newtonsoft.Json;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class StaffFileRepository : IStaffRepository
    {
        public List<Staff> GetAll()
        {
            var staffs = JsonConvert.DeserializeObject<List<Staff>>(ReadFromFile());
            return staffs;
        }

        public void Update(List<Staff> staffs)
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
