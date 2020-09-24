using System;

namespace staff_qualification_Forms
{
    public class TrainingDb
    {
        public int Id { get; set; }
        public int StaffID { get; set; }
        public int ProjectID { get; set; }
        public int ModelID { get; set; }
        public int OperationID { get; set; }
        public int TrainerID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
