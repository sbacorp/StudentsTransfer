using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private PrivateFontCollection pfc = new PrivateFontCollection();
        private string locationInMain;
        
        public StudentForm(MainForm parent, int idUser)
        {
            InitializeComponent();
            InitFont();
            this.parent = parent;
            fullClosing = true;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.idUser = idUser;
            locationInMain = "";
        }

        private void InitFont()
        {
            int fontLength = Properties.Resources.gothampro.Length;
            byte[] fontData = Properties.Resources.gothampro;
            System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontLength);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            foreach (Control item in this.Controls)
            {
                item.Font = new Font(pfc.Families[0], item.Font.Size);
            }
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
            labelPosition.Text = buttonMain.Text.Trim() + ":" + locationInMain;
            if (studInfo == null)
            {
                studInfo = new StudentInfo(idUser, ExitToLogin, ChangeLocation);
            }
            PanelContent_Selected(studInfo);
            ActivateButton(sender);
            Width -= 1;
        }

        private void ChangeLocation(string location)
        {
            labelPosition.Text = labelPosition.Text.Split(':')[0]+":"+location;
            locationInMain = location;
        }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            labelPosition.Text = buttonApplications.Text.Trim();
            if (statements == null)
            {
                statements = new Statements(idUser);
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
                activeButton.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
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
                    btn.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
                }
            }
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
