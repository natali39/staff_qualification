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
            var selfChecksDb = repository.GetAll();
            var selfChecks = new List<SelfCheck>();
            foreach (var selfCheckDb in selfChecksDb)
            {
                var selfCheck = ToSelfCheck(selfCheckDb);
                selfChecks.Add(selfCheck);
            }
            return selfChecks;
        }

        public void AddStaff(SelfCheck selfCheck)
        {
            var selfCheckDb = ToSelfCheckDb(selfCheck);
            repository.Add(selfCheckDb);
        }

        public void RemoveStaff(SelfCheck selfCheck)
        {
            var selfCheckDb = ToSelfCheckDb(selfCheck);
            repository.Delete(selfCheckDb);
        }

        public void UpdateStaff(SelfCheck selfCheck)
        {
            var selfCheckDb = ToSelfCheckDb(selfCheck);
            repository.Update(selfCheckDb);
        }

        static SelfCheck ToSelfCheck(SelfCheckDb selfCheckDb)
        {
            var selfCheck = new SelfCheck();
            selfCheck.ID = selfCheckDb.ID;
            selfCheck.TrainingID = selfCheckDb.TrainingID;
            selfCheck.ResponsiblePersonID = selfCheckDb.ResponsiblePersonID;
            selfCheck.Date = selfCheckDb.Date;
            return selfCheck;
        }

        static SelfCheckDb ToSelfCheckDb(SelfCheck selfCheck)
        {
            var selfCheckDb = new SelfCheckDb();
            selfCheckDb.ID = selfCheck.ID;
            selfCheckDb.TrainingID = selfCheck.TrainingID;
            selfCheckDb.ResponsiblePersonID = selfCheck.ResponsiblePersonID;
            selfCheckDb.Date = selfCheck.Date;
            return selfCheckDb;
        }
    }
}
