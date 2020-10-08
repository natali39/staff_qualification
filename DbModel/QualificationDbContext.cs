using System.Data.Entity;

namespace staff_qualification_Forms
{
    public class QualificationDbContext : DbContext
    {
        public QualificationDbContext() : base("DbConnectionString")
        {
        }

        public DbSet<StaffDb> Staffs { get; set; }
    }
}
