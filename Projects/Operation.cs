using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Operation : Id
    {
        public string Name { get; set; }
        public List<Document> Documents { get; set; }

        public Operation()
        {
            Documents = new List<Document>();
        }
    }
}