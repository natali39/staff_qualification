using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Model
    {
        int id;
        public string Name { get; set; }
        public Project Project { get; set; }
        public List<Operation> operations;

        public Model(string name)
        {
            this.Name = name;
        }
    }
}