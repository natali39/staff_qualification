using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class ProjectsForm : Form
    {
        List<Project> projects = new List<Project>();
        
        public ProjectsForm()
        {
            InitializeComponent();
            FillTreeView();
        }
        
        private void FillTreeView()
        {
            projectsTreeView.BeginUpdate();
            projectsTreeView.Nodes.Clear();

            foreach (var project in projects)
            {
                projectsTreeView.Nodes.Add(project.Name);

                try
                {
                    foreach (var model in project.Models)
                    {
                        var modelNode = new TreeNode(model.Name);
                        projectsTreeView.Nodes[projects.IndexOf(project)].Nodes.Add(modelNode);
                    }
                }
                catch (Exception ex) {  }
            }
            projectsTreeView.EndUpdate();
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            foreach (var project in projects)
            {
                try
                {
                    if (projectsTreeView.SelectedNode.Text == project.Name)
                    {
                        if (project.Models == null)
                        {
                            project.Models = new List<Model>();
                        }
                        Model model = new Model(addModelNameTextBox.Text);
                        project.Models.Add(model);
                    }
                }
                catch (Exception ex) { }
            }
            FillTreeView();
        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            if (addProjectTextBox.Text != string.Empty)
            {
                var project = new Project(addProjectTextBox.Text);
                projects.Add(project);
            }
            FillTreeView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillTreeView();
        }
    }
}
