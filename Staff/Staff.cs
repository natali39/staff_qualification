using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Staff
    {
        public string ID;
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public string Position;

        public Staff(string id, string lastName, string firstName, string middleName, string position)
        {
            this.ID = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.Position = position;
        }

        public static List<Staff> GetListStaffs(string [] staffDataLines)
        {
            var staffs = new List<Staff>();
            foreach (var line in staffDataLines)
            {
                var splitLines = line.Split(';');
                var staff = new Staff(splitLines[0], splitLines[1], splitLines[2], splitLines[3], splitLines[4]);
                staffs.Add(staff);
            }
            return staffs;
        }

        public static string GetStaffsFormated(List<Staff> staffs)
        {
            var staffsFormated = string.Empty;
            foreach (var staff in staffs)
            {
                staffsFormated += $"{staff.ID};{staff.LastName};{staff.FirstName};{staff.MiddleName};{staff.Position}{Environment.NewLine}";
            }
            return staffsFormated;
        }
    }
}
