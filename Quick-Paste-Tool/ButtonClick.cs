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
        private void button1_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DoButtonClickJob(sender);
        }

        private void DoButtonClickJob(object sender)
        {
            _currButton = sender as Button;
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

        private static string GetPrefSettingByButton(Button currButton)
        {
            string currPrefSetting = String.Empty;
            switch (currButton.Name)
            {
                case "button1":
                    currPrefSetting = Properties.Settings.Default.btn1_pref;
                    break;

                case "button2":
                    currPrefSetting = Properties.Settings.Default.btn2_pref;
                    break;

                case "button3":
                    currPrefSetting = Properties.Settings.Default.btn3_pref;
                    break;

                case "button4":
                    currPrefSetting = Properties.Settings.Default.btn4_pref;
                    break;

                case "button5":
                    currPrefSetting = Properties.Settings.Default.btn5_pref;
                    break;

                case "button6":
                    currPrefSetting = Properties.Settings.Default.btn6_pref;
                    break;

                case "button7":
                    currPrefSetting = Properties.Settings.Default.btn7_pref;
                    break;

                case "button8":
                    currPrefSetting = Properties.Settings.Default.btn8_pref;
                    break;

                case "button9":
                    currPrefSetting = Properties.Settings.Default.btn9_pref;
                    break;

                case "button10":
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