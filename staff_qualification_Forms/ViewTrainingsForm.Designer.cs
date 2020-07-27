namespace staff_qualification_Forms
{
    partial class ViewTrainingsForm
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
            this.trainingsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingsDataGridView
            // 
            this.trainingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.trainingsDataGridView.Name = "trainingsDataGridView";
            this.trainingsDataGridView.Size = new System.Drawing.Size(800, 382);
            this.trainingsDataGridView.TabIndex = 0;
            this.trainingsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.trainingsDataGridView_CellMouseDoubleClick);
            // 
            // AllTrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.trainingsDataGridView);
            this.Name = "AllTrainingsForm";
            this.Text = "AllTrainingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView trainingsDataGridView;
    }
}