using System;
using System.Windows.Forms;

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
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsTreeView = new System.Windows.Forms.TreeView();
            this.operationsLabel = new System.Windows.Forms.Label();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.modelDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.operationDeleteButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.operationsNameFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addOperationTextBox = new System.Windows.Forms.TextBox();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.projectDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.modelDeleteButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.modelsNameFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addModelNameTextBox = new System.Windows.Forms.TextBox();
            this.addModelButton = new System.Windows.Forms.Button();
            this.listModelLabel = new System.Windows.Forms.Label();
            this.modelPictureBox = new System.Windows.Forms.PictureBox();
            this.modelImageLabel = new System.Windows.Forms.Label();
            this.addModelImageButton = new System.Windows.Forms.Button();
            this.documentsLabel = new System.Windows.Forms.Label();
            this.addDocumentLinkLabel = new System.Windows.Forms.LinkLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.documentsPanel = new System.Windows.Forms.Panel();
            this.operationDocumentsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.modelDetailsGroupBox.SuspendLayout();
            this.operationsPanel.SuspendLayout();
            this.projectDetailsGroupBox.SuspendLayout();
            this.modelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelPictureBox)).BeginInit();
            this.documentsPanel.SuspendLayout();
            this.operationDocumentsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.FullRowSelect = true;
            this.projectsTreeView.HideSelection = false;
            this.projectsTreeView.Location = new System.Drawing.Point(0, 53);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.Size = new System.Drawing.Size(221, 426);
            this.projectsTreeView.TabIndex = 18;
            this.projectsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projectsTreeView_AfterSelect);
            // 
            // operationsLabel
            // 
            this.operationsLabel.AutoSize = true;
            this.operationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsLabel.Location = new System.Drawing.Point(8, 22);
            this.operationsLabel.Name = "operationsLabel";
            this.operationsLabel.Size = new System.Drawing.Size(98, 13);
            this.operationsLabel.TabIndex = 4;
            this.operationsLabel.Text = "Список операций:";
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(155, 27);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(30, 23);
            this.addProjectButton.TabIndex = 7;
            this.addProjectButton.Text = "+";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.Location = new System.Drawing.Point(191, 27);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(30, 23);
            this.deleteProjectButton.TabIndex = 9;
            this.deleteProjectButton.Text = "-";
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            // 
            // modelDetailsGroupBox
            // 
            this.modelDetailsGroupBox.Controls.Add(this.operationsPanel);
            this.modelDetailsGroupBox.Controls.Add(this.addOperationTextBox);
            this.modelDetailsGroupBox.Controls.Add(this.addOperationButton);
            this.modelDetailsGroupBox.Controls.Add(this.operationsLabel);
            this.modelDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelDetailsGroupBox.Location = new System.Drawing.Point(238, 274);
            this.modelDetailsGroupBox.Name = "modelDetailsGroupBox";
            this.modelDetailsGroupBox.Size = new System.Drawing.Size(349, 205);
            this.modelDetailsGroupBox.TabIndex = 10;
            this.modelDetailsGroupBox.TabStop = false;
            this.modelDetailsGroupBox.Text = "Модель";
            this.modelDetailsGroupBox.Visible = false;
            // 
            // operationsPanel
            // 
            this.operationsPanel.AutoScroll = true;
            this.operationsPanel.Controls.Add(this.operationDeleteButtonsFlowLayoutPanel);
            this.operationsPanel.Controls.Add(this.operationsNameFlowLayoutPanel);
            this.operationsPanel.Location = new System.Drawing.Point(6, 41);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(330, 108);
            this.operationsPanel.TabIndex = 27;
            // 
            // operationDeleteButtonsFlowLayoutPanel
            // 
            this.operationDeleteButtonsFlowLayoutPanel.AutoSize = true;
            this.operationDeleteButtonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.operationDeleteButtonsFlowLayoutPanel.Location = new System.Drawing.Point(270, 3);
            this.operationDeleteButtonsFlowLayoutPanel.Name = "operationDeleteButtonsFlowLayoutPanel";
            this.operationDeleteButtonsFlowLayoutPanel.Size = new System.Drawing.Size(39, 101);
            this.operationDeleteButtonsFlowLayoutPanel.TabIndex = 1;
            // 
            // operationsNameFlowLayoutPanel
            // 
            this.operationsNameFlowLayoutPanel.AutoSize = true;
            this.operationsNameFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.operationsNameFlowLayoutPanel.Location = new System.Drawing.Point(3, 4);
            this.operationsNameFlowLayoutPanel.Name = "operationsNameFlowLayoutPanel";
            this.operationsNameFlowLayoutPanel.Size = new System.Drawing.Size(256, 100);
            this.operationsNameFlowLayoutPanel.TabIndex = 0;
            // 
            // addOperationTextBox
            // 
            this.addOperationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOperationTextBox.Location = new System.Drawing.Point(11, 168);
            this.addOperationTextBox.Name = "addOperationTextBox";
            this.addOperationTextBox.Size = new System.Drawing.Size(254, 20);
            this.addOperationTextBox.TabIndex = 26;
            // 
            // addOperationButton
            // 
            this.addOperationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOperationButton.Location = new System.Drawing.Point(276, 168);
            this.addOperationButton.Name = "addOperationButton";
            this.addOperationButton.Size = new System.Drawing.Size(20, 20);
            this.addOperationButton.TabIndex = 24;
            this.addOperationButton.Text = "+";
            this.addOperationButton.UseVisualStyleBackColor = true;
            this.addOperationButton.Click += new System.EventHandler(this.addOperationButton_Click);
            // 
            // projectDetailsGroupBox
            // 
            this.projectDetailsGroupBox.Controls.Add(this.modelPanel);
            this.projectDetailsGroupBox.Controls.Add(this.addModelNameTextBox);
            this.projectDetailsGroupBox.Controls.Add(this.addModelButton);
            this.projectDetailsGroupBox.Controls.Add(this.listModelLabel);
            this.projectDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectDetailsGroupBox.Location = new System.Drawing.Point(238, 53);
            this.projectDetailsGroupBox.Name = "projectDetailsGroupBox";
            this.projectDetailsGroupBox.Size = new System.Drawing.Size(349, 203);
            this.projectDetailsGroupBox.TabIndex = 5;
            this.projectDetailsGroupBox.TabStop = false;
            this.projectDetailsGroupBox.Text = "Проект";
            this.projectDetailsGroupBox.Visible = false;
            // 
            // modelPanel
            // 
            this.modelPanel.AutoScroll = true;
            this.modelPanel.Controls.Add(this.modelDeleteButtonsFlowLayoutPanel);
            this.modelPanel.Controls.Add(this.modelsNameFlowLayoutPanel);
            this.modelPanel.Location = new System.Drawing.Point(6, 43);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(330, 108);
            this.modelPanel.TabIndex = 4;
            this.modelPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelNamePanel_MouseClick);
            // 
            // modelDeleteButtonsFlowLayoutPanel
            // 
            this.modelDeleteButtonsFlowLayoutPanel.AutoSize = true;
            this.modelDeleteButtonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.modelDeleteButtonsFlowLayoutPanel.Location = new System.Drawing.Point(270, 3);
            this.modelDeleteButtonsFlowLayoutPanel.Name = "modelDeleteButtonsFlowLayoutPanel";
            this.modelDeleteButtonsFlowLayoutPanel.Size = new System.Drawing.Size(39, 102);
            this.modelDeleteButtonsFlowLayoutPanel.TabIndex = 1;
            // 
            // modelsNameFlowLayoutPanel
            // 
            this.modelsNameFlowLayoutPanel.AutoSize = true;
            this.modelsNameFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.modelsNameFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.modelsNameFlowLayoutPanel.Name = "modelsNameFlowLayoutPanel";
            this.modelsNameFlowLayoutPanel.Size = new System.Drawing.Size(256, 102);
            this.modelsNameFlowLayoutPanel.TabIndex = 0;
            // 
            // addModelNameTextBox
            // 
            this.addModelNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addModelNameTextBox.Location = new System.Drawing.Point(11, 168);
            this.addModelNameTextBox.Name = "addModelNameTextBox";
            this.addModelNameTextBox.Size = new System.Drawing.Size(254, 20);
            this.addModelNameTextBox.TabIndex = 3;
            // 
            // addModelButton
            // 
            this.addModelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addModelButton.Location = new System.Drawing.Point(276, 168);
            this.addModelButton.Name = "addModelButton";
            this.addModelButton.Size = new System.Drawing.Size(20, 20);
            this.addModelButton.TabIndex = 1;
            this.addModelButton.Text = "+";
            this.addModelButton.UseVisualStyleBackColor = true;
            this.addModelButton.Click += new System.EventHandler(this.addModelButton_Click);
            // 
            // listModelLabel
            // 
            this.listModelLabel.AutoSize = true;
            this.listModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listModelLabel.Location = new System.Drawing.Point(10, 23);
            this.listModelLabel.Name = "listModelLabel";
            this.listModelLabel.Size = new System.Drawing.Size(94, 13);
            this.listModelLabel.TabIndex = 0;
            this.listModelLabel.Text = "Список моделей:";
            // 
            // modelPictureBox
            // 
            this.modelPictureBox.Location = new System.Drawing.Point(604, 96);
            this.modelPictureBox.Name = "modelPictureBox";
            this.modelPictureBox.Size = new System.Drawing.Size(265, 145);
            this.modelPictureBox.TabIndex = 19;
            this.modelPictureBox.TabStop = false;
            this.modelPictureBox.Visible = false;
            // 
            // modelImageLabel
            // 
            this.modelImageLabel.AutoSize = true;
            this.modelImageLabel.Location = new System.Drawing.Point(607, 76);
            this.modelImageLabel.Name = "modelImageLabel";
            this.modelImageLabel.Size = new System.Drawing.Size(121, 13);
            this.modelImageLabel.TabIndex = 20;
            this.modelImageLabel.Text = "Изображение модели:";
            this.modelImageLabel.Visible = false;
            // 
            // addModelImageButton
            // 
            this.addModelImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addModelImageButton.Location = new System.Drawing.Point(788, 67);
            this.addModelImageButton.Name = "addModelImageButton";
            this.addModelImageButton.Size = new System.Drawing.Size(81, 23);
            this.addModelImageButton.TabIndex = 21;
            this.addModelImageButton.Text = "Добавить...";
            this.addModelImageButton.UseVisualStyleBackColor = true;
            this.addModelImageButton.Visible = false;
            // 
            // documentsLabel
            // 
            this.documentsLabel.AutoSize = true;
            this.documentsLabel.Location = new System.Drawing.Point(604, 295);
            this.documentsLabel.Name = "documentsLabel";
            this.documentsLabel.Size = new System.Drawing.Size(69, 13);
            this.documentsLabel.TabIndex = 22;
            this.documentsLabel.Text = "Документы:";
            this.documentsLabel.Visible = false;
            // 
            // addDocumentLinkLabel
            // 
            this.addDocumentLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.addDocumentLinkLabel.Location = new System.Drawing.Point(3, 0);
            this.addDocumentLinkLabel.Name = "addDocumentLinkLabel";
            this.addDocumentLinkLabel.Size = new System.Drawing.Size(117, 13);
            this.addDocumentLinkLabel.TabIndex = 23;
            this.addDocumentLinkLabel.TabStop = true;
            this.addDocumentLinkLabel.Text = "+ Добавить документ";
            this.addDocumentLinkLabel.Visible = false;
            this.addDocumentLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addDocumentLinkLabel_LinkClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Документы(*.txt;*.docx;*.doc;*pdf;*.xlsx;*.xls)|*.txt;*.docx;*.doc;*pdf;*.xlsx;*.xls";
            // 
            // documentsPanel
            // 
            this.documentsPanel.Controls.Add(this.operationDocumentsFlowLayoutPanel);
            this.documentsPanel.Location = new System.Drawing.Point(604, 315);
            this.documentsPanel.Name = "documentsPanel";
            this.documentsPanel.Size = new System.Drawing.Size(265, 164);
            this.documentsPanel.TabIndex = 24;
            // 
            // operationDocumentsFlowLayoutPanel
            // 
            this.operationDocumentsFlowLayoutPanel.Controls.Add(this.addDocumentLinkLabel);
            this.operationDocumentsFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.operationDocumentsFlowLayoutPanel.Name = "operationDocumentsFlowLayoutPanel";
            this.operationDocumentsFlowLayoutPanel.Size = new System.Drawing.Size(200, 157);
            this.operationDocumentsFlowLayoutPanel.TabIndex = 24;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 500);
            this.Controls.Add(this.documentsPanel);
            this.Controls.Add(this.documentsLabel);
            this.Controls.Add(this.addModelImageButton);
            this.Controls.Add(this.modelImageLabel);
            this.Controls.Add(this.modelPictureBox);
            this.Controls.Add(this.projectDetailsGroupBox);
            this.Controls.Add(this.modelDetailsGroupBox);
            this.Controls.Add(this.deleteProjectButton);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.projectsTreeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Проекты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectsForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.modelDetailsGroupBox.ResumeLayout(false);
            this.modelDetailsGroupBox.PerformLayout();
            this.operationsPanel.ResumeLayout(false);
            this.operationsPanel.PerformLayout();
            this.projectDetailsGroupBox.ResumeLayout(false);
            this.projectDetailsGroupBox.PerformLayout();
            this.modelPanel.ResumeLayout(false);
            this.modelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelPictureBox)).EndInit();
            this.documentsPanel.ResumeLayout(false);
            this.operationDocumentsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TreeView projectsTreeView;
        private System.Windows.Forms.Label operationsLabel;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.Button deleteProjectButton;
        private GroupBox modelDetailsGroupBox;
        private GroupBox projectDetailsGroupBox;
        private Button addModelButton;
        private Label listModelLabel;
        private TextBox addOperationTextBox;
        private Button addOperationButton;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Panel modelPanel;
        private TextBox addModelNameTextBox;
        private Panel operationsPanel;
        private PictureBox modelPictureBox;
        private Label modelImageLabel;
        private Button addModelImageButton;
        private Label documentsLabel;
        private LinkLabel addDocumentLinkLabel;
        private OpenFileDialog openFileDialog;
        private FlowLayoutPanel modelsNameFlowLayoutPanel;
        private FlowLayoutPanel modelDeleteButtonsFlowLayoutPanel;
        private FlowLayoutPanel operationDeleteButtonsFlowLayoutPanel;
        private FlowLayoutPanel operationsNameFlowLayoutPanel;
        private Panel documentsPanel;
        private FlowLayoutPanel operationDocumentsFlowLayoutPanel;
    }
}

