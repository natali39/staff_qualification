using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ProjectDb : IdDb
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public List<ModelDb> Models { get; set; }
    }
}
