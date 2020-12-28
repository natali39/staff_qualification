using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace staff_qualification_Forms
{
    public class ProjectDbRepository : IProjectRepository
    {
        public List<ProjectDb> GetAll()
        {
            using (var context = new QualificationDbContext())
            {
                return context.Projects
                    .Include(p => p.Models
                        .Select(m => m.Operations
                            .Select(o => o.Documents)))
                    .ToList();
            }
        }

        public ProjectDb Add(ProjectDb projectDb)
        {
            using (var context = new QualificationDbContext())
            {
                var projectDbWithId = context.Projects.Add(projectDb);
                context.SaveChanges();
                return projectDbWithId;
            }
        }

        public void Delete(ProjectDb projectDb)
        {
            using (var context = new QualificationDbContext())
            {

                context.Entry(projectDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ProjectDb Update(ProjectDb modifiedProjectDb)
        {
            using (var context = new QualificationDbContext())
            {
                var originalProjectDb = context.Projects
                    .Where(p => p.Id == modifiedProjectDb.Id)
                    .Include(p => p.Models
                    .Select(m => m.Operations
                    .Select(o => o.Documents)))
                    .FirstOrDefault();
                originalProjectDb.Models = modifiedProjectDb.Models;
                context.Entry(originalProjectDb).State = EntityState.Modified;
                context.SaveChanges();
                return context.Projects.Where(p => p.Id == modifiedProjectDb.Id).FirstOrDefault();
            }
        }
    }
}
