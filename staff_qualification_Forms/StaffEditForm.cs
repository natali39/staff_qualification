using System;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class StaffEditForm : Form
    {
        public Staff staff;

        public StaffEditForm()
        {
            InitializeComponent();
            GetFormProperties();
        }

        public StaffEditForm(int id) : this()
        {
            this.staff = new Staff();
            idTextBox.Text = id.ToString();
        }

        public StaffEditForm(Staff staff) : this()
        {
            this.staff = staff;
            FillFormControls();
        }

        private void GetFormProperties()
        {
            positionComboBox.DataSource = Enum.GetValues(typeof(Positions));
            positionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            idTextBox.ReadOnly = true;
        }

        private void FillFormControls()
        {
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
                staff.ID = int.Parse(idTextBox.Text);
                staff.LastName = lastNameTextBox.Text;
                staff.FirstName = firstNameTextBox.Text;
                staff.MiddleName = middleNameTextBox.Text;
                staff.Position = (Positions)Enum.Parse(typeof(Positions), positionComboBox.SelectedValue.ToString());
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
    }
}
