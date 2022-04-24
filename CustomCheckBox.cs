﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTransfer
{
    class CustomCheckBox: CheckBox
    {
        public readonly int ID_University;

        public CustomCheckBox(int iD_University, EventHandler click)
        {
            ID_University = iD_University;
            this.Click += click;
            Dock = DockStyle.Top;
            Appearance = Appearance.Button;
            Text = $"University {ID_University}";
            TabIndex = ID_University;
        }
    }
}
