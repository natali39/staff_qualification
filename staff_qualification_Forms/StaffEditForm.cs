using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffEditForm : Form
    {
        public Staff staff;
        private bool isSaved;
        private bool isChanged;

        public StaffEditForm()
        {
            InitializeComponent();
            GetFormProperties();
        }

        public StaffEditForm(int id) : this()
        {
            idTextBox.Text = id.ToString();
        }

        public StaffEditForm(Staff staff) : this()
        {
            this.staff = staff;
            FillFormControls();
            isChanged = false;
        }

        private void GetFormProperties()
        {
            positionComboBox.DataSource = DisplayPositions.GetListDisplayPositions();
            positionComboBox.DisplayMember = "Description";
            positionComboBox.ValueMember = "Position";
            positionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            idTextBox.ReadOnly = true;
        }

        private void FillFormControls()
        {
            idTextBox.Text = staff.ID.ToString();
            lastNameTextBox.Text = staff.LastName;
            firstNameTextBox.Text = staff.FirstName;
            middleNameTextBox.Text = staff.MiddleName;
            positionComboBox.Text = DisplayPositions.GetPositionDisplayName(staff.Position).ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!IsEmptyData())
            {
                SaveStaff();
                isSaved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные о сотруднике не заполнены!");
            }
        }

        private void StaffEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (isChanged)
                {
                    var result = MessageBox.Show("Сохранить данные о сотруднике?", "Сотрудник", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        if (!IsEmptyData())
                        {
                            SaveStaff();
                        }
                        else
                        {
                            MessageBox.Show("Данные о сотруднике не заполнены!");
                            e.Cancel = true;
                        }
                    }
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private bool IsEmptyData()
        {
            return idTextBox.Text == String.Empty || lastNameTextBox.Text == String.Empty || firstNameTextBox.Text == String.Empty || positionComboBox.Text == String.Empty;
        }

        private void SaveStaff()
        {
            if (staff == null)
            {
                this.staff = new Staff();
            }
            staff.ID = int.Parse(idTextBox.Text);
            staff.LastName = lastNameTextBox.Text;
            staff.FirstName = firstNameTextBox.Text;
            staff.MiddleName = middleNameTextBox.Text;
            staff.Position = (Positions)Enum.Parse(typeof(Positions), positionComboBox.SelectedValue.ToString());
        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
    }
}
