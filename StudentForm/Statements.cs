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
    public partial class Statements : Form
    {
        public Statements()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.TopMost = true;
            this.Dock = DockStyle.Fill;
        }

        private void Statements_Load(object sender, EventArgs e)
        {

        }
    }
}
