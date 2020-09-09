using System;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class InputProjectNameForm : Form
    {
        public string Name;

        public InputProjectNameForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (addProjectNameTextBox.Text != String.Empty)
            {
                Name = addProjectNameTextBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Нужно ввести название проекта!");
            }
        }

        private void InputProjectNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addProjectNameTextBox.Text == String.Empty)
            {
                Name = null;
            }
        }
    }
}
