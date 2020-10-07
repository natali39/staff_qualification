using System;

namespace staff_qualification_Forms
{
    public class SelfCheckDb : IdDb
    {
        //public int Id { get; set; }
        public Guid TrainingID { get; set; }
        public int ResponsiblePersonID { get; set; }
        public DateTime Date { get; set; }
    }
}
