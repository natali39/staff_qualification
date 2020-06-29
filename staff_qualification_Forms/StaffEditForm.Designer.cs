namespace staff_qualification_Forms
{
    partial class StaffEditForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(39, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(96, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(39, 101);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(315, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(164, 263);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(36, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(99, 13);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Табельный номер";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(36, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(161, 30);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(65, 13);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Должность";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(36, 139);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "Имя";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(39, 155);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(315, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(36, 195);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.middleNameLabel.TabIndex = 10;
            this.middleNameLabel.Text = "Отчество";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(39, 211);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(315, 20);
            this.middleNameTextBox.TabIndex = 9;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(164, 46);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(190, 21);
            this.positionComboBox.TabIndex = 11;
            // 
            // StaffEditForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 311);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "StaffEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.ComboBox positionComboBox;
    }
}