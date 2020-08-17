using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Staff
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Positions Position { get; set; }

        public Staff()
        {
        }

        public static int GetNextId(List<Staff> staffs)
        {
            if (staffs == null || staffs.Count == 0)
                return 1;
            return staffs[staffs.Count - 1].ID + 1;
        }

        public static List<Staff> SearchByLastName(List<Staff> staffs, string userInputValue)
        {
            var foundListStaff = new List<Staff>();
            foreach(var staff in staffs)
            {
                if (staff.LastName.ToLower().Contains(userInputValue.ToLower()))
                {
                    foundListStaff.Add(staff);
                }
            }
            return foundListStaff;
        }

        public string GetStaffFullName()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }

        public static Staff GetStaffByID(int id, List<Staff> staffs)
        {
            foreach (var staff in staffs)
            {
                if (staff.ID == id)
                    return staff;
            }
            return null;
        }
   }
}
