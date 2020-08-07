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
            return repository.GetAll();
        }

        public void UpdateData(List<Training> trainings)
        {
            repository.Update(trainings);
        }
    }
}
