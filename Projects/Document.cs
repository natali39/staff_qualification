namespace staff_qualification_Forms
{
    public class Document : Id
    {
        public string Name;
        public string Path;

        public Document()
        {

        }

        public Document(string name, string path)
        {
            Name = name;
            Path = path;
        }
    }
}
