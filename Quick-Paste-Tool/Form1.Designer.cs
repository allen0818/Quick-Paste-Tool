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
            this.RadioButton_EditMode = new System.Windows.Forms.RadioButton();
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
            this.GroupBox_EditTemplate = new System.Windows.Forms.GroupBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.RichTextBox_Content = new System.Windows.Forms.RichTextBox();
            this.TextBox_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GroupBox_EditTemplate.SuspendLayout();
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
            this.panel1.Controls.Add(this.RadioButton_EditMode);
            this.panel1.Controls.Add(this.RadioButton_RunningMode);
            this.panel1.Location = new System.Drawing.Point(79, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 25);
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
            this.RadioButton_RunningMode.Location = new System.Drawing.Point(8, 5);
            this.RadioButton_RunningMode.Name = "RadioButton_RunningMode";
            this.RadioButton_RunningMode.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_RunningMode.TabIndex = 5;
            this.RadioButton_RunningMode.TabStop = true;
            this.RadioButton_RunningMode.Text = "使用中";
            this.RadioButton_RunningMode.UseVisualStyleBackColor = true;
            this.RadioButton_RunningMode.CheckedChanged += new System.EventHandler(this.RadioButton_Mode_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "範本2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "範本3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(232, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "範本4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "範本5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(306, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "範本10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(232, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "範本9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "範本8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(84, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "範本7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "範本6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // GroupBox_EditTemplate
            // 
            this.GroupBox_EditTemplate.Controls.Add(this.Button_Cancel);
            this.GroupBox_EditTemplate.Controls.Add(this.Button_Save);
            this.GroupBox_EditTemplate.Controls.Add(this.RichTextBox_Content);
            this.GroupBox_EditTemplate.Controls.Add(this.TextBox_Title);
            this.GroupBox_EditTemplate.Controls.Add(this.label4);
            this.GroupBox_EditTemplate.Controls.Add(this.label3);
            this.GroupBox_EditTemplate.Controls.Add(this.label2);
            this.GroupBox_EditTemplate.Location = new System.Drawing.Point(10, 118);
            this.GroupBox_EditTemplate.Name = "GroupBox_EditTemplate";
            this.GroupBox_EditTemplate.Size = new System.Drawing.Size(358, 170);
            this.GroupBox_EditTemplate.TabIndex = 15;
            this.GroupBox_EditTemplate.TabStop = false;
            this.GroupBox_EditTemplate.Text = "編輯範本";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(297, 141);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(52, 23);
            this.Button_Cancel.TabIndex = 16;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(242, 141);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(52, 23);
            this.Button_Save.TabIndex = 16;
            this.Button_Save.Text = "儲存";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // RichTextBox_Content
            // 
            this.RichTextBox_Content.Location = new System.Drawing.Point(80, 76);
            this.RichTextBox_Content.Name = "RichTextBox_Content";
            this.RichTextBox_Content.Size = new System.Drawing.Size(269, 58);
            this.RichTextBox_Content.TabIndex = 8;
            this.RichTextBox_Content.Text = "";
            // 
            // TextBox_Title
            // 
            this.TextBox_Title.Location = new System.Drawing.Point(80, 46);
            this.TextBox_Title.Name = "TextBox_Title";
            this.TextBox_Title.Size = new System.Drawing.Size(85, 22);
            this.TextBox_Title.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "範本內容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "按鈕標題";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "請先點選要編輯的按鈕";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 292);
            this.Controls.Add(this.GroupBox_EditTemplate);
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
            this.GroupBox_EditTemplate.ResumeLayout(false);
            this.GroupBox_EditTemplate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_StayOnTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButton_EditMode;
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
        private System.Windows.Forms.GroupBox GroupBox_EditTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RichTextBox_Content;
        private System.Windows.Forms.TextBox TextBox_Title;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Cancel;
    }
}

