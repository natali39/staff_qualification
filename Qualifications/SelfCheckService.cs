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

        public SelfCheck AddSelfCheck(SelfCheck selfCheck)
        {
            var selfCheckDb = ToSelfCheckDb(selfCheck);
            var selfCheckDbWithId = repository.Add(selfCheckDb);
            return ToSelfCheck(selfCheckDbWithId);
        }

        public void RemoveSelfCheck(SelfCheck selfCheck)
        {
            var selfCheckDb = ToSelfCheckDb(selfCheck);
            repository.Delete(selfCheckDb);
        }

        public void UpdateSelfCheck(SelfCheck selfCheck)
        {
            var selfCheckDb = ToSelfCheckDb(selfCheck);
            repository.Update(selfCheckDb);
        }

        static SelfCheck ToSelfCheck(SelfCheckDb selfCheckDb)
        {
            var selfCheck = new SelfCheck();
            selfCheck.ID = selfCheckDb.Id;
            selfCheck.TrainingID = selfCheckDb.TrainingDbId;
            selfCheck.ResponsiblePersonID = selfCheckDb.ResponsiblePersonId;
            selfCheck.Date = selfCheckDb.Date;
            return selfCheck;
        }

        static SelfCheckDb ToSelfCheckDb(SelfCheck selfCheck)
        {
            var selfCheckDb = new SelfCheckDb();
            selfCheckDb.Id = selfCheck.ID;
            selfCheckDb.TrainingDbId = selfCheck.TrainingID;
            selfCheckDb.ResponsiblePersonId = selfCheck.ResponsiblePersonID;
            selfCheckDb.Date = selfCheck.Date;
            return selfCheckDb;
        }
    }
}
