namespace staff_qualification_Forms
{
    partial class SelfCheckForm
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
            this.selfCheckIdTextBox = new System.Windows.Forms.TextBox();
            this.selfCheckIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trainingTextBox = new System.Windows.Forms.TextBox();
            this.selectTrainingButton = new System.Windows.Forms.Button();
            this.selfCheckDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selfCheckDateLabel = new System.Windows.Forms.Label();
            this.generateDocumentButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.responsiblePersonLabel = new System.Windows.Forms.Label();
            this.responsiblePersonButton = new System.Windows.Forms.Button();
            this.responsiblePersonTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selfCheckIdTextBox
            // 
            this.selfCheckIdTextBox.Location = new System.Drawing.Point(143, 31);
            this.selfCheckIdTextBox.Name = "selfCheckIdTextBox";
            this.selfCheckIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.selfCheckIdTextBox.TabIndex = 3;
            // 
            // selfCheckIdLabel
            // 
            this.selfCheckIdLabel.AutoSize = true;
            this.selfCheckIdLabel.Location = new System.Drawing.Point(24, 31);
            this.selfCheckIdLabel.Name = "selfCheckIdLabel";
            this.selfCheckIdLabel.Size = new System.Drawing.Size(101, 13);
            this.selfCheckIdLabel.TabIndex = 2;
            this.selfCheckIdLabel.Text = "Номер документа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Обучение:";
            // 
            // trainingTextBox
            // 
            this.trainingTextBox.Location = new System.Drawing.Point(143, 75);
            this.trainingTextBox.Name = "trainingTextBox";
            this.trainingTextBox.Size = new System.Drawing.Size(278, 20);
            this.trainingTextBox.TabIndex = 5;
            // 
            // selectTrainingButton
            // 
            this.selectTrainingButton.Location = new System.Drawing.Point(427, 74);
            this.selectTrainingButton.Name = "selectTrainingButton";
            this.selectTrainingButton.Size = new System.Drawing.Size(25, 21);
            this.selectTrainingButton.TabIndex = 17;
            this.selectTrainingButton.Text = "...";
            this.selectTrainingButton.UseVisualStyleBackColor = true;
            this.selectTrainingButton.Click += new System.EventHandler(this.selectTrainingButton_Click);
            // 
            // selfCheckDateTimePicker
            // 
            this.selfCheckDateTimePicker.Location = new System.Drawing.Point(221, 310);
            this.selfCheckDateTimePicker.Name = "selfCheckDateTimePicker";
            this.selfCheckDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.selfCheckDateTimePicker.TabIndex = 18;
            this.selfCheckDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // selfCheckDateLabel
            // 
            this.selfCheckDateLabel.AutoSize = true;
            this.selfCheckDateLabel.Location = new System.Drawing.Point(24, 316);
            this.selfCheckDateLabel.Name = "selfCheckDateLabel";
            this.selfCheckDateLabel.Size = new System.Drawing.Size(169, 13);
            this.selfCheckDateLabel.TabIndex = 19;
            this.selfCheckDateLabel.Text = "Дата присвоения самоконтрля:";
            // 
            // generateDocumentButton
            // 
            this.generateDocumentButton.Location = new System.Drawing.Point(27, 374);
            this.generateDocumentButton.Name = "generateDocumentButton";
            this.generateDocumentButton.Size = new System.Drawing.Size(151, 23);
            this.generateDocumentButton.TabIndex = 20;
            this.generateDocumentButton.Text = "Сформировать документ";
            this.generateDocumentButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(346, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // responsiblePersonLabel
            // 
            this.responsiblePersonLabel.AutoSize = true;
            this.responsiblePersonLabel.Location = new System.Drawing.Point(24, 120);
            this.responsiblePersonLabel.Name = "responsiblePersonLabel";
            this.responsiblePersonLabel.Size = new System.Drawing.Size(114, 13);
            this.responsiblePersonLabel.TabIndex = 22;
            this.responsiblePersonLabel.Text = "Ответственное лицо:";
            // 
            // responsiblePersonButton
            // 
            this.responsiblePersonButton.Location = new System.Drawing.Point(427, 116);
            this.responsiblePersonButton.Name = "responsiblePersonButton";
            this.responsiblePersonButton.Size = new System.Drawing.Size(25, 21);
            this.responsiblePersonButton.TabIndex = 24;
            this.responsiblePersonButton.Text = "...";
            this.responsiblePersonButton.UseVisualStyleBackColor = true;
            this.responsiblePersonButton.Click += new System.EventHandler(this.responsiblePersonButton_Click);
            // 
            // responsiblePersonTextBox
            // 
            this.responsiblePersonTextBox.Location = new System.Drawing.Point(143, 117);
            this.responsiblePersonTextBox.Name = "responsiblePersonTextBox";
            this.responsiblePersonTextBox.Size = new System.Drawing.Size(278, 20);
            this.responsiblePersonTextBox.TabIndex = 23;
            // 
            // SelfCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 422);
            this.Controls.Add(this.responsiblePersonButton);
            this.Controls.Add(this.responsiblePersonTextBox);
            this.Controls.Add(this.responsiblePersonLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generateDocumentButton);
            this.Controls.Add(this.selfCheckDateLabel);
            this.Controls.Add(this.selfCheckDateTimePicker);
            this.Controls.Add(this.selectTrainingButton);
            this.Controls.Add(this.trainingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selfCheckIdTextBox);
            this.Controls.Add(this.selfCheckIdLabel);
            this.Name = "SelfCheckForm";
            this.Text = "SelfCheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selfCheckIdTextBox;
        private System.Windows.Forms.Label selfCheckIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trainingTextBox;
        private System.Windows.Forms.Button selectTrainingButton;
        private System.Windows.Forms.DateTimePicker selfCheckDateTimePicker;
        private System.Windows.Forms.Label selfCheckDateLabel;
        private System.Windows.Forms.Button generateDocumentButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label responsiblePersonLabel;
        private System.Windows.Forms.Button responsiblePersonButton;
        private System.Windows.Forms.TextBox responsiblePersonTextBox;
    }
}