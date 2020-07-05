namespace staff_qualification_Forms
{
    partial class ProjectEditForm
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
            this.addProjectTextBox = new System.Windows.Forms.TextBox();
            this.saveProjectButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.addModelButton = new System.Windows.Forms.Button();
            this.addModelNameTextBox = new System.Windows.Forms.TextBox();
            this.listModelLabel = new System.Windows.Forms.Label();
            this.modelListBox = new System.Windows.Forms.ListBox();
            this.deleteModelButton = new System.Windows.Forms.Button();
            this.operationsListBox = new System.Windows.Forms.ListBox();
            this.listOperationsLabel = new System.Windows.Forms.Label();
            this.deleteOperationButton = new System.Windows.Forms.Button();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.addOperationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addProjectTextBox
            // 
            this.addProjectTextBox.Location = new System.Drawing.Point(15, 36);
            this.addProjectTextBox.Name = "addProjectTextBox";
            this.addProjectTextBox.Size = new System.Drawing.Size(221, 20);
            this.addProjectTextBox.TabIndex = 12;
            // 
            // saveProjectButton
            // 
            this.saveProjectButton.Location = new System.Drawing.Point(444, 33);
            this.saveProjectButton.Name = "saveProjectButton";
            this.saveProjectButton.Size = new System.Drawing.Size(95, 23);
            this.saveProjectButton.TabIndex = 11;
            this.saveProjectButton.Text = "Сохранить";
            this.saveProjectButton.UseVisualStyleBackColor = true;
            this.saveProjectButton.Click += new System.EventHandler(this.saveProjectButton_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(12, 13);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(44, 13);
            this.projectNameLabel.TabIndex = 13;
            this.projectNameLabel.Text = "Проект";
            // 
            // addModelButton
            // 
            this.addModelButton.Location = new System.Drawing.Point(172, 80);
            this.addModelButton.Name = "addModelButton";
            this.addModelButton.Size = new System.Drawing.Size(28, 23);
            this.addModelButton.TabIndex = 15;
            this.addModelButton.Text = "+";
            this.addModelButton.UseVisualStyleBackColor = true;
            this.addModelButton.Click += new System.EventHandler(this.addModelButton_Click);
            // 
            // addModelNameTextBox
            // 
            this.addModelNameTextBox.Location = new System.Drawing.Point(15, 109);
            this.addModelNameTextBox.Name = "addModelNameTextBox";
            this.addModelNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.addModelNameTextBox.TabIndex = 14;
            // 
            // listModelLabel
            // 
            this.listModelLabel.AutoSize = true;
            this.listModelLabel.Location = new System.Drawing.Point(12, 86);
            this.listModelLabel.Name = "listModelLabel";
            this.listModelLabel.Size = new System.Drawing.Size(94, 13);
            this.listModelLabel.TabIndex = 16;
            this.listModelLabel.Text = "Список моделей:";
            // 
            // modelListBox
            // 
            this.modelListBox.FormattingEnabled = true;
            this.modelListBox.Location = new System.Drawing.Point(15, 141);
            this.modelListBox.Name = "modelListBox";
            this.modelListBox.Size = new System.Drawing.Size(221, 134);
            this.modelListBox.TabIndex = 17;
            this.modelListBox.SelectedIndexChanged += new System.EventHandler(this.modelListBox_SelectedIndexChanged);
            // 
            // deleteModelButton
            // 
            this.deleteModelButton.Location = new System.Drawing.Point(206, 80);
            this.deleteModelButton.Name = "deleteModelButton";
            this.deleteModelButton.Size = new System.Drawing.Size(28, 23);
            this.deleteModelButton.TabIndex = 18;
            this.deleteModelButton.Text = "-";
            this.deleteModelButton.UseVisualStyleBackColor = true;
            this.deleteModelButton.Click += new System.EventHandler(this.deleteModelButton_Click);
            // 
            // operationsListBox
            // 
            this.operationsListBox.FormattingEnabled = true;
            this.operationsListBox.Location = new System.Drawing.Point(267, 141);
            this.operationsListBox.Name = "operationsListBox";
            this.operationsListBox.Size = new System.Drawing.Size(272, 134);
            this.operationsListBox.TabIndex = 19;
            // 
            // listOperationsLabel
            // 
            this.listOperationsLabel.AutoSize = true;
            this.listOperationsLabel.Location = new System.Drawing.Point(262, 86);
            this.listOperationsLabel.Name = "listOperationsLabel";
            this.listOperationsLabel.Size = new System.Drawing.Size(98, 13);
            this.listOperationsLabel.TabIndex = 20;
            this.listOperationsLabel.Text = "Список операций:";
            // 
            // deleteOperationButton
            // 
            this.deleteOperationButton.Location = new System.Drawing.Point(511, 80);
            this.deleteOperationButton.Name = "deleteOperationButton";
            this.deleteOperationButton.Size = new System.Drawing.Size(28, 23);
            this.deleteOperationButton.TabIndex = 22;
            this.deleteOperationButton.Text = "-";
            this.deleteOperationButton.UseVisualStyleBackColor = true;
            // 
            // addOperationButton
            // 
            this.addOperationButton.Location = new System.Drawing.Point(477, 80);
            this.addOperationButton.Name = "addOperationButton";
            this.addOperationButton.Size = new System.Drawing.Size(28, 23);
            this.addOperationButton.TabIndex = 21;
            this.addOperationButton.Text = "+";
            this.addOperationButton.UseVisualStyleBackColor = true;
            this.addOperationButton.Click += new System.EventHandler(this.addOperationButton_Click);
            // 
            // addOperationTextBox
            // 
            this.addOperationTextBox.Location = new System.Drawing.Point(267, 109);
            this.addOperationTextBox.Name = "addOperationTextBox";
            this.addOperationTextBox.Size = new System.Drawing.Size(272, 20);
            this.addOperationTextBox.TabIndex = 23;
            // 
            // ProjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 315);
            this.Controls.Add(this.addOperationTextBox);
            this.Controls.Add(this.deleteOperationButton);
            this.Controls.Add(this.addOperationButton);
            this.Controls.Add(this.listOperationsLabel);
            this.Controls.Add(this.operationsListBox);
            this.Controls.Add(this.deleteModelButton);
            this.Controls.Add(this.modelListBox);
            this.Controls.Add(this.listModelLabel);
            this.Controls.Add(this.addModelButton);
            this.Controls.Add(this.addModelNameTextBox);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.addProjectTextBox);
            this.Controls.Add(this.saveProjectButton);
            this.Name = "ProjectEditForm";
            this.Text = "ProjectEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProjectTextBox;
        private System.Windows.Forms.Button saveProjectButton;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Button addModelButton;
        private System.Windows.Forms.TextBox addModelNameTextBox;
        private System.Windows.Forms.Label listModelLabel;
        private System.Windows.Forms.ListBox modelListBox;
        private System.Windows.Forms.Button deleteModelButton;
        private System.Windows.Forms.ListBox operationsListBox;
        private System.Windows.Forms.Label listOperationsLabel;
        private System.Windows.Forms.Button deleteOperationButton;
        private System.Windows.Forms.Button addOperationButton;
        private System.Windows.Forms.TextBox addOperationTextBox;
    }
}