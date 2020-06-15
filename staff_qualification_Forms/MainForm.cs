using System;
using System.Windows.Forms;

namespace staff_qualification_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
        
