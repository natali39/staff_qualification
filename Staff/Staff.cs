using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft;

namespace staff_qualification_Forms
{
    public class Staffs
    {
        public List<Staff> ListStaffs { get; set; }
    }

    public enum PositionsEnum
    {
        [Description("Швея")]
        Seamstress,

        [Description("Контролёр")]
        Control,

        [Description("Мастер")]
        Master,

        [Description("Начальник производства")]
        ProductoinManager,
    }

    public class Staff
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }

        public Staff()
        {
        }

        public Staff(string id, string lastName, string firstName, string middleName, string position)
        {
            this.ID = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.Position = position;
        }
    }
}
