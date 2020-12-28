namespace staff_qualification_Forms
{
    partial class InputProjectNameForm
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
            this.addProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProjectNameTextBox
            // 
            this.addProjectNameTextBox.AcceptsTab = true;
            this.addProjectNameTextBox.Location = new System.Drawing.Point(15, 36);
            this.addProjectNameTextBox.Name = "addProjectNameTextBox";
            this.addProjectNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.addProjectNameTextBox.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(251, 34);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(12, 13);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(147, 13);
            this.projectNameLabel.TabIndex = 13;
            this.projectNameLabel.Text = "Введите название проекта:";
            // 
            // InputProjectNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 98);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.addProjectNameTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "InputProjectNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый проект";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputProjectNameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProjectNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label projectNameLabel;
    }
}