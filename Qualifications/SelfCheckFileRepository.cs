using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class SelfCheckFileRepository : ISelfCheckRepository
    {
        public List<SelfCheck> GetAll()
        {
            var selfChecks = JsonHelper.Deserialize<List<SelfCheck>>(ReadFromFile());
            if (selfChecks == null)
                selfChecks = new List<SelfCheck>();
            return selfChecks;
        }

        public void Update(List<SelfCheck> selfChecks)
        {
            var jsonSelfCheck = JsonHelper.Serialize<List<SelfCheck>>(selfChecks);
            WriteToFile(jsonSelfCheck);
        }

        private string ReadFromFile()
        {
            if (!FileProvider.IsExist(FilePaths.SelfCheckPath))
            {
                FileProvider.Create(FilePaths.SelfCheckPath);
            }
            return FileProvider.Read(FilePaths.SelfCheckPath);
        }

        private void WriteToFile(string value)
        {
            FileProvider.Write(FilePaths.SelfCheckPath, value, false);
        }
    }
}
