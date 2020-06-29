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
        Staffs staffs = new Staffs();

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
            table.Columns.Add("Табельный номер");
            table.Columns.Add("Фамилия");
            table.Columns.Add("Имя");
            table.Columns.Add("Отчество");
            table.Columns.Add("Должность");
        }

        private void GetTableRows(Staffs staffs)
        {
            table.Rows.Clear();
            if (staffs != null && staffs.ListStaffs != null)
            foreach (var staff in staffs.ListStaffs)
            {
                table.Rows.Add(staff.ID, staff.LastName, staff.FirstName, staff.MiddleName, staff.Position);
            }
        }

        private void SaveTableChanges()
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                staffs.ListStaffs[i].ID = table.Rows[i].ItemArray[0].ToString();
                staffs.ListStaffs[i].LastName = table.Rows[i].ItemArray[1].ToString();
                staffs.ListStaffs[i].FirstName = table.Rows[i].ItemArray[2].ToString();
                staffs.ListStaffs[i].MiddleName = table.Rows[i].ItemArray[3].ToString();
                staffs.ListStaffs[i].Position = table.Rows[i].ItemArray[4].ToString();
            }
        }

        private void UpdateStaffsData()
        {
            service.UpdateData(staffs);
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            StaffEditForm staffEditForm = new StaffEditForm(staffs);
            staffEditForm.ShowDialog();
            if (staffs.ListStaffs.Count > table.Rows.Count)
            {
                var staff = staffs.ListStaffs[staffs.ListStaffs.Count - 1];
                table.Rows.Add(staff.ID, staff.LastName, staff.FirstName, staff.MiddleName, staff.Position);
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
                    staffs.ListStaffs.RemoveAt(currentIndex);
                    staffDataGridView.Rows.RemoveAt(currentIndex);
                }
            }
            catch
            {
                MessageBox.Show("В таблице нет записей");
            }
        }

        private void StaffsForm_FormClosing(object sender, FormClosingEventArgs e)
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
}
