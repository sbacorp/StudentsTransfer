
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelUniversisties = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelWarInn = new System.Windows.Forms.Label();
            this.labelWarSnils = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.bAddPassport = new System.Windows.Forms.Button();
            this.labelInn = new System.Windows.Forms.Label();
            this.labelSnils = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tbInn = new System.Windows.Forms.TextBox();
            this.tbSnils = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.bToGroup = new System.Windows.Forms.Button();
            this.bBudget = new System.Windows.Forms.Button();
            this.bChangeUniv = new System.Windows.Forms.Button();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.bAddPhoto = new System.Windows.Forms.Button();
            this.bChangeMind = new System.Windows.Forms.Button();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.panelPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(0, 18);
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
            this.buttonSend.Location = new System.Drawing.Point(256, 402);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(144, 23);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Создать";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelGroup);
            this.panelInfo.Controls.Add(this.tbGroup);
            this.panelInfo.Controls.Add(this.labelWarInn);
            this.panelInfo.Controls.Add(this.labelWarSnils);
            this.panelInfo.Controls.Add(this.labelPassport);
            this.panelInfo.Controls.Add(this.bAddPassport);
            this.panelInfo.Controls.Add(this.labelInn);
            this.panelInfo.Controls.Add(this.labelSnils);
            this.panelInfo.Controls.Add(this.labelDate);
            this.panelInfo.Controls.Add(this.labelMail);
            this.panelInfo.Controls.Add(this.label2Name);
            this.panelInfo.Controls.Add(this.labelName);
            this.panelInfo.Controls.Add(this.tbInn);
            this.panelInfo.Controls.Add(this.tbSnils);
            this.panelInfo.Controls.Add(this.dateTimePicker1);
            this.panelInfo.Controls.Add(this.tbMail);
            this.panelInfo.Controls.Add(this.tbLastName);
            this.panelInfo.Controls.Add(this.tbName);
            this.panelInfo.Location = new System.Drawing.Point(12, 13);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(139, 383);
            this.panelInfo.TabIndex = 8;
            this.panelInfo.SizeChanged += new System.EventHandler(this.panelInfo_SizeChanged);
            // 
            // labelWarInn
            // 
            this.labelWarInn.AutoSize = true;
            this.labelWarInn.ForeColor = System.Drawing.Color.Red;
            this.labelWarInn.Location = new System.Drawing.Point(47, 202);
            this.labelWarInn.Name = "labelWarInn";
            this.labelWarInn.Size = new System.Drawing.Size(125, 13);
            this.labelWarInn.TabIndex = 21;
            this.labelWarInn.Text = "Неправильный формат";
            this.labelWarInn.Visible = false;
            // 
            // labelWarSnils
            // 
            this.labelWarSnils.AutoSize = true;
            this.labelWarSnils.ForeColor = System.Drawing.Color.Red;
            this.labelWarSnils.Location = new System.Drawing.Point(47, 163);
            this.labelWarSnils.Name = "labelWarSnils";
            this.labelWarSnils.Size = new System.Drawing.Size(125, 13);
            this.labelWarSnils.TabIndex = 20;
            this.labelWarSnils.Text = "Неправильный формат";
            this.labelWarSnils.Visible = false;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(3, 293);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(106, 13);
            this.labelPassport.TabIndex = 19;
            this.labelPassport.Text = "Паспорт не выбран";
            // 
            // bAddPassport
            // 
            this.bAddPassport.Location = new System.Drawing.Point(0, 309);
            this.bAddPassport.Name = "bAddPassport";
            this.bAddPassport.Size = new System.Drawing.Size(139, 23);
            this.bAddPassport.TabIndex = 18;
            this.bAddPassport.Text = "Добавить паспорт";
            this.bAddPassport.UseVisualStyleBackColor = true;
            this.bAddPassport.Click += new System.EventHandler(this.bAddPassport_Click);
            // 
            // labelInn
            // 
            this.labelInn.AutoSize = true;
            this.labelInn.Location = new System.Drawing.Point(3, 204);
            this.labelInn.Name = "labelInn";
            this.labelInn.Size = new System.Drawing.Size(31, 13);
            this.labelInn.TabIndex = 17;
            this.labelInn.Text = "ИНН";
            // 
            // labelSnils
            // 
            this.labelSnils.AutoSize = true;
            this.labelSnils.Location = new System.Drawing.Point(3, 163);
            this.labelSnils.Name = "labelSnils";
            this.labelSnils.Size = new System.Drawing.Size(38, 13);
            this.labelSnils.TabIndex = 16;
            this.labelSnils.Text = "Снилс";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 118);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 13);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Дата рождения";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(3, 79);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(37, 13);
            this.labelMail.TabIndex = 14;
            this.labelMail.Text = "Почта";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Location = new System.Drawing.Point(3, 41);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(56, 13);
            this.label2Name.TabIndex = 13;
            this.label2Name.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 2);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Имя";
            // 
            // tbInn
            // 
            this.tbInn.Location = new System.Drawing.Point(0, 220);
            this.tbInn.Name = "tbInn";
            this.tbInn.Size = new System.Drawing.Size(139, 20);
            this.tbInn.TabIndex = 11;
            // 
            // tbSnils
            // 
            this.tbSnils.Location = new System.Drawing.Point(0, 179);
            this.tbSnils.Name = "tbSnils";
            this.tbSnils.Size = new System.Drawing.Size(139, 20);
            this.tbSnils.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 134);
            this.dateTimePicker1.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1953, 3, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
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
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPhoto.Image = global::StudentsTransfer.Properties.Resources.account;
            this.pbPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(144, 127);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // bToGroup
            // 
            this.bToGroup.BackColor = System.Drawing.Color.Snow;
            this.bToGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.bToGroup.FlatAppearance.BorderSize = 0;
            this.bToGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bToGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bToGroup.Location = new System.Drawing.Point(493, 0);
            this.bToGroup.Name = "bToGroup";
            this.bToGroup.Size = new System.Drawing.Size(15, 450);
            this.bToGroup.TabIndex = 11;
            this.bToGroup.Text = "Из группы в группу";
            this.bToGroup.UseVisualStyleBackColor = false;
            this.bToGroup.Click += new System.EventHandler(this.bToGroup_Click);
            // 
            // bBudget
            // 
            this.bBudget.Dock = System.Windows.Forms.DockStyle.Right;
            this.bBudget.FlatAppearance.BorderSize = 0;
            this.bBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBudget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bBudget.Location = new System.Drawing.Point(508, 0);
            this.bBudget.Name = "bBudget";
            this.bBudget.Size = new System.Drawing.Size(15, 450);
            this.bBudget.TabIndex = 10;
            this.bBudget.Text = "На бюджет";
            this.bBudget.UseVisualStyleBackColor = true;
            this.bBudget.Click += new System.EventHandler(this.bBudget_Click);
            // 
            // bChangeUniv
            // 
            this.bChangeUniv.Dock = System.Windows.Forms.DockStyle.Right;
            this.bChangeUniv.FlatAppearance.BorderSize = 0;
            this.bChangeUniv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangeUniv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bChangeUniv.Location = new System.Drawing.Point(477, 0);
            this.bChangeUniv.Name = "bChangeUniv";
            this.bChangeUniv.Size = new System.Drawing.Size(16, 450);
            this.bChangeUniv.TabIndex = 9;
            this.bChangeUniv.Text = "В другой вуз";
            this.bChangeUniv.UseVisualStyleBackColor = true;
            this.bChangeUniv.Click += new System.EventHandler(this.bChangeUniv_Click);
            // 
            // panelPhoto
            // 
            this.panelPhoto.Controls.Add(this.bAddPhoto);
            this.panelPhoto.Controls.Add(this.pbPhoto);
            this.panelPhoto.Location = new System.Drawing.Point(256, 13);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(144, 127);
            this.panelPhoto.TabIndex = 12;
            // 
            // bAddPhoto
            // 
            this.bAddPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAddPhoto.Location = new System.Drawing.Point(0, 0);
            this.bAddPhoto.Name = "bAddPhoto";
            this.bAddPhoto.Size = new System.Drawing.Size(144, 23);
            this.bAddPhoto.TabIndex = 19;
            this.bAddPhoto.Text = "Добавить фото";
            this.bAddPhoto.UseVisualStyleBackColor = true;
            this.bAddPhoto.Click += new System.EventHandler(this.bAddPhoto_Click);
            // 
            // bChangeMind
            // 
            this.bChangeMind.Location = new System.Drawing.Point(12, 402);
            this.bChangeMind.Name = "bChangeMind";
            this.bChangeMind.Size = new System.Drawing.Size(139, 23);
            this.bChangeMind.TabIndex = 13;
            this.bChangeMind.Text = "Поменять решение";
            this.bChangeMind.UseVisualStyleBackColor = true;
            this.bChangeMind.Click += new System.EventHandler(this.bChangeMind_Click);
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(0, 263);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(139, 20);
            this.tbGroup.TabIndex = 22;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(3, 246);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 23;
            this.labelGroup.Text = "Группа";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.bChangeUniv);
            this.Controls.Add(this.bToGroup);
            this.Controls.Add(this.bBudget);
            this.Controls.Add(this.panelPhoto);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.panelUniversisties);
            this.Controls.Add(this.bChangeMind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.SizeChanged += new System.EventHandler(this.StudentInfo_SizeChanged);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.panelPhoto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panelUniversisties;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbInn;
        private System.Windows.Forms.TextBox tbSnils;
        private System.Windows.Forms.Button bToGroup;
        private System.Windows.Forms.Button bBudget;
        private System.Windows.Forms.Button bChangeUniv;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Label labelSnils;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInn;
        private System.Windows.Forms.Button bAddPassport;
        private System.Windows.Forms.Button bAddPhoto;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Button bChangeMind;
        private System.Windows.Forms.Label labelWarInn;
        private System.Windows.Forms.Label labelWarSnils;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox tbGroup;
    }
}