using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTransfer
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(@"Data Source=..\..\StudTransfer.db;Mode=ReadOnly")) // TODO прописать путь к базе
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT * FROM applications";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    int studentId, universityId, id;
                    if (reader.HasRows)
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                    
                            if (reader.GetValue(3).Equals("not checked"))
                            {
                                if(!int.TryParse(reader.GetValue(0).ToString(), out id) || !int.TryParse(reader.GetValue(1).ToString(), out studentId) || !int.TryParse(reader.GetValue(0).ToString(), out universityId))
                                {
                                    throw new Exception("bad format");
                                }
                                SQLiteCommand takeUser = new SQLiteCommand();
                                takeUser.Connection = connection;
                                takeUser.CommandText = $"SELECT * from users where id = {reader}";
                                applicationsTable.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                            }
                            else
                            {
                                continue;
                            }      
                        }
                    }
                }
            }
        }
    }
}
