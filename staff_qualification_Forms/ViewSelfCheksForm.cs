using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewSelfCheksForm : Form
    {
        private TrainingService trainingService = new TrainingService(new TrainingFileRepository());
        private ProjectService projectService = new ProjectService(new ProjectFileRepository());
        private StaffService staffService = new StaffService(new StaffFileRepository());
        private SelfCheckService selfCheckService = new SelfCheckService(new SelfCheckFileRepository());

        private List<SelfCheck> selfChecks = new List<SelfCheck>();
        private List<Training> trainings = new List<Training>();
        private List<Project> projects = new List<Project>();
        private List<Staff> staffs = new List<Staff>();

        private DataTable table = new DataTable();
        private BindingSource bindingSource = new BindingSource();

        public ViewSelfCheksForm()
        {
            InitializeComponent();
            GetListData();
            SetDataGridViewProperties();
            GetTableHeader();
            FillSelfChecksDataGridView();
        }

        private void GetListData()
        {
            trainings = trainingService.GetData();
            projects = projectService.GetData();
            staffs = staffService.GetData();
            selfChecks = selfCheckService.GetData();
        }

        private void SetDataGridViewProperties()
        {
            selfChecksDataGridView.Dock = DockStyle.Fill;
            selfChecksDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            selfChecksDataGridView.AllowUserToAddRows = false;
            selfChecksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GetTableHeader()
        {
            var staffColumn = new DataColumn("Сотрудник", typeof(string));
            var projectColumn = new DataColumn("Проект", typeof(string));
            var modelColumn = new DataColumn("Модель", typeof(string));
            var operationColumn = new DataColumn("Операция", typeof(string));
            var trainerColumn = new DataColumn("Инструктор", typeof(string));
            var responsiblePersonColumn = new DataColumn("Ответственный", typeof(string));
            var startTrainingDate = new DataColumn("Дата начала обучения", typeof(DateTime));
            var endTrainingDate = new DataColumn("Дата окончания обучения", typeof(DateTime));
            var selfCheckDate = new DataColumn("Дата присвоения самоконтроля", typeof(DateTime));

            table.Columns.Add(staffColumn);
            table.Columns.Add(projectColumn);
            table.Columns.Add(modelColumn);
            table.Columns.Add(operationColumn);
            table.Columns.Add(trainerColumn);
            table.Columns.Add(responsiblePersonColumn);
            table.Columns.Add(startTrainingDate);
            table.Columns.Add(endTrainingDate);
            table.Columns.Add(selfCheckDate);

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }
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
                    currentResponsiblePerson.GetStaffFullName(),
                    currentTraining.StartDate,
                    currentTraining.EndDate,
                    selfCheck.Date);
            }

            bindingSource.DataSource = table;
            selfChecksDataGridView.DataSource = bindingSource;
        }
    }
}
