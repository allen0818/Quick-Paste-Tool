using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quick_Paste_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckBox_StayOnTop.CheckedChanged += CheckBox_StayOnTop_CheckedChanged;

            CheckBox_StayOnTop.Checked = true;
        }

        private void CheckBox_StayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_StayOnTop.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }
    }
}
