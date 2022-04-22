namespace StudentsTransfer
{
    partial class RegistrationForm
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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.nameCheck = new System.Windows.Forms.Label();
            this.surnameCheck = new System.Windows.Forms.Label();
            this.mailCheck = new System.Windows.Forms.Label();
            this.passwordCheck = new System.Windows.Forms.Label();
            this.passTip = new System.Windows.Forms.ToolTip(this.components);
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.showConfirmPassCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmPassCheck = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthLabel = new System.Windows.Forms.Label();
            this.nameTip = new System.Windows.Forms.ToolTip(this.components);
            this.surnameTip = new System.Windows.Forms.ToolTip(this.components);
            this.mailTip = new System.Windows.Forms.ToolTip(this.components);
            this.confirmPassTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(48, 114);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(317, 22);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(48, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(317, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(45, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя ";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.surnameLabel.Location = new System.Drawing.Point(45, 95);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(66, 16);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(48, 288);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(317, 22);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(48, 226);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(317, 22);
            this.mailTextBox.TabIndex = 0;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mailLabel.Location = new System.Drawing.Point(45, 207);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(48, 16);
            this.mailLabel.TabIndex = 1;
            this.mailLabel.Text = "Почта";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(45, 269);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль";
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(48, 364);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(317, 22);
            this.confirmPassTextBox.TabIndex = 0;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            this.confirmPassTextBox.TextChanged += new System.EventHandler(this.confirmPassTextBox_TextChanged);
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmPassLabel.Location = new System.Drawing.Point(45, 345);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(145, 16);
            this.confirmPassLabel.TabIndex = 1;
            this.confirmPassLabel.Text = "Подтвердите пароль";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(123, 439);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(146, 41);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Создать аккаунт";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // nameCheck
            // 
            this.nameCheck.AutoSize = true;
            this.nameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheck.ForeColor = System.Drawing.Color.Red;
            this.nameCheck.Location = new System.Drawing.Point(371, 52);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(33, 20);
            this.nameCheck.TabIndex = 1;
            this.nameCheck.Text = "    ";
            // 
            // surnameCheck
            // 
            this.surnameCheck.AutoSize = true;
            this.surnameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameCheck.ForeColor = System.Drawing.Color.Red;
            this.surnameCheck.Location = new System.Drawing.Point(371, 114);
            this.surnameCheck.Name = "surnameCheck";
            this.surnameCheck.Size = new System.Drawing.Size(33, 20);
            this.surnameCheck.TabIndex = 1;
            this.surnameCheck.Text = "    ";
            // 
            // mailCheck
            // 
            this.mailCheck.AutoSize = true;
            this.mailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailCheck.ForeColor = System.Drawing.Color.Red;
            this.mailCheck.Location = new System.Drawing.Point(371, 228);
            this.mailCheck.Name = "mailCheck";
            this.mailCheck.Size = new System.Drawing.Size(33, 20);
            this.mailCheck.TabIndex = 1;
            this.mailCheck.Text = "    ";
            // 
            // passwordCheck
            // 
            this.passwordCheck.AutoSize = true;
            this.passwordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordCheck.ForeColor = System.Drawing.Color.Red;
            this.passwordCheck.Location = new System.Drawing.Point(371, 288);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(0, 20);
            this.passwordCheck.TabIndex = 1;
            // 
            // passTip
            // 
            this.passTip.ToolTipTitle = "Почему пароль не подходит?";
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassCheckBox.Location = new System.Drawing.Point(48, 317);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(142, 20);
            this.showPassCheckBox.TabIndex = 3;
            this.showPassCheckBox.Text = "Показать пароль";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // showConfirmPassCheckBox
            // 
            this.showConfirmPassCheckBox.AutoSize = true;
            this.showConfirmPassCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showConfirmPassCheckBox.Location = new System.Drawing.Point(48, 392);
            this.showConfirmPassCheckBox.Name = "showConfirmPassCheckBox";
            this.showConfirmPassCheckBox.Size = new System.Drawing.Size(142, 20);
            this.showConfirmPassCheckBox.TabIndex = 3;
            this.showConfirmPassCheckBox.Text = "Показать пароль";
            this.showConfirmPassCheckBox.UseVisualStyleBackColor = true;
            this.showConfirmPassCheckBox.CheckedChanged += new System.EventHandler(this.showConfirmPassCheckBox_CheckedChanged);
            // 
            // confirmPassCheck
            // 
            this.confirmPassCheck.AutoSize = true;
            this.confirmPassCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassCheck.ForeColor = System.Drawing.Color.Red;
            this.confirmPassCheck.Location = new System.Drawing.Point(371, 366);
            this.confirmPassCheck.Name = "confirmPassCheck";
            this.confirmPassCheck.Size = new System.Drawing.Size(0, 20);
            this.confirmPassCheck.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.dateTimePicker.Location = new System.Drawing.Point(48, 171);
            this.dateTimePicker.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthLabel.Location = new System.Drawing.Point(45, 152);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(106, 16);
            this.birthLabel.TabIndex = 1;
            this.birthLabel.Text = "Дата рождения";
            // 
            // confirmPassTip
            // 
            this.confirmPassTip.ToolTipTitle = "Подтверждение пароля";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(411, 513);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.showConfirmPassCheckBox);
            this.Controls.Add(this.showPassCheckBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.surnameCheck);
            this.Controls.Add(this.confirmPassCheck);
            this.Controls.Add(this.mailCheck);
            this.Controls.Add(this.passwordCheck);
            this.Controls.Add(this.nameCheck);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label nameCheck;
        private System.Windows.Forms.Label surnameCheck;
        private System.Windows.Forms.Label mailCheck;
        private System.Windows.Forms.Label passwordCheck;
        private System.Windows.Forms.ToolTip passTip;
        private System.Windows.Forms.CheckBox showPassCheckBox;
        private System.Windows.Forms.CheckBox showConfirmPassCheckBox;
        private System.Windows.Forms.Label confirmPassCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.ToolTip nameTip;
        private System.Windows.Forms.ToolTip surnameTip;
        private System.Windows.Forms.ToolTip mailTip;
        private System.Windows.Forms.ToolTip confirmPassTip;
    }
}