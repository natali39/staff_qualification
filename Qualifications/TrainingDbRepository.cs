using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace staff_qualification_Forms
{
    public class TrainingDbRepository : ITrainingRepository
    {
        public List<TrainingDb> GetAll()
        {
            using (var context = new QualificationDbContext())
            {
                return context.Trainings.ToList();
            }
        }

        public void Add(TrainingDb trainingDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Trainings.Add(trainingDb);
                context.SaveChanges();
            }
        }

        public void Delete(TrainingDb trainingDb)
        {
            using (var context = new QualificationDbContext())
            {
                context.Entry(trainingDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TrainingDb trainingDbChanged)
        {
            using (var context = new QualificationDbContext())
            {
                var trainingDbCurrent = context.Trainings.Find(trainingDbChanged.Id);
                trainingDbCurrent.StaffDbId = trainingDbChanged.StaffDbId;
                trainingDbCurrent.TrainerId = trainingDbChanged.TrainerId;
                trainingDbCurrent.ProjectId = trainingDbChanged.ProjectId;
                trainingDbCurrent.ModelId = trainingDbChanged.ModelId;
                trainingDbCurrent.OperationId = trainingDbChanged.OperationId;
                trainingDbCurrent.StartDate = trainingDbChanged.StartDate;
                trainingDbCurrent.EndDate = trainingDbChanged.EndDate;
                context.Entry(trainingDbCurrent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
