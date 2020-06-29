using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffEditForm : Form
    {
        Staffs staffs;

        public StaffEditForm(Staffs staffs)
        {
            this.staffs = staffs;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.IsEmptyData())
            {
                var staff = new Staff
                {
                    ID = idTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    FirstName = firstNameTextBox.Text,
                    MiddleName = middleNameTextBox.Text,
                    Position = positionComboBox.Text
                };
                staffs.ListStaffs.Add(staff);
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные о сотруднике не заполнены!");
            }
            
        }

        private bool IsEmptyData()
        {
            return idTextBox.Text == String.Empty && lastNameTextBox.Text == String.Empty && positionComboBox.Text == String.Empty;
        }

        private void ClearForm()
        {
            idTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            positionComboBox.Text = String.Empty;
            idTextBox.Focus();
        }
    }
}
