using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ProjectsForm : Form
    {
        ProjectService service = new ProjectService(new ProjectFileRepository());
        List<Project> projects;
        Project project;
        Model model;
        List<LinkLabel> modelsLinkLabels;
        List<Button> modelsDeleteButtons;

        public ProjectsForm()
        {
            InitializeComponent();
            projects = service.GetData(); 

            if (projects == null)
                projects = new List<Project>();
            FillTreeView();
            projectsTreeView.SelectedNode = null;
        }

        private void FillTreeView()
        {
            projectsTreeView.BeginUpdate();
            projectsTreeView.Nodes.Clear();
            foreach (var project in projects)
            {
                var projectNode = new TreeNode(project.Name);
                projectNode.Tag = project;
                projectsTreeView.Nodes.Add(projectNode);

                foreach (var model in project.Models)
                {
                    var modelNode = new TreeNode(model.Name);
                    modelNode.Tag = model;
                    projectNode.Nodes.Add(modelNode);
                }
            }
            projectsTreeView.EndUpdate();
        }

        private void FindAndSelectModelNode(TreeNodeCollection nodes, string name)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == name)
                {
                    projectsTreeView.SelectedNode = node;
                }
                FindAndSelectModelNode(node.Nodes, name);
            }
        }

        private void projectsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (projectsTreeView.SelectedNode.Level == 0)
            {
                project = (Project)projectsTreeView.SelectedNode.Tag;
                ClearModelDetailsGroupBox();
                FillProjectDetailsGroupBox();
            }
            else if (e.Node.Level == 1)
            {
                project = (Project)projectsTreeView.SelectedNode.Parent.Tag;
                FillProjectDetailsGroupBox();
                model = (Model)projectsTreeView.SelectedNode.Tag;
                FillModelDetailsGroupBox(model);
            }
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            InputProjectNameForm inputNameForm = new InputProjectNameForm();
            inputNameForm.ShowDialog();
            if (inputNameForm.Name != null)
            {
                project = new Project();
                project.Name = inputNameForm.Name;
                projects.Add(project);
                var projectNode = new TreeNode(project.Name);
                projectNode.Tag = project;
                projectsTreeView.Nodes.Add(projectNode);
                service.UpdateData(projects);
            }
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsTreeView.SelectedNode != null && projectsTreeView.SelectedNode.Level == 0)
            {
                var result = MessageBox.Show($"Вы действительно хотите удалить проект?{Environment.NewLine}Внимание! Будут удалены также все модели и операции!", "Удаление проета", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    project = (Project)projectsTreeView.SelectedNode.Tag;
                    projects.Remove(project);
                    projectsTreeView.SelectedNode.Remove();
                    service.UpdateData(projects);
                }
            }
        }

        private void FillProjectDetailsGroupBox()
        {
            projectDetailsGroupBox.Visible = true;
            projectDetailsGroupBox.Text = $"Проект: {project.Name}";
            DisposeModelsLinkLabels();
            DisposeModelsDeleteButtons();
            CreateModelsLinkLabels(project.Models);
        }

        private void FillModelDetailsGroupBox(Model model)
        {
            modelDetailsGroupBox.Visible = true;
            modelDetailsGroupBox.Text = $"Модель: {model.Name}";
            GetListOperations(model);
        }

        private void ClearModelDetailsGroupBox()
        {
            modelDetailsGroupBox.Visible = false;
            modelDetailsGroupBox.Text = String.Empty;
            operationsListBox.Items.Clear();
        }

        private void CreateModelsLinkLabels(List<Model> models)
        {
            if (modelsLinkLabels == null)
            {
                modelsLinkLabels = new List<LinkLabel>();
                modelsDeleteButtons = new List<Button>();
            }
            for (int i = 0; i < project.Models.Count; i++)
            {
                var linkLabel = new LinkLabel()
                {
                    Name = "modelLabel" + i.ToString(),
                    Location = new Point(5, i * 22 + 5),
                    Text = $"{project.Models[i].Name}",
                    Tag = project.Models[i]
                };
                linkLabel.AutoSize = true;
                CreateModelDeleteButton(i);
                linkLabel.Click += new EventHandler(modelLinkedLabel_Click);
                modelsLinkLabels.Add(linkLabel);
                modelNamePanel.Controls.Add(linkLabel);
            }
        }

        private void DisposeModelsLinkLabels()
        {
            if (modelsLinkLabels != null)
            {
                foreach (var label in modelsLinkLabels)
                {
                    label.Dispose();
                }
            }
        }

        private void CreateModelDeleteButton(int i)
        {
            var deleteButton = new Button()
            {
                Name = "modelDeleteButton" + i.ToString(),
                Location = new Point(270, i * 21 + 3),
                Width = 20,
                Height = 20,
                Text = "-",
                Tag = project.Models[i]
            };
            deleteButton.Click += new EventHandler(deleteModelButton_Click);
            modelsDeleteButtons.Add(deleteButton);
            modelNamePanel.Controls.Add(deleteButton);
        }

        private void DisposeModelsDeleteButtons()
        {
            if (modelsDeleteButtons != null)
            {
                foreach (var button in modelsDeleteButtons)
                {
                    button.Dispose();
                }
            }
        }

        private void modelLinkedLabel_Click(object sender, EventArgs e)
        {
            var modelLinkedLabel = (LinkLabel)sender;
            model = (Model)modelLinkedLabel.Tag;
            FillModelDetailsGroupBox(model);
            FindAndSelectModelNode(projectsTreeView.Nodes, model.Name);
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            if (project != null)
            {
                if (addModelNameTextBox.Text != String.Empty)
                {
                    foreach (var model in project.Models)
                    {
                        if (addModelNameTextBox.Text == model.Name)
                        {
                            MessageBox.Show("Такая модель уже существует! Введите другое название!");
                            addModelNameTextBox.Focus();
                            return;
                        }
                    }
                    model = new Model(addModelNameTextBox.Text);
                    project.Models.Add(model);
                    FillTreeView();
                    DisposeModelsLinkLabels();
                    CreateModelsLinkLabels(project.Models);
                    FillModelDetailsGroupBox(model);
                    addModelNameTextBox.Text = String.Empty;
                    service.UpdateData(projects);
                }
                else
                {
                    MessageBox.Show("Нужно ввести название модели!");
                }
            }
            else
            {
                MessageBox.Show("Проект не выбран! Сначала выберите проект!");
            }
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            var modelDeleteButton = (Button)sender;
            model = (Model)modelDeleteButton.Tag;

            var result = MessageBox.Show($"Удалить модель {model.Name}?{Environment.NewLine}Внимание! Удалится также вся информация о модели!", "Удаление модели", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                project.Models.Remove(model);
                DisposeModelsLinkLabels();
                DisposeModelsDeleteButtons();
                CreateModelsLinkLabels(project.Models);
                FillTreeView();
                ClearModelDetailsGroupBox();
                service.UpdateData(projects);
            }
        }

        private void GetListOperations(Model model)
        {
            operationsListBox.Items.Clear();
            foreach (var operation in model.Operations)
            {
                operationsListBox.Items.Add(operation);
                operationsListBox.DisplayMember = "Name";
            }
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            if (model != null && modelDetailsGroupBox.Text != String.Empty)
            {
                if (addOperationTextBox.Text != String.Empty)
                {
                    foreach (var operation in model.Operations)
                    {
                        if (addOperationTextBox.Text == operation.Name)
                        {
                            MessageBox.Show("Такая операция уже существует! Введите другое название!");
                            addOperationTextBox.Focus();
                            return;
                        }
                    }
                    model.Operations.Add(new Operation(addOperationTextBox.Text));
                    GetListOperations(model);
                    addOperationTextBox.Text = String.Empty;
                    service.UpdateData(projects);
                }
                else
                {
                    MessageBox.Show("Нужно ввести название операции!");
                }
            }
            else
            {
                MessageBox.Show("Модель не выбрана!");
            }
        }

        private void deleteOperationButton_Click(object sender, EventArgs e)
        {
            var operation = (Operation)operationsListBox.SelectedItem;
            if (operation != null)
            {
                var result = MessageBox.Show("Удалить операцию?", "Удаление операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    model.Operations.Remove(operation);
                    GetListOperations(model);
                    service.UpdateData(projects);
                }
            }
            else
            {
                MessageBox.Show("Операция не выбрана!");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modelNamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            modelNamePanel.Focus();
        }
    }
}
