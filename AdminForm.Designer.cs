
namespace StudentsTransfer
{
    partial class AdminForm
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
            this.applicationsTable = new System.Windows.Forms.DataGridView();
            this.applicationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.university = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationsTable
            // 
            this.applicationsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applicationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicationId,
            this.student,
            this.university,
            this.status});
            this.applicationsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsTable.Location = new System.Drawing.Point(0, 0);
            this.applicationsTable.Name = "applicationsTable";
            this.applicationsTable.RowHeadersVisible = false;
            this.applicationsTable.RowHeadersWidth = 51;
            this.applicationsTable.RowTemplate.Height = 24;
            this.applicationsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicationsTable.Size = new System.Drawing.Size(800, 450);
            this.applicationsTable.TabIndex = 0;
            // 
            // applicationId
            // 
            this.applicationId.FillWeight = 106.9519F;
            this.applicationId.HeaderText = "id";
            this.applicationId.MinimumWidth = 6;
            this.applicationId.Name = "applicationId";
            this.applicationId.ReadOnly = true;
            // 
            // student
            // 
            this.student.FillWeight = 97.68271F;
            this.student.HeaderText = "Студент";
            this.student.MinimumWidth = 6;
            this.student.Name = "student";
            this.student.ReadOnly = true;
            // 
            // university
            // 
            this.university.FillWeight = 97.68271F;
            this.university.HeaderText = "Вуз";
            this.university.MinimumWidth = 6;
            this.university.Name = "university";
            this.university.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 97.68271F;
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applicationsTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView applicationsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn university;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}