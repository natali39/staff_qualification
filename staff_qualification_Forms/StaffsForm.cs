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
        int selectedRowIndex;
        bool isChanged = false;
        string mode = "edit";
        public Staff staff;

        public StaffsForm()
        {
            InitializeComponent();
            SetFormProperties();
        }

        public StaffsForm(string mode) : this()
        {
            this.mode = mode;
            this.staff = new Staff();
            addButton.Visible = false;
            deleteButton.Visible = false;
            saveButton.Visible = false;
        }

        public void SetFormProperties()
        {
            GetTable();
            staffDataGridView.DataSource = table;
            staffDataGridView.AllowUserToAddRows = false;
            staffDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGridView.MultiSelect = false;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            UpdateStaffsData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей");
                return;
            }
            var result = MessageBox.Show("Удалить выбранную строку?", "Подтверждение операции", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteStaff();
            }
        }

        private void DeleteStaff()
        {
            if (staffDataGridView.SelectedRows.Count > 0)
            {
                staffs.RemoveAt(selectedRowIndex);
                UpdateTableRows(staffs);
                UpdateStaffsData();
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
                if (mode == "select")
                {
                    staff = staffs[index];
                    Close();
                }
                else
                {
                    var staffEditForm = new StaffEditForm(staffs[index]);
                    staffEditForm.ShowDialog();
                    UpdateTableRows(staffs);
                    UpdateStaffsData();
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTableRows(Staff.SearchByLastName(staffs, searchTextBox.Text));
        }

        private void staffDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    DeleteStaff();
            //}
        }

        private void staffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }
    }
}
