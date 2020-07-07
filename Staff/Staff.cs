using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft;

namespace staff_qualification_Forms
{
    public enum Positions
    {
        [Description("Швея")]
        Seamstress,

        [Description("Контролёр")]
        Control,

        [Description("Мастер")]
        Master,

        [Description("Начальник производства")]
        ProductionManager,
    }

    public class Staff
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Positions Position { get; set; }
        public List<Staff> staffs { get; set; }

        public Staff()
        {
        }

        public Staff(int id, string lastName, string firstName, string middleName, Positions position)
        {
            this.ID = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.Position = position;
        }

        public static int GetNextId(List<Staff> staffs)
        {
            var idArray = new int[staffs.Count];
            foreach (var staff in staffs)
            {
                idArray[staffs.IndexOf(staff)] = staff.ID;
            }
            var idMax = 0;
            for (int i = 0; i < idArray.Length; i++)
            {
                if (idArray[i] > idMax)
                    idMax = idArray[i];
            }
            return idMax + 1;
        }

        public static List<Staff> SearchLastName(List<Staff> staffs, string userInputValue)
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
    }
}
