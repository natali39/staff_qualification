using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class OperationDb : IdDb
    {
        public string Name { get; set; }
        public List<DocumentDb> Documents { get; set; }

        public Guid? ModelDbId { get; set; }
        public ModelDb ModelDb { get; set; }
    }
}
