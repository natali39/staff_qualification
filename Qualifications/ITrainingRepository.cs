using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface ITrainingRepository
    {
        List<TrainingDb> GetAll();
        void Add(TrainingDb trainingDb);
        void Delete(TrainingDb trainingDb);
        void Update(TrainingDb trainingsDb);
    }
}
