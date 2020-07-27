using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class MainForm : Form
    {
        ProjectService projectService = new ProjectService(new ProjectFileRepository());
        StaffService staffService = new StaffService(new StaffFileRepository());
        Project project;
        Model model;
        Operation operation;
        Staff staff;
        List<Project> projects;
        List<Staff> staffs;

        public MainForm()
        {
            InitializeComponent();

            projects = projectService.GetData();
            staffs = staffService.GetData();

            projectComboBox.DataSource = projects;
            projectComboBox.DisplayMember = "Name";
            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            modelComboBox.DisplayMember = "Name";
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            operationComboBox.DisplayMember = "Name";
            operationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            staffComboBox.DataSource = staffs;
            staffComboBox.DisplayMember = "LastName";
            operationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var staffsForm = new StaffsForm();
            staffsForm.ShowDialog();
        }

        private void проектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
        }

        private void operationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = (Operation)operationComboBox.SelectedItem;
        }

        private void новоеОбучениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingForm trainingForm = new TrainingForm();
            trainingForm.ShowDialog();
        }

        private void посмотретьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTrainingsForm viewTainingsForm = new ViewTrainingsForm();
            viewTainingsForm.ShowDialog();
        }

        private void новыйСамоконтрольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfCheckForm selfCheckForm = new SelfCheckForm();
            selfCheckForm.ShowDialog();
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            project = (Project)projectComboBox.SelectedItem;
            modelComboBox.DataSource = project.Models;
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = (Model)modelComboBox.SelectedItem;
            operationComboBox.DataSource = model.Operations;
        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            staff = (Staff)staffComboBox.SelectedItem;
        }

        private void StaffComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string LastName = ((Staff)e.ListItem).LastName;
            string FirstName = ((Staff)e.ListItem).FirstName;
            string MiddleName = ((Staff)e.ListItem).MiddleName;
            e.Value = $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
        
