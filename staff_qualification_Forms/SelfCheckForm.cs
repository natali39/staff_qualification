using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class SelfCheckForm : Form
    {
        SelfCheck selfCheck = new SelfCheck();
        Training training;
        SelfCheckService selfCheckService = new SelfCheckService(new SelfCheckDbRepository());
        ProjectService projectService = new ProjectService(new ProjectDbRepository());
        StaffService staffService = new StaffService(new StaffDBRepository());
        List<SelfCheck> selfChecks;
        List<Project> projects;
        List<Staff> staffs;
        SelfCheckReport selfCheckReport;

        public SelfCheckForm()
        {
            InitializeComponent();

            selfChecks = selfCheckService.GetData();
            projects = projectService.GetData();
            staffs = staffService.GetData();
            selfCheckReport = new SelfCheckReport();
            selfCheckDateTimePicker.Format = DateTimePickerFormat.Short;
            selfCheckDateTimePicker.Value = DateTime.Now;
            selfCheck.Date = selfCheckDateTimePicker.Value;
        }

        private void selectTrainingButton_Click(object sender, EventArgs e)
        {
            ViewTrainingsForm viewTrainingsForm = new ViewTrainingsForm("select");
            viewTrainingsForm.ShowDialog();
            training = viewTrainingsForm.SelectedTraining;
            if (training == null)
                return;
            selfCheck.TrainingID = training.ID;
            GetTrainingDetails(training);
        }

        private void GetTrainingDetails(Training training)
        {
            var project = IdHelper.GetEntityByID(projects, training.ProjectID);
            var model = IdHelper.GetEntityByID(project.Models, training.ModelID);
            var operation = IdHelper.GetEntityByID(model.Operations, training.OperationID);
            var staff = Staff.GetStaffByID(training.StaffID, staffs);
            var staffName = staff.GetStaffFullName();
            var modelDescription = $"{project.Name} {model.Name}";

            trainingTextBox.Text = $"{staffName}; {modelDescription}; {operation.Name}";
            selfCheckReport.StaffID = training.StaffID.ToString();
            selfCheckReport.StaffName = staffName;
            selfCheckReport.ModelDescription = modelDescription;
            selfCheckReport.Operation = operation.Name;
        }

        private void responsiblePersonButton_Click(object sender, EventArgs e)
        {
            StaffsForm staffsForm = new StaffsForm("select");
            staffsForm.ShowDialog();
            var responsiblePerson = staffsForm.SelectedStaff;
            selfCheck.ResponsiblePersonID = responsiblePerson.ID;
            responsiblePersonTextBox.Text = responsiblePerson.GetStaffFullName();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selfCheck.Date = selfCheckDateTimePicker.Value;
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
                MessageBox.Show("Дата присвоения самоконтроля не может быть меньше даты окончания обучения и больше текущей даты!");
                return;
            }
            selfChecks.Add(selfCheckService.AddSelfCheck(selfCheck));
            Close();
        }

        private void CheckForUnique()
        {
            foreach (var existingSelfCheck in selfChecks)
            {
                if (selfCheck.TrainingID == existingSelfCheck.TrainingID)
                {
                    MessageBox.Show("Такой самоконтроль уже существует! Проверьте корректность введенных данных.");
                    return;
                }
            }
        }

        private bool IncorrectDate()
        {
            return selfCheck.Date < training.EndDate || selfCheck.Date > DateTime.Now ;
        }

        private bool IsEmpty()
        {
            return selfCheck.TrainingID == Guid.Empty || selfCheck.ResponsiblePersonID == 0;
        }

        private void generateDocumentButton_Click(object sender, EventArgs e)
        {
            selfCheckReport.Date = selfCheck.Date;
            selfCheckReport.ResponsiblePerson = responsiblePersonTextBox.Text;
            selfCheckReport.FillSelfCheckDocument();
        }
    }
}
