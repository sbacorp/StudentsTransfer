
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSetting = new System.Windows.Forms.PictureBox();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.timerSetting = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.BackgroundImage = global::StudentsTransfer.Properties.Resources.Безымянный_1;
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.pictureBoxSetting);
            this.MenuPanel.Controls.Add(this.buttonSetting);
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Name = "MenuPanel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::StudentsTransfer.Properties.Resources.transfer;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSetting
            // 
            this.pictureBoxSetting.Image = global::StudentsTransfer.Properties.Resources.setting;
            resources.ApplyResources(this.pictureBoxSetting, "pictureBoxSetting");
            this.pictureBoxSetting.Name = "pictureBoxSetting";
            this.pictureBoxSetting.TabStop = false;
            // 
            // buttonSetting
            // 
            this.buttonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonSetting, "buttonSetting");
            this.buttonSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.MouseEnter += new System.EventHandler(this.MenuPanel_MouseEnter);
            // 
            // panelContent
            // 
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            // 
            // timerSetting
            // 
            this.timerSetting.Tick += new System.EventHandler(this.timerSetting_Tick);
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.MenuPanel);
            this.Name = "StudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox pictureBoxSetting;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Timer timerSetting;
    }
}