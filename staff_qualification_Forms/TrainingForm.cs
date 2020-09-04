﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class TrainingForm : Form
    {
        Training training = new Training();
        int defaultTrainingPeriod = 3;
        ProjectService projectService = new ProjectService(new ProjectFileRepository());
        TrainingService trainingService = new TrainingService(new TrainingFileRepository());
        List<Training> trainings;
        TrainingReport trainingReport;

        public TrainingForm()
        {
            InitializeComponent();
            trainings = trainingService.GetData();
            if (trainings == null)
                trainings = new List<Training>();
            trainingReport = new TrainingReport();
            GetFormProperties();
        }

        private void GetFormProperties()
        {
            var projects = projectService.GetData();

            projectComboBox.DataSource = projects;
            projectComboBox.DisplayMember = "Name";
            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            modelComboBox.DisplayMember = "Name";
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            operationComboBox.DisplayMember = "Name";
            operationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            startTrainingDateTimePicker.Format = DateTimePickerFormat.Short;
            startTrainingDateTimePicker.Value = DateTime.Now;
            endTrainingDateTimePicker.Format = DateTimePickerFormat.Short;
            endTrainingDateTimePicker.Value = DateTime.Now.AddDays(defaultTrainingPeriod);
        }

        private void selectStaffButton_Click(object sender, EventArgs e)
        {
            var staff = SelectStaff();
            training.StaffID = staff.ID;
            staffNameTextBox.Text = staff.GetStaffFullName();
        }

        private void selectTrainerButton_Click(object sender, EventArgs e)
        {
            var trainer = SelectStaff();
            training.TrainerID = trainer.ID;
            trainerTextBox.Text = trainer.GetStaffFullName();
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var project = (Project)projectComboBox.SelectedItem;
            training.ProjectID = project.ID;
            modelComboBox.DataSource = project.Models;
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = (Model)modelComboBox.SelectedItem;
            training.ModelID = model.ID;
            operationComboBox.DataSource = model.Operations;
        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var operation = (Operation)operationComboBox.SelectedItem;
            training.OperationID = operation.ID;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            if (IncorrectDate())
            {
                MessageBox.Show("Сроки обучения введены неверно!");
                return;
            }

            CheckForUnique();

            IdHelper.TryUpdateId(training);
            trainings.Add(training);
            trainingService.UpdateData(trainings);
            Close();
        }

        private void CheckForUnique()
        {
            foreach (var existingTraining in trainings)
            {
                if (training.OperationID == existingTraining.OperationID
                    && training.StaffID == existingTraining.StaffID)
                {
                    MessageBox.Show("Такое обучение уже существует! Проверьте корректность введенных данных.");
                    return;
                }
            }
        }

        private bool IsEmpty()
        {
            return training.StaffID == 0
                || training.TrainerID == 0
                || training.ProjectID == Guid.Empty
                || training.ModelID == Guid.Empty
                || training.OperationID == Guid.Empty;
        }

        private bool IncorrectDate()
        {
            return training.StartDate > training.EndDate
                || training.StartDate.AddDays(defaultTrainingPeriod) > training.EndDate;
        }

        private Staff SelectStaff()
        {
            var selectedStaff = new Staff();
            StaffsForm staffsForm = new StaffsForm("select");
            staffsForm.ShowDialog();
            selectedStaff = staffsForm.SelectedStaff;
            return selectedStaff;
        }

        private void startTrainingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            training.StartDate = startTrainingDateTimePicker.Value;
        }

        private void endTrainingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            training.EndDate = endTrainingDateTimePicker.Value;
        }

        private void generateDocumentButton_Click(object sender, EventArgs e)
        {
            trainingReport.StaffID = training.StaffID.ToString();
            trainingReport.StaffName = staffNameTextBox.Text;
            trainingReport.Trainer = trainerTextBox.Text;
            trainingReport.ModelDescription = $"{projectComboBox.Text} {modelComboBox.Text}";
            trainingReport.Operation = operationComboBox.Text.ToLower();
            trainingReport.Date = training.StartDate.ToString("d");
            trainingReport.EndDate = training.EndDate.ToString("d");

            trainingReport.FillTrainingDocument();
        }
    }
}
