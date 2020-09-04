using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffsForm : Form
    {
        private DataTable table = new DataTable();
        private StaffService staffService = new StaffService(new StaffFileRepository());
        private List<Staff> staffs = new List<Staff>();
        private int selectedStaffID;
        private bool isChanged = false;
        private string mode = "edit";
        public Staff SelectedStaff;

        public StaffsForm()
        {
            InitializeComponent();
            SetFormProperties();
        }

        public StaffsForm(string mode) : this()
        {
            this.mode = mode;
            this.SelectedStaff = new Staff();
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
            staffs = staffService.GetData();
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
            staffService.UpdateData(staffs);
        }

        private void addButton_Click(object sender, EventArgs e)
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
            DeleteStaff();
        }

        private void DeleteStaff()
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей");
                return;
            }
            var result = MessageBox.Show("Удалить выбранную строку?", "Подтверждение операции", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (staffDataGridView.SelectedRows.Count == 1)
                {
                    CheckRelatedDocuments(SelectedStaff);
                    staffs.Remove(SelectedStaff);
                    UpdateTableRows(staffs);
                    UpdateStaffsData();
                }
            }
        }

        private void CheckRelatedDocuments(Staff selectedStaff)
        {
            TrainingService trainingService = new TrainingService(new TrainingFileRepository());
            SelfCheckService selfCheckService = new SelfCheckService(new SelfCheckFileRepository());
            var trainings = trainingService.GetData();
            var selfChecks = selfCheckService.GetData();
            foreach (var training in trainings)
            {
                if (training.StaffID == SelectedStaff.ID || training.TrainerID == SelectedStaff.ID)
                {
                    MessageBox.Show("Сотрудник не может быть удален, так как есть по крайней мере один документ об обучении, при заполнении которого данный сотрудник был выбран!");
                    return;
                }
            }
            foreach (var selfcheck in selfChecks)
            {
                if (selfcheck.ResponsiblePersonID == SelectedStaff.ID)
                {
                    MessageBox.Show("Сотрудник не может быть удален, так как есть по крайней мере один документ о присвоении самоконтроля, при заполнении которого данный сотрудник был выбран!");
                    return;
                }
            }
        }

        private void staffDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
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
            if (selectedStaffID > 0)
            {
                if (mode == "select")
                    Close();
                else
                {
                    var staffEditForm = new StaffEditForm(SelectedStaff);
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

        private void staffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                var selectedString = staffDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();
                selectedStaffID = int.Parse(selectedString);
                foreach (var staff in staffs)
                {
                    if (staff.ID == selectedStaffID)
                        SelectedStaff = staff;
                }
            }
        }
    }
}
