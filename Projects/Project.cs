using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Project : Id
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; }

        public Project()
        {
            Models = new List<Model>();
        }
    }
}
