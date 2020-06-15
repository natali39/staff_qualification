using System;
using System.Data;

namespace staff_qualification_Forms
{
    class StaffFileRepository : IStaffRepository
    {
        DataTable table = new DataTable();

        public DataTable GetAll()
        {
            var staffsDataFromFile = ReadFromFile();
            var staffDataLines = staffsDataFromFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            GetTableHeader();
            GetTableRows(staffDataLines);
            return table;
        }

        public void Update(DataTable table)
        {
            WriteToFile(GetFormatedLinesFromTable(table));
        }

        public void Delete()
        {

        }

        private void GetTableHeader()
        {
            table.Columns.Add("id");
            table.Columns.Add("lastName");
            table.Columns.Add("firstName");
            table.Columns.Add("middleName");
            table.Columns.Add("position");
        }

        private void GetTableRows(string[] staffDataLines)
        {
            foreach (var line in staffDataLines)
            {
                var row = line.Split(';');
                table.Rows.Add(row);
            }
        }

        private string ReadFromFile()
        {
            if (!FileProvider.IsExist(FilePaths.StaffPath))
            {
                FileProvider.Create(FilePaths.StaffPath);
            }
            return FileProvider.Read(FilePaths.StaffPath);
        }

        private void WriteToFile(string value)
        {
            FileProvider.Write(FilePaths.StaffPath, value, false);
        }

        private string GetFormatedLinesFromTable(DataTable table)
        {
            var lines = string.Empty;
            var line = string.Empty;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Rows[i].ItemArray.Length; j++)
                {
                    if (j != table.Rows[i].ItemArray.Length - 1)
                        line = line + table.Rows[i].ItemArray[j].ToString() + ";";
                    else
                        line = line + table.Rows[i].ItemArray[j].ToString() + Environment.NewLine;
                }
                lines = lines + line;
                line = string.Empty;
            }
            return lines;
        }
    }
}
