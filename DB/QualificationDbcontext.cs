using System.Data.Entity;

namespace staff_qualification_Forms
{
    public class QualificationDbContext : DbContext
    {
        public QualificationDbContext() : base("DBConnectionString")
        {
        }
        //public DbSet<ProjectDb> Projects { get; set; }
        //public DbSet<ModelDb> Models { get; set; }
        //public DbSet<OperationDb> Operations { get; set; }
        //public DbSet<DocumentDb> Documents { get; set; }
        public DbSet<StaffDb> Staffs { get; set; }
        public DbSet<TrainingDb> Trainings { get; set; }
        public DbSet<SelfCheckDb> SelfChecks { get; set; }
    }
}
