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
                var projectsDb = context.Projects.ToList();
                return projectsDb;
            }
        }

        public void Add(ProjectDb projectDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Projects.Add(projectDb);
                context.SaveChanges();
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

        public void Update(ProjectDb projectDbChanged)
        {
            using (var context = new QualificationDbContext())
            {
                var projectDbCurrent = context.Projects.Find(projectDbChanged.ID);
                projectDbCurrent.Name = projectDbChanged.Name;
                projectDbCurrent.Models = projectDbChanged.Models;
                context.Entry(projectDbCurrent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
