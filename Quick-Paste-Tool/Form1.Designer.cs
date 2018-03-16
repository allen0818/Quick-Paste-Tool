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
            this.RadioButton_RunningMode = new System.Windows.Forms.RadioButton();
            this.RadioButton_SettingMode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CheckBox_StayOnTop
            // 
            this.CheckBox_StayOnTop.AutoSize = true;
            this.CheckBox_StayOnTop.Location = new System.Drawing.Point(269, 12);
            this.CheckBox_StayOnTop.Name = "CheckBox_StayOnTop";
            this.CheckBox_StayOnTop.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_StayOnTop.TabIndex = 0;
            this.CheckBox_StayOnTop.Text = "保持置頂";
            this.CheckBox_StayOnTop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "範本1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "當前模式";
            // 
            // RadioButton_RunningMode
            // 
            this.RadioButton_RunningMode.AutoSize = true;
            this.RadioButton_RunningMode.Location = new System.Drawing.Point(81, 13);
            this.RadioButton_RunningMode.Name = "RadioButton_RunningMode";
            this.RadioButton_RunningMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_RunningMode.TabIndex = 3;
            this.RadioButton_RunningMode.TabStop = true;
            this.RadioButton_RunningMode.Text = "使用中";
            this.RadioButton_RunningMode.UseVisualStyleBackColor = true;
            // 
            // RadioButton_SettingMode
            // 
            this.RadioButton_SettingMode.AutoSize = true;
            this.RadioButton_SettingMode.Location = new System.Drawing.Point(146, 13);
            this.RadioButton_SettingMode.Name = "RadioButton_SettingMode";
            this.RadioButton_SettingMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_SettingMode.TabIndex = 4;
            this.RadioButton_SettingMode.TabStop = true;
            this.RadioButton_SettingMode.Text = "設定中";
            this.RadioButton_SettingMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 133);
            this.Controls.Add(this.RadioButton_SettingMode);
            this.Controls.Add(this.RadioButton_RunningMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckBox_StayOnTop);
            this.Name = "Form1";
            this.Text = "Quick Paste Tool v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_StayOnTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioButton_RunningMode;
        private System.Windows.Forms.RadioButton RadioButton_SettingMode;
    }
}

