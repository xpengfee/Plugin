using System;
using System.Reflection;

namespace Svr.Plugin.Interface
{
	/// <summary>
	/// APlugin 的摘要说明。
	/// </summary>
	public abstract class APlugin:IPlugin
	{
		private string cCName;
		private string cEName;
		private string cDescription;
        private string cAuthor;
        private string cKey;
        private float fVersion;

		public APlugin()
		{
			Assembly a = Assembly.GetExecutingAssembly();
			object[] attrib = a.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
			cCName = ((AssemblyTitleAttribute)attrib[0]).Title;
			
			attrib = a.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
			cEName = ((AssemblyProductAttribute)attrib[0]).Product;

			attrib = a.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
			cDescription = ((AssemblyDescriptionAttribute)attrib[0]).Description;

			attrib = a.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
			cAuthor = ((AssemblyCopyrightAttribute)attrib[0]).Copyright;

			fVersion=float.Parse(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString()+"."+System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString());

		}
		#region IPlugin 成员

		public string CName
		{
			get
			{
				return cCName;
			}
		}

		public string EName
		{
			get
			{
				return cEName;
			}
		}

		public string Key
		{
            set {
                cKey = value;
            }
			get
			{
				return cKey;
			}
		}

		public string Description
		{
			get
			{
				return cDescription;
			}
		}

		public string Author
		{
			get
			{
				return cAuthor;
			}
		}

		public float Version
		{
			get
			{
				return fVersion;
			}
		}
		public abstract System.Windows.Forms.UserControl MainControl
		{
			get;
		}


		public abstract void Initialize();
		public abstract void Start();
		public abstract void Stop();
		public abstract void Dispose();




		#endregion
	}
}
