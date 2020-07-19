using Newtonsoft.Json;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class Project
    {
        int id;
        public string Name { get; set; }
        public List<Model> Models;

        public Project()
        {
            Models = new List<Model>();
        }
    }
}
