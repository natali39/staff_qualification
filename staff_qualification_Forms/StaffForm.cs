using System;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            SetFormProperties();
            ShowTable();
        }

        public void SetFormProperties()
        {
            var idColumn = new DataGridViewColumn();
            idColumn.HeaderText = "Табельный номер";
            idColumn.Name = "id";
            idColumn.CellTemplate = new DataGridViewTextBoxCell();
            idColumn.ReadOnly = true;

            var nameColumn = new DataGridViewColumn();
            nameColumn.HeaderText = "ФИО сотрудника";
            nameColumn.Name = "name";
            nameColumn.CellTemplate = new DataGridViewTextBoxCell();
            nameColumn.ReadOnly = true;


            var positionColumn = new DataGridViewColumn();
            positionColumn.HeaderText = "Должность";
            positionColumn.Name = "position";
            positionColumn.CellTemplate = new DataGridViewTextBoxCell();
            positionColumn.ReadOnly = true;

            staffDataGridView.Columns.Add(idColumn);
            staffDataGridView.Columns.Add(nameColumn);
            staffDataGridView.Columns.Add(positionColumn);

            staffDataGridView.AllowUserToAddRows = false;
        }

        private void ShowTable()
        {
            staffDataGridView.Rows.Clear();
            WriteDataInTable();
        }

        private void UpdateTable()
        {
            var lines = ReadDataFromTable();
            Staff.PutStaffsData(lines);
        }

        private void WriteDataInTable()
        {
            var staffDataLines = Staff.GetStaffsData();
            foreach (var line in staffDataLines)
            {
                var rows = line.Split(';');
                staffDataGridView.Rows.Add(rows[0], rows[1], rows[2]);
            }
        }

        private string ReadDataFromTable()
        {
            var lines = string.Empty;
            var row = string.Empty;
            for (int i = 0; i < staffDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < staffDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j != staffDataGridView.Rows[i].Cells.Count - 1)
                        row = row + staffDataGridView.Rows[i].Cells[j].Value + ";";
                    else
                        row = row + staffDataGridView.Rows[i].Cells[j].Value + Environment.NewLine;
                }
                lines = lines + row;
                row = string.Empty;
            }
            return lines;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            var staffEditForm = new StaffEditForm();
            staffEditForm.ShowDialog();
            ShowTable();
        }

        private void editButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var index = staffDataGridView.CurrentRow.Index;
                var staffs = Staff.GetListStaffs(Staff.GetStaffsData());
                var staffEditForm = new StaffEditForm();
                staffEditForm.SetFormProperties(staffs, index);
                staffEditForm.ShowDialog();
                ShowTable();
            }
            catch
            {
                MessageBox.Show("В списке нет записей");
            }
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var currentIndex = staffDataGridView.CurrentRow.Index;
                var result = MessageBox.Show("Удалить запись?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    staffDataGridView.Rows.RemoveAt(currentIndex);
                    UpdateTable();
                    ShowTable();
                }
            }
            catch
            {
                MessageBox.Show("В списке нет записей");
            }
        }
    }
}
