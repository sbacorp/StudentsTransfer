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
        private string pathPassport;
        private string pathPhoto;
        private Action<string> changeLocation;
        public StudentInfo(int idUser, Action exit, Action<string> changeLocation)
        {
            InitializeComponent();
            this.exit = exit;
            this.changeLocation = changeLocation;
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
            panelPhoto.Location = new Point(newWidth+2* padding, pbPhoto.Location.Y);
            buttonSend.Location = new Point(newWidth + 2 * padding, buttonSend.Location.Y);
            buttonExit.Width = 72;
            buttonExit.Location = new Point(Width-buttonExit.Width, pbPhoto.Location.Y);
            bChangeUniv.Width = this.Width / 3;
            bBudget.Width = this.Width / 3;
            bToGroup.Width = this.Width / 3;
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
            if (pathPhoto == null)
            {
                bAddPhoto.Dock = DockStyle.Fill;
                pbPhoto.Visible = false;
            }
            var info = EmployeeDB.ReadUserInfoId(idUser);
            if (info==null)
            {
                return;
            }
            Width += 1;
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

        private void bToGroup_Click(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void HideButtons()
        {
            bToGroup.Visible = false;
            bChangeUniv.Visible = false;
            bBudget.Visible = false;
        }

        private void bBudget_Click(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void bChangeUniv_Click(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void bAddPassport_Click(object sender, EventArgs e) 
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (fd.ShowDialog()==DialogResult.OK)
                {
                    // добавить коипрование в локальную папкку

                    this.pathPassport = fd.FileName;

                    labelPassport.Text = pathPassport.Split('\\').Last();
                }
            }
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.pathPhoto = fd.FileName;
                    //сделать копирование фотки в локальную папку
                    pbPhoto.Image = new Bitmap(fd.FileName);
                    bAddPhoto.Visible = false;
                    pbPhoto.Visible = true;

                }
            }
        }
    }
}
