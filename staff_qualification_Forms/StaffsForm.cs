using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffsForm : Form
    {
        DataTable table = new DataTable();
        StaffService service = new StaffService(new StaffFileRepository());
        List<Staff> staffs = new List<Staff>();
        bool isChanged = false;

        public StaffsForm()
        {
            InitializeComponent();
            SetFormProperties();
        }

        public void SetFormProperties()
        {
            GetTable();
            staffDataGridView.DataSource = table;
            staffDataGridView.AllowUserToAddRows = false;
            staffDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GetTable()
        {
            staffs = service.GetData();
            GetTableHeader();
            GetTableRows(staffs);
        }

        private void GetTableHeader()
        {
            var idColumn = new DataColumn("Табельный номер", typeof(int));
            idColumn.ReadOnly = true;
            table.Columns.Add(idColumn);
            table.Columns.Add("Фамилия");
            table.Columns.Add("Имя");
            table.Columns.Add("Отчество");
            var positionColumn = new DataColumn("Должность", typeof(Positions));
            positionColumn.ReadOnly = true;
            table.Columns.Add(positionColumn);
        }

        private void GetTableRows(List<Staff> staffs)
        {
            table.Rows.Clear();
            if (staffs != null && staffs != null)
                foreach (var staff in staffs)
                {
                    table.Rows.Add(staff.ID, staff.LastName, staff.FirstName, staff.MiddleName, staff.Position);
                }
        }

        private void SaveTableChanges()
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                staffs[i].ID = int.Parse(table.Rows[i].ItemArray[0].ToString());
                staffs[i].LastName = table.Rows[i].ItemArray[1].ToString();
                staffs[i].FirstName = table.Rows[i].ItemArray[2].ToString();
                staffs[i].MiddleName = table.Rows[i].ItemArray[3].ToString();
                staffs[i].Position = (Positions)table.Rows[i].ItemArray[4];
            }
        }

        private void UpdateStaffsData()
        {
            service.UpdateData(staffs);
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            if (staffs == null)
            {
                staffs = new List<Staff>();
            }
            StaffEditForm staffEditForm = new StaffEditForm(staffs);
            staffEditForm.ShowDialog();
            if (staffs.Count > table.Rows.Count)
            {
                var staff = staffs[staffs.Count - 1];
                table.Rows.Add(staff.ID, staff.LastName, staff.FirstName, staff.MiddleName, staff.Position);
                isChanged = true;
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            SaveTableChanges();
            UpdateStaffsData();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var currentIndex = staffDataGridView.CurrentRow.Index;
                var result = MessageBox.Show("Удалить запись?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    staffs.RemoveAt(currentIndex);
                    staffDataGridView.Rows.RemoveAt(currentIndex);
                    isChanged = true;
                }
            }
            catch
            {
                MessageBox.Show("В таблице нет записей");
            }
        }

        private void StaffsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                var result = MessageBox.Show("Сохранить изменения в списке сотрудников?", "Сотрудники", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveTableChanges();
                    UpdateStaffsData();
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void staffDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                var staffEditForm = new StaffEditForm(staffs, index);
                staffEditForm.ShowDialog();
                GetTableRows(staffs);
            }
        }

        private void staffDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isChanged = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < staffDataGridView.RowCount; i++)
            {
                staffDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < staffDataGridView.ColumnCount; j++)
                {
                    if (staffDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        if (staffDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                        {
                            staffDataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
