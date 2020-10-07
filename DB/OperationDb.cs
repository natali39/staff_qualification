using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class OperationDb : IdDb
    {
        public string Name { get; set; }
        public List<DocumentDb> Documents { get; set; }
    }
}
