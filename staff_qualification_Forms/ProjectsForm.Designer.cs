namespace staff_qualification_Forms
{
    partial class ProjectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsTreeView = new System.Windows.Forms.TreeView();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.operationsListBox = new System.Windows.Forms.ListBox();
            this.operationsLabel = new System.Windows.Forms.Label();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.addOperationTextBox = new System.Windows.Forms.TextBox();
            this.addModelNameTextBox = new System.Windows.Forms.TextBox();
            this.addModelButton = new System.Windows.Forms.Button();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.addProjectTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.модельToolStripMenuItem});
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // модельToolStripMenuItem
            // 
            this.модельToolStripMenuItem.Name = "модельToolStripMenuItem";
            this.модельToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.модельToolStripMenuItem.Text = "Модель";
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.Location = new System.Drawing.Point(0, 53);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.Size = new System.Drawing.Size(199, 341);
            this.projectsTreeView.TabIndex = 0;
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Location = new System.Drawing.Point(410, 183);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(104, 13);
            this.modelNameLabel.TabIndex = 2;
            this.modelNameLabel.Text = "Назввание модели";
            // 
            // operationsListBox
            // 
            this.operationsListBox.FormattingEnabled = true;
            this.operationsListBox.Location = new System.Drawing.Point(413, 234);
            this.operationsListBox.Name = "operationsListBox";
            this.operationsListBox.Size = new System.Drawing.Size(245, 160);
            this.operationsListBox.TabIndex = 3;
            // 
            // operationsLabel
            // 
            this.operationsLabel.AutoSize = true;
            this.operationsLabel.Location = new System.Drawing.Point(410, 218);
            this.operationsLabel.Name = "operationsLabel";
            this.operationsLabel.Size = new System.Drawing.Size(60, 13);
            this.operationsLabel.TabIndex = 4;
            this.operationsLabel.Text = "Операции:";
            // 
            // addOperationButton
            // 
            this.addOperationButton.Location = new System.Drawing.Point(216, 265);
            this.addOperationButton.Name = "addOperationButton";
            this.addOperationButton.Size = new System.Drawing.Size(157, 23);
            this.addOperationButton.TabIndex = 5;
            this.addOperationButton.Text = "Добавить опреацию";
            this.addOperationButton.UseVisualStyleBackColor = true;
            // 
            // addOperationTextBox
            // 
            this.addOperationTextBox.Location = new System.Drawing.Point(216, 234);
            this.addOperationTextBox.Name = "addOperationTextBox";
            this.addOperationTextBox.Size = new System.Drawing.Size(157, 20);
            this.addOperationTextBox.TabIndex = 6;
            // 
            // addModelNameTextBox
            // 
            this.addModelNameTextBox.Location = new System.Drawing.Point(216, 138);
            this.addModelNameTextBox.Name = "addModelNameTextBox";
            this.addModelNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.addModelNameTextBox.TabIndex = 7;
            // 
            // addModelButton
            // 
            this.addModelButton.Location = new System.Drawing.Point(216, 183);
            this.addModelButton.Name = "addModelButton";
            this.addModelButton.Size = new System.Drawing.Size(154, 23);
            this.addModelButton.TabIndex = 8;
            this.addModelButton.Text = "Добавить модель";
            this.addModelButton.UseVisualStyleBackColor = true;
            this.addModelButton.Click += new System.EventHandler(this.addModelButton_Click);
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(216, 84);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(154, 23);
            this.addProjectButton.TabIndex = 9;
            this.addProjectButton.Text = "Добавить проект";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // addProjectTextBox
            // 
            this.addProjectTextBox.Location = new System.Drawing.Point(216, 53);
            this.addProjectTextBox.Name = "addProjectTextBox";
            this.addProjectTextBox.Size = new System.Drawing.Size(154, 20);
            this.addProjectTextBox.TabIndex = 10;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 394);
            this.Controls.Add(this.addProjectTextBox);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.addModelButton);
            this.Controls.Add(this.addModelNameTextBox);
            this.Controls.Add(this.addOperationTextBox);
            this.Controls.Add(this.addOperationButton);
            this.Controls.Add(this.operationsLabel);
            this.Controls.Add(this.operationsListBox);
            this.Controls.Add(this.modelNameLabel);
            this.Controls.Add(this.projectsTreeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectsForm";
            this.Text = "Проекты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модельToolStripMenuItem;
        private System.Windows.Forms.TreeView projectsTreeView;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.ListBox operationsListBox;
        private System.Windows.Forms.Label operationsLabel;
        private System.Windows.Forms.Button addOperationButton;
        private System.Windows.Forms.TextBox addOperationTextBox;
        private System.Windows.Forms.TextBox addModelNameTextBox;
        private System.Windows.Forms.Button addModelButton;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.TextBox addProjectTextBox;
    }
}

