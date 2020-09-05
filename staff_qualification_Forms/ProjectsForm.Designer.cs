﻿using System;
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
            this.addOperationTextBox = new System.Windows.Forms.TextBox();
            this.addOperationButton = new System.Windows.Forms.Button();
            this.projectDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.modelNamePanel = new System.Windows.Forms.Panel();
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
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
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
            this.modelDetailsGroupBox.Size = new System.Drawing.Size(342, 205);
            this.modelDetailsGroupBox.TabIndex = 10;
            this.modelDetailsGroupBox.TabStop = false;
            this.modelDetailsGroupBox.Text = "Модель";
            this.modelDetailsGroupBox.Visible = false;
            // 
            // operationsPanel
            // 
            this.operationsPanel.AutoScroll = true;
            this.operationsPanel.Location = new System.Drawing.Point(6, 41);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(330, 108);
            this.operationsPanel.TabIndex = 27;
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
            this.projectDetailsGroupBox.Controls.Add(this.modelNamePanel);
            this.projectDetailsGroupBox.Controls.Add(this.addModelNameTextBox);
            this.projectDetailsGroupBox.Controls.Add(this.addModelButton);
            this.projectDetailsGroupBox.Controls.Add(this.listModelLabel);
            this.projectDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectDetailsGroupBox.Location = new System.Drawing.Point(238, 53);
            this.projectDetailsGroupBox.Name = "projectDetailsGroupBox";
            this.projectDetailsGroupBox.Size = new System.Drawing.Size(342, 203);
            this.projectDetailsGroupBox.TabIndex = 5;
            this.projectDetailsGroupBox.TabStop = false;
            this.projectDetailsGroupBox.Text = "Проект";
            this.projectDetailsGroupBox.Visible = false;
            // 
            // modelNamePanel
            // 
            this.modelNamePanel.AutoScroll = true;
            this.modelNamePanel.Location = new System.Drawing.Point(6, 43);
            this.modelNamePanel.Name = "modelNamePanel";
            this.modelNamePanel.Size = new System.Drawing.Size(330, 108);
            this.modelNamePanel.TabIndex = 4;
            this.modelNamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelNamePanel_MouseClick);
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
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 500);
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
            this.projectDetailsGroupBox.ResumeLayout(false);
            this.projectDetailsGroupBox.PerformLayout();
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
        private Panel modelNamePanel;
        private TextBox addModelNameTextBox;
        private Panel operationsPanel;
    }
}

