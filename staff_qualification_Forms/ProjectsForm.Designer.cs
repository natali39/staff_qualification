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
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.модельToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsTreeView = new System.Windows.Forms.TreeView();
            this.operationsListBox = new System.Windows.Forms.ListBox();
            this.operationsLabel = new System.Windows.Forms.Label();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.modelDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addOperationTextBox = new System.Windows.Forms.TextBox();
            this.deleteOperationButton = new System.Windows.Forms.Button();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.projectDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addModelNameTextBox = new System.Windows.Forms.TextBox();
            this.addModelButton = new System.Windows.Forms.Button();
            this.listModelLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.modelDetailsGroupBox.SuspendLayout();
            this.projectDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.удалитьToolStripMenuItem});
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
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
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
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem1,
            this.модельToolStripMenuItem1});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // проектToolStripMenuItem1
            // 
            this.проектToolStripMenuItem1.Name = "проектToolStripMenuItem1";
            this.проектToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.проектToolStripMenuItem1.Text = "Проект";
            // 
            // модельToolStripMenuItem1
            // 
            this.модельToolStripMenuItem1.Name = "модельToolStripMenuItem1";
            this.модельToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.модельToolStripMenuItem1.Text = "Модель";
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.FullRowSelect = true;
            this.projectsTreeView.HideSelection = false;
            this.projectsTreeView.Location = new System.Drawing.Point(0, 53);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.Size = new System.Drawing.Size(221, 415);
            this.projectsTreeView.TabIndex = 18;
            this.projectsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projectsTreeView_AfterSelect);
            // 
            // operationsListBox
            // 
            this.operationsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsListBox.FormattingEnabled = true;
            this.operationsListBox.Location = new System.Drawing.Point(11, 40);
            this.operationsListBox.Name = "operationsListBox";
            this.operationsListBox.Size = new System.Drawing.Size(314, 82);
            this.operationsListBox.TabIndex = 3;
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
            this.modelDetailsGroupBox.Controls.Add(this.addOperationTextBox);
            this.modelDetailsGroupBox.Controls.Add(this.deleteOperationButton);
            this.modelDetailsGroupBox.Controls.Add(this.addOperationButton);
            this.modelDetailsGroupBox.Controls.Add(this.operationsListBox);
            this.modelDetailsGroupBox.Controls.Add(this.operationsLabel);
            this.modelDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelDetailsGroupBox.Location = new System.Drawing.Point(238, 291);
            this.modelDetailsGroupBox.Name = "modelDetailsGroupBox";
            this.modelDetailsGroupBox.Size = new System.Drawing.Size(342, 177);
            this.modelDetailsGroupBox.TabIndex = 10;
            this.modelDetailsGroupBox.TabStop = false;
            this.modelDetailsGroupBox.Text = "Модель";
            this.modelDetailsGroupBox.Visible = false;
            // 
            // addOperationTextBox
            // 
            this.addOperationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOperationTextBox.Location = new System.Drawing.Point(11, 137);
            this.addOperationTextBox.Name = "addOperationTextBox";
            this.addOperationTextBox.Size = new System.Drawing.Size(254, 20);
            this.addOperationTextBox.TabIndex = 26;
            // 
            // deleteOperationButton
            // 
            this.deleteOperationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteOperationButton.Location = new System.Drawing.Point(305, 136);
            this.deleteOperationButton.Name = "deleteOperationButton";
            this.deleteOperationButton.Size = new System.Drawing.Size(20, 20);
            this.deleteOperationButton.TabIndex = 25;
            this.deleteOperationButton.Text = "-";
            this.deleteOperationButton.UseVisualStyleBackColor = true;
            this.deleteOperationButton.Click += new System.EventHandler(this.deleteOperationButton_Click);
            // 
            // addOperationButton
            // 
            this.addOperationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOperationButton.Location = new System.Drawing.Point(271, 136);
            this.addOperationButton.Name = "addOperationButton";
            this.addOperationButton.Size = new System.Drawing.Size(20, 20);
            this.addOperationButton.TabIndex = 24;
            this.addOperationButton.Text = "+";
            this.addOperationButton.UseVisualStyleBackColor = true;
            this.addOperationButton.Click += new System.EventHandler(this.addOperationButton_Click);
            // 
            // projectDetailsGroupBox
            // 
            this.projectDetailsGroupBox.Controls.Add(this.addModelNameTextBox);
            this.projectDetailsGroupBox.Controls.Add(this.addModelButton);
            this.projectDetailsGroupBox.Controls.Add(this.listModelLabel);
            this.projectDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectDetailsGroupBox.Location = new System.Drawing.Point(238, 53);
            this.projectDetailsGroupBox.Name = "projectDetailsGroupBox";
            this.projectDetailsGroupBox.Size = new System.Drawing.Size(342, 224);
            this.projectDetailsGroupBox.TabIndex = 5;
            this.projectDetailsGroupBox.TabStop = false;
            this.projectDetailsGroupBox.Text = "Проект";
            // 
            // addModelNameTextBox
            // 
            this.addModelNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addModelNameTextBox.Location = new System.Drawing.Point(11, 188);
            this.addModelNameTextBox.Name = "addModelNameTextBox";
            this.addModelNameTextBox.Size = new System.Drawing.Size(286, 20);
            this.addModelNameTextBox.TabIndex = 3;
            // 
            // addModelButton
            // 
            this.addModelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addModelButton.Location = new System.Drawing.Point(305, 186);
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
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 490);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.modelDetailsGroupBox.ResumeLayout(false);
            this.modelDetailsGroupBox.PerformLayout();
            this.projectDetailsGroupBox.ResumeLayout(false);
            this.projectDetailsGroupBox.PerformLayout();
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
        private System.Windows.Forms.ListBox operationsListBox;
        private System.Windows.Forms.Label operationsLabel;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.Button deleteProjectButton;
        private GroupBox modelDetailsGroupBox;
        private GroupBox projectDetailsGroupBox;
        private Button addModelButton;
        private TextBox addModelNameTextBox;
        private Label listModelLabel;
        private TextBox addOperationTextBox;
        private Button deleteOperationButton;
        private Button addOperationButton;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem проектToolStripMenuItem1;
        private ToolStripMenuItem модельToolStripMenuItem1;
    }
}

