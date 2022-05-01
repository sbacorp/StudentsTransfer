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
        MainForm parent;
        StudentInfo studInfo;
        Statements statements;
        private bool fullClosing;
        private Button activeButton;
        private readonly int idUser;
        public StudentForm(MainForm parent, int idUser)
        {
            InitializeComponent();
            this.parent = parent;
            fullClosing = true;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.idUser = idUser;
        }
        private void ExitToLogin()
        {
            studInfo?.Close();
            statements?.Close();
            fullClosing = false;
            this.Close();
            parent.OutLogin();
            parent.Show();
        }
        private void PanelContent_Selected(Form selectedForm)
        {
            if (panelContent.Controls.Contains(formInPanel))
            {
                panelContent.Controls.Remove(formInPanel);
                }
            formInPanel = selectedForm;
            panelContent.Controls.Add(formInPanel);
            selectedForm.Show();
            }
        private void buttonMain_Click(object sender, EventArgs e)
        {
            if (studInfo == null)
            {
                studInfo = new StudentInfo(idUser);
                }
            PanelContent_Selected(studInfo);
            ActivateButton(sender);
            }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            if (statements == null)
            {
                statements = new Statements();
            }
            PanelContent_Selected(statements);
            ActivateButton(sender);
        }

        private void ActivateButton(object sender)
        {
            if (sender != null && activeButton != (Button)sender)
        {
                DisableButtons();
                activeButton = (Button)sender;
                // Настройка внешн активированной кнопки

                activeButton.ForeColor = Color.Black;
                activeButton.Font = new System.Drawing.Font("Gotham", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            }
        }

        private void DisableButtons()
        {
            foreach (Control btn in MenuPanel.Controls)
            {
                if (btn.GetType() == typeof(Button))
        { 
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.Black;
                    btn.Font = new System.Drawing.Font("Gotham", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fullClosing)
        {
                Application.Exit();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitToLogin();
        }
    }
}
