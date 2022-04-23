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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.authButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.Location = new System.Drawing.Point(53, 211);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(305, 33);
            this.surnameTextBox.TabIndex = 0;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(53, 137);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(305, 33);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(50, 116);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя ";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.ForeColor = System.Drawing.Color.Black;
            this.surnameLabel.Location = new System.Drawing.Point(52, 190);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(77, 18);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(53, 410);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(305, 33);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(53, 337);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(305, 33);
            this.mailTextBox.TabIndex = 0;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.ForeColor = System.Drawing.Color.Black;
            this.mailLabel.Location = new System.Drawing.Point(52, 316);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(54, 18);
            this.mailLabel.TabIndex = 1;
            this.mailLabel.Text = "Почта";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(50, 389);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 18);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль";
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTextBox.Location = new System.Drawing.Point(53, 513);
            this.confirmPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(305, 33);
            this.confirmPassTextBox.TabIndex = 0;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            this.confirmPassTextBox.TextChanged += new System.EventHandler(this.confirmPassTextBox_TextChanged);
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.ForeColor = System.Drawing.Color.Black;
            this.confirmPassLabel.Location = new System.Drawing.Point(50, 492);
            this.confirmPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(164, 18);
            this.confirmPassLabel.TabIndex = 1;
            this.confirmPassLabel.Text = "Подтвердите пароль";
            // 
            // nameCheck
            // 
            this.nameCheck.AutoSize = true;
            this.nameCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheck.ForeColor = System.Drawing.Color.Red;
            this.nameCheck.Location = new System.Drawing.Point(366, 148);
            this.nameCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(28, 17);
            this.nameCheck.TabIndex = 1;
            this.nameCheck.Text = "    ";
            // 
            // surnameCheck
            // 
            this.surnameCheck.AutoSize = true;
            this.surnameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameCheck.ForeColor = System.Drawing.Color.Red;
            this.surnameCheck.Location = new System.Drawing.Point(366, 219);
            this.surnameCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameCheck.Name = "surnameCheck";
            this.surnameCheck.Size = new System.Drawing.Size(28, 17);
            this.surnameCheck.TabIndex = 1;
            this.surnameCheck.Text = "    ";
            // 
            // mailCheck
            // 
            this.mailCheck.AutoSize = true;
            this.mailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailCheck.ForeColor = System.Drawing.Color.Red;
            this.mailCheck.Location = new System.Drawing.Point(366, 346);
            this.mailCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailCheck.Name = "mailCheck";
            this.mailCheck.Size = new System.Drawing.Size(28, 17);
            this.mailCheck.TabIndex = 1;
            this.mailCheck.Text = "    ";
            // 
            // passwordCheck
            // 
            this.passwordCheck.AutoSize = true;
            this.passwordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordCheck.ForeColor = System.Drawing.Color.Red;
            this.passwordCheck.Location = new System.Drawing.Point(366, 410);
            this.passwordCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(0, 17);
            this.passwordCheck.TabIndex = 1;
            // 
            // passTip
            // 
            this.passTip.ToolTipTitle = "Почему пароль не подходит?";
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.ForeColor = System.Drawing.Color.Black;
            this.showPassCheckBox.Location = new System.Drawing.Point(53, 449);
            this.showPassCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(155, 22);
            this.showPassCheckBox.TabIndex = 3;
            this.showPassCheckBox.Text = "Показать пароль";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // showConfirmPassCheckBox
            // 
            this.showConfirmPassCheckBox.AutoSize = true;
            this.showConfirmPassCheckBox.ForeColor = System.Drawing.Color.Black;
            this.showConfirmPassCheckBox.Location = new System.Drawing.Point(53, 552);
            this.showConfirmPassCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showConfirmPassCheckBox.Name = "showConfirmPassCheckBox";
            this.showConfirmPassCheckBox.Size = new System.Drawing.Size(155, 22);
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
            this.confirmPassCheck.Location = new System.Drawing.Point(366, 524);
            this.confirmPassCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassCheck.Name = "confirmPassCheck";
            this.confirmPassCheck.Size = new System.Drawing.Size(0, 17);
            this.confirmPassCheck.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.SkyBlue;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.Location = new System.Drawing.Point(53, 278);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 25);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(50, 257);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(124, 18);
            this.birthLabel.TabIndex = 1;
            this.birthLabel.Text = "Дата рождения";
            // 
            // confirmPassTip
            // 
            this.confirmPassTip.ToolTipTitle = "Подтверждение пароля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Transfer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StudentsTransfer.Properties.Resources.transfer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 15);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::StudentsTransfer.Properties.Resources.close__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(392, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(14, 15);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // authButton
            // 
            this.authButton.BackColor = System.Drawing.Color.Transparent;
            this.authButton.BackgroundImage = global::StudentsTransfer.Properties.Resources.ryjgrf;
            this.authButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.authButton.FlatAppearance.BorderSize = 0;
            this.authButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authButton.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authButton.Location = new System.Drawing.Point(35, 594);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(342, 38);
            this.authButton.TabIndex = 11;
            this.authButton.Text = "Создать аккаунт";
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Регистрация";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 25);
            this.panel1.TabIndex = 13;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.showConfirmPassCheckBox);
            this.Controls.Add(this.showPassCheckBox);
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
            this.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}