using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ProjectsForm : Form
    {
        ProjectService projectService;
        List<Project> projects;
        Project currentProject;
        Model currentModel;
        Operation currentOperation;
        List<LinkLabel> modelsLinkLabels;
        List<LinkLabel> operationsLinkLabels;
        List<Button> modelDeleteButtons;
        List<Button> operationsDeleteButtons;
        List<LinkLabel> operationDocumentsLinkLabels;

        public ProjectsForm(List<Project> projects, ProjectService projectService)
        {
            InitializeComponent();
            this.projects = projects;
            this.projectService = projectService;
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
                currentProject = (Project)projectsTreeView.SelectedNode.Tag;
                ClearProjectDetails();
                ClearModelDetails();
                FillProjectDetails();
            }
            else if (e.Node.Level == 1)
            {
                currentProject = (Project)projectsTreeView.SelectedNode.Parent.Tag;
                ClearProjectDetails();
                FillProjectDetails();
                ClearModelDetails();
                currentModel = (Model)projectsTreeView.SelectedNode.Tag;
                FillModelDetails(currentModel);
            }
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            InputProjectNameForm inputNameForm = new InputProjectNameForm();
            inputNameForm.ShowDialog();
            if (inputNameForm.Name != null)
            {
                var project = new Project();
                project.Name = inputNameForm.Name;
                project = projectService.AddProject(project);
                projects.Add(project);
                var projectNode = new TreeNode(project.Name);
                projectNode.Tag = project;
                projectsTreeView.Nodes.Add(projectNode);
            }
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsTreeView.SelectedNode != null && projectsTreeView.SelectedNode.Level == 0)
            {
                var result = MessageBox.Show($"Вы действительно хотите удалить проект?", "Удаление проета", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var project = (Project)projectsTreeView.SelectedNode.Tag;
                    if (project.Models.Count != 0)
                    {
                        MessageBox.Show($"Проект {project.Name} нельзя удалить, т.к. он содержит по крайней мере одну модель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    projectService.DeleteProject(project);
                    projects.Remove(project);
                    projectsTreeView.SelectedNode.Remove();
                }
            }
        }

        private void ClearProjectDetails()
        {
            DisposeLinkLabels(modelsLinkLabels);
            DisposeDeleteButtons(modelDeleteButtons);
        }

        private void FillProjectDetails()
        {
            projectDetailsGroupBox.Visible = true;
            projectDetailsGroupBox.Text = $"Проект: {currentProject.Name}";
            CreateModelsLinkLabels(currentProject.Models);
        }

        private void ClearModelDetails()
        {
            DisposeLinkLabels(operationsLinkLabels);
            DisposeDeleteButtons(operationsDeleteButtons);
            modelDetailsGroupBox.Visible = false;
            modelDetailsGroupBox.Text = String.Empty;
            modelImageLabel.Visible = false;
            addModelImageButton.Visible = false;
            modelPictureBox.Visible = false;
            ClearOperationDetails();
        }

        private void FillModelDetails(Model model)
        {
            modelDetailsGroupBox.Visible = true;
            modelDetailsGroupBox.Text = $"Модель: {model.Name}";
            CreateOperationsLinkLabels(model.Operations);
            modelImageLabel.Visible = true;
            addModelImageButton.Visible = true;
            modelPictureBox.Visible = true;
        }

        private void ClearOperationDetails()
        {
            DisposeLinkLabels(operationDocumentsLinkLabels);
            addDocumentLinkLabel.Visible = false;
            documentsLabel.Visible = false;
            documentsPanel.Visible = false;
        }

        private void FillOperationDetails(Operation operation)
        {
            documentsLabel.Visible = true;
            documentsPanel.Visible = true;
            addDocumentLinkLabel.Visible = true;
            CreateOperationDocumentsLinkLabels(operation.Documents);
        }

        private void CreateModelsLinkLabels(List<Model> models)
        {
            modelsLinkLabels = new List<LinkLabel>();
            modelDeleteButtons = new List<Button>();
            foreach (var model in models)
            {
                var modelLinkLabel = new LinkLabel()
                {
                    Name = model.Name + "LinkLabel",
                    Text = model.Name,
                    Tag = model,
                    Width = modelsNameFlowLayoutPanel.Width,
                    Height = 20,
                    Margin = new Padding(0, 5, 0, 0)
                };
                CreateModelDeleteButton(model);
                modelLinkLabel.Click += new EventHandler(modelLinkedLabel_Click);
                modelsLinkLabels.Add(modelLinkLabel);
                modelsNameFlowLayoutPanel.Controls.Add(modelLinkLabel);
            }
        }

        private void CreateModelDeleteButton(Model model)
        {
            var deleteButton = new Button()
            {
                Name = model.Name + "DeleteButton",
                Width = 20,
                Height = 20,
                Text = "-",
                Tag = model,
                Margin = new Padding(0, 5, 0, 0)
            };
            deleteButton.Click += new EventHandler(deleteModelButton_Click);
            modelDeleteButtons.Add(deleteButton);
            modelDeleteButtonsFlowLayoutPanel.Controls.Add(deleteButton);
        }

        private void modelLinkedLabel_Click(object sender, EventArgs e)
        {
            ClearModelDetails();
            var modelLinkedLabel = (LinkLabel)sender;
            currentModel = (Model)modelLinkedLabel.Tag;
            FillModelDetails(currentModel);
            FindAndSelectModelNode(projectsTreeView.Nodes, currentModel.Name);
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            if (currentProject == null)
            {
                MessageBox.Show("Проект не выбран! Сначала выберите проект!");
                return;
            }
            if (addModelNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("Нужно ввести название модели!");
                return;
            }
            foreach (var model in currentProject.Models)
            {
                if (addModelNameTextBox.Text.ToLower() == model.Name.ToLower())
                {
                    MessageBox.Show("Такая модель уже существует! Введите другое название!");
                    addModelNameTextBox.Focus();
                    return;
                }
            }
            var newModel = new Model();
            newModel.Name = addModelNameTextBox.Text;
            projectService.AddModel(newModel, currentProject.ID);
            currentProject = projectService.GetProject(currentProject.ID);
            var project = projects.FirstOrDefault(p => p.ID == currentProject.ID);
            project = currentProject;
            FillTreeView();
            ClearProjectDetails();
            ClearModelDetails();
            CreateModelsLinkLabels(currentProject.Models);
            FillModelDetails(newModel);
            addModelNameTextBox.Text = String.Empty;
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            var modelDeleteButton = (Button)sender;
            var model = (Model)modelDeleteButton.Tag;
            if (model.Operations.Count != 0)
            {
                MessageBox.Show($"модель {model.Name} нельзя удалить, т.к. оан содержит по крайней мере одну операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Удалить модель {model.Name}?", "Удаление модели", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                projectService.DeleteModel(model);
                currentProject.Models.Remove(model);
                ClearProjectDetails();
                ClearModelDetails();
                CreateModelsLinkLabels(currentProject.Models);
                FillTreeView();
            }
        }

        private void CreateOperationsLinkLabels(List<Operation> operations)
        {
            operationsLinkLabels = new List<LinkLabel>();
            operationsDeleteButtons = new List<Button>();
            foreach (var operation in operations)
            {
                var operationLinkLabel = new LinkLabel()
                {
                    Name = operation.Name + "LinkLabel",
                    Text = operation.Name,
                    Tag = operation,
                    Width = operationsNameFlowLayoutPanel.Width,
                    Height = 20,
                    Margin = new Padding(0, 5, 0, 0)
                };
                CreateOperationsDeleteButton(operation);
                operationLinkLabel.Click += new EventHandler(operationLinkedLabel_Click);
                operationsLinkLabels.Add(operationLinkLabel);
                operationsNameFlowLayoutPanel.Controls.Add(operationLinkLabel);
            }
        }

        private void CreateOperationsDeleteButton(Operation operation)
        {
            var operationDeleteButton = new Button()
            {
                Name = operation.Name + "DeleteButton",
                Width = 20,
                Height = 20,
                Text = "-",
                Tag = operation,
                Margin = new Padding(0, 5, 0, 0)
            };
            operationDeleteButton.Click += new EventHandler(deleteOperationButton_Click);
            operationsDeleteButtons.Add(operationDeleteButton);
            operationDeleteButtonsFlowLayoutPanel.Controls.Add(operationDeleteButton);
        }

        private void operationLinkedLabel_Click(object sender, EventArgs e)
        {
            ClearOperationDetails();
            var operationLinkLabel = (LinkLabel)sender;
            operationLinkLabel.LinkColor = Color.Black;
            currentOperation = (Operation)operationLinkLabel.Tag;
            FillOperationDetails(currentOperation);
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            if (currentModel == null && modelDetailsGroupBox.Text == String.Empty)
            {
                MessageBox.Show("Модель не выбрана!");
                return;
            }
            if (addOperationTextBox.Text == String.Empty)
            {
                MessageBox.Show("Нужно ввести название операции!");
                return;
            }
            foreach (var operation in currentModel.Operations)
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
            newOperation = projectService.AddOperation(newOperation, currentModel.ID);
            currentModel.Operations.Add(newOperation);
            ClearModelDetails();
            FillModelDetails(currentModel);
            addOperationTextBox.Text = String.Empty;
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
                    projectService.DeleteOperation(operation.ID);
                    currentModel.Operations.Remove(operation);
                    ClearModelDetails();
                    FillModelDetails(currentModel);
                }
            }
        }

        private void CreateOperationDocumentsLinkLabels(List<Document> documents)
        {
            operationDocumentsLinkLabels = new List<LinkLabel>();
            foreach (var document in documents)
            {
                var documentLinkLabel = new LinkLabel()
                {
                    Name = document.Name + "LinkLabel",
                    Text = document.Name,
                    Tag = document,
                    Width = operationDocumentsFlowLayoutPanel.Width,
                    Margin = new Padding(0, 0, 0, 5),
                };
                documentLinkLabel.Click += new EventHandler(documentLinkLabel_Click);
                operationDocumentsLinkLabels.Add(documentLinkLabel);
                operationDocumentsFlowLayoutPanel.Controls.Add(documentLinkLabel);
            }
            if (operationDocumentsLinkLabels.Count > 0)
            {
                if (operationDocumentsLinkLabels.Count >= 5)
                {
                    addDocumentLinkLabel.Visible = false;
                    return;
                }
                operationDocumentsFlowLayoutPanel.Controls.Add(addDocumentLinkLabel);
            }
        }

        private void addDocumentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.FileName = String.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var document = new Document(openFileDialog.SafeFileName, openFileDialog.FileName);
            currentOperation.Documents.Add(document);
            projectService.AddDocument(document, currentOperation.ID);
            ClearOperationDetails();
            FillOperationDetails(currentOperation);
        }

        private void documentLinkLabel_Click(object sender, EventArgs e)
        {
            var documentLabel = (LinkLabel)sender;
            var document = (Document)documentLabel.Tag;
            if (FileProvider.IsExist(document.Path))
            {
                System.Diagnostics.Process.Start(document.Path);
            }
            else
            {
                var result = MessageBox.Show("Такой документ отсутствует или был удалён.\nУдалить ссылку на документ?",
                    "Файл не найден!", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
                projectService.DeleteDocument(document);
                currentOperation.Documents.Remove(document);
                ClearOperationDetails();
                FillOperationDetails(currentOperation);
            }
        }

        private void DisposeLinkLabels(List<LinkLabel> linkLabels)
        {
            if (linkLabels != null)
            {
                foreach (var label in linkLabels)
                {
                    label.LinkColor = Color.FromArgb(0,0,255);
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
            modelPanel.Focus();
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
    }
}
