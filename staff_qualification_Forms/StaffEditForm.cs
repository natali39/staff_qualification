using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffEditForm : Form
    {
        List<Staff> staffs;
        private int index;
        private bool editMode = false;

        public StaffEditForm(List<Staff> staffs)
        {
            this.staffs = staffs;
            InitializeComponent();
            GetFormProperties();
        }

        public StaffEditForm(List<Staff> staffs, int index) : this(staffs)
        {
            this.index = index;
            FillFormControls();
            editMode = true;
        }

        private void GetFormProperties()
        {
            idTextBox.Text = Staff.GetNextId(staffs).ToString();
            positionComboBox.DataSource = Enum.GetValues(typeof(Positions));
            positionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            idTextBox.ReadOnly = true;
        }

        private void FillFormControls()
        {
            var staff = staffs[index];
            idTextBox.Text = staff.ID.ToString();
            lastNameTextBox.Text = staff.LastName;
            firstNameTextBox.Text = staff.FirstName;
            middleNameTextBox.Text = staff.MiddleName;
            positionComboBox.Text = staff.Position.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!IsEmptyData())
            {
                if (editMode == true)
                {
                    var staff = staffs[index];
                    staff.LastName = lastNameTextBox.Text;
                    staff.FirstName = firstNameTextBox.Text;
                    staff.MiddleName = middleNameTextBox.Text;
                    staff.Position = (Positions)Enum.Parse(typeof(Positions), positionComboBox.SelectedValue.ToString());
                }
                if (editMode == false)
                {
                    var staff = new Staff
                    {
                        ID = int.Parse(idTextBox.Text),
                        LastName = lastNameTextBox.Text,
                        FirstName = firstNameTextBox.Text,
                        MiddleName = middleNameTextBox.Text,
                        Position = (Positions)Enum.Parse(typeof(Positions), positionComboBox.SelectedValue.ToString())
                    };
                    staffs.Add(staff);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные о сотруднике не заполнены!");
            }
        }

        private bool IsEmptyData()
        {
            return idTextBox.Text == String.Empty || lastNameTextBox.Text == String.Empty || firstNameTextBox.Text == String.Empty || positionComboBox.Text == String.Empty;
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
