using StudentsTransfer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTransfer
{
    public partial class MainForm : Form
    {
        User admin;
        AdminForm adminForm;
        StudentForm studentForm;
        RegistrationForm registrationForm;
        private string PATH_SESSION = $@"{Environment.CurrentDirectory}\Resources\lastSession.txt";
        private bool goLastSession;
        public MainForm()
        {
            InitializeComponent();
            admin = new Admin("admin", "admin123");
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Equals("") || passwordTextBox.Text.Equals(""))
            {
                incorrectDataLabel.Text = "Поля не могут быть пустыми";
                incorrectDataLabel.Visible = true;
                return;
            }
            else if (loginTextBox.Text.Equals(admin.login) && passwordTextBox.Text.Equals(admin.password))
            {
                adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();
                return;
            }
            else
            {
                using (var connection = new SQLiteConnection(@"Data Source=..\..\StudTransfer.db;Mode=ReadOnly")) // TODO прописать путь к базе
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM users WHERE mail = '{loginTextBox.Text}' AND password = '{passwordTextBox.Text}'";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int id = 0;
                        if (reader.HasRows && reader.Read() && int.TryParse(reader.GetValue(0).ToString(), out id))
                        {
                            CheckOutBox();
                            studentForm = new StudentForm(this, id);
                            this.Hide();
                            passwordTextBox.Text = string.Empty;
                            studentForm.Show();
                            return;
                        }
                    }
                }
            }
            incorrectDataLabel.Text = "Неверные логин или пароль";
            incorrectDataLabel.Visible = true;
        }

        private void CheckOutBox()
        {
            if (checkBox1.Checked)
            {
                File.WriteAllText(PATH_SESSION,
                    string.Join("\n", loginTextBox.Text, passwordTextBox.Text));
                return;
            }
        }

        


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm = new RegistrationForm();
            this.Hide();
            if (registrationForm.ShowDialog().Equals(DialogResult.OK))
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (goLastSession)
            {
                this.Hide();
            }
        }
        #region MoveForm
        //Нашел на стеке сам бы такое не написал
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void StudentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string fileContent;
            if ((fileContent = File.ReadAllText(PATH_SESSION)) != string.Empty)
            {
                goLastSession = true;
                loginTextBox.Text = fileContent.Split('\n')[0].Trim();
                passwordTextBox.Text = fileContent.Split('\n')[1].Trim();
                authButton.PerformClick();
            }
        }
        public void OutLogin()
        {
            File.WriteAllText(PATH_SESSION, string.Empty);
            goLastSession = false;
        }
    }
}
