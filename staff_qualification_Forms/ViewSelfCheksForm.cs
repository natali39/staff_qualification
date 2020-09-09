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

                if (currentStaff != null && currentTrainer != null && currentResponsiblePerson != null && currentOperation != null)
                {
                    var row = table.NewRow();
                    row["trainingID"] = currentTraining.ID.ToString();
                    row["Сотрудник"] = currentStaff.GetStaffFullName();
                    row["Проект"] = currentProject.Name;
                    row["Модель"] = currentModel.Name;
                    row["Операция"] = currentOperation.Name;
                    row["Инструктор"] = currentTrainer.GetStaffFullName();
                    row["Дата начала"] = currentTraining.StartDate.ToString("d");
                    row["Дата окончания"] = currentTraining.EndDate.ToString("d");
                    row["Дата присвоения самоконтроля"] = selfCheck.Date.ToString("d");
                    row["Ответственный"] = currentResponsiblePerson.GetStaffFullName();
                    table.Rows.Add(row);
                }
            }
            bindingSource.DataSource = table;
            outputDataGridView.DataSource = bindingSource;
            outputDataGridView.Columns["trainingID"].Visible = false;
        }
    }
}
