namespace Svr.Plugin.SyncData.SMS
{
    partial class frmSendSMS
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关 闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(77, 176);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "发 送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(77, 42);
            this.tbContent.MaxLength = 140;
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(226, 67);
            this.tbContent.TabIndex = 20;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(15, 45);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(65, 12);
            this.lblContent.TabIndex = 19;
            this.lblContent.Text = "短信内容：";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(77, 12);
            this.tbMobile.MaxLength = 11;
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(226, 21);
            this.tbMobile.TabIndex = 18;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(15, 15);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 12);
            this.lblMobile.TabIndex = 17;
            this.lblMobile.Text = "手 机 号：";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Blue;
            this.lblTip.Location = new System.Drawing.Point(56, 129);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(173, 12);
            this.lblTip.TabIndex = 23;
            this.lblTip.Text = "注：短信字符请定义在70字之内";
            // 
            // frmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 212);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.lblMobile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendSMS";
            this.Text = "发送测试短信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblTip;
    }
}