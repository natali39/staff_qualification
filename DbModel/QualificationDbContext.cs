using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staff_qualification_Forms
{
    public class QualificationDbContext : DbContext 
    {
        public QualificationDbContext() : base("DbConnectionString")
        {

        }
        public DbSet<StaffDb> Staffs { get; set; }
        public DbSet<TrainingDb> Trainings { get; set; }
        public DbSet<SelfCheckDb> SelfChecks { get; set; }
    }
}
