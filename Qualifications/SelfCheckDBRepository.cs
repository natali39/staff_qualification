using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace staff_qualification_Forms
{
    public class SelfCheckDbRepository : ISelfCheckRepository
    {
        public List<SelfCheckDb> GetAll()
        {
            using (var context = new QualificationDbContext())
            {
                return context.SelfChecks.ToList();
            }
        }

        public void Add(SelfCheckDb selfCheckDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.SelfChecks.Add(selfCheckDb);
                context.SaveChanges();
            }

        }

        public void Delete(SelfCheckDb selfCheckDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(selfCheckDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(SelfCheckDb selfCheckDbChanged)
        {
            using (var context = new QualificationDbContext())
            {
                var selfCheckDbCurrent = context.SelfChecks.Find(selfCheckDbChanged.ID);
                selfCheckDbCurrent.TrainingID = selfCheckDbChanged.TrainingID;
                selfCheckDbCurrent.ResponsiblePersonID = selfCheckDbChanged.ResponsiblePersonID;
                selfCheckDbCurrent.Date = selfCheckDbChanged.Date;
                context.Entry(selfCheckDbCurrent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
