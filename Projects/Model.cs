using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Model
    {
        int id;
        public string Name { get; set; }
        public List<Operation> Operations;

        public Model(string name)
        {
            this.Name = name;
            Operations = new List<Operation>();
        }
    }
}