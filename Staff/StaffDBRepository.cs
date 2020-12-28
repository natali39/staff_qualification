using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace staff_qualification_Forms
{
    public class StaffDBRepository : IStaffRepository
    {
        public List<StaffDb> GetAll()
        {
            using (var context = new QualificationDbContext())
            {
                return context.Staffs.ToList();
            }
        }

        public StaffDb Add(StaffDb staffDb) // вернуть обновленный staffDb
        {
            using (var context = new QualificationDbContext())
            {
                var entity = context.Staffs.Add(staffDb);
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(StaffDb staffDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(staffDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(StaffDb staffDbChanged)
        {
            using (var context = new QualificationDbContext())
            {
                var staffDbCurrent = context.Staffs.Find(staffDbChanged.Id);
                staffDbCurrent.LastName = staffDbChanged.LastName;
                staffDbCurrent.FirstName = staffDbChanged.FirstName;
                staffDbCurrent.MiddleName = staffDbChanged.MiddleName;
                staffDbCurrent.Position = staffDbChanged.Position;
                context.Entry(staffDbCurrent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
