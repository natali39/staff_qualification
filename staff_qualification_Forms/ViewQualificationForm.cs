using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewQualificationForm : Form
    {
        protected TrainingService trainingService = new TrainingService(new TrainingFileRepository());
        protected ProjectService projectService = new ProjectService(new ProjectFileRepository());
        protected StaffService staffService = new StaffService(new StaffFileRepository());
        protected SelfCheckService selfCheckService = new SelfCheckService(new SelfCheckFileRepository());
        protected List<SelfCheck> selfChecks = new List<SelfCheck>();
        protected List<Training> trainings = new List<Training>();
        protected List<Project> projects = new List<Project>();
        protected List<Staff> staffs = new List<Staff>();
        protected string mode = "edit";
        public DataTable table = new DataTable();
        public BindingSource bindingSource = new BindingSource();

        public ViewQualificationForm()
        {
            InitializeComponent();
            GetListData();
            SetDataGridViewProperties();
            GetTableColumns();
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
            outputDataGridView.Dock = DockStyle.Fill;
            outputDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            outputDataGridView.AllowUserToAddRows = false;
            outputDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            outputDataGridView.MultiSelect = false;
        }

        private void GetTableColumns()
        {
            var staffColumn = new DataColumn("Сотрудник", typeof(string));
            var projectColumn = new DataColumn("Проект", typeof(string));
            var modelColumn = new DataColumn("Модель", typeof(string));
            var operationColumn = new DataColumn("Операция", typeof(string));
            var trainerColumn = new DataColumn("Инструктор", typeof(string));
            var startTrainingDateColumn = new DataColumn("Дата начала", typeof(string));
            var endTrainingDateColumn = new DataColumn("Дата окончания", typeof(string));
            var selfCheckDateColumn = new DataColumn("Дата присвоения самоконтроля", typeof(string));
            var responsiblePersonColumn = new DataColumn("Ответственный", typeof(string));

            table.Columns.Add(staffColumn);
            table.Columns.Add(projectColumn);
            table.Columns.Add(modelColumn);
            table.Columns.Add(operationColumn);
            table.Columns.Add(trainerColumn);
            table.Columns.Add(startTrainingDateColumn);
            table.Columns.Add(endTrainingDateColumn);
            table.Columns.Add(selfCheckDateColumn);
            table.Columns.Add(responsiblePersonColumn);

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }
        }

        protected virtual void outputDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        protected virtual void outputDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
