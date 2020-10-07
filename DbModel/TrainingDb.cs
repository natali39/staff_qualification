using System;

namespace staff_qualification_Forms
{
    public class TrainingDb : IdDb
    {
        //public int Id { get; set; }
        public int StaffID { get; set; }
        public Guid ProjectID { get; set; }
        public Guid ModelID { get; set; }
        public Guid OperationID { get; set; }
        public int TrainerID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
