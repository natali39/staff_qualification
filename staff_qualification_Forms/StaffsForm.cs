using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffsForm : Form
    {
        private DataTable table = new DataTable();
        private StaffService staffService = new StaffService(new StaffDBRepository());
        private List<Staff> staffs = new List<Staff>();
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
            SelectedStaff = new Staff();
            addButton.Visible = false;
            deleteButton.Visible = false;
            editButton.Visible = false;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (staffs == null)
            {
                staffs = new List<Staff>();
            }
            StaffEditForm staffEditForm = new StaffEditForm();
            staffEditForm.ShowDialog();
            if (staffEditForm.staff != null)
            {
                var staff = staffService.AddStaff(staffEditForm.staff);
                staffs.Add(staff);
                UpdateTableRows(staffs);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (TableIsEmpty())
                return;
            if (staffDataGridView.SelectedRows.Count == 1)
            {
                var index = staffDataGridView.SelectedRows[0].Index;
                SelectedStaff = SelectStaff(index);
                EditStaff();
            }
        }

        private void EditStaff()
        {
            var staffEditForm = new StaffEditForm(SelectedStaff);
            staffEditForm.ShowDialog();
            staffService.UpdateStaff(SelectedStaff);
            UpdateTableRows(staffs);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (TableIsEmpty())
                return;

            var result = MessageBox.Show("Удалить выбранную строку?", "Подтверждение операции", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (staffDataGridView.SelectedRows.Count == 1)
                {
                    var index = staffDataGridView.SelectedRows[0].Index;
                    SelectedStaff = SelectStaff(index);
                }
            }
            if (SelectedStaff != null)
                DeleteStaff();
        }

        private void DeleteStaff()
        {
            if (CheckRelatedDocuments(SelectedStaff))
                return;
            staffs.Remove(SelectedStaff);
            staffService.RemoveStaff(SelectedStaff);
            UpdateTableRows(staffs);
        }

        private bool TableIsEmpty()
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("В таблице нет записей");
                return true;
            }
            return false;
        }

        private bool CheckRelatedDocuments(Staff staff)
        {
            TrainingService trainingService = new TrainingService(new TrainingDbRepository());
            SelfCheckService selfCheckService = new SelfCheckService(new SelfCheckDbRepository());
            var trainings = trainingService.GetData();
            var selfChecks = selfCheckService.GetData();
            foreach (var training in trainings)
            {
                if (training.StaffID == staff.ID || training.TrainerID == staff.ID)
                {
                    MessageBox.Show("Сотрудник не может быть удален, так как есть по крайней мере один документ об обучении, при заполнении которого данный сотрудник был выбран!");
                    return true;
                }
            }
            foreach (var selfcheck in selfChecks)
            {
                if (selfcheck.ResponsiblePersonID == staff.ID)
                {
                    MessageBox.Show("Сотрудник не может быть удален, так как есть по крайней мере один документ о присвоении самоконтроля, при заполнении которого данный сотрудник был выбран!");
                    return true;
                }
            }
            return false;
        }

        private void staffDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void staffDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0)
                return;
            SelectedStaff = SelectStaff(index);
            if (SelectedStaff.ID > 0)
            {
                if (mode == "select")
                    Close();
                else
                {
                    EditStaff();
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
                SelectedStaff = SelectStaff(selectedRowIndex);
            }
        }

        private Staff SelectStaff(int rowIndex)
        {
            var selectedStaffID = 0;
            var convertId = int.TryParse(staffDataGridView.Rows[rowIndex].Cells[0].Value.ToString(), out selectedStaffID);
            
            foreach (var staff in staffs)
            {
                if (staff.ID == selectedStaffID)
                    SelectedStaff = staff;
            }
            return SelectedStaff;
        }

    }
}
