namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_submit = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(12, 12);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(314, 247);
            this.textBox_log.TabIndex = 0;
            this.textBox_log.TextChanged += new System.EventHandler(this.textBox_log_TextChanged);
            this.textBox_log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_log_KeyDown);
            // 
            // textBox_submit
            // 
            this.textBox_submit.Location = new System.Drawing.Point(12, 265);
            this.textBox_submit.Name = "textBox_submit";
            this.textBox_submit.Size = new System.Drawing.Size(233, 25);
            this.textBox_submit.TabIndex = 1;
            this.textBox_submit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_submit_KeyDown);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(251, 267);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 302);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_submit);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_submit;
        private System.Windows.Forms.Button button_submit;
    }
}

