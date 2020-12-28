using System;

namespace staff_qualification_Forms
{
    public class TrainingDb : IdDb
    {
        public int StaffDbId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid ModelId { get; set; }
        public Guid OperationId { get; set; }
        public int TrainerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual StaffDb StaffDb { get; set; }
        //public virtual ProjectDb ProjectDb { get; set; }
        //public virtual ModelDb ModelDb { get; set; }
        public virtual OperationDb OperationDb { get; set; }
    }
}
