namespace staff_qualification_Forms
{
    partial class MainForm
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
            this.listSectionMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОбучениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самоконтрольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.outputDataGridView = new System.Windows.Forms.DataGridView();
            this.projecstLabel = new System.Windows.Forms.Label();
            this.modelsLabel = new System.Windows.Forms.Label();
            this.QualificationLabel = new System.Windows.Forms.Label();
            this.noTrainingCheckBox = new System.Windows.Forms.CheckBox();
            this.endTrainingCheckBox = new System.Windows.Forms.CheckBox();
            this.onTrainingCheckBox = new System.Windows.Forms.CheckBox();
            this.selfChekCheckBox = new System.Windows.Forms.CheckBox();
            this.modelsPanel = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.selectAllModelsCheckBox = new System.Windows.Forms.CheckBox();
            this.listSectionMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listSectionMenuStrip1
            // 
            this.listSectionMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.спискиToolStripMenuItem,
            this.документыToolStripMenuItem});
            this.listSectionMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.listSectionMenuStrip1.Name = "listSectionMenuStrip1";
            this.listSectionMenuStrip1.Size = new System.Drawing.Size(868, 24);
            this.listSectionMenuStrip1.TabIndex = 2;
            this.listSectionMenuStrip1.Text = "ListSectionMenuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.проектыToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.проектыToolStripMenuItem.Text = "Проекты";
            this.проектыToolStripMenuItem.Click += new System.EventHandler(this.проектыToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обучениеToolStripMenuItem,
            this.самоконтрольToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // обучениеToolStripMenuItem
            // 
            this.обучениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеОбучениеToolStripMenuItem,
            this.посмотретьВсеToolStripMenuItem});
            this.обучениеToolStripMenuItem.Name = "обучениеToolStripMenuItem";
            this.обучениеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.обучениеToolStripMenuItem.Text = "Обучение";
            // 
            // новоеОбучениеToolStripMenuItem
            // 
            this.новоеОбучениеToolStripMenuItem.Name = "новоеОбучениеToolStripMenuItem";
            this.новоеОбучениеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.новоеОбучениеToolStripMenuItem.Text = "Новое обучение";
            this.новоеОбучениеToolStripMenuItem.Click += new System.EventHandler(this.новоеОбучениеToolStripMenuItem_Click);
            // 
            // посмотретьВсеToolStripMenuItem
            // 
            this.посмотретьВсеToolStripMenuItem.Name = "посмотретьВсеToolStripMenuItem";
            this.посмотретьВсеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.посмотретьВсеToolStripMenuItem.Text = "Посмотреть все";
            this.посмотретьВсеToolStripMenuItem.Click += new System.EventHandler(this.посмотретьВсеОбученияToolStripMenuItem_Click);
            // 
            // самоконтрольToolStripMenuItem
            // 
            this.самоконтрольToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.самоконтрольToolStripMenuItem.Name = "самоконтрольToolStripMenuItem";
            this.самоконтрольToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.самоконтрольToolStripMenuItem.Text = "Самоконтроль";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.новыйToolStripMenuItem.Text = "Новый самоконтроль";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйСамоконтрольToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.просмотрToolStripMenuItem.Text = "Посмотреть все";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(82, 44);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(159, 21);
            this.projectComboBox.TabIndex = 3;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // outputDataGridView
            // 
            this.outputDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.outputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGridView.Location = new System.Drawing.Point(0, 368);
            this.outputDataGridView.Name = "outputDataGridView";
            this.outputDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.outputDataGridView.Size = new System.Drawing.Size(868, 264);
            this.outputDataGridView.TabIndex = 7;
            // 
            // projecstLabel
            // 
            this.projecstLabel.AutoSize = true;
            this.projecstLabel.Location = new System.Drawing.Point(7, 47);
            this.projecstLabel.Name = "projecstLabel";
            this.projecstLabel.Size = new System.Drawing.Size(55, 13);
            this.projecstLabel.TabIndex = 8;
            this.projecstLabel.Text = "Проекты:";
            // 
            // modelsLabel
            // 
            this.modelsLabel.AutoSize = true;
            this.modelsLabel.Location = new System.Drawing.Point(7, 81);
            this.modelsLabel.Name = "modelsLabel";
            this.modelsLabel.Size = new System.Drawing.Size(49, 13);
            this.modelsLabel.TabIndex = 9;
            this.modelsLabel.Text = "Модели:";
            // 
            // QualificationLabel
            // 
            this.QualificationLabel.AutoSize = true;
            this.QualificationLabel.Location = new System.Drawing.Point(7, 326);
            this.QualificationLabel.Name = "QualificationLabel";
            this.QualificationLabel.Size = new System.Drawing.Size(85, 13);
            this.QualificationLabel.TabIndex = 12;
            this.QualificationLabel.Text = "Квалификация:";
            // 
            // noTrainingCheckBox
            // 
            this.noTrainingCheckBox.AutoSize = true;
            this.noTrainingCheckBox.Location = new System.Drawing.Point(463, 326);
            this.noTrainingCheckBox.Name = "noTrainingCheckBox";
            this.noTrainingCheckBox.Size = new System.Drawing.Size(89, 17);
            this.noTrainingCheckBox.TabIndex = 13;
            this.noTrainingCheckBox.Text = "Не обучался";
            this.noTrainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // endTrainingCheckBox
            // 
            this.endTrainingCheckBox.AutoSize = true;
            this.endTrainingCheckBox.Location = new System.Drawing.Point(111, 326);
            this.endTrainingCheckBox.Name = "endTrainingCheckBox";
            this.endTrainingCheckBox.Size = new System.Drawing.Size(115, 17);
            this.endTrainingCheckBox.TabIndex = 14;
            this.endTrainingCheckBox.Text = "Прошел обучение";
            this.endTrainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // onTrainingCheckBox
            // 
            this.onTrainingCheckBox.AutoSize = true;
            this.onTrainingCheckBox.Location = new System.Drawing.Point(357, 326);
            this.onTrainingCheckBox.Name = "onTrainingCheckBox";
            this.onTrainingCheckBox.Size = new System.Drawing.Size(89, 17);
            this.onTrainingCheckBox.TabIndex = 15;
            this.onTrainingCheckBox.Text = "На обучении";
            this.onTrainingCheckBox.UseVisualStyleBackColor = true;
            // 
            // selfChekCheckBox
            // 
            this.selfChekCheckBox.AutoSize = true;
            this.selfChekCheckBox.Location = new System.Drawing.Point(242, 326);
            this.selfChekCheckBox.Name = "selfChekCheckBox";
            this.selfChekCheckBox.Size = new System.Drawing.Size(100, 17);
            this.selfChekCheckBox.TabIndex = 16;
            this.selfChekCheckBox.Text = "Самоконтроль";
            this.selfChekCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelsPanel
            // 
            this.modelsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelsPanel.AutoScroll = true;
            this.modelsPanel.Location = new System.Drawing.Point(0, 100);
            this.modelsPanel.Name = "modelsPanel";
            this.modelsPanel.Size = new System.Drawing.Size(868, 201);
            this.modelsPanel.TabIndex = 20;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(680, 322);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(145, 23);
            this.reportButton.TabIndex = 21;
            this.reportButton.Text = "Показать результат";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // selectAllModelsCheckBox
            // 
            this.selectAllModelsCheckBox.AutoSize = true;
            this.selectAllModelsCheckBox.Location = new System.Drawing.Point(82, 80);
            this.selectAllModelsCheckBox.Name = "selectAllModelsCheckBox";
            this.selectAllModelsCheckBox.Size = new System.Drawing.Size(91, 17);
            this.selectAllModelsCheckBox.TabIndex = 22;
            this.selectAllModelsCheckBox.Text = "Выбрать все";
            this.selectAllModelsCheckBox.UseVisualStyleBackColor = true;
            this.selectAllModelsCheckBox.CheckedChanged += new System.EventHandler(this.selectAllModelsCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 632);
            this.Controls.Add(this.selectAllModelsCheckBox);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.modelsPanel);
            this.Controls.Add(this.selfChekCheckBox);
            this.Controls.Add(this.onTrainingCheckBox);
            this.Controls.Add(this.endTrainingCheckBox);
            this.Controls.Add(this.noTrainingCheckBox);
            this.Controls.Add(this.QualificationLabel);
            this.Controls.Add(this.modelsLabel);
            this.Controls.Add(this.projecstLabel);
            this.Controls.Add(this.outputDataGridView);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.listSectionMenuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квалификация сотрудников";
            this.listSectionMenuStrip1.ResumeLayout(false);
            this.listSectionMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip listSectionMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самоконтрольToolStripMenuItem;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.ToolStripMenuItem новоеОбучениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.DataGridView outputDataGridView;
        private System.Windows.Forms.Label projecstLabel;
        private System.Windows.Forms.Label modelsLabel;
        private System.Windows.Forms.Label QualificationLabel;
        private System.Windows.Forms.CheckBox noTrainingCheckBox;
        private System.Windows.Forms.CheckBox endTrainingCheckBox;
        private System.Windows.Forms.CheckBox onTrainingCheckBox;
        private System.Windows.Forms.CheckBox selfChekCheckBox;
        private System.Windows.Forms.Panel modelsPanel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.CheckBox selectAllModelsCheckBox;
    }
}

