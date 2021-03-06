﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quick_Paste_Tool
{
    public partial class EditForm : Form
    {
        public static MainForm _mainForm = null;

        protected override void OnFormClosing(FormClosingEventArgs e)
        { //表單預設的關閉按鈕事件
            base.OnFormClosing(e);
            _mainForm._editForm = null;
        }

        public EditForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            this.TopMost = true;
        }

        public void LoadCurrPrefSetting(String currPrefSetting)
        {
            if (!String.IsNullOrEmpty(currPrefSetting) &&
                currPrefSetting.Split(';').Count() >= 2)
            {
                TextBox_Title.Text = currPrefSetting.Split(';')[0];
                RichTextBox_Content.Text = currPrefSetting.Split(';')[1];
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            CloseEditForm();
        }

        private void CloseEditForm()
        {
            _mainForm._editForm = null;
            this.Close();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (_mainForm._currButton == null)
            {
                MessageBox.Show("請先點選要編輯的按鈕!", "提示", MessageBoxButtons.OK);
                return;
            }

            SaveNewPrefSetting();

            _mainForm.UpdateButtonTitles();
            CloseEditForm();
        }

        private void SaveNewPrefSetting()
        {
            var newPrefSetting = String.Format("{0};{1}", TextBox_Title.Text.Trim(), RichTextBox_Content.Text);
            switch (_mainForm._currButton.Name)
            {
                case "Button1":
                    Properties.Settings.Default.btn1_pref = newPrefSetting;
                    break;

                case "Button2":
                    Properties.Settings.Default.btn2_pref = newPrefSetting;
                    break;

                case "Button3":
                    Properties.Settings.Default.btn3_pref = newPrefSetting;
                    break;

                case "Button4":
                    Properties.Settings.Default.btn4_pref = newPrefSetting;
                    break;

                case "Button5":
                    Properties.Settings.Default.btn5_pref = newPrefSetting;
                    break;

                case "Button6":
                    Properties.Settings.Default.btn6_pref = newPrefSetting;
                    break;

                case "Button7":
                    Properties.Settings.Default.btn7_pref = newPrefSetting;
                    break;

                case "Button8":
                    Properties.Settings.Default.btn8_pref = newPrefSetting;
                    break;

                case "Button9":
                    Properties.Settings.Default.btn9_pref = newPrefSetting;
                    break;

                case "Button10":
                    Properties.Settings.Default.btn10_pref = newPrefSetting;
                    break;
            }

            Properties.Settings.Default.Save();
        }
    }
}
