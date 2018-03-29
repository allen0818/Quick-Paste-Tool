namespace Quick_Paste_Tool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.CheckBox_StayOnTop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButton_EditMode = new System.Windows.Forms.RadioButton();
            this.RadioButton_RunningMode = new System.Windows.Forms.RadioButton();
            this.ToolTip_Title = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox_Hotkey = new System.Windows.Forms.GroupBox();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GroupBox_Hotkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckBox_StayOnTop
            // 
            this.CheckBox_StayOnTop.AutoSize = true;
            this.CheckBox_StayOnTop.Location = new System.Drawing.Point(304, 12);
            this.CheckBox_StayOnTop.Name = "CheckBox_StayOnTop";
            this.CheckBox_StayOnTop.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_StayOnTop.TabIndex = 0;
            this.CheckBox_StayOnTop.Text = "保持置頂";
            this.CheckBox_StayOnTop.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "目前模式：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioButton_EditMode);
            this.panel1.Controls.Add(this.RadioButton_RunningMode);
            this.panel1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(80, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 25);
            this.panel1.TabIndex = 5;
            // 
            // RadioButton_EditMode
            // 
            this.RadioButton_EditMode.AutoSize = true;
            this.RadioButton_EditMode.Location = new System.Drawing.Point(73, 5);
            this.RadioButton_EditMode.Name = "RadioButton_EditMode";
            this.RadioButton_EditMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_EditMode.TabIndex = 6;
            this.RadioButton_EditMode.Text = "設定中";
            this.RadioButton_EditMode.UseVisualStyleBackColor = true;
            // 
            // RadioButton_RunningMode
            // 
            this.RadioButton_RunningMode.AutoSize = true;
            this.RadioButton_RunningMode.Checked = true;
            this.RadioButton_RunningMode.Location = new System.Drawing.Point(10, 5);
            this.RadioButton_RunningMode.Name = "RadioButton_RunningMode";
            this.RadioButton_RunningMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_RunningMode.TabIndex = 5;
            this.RadioButton_RunningMode.TabStop = true;
            this.RadioButton_RunningMode.Text = "使用中";
            this.RadioButton_RunningMode.UseVisualStyleBackColor = true;
            this.RadioButton_RunningMode.CheckedChanged += new System.EventHandler(this.RadioButton_Mode_CheckedChanged);
            // 
            // ToolTip_Title
            // 
            this.ToolTip_Title.ShowAlways = true;
            // 
            // GroupBox_Hotkey
            // 
            this.GroupBox_Hotkey.Controls.Add(this.Button10);
            this.GroupBox_Hotkey.Controls.Add(this.Button9);
            this.GroupBox_Hotkey.Controls.Add(this.Button8);
            this.GroupBox_Hotkey.Controls.Add(this.Button7);
            this.GroupBox_Hotkey.Controls.Add(this.Button6);
            this.GroupBox_Hotkey.Controls.Add(this.Button5);
            this.GroupBox_Hotkey.Controls.Add(this.Button4);
            this.GroupBox_Hotkey.Controls.Add(this.Button3);
            this.GroupBox_Hotkey.Controls.Add(this.Button2);
            this.GroupBox_Hotkey.Controls.Add(this.Button1);
            this.GroupBox_Hotkey.Location = new System.Drawing.Point(9, 33);
            this.GroupBox_Hotkey.Name = "GroupBox_Hotkey";
            this.GroupBox_Hotkey.Size = new System.Drawing.Size(366, 72);
            this.GroupBox_Hotkey.TabIndex = 15;
            this.GroupBox_Hotkey.TabStop = false;
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(300, 42);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(62, 23);
            this.Button10.TabIndex = 24;
            this.Button10.Text = "範本10";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(226, 42);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(62, 23);
            this.Button9.TabIndex = 23;
            this.Button9.Text = "範本9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(152, 42);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(62, 23);
            this.Button8.TabIndex = 22;
            this.Button8.Text = "範本8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(78, 42);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(62, 23);
            this.Button7.TabIndex = 21;
            this.Button7.Text = "範本7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(4, 42);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(62, 23);
            this.Button6.TabIndex = 20;
            this.Button6.Text = "範本6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(300, 14);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(62, 23);
            this.Button5.TabIndex = 19;
            this.Button5.Text = "範本5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(226, 14);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(62, 23);
            this.Button4.TabIndex = 18;
            this.Button4.Text = "範本4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(152, 14);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(62, 23);
            this.Button3.TabIndex = 17;
            this.Button3.Text = "範本3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(78, 14);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(62, 23);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "範本2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(4, 14);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(62, 23);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "範本1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 112);
            this.Controls.Add(this.GroupBox_Hotkey);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBox_StayOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Quick Paste Tool v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBox_Hotkey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_StayOnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButton_EditMode;
        private System.Windows.Forms.RadioButton RadioButton_RunningMode;
        private System.Windows.Forms.ToolTip ToolTip_Title;
        private System.Windows.Forms.GroupBox GroupBox_Hotkey;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
    }
}

