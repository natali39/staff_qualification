using System;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetFormProperties();
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

            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(nameColumn);
            dataGridView1.Columns.Add(positionColumn);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Visible = false;

            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTable();
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            dataGridView1.Visible = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var staffEditForm = new StaffEditForm();
            staffEditForm.ShowDialog();
            ShowTable();
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                var index = dataGridView1.CurrentRow.Index;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var currentIndex = dataGridView1.CurrentRow.Index;
                var result = MessageBox.Show("Удалить запись?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(currentIndex);
                    UpdateTable();
                    ShowTable();
                }
            }
            catch
            {
                MessageBox.Show("В списке нет записей");
            }
        }

        private void ShowTable()
        {
            dataGridView1.Rows.Clear();
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
                dataGridView1.Rows.Add(rows[0], rows[1], rows[2]);
            }
        }

        private string ReadDataFromTable()
        {
            var lines = string.Empty;
            var row = string.Empty;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    if (j != dataGridView1.Rows[i].Cells.Count - 1)
                        row = row + dataGridView1.Rows[i].Cells[j].Value + ";";
                    else
                        row = row + dataGridView1.Rows[i].Cells[j].Value + Environment.NewLine;
                }
                if (row != $";;{Environment.NewLine}")
                    lines = lines + row;
                row = string.Empty;
            }
            return lines;
        }
    }
}
        
