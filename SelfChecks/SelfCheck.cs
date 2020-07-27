using System;

namespace staff_qualification_Forms
{
    public  class SelfCheck
    {
        public int ID { get; set; }
        public Staff Staff { get; set; }
        public Staff ResponsiblePerson { get; set; }
        public Training Training { get; set; }
        public DateTime Date { get; set; }
    }
}