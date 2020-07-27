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
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.outputDataGridView = new System.Windows.Forms.DataGridView();
            this.projecstLabel = new System.Windows.Forms.Label();
            this.modelsLabel = new System.Windows.Forms.Label();
            this.operationsLabel = new System.Windows.Forms.Label();
            this.staffsLabel = new System.Windows.Forms.Label();
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
            this.посмотретьВсеToolStripMenuItem.Click += new System.EventHandler(this.посмотретьВсеToolStripMenuItem_Click);
            // 
            // самоконтрольToolStripMenuItem
            // 
            this.самоконтрольToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.самоконтрольToolStripMenuItem.Name = "самоконтрольToolStripMenuItem";
            this.самоконтрольToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
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
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(328, 44);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(218, 21);
            this.modelComboBox.TabIndex = 4;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(637, 44);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(219, 21);
            this.operationComboBox.TabIndex = 5;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.operationComboBox_SelectedIndexChanged);
            // 
            // staffComboBox
            // 
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(82, 94);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(331, 21);
            this.staffComboBox.TabIndex = 6;
            this.staffComboBox.SelectedIndexChanged += new System.EventHandler(this.staffComboBox_SelectedIndexChanged);
            this.staffComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.StaffComboBoxFormat);
            // 
            // outputDataGridView
            // 
            this.outputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputDataGridView.Location = new System.Drawing.Point(0, 183);
            this.outputDataGridView.Name = "outputDataGridView";
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
            this.modelsLabel.Location = new System.Drawing.Point(267, 47);
            this.modelsLabel.Name = "modelsLabel";
            this.modelsLabel.Size = new System.Drawing.Size(49, 13);
            this.modelsLabel.TabIndex = 9;
            this.modelsLabel.Text = "Модели:";
            // 
            // operationsLabel
            // 
            this.operationsLabel.AutoSize = true;
            this.operationsLabel.Location = new System.Drawing.Point(571, 47);
            this.operationsLabel.Name = "operationsLabel";
            this.operationsLabel.Size = new System.Drawing.Size(60, 13);
            this.operationsLabel.TabIndex = 10;
            this.operationsLabel.Text = "Операции:";
            // 
            // staffsLabel
            // 
            this.staffsLabel.AutoSize = true;
            this.staffsLabel.Location = new System.Drawing.Point(7, 97);
            this.staffsLabel.Name = "staffsLabel";
            this.staffsLabel.Size = new System.Drawing.Size(69, 13);
            this.staffsLabel.TabIndex = 11;
            this.staffsLabel.Text = "Сотрудники:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 447);
            this.Controls.Add(this.staffsLabel);
            this.Controls.Add(this.operationsLabel);
            this.Controls.Add(this.modelsLabel);
            this.Controls.Add(this.projecstLabel);
            this.Controls.Add(this.outputDataGridView);
            this.Controls.Add(this.staffComboBox);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.modelComboBox);
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
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.ToolStripMenuItem новоеОбучениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.DataGridView outputDataGridView;
        private System.Windows.Forms.Label projecstLabel;
        private System.Windows.Forms.Label modelsLabel;
        private System.Windows.Forms.Label operationsLabel;
        private System.Windows.Forms.Label staffsLabel;
    }
}

