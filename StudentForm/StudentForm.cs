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
    public partial class StudentForm : Form
    {
        Form formInPanel;
        StudentInfo studInfo;
        Statements statements;
        private readonly int idUser;
        public StudentForm(int idUser)
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.idUser = idUser;
        }
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            if (studInfo ==null)
            {
                studInfo = new StudentInfo(this, idUser);
            }
            if (this.panelContent.Controls.Contains(formInPanel))
            {
                panelContent.Controls.Remove(formInPanel);
            }
            formInPanel = studInfo;
            this.panelContent.Controls.Add(formInPanel);
            studInfo.Show();
        }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            if (statements == null)
            {
                statements = new Statements();
            }
            if (this.panelContent.Controls.Contains(formInPanel))
            {
                panelContent.Controls.Remove(formInPanel);
            }
            formInPanel = statements;
            this.panelContent.Controls.Add(formInPanel);
            statements.Show();
        }
        private void buttonSetting_Click(object sender, EventArgs e)
        {
            EmployeeDB.ReadUniversities();
        }
    }
}
