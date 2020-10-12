using System;

namespace staff_qualification_Forms
{
    public class SelfCheckDb : IdDb
    {
        //public Guid Id { get; set; }
        public int ResponsiblePersonId { get; set; }
        public DateTime Date { get; set; }

        public Guid TrainingDbId { get; set; }
        public TrainingDb TrainingDb { get; set; }
    }
}
