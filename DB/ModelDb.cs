using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ModelDb : IdDb
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public List<OperationDb> Operations { get; set; }
    }
}
