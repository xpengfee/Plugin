using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using THS.Config;
namespace Svr.Plugin.Host
{
	/// <summary>
	/// frmConfig 的摘要说明。
	/// </summary>
	public class frmConfig : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbSyncServer;
        private System.Windows.Forms.Label lblSyncServer;
        private System.Windows.Forms.TextBox tbSyncServerAddress;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancle;
		private ConfigHelper m_config=new ConfigHelper();
        private System.Windows.Forms.TextBox tbDBConn;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbSyncServerName;
        private System.Windows.Forms.Label lblSyncName;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmConfig()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.gbSyncServer = new System.Windows.Forms.GroupBox();
            this.tbSyncServerAddress = new System.Windows.Forms.TextBox();
            this.lblSyncServer = new System.Windows.Forms.Label();
            this.tbDBConn = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbSyncServerName = new System.Windows.Forms.TextBox();
            this.lblSyncName = new System.Windows.Forms.Label();
            this.gbSyncServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSyncServer
            // 
            this.gbSyncServer.Controls.Add(this.tbSyncServerName);
            this.gbSyncServer.Controls.Add(this.lblSyncName);
            this.gbSyncServer.Controls.Add(this.tbSyncServerAddress);
            this.gbSyncServer.Controls.Add(this.lblSyncServer);
            this.gbSyncServer.Location = new System.Drawing.Point(16, 8);
            this.gbSyncServer.Name = "gbSyncServer";
            this.gbSyncServer.Size = new System.Drawing.Size(488, 95);
            this.gbSyncServer.TabIndex = 0;
            this.gbSyncServer.TabStop = false;
            this.gbSyncServer.Text = "同步服务器接口";
            // 
            // tbSyncServerAddress
            // 
            this.tbSyncServerAddress.Location = new System.Drawing.Point(109, 57);
            this.tbSyncServerAddress.Name = "tbSyncServerAddress";
            this.tbSyncServerAddress.Size = new System.Drawing.Size(363, 21);
            this.tbSyncServerAddress.TabIndex = 3;
            // 
            // lblSyncServer
            // 
            this.lblSyncServer.AutoSize = true;
            this.lblSyncServer.Location = new System.Drawing.Point(17, 61);
            this.lblSyncServer.Name = "lblSyncServer";
            this.lblSyncServer.Size = new System.Drawing.Size(77, 12);
            this.lblSyncServer.TabIndex = 0;
            this.lblSyncServer.Text = "服务器地址：";
            // 
            // tbDBConn
            // 
            this.tbDBConn.Location = new System.Drawing.Point(16, 24);
            this.tbDBConn.Name = "tbDBConn";
            this.tbDBConn.ReadOnly = true;
            this.tbDBConn.Size = new System.Drawing.Size(456, 21);
            this.tbDBConn.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保 存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(303, 119);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "取 消";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "选择监控目录";
            // 
            // tbSyncServerName
            // 
            this.tbSyncServerName.Location = new System.Drawing.Point(109, 20);
            this.tbSyncServerName.Name = "tbSyncServerName";
            this.tbSyncServerName.Size = new System.Drawing.Size(363, 21);
            this.tbSyncServerName.TabIndex = 5;
            // 
            // lblSyncName
            // 
            this.lblSyncName.AutoSize = true;
            this.lblSyncName.Location = new System.Drawing.Point(17, 24);
            this.lblSyncName.Name = "lblSyncName";
            this.lblSyncName.Size = new System.Drawing.Size(77, 12);
            this.lblSyncName.TabIndex = 4;
            this.lblSyncName.Text = "服务器名称：";
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(520, 156);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSyncServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器设置";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.gbSyncServer.ResumeLayout(false);
            this.gbSyncServer.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			SaveConfig();
			MessageBox.Show("保存成功！");
			this.Close();
		
		}


		private void frmConfig_Load(object sender, System.EventArgs e)
		{
			LoadConfig();
		}

		/// <summary>
		/// 读取配置
		/// </summary>
		private void LoadConfig()
		{
            this.tbSyncServerAddress.Text = m_config.SyncServerAddress;
            this.tbSyncServerName.Text = m_config.SyncServerName;
		}

		/// <summary>
		/// 写入配置
		/// </summary>
		private void SaveConfig()
		{
            m_config.SyncServerAddress = this.tbSyncServerAddress.Text;
            m_config.SyncServerName = this.tbSyncServerName.Text;
		}
	}
}
