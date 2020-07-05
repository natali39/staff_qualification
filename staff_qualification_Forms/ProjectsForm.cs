using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ProjectsForm : Form
    {
        List<Project> projects;
        Project project;
        Model model;
        bool isChanged = false;
        
        public ProjectsForm()
        {
            InitializeComponent();
            projects = Project.GetAll(); 
            if (projects == null)
                projects = new List<Project>();
            FillTreeView();
        }

        private void FillTreeView()
        {
            projectsTreeView.BeginUpdate();
            projectsTreeView.Nodes.Clear();
            if (projects != null)
            {
                foreach (var project in projects)
                {
                    var projectNode = new TreeNode(project.Name);
                    projectNode.Tag = project;
                    projectsTreeView.Nodes.Add(projectNode);

                    try
                    {
                        foreach (var model in project.Models)
                        {
                            var modelNode = new TreeNode(model.Name);
                            modelNode.Tag = model;
                            projectsTreeView.Nodes[projects.IndexOf(project)].Nodes.Add(modelNode);
                        }
                    }
                    catch (Exception ex) { }
                }
                projectsTreeView.EndUpdate();
            }
        }

        private void проектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProject();
        }

        private void addProjectButton_Click_1(object sender, EventArgs e)
        {
            AddProject();
        }

        private void AddProject()
        {
            project = new Project();
            var projectEditForm = new ProjectEditForm(project);
            projectEditForm.ShowDialog();
            if (projectEditForm.project != null)
            {
                projects.Add(projectEditForm.project);
                FillTreeView();
            }
        }

        private void ProjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Сохранить изменения?", "Проекты", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Project.Update(projects);
            }
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsTreeView.SelectedNode != null)
            {
                if (projectsTreeView.SelectedNode.Level == 0)
                {
                    project = (Project)projectsTreeView.SelectedNode.Tag;
                    projects.Remove(project);
                }
                else if (projectsTreeView.SelectedNode.Level == 1)
                {
                    model = (Model)projectsTreeView.SelectedNode.Tag;
                    project = (Project)projectsTreeView.SelectedNode.Parent.Tag;
                    project.Models.Remove(model);
                }
                FillTreeView();
            }
        }

        private void projectsTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (projectsTreeView.SelectedNode.Level == 0)
            {
                project = (Project)projectsTreeView.SelectedNode.Tag;
                var projectEditForm = new ProjectEditForm(project);
                projectEditForm.ShowDialog();
                FillTreeView();
            }
        }

        private void projectsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (projectsTreeView.SelectedNode.Level == 1)
            {
                model = (Model)projectsTreeView.SelectedNode.Tag;
                modelNameLabel.Text = model.Name;
                GetListOperations(model);
            }
        }

        private void GetListOperations(Model model)
        {
            operationsListBox.Items.Clear();
            foreach (var operation in model.Operations)
            {
                operationsListBox.Items.Add(operation.Name);
            }
        }
    }
}
