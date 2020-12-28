using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class StaffService
    {
        private readonly IStaffRepository repository;

        public StaffService(IStaffRepository repository)
        {
            this.repository = repository;
        }

        public List<Staff> GetData()
        {
            var staffsDb = repository.GetAll();
            return ConvertToStaffs(staffsDb);
        }

        public Staff AddStaff(Staff staff)
        {
            var staffDb = ToStaffDb(staff);
            var staffDbWithId = repository.Add(staffDb);
            var staffWithId = ToStaff(staffDbWithId);
            return staffWithId;
        }

        public void RemoveStaff(Staff staff)
        {
            var staffDb = ToStaffDb(staff);
            repository.Delete(staffDb);
        }

        public void UpdateStaff(Staff staff)
        {
            var staffDb = ToStaffDb(staff);
            repository.Update(staffDb);
        }

        static List<Staff> ConvertToStaffs(List<StaffDb> staffsDb)
        {
            var staffs = new List<Staff>();
            foreach (var staffDb in staffsDb)
            {
                var staff = ToStaff(staffDb);
                staffs.Add(staff);
            }
            return staffs;
        }

        static Staff ToStaff(StaffDb staffDb)
        {
            var staff = new Staff();
            staff.ID = staffDb.Id;
            staff.LastName = staffDb.LastName;
            staff.FirstName = staffDb.FirstName;
            staff.MiddleName = staffDb.MiddleName;
            staff.Position = ToStaffPosition(staffDb.Position);
            return staff;
        }

        static Positions ToStaffPosition(PositionsDb positionsDb)
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
    }
}
