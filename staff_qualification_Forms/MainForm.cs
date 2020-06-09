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
            var staffForm = new StaffForm();
            staffForm.ShowDialog();
        }
    }
}
        
