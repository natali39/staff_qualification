using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Staff
    {
        public string ID;
        public string Name;
        public string Position;

        public List<string> positions = new List<string>
        {
            "швея",
            "контролер",
            "инструктор",
            "мастер",
            "начальник производства"
        };

        public Staff(string id, string name, string position)
        {
            this.ID = id;
            this.Name = name;
            this.Position = position;
        }

        public static List<Staff> GetListStaffs(string [] staffDataLines)
        {
            var staffs = new List<Staff>();
            foreach (var line in staffDataLines)
            {
                var splitLines = line.Split(';');
                var staff = new Staff(splitLines[0], splitLines[1], splitLines[2]);
                staffs.Add(staff);
            }
            return staffs;
        }

        public static string GetStaffsFormated(List<Staff> staffs)
        {
            var staffsFormated = string.Empty;
            foreach (var staff in staffs)
            {
                staffsFormated += $"{staff.ID};{staff.Name};{staff.Position}{Environment.NewLine}";
            }
            return staffsFormated;
        }

        public static string[] GetStaffsData()
        {
            if (!FileProvider.IsExist(FilePaths.StaffPath))
            {
                FileProvider.Create(FilePaths.StaffPath);
            }
            var staffDataFromFile = FileProvider.ReadDataFromFile(FilePaths.StaffPath);
            return staffDataFromFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static void PutStaffsData(string value)
        {
            FileProvider.WriteDataToFile(FilePaths.StaffPath, value, false);
        }
    }
}
