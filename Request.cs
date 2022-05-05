using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTransfer
{
    public partial class Request : Form
    {
        string student, snils, inn, univer;

        public Request(int userId, string student, string univer)
        {
            InitializeComponent();
            this.student = student;
            this.univer = univer;
        }

        private void Request_Load(object sender, EventArgs e)
        {
            List<object> data = new List<object>();
            using (var connection = new SQLiteConnection("Data Source=StudTransfer.db;Mode=ReadOnly;"))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM requests WHERE user_id={}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        data.Add(reader.GetValue(0));
                        for (int i = 3; i < 7; i++)
                        {
                            data.Add(reader.GetValue(i));
                        }                  
                    }
                }
            }
            label1.Text = $"Заявление номер {data[0]}";
        }
    }
}
