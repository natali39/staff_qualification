using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Model : Id
    {
        public string Name { get; set; }
        public List<Operation> Operations;

        public Model()
        {
            Operations = new List<Operation>();
        }
    }
}