using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class MainForm : Form
    {
        ProjectService projectService = new ProjectService(new ProjectFileRepository());
        StaffService staffService = new StaffService(new StaffDBRepository());
        TrainingService trainingService = new TrainingService(new TrainingDbRepository());
        SelfCheckService selfCheckService = new SelfCheckService(new SelfCheckDbRepository());

        List<CheckBox> modelsCheckBoxes;
        List<CheckBox> modelsSelectAllCheckBoxes;
        List<CheckedListBox> operationsCheckedListBoxes;

        List<Project> projects;
        List<Staff> staffs;
        List<Training> trainings;
        List<SelfCheck> selfChecks;

        List<Training> endTraining;
        List<Training> onTraining;
        List<Training> isSelfCheck;

        Project project;

        DataTable table = new DataTable();

        public MainForm()
        {
            InitializeComponent();
            GetListData();
            List<CheckBox> modelsCheckBoxes = new List<CheckBox>();
            List<CheckBox> modelsSelectAllCheckBoxes = new List<CheckBox>();
            List<CheckedListBox> operationsCheckedListBoxes = new List<CheckedListBox>();
            SetFormProperties();
        }

        private void GetListData()
        {
            projects = projectService.GetData();
            staffs = staffService.GetData();
            trainings = trainingService.GetData();
            selfChecks = selfCheckService.GetData();
        }

        private void SetFormProperties()
        {
            outputDataGridView.AllowUserToAddRows = false;
            outputDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GetTableHeader();

            selectAllModelsCheckBox.Visible = false;

            projectComboBox.DataSource = projects;
            projectComboBox.DisplayMember = "Name";
            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void GetTableHeader()
        {
            table.Columns.Add("Табельный номер");
            table.Columns.Add("ФИО");
            table.Columns.Add("Модель");
            table.Columns.Add("Операция");
            table.Columns.Add("Начало обучения");
            table.Columns.Add("Окончание обучения");
            table.Columns.Add("Дата присвоения самоконтроля");
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var staffsForm = new StaffsForm();
            staffsForm.ShowDialog();
            staffs = staffService.GetData();
        }

        private void проектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            projects = projectService.GetData();
            projectComboBox.DataSource = projects;
            RefreshProjectInfo();
        }

        private void новоеОбучениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingForm trainingForm = new TrainingForm();
            trainingForm.ShowDialog();
            trainings = trainingService.GetData();
        }

        private void посмотретьВсеОбученияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTrainingsForm viewTainingsForm = new ViewTrainingsForm();
            viewTainingsForm.ShowDialog();
        }

        private void новыйСамоконтрольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfCheckForm selfCheckForm = new SelfCheckForm();
            selfCheckForm.ShowDialog();
            selfChecks = selfCheckService.GetData();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSelfCheksForm viewSelfChekForm = new ViewSelfCheksForm();
            viewSelfChekForm.ShowDialog();
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            project = (Project)projectComboBox.SelectedItem;
            RefreshProjectInfo();
        }

        private void RefreshProjectInfo()
        {
            ClearProjectInfo();
            CreateModelsCheckBoxes(project.Models);
        }

        private void ClearProjectInfo()
        {
            selectAllModelsCheckBox.Checked = false;
            selectAllModelsCheckBox.Visible = false;
            DisposeModelsCheckBoxes();
            DisposeOperationsCheckedListBoxes();
            table.Rows.Clear();
        }

        private void CreateModelsCheckBoxes(List<Model> models)
        {
            if (models == null)
                return;
            selectAllModelsCheckBox.Visible = true;
            modelsCheckBoxes = new List<CheckBox>();
            modelsSelectAllCheckBoxes = new List<CheckBox>();
            operationsCheckedListBoxes = new List<CheckedListBox>();

            for (int i = 0; i < models.Count; i++)
            {
                var modelCheckBox = new CheckBox()
                {
                    Name = "modelCheckBox" + i.ToString(),
                    Location = new Point(12 + i * 210, 5),
                    Text = models[i].Name,
                    Tag = models[i],
                    AutoSize = true
                };

                var modelSelectAllCheckBox = new CheckBox()
                {
                    Name = "modelSelectAllCheckBox" + i.ToString(),
                    Location = new Point(160 + i * 210, 5),
                    Text = "Все",
                    Tag = models[i],
                    AutoSize = true
                };

                modelCheckBox.CheckedChanged += new EventHandler(modelCheckBox_CheckedChanged);
                modelSelectAllCheckBox.CheckedChanged += new EventHandler(modelSelectAllCheckBox_CheckedChanged);

                modelsCheckBoxes.Add(modelCheckBox);
                modelsSelectAllCheckBoxes.Add(modelSelectAllCheckBox);
                modelsPanel.Controls.Add(modelCheckBox);
                modelsPanel.Controls.Add(modelSelectAllCheckBox);
                CreateOperationsCheckedListBox(models[i].Operations, i);
            }
        }

        private void CreateOperationsCheckedListBox(List<Operation> operations, int i)
        {
            var operationCheckedListBox = new CheckedListBox()
            {
                Name = "operationCheckedListBox" + i.ToString(),
                Location = new Point(12 + i * 210, 25),
                Width = 190,
                Height = 150,
                DataSource = operations,
                DisplayMember = "Name",
                Tag = i,
                CheckOnClick = true
            };
            operationCheckedListBox.ItemCheck += new ItemCheckEventHandler(operationsCheckedListBox_ItemCheck);
            operationsCheckedListBoxes.Add(operationCheckedListBox);
            modelsPanel.Controls.Add(operationCheckedListBox);
        }

        private void DisposeOperationsCheckedListBoxes()
        {
            if (operationsCheckedListBoxes != null)
            {
                foreach (var checkedListBox in operationsCheckedListBoxes)
                {
                    checkedListBox.Dispose();
                }
            }
        }

        private void DisposeModelsCheckBoxes()
        {
            if (modelsCheckBoxes == null)
                return;
            foreach (var checkBox in modelsCheckBoxes)
            {
                checkBox.Dispose();
            }
            foreach (var checkBox in modelsSelectAllCheckBoxes)
            {
                checkBox.Dispose();
            }
        }

        private void selectAllModelsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllModelsCheckBox.Checked == true)
            {
                foreach (var checkBox in modelsCheckBoxes)
                    checkBox.Checked = true;
                foreach (var checkedListBox in operationsCheckedListBoxes)
                    CheckAllItems(checkedListBox);
            }
            if (selectAllModelsCheckBox.Checked == false)
            {
                foreach (var checkBox in modelsCheckBoxes)
                    checkBox.Checked = false;
                foreach (var checkedListBox in operationsCheckedListBoxes)
                    UncheckAllItems(checkedListBox);
            }
        }

        private void modelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var currentModelCheckBox = (CheckBox)sender;
            int index = modelsCheckBoxes.IndexOf(currentModelCheckBox);

            if (currentModelCheckBox.Checked == false)
            {
                modelsSelectAllCheckBoxes[index].Checked = false;
                UncheckAllItems(operationsCheckedListBoxes[index]);
            }
        }

        private void modelSelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var currentModelSelectAllCheckbox = (CheckBox)sender;
            int index = modelsSelectAllCheckBoxes.IndexOf(currentModelSelectAllCheckbox);
            var currentOperationsCheckedListBox = operationsCheckedListBoxes[index];
            if (currentModelSelectAllCheckbox.Checked == true)
            {
                CheckAllItems(currentOperationsCheckedListBox);
            }
            if (currentModelSelectAllCheckbox.Checked == false)
            {
                UncheckAllItems(currentOperationsCheckedListBox);
            }
        }

        private void CheckAllItems(CheckedListBox checkedListBox)
        {
            for (int index = 0; index < checkedListBox.Items.Count; index++)
            {
                checkedListBox.SetItemChecked(index, true);
            }
        }

        private void UncheckAllItems(CheckedListBox checkedListBox)
        {
            for (int index = 0; index < checkedListBox.Items.Count; index++)
            {
                checkedListBox.SetItemChecked(index, false);
            }
        }

        private void operationsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var currentOperationCheckedListBox = (CheckedListBox)sender;
            int index = operationsCheckedListBoxes.IndexOf(currentOperationCheckedListBox);
            if (e.NewValue == CheckState.Unchecked)
            {
                if (currentOperationCheckedListBox.CheckedItems.Count == 1)
                {
                    modelsCheckBoxes[index].Checked = false;
                    modelsSelectAllCheckBoxes[index].Checked = false;
                }
            }
            else
            {
                modelsCheckBoxes[index].Checked = true;
            }
        }

        private List<Operation> GetSelectedOperations()
        {
            var selectedOperations = new List<Operation>();

            if (modelsCheckBoxes != null)
            {
                foreach (var checkBox in modelsCheckBoxes)
                {
                    if (checkBox.Checked == true)
                    {
                        int index = modelsCheckBoxes.IndexOf(checkBox);
                        var currentCheckedListBox = operationsCheckedListBoxes[index];
                        foreach (var item in currentCheckedListBox.CheckedItems)
                        {
                            selectedOperations.Add((Operation)item);
                        }
                    }
                }
            }
            return selectedOperations;
        }

        private void viewOutputButton_Click(object sender, EventArgs e)
        {
            GetListData();
            var selectedOperations = GetSelectedOperations();
            if (selectedOperations == null || selectedOperations.Count == 0)
            {
                MessageBox.Show("Ни одна операция не выбрана!");
                return;
            }

            GetSelectedTrainings(selectedOperations);
            var output = GetOutputData();
            FillDataGridView(output);
        }

        private void GetSelectedTrainings(List<Operation> selectedOperations)
        {
            endTraining = new List<Training>();
            onTraining = new List<Training>();
            isSelfCheck = new List<Training>();

            foreach (var operation in selectedOperations)
            {
                if (onTrainingCheckBox.Checked == true)
                    GetOnTrainingList(operation);
                if (endTrainingCheckBox.Checked == true)
                    GetEndTrainingList(operation);
                if (IsSelfChekCheckBox.Checked == true)
                    GetIsSelfCheckList(operation);
            }
        }

        private void GetOnTrainingList(Operation operation)
        {
            foreach (var training in trainings)
            {
                if (training.OperationID == operation.ID && training.EndDate.Date >= DateTime.Now.Date)
                    onTraining.Add(training);
            }
        }
        
        private void GetEndTrainingList(Operation operation)
        {
            foreach (var training in trainings)
            {
                if (training.OperationID == operation.ID && training.EndDate.Date < DateTime.Now.Date)
                    endTraining.Add(training);
            }
        }

        private void GetIsSelfCheckList(Operation operation)
        {
            foreach (var selfCheck in selfChecks)
            {
                var training = IdHelper.GetEntityByID(trainings, selfCheck.TrainingID);
                if (training.OperationID == operation.ID)
                    isSelfCheck.Add(training);
            }
        }

        private List<Training> GetTotalTrainingList()
        {
            var totalTraining = new List<Training>();
            totalTraining.AddRange(onTraining.Union(endTraining).Union(isSelfCheck));
            return totalTraining;
        }

        private List<Result> GetOutputData()
        {
            var outputData = new List<Result>();
            var totalTrainings = GetTotalTrainingList();
            foreach (var training in totalTrainings)
            {
                var result = new Result();
                var model = IdHelper.GetEntityByID(project.Models, training.ModelID);
                result.ModelName = model.Name;
                var operation = IdHelper.GetEntityByID(model.Operations, training.OperationID);
                result.OperationName = operation.Name;
                result.StartTrainingDate = training.StartDate.ToString("d");
                result.EndTrainingDate = training.EndDate.ToString("d");
                result.StaffID = training.StaffID;
                var staff = Staff.GetStaffByID(training.StaffID, staffs);
                if (staff != null)
                    result.StaffFullName = staff.GetStaffFullName();

                foreach (var selfCheck in selfChecks)
                {
                    if (selfCheck.TrainingID == training.ID)
                    {
                        result.SelfCheckDate = selfCheck.Date.ToString("d");
                        break;
                    }
                    else
                    {
                        result.SelfCheckDate = "-";
                    }
                }
                outputData.Add(result);
            }
            return outputData;
        }

        private void FillDataGridView(List<Result> output)
        {
            table.Rows.Clear();
            foreach (var resultLine in output)
            {
                table.Rows.Add
                    (resultLine.StaffID,
                    resultLine.StaffFullName,
                    resultLine.ModelName,
                    resultLine.OperationName,
                    resultLine.StartTrainingDate,
                    resultLine.EndTrainingDate,
                    resultLine.SelfCheckDate
                    );
            }
            outputDataGridView.DataSource = table;
        }
    }
}
        
