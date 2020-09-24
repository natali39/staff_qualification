using Newtonsoft.Json;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class StaffFileRepository : IStaffRepository
    {
        public List<Staff> GetAll()
        {
            var staffs = JsonHelper.Deserialize<List<Staff>>(ReadFromFile());
            if (staffs == null)
                staffs = new List<Staff>();
            return staffs;
        }

        public void Add(Staff staff)
        {

        }

        public void Delete(Staff staff)
        {

        }

        public void Update(Staff staff)
        {

        }

        //public void Update(List<Staff> staffs)
        //{
        //    var jsonStaffs = JsonHelper.Serialize<List<Staff>>(staffs);
        //    WriteToFile(jsonStaffs);
        //}

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
