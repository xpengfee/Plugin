namespace Svr.Plugin.SyncData.SMS
{
    partial class frmSMSRegister
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
            this.tbSerialPwd = new System.Windows.Forms.TextBox();
            this.lblSerialPwd = new System.Windows.Forms.Label();
            this.tbSerialNo = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.cbRegisterInfo = new System.Windows.Forms.GroupBox();
            this.tbContactAddress = new System.Windows.Forms.TextBox();
            this.lblContactAddress = new System.Windows.Forms.Label();
            this.tbContactZipcode = new System.Windows.Forms.TextBox();
            this.lblContactZipCode = new System.Windows.Forms.Label();
            this.tbContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.tbContactFax = new System.Windows.Forms.TextBox();
            this.lblContactFax = new System.Windows.Forms.Label();
            this.tbContactPhone = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.tbContactMobile = new System.Windows.Forms.TextBox();
            this.lblContactMobile = new System.Windows.Forms.Label();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbRegisterInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSerialPwd
            // 
            this.tbSerialPwd.Location = new System.Drawing.Point(298, 17);
            this.tbSerialPwd.Name = "tbSerialPwd";
            this.tbSerialPwd.PasswordChar = '*';
            this.tbSerialPwd.Size = new System.Drawing.Size(82, 21);
            this.tbSerialPwd.TabIndex = 16;
            // 
            // lblSerialPwd
            // 
            this.lblSerialPwd.AutoSize = true;
            this.lblSerialPwd.Location = new System.Drawing.Point(257, 20);
            this.lblSerialPwd.Name = "lblSerialPwd";
            this.lblSerialPwd.Size = new System.Drawing.Size(41, 12);
            this.lblSerialPwd.TabIndex = 15;
            this.lblSerialPwd.Text = "密码：";
            // 
            // tbSerialNo
            // 
            this.tbSerialNo.Location = new System.Drawing.Point(82, 17);
            this.tbSerialNo.Name = "tbSerialNo";
            this.tbSerialNo.Size = new System.Drawing.Size(169, 21);
            this.tbSerialNo.TabIndex = 14;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(12, 20);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(77, 12);
            this.lblSerialNo.TabIndex = 13;
            this.lblSerialNo.Text = "软件序列号：";
            // 
            // cbRegisterInfo
            // 
            this.cbRegisterInfo.Controls.Add(this.tbContactAddress);
            this.cbRegisterInfo.Controls.Add(this.lblContactAddress);
            this.cbRegisterInfo.Controls.Add(this.tbContactZipcode);
            this.cbRegisterInfo.Controls.Add(this.lblContactZipCode);
            this.cbRegisterInfo.Controls.Add(this.tbContactEmail);
            this.cbRegisterInfo.Controls.Add(this.lblContactEmail);
            this.cbRegisterInfo.Controls.Add(this.tbContactFax);
            this.cbRegisterInfo.Controls.Add(this.lblContactFax);
            this.cbRegisterInfo.Controls.Add(this.tbContactPhone);
            this.cbRegisterInfo.Controls.Add(this.lblContactPhone);
            this.cbRegisterInfo.Controls.Add(this.tbContactMobile);
            this.cbRegisterInfo.Controls.Add(this.lblContactMobile);
            this.cbRegisterInfo.Controls.Add(this.tbContactName);
            this.cbRegisterInfo.Controls.Add(this.lblContactName);
            this.cbRegisterInfo.Controls.Add(this.tbUserName);
            this.cbRegisterInfo.Controls.Add(this.lblUserName);
            this.cbRegisterInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRegisterInfo.Location = new System.Drawing.Point(10, 56);
            this.cbRegisterInfo.Name = "cbRegisterInfo";
            this.cbRegisterInfo.Size = new System.Drawing.Size(377, 181);
            this.cbRegisterInfo.TabIndex = 17;
            this.cbRegisterInfo.TabStop = false;
            this.cbRegisterInfo.Text = "用户注册基本信息";
            // 
            // tbContactAddress
            // 
            this.tbContactAddress.Location = new System.Drawing.Point(101, 137);
            this.tbContactAddress.Name = "tbContactAddress";
            this.tbContactAddress.Size = new System.Drawing.Size(268, 21);
            this.tbContactAddress.TabIndex = 24;
            // 
            // lblContactAddress
            // 
            this.lblContactAddress.AutoSize = true;
            this.lblContactAddress.Location = new System.Drawing.Point(8, 140);
            this.lblContactAddress.Name = "lblContactAddress";
            this.lblContactAddress.Size = new System.Drawing.Size(65, 12);
            this.lblContactAddress.TabIndex = 23;
            this.lblContactAddress.Text = "公司地址：";
            // 
            // tbContactZipcode
            // 
            this.tbContactZipcode.Location = new System.Drawing.Point(285, 110);
            this.tbContactZipcode.Name = "tbContactZipcode";
            this.tbContactZipcode.Size = new System.Drawing.Size(85, 21);
            this.tbContactZipcode.TabIndex = 22;
            // 
            // lblContactZipCode
            // 
            this.lblContactZipCode.AutoSize = true;
            this.lblContactZipCode.Location = new System.Drawing.Point(220, 113);
            this.lblContactZipCode.Name = "lblContactZipCode";
            this.lblContactZipCode.Size = new System.Drawing.Size(65, 12);
            this.lblContactZipCode.TabIndex = 21;
            this.lblContactZipCode.Text = "邮政编码：";
            // 
            // tbContactEmail
            // 
            this.tbContactEmail.Location = new System.Drawing.Point(101, 110);
            this.tbContactEmail.Name = "tbContactEmail";
            this.tbContactEmail.Size = new System.Drawing.Size(85, 21);
            this.tbContactEmail.TabIndex = 20;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(8, 113);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(65, 12);
            this.lblContactEmail.TabIndex = 19;
            this.lblContactEmail.Text = "电子邮件：";
            // 
            // tbContactFax
            // 
            this.tbContactFax.Location = new System.Drawing.Point(285, 81);
            this.tbContactFax.Name = "tbContactFax";
            this.tbContactFax.Size = new System.Drawing.Size(85, 21);
            this.tbContactFax.TabIndex = 18;
            // 
            // lblContactFax
            // 
            this.lblContactFax.AutoSize = true;
            this.lblContactFax.Location = new System.Drawing.Point(220, 84);
            this.lblContactFax.Name = "lblContactFax";
            this.lblContactFax.Size = new System.Drawing.Size(65, 12);
            this.lblContactFax.TabIndex = 17;
            this.lblContactFax.Text = "联系传真：";
            // 
            // tbContactPhone
            // 
            this.tbContactPhone.Location = new System.Drawing.Point(101, 81);
            this.tbContactPhone.Name = "tbContactPhone";
            this.tbContactPhone.Size = new System.Drawing.Size(85, 21);
            this.tbContactPhone.TabIndex = 16;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Location = new System.Drawing.Point(8, 84);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(65, 12);
            this.lblContactPhone.TabIndex = 15;
            this.lblContactPhone.Text = "联系电话：";
            // 
            // tbContactMobile
            // 
            this.tbContactMobile.Location = new System.Drawing.Point(285, 51);
            this.tbContactMobile.Name = "tbContactMobile";
            this.tbContactMobile.Size = new System.Drawing.Size(85, 21);
            this.tbContactMobile.TabIndex = 14;
            // 
            // lblContactMobile
            // 
            this.lblContactMobile.AutoSize = true;
            this.lblContactMobile.Location = new System.Drawing.Point(220, 54);
            this.lblContactMobile.Name = "lblContactMobile";
            this.lblContactMobile.Size = new System.Drawing.Size(65, 12);
            this.lblContactMobile.TabIndex = 13;
            this.lblContactMobile.Text = "联系手机：";
            // 
            // tbContactName
            // 
            this.tbContactName.Location = new System.Drawing.Point(101, 51);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(85, 21);
            this.tbContactName.TabIndex = 12;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(8, 54);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(77, 12);
            this.lblContactName.TabIndex = 11;
            this.lblContactName.Text = "联系人姓名：";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(101, 24);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(268, 21);
            this.tbUserName.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(8, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 12);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "企业(用户)名称：";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(100, 251);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "注 册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSMSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbRegisterInfo);
            this.Controls.Add(this.tbSerialPwd);
            this.Controls.Add(this.lblSerialPwd);
            this.Controls.Add(this.tbSerialNo);
            this.Controls.Add(this.lblSerialNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSMSRegister";
            this.Text = "注册";
            this.cbRegisterInfo.ResumeLayout(false);
            this.cbRegisterInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSerialPwd;
        private System.Windows.Forms.Label lblSerialPwd;
        private System.Windows.Forms.TextBox tbSerialNo;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.GroupBox cbRegisterInfo;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbContactAddress;
        private System.Windows.Forms.Label lblContactAddress;
        private System.Windows.Forms.TextBox tbContactZipcode;
        private System.Windows.Forms.Label lblContactZipCode;
        private System.Windows.Forms.TextBox tbContactEmail;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.TextBox tbContactFax;
        private System.Windows.Forms.Label lblContactFax;
        private System.Windows.Forms.TextBox tbContactPhone;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.TextBox tbContactMobile;
        private System.Windows.Forms.Label lblContactMobile;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}