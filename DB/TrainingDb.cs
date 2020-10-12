using System;

namespace staff_qualification_Forms
{
    public class TrainingDb : IdDb
    {
        //public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid ModelId { get; set; }
        public Guid OperationId { get; set; }
        public int TrainerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int StaffDbId { get; set; }
        public StaffDb StaffDb { get; set; }
    }
}
