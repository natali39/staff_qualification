using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ProjectEditForm : Form
    {
        public Project project;
        Model model;

        public ProjectEditForm(Project project)
        {
            InitializeComponent();
            this.project = project;
            addProjectTextBox.Text = project.Name;
            FillModelListBox();
        }

        private void FillModelListBox()
        {
            if (project.Models != null)
            {
                foreach (var model in project.Models)
                {
                    modelListBox.Items.Add(model.Name);
                }
            }
        }

        private void RefreshModelListBox()
        {
            modelListBox.Items.Clear();
            FillModelListBox();
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            if (addProjectTextBox.Text != String.Empty)
            {
                project.Name = addProjectTextBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Нужно ввести название проекта!");
            }
        }

        private void SaveModelsList()
        {
            foreach (var item in modelListBox.Items)
            {
                project.Models.Add(new Model(item.ToString()));
            }
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            if (project.Models == null)
            {
                project.Models = new List<Model>();
            }
            if (addModelNameTextBox.Text != String.Empty)
            {
                project.Models.Add(new Model(addModelNameTextBox.Text));
                RefreshModelListBox();
                addModelNameTextBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Нужно ввести название модели!");
            }
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                project.Models.RemoveAt(modelListBox.SelectedIndex);
                RefreshModelListBox();
            }
            catch (Exception ex) { }
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            model = project.Models[modelListBox.SelectedIndex];
            if (model.Operations == null)
            {
                model.Operations = new List<Operation>();
            }
            if (addOperationTextBox.Text != String.Empty)
            {
                model.Operations.Add(new Operation(addOperationTextBox.Text));
                RefreshOperationsListBox();
                addOperationTextBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Нужно ввести название модели!");
            }
        }

        private void modelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = project.Models[modelListBox.SelectedIndex];
            RefreshOperationsListBox();
        }

        private void RefreshOperationsListBox()
        {
            operationsListBox.Items.Clear();
            FillOperationsListBox();
        }

        private void FillOperationsListBox()
        {
            if (model.Operations != null)
            {
                foreach (var operation in model.Operations)
                {
                    operationsListBox.Items.Add(operation.Name);
                }
            }
        }

    }
}
