﻿using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewTrainingsForm : ViewQualificationForm
    {
        public Training SelectedTraining;
        private string selfCheckDate;
        private string selfCheckResponsiblePerson;

        public ViewTrainingsForm()
        {
            InitializeComponent();
            FillTrainingsDataGridView();
        }

        public ViewTrainingsForm(string mode) : this()
        {
            this.mode = mode;
            SelectedTraining = new Training();
        }

        private void FillTrainingsDataGridView()
        {
            table.Rows.Clear();
            if (trainings == null)
                return;
            foreach (var training in trainings)
            {
                var currentStaff = Staff.GetStaffByID(training.StaffID, staffs);
                var currentTrainer = Staff.GetStaffByID(training.TrainerID, staffs);
                var currentProject = IdHelper.GetEntityByID(projects, training.ProjectID);
                var currentModel = IdHelper.GetEntityByID(currentProject.Models, training.ModelID);
                var currentOperation = IdHelper.GetEntityByID(currentModel.Operations, training.OperationID);

                if (currentStaff != null && currentTrainer != null && currentOperation != null)
                {
                    FillSelfCheckColumns(training);

                    table.Rows.Add
                        (currentStaff.GetStaffFullName(),
                        currentProject.Name,
                        currentModel.Name,
                        currentOperation.Name,
                        currentTrainer.GetStaffFullName(),
                        training.StartDate.ToString("d"),
                        training.EndDate.ToString("d"),
                        selfCheckDate,
                        selfCheckResponsiblePerson);
                }
            }

            bindingSource.DataSource = table;
            outputDataGridView.DataSource = bindingSource;
        }

        private void FillSelfCheckColumns(Training training)
        {
            foreach (var selfCheck in selfChecks)
            {
                if (selfCheck.TrainingID == training.ID)
                {
                    selfCheckDate = selfCheck.Date.ToString("d");
                    var currentResponsiblePerson = Staff.GetStaffByID(selfCheck.ResponsiblePersonID, staffs);
                    if (currentResponsiblePerson != null)
                    {
                        selfCheckResponsiblePerson = currentResponsiblePerson.GetStaffFullName();
                        break;
                    }
                    break;
                }
                else
                {
                    selfCheckDate = "Не присвоен";
                    selfCheckResponsiblePerson = "-";
                }
            }
        }

        protected override void outputDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            if (index >= 0)
                SelectedTraining = trainings[index];
            if (mode == "select")
                Close();
            else
            {
                var trainingForm = new TrainingForm(SelectedTraining);
                trainingForm.ShowDialog();
                FillTrainingsDataGridView();
            }
        }

        protected override void outputDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
