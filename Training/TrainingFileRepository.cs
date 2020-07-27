using Newtonsoft.Json;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class TrainingFileRepository : ITrainingRepository
    {
        public List<Training> GetAll()
        {
            return JsonConvert.DeserializeObject<List<Training>>(ReadFromFile());
        }

        public void Add(Training training)
        {
            var jsonTraining = JsonConvert.SerializeObject(training);
            WriteToFile(jsonTraining);
        }

        public void Update(List<Training> trainings)
        {
            var jsonTraining = JsonConvert.SerializeObject(trainings);
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
