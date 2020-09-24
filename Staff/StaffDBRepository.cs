using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace staff_qualification_Forms
{
    public class StaffDBRepository : IStaffRepository
    {
        public List<Staff> GetAll()
        {
            using (var context = new QualificationDbContext())
            {
                var staffsDb = context.Staffs.ToList();
                var staffs = new List<Staff>();
                foreach (var staffDb in staffsDb)
                {
                    var staff = ToStaff(staffDb);
                    staffs.Add(staff);
                }
                return staffs;
            }
        }

        public void Add(Staff staff)
        {
            using (var context = new QualificationDbContext())
            {
                var staffDb = ToStaffDb(staff);
                context.Staffs.Add(staffDb);
                context.SaveChanges();
            }
        }

        public void Delete(Staff staff)
        {
            using (var context = new QualificationDbContext())
            {
                var staffDb = ToStaffDb(staff);
                context.Entry(staffDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Staff staff)
        {
            using (var context = new QualificationDbContext())
            {
                var staffDb = context.Staffs.Find(staff.ID);
                var staffDbChanged = ToStaffDb(staff);
                staffDb.LastName = staffDbChanged.LastName;
                staffDb.FirstName = staffDbChanged.FirstName;
                staffDb.MiddleName = staffDbChanged.MiddleName;
                staffDb.Position = staffDbChanged.Position;
                context.Entry(staffDb).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        Staff ToStaff(StaffDb staffDb)
        {
            var staff = new Staff();
            staff.ID = staffDb.Id; 
            staff.LastName = staffDb.LastName;
            staff.FirstName = staffDb.FirstName;
            staff.MiddleName = staffDb.MiddleName;
            staff.Position = ToStaffPosition(staffDb.Position);
            return staff;
        }

        StaffDb ToStaffDb(Staff staff)
        {
            var staffDb = new StaffDb();
            staffDb.Id = staff.ID;
            staffDb.LastName = staff.LastName;
            staffDb.FirstName = staff.FirstName;
            staffDb.MiddleName = staff.MiddleName;
            staffDb.Position = ToStaffDbPosition(staff.Position);
            return staffDb;
        }

        private PositionsDb ToStaffDbPosition(Positions position)
        {
            switch (position)
            {
                case Positions.Seamstress:
                    return PositionsDb.Seamstress;
                case Positions.Control:
                    return PositionsDb.Control;
                case Positions.Master:
                    return PositionsDb.Master;
                case Positions.ProductionManager:
                    return PositionsDb.ProductionManager;
                default:
                    return 0;
            }
        }

        Positions ToStaffPosition (PositionsDb positionsDb)
        {
            switch (positionsDb)
            {
                case PositionsDb.Seamstress:
                    return Positions.Seamstress;
                case PositionsDb.Control:
                    return Positions.Control;
                case PositionsDb.Master:
                    return Positions.Master;
                case PositionsDb.ProductionManager:
                    return Positions.ProductionManager;
                default:
                    return 0;
            }
        }
    }
}
