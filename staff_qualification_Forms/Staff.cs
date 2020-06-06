using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Staff
    {
        public string id;
        public string name;
        public string position;

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
            this.id = id;
            this.name = name;
            this.position = position;
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
                staffsFormated += $"{staff.id};{staff.name};{staff.position}{Environment.NewLine}";
            }
            return staffsFormated;
        }

        public static string[] GetStaffsData()
        {
            var staffDataFromFile = LoadData.ReadDataFromFile(@"staff.txt");
            return staffDataFromFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static void PutStaffsData(string value)
        {
            LoadData.WriteDataToFile(@"staff.txt", value, false);
        }
    }
}
