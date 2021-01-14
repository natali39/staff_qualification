using System;
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

        public ProjectDb GetProject(Guid projectId)
        {
            using (var context = new QualificationDbContext())
            {
                return context.Projects
                    .Include(p => p.Models
                        .Select(m => m.Operations
                            .Select(o => o.Documents)))
                    .FirstOrDefault(p => p.Id == projectId);
            }
        }

        public ProjectDb AddProject(ProjectDb projectDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Projects.Add(projectDb);
                context.SaveChanges();
                return projectDb;
            }
        }

        public void UpdateProject(ProjectDb projectDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(projectDb).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProject(ProjectDb projectDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(projectDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void AddModel(ModelDb modelDb, Guid projectId)
        {
            using (var context = new QualificationDbContext())
            {
                var projectDb = context.Projects.Include(p => p.Models).FirstOrDefault(p => p.Id == projectId);
                projectDb.Models.Add(modelDb);
                context.SaveChanges();
            }
        }

        public void UpdateModel(ModelDb modelDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(modelDb).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteModel(ModelDb modelDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(modelDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public OperationDb AddOperation(OperationDb operationDb, Guid modelId)
        {
            using (var context = new QualificationDbContext())
            {
                var modelDb = context.Models.Include(m => m.Operations).FirstOrDefault(m => m.Id == modelId);
                modelDb.Operations.Add(operationDb);
                context.SaveChanges();
            }
            return operationDb;
        }

        public void DeleteOperation(Guid operationId)
        {
            using (var context = new QualificationDbContext())
            {
                var operationDb = context.Operations.FirstOrDefault(o => o.Id == operationId);
                context.Operations.Remove(operationDb);
                context.SaveChanges();
            }
        }

        public void UpdateOperation(OperationDb operationDb)
        {
            using (var context = new QualificationDbContext())
            {
                var operation = context.Operations.Include(o => o.Documents).FirstOrDefault(o => o.Id == operationDb.Id);
                operation = operationDb;
                context.SaveChanges();
            }
        }
    }
}
