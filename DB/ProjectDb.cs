using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ProjectDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ModelDb> Models { get; set; }
    }
}
