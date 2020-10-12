using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface ISelfCheckRepository
    {
        List<SelfCheckDb> GetAll();
        SelfCheckDb Add(SelfCheckDb selfCheckDb);
        void Delete(SelfCheckDb selfCheckDb);
        void Update(SelfCheckDb selfCheckDb);
    }
}
