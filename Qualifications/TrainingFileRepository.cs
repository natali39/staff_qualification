using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class TrainingFileRepository : ITrainingRepository
    {
        public List<Training> GetAll()
        {
            var trainings = JsonHelper.Deserialize<List<Training>>(ReadFromFile());
            if (trainings == null)
                trainings = new List<Training>();
            return trainings;
        }

        public void Add(Training training)
        {
        }

        public void Update(List<Training> trainings)
        {
            var jsonTraining = JsonHelper.Serialize<List<Training>>(trainings);
            WriteToFile(jsonTraining);
        }

        private string ReadFromFile()
        {
            if (!FileProvider.IsExist(FilePaths.TrainingPath))
            {
                FileProvider.Create(FilePaths.TrainingPath);
            }
            return FileProvider.Read(FilePaths.TrainingPath);
        }

        private void WriteToFile(string value)
        {
            FileProvider.Write(FilePaths.TrainingPath, value, false);
        }
    }
}
