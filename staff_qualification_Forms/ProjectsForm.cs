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
        Operation operation;
        List<LinkLabel> modelsLinkLabels;
        List<LinkLabel> operationsLinkLabels;
        List<Button> modelsDeleteButtons;
        List<Button> operationsDeleteButtons;
        List<LinkLabel> operationDocumentsLinkLabels;
        Point startPointAddDocumentLinkLabel = new Point(3, 10);

        public ProjectsForm()
        {
            InitializeComponent();
            projects = service.GetData(); 
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
                ClearModelDetailsGroupBox();
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
                IdHelper.TryUpdateId(project);
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
            DisposeLinkLabels(modelsLinkLabels);
            DisposeDeleteButtons(modelsDeleteButtons);
            CreateModelsLinkLabels(project.Models);
        }

        private void CreateModelsLinkLabels(List<Model> models)
        {
            if (modelsLinkLabels == null)
            {
                modelsLinkLabels = new List<LinkLabel>();
                modelsDeleteButtons = new List<Button>();
            }
            for (int i = 0; i < models.Count; i++)
            {
                var modelLinkLabel = new LinkLabel()
                {
                    Name = "modelLabel" + i.ToString(),
                    Location = new Point(5, i * 22 + 5),
                    Text = models[i].Name,
                    Tag = models[i]
                };
                modelLinkLabel.AutoSize = true;
                CreateModelDeleteButton(models[i], i);
                modelLinkLabel.Click += new EventHandler(modelLinkedLabel_Click);
                modelsLinkLabels.Add(modelLinkLabel);
                modelNamePanel.Controls.Add(modelLinkLabel);
            }
        }

        private void CreateModelDeleteButton(Model model, int i)
        {
            var deleteButton = new Button()
            {
                Name = "modelDeleteButton" + i.ToString(),
                Location = new Point(270, i * 21 + 3),
                Width = 20,
                Height = 20,
                Text = "-",
                Tag = model
            };
            deleteButton.Click += new EventHandler(deleteModelButton_Click);
            modelsDeleteButtons.Add(deleteButton);
            modelNamePanel.Controls.Add(deleteButton);
        }

        private void modelLinkedLabel_Click(object sender, EventArgs e)
        {
            var modelLinkedLabel = (LinkLabel)sender;
            model = (Model)modelLinkedLabel.Tag;
            ClearModelDetailsGroupBox();
            FillModelDetailsGroupBox(model);
            FindAndSelectModelNode(projectsTreeView.Nodes, model.Name);
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            if (project == null)
            {
                MessageBox.Show("Проект не выбран! Сначала выберите проект!");
                return;
            }
            if (addModelNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("Нужно ввести название модели!");
                return;
            }
            foreach (var model in project.Models)
            {
                if (addModelNameTextBox.Text.ToLower() == model.Name.ToLower())
                {
                    MessageBox.Show("Такая модель уже существует! Введите другое название!");
                    addModelNameTextBox.Focus();
                    return;
                }
            }
            model = new Model();
            IdHelper.TryUpdateId(model);
            model.Name = addModelNameTextBox.Text;
            project.Models.Add(model);
            FillTreeView();
            DisposeLinkLabels(modelsLinkLabels);
            CreateModelsLinkLabels(project.Models);
            FillModelDetailsGroupBox(model);
            addModelNameTextBox.Text = String.Empty;
            service.UpdateData(projects);
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            var modelDeleteButton = (Button)sender;
            model = (Model)modelDeleteButton.Tag;

            var result = MessageBox.Show($"Удалить модель {model.Name}?{Environment.NewLine}Внимание! Удалится также вся информация о модели!", "Удаление модели", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                project.Models.Remove(model);
                DisposeLinkLabels(modelsLinkLabels);
                DisposeDeleteButtons(modelsDeleteButtons);
                CreateModelsLinkLabels(project.Models);
                FillTreeView();
                ClearModelDetailsGroupBox();
                service.UpdateData(projects);
            }
        }

        private void FillModelDetailsGroupBox(Model model)
        {
            modelDetailsGroupBox.Visible = true;
            modelDetailsGroupBox.Text = $"Модель: {model.Name}";
            CreateOperationsLinkLabels(model.Operations);
            modelImageLabel.Visible = true;
            addModelImageButton.Visible = true;
            modelPictureBox.Visible = true;
        }

        private void CreateOperationsLinkLabels(List<Operation> operations)
        {
            if (operationsLinkLabels == null)
            {
                operationsLinkLabels = new List<LinkLabel>();
                operationsDeleteButtons = new List<Button>();
            }
            for (int i = 0; i < operations.Count; i++)
            {
                var operationLinkLabel = new LinkLabel()
                {
                    Name = "operationLinkLabel" + i.ToString(),
                    Location = new Point(5, i * 22 + 5),
                    Text = operations[i].Name,
                    Tag = operations[i],
                    AutoSize = true
                };
                CreateOperationsDeleteButton(operations[i], i);
                operationLinkLabel.Click += new EventHandler(operationLinkedLabel_Click);
                operationsLinkLabels.Add(operationLinkLabel);
                operationsPanel.Controls.Add(operationLinkLabel);
            }
        }

        private void CreateOperationsDeleteButton(Operation operation, int i)
        {
            var operationDeleteButton = new Button()
            {
                Name = "operationDeleteButton" + i.ToString(),
                Location = new Point(270, i * 21 + 3),
                Width = 20,
                Height = 20,
                Text = "-",
                Tag = operation
            };
            operationDeleteButton.Click += new EventHandler(deleteOperationButton_Click);
            operationsDeleteButtons.Add(operationDeleteButton);
            operationsPanel.Controls.Add(operationDeleteButton);
        }

        private void operationLinkedLabel_Click(object sender, EventArgs e)
        {
            ClearOperationPanel();
            documentsLabel.Visible = true;
            documentsPanel.Visible = true;
            addDocumentLinkLabel.Visible = true;
            var operationLinkLabel = (LinkLabel)sender;
            operation = (Operation)operationLinkLabel.Tag;
            CreateOperationDocumentsLinkLabels(operation.Documents);
        }

        private void CreateOperationDocumentsLinkLabels(List<string> documents)
        {
            operationDocumentsLinkLabels = new List<LinkLabel>();
            for (int i = 0; i < documents.Count; i++)
            {
                var documentLinkLabel = new LinkLabel()
                {
                    Name = "operationDocument" + i.ToString(),
                    Location = new Point
                        (startPointAddDocumentLinkLabel.X,
                        startPointAddDocumentLinkLabel.Y + i * 22 + 5),
                    Text = documents[i],
                    Tag = documents[i],
                    AutoSize = true
                };
                documentLinkLabel.Click += new EventHandler(documentLinkLabel_Click);
                operationDocumentsLinkLabels.Add(documentLinkLabel);
                documentsPanel.Controls.Add(documentLinkLabel);
            }
            if (operationDocumentsLinkLabels.Count > 0)
            {
                if (operationDocumentsLinkLabels.Count >= 5)
                {
                    addDocumentLinkLabel.Visible = false;
                    return;
                }
                addDocumentLinkLabel.Location = new Point
                    (operationDocumentsLinkLabels[documents.Count - 1].Location.X,
                    operationDocumentsLinkLabels[documents.Count - 1].Location.Y + 25);
            }
        }

        private void ClearModelDetailsGroupBox()
        {
            modelDetailsGroupBox.Visible = false;
            modelDetailsGroupBox.Text = String.Empty;
            DisposeLinkLabels(operationsLinkLabels);
            DisposeDeleteButtons(operationsDeleteButtons);
            modelImageLabel.Visible = false;
            addModelImageButton.Visible = false;
            modelPictureBox.Visible = false;
            ClearOperationPanel();
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            if (model == null && modelDetailsGroupBox.Text == String.Empty)
            {
                MessageBox.Show("Модель не выбрана!");
                return;
            }
            if (addOperationTextBox.Text == String.Empty)
            {
                MessageBox.Show("Нужно ввести название операции!");
                return;
            }
            foreach (var operation in model.Operations)
            {
                if (addOperationTextBox.Text.ToLower() == operation.Name.ToLower())
                {
                    MessageBox.Show("Такая операция уже существует! Введите другое название!");
                    addOperationTextBox.Focus();
                    return;
                }
            }
            var newOperation = new Operation();
            newOperation.Name = addOperationTextBox.Text;
            IdHelper.TryUpdateId(newOperation);
            model.Operations.Add(newOperation);
            ClearModelDetailsGroupBox();
            FillModelDetailsGroupBox(model);
            addOperationTextBox.Text = String.Empty;
            service.UpdateData(projects);
        }

        private void deleteOperationButton_Click(object sender, EventArgs e)
        {
            var operationDeleteButton = (Button)sender;
            var operation = (Operation)operationDeleteButton.Tag;
            if (operation != null)
            {
                var result = MessageBox.Show("Удалить операцию?", "Удаление операции", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    model.Operations.Remove(operation);
                    ClearModelDetailsGroupBox();
                    FillModelDetailsGroupBox(model);
                    service.UpdateData(projects);
                }
            }
        }

        private void ClearOperationPanel()
        {
            DisposeLinkLabels(operationDocumentsLinkLabels);
            addDocumentLinkLabel.Location = startPointAddDocumentLinkLabel;
            addDocumentLinkLabel.Visible = false;
            documentsLabel.Visible = false;
            documentsPanel.Visible = false;
        }

        private void DisposeLinkLabels(List<LinkLabel> linkLabels)
        {
            if (linkLabels != null)
            {
                foreach (var label in linkLabels)
                {
                    label.Dispose();
                }
            }
        }

        private void DisposeDeleteButtons(List<Button> buttons)
        {
            if (buttons != null)
            {
                foreach (var button in buttons)
                {
                    button.Dispose();
                }
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

        private void ProjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var project in projects)
            {
                if (project.Models.Count == 0)
                {
                    MessageBox.Show($"Проект должен содержать хотя бы одну модель! Добавьте модели в {project.Name}.");
                    e.Cancel = true;
                    return;
                }
                foreach (var model in project.Models)
                {
                    if (model.Operations.Count == 0)
                    {
                        MessageBox.Show($"Модель должна содержать хотя бы одну операция! Добавьте операции в {model.Name}.");
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void addDocumentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filePath = openFileDialog.FileName;
            string fileName = openFileDialog.SafeFileName;
            operation.Documents.Add(filePath);
            service.UpdateData(projects);
            CreateOperationDocumentsLinkLabels(operation.Documents);
        }

        private void documentLinkLabel_Click(object sender, EventArgs e)
        {
            var documentLabel = (LinkLabel)sender;
            var documentPath = documentLabel.Text;
            System.Diagnostics.Process.Start(documentPath);
        }
    }
}
