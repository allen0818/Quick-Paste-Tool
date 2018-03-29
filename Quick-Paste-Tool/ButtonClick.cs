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
        private void Button1_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void DoButtonClickJob(object sender)
        {
            _currButton = sender as Button;
            if (_currButton != null)
            {
                var currPrefSetting = GetPrefSettingByButton(_currButton);
                if (_isCurrInEditMode)
                {
                    OpenEditFormIfNeed();
                    if (_editForm != null)
                        _editForm.LoadCurrPrefSetting(currPrefSetting);
                }
                else
                {
                    PasteCurrPrefSetting(currPrefSetting);
                }
            }
        }

        private string GetPrefSettingByButton(Button currButton)
        {
            string currPrefSetting = String.Empty;
            switch (currButton.Name)
            {
                case "Button1":
                    currPrefSetting = Properties.Settings.Default.btn1_pref;
                    break;

                case "Button2":
                    currPrefSetting = Properties.Settings.Default.btn2_pref;
                    break;

                case "Button3":
                    currPrefSetting = Properties.Settings.Default.btn3_pref;
                    break;

                case "Button4":
                    currPrefSetting = Properties.Settings.Default.btn4_pref;
                    break;

                case "Button5":
                    currPrefSetting = Properties.Settings.Default.btn5_pref;
                    break;

                case "Button6":
                    currPrefSetting = Properties.Settings.Default.btn6_pref;
                    break;

                case "Button7":
                    currPrefSetting = Properties.Settings.Default.btn7_pref;
                    break;

                case "Button8":
                    currPrefSetting = Properties.Settings.Default.btn8_pref;
                    break;

                case "Button9":
                    currPrefSetting = Properties.Settings.Default.btn9_pref;
                    break;

                case "Button10":
                    currPrefSetting = Properties.Settings.Default.btn10_pref;
                    break;
            }

            return currPrefSetting;
        }

        private void PasteCurrPrefSetting(string currPrefSetting)
        {
            if (!String.IsNullOrEmpty(currPrefSetting) &&
                currPrefSetting.Split(';').Count() >= 2)
            {
                string pasteValue = currPrefSetting.Split(';')[1];

                Clipboard.SetText(pasteValue);
                SendKeys.Send(Clipboard.GetText());
            }
        }
    }
}