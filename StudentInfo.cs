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
        CheckBox activeBox;
        private int selectUnivID;
        public StudentInfo(StudentForm parent)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Fill;
            this.parent = parent;
            panel1.AutoScroll = false;  
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            //Чтение вузов из бд и закидываем чекбоксы
            for (int i = 20 - 1; i >= 0; i--)
            {
                var box = new CustomCheckBox(i, cBoxs_Click);
                this.panel1.Controls.Add(box);
            }

            
        }
        
        private void StudentInfo_SizeChanged(object sender, EventArgs e)
        {
            //this.pictureBox1.Location = new Point(Size.Subtract(this.Size, pictureBox1.Size)) { Y=0};
            
            
        }

        private void cBoxs_Click(object sender, EventArgs e)
        {
            CheckBox putBox = sender as CheckBox;

            if (activeBox != null && !activeBox.Equals(putBox))
            {
                activeBox.Checked = false;
            }
            activeBox = putBox.Checked ? putBox : null;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
