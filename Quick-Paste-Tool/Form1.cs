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
            //Form Size For Collapsed: 395, 150
            CheckBox_StayOnTop.Checked = true;
            RadioButton_RunningMode.Checked = true;

            button1.Text = Properties.Settings.Default.btn1_pref.Split(';')[0];
            button2.Text = Properties.Settings.Default.btn2_pref.Split(';')[0];
            button3.Text = Properties.Settings.Default.btn3_pref.Split(';')[0];
            button4.Text = Properties.Settings.Default.btn4_pref.Split(';')[0];
            button5.Text = Properties.Settings.Default.btn5_pref.Split(';')[0];
            button6.Text = Properties.Settings.Default.btn6_pref.Split(';')[0];
            button7.Text = Properties.Settings.Default.btn7_pref.Split(';')[0];
            button8.Text = Properties.Settings.Default.btn8_pref.Split(';')[0];
            button9.Text = Properties.Settings.Default.btn9_pref.Split(';')[0];
            button10.Text = Properties.Settings.Default.btn10_pref.Split(';')[0];
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
            //Clipboard.SetText("範本1的文字內容");
            Clipboard.SetText(Properties.Settings.Default.btn1_pref);
            SendKeys.Send(Clipboard.GetText());
        }
    }
}
