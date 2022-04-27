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
        public StudentForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
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
                studInfo = new StudentInfo(this);
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

        private void MenuPanel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonSetting_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
