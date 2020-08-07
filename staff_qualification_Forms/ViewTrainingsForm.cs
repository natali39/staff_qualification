﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ViewTrainingsForm : Form
    {
        private TrainingService trainingService = new TrainingService(new TrainingFileRepository());
        private ProjectService projectService = new ProjectService(new ProjectFileRepository());
        private StaffService staffService = new StaffService(new StaffFileRepository());

        public Training Training;
        private List<Training> trainings = new List<Training>();
        private List<Project> projects = new List<Project>();
        private List<Staff> staffs = new List<Staff>();

        private DataTable table = new DataTable();
        private BindingSource bindingSource = new BindingSource();

        public ViewTrainingsForm()
        {
            InitializeComponent();
            GetListData();
            SetDataGridViewProperties();
            GetTableColumns();
            FillTrainingsDataGridView();
        }

        private void GetListData()
        {
            trainings = trainingService.GetData();
            projects = projectService.GetData();
            staffs = staffService.GetData();
        }

        private void SetDataGridViewProperties()
        {
            trainingsDataGridView.Dock = DockStyle.Fill;
            trainingsDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            trainingsDataGridView.AllowUserToAddRows = false;
            trainingsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void GetTableColumns()
        {
            var staffColumn = new DataColumn("Сотрудник", typeof(string));
            var projectColumn = new DataColumn("Проект", typeof(string));
            var modelColumn = new DataColumn("Модель", typeof(string));
            var operationColumn = new DataColumn("Операция", typeof(string));
            var trainerColumn = new DataColumn("Инструктор", typeof(string));
            var startTrainingDate = new DataColumn("Дата начала", typeof(DateTime));
            var endTrainingDate = new DataColumn("Дата окончания", typeof(DateTime));

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
        }

        private void FillTrainingsDataGridView()
        {
            if (trainings == null)
                return;
            foreach (var training in trainings)
            {
                var currentStaff = Staff.GetStaffByID(training.StaffID, staffs);
                var currentTrainer = Staff.GetStaffByID(training.TrainerID, staffs);
                var currentProject = IdHelper.GetEntityByID(projects, training.ProjectID);
                var currentModel = IdHelper.GetEntityByID(currentProject.Models, training.ModelID);
                var currentOperation = IdHelper.GetEntityByID(currentModel.Operations, training.OperationID);

                table.Rows.Add
                    (currentStaff.GetStaffFullName(),
                    currentProject.Name,
                    currentModel.Name,
                    currentOperation.Name,
                    currentTrainer.GetStaffFullName(),
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
