using System;
using System.IO;
using System.Reflection;
using Svr.Plugin.Interface;
namespace Svr.Plugin.Host 
{
	/// <summary>
	/// Summary description for PluginServices.
	/// </summary>
	public class PluginServices  
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public PluginServices()
		{
		}
	
		private Types.AvailablePlugins colAvailablePlugins = new Types.AvailablePlugins();
		
		/// <summary>
		/// 插件队列
		/// </summary>
		public Types.AvailablePlugins AvailablePlugins
		{
			get {return colAvailablePlugins;}
			set {colAvailablePlugins = value;}
		}
		
		/// <summary>
		/// 查找当前目录插件
		/// </summary>
		public void FindPlugins()
		{
			FindPlugins(AppDomain.CurrentDomain.BaseDirectory);
		}
		/// <summary>
		/// 指定目录查找插件
		/// </summary>
		/// <param name="Path">待查目录</param>
		public void FindPlugins(string Path)
		{
			//首先清空插件LIST
			colAvailablePlugins.Clear();
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
			//搜索指定目录
			foreach (string fileOn in Directory.GetFiles(Path,"*.dll"))
			{
				try
				{
					this.AddPlugin(fileOn);				
				}
				catch(System.Exception ex)
				{
					string aa=ex.Message;
				}
			}
		}
		
		/// <summary>
		/// 关闭插件
		/// </summary>
		public void ClosePlugins()
		{
			foreach (Types.AvailablePlugin pluginOn in colAvailablePlugins)
			{
				//调用Dispose方法
				pluginOn.Instance.Dispose(); 
				
				pluginOn.Instance = null;
			}
			
			//清空列表
			colAvailablePlugins.Clear();
		}
		
		private void AddPlugin(string FileName)
		{
			//创建插件
			Assembly pluginAssembly = Assembly.LoadFrom(FileName);
			
			//获取方法类型
			foreach (Type pluginType in pluginAssembly.GetTypes())
			{
				if (pluginType.IsPublic) //必须是 public
				{
					if (!pluginType.IsAbstract)  //不能为abstract types
					{
                        Type typeInterface = pluginType.GetInterface("Svr.Plugin.Interface.IPlugin", true);
						
						//确定必须实现PluginInterface.IPlugin方法
						if (typeInterface != null)
						{
							//创建一个指定插件
							Types.AvailablePlugin newPlugin = new Types.AvailablePlugin();
							
							newPlugin.AssemblyPath = FileName;
							
							newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
                            //设置插件的KEY sunlq
                            newPlugin.Instance.Key = System.IO.Path.GetFileNameWithoutExtension(FileName);
							//调用初始化方法
							newPlugin.Instance.Initialize();
							
							//当前插件插入到插件队列
							this.colAvailablePlugins.Add(newPlugin);
							
							//cleanup a bit
							newPlugin = null;
						}	
						
						typeInterface = null; //Mr. Clean			
					}				
				}			
			}
			
			pluginAssembly = null; //more cleanup
		}

	}
	namespace Types
	{
		/// <summary>
		/// 插件队列
		/// </summary>
		public class AvailablePlugins : System.Collections.CollectionBase
		{

			/// <summary>
			/// 从队列中插入指定插件
			/// </summary>
			/// <param name="pluginToAdd">待插入插件</param>
			public void Add(Types.AvailablePlugin pluginToAdd)
			{
				this.List.Add(pluginToAdd); 
			}
		
			/// <summary>
			/// 从队列中删除指定插件
			/// </summary>
			/// <param name="pluginToRemove">待删除插件</param>
			public void Remove(Types.AvailablePlugin pluginToRemove)
			{
				this.List.Remove(pluginToRemove);
			}
		
			/// <summary>
			/// 查找指定插件
			/// </summary>
			/// <param name="pluginNameOrPath">指定路径或者插件名</param>
			/// <returns>找到的插件或者返回NULL</returns>
			public Types.AvailablePlugin Find(string pluginNameOrPath)
			{
				Types.AvailablePlugin toReturn = null;
			
				//循环队列
				foreach (Types.AvailablePlugin pluginOn in this.List)
				{
					if (pluginOn.AssemblyPath.Equals(pluginNameOrPath))
					{
						toReturn = pluginOn;
						break;		
					}
				}
				return toReturn;
			}
		}
		
		/// <summary>
		/// 插件属性
		/// </summary>
		public class AvailablePlugin
		{
			private IPlugin myInstance = null;
			private string myAssemblyPath = "";
			
			public IPlugin Instance
			{
				get {return myInstance;}
				set	{myInstance = value;}
			}
			public string AssemblyPath
			{
				get {return myAssemblyPath;}
				set {myAssemblyPath = value;}
			}
		}
	}	
}

