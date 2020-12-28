using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewTrainingsForm : ViewQualificationForm
    {
        public Training SelectedTraining;
        private string selfCheckDate;
        private string selfCheckResponsiblePerson;
        private string selectedTrainingID;

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
                if (currentProject == null) continue;
                var currentModel = IdHelper.GetEntityByID(currentProject.Models, training.ModelID);
                if (currentModel == null) continue;
                var currentOperation = IdHelper.GetEntityByID(currentModel.Operations, training.OperationID);
                if (currentOperation == null) continue;

                if (currentStaff != null && currentTrainer != null && currentOperation != null)
                {
                    FillSelfCheckColumns(training);
                    var row = table.NewRow();
                    row["trainingID"] = training.ID.ToString();
                    row["Сотрудник"] = currentStaff.GetStaffFullName();
                    row["Проект"] = currentProject.Name;
                    row["Модель"] = currentModel.Name;
                    row["Операция"] = currentOperation.Name;
                    row["Инструктор"] = currentTrainer.GetStaffFullName();
                    row["Дата начала"] = training.StartDate.ToString("d");
                    row["Дата окончания"] = training.EndDate.ToString("d");
                    row["Дата присвоения самоконтроля"] = selfCheckDate;
                    row["Ответственный"] = selfCheckResponsiblePerson;
                    table.Rows.Add(row);
                }
            }
            bindingSource.DataSource = table;
            outputDataGridView.DataSource = bindingSource;
            outputDataGridView.Columns["trainingID"].Visible = false;
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
                        return;
                    }
                    return;
                }
            }
            selfCheckDate = "Не присвоен";
            selfCheckResponsiblePerson = "-";
        }

        protected override void outputDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
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
            var selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                selectedTrainingID = outputDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString();
                foreach (var training in trainings)
                {
                    if (training.ID.ToString() == selectedTrainingID)
                        SelectedTraining = training;
                }
            }
        }
    }
}
