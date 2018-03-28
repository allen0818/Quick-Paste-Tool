namespace Quick_Paste_Tool
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_EditTemplate = new System.Windows.Forms.GroupBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.RichTextBox_Content = new System.Windows.Forms.RichTextBox();
            this.TextBox_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox_EditTemplate.SuspendLayout();
            this.SuspendLayout();
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
            this.GroupBox_EditTemplate.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_EditTemplate.Name = "GroupBox_EditTemplate";
            this.GroupBox_EditTemplate.Size = new System.Drawing.Size(358, 170);
            this.GroupBox_EditTemplate.TabIndex = 16;
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
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 188);
            this.Controls.Add(this.GroupBox_EditTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.GroupBox_EditTemplate.ResumeLayout(false);
            this.GroupBox_EditTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_EditTemplate;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.RichTextBox RichTextBox_Content;
        private System.Windows.Forms.TextBox TextBox_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}