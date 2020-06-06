using System.IO;
using System.Text;

namespace staff_qualification_Forms
{
    public class LoadData
    {
        public static string ReadDataFromFile(string path)
        {
            using (var streamReader = new StreamReader(path, Encoding.Default))
            {
                return streamReader.ReadToEnd();
            }
        }

        public static void WriteDataToFile(string path, string data, bool append)
        {
            using (var streamWriter = new StreamWriter(path, append, Encoding.UTF8))
            {
                streamWriter.WriteLine(data);
            }
        }
    }
}
