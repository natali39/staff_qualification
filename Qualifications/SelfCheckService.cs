using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class SelfCheckService
    {
        private readonly ISelfCheckRepository repository;

        public SelfCheckService(ISelfCheckRepository repository)
        {
            this.repository = repository;
        }

        public List<SelfCheck> GetData()
        {
            return repository.GetAll();
        }

        public void UpdateData(List<SelfCheck> selfChecks)
        {
            repository.Update(selfChecks);
        }
    }
}
