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
       
        private Form activeForm;
        private Button currentButton;
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Gotham", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in MenuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Gotham", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMain_Click(object sender, EventArgs e)
        { 
            
            OpenChildForm(new StudentInfo(this), sender);
        }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statements(), sender);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings(), sender);
        }
    }
}
