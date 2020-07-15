using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            UpdateTableRows(staffs);
        }

        private void GetTableHeader()
        {
            var idColumn = new DataColumn("Табельный номер", typeof(int));
            var lastNameColumn = new DataColumn("Фамилия", typeof(string));
            var firstNameColumn = new DataColumn("Имя", typeof(string));
            var middlNameColumn = new DataColumn("Отчество", typeof(string));
            var positionColumn = new DataColumn("Должность", typeof(string));

            table.Columns.Add(idColumn);
            table.Columns.Add(lastNameColumn);
            table.Columns.Add(firstNameColumn);
            table.Columns.Add(middlNameColumn);
            table.Columns.Add(positionColumn);

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void UpdateTableRows(List<Staff> staffs)
        {
            table.Rows.Clear();
            if (staffs != null)
                foreach (var staff in staffs)
                {
                    var positionDisplayName = DisplayPositions.GetPositionDisplayName(staff.Position);
                    table.Rows.Add(staff.ID, staff.LastName, staff.FirstName, staff.MiddleName, positionDisplayName);
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
            if (staffEditForm.staff != null)
            {
                staffs.Add(staffEditForm.staff);
                UpdateTableRows(staffs);
                UpdateStaffsData();
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            UpdateStaffsData();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Удалить выделенные строки?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteSelectedRows();
                    UpdateTableRows(staffs);
                    UpdateStaffsData();
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
                UpdateTableRows(staffs);
                UpdateStaffsData();
            }
        }

        private void DeleteSelectedRows()
        {
            var listSelectedIndex = new List<int>();
            foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
            {
                listSelectedIndex.Add(row.Index);
            }
            var sortedListIndex = listSelectedIndex.OrderByDescending(index => index);
            foreach (var index in sortedListIndex)
            {
                staffs.RemoveAt(index);
                staffDataGridView.Rows[index - 1].Selected = true;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTableRows(Staff.SearchLastName(staffs, searchTextBox.Text));
        }
    }
}
