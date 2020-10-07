﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace staff_qualification_Forms
{
    public class StaffDbRepository : IStaffRepository
    {
        public List<StaffDb> GetAll()
        {
            using (var context = new QualificationDbContext())
            {
                var staffsDb = context.Staffs.ToList();
                return staffsDb;
            }
        }

        public void Add(StaffDb staffDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Staffs.Add(staffDb);
                context.SaveChanges();
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
