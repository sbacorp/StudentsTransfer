using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string location;
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
            //buttonExit.Width = 72;
            //buttonExit.Location = new Point(Width-buttonExit.Width, pbPhoto.Location.Y);
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
            LoadInfo();
        }

        private void LoadInfo()
        {
            var info = EmployeeDB.ReadUserRequest(idUser);
            tbGroup.Text = EmployeeDB.GetGroup(idUser); 
            if (info == null)
            {
                return;
            }
            tbInn.Text = info[2].ToString();
            tbSnils.Text = info[1].ToString();
            pathPassport = info[4].ToString();
            pathPhoto = info[3].ToString();
            if (!File.Exists($"{Environment.CurrentDirectory}\\Resources\\pictures\\{pathPassport}"))
            {
                pathPassport = null;
                return;
            }
            labelPassport.Text = pathPassport;
            if (!File.Exists($"{Environment.CurrentDirectory}\\Resources\\pictures\\{pathPhoto}"))
            {
                pathPhoto = null;
                return;
            }
            pbPhoto.Image = new Bitmap($"{Environment.CurrentDirectory}\\Resources\\pictures\\{pathPhoto}");
            pbPhoto.Visible = true;
            bAddPhoto.Dock = DockStyle.Bottom;
            bAddPhoto.Text = "Изменить фото";
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
            changeLocation.Invoke(bToGroup.Text);
            location = bToGroup.Text;
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
            changeLocation.Invoke(bBudget.Text);
            location = bBudget.Text;
        }

        private void bChangeUniv_Click(object sender, EventArgs e)
        {
            changeLocation.Invoke(bChangeUniv.Text);
            HideButtons();
            location = bChangeUniv.Text;
        }

        private void bAddPassport_Click(object sender, EventArgs e) 
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (fd.ShowDialog()==DialogResult.OK)
                {
                    // добавить путь в бд

                    this.pathPassport = fd.FileName.Split('\\').Last();
                    CheckDirectory();
                    labelPassport.Text = pathPassport;
                    string pathPic = $"{Environment.CurrentDirectory}\\Resources\\pictures";
                    int index = 0;
                    while (File.Exists(pathPic+"\\"+index +".jpg"))
                    {
                        index++;
                    }
                    File.Copy(fd.FileName, pathPic + "\\" + index + ".jpg");
                    pathPassport = index + ".jpg";
                }
            }
        }

        private static void CheckDirectory()
        {
            if (!Directory.Exists($"{Environment.CurrentDirectory}\\Resources\\pictures"))
            {
                Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Resources\\pictures");
            }
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.pathPhoto = fd.FileName.Split('\\').Last();
                    //Добавлять путь в бд
                    CheckDirectory();
                    string pathPic = $"{Environment.CurrentDirectory}\\Resources\\pictures";
                    int index = 0;
                    while (File.Exists(pathPic + "\\" + index + ".jpg"))
                    {
                        index++;
                    }
                    File.Copy(fd.FileName, pathPic + "\\" + index + ".jpg");
                    pbPhoto.Image = new Bitmap(fd.FileName);
                    bAddPhoto.Dock = DockStyle.Bottom;
                    bAddPhoto.Text = "Изменить фото";
                    pbPhoto.Visible = true;
                    pathPhoto = index + ".jpg";

                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (selectUnivID==-1 || pathPassport==null || pathPhoto==null || !SnilsCorrect() || !InnCorrect() || location ==null || tbGroup.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля и загрузите все фото");
                return;
            } 
            if (EmployeeDB.CheckUserRequest(idUser, selectUnivID))
            {
                MessageBox.Show("Нельзя сделать 2 заявки в один и тот же вуз");
                return;
            }
            labelWarSnils.Visible = false;
            labelWarInn.Visible = false;
            EmployeeDB.AddRequests(pathPhoto, pathPassport, idUser, selectUnivID, tbSnils.Text, tbInn.Text);
            EmployeeDB.AddApplications(idUser, selectUnivID, location);
            EmployeeDB.AddGroup(idUser, tbGroup.Text);
            MessageBox.Show("Завяка успешно подана");
        }

        private bool InnCorrect()
        {
            string data = tbInn.Text;
            long value;
            if (long.TryParse(data, out value) && data.Length == 12)
            {
                labelWarInn.Visible = false;
                return true;
            }
            labelWarInn.Visible = true;
            return false;
        }

        private bool SnilsCorrect()
        {
            string data = tbSnils.Text;
            long value;
            if (long.TryParse(data, out value) && data.Length == 11)
            {
                labelWarSnils.Visible = false;
                return true;
            }
            labelWarSnils.Visible = true;
            return false;
        }

        private void bChangeMind_Click(object sender, EventArgs e)
        {
            bBudget.Visible = true;
            bToGroup.Visible = true;
            bChangeUniv.Visible = true;
        }
    }
}
