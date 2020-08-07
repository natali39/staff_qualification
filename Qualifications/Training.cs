using System;

namespace staff_qualification_Forms
{
    public class Training : Id
    {
        public int StaffID { get; set; }
        public Guid ProjectID { get; set; }
        public Guid ModelID { get; set; }
        public Guid OperationID { get; set; }
        public int TrainerID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
