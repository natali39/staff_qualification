using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Training
    {
        public int ID { get; set; }
        public Staff Staff { get; set; }
        public Project Project { get; set; }
        public Model Model { get; set; }
        public Operation Operation { get; set; }
        public Staff Trainer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static int GetNextID(List<Training> trainings)
        {
            if (trainings == null || trainings.Count == 0)
                return 0;
            return trainings[trainings.Count - 1].ID + 1;
        }
    }
}
