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
            using (var connection = new SQLiteConnection("Data Source=StudTransfer.db;Mode=ReadOnly;")) 
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT * FROM applications;";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {                
                    if (reader.HasRows)
                    {
                        int id, userId, univerId;
                        while (reader.Read() && int.TryParse(reader.GetValue(0).ToString(), out id) && int.TryParse(reader.GetValue(1).ToString(), out userId) && int.TryParse(reader.GetValue(2).ToString(), out univerId))
                        {
                            var user = EmployeeDB.ReadUserInfoId(userId);
                            dataGridView1.Rows.Add(id, $"{user[0]} {user[1]}", reader.GetValue(4), reader.GetValue(3), univerId);
                        }
                    }
                }
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            
        }
    }
}
