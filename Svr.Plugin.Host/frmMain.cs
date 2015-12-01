using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using log4net;
namespace Svr.Plugin.Host
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel;
		private System.Windows.Forms.TreeView tvwPlugins;
		private System.Windows.Forms.Panel pnlPlugin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblPluginName;
		private System.Windows.Forms.Label lblPluginVersion;
		private System.Windows.Forms.Label lblPluginAuthor;
		private System.Windows.Forms.Label lblPluginDesc;
		private PluginServices m_Plugins=null;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.ComponentModel.IContainer components;
        private ConfigHelper m_config = new ConfigHelper();
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger("dd");

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			Application.EnableVisualStyles();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.tvwPlugins = new System.Windows.Forms.TreeView();
            this.pnlPlugin = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPluginDesc = new System.Windows.Forms.Label();
            this.lblPluginAuthor = new System.Windows.Forms.Label();
            this.lblPluginVersion = new System.Windows.Forms.Label();
            this.lblPluginName = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem2});
            this.menuItem1.Text = "系统";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "配置";
            this.menuItem3.Visible = false;
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click_1);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "关于";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "退出";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 472);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(736, 26);
            this.statusBar.TabIndex = 1;
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Width = 10000;
            // 
            // tvwPlugins
            // 
            this.tvwPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPlugins.FullRowSelect = true;
            this.tvwPlugins.Location = new System.Drawing.Point(10, 9);
            this.tvwPlugins.Name = "tvwPlugins";
            this.tvwPlugins.ShowLines = false;
            this.tvwPlugins.ShowPlusMinus = false;
            this.tvwPlugins.ShowRootLines = false;
            this.tvwPlugins.Size = new System.Drawing.Size(118, 264);
            this.tvwPlugins.TabIndex = 2;
            this.tvwPlugins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPlugins_AfterSelect);
            // 
            // pnlPlugin
            // 
            this.pnlPlugin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlugin.Location = new System.Drawing.Point(136, 8);
            this.pnlPlugin.Name = "pnlPlugin";
            this.pnlPlugin.Size = new System.Drawing.Size(600, 440);
            this.pnlPlugin.TabIndex = 4;
            this.pnlPlugin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlugin_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblPluginDesc);
            this.groupBox1.Controls.Add(this.lblPluginAuthor);
            this.groupBox1.Controls.Add(this.lblPluginVersion);
            this.groupBox1.Controls.Add(this.lblPluginName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "插件信息:";
            // 
            // lblPluginDesc
            // 
            this.lblPluginDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginDesc.Location = new System.Drawing.Point(8, 80);
            this.lblPluginDesc.Name = "lblPluginDesc";
            this.lblPluginDesc.Size = new System.Drawing.Size(99, 80);
            this.lblPluginDesc.TabIndex = 3;
            this.lblPluginDesc.Text = "插件描述";
            // 
            // lblPluginAuthor
            // 
            this.lblPluginAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginAuthor.Location = new System.Drawing.Point(8, 56);
            this.lblPluginAuthor.Name = "lblPluginAuthor";
            this.lblPluginAuthor.Size = new System.Drawing.Size(99, 17);
            this.lblPluginAuthor.TabIndex = 2;
            this.lblPluginAuthor.Text = "By:作者";
            // 
            // lblPluginVersion
            // 
            this.lblPluginVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginVersion.Location = new System.Drawing.Point(8, 32);
            this.lblPluginVersion.Name = "lblPluginVersion";
            this.lblPluginVersion.Size = new System.Drawing.Size(99, 18);
            this.lblPluginVersion.TabIndex = 1;
            this.lblPluginVersion.Text = "版本";
            // 
            // lblPluginName
            // 
            this.lblPluginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginName.Location = new System.Drawing.Point(8, 16);
            this.lblPluginName.Name = "lblPluginName";
            this.lblPluginName.Size = new System.Drawing.Size(99, 17);
            this.lblPluginName.TabIndex = 0;
            this.lblPluginName.Text = "插件名称";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "运行中……";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(736, 498);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tvwPlugins);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlPlugin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(752, 536);
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(752, 536);
            this.Name = "frmMain";
            this.Text = "通用插件系统";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Move += new System.EventHandler(this.frmMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			frmMain mainForm = new frmMain();
			if (!RunningInstance())
			{

				Application.Run(mainForm);
			}
			else
			{
				MessageBox.Show("程序已经运行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
			}
		}
		/// <summary>
		/// 判断事例是否运行
		/// </summary>
		/// <returns></returns>
		private static bool RunningInstance()
		{log.Debug("RunningInstance");
			Process current = Process.GetCurrentProcess();
			Process[] processes = Process.GetProcessesByName(current.ProcessName);

			//遍历正在有相同名字运行的例程
			foreach (Process process in processes)
			{
				//忽略现有的例程
				if (process.Id != current.Id)
				{
					//确保例程从EXE文件运行
					if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\\\") ==
						current.MainModule.FileName)
					{
						//返回另一个例程实例
						return true;
					}
				}
			}
			//没有其它的例程，返回false
			return false;
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			m_Plugins =new PluginServices();
			//Call the find plugins routine, to search in our Plugins Folder
			m_Plugins.FindPlugins(Application.StartupPath + @"\Plugins");
			
			//添加插件
			foreach (Types.AvailablePlugin pluginOn in m_Plugins.AvailablePlugins)
			{
				//TreeNode newNode = new TreeNode(pluginOn.Instance.CName);
                TreeNode newNode = new TreeNode(System.IO.Path.GetFileNameWithoutExtension(pluginOn.AssemblyPath));
                newNode.Tag = pluginOn.AssemblyPath;
				this.tvwPlugins.Nodes.Add(newNode);
				newNode = null;
			}
            if (!String.IsNullOrWhiteSpace(m_config.SyncServerName))
            {
                this.Text += " - " + m_config.SyncServerName;
                notifyIcon1.Text = m_config.SyncServerName + "运行中";
            }
		}

		private void tvwPlugins_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			//Make sure there's a selected Plugin
			if (this.tvwPlugins.SelectedNode != null)
			{
				//Get the selected Plugin
                Types.AvailablePlugin selectedPlugin = m_Plugins.AvailablePlugins.Find(tvwPlugins.SelectedNode.Tag.ToString());
				
				if (selectedPlugin != null)
				{
					//Again, if the plugin is found, do some work...
					
					
					//This part adds the plugin's info to the 'Plugin Information:' Frame
					this.lblPluginName.Text = selectedPlugin.Instance.CName;
                   // this.lblPluginName.Text = System.IO.Path.GetFileNameWithoutExtension(selectedPlugin.AssemblyPath);

					this.lblPluginVersion.Text = "版本：" + selectedPlugin.Instance.Version;					
					this.lblPluginAuthor.Text = "作者： " + selectedPlugin.Instance.Author;
					this.lblPluginDesc.Text =" 描述："+selectedPlugin.Instance.Description;
					
					//Clear the current panel of any other plugin controls... 
					//Note: this only affects visuals.. doesn't close the instance of the plugin
					this.pnlPlugin.Controls.Clear();
					
					//Set the dockstyle of the plugin to fill, to fill up the space provided
					selectedPlugin.Instance.MainControl.Dock = DockStyle.Fill;
					
					//Finally, add the usercontrol to the panel... Tadah!
					this.pnlPlugin.Controls.Add(selectedPlugin.Instance.MainControl);
			
				}
			
			}
		}
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Close(); //User clicked File > Exit
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//Lets call the close for all the plugins before we truly exit!
			m_Plugins.ClosePlugins();
		}

		private void pnlPlugin_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//Feedback()
		}

		private void notifyIcon1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
		}

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
			this.Show();
			if (WindowState!=FormWindowState.Normal)
			{
				WindowState=FormWindowState.Normal;
			}
			this.Activate();
			this.Focus();
			this.notifyIcon1.Visible=false;

		}

		private void frmMain_Move(object sender, System.EventArgs e)
		{
			if (WindowState==FormWindowState.Minimized)
			{
				this.Hide();
				this.notifyIcon1.Visible=true;
			}

		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem3_Click_1(object sender, System.EventArgs e)
		{
			frmConfig frmc=new frmConfig();
			frmc.Show();
		
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			About about =new About();
			about.Show();

		}

	}
}
