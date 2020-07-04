using System.IO;
using System.Text;

namespace staff_qualification_Forms
{
    public class FileProvider
    {
        public static bool IsExist(string path)
        {
            return File.Exists(path);
        }

        public static void Create(string path)
        {
            using (FileStream fileStream = File.Create(path))
            {
            }
        }

        public static string Read(string path)
        {
            using (var streamReader = new StreamReader(path, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }

        public static void Write(string path, string data, bool append)
        {
            using (var streamWriter = new StreamWriter(path, append, Encoding.UTF8))
            {
                streamWriter.WriteLine(data);
            }
        }
    }
}
