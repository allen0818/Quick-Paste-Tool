namespace Quick_Paste_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBox_StayOnTop = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButton_SettingMode = new System.Windows.Forms.RadioButton();
            this.RadioButton_RunningMode = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckBox_StayOnTop
            // 
            this.CheckBox_StayOnTop.AutoSize = true;
            this.CheckBox_StayOnTop.Location = new System.Drawing.Point(301, 14);
            this.CheckBox_StayOnTop.Name = "CheckBox_StayOnTop";
            this.CheckBox_StayOnTop.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_StayOnTop.TabIndex = 0;
            this.CheckBox_StayOnTop.Text = "保持置頂";
            this.CheckBox_StayOnTop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "範本1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "當前模式";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioButton_SettingMode);
            this.panel1.Controls.Add(this.RadioButton_RunningMode);
            this.panel1.Location = new System.Drawing.Point(79, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 25);
            this.panel1.TabIndex = 5;
            // 
            // RadioButton_SettingMode
            // 
            this.RadioButton_SettingMode.AutoSize = true;
            this.RadioButton_SettingMode.Location = new System.Drawing.Point(73, 5);
            this.RadioButton_SettingMode.Name = "RadioButton_SettingMode";
            this.RadioButton_SettingMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_SettingMode.TabIndex = 6;
            this.RadioButton_SettingMode.Text = "設定中";
            this.RadioButton_SettingMode.UseVisualStyleBackColor = true;
            // 
            // RadioButton_RunningMode
            // 
            this.RadioButton_RunningMode.AutoSize = true;
            this.RadioButton_RunningMode.Checked = true;
            this.RadioButton_RunningMode.Location = new System.Drawing.Point(8, 5);
            this.RadioButton_RunningMode.Name = "RadioButton_RunningMode";
            this.RadioButton_RunningMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_RunningMode.TabIndex = 5;
            this.RadioButton_RunningMode.TabStop = true;
            this.RadioButton_RunningMode.Text = "使用中";
            this.RadioButton_RunningMode.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "範本2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "範本3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(232, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "範本4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "範本5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(306, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "範本10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(232, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "範本9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "範本8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(84, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "範本7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "範本6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 112);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckBox_StayOnTop);
            this.Name = "Form1";
            this.Text = "Quick Paste Tool v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_StayOnTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButton_SettingMode;
        private System.Windows.Forms.RadioButton RadioButton_RunningMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

