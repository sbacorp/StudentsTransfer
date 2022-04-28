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
    public partial class StudentInfo : Form
    {
        
        private CheckBox lastBox;
        private readonly int idUser;
        private int selectUnivID;
        private Action exit;
        public StudentInfo(int idUser, Action exit)
        {
            InitializeComponent();
            this.exit = exit;
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Fill;
            this.idUser = idUser;
            selectUnivID = -1;
            panelUniversisties.AutoScroll = false;  
            panelUniversisties.HorizontalScroll.Enabled = false;
            panelUniversisties.HorizontalScroll.Visible = false;
            panelUniversisties.HorizontalScroll.Maximum = 0;
            panelUniversisties.AutoScroll = true;
            //Чтение вузов из бд и закидываем чекбоксы
            foreach (var university in EmployeeDB.ReadUniversities())
            {
                int id; 
                if (int.TryParse(university[0].ToString(), out id) )
                {
                    var box = new CustomCheckBox(id, university[1].ToString(), cBoxs_Click);
                    this.panelUniversisties.Controls.Add(box); 
                }
            }

            
        }


        private void StudentInfo_SizeChanged(object sender, EventArgs e)
        {
            int padding = 20;
            //this.pictureBox1.Location = new Point(Size.Subtract(this.Size, pictureBox1.Size)) { Y=0};
            int newWidth = (Width - padding) / 3;
            foreach (Control item in this.Controls)
            {
                int oldWidth = item.Width;
                item.Width = newWidth;
            }
            panelUniversisties.Location = new Point(newWidth + 2 * padding, panelUniversisties.Location.Y);
            pbPhoto.Location = new Point(newWidth+2* padding, pbPhoto.Location.Y);
            buttonSend.Location = new Point(newWidth + 2 * padding, buttonSend.Location.Y);
            buttonExit.Width = 72;
            buttonExit.Location = new Point(Width-buttonExit.Width, pbPhoto.Location.Y);
        }

        private void cBoxs_Click(object sender, EventArgs e)
        {
            CustomCheckBox activeBox = sender as CustomCheckBox;

            if (lastBox != null && !lastBox.Equals(activeBox))
            {
                lastBox.Checked = false;
            }
            if (activeBox.Checked)
            {
                lastBox = activeBox;
                selectUnivID = activeBox.ID_University;
                return;
            }
            lastBox = null;
            selectUnivID = -1;

        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            var info = EmployeeDB.ReadUserInfoId(idUser);
            if (info==null)
            {
                return;
            }
            tbName.Text = info[0].ToString();
            tbLastName.Text = info[1].ToString();
            tbMail.Text = info[2].ToString();
            dateTimePicker1.Value = (DateTime)info[3];
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exit?.Invoke();
        }

        private void panelInfo_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in panelInfo.Controls)
            {
                item.Width = panelInfo.Width;
            }
        }
    }
}
