namespace staff_qualification_Forms
{
    partial class TrainingForm
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
            this.trainingIdLabel = new System.Windows.Forms.Label();
            this.trainingIdTextBox = new System.Windows.Forms.TextBox();
            this.staffNameTextBox = new System.Windows.Forms.TextBox();
            this.staffNameLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.trainerTextBox = new System.Windows.Forms.TextBox();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.startTrainingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTrainingLabel = new System.Windows.Forms.Label();
            this.endTrainingLabel = new System.Windows.Forms.Label();
            this.endTrainingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generateDocumentButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.selectStaffButton = new System.Windows.Forms.Button();
            this.selectTrainerButton = new System.Windows.Forms.Button();
            this.operationLabel = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // trainingIdLabel
            // 
            this.trainingIdLabel.AutoSize = true;
            this.trainingIdLabel.Location = new System.Drawing.Point(23, 28);
            this.trainingIdLabel.Name = "trainingIdLabel";
            this.trainingIdLabel.Size = new System.Drawing.Size(101, 13);
            this.trainingIdLabel.TabIndex = 0;
            this.trainingIdLabel.Text = "Номер документа:";
            // 
            // trainingIdTextBox
            // 
            this.trainingIdTextBox.Location = new System.Drawing.Point(142, 28);
            this.trainingIdTextBox.Name = "trainingIdTextBox";
            this.trainingIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.trainingIdTextBox.TabIndex = 1;
            // 
            // staffNameTextBox
            // 
            this.staffNameTextBox.Location = new System.Drawing.Point(142, 65);
            this.staffNameTextBox.Name = "staffNameTextBox";
            this.staffNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.staffNameTextBox.TabIndex = 3;
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.AutoSize = true;
            this.staffNameLabel.Location = new System.Drawing.Point(23, 69);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(63, 13);
            this.staffNameLabel.TabIndex = 2;
            this.staffNameLabel.Text = "Сотрудник:";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(23, 157);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(47, 13);
            this.projectLabel.TabIndex = 4;
            this.projectLabel.Text = "Проект:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(23, 199);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(49, 13);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Модель:";
            // 
            // trainerTextBox
            // 
            this.trainerTextBox.Location = new System.Drawing.Point(142, 108);
            this.trainerTextBox.Name = "trainerTextBox";
            this.trainerTextBox.Size = new System.Drawing.Size(295, 20);
            this.trainerTextBox.TabIndex = 9;
            // 
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Location = new System.Drawing.Point(23, 112);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(69, 13);
            this.trainerLabel.TabIndex = 8;
            this.trainerLabel.Text = "Инструктор:";
            // 
            // startTrainingDateTimePicker
            // 
            this.startTrainingDateTimePicker.Location = new System.Drawing.Point(26, 311);
            this.startTrainingDateTimePicker.Name = "startTrainingDateTimePicker";
            this.startTrainingDateTimePicker.Size = new System.Drawing.Size(165, 20);
            this.startTrainingDateTimePicker.TabIndex = 10;
            this.startTrainingDateTimePicker.ValueChanged += new System.EventHandler(this.startTrainingDateTimePicker_ValueChanged);
            // 
            // startTrainingLabel
            // 
            this.startTrainingLabel.AutoSize = true;
            this.startTrainingLabel.Location = new System.Drawing.Point(23, 285);
            this.startTrainingLabel.Name = "startTrainingLabel";
            this.startTrainingLabel.Size = new System.Drawing.Size(96, 13);
            this.startTrainingLabel.TabIndex = 11;
            this.startTrainingLabel.Text = "Начало обучения:";
            // 
            // endTrainingLabel
            // 
            this.endTrainingLabel.AutoSize = true;
            this.endTrainingLabel.Location = new System.Drawing.Point(270, 285);
            this.endTrainingLabel.Name = "endTrainingLabel";
            this.endTrainingLabel.Size = new System.Drawing.Size(114, 13);
            this.endTrainingLabel.TabIndex = 13;
            this.endTrainingLabel.Text = "Окончание обучения:";
            // 
            // endTrainingDateTimePicker
            // 
            this.endTrainingDateTimePicker.Location = new System.Drawing.Point(273, 311);
            this.endTrainingDateTimePicker.Name = "endTrainingDateTimePicker";
            this.endTrainingDateTimePicker.Size = new System.Drawing.Size(165, 20);
            this.endTrainingDateTimePicker.TabIndex = 12;
            this.endTrainingDateTimePicker.ValueChanged += new System.EventHandler(this.endTrainingDateTimePicker_ValueChanged);
            // 
            // generateDocumentButton
            // 
            this.generateDocumentButton.Location = new System.Drawing.Point(26, 372);
            this.generateDocumentButton.Name = "generateDocumentButton";
            this.generateDocumentButton.Size = new System.Drawing.Size(165, 23);
            this.generateDocumentButton.TabIndex = 14;
            this.generateDocumentButton.Text = "Сформировать документ";
            this.generateDocumentButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(363, 372);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // selectStaffButton
            // 
            this.selectStaffButton.Location = new System.Drawing.Point(444, 64);
            this.selectStaffButton.Name = "selectStaffButton";
            this.selectStaffButton.Size = new System.Drawing.Size(25, 21);
            this.selectStaffButton.TabIndex = 16;
            this.selectStaffButton.Text = "...";
            this.selectStaffButton.UseVisualStyleBackColor = true;
            this.selectStaffButton.Click += new System.EventHandler(this.selectStaffButton_Click);
            // 
            // selectTrainerButton
            // 
            this.selectTrainerButton.Location = new System.Drawing.Point(444, 107);
            this.selectTrainerButton.Name = "selectTrainerButton";
            this.selectTrainerButton.Size = new System.Drawing.Size(25, 21);
            this.selectTrainerButton.TabIndex = 19;
            this.selectTrainerButton.Text = "...";
            this.selectTrainerButton.UseVisualStyleBackColor = true;
            this.selectTrainerButton.Click += new System.EventHandler(this.selectTrainerButton_Click);
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(24, 242);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(60, 13);
            this.operationLabel.TabIndex = 20;
            this.operationLabel.Text = "Операция:";
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(142, 151);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(295, 21);
            this.projectComboBox.TabIndex = 23;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(142, 195);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(295, 21);
            this.modelComboBox.TabIndex = 24;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(142, 239);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(295, 21);
            this.operationComboBox.TabIndex = 25;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.operationComboBox_SelectedIndexChanged);
            // 
            // NewTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 422);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.selectTrainerButton);
            this.Controls.Add(this.selectStaffButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generateDocumentButton);
            this.Controls.Add(this.endTrainingLabel);
            this.Controls.Add(this.endTrainingDateTimePicker);
            this.Controls.Add(this.startTrainingLabel);
            this.Controls.Add(this.startTrainingDateTimePicker);
            this.Controls.Add(this.trainerTextBox);
            this.Controls.Add(this.trainerLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.staffNameTextBox);
            this.Controls.Add(this.staffNameLabel);
            this.Controls.Add(this.trainingIdTextBox);
            this.Controls.Add(this.trainingIdLabel);
            this.Name = "NewTrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новое обучение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trainingIdLabel;
        private System.Windows.Forms.TextBox trainingIdTextBox;
        private System.Windows.Forms.TextBox staffNameTextBox;
        private System.Windows.Forms.Label staffNameLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox trainerTextBox;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.DateTimePicker startTrainingDateTimePicker;
        private System.Windows.Forms.Label startTrainingLabel;
        private System.Windows.Forms.Label endTrainingLabel;
        private System.Windows.Forms.DateTimePicker endTrainingDateTimePicker;
        private System.Windows.Forms.Button generateDocumentButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button selectStaffButton;
        private System.Windows.Forms.Button selectTrainerButton;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox operationComboBox;
    }
}