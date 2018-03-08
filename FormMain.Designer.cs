namespace SmartGG
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.Location = new System.Drawing.Point(12, 42);
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.Size = new System.Drawing.Size(367, 95);
            this.richTextBox_Input.TabIndex = 0;
            this.richTextBox_Input.Text = "";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 159);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(534, 202);
            this.richTextBox_Output.TabIndex = 1;
            this.richTextBox_Output.Text = "";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(385, 57);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(148, 66);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 484);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.richTextBox_Output);
            this.Controls.Add(this.richTextBox_Input);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.Button button_send;
    }
}

