
namespace StudentsTransfer
{
    partial class StudentInfo
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
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelUniversisties = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPhoto.Location = new System.Drawing.Point(256, 12);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(144, 127);
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(0, 14);
            this.tbName.MaxLength = 35;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(139, 20);
            this.tbName.TabIndex = 1;
            // 
            // panelUniversisties
            // 
            this.panelUniversisties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUniversisties.Location = new System.Drawing.Point(256, 154);
            this.panelUniversisties.Name = "panelUniversisties";
            this.panelUniversisties.Size = new System.Drawing.Size(144, 203);
            this.panelUniversisties.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(256, 380);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(144, 23);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Создать";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(452, 13);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.dateTimePicker1);
            this.panelInfo.Controls.Add(this.tbMail);
            this.panelInfo.Controls.Add(this.tbLastName);
            this.panelInfo.Controls.Add(this.tbName);
            this.panelInfo.Location = new System.Drawing.Point(12, 24);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(139, 276);
            this.panelInfo.TabIndex = 8;
            this.panelInfo.SizeChanged += new System.EventHandler(this.panelInfo_SizeChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(0, 95);
            this.tbMail.MaxLength = 35;
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(139, 20);
            this.tbMail.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(0, 54);
            this.tbLastName.MaxLength = 35;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(139, 20);
            this.tbLastName.TabIndex = 6;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.panelUniversisties);
            this.Controls.Add(this.pbPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.SizeChanged += new System.EventHandler(this.StudentInfo_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panelUniversisties;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbLastName;
    }
}