using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface ITrainingRepository
    {
        List<Training> GetAll();
        void Update(List<Training> trainings);
    }
}
