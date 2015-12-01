namespace Svr.Plugin.SyncData.SMS
{
    partial class frmChargeUp
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
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnChargeUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCardNo
            // 
            this.tbCardNo.Location = new System.Drawing.Point(85, 16);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(153, 21);
            this.tbCardNo.TabIndex = 12;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(32, 19);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(41, 12);
            this.lblCardNo.TabIndex = 11;
            this.lblCardNo.Text = "卡号：";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(85, 46);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(153, 21);
            this.tbPwd.TabIndex = 14;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(32, 49);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(41, 12);
            this.lblPwd.TabIndex = 13;
            this.lblPwd.Text = "密码：";
            // 
            // btnChargeUp
            // 
            this.btnChargeUp.Location = new System.Drawing.Point(82, 85);
            this.btnChargeUp.Name = "btnChargeUp";
            this.btnChargeUp.Size = new System.Drawing.Size(75, 23);
            this.btnChargeUp.TabIndex = 15;
            this.btnChargeUp.Text = "充 值";
            this.btnChargeUp.UseVisualStyleBackColor = true;
            this.btnChargeUp.Click += new System.EventHandler(this.btnChargeUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChargeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 126);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChargeUp);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.tbCardNo);
            this.Controls.Add(this.lblCardNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChargeUp";
            this.Text = "充值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnChargeUp;
        private System.Windows.Forms.Button btnCancel;
    }
}