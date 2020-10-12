using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class TrainingService
    {
        private readonly ITrainingRepository repository;

        public TrainingService(ITrainingRepository repository)
        {
            this.repository = repository;
        }

        public List<Training> GetData()
        {
            var trainingsDb = repository.GetAll();
            var trainings = new List<Training>();
            foreach (var trainingDb in trainingsDb)
            {
                var training = ToTraining(trainingDb);
                trainings.Add(training);
            }
            return trainings;
        }

        public void AddTraining(Training training)
        {
            var trainingDb = ToTrainingDb(training);
            repository.Add(trainingDb);
        }

        public void DeleteTraining(Training training)
        {
            var trainingDb = ToTrainingDb(training);
            repository.Delete(trainingDb);
        }

        public void UpdateTraining(Training training)
        {
            var trainingDb = ToTrainingDb(training);
            repository.Update(trainingDb);
        }

        static Training ToTraining(TrainingDb trainingDb)
        {
            var training = new Training();
            training.ID = trainingDb.Id;
            training.StaffID = trainingDb.StaffDbId;
            training.TrainerID = trainingDb.TrainerId;
            training.ProjectID = trainingDb.ProjectId;
            training.ModelID = trainingDb.ModelId;
            training.OperationID = trainingDb.OperationId;
            training.StartDate = trainingDb.StartDate;
            training.EndDate = trainingDb.EndDate;
            return training;
        }

        private TrainingDb ToTrainingDb(Training training)
        {
            var trainingDb = new TrainingDb();
            trainingDb.Id = training.ID;
            trainingDb.StaffDbId = training.StaffID;
            trainingDb.TrainerId = training.TrainerID;
            trainingDb.ProjectId = training.ProjectID;
            trainingDb.ModelId = training.ModelID;
            trainingDb.OperationId = training.OperationID;
            trainingDb.StartDate = training.StartDate;
            trainingDb.EndDate = training.EndDate;
            return trainingDb;
        }
    }
}
