using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentsTransfer
{
    
    public partial class RegistrationForm : Form
    {
        private const string numbers = "1234567890";
        private const string cyrillic = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        private const string symbols = "`~!#$%^&*()-_=+;:'/.,<>|\"";
        private string forbidden = numbers + symbols + "@";

        private bool nameMatch;
        private bool surnameMatch;
        private bool mailMatch;
        private bool passwordMatch;
        private bool confirmPassMatch;


        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTip.ToolTipTitle = "Имя";
            nameMatch = !nameTextBox.Text.Equals("") && Char.IsUpper(nameTextBox.Text[0]) && !forbidden.Intersect(nameTextBox.Text).Any() && nameTextBox.Text.Skip(1).All(Char.IsLower);
            if (nameMatch)
            {
                nameTip.SetToolTip(nameCheck, "Все в порядке");
                nameCheck.Text = "✔️";
                nameCheck.ForeColor = Color.Green;
            }
            else
            {
                nameTip.SetToolTip(nameCheck, "• Имя должно начинаться с заглавной буквы\n" +
                    "• Имя не должно содержать запрещенных символов");
                nameCheck.Text = "❌";
                nameCheck.ForeColor = Color.Red;
            }
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            surnameTip.ToolTipTitle = "Фамилия";
            surnameMatch = !surnameTextBox.Text.Equals("") && Char.IsUpper(surnameTextBox.Text[0]) && !forbidden.Intersect(surnameTextBox.Text).Any() && surnameTextBox.Text.Skip(1).All(Char.IsLower);
            if (surnameMatch)
            {
                surnameTip.SetToolTip(surnameCheck, "Все в порядке");
                surnameCheck.Text = "✔️";
                surnameCheck.ForeColor = Color.Green;

            }
            else
            {
                surnameTip.SetToolTip(surnameCheck, "• Фамилия должна начинаться с заглавной буквы\n" +
                    "• Фамилия не должна содержать запрещенных символов");
                surnameCheck.Text = "❌";
                surnameCheck.ForeColor = Color.Red;
            }
            
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {
            
            mailMatch = mailTextBox.Text.Contains("@") && mailTextBox.Text.Split('@')[0].Length > 3 && !symbols.Contains(mailTextBox.Text[0]) && !cyrillic.Intersect(mailTextBox.Text).Any() && mailTextBox.Text.Split('@')[1].Contains('.') && mailTextBox.Text.Split('@')[1].Split('.')[0].Length > 1 && mailTextBox.Text.Split('@')[1].Split('.')[1].Length > 1 && !(symbols + cyrillic).Intersect(mailTextBox.Text.Split('@')[1].Split('.')[0]).Any() && !(symbols + cyrillic).Intersect(mailTextBox.Text.Split('@')[1].Split('.')[1]).Any();
            if (mailMatch)
            {
                mailTip.ToolTipTitle = "Почта";
                mailTip.SetToolTip(mailCheck, "Все в порядке");
                mailCheck.Text = "✔️";
                mailCheck.ForeColor = Color.Green;
            }
            else
            {
                mailTip.ToolTipTitle = "Неверный формат почты";
                mailTip.SetToolTip(mailCheck, "Почта должна иметь формат user@site.tt");
                mailCheck.Text = "❌";
                mailCheck.ForeColor = Color.Red;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordMatch = passwordTextBox.Text.Length > 7 && !cyrillic.Intersect(passwordTextBox.Text).Any();
            confirmPassTextBox_TextChanged(sender, e);
            if (!passwordMatch)
            {
                passTip.ToolTipTitle = "Почему пароль не подходит?";
                passTip.SetToolTip(passwordCheck, "• Пароль должен содержать минимум 8 символов\n" +
                    "• Пароль не должен содержать символов кириллицы");
                passwordCheck.Text = "❌";
                passwordCheck.ForeColor = Color.Red;
            }
            else
            {
                passTip.ToolTipTitle = "Пароль";
                passTip.SetToolTip(passwordCheck, "Надежный пароль");
                passwordCheck.Text = "✔️";
                passwordCheck.ForeColor = Color.Green;
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPassCheckBox.Checked;
        }

        private void showConfirmPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmPassTextBox.UseSystemPasswordChar = !showConfirmPassCheckBox.Checked;
        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            
            confirmPassTip.ToolTipTitle = "Подтверждение";
            
            confirmPassMatch = confirmPassTextBox.Text.Equals(passwordTextBox.Text) && passwordTextBox.Text.Length > 7;
            if (confirmPassMatch)
            {
                confirmPassTip.SetToolTip(confirmPassCheck, "Все в порядке");
                confirmPassCheck.Text = "✔️";
                confirmPassCheck.ForeColor = Color.Green;
            }
            else
            {
                confirmPassTip.SetToolTip(confirmPassCheck, "Пароли должны совпадать");
                confirmPassCheck.Text = "❌";
                confirmPassCheck.ForeColor = Color.Red;
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(@"Data Source=..\..\StudTransfer.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;

                command.CommandText = $"SELECT * FROM users WHERE mail = '{mailTextBox.Text}';";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    int id = 0;
                    if (reader.HasRows && reader.Read() && int.TryParse(reader.GetValue(0).ToString(), out id))
                    {
                        mailMatch = false;
                        MessageBox.Show("Пользователь с такой почтой уже зарегистрирован");
                        return;
                    }
                }

                connection.Close();
            }
            if (nameMatch && surnameMatch && mailMatch && passwordMatch && confirmPassMatch)
            {
                using (var connection = new SQLiteConnection(@"Data Source=..\..\StudTransfer.db"))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;
                    SQLiteParameter nameParam = new SQLiteParameter("@name", nameTextBox.Text);
                    SQLiteParameter surnameParam = new SQLiteParameter("@surname", surnameTextBox.Text);
                    SQLiteParameter mailParam = new SQLiteParameter("@mail", mailTextBox.Text);
                    SQLiteParameter dateParam = new SQLiteParameter("@date", dateTimePicker.Value.ToString("yyyyMMdd"));
                    SQLiteParameter passParam = new SQLiteParameter("@pass", passwordTextBox.Text);
                    command.CommandText = $"INSERT INTO users (name, lastname, mail, dateOfBirth, password) VALUES(@name, @surname, @mail, @date, @pass);";
                    command.Parameters.AddRange(new SQLiteParameter[] { nameParam, surnameParam, mailParam, dateParam, passParam });
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Аккаунт создан");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения полей");
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
    }
}
