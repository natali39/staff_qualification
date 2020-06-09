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
            idTextBox.Text = staffs[index].ID;
            nameTextBox.Text = staffs[index].Name;
            positionTextBox.Text = staffs[index].Position;
            formMode = "edit";
            this.Text = "Редактировать данные о сторуднике";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (formMode == "edit")
            {
                staffs[index].ID = idTextBox.Text;
                staffs[index].Name = nameTextBox.Text;
                staffs[index].Position = positionTextBox.Text;
                FileProvider.WriteDataToFile(FilePaths.StaffPath, Staff.GetStaffsFormated(staffs), false);
                this.Close();
            }
            else
            {
                var result = DialogResult.None;
                if (this.IsEmptyData())
                    result = MessageBox.Show("Поля не заполнены. Продолжить?", "Подтверждение операции", MessageBoxButtons.YesNo);
                if (!this.IsEmptyData() || result == DialogResult.Yes)
                {
                    var staffDataLines = $"{idTextBox.Text};{nameTextBox.Text};{positionTextBox.Text}{Environment.NewLine}";
                    FileProvider.WriteDataToFile(FilePaths.StaffPath, staffDataLines, true);
                    ClearForm();
                }
            }
        }

        private bool IsEmptyData()
        {
            return idTextBox.Text == String.Empty && nameTextBox.Text == String.Empty && positionTextBox.Text == String.Empty;
        }

        private void ClearForm()
        {
            idTextBox.Text = String.Empty;
            idTextBox.Focus();
            nameTextBox.Text = String.Empty;
            positionTextBox.Text = String.Empty;
            idTextBox.Focus();
        }
    }
}
