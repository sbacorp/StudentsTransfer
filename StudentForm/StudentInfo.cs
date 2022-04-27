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
        Form parent;
        CheckBox lastBox;
        private readonly int idUser;
        private int selectUnivID;
        public StudentInfo(StudentForm parent, int idUser)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Fill;
            this.parent = parent;
            this.idUser = idUser;
            selectUnivID = -1;
            panel1.AutoScroll = false;  
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            //Чтение вузов из бд и закидываем чекбоксы
            foreach (var university in EmployeeDB.ReadUniversities())
            {
                int id; 
                if (int.TryParse(university[0].ToString(), out id) )
                {
                    var box = new CustomCheckBox(id, university[1].ToString(), cBoxs_Click);
                    this.panel1.Controls.Add(box); 
                }
            }

            
        }


        private void StudentInfo_SizeChanged(object sender, EventArgs e)
        {
            //this.pictureBox1.Location = new Point(Size.Subtract(this.Size, pictureBox1.Size)) { Y=0};
            
            
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
    }
}
