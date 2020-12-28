using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ModelDb : IdDb
    {
        public string Name { get; set; }
        public List<OperationDb> Operations { get; set; }

        public Guid? ProjectDbId { get; set; }
        public ProjectDb ProjectDb { get; set; }
    }
}
