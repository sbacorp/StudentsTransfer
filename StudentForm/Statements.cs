using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTransfer
{
    public partial class Statements : Form
    {
        private readonly int idUser;
        public Statements(int idUser)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Fill;
            this.idUser = idUser;
        }

        private void Statements_Load(object sender, EventArgs e)
        {
            var applications = EmployeeDB.ReadUserApplications(idUser);
            foreach (var application in applications)
            {
                int idUniv;
                if (!int.TryParse(application[0].ToString(), out idUniv))
                {
                    continue;
                }
                string nameUniv = EmployeeDB.GetUniversityName(idUniv) ?? "Вуз неопознан";
                var itemToDGV = new object[] { nameUniv, application[1], application[2]};
                dataGridView.Rows.Add(itemToDGV);
            }
        }
    }
}
