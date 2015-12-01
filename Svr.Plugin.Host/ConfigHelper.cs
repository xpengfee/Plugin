using System;
using System.Configuration;
using THS.Config;
using System.IO;
using System.Text;
namespace Svr.Plugin.Host
{
	/// <summary>
	/// ConfigHelper 的摘要说明。
	/// </summary>
	public class ConfigHelper
	{
		private THS.Config.Xml config=new Xml();
		private static ConfigHelper _Instance;
		public ConfigHelper()
		{
		}		
		static  ConfigHelper()
		{
			_Instance = new ConfigHelper();
		}
		public static ConfigHelper Instance
		{
			get { return _Instance; }
		}


		/// <summary>
		/// 接口地址
		/// </summary>
		public string SyncServerAddress
		{
			get
			{
                return config.GetValue("SYS", "SyncServerAddress", "http://127.0.0.1/WSTJAM/SAPSyncService.asmx");
            }
			set
			{
                config.SetValue("SYS", "SyncServerAddress", value);
			}
		}
        /// <summary>
        /// 接口地址
        /// </summary>
        public string SyncServerName
        {
            get
            {
                return config.GetValue("SYS", "SyncServerName", "");
            }
            set
            {
                config.SetValue("SYS", "SyncServerName", value);
            }
        }
    }
}
