using System;

namespace staff_qualification_Forms
{
    public class DocumentDb : IdDb
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Guid? OperationDbId { get; set; }
        public OperationDb OperationDb { get; set; }
    }
}
