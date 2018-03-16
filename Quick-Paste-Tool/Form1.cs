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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= (int) 0x08000000L; //WS_DISABLED

                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();

            CheckBox_StayOnTop.CheckedChanged += CheckBox_StayOnTop_CheckedChanged;
            LoadDefaultSetting();
        }

        private void LoadDefaultSetting()
        {
            CheckBox_StayOnTop.Checked = true;
        }

        private void CheckBox_StayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_StayOnTop.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("範本1的文字內容");
            SendKeys.Send(Clipboard.GetText());
        }
    }
}
