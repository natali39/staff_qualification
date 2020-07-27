using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class TrainingForm : Form
    {
        Training training = new Training();
        ProjectService projectService = new ProjectService(new ProjectFileRepository());
        TrainingService trainingService = new TrainingService(new TrainingFileRepository());
        List<Training> trainings;

        public TrainingForm()
        {
            InitializeComponent();
            trainings = trainingService.GetData();
            if (trainings == null)
                trainings = new List<Training>();
            GetFormProperties();
        }

        private void GetFormProperties()
        {
            training.ID = Training.GetNextID(trainings);
            trainingIdTextBox.Text = training.ID.ToString();

            var projects = projectService.GetData();
            var models = new List<Model>();

            projectComboBox.DataSource = projects;
            projectComboBox.DisplayMember = "Name";
            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            modelComboBox.DisplayMember = "Name";
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            operationComboBox.DisplayMember = "Name";
            operationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            startTrainingDateTimePicker.Format = DateTimePickerFormat.Short;
            endTrainingDateTimePicker.Format = DateTimePickerFormat.Short;
        }

        private void selectStaffButton_Click(object sender, EventArgs e)
        {
            training.Staff = SelectStaff();
            staffNameTextBox.Text = training.Staff.GetStaffFullName();
        }

        private void selectTrainerButton_Click(object sender, EventArgs e)
        {
            training.Trainer = SelectStaff();
            trainerTextBox.Text = training.Trainer.GetStaffFullName();
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            training.Project = (Project)projectComboBox.SelectedItem;
            modelComboBox.DataSource = training.Project.Models;
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            training.Model = (Model)modelComboBox.SelectedItem;
            operationComboBox.DataSource = training.Model.Operations;
        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            training.Operation = (Operation)operationComboBox.SelectedItem;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                trainings.Add(training);
                trainingService.UpdateData(trainings);
                Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private bool IsEmpty()
        {
            return training.Staff == null
                || training.Trainer == null
                || training.Project == null
                || training.Operation == null
                || training.StartDate == training.EndDate;
        }

        private Staff SelectStaff()
        {
            StaffsForm staffsForm = new StaffsForm("select");
            staffsForm.ShowDialog();
            return staffsForm.Staff;
        }

        private void startTrainingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            training.StartDate = startTrainingDateTimePicker.Value;
        }

        private void endTrainingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            training.EndDate = endTrainingDateTimePicker.Value;
        }
    }
}
