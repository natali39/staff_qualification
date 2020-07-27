using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewTrainingsForm : Form
    {
        public Training Training;
        private TrainingService trainingService = new TrainingService(new TrainingFileRepository());
        private List<Training> trainings = new List<Training>();
        private DataTable table = new DataTable();
        private BindingSource bindingSource = new BindingSource();

        public ViewTrainingsForm()
        {
            InitializeComponent();
            trainings = trainingService.GetData();
            FillTrainingsDataGridView();
        }

        private void FillTrainingsDataGridView()
        {
            trainingsDataGridView.Dock = DockStyle.Fill;
            trainingsDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            trainingsDataGridView.AllowUserToAddRows = false;
            trainingsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var idColumn = new DataColumn("Номер документа", typeof(int));
            var staffColumn = new DataColumn("Сотрудник", typeof(string));
            var projectColumn = new DataColumn("Проект", typeof(string));
            var modelColumn = new DataColumn("Модель", typeof(string));
            var operationColumn = new DataColumn("Операция", typeof(string));
            var trainerColumn = new DataColumn("Инструктор", typeof(string));
            var startTrainingDate = new DataColumn("Дата начала", typeof(DateTime));
            var endTrainingDate = new DataColumn("Дата окончания", typeof(DateTime));

            table.Columns.Add(idColumn);
            table.Columns.Add(staffColumn);
            table.Columns.Add(projectColumn);
            table.Columns.Add(modelColumn);
            table.Columns.Add(operationColumn);
            table.Columns.Add(trainerColumn);
            table.Columns.Add(startTrainingDate);
            table.Columns.Add(endTrainingDate);

            foreach (DataColumn column in table.Columns)
            {
                column.ReadOnly = true;
            }

            if (trainings != null)
                foreach (var training in trainings)
                {
                    table.Rows.Add
                        (training.ID,
                        $"{training.Staff.LastName} {training.Staff.FirstName} {training.Staff.MiddleName}",
                        training.Project.Name,
                        training.Model.Name,
                        training.Operation.Name,
                        $"{training.Staff.LastName} {training.Staff.FirstName} {training.Staff.MiddleName}",
                        training.StartDate,
                        training.EndDate);
                }

            bindingSource.DataSource = table;

            trainingsDataGridView.DataSource = bindingSource;
        }

        private void trainingsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            if (index >= 0)
            {
                Training = trainings[index];
                Close();
            }
        }
    }
}
