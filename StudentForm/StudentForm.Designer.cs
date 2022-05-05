
namespace StudentsTransfer
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPosition = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonApplications = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelPosition);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labelPosition
            // 
            resources.ApplyResources(this.labelPosition, "labelPosition");
            this.labelPosition.Name = "labelPosition";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.BackgroundImage = global::StudentsTransfer.Properties.Resources.Безымянный_1;
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Controls.Add(this.exitButton);
            this.MenuPanel.Controls.Add(this.buttonApplications);
            this.MenuPanel.Controls.Add(this.buttonMain);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Name = "MenuPanel";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonApplications
            // 
            resources.ApplyResources(this.buttonApplications, "buttonApplications");
            this.buttonApplications.FlatAppearance.BorderSize = 0;
            this.buttonApplications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonApplications.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonApplications.Image = global::StudentsTransfer.Properties.Resources.bank_statement;
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.buttonApplications_Click);
            // 
            // buttonMain
            // 
            resources.ApplyResources(this.buttonMain, "buttonMain");
            this.buttonMain.FlatAppearance.BorderSize = 0;
            this.buttonMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMain.Image = global::StudentsTransfer.Properties.Resources.user;
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::StudentsTransfer.Properties.Resources.change;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPanel);
            this.Name = "StudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonApplications;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button exitButton;
    }
}