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
        private const int INTERVAL_UP = 5;
        private int factor;
        StudentInfo studInfo;
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

        private void MenuPanel_MouseEnter(object sender, EventArgs e)
        {
            this.timerSetting.Interval = 10;
            this.timerSetting.Enabled = true;
            factor = 1;
            
        }

        private void timerSetting_Tick(object sender, EventArgs e)
        {
            if (this.timerSetting.Interval>500)
            {
                timerSetting.Enabled = false;
                return;
            }
            timerSetting.Interval += INTERVAL_UP * factor;
            factor += 1;
            pictureBoxSetting.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            pictureBoxSetting.Image = pictureBoxSetting.Image;
            
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            studInfo = new StudentInfo(this);
            this.panelContent.Controls.Add(studInfo);
            studInfo.Show();
        }
    }
}
