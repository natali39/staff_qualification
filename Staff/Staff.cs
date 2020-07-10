using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft;

namespace staff_qualification_Forms
{
    public enum Positions
    {
        [Description("Швея")]
        Seamstress = 0,

        [Description("Контролёр")]
        Control = 1,

        [Description("Мастер")]
        Master = 2,

        [Description("Начальник производства")]
        ProductionManager = 3,
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

        public static object GetPositionsDescription()
        {
            return Enum.GetValues(typeof(Positions))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
        }

        public static string GetDescription(Enum position)
        {
            Type type = position.GetType();

            MemberInfo[] memInfo = type.GetMember(position.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return position.ToString();
        }

        public static string GetPositionDisplayName(Positions position)
        {
            switch ((int)position)
            {
                case 0:
                    return "швея";
                case 1:
                    return "контролер";
                case 2:
                    return "мастер";
                case 3:
                    return "начальник производства";
            }
            return string.Empty;
        }
    }
}
