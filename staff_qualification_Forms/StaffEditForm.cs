using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffEditForm : Form
    {
        List<Staff> staffs;
        int index;
        string formMode = "add";

        public StaffEditForm()
        {
            InitializeComponent();
        }

        public void SetFormProperties(List<Staff> staffs, int index)
        {
            this.staffs = staffs;
            this.index = index;
            idTextBox.Text = staffs[index].id;
            nameTextBox.Text = staffs[index].name;
            positionTextBox.Text = staffs[index].position;
            formMode = "edit";
            this.Name = "Редактировать данные о сторуднике";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formMode == "edit")
            {
                staffs[index].id = idTextBox.Text;
                staffs[index].name = nameTextBox.Text;
                staffs[index].position = positionTextBox.Text;
                LoadData.WriteDataToFile(@"staff.txt", Staff.GetStaffsFormated(staffs), false);
            }
            else
            {
                var staffDataLines = $"{idTextBox.Text};{nameTextBox.Text};{positionTextBox.Text}{Environment.NewLine}";
                LoadData.WriteDataToFile(@"staff.txt", staffDataLines, true);
            }
            idTextBox.Text = String.Empty;
            idTextBox.Focus();
            nameTextBox.Text = String.Empty;
            positionTextBox.Text = String.Empty;
            idTextBox.Focus();
        }
    }
}
