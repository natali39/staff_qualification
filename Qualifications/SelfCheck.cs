﻿using System;

namespace staff_qualification_Forms
{
    public  class SelfCheck : Id
    {
        public Guid TrainingID { get; set; }
        public int ResponsiblePersonID { get; set; }
        public DateTime Date { get; set; }
    }
}