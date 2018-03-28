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
    public partial class MainForm : Form
    {
        public Button _currButton = null;
        private bool _isCurrInEditMode = false;
        public EditForm _editForm = null;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= (int)0x08000000L; //WS_DISABLED

                return cp;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            CheckBox_StayOnTop.CheckedChanged += CheckBox_StayOnTop_CheckedChanged;
            LoadDefaultSetting();
        }

        private void LoadDefaultSetting()
        {
            CheckBox_StayOnTop.Checked = true;
            RadioButton_RunningMode.Checked = true;

            LoadPrefSetting();
        }

        public void LoadPrefSetting()
        {
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

        private void RadioButton_Mode_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_EditMode.Checked)
            {
                _isCurrInEditMode = true;
                OpenEditFormIfNeed();
            }
            else
            {
                _isCurrInEditMode = false;
                CloseEditFormIfNeed();
            }
        }

        private void OpenEditFormIfNeed()
        {
            if (_editForm == null)
            {
                _editForm = new EditForm(this);
                _editForm.StartPosition = FormStartPosition.Manual;
                _editForm.Location = new Point(this.Left, this.Top + this.Height + 15);
                _editForm.Show();
            }
        }

        private void CloseEditFormIfNeed()
        {
            if (_editForm != null)
            {
                _editForm.Close();

                _editForm = null;
                _currButton = null;
            }
        }
    }
}
