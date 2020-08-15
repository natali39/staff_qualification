using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewSelfCheksForm : ViewQualificationForm
    {
        public ViewSelfCheksForm()
        {
            InitializeComponent();
            FillSelfChecksDataGridView();
        }

        private void FillSelfChecksDataGridView()
        {
            if (selfChecks == null)
                return;

            foreach (var selfCheck in selfChecks)
            {
                var currentTraining = IdHelper.GetEntityByID(trainings, selfCheck.TrainingID);
                var currentStaff = Staff.GetStaffByID(currentTraining.StaffID, staffs);
                var currentTrainer = Staff.GetStaffByID(currentTraining.TrainerID, staffs);
                var currentResponsiblePerson = Staff.GetStaffByID(selfCheck.ResponsiblePersonID, staffs);
                var currentProject = IdHelper.GetEntityByID(projects, currentTraining.ProjectID);
                var currentModel = IdHelper.GetEntityByID(currentProject.Models, currentTraining.ModelID);
                var currentOperation = IdHelper.GetEntityByID(currentModel.Operations, currentTraining.OperationID);

                table.Rows.Add
                    (currentStaff.GetStaffFullName(),
                    currentProject.Name,
                    currentModel.Name,
                    currentOperation.Name,
                    currentTrainer.GetStaffFullName(),
                    currentTraining.StartDate.ToString("d"),
                    currentTraining.EndDate.ToString("d"),
                    selfCheck.Date.ToString("d"),
                    currentResponsiblePerson.GetStaffFullName());
            }
            bindingSource.DataSource = table;
            outputDataGridView.DataSource = bindingSource;
        }
    }
}
