using System;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class SelfCheckForm : Form
    {
        SelfCheck selfCheck = new SelfCheck();
        Training training;

        public SelfCheckForm()
        {
            InitializeComponent();

            selfCheckDateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void selectTrainingButton_Click(object sender, EventArgs e)
        {
            ViewTrainingsForm allTrainingsForm = new ViewTrainingsForm();
            allTrainingsForm.ShowDialog();
            training = allTrainingsForm.Training;
            trainingTextBox.Text = training.ID.ToString();
        }

        private void responsiblePersonButton_Click(object sender, EventArgs e)
        {
            StaffsForm staffsForm = new StaffsForm("select");
            staffsForm.ShowDialog();
            selfCheck.ResponsiblePerson = staffsForm.Staff;
            responsiblePersonTextBox.Text = selfCheck.ResponsiblePerson.GetStaffFullName();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selfCheck.Date = selfCheckDateTimePicker.Value;
        }
    }
}
