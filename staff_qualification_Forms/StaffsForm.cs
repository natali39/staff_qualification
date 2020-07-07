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
            AddTableRows(staffs);
        }

        private void GetTableHeader()
        {
            var idColumn = new DataColumn("Табельный номер", typeof(int));
            table.Columns.Add(idColumn);
            var lastNameColumn = new DataColumn("Фамилия", typeof(string));
            table.Columns.Add(lastNameColumn);
            var firstNameColumn = new DataColumn("Имя", typeof(string));
            table.Columns.Add(firstNameColumn);
            var middlNameColumn = new DataColumn("Отчество", typeof(string));
            table.Columns.Add(middlNameColumn);
            var positionColumn = new DataColumn("Должность", typeof(Positions));
            table.Columns.Add(positionColumn);

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void AddTableRows(List<Staff> staffs)
        {
            table.Rows.Clear();
            if (staffs != null)
                foreach (var staff in staffs)
                {
                    table.Rows.Add(staff.ID, staff.LastName, staff.FirstName, staff.MiddleName, staff.Position);
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
            int id = Staff.GetNextId(staffs);
            StaffEditForm staffEditForm = new StaffEditForm(id);
            staffEditForm.ShowDialog();
            staffs.Add(staffEditForm.staff);
            AddTableRows(staffs);
            UpdateStaffsData();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
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
                var staffEditForm = new StaffEditForm(staffs[index]);
                staffEditForm.ShowDialog();
                AddTableRows(staffs);
                UpdateStaffsData();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            AddTableRows(Staff.SearchLastName(staffs, searchTextBox.Text));
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = String.Empty;
            AddTableRows(staffs);
        }
    }
}
