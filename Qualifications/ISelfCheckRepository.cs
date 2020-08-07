using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface ISelfCheckRepository
    {
        List<SelfCheck> GetAll();
        void Update(List<SelfCheck> selfChecks);
    }
}
