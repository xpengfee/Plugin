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
		/// ���캯��
		/// </summary>
		public PluginServices()
		{
		}
	
		private Types.AvailablePlugins colAvailablePlugins = new Types.AvailablePlugins();
		
		/// <summary>
		/// �������
		/// </summary>
		public Types.AvailablePlugins AvailablePlugins
		{
			get {return colAvailablePlugins;}
			set {colAvailablePlugins = value;}
		}
		
		/// <summary>
		/// ���ҵ�ǰĿ¼���
		/// </summary>
		public void FindPlugins()
		{
			FindPlugins(AppDomain.CurrentDomain.BaseDirectory);
		}
		/// <summary>
		/// ָ��Ŀ¼���Ҳ��
		/// </summary>
		/// <param name="Path">����Ŀ¼</param>
		public void FindPlugins(string Path)
		{
			//������ղ��LIST
			colAvailablePlugins.Clear();
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
			//����ָ��Ŀ¼
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
		/// �رղ��
		/// </summary>
		public void ClosePlugins()
		{
			foreach (Types.AvailablePlugin pluginOn in colAvailablePlugins)
			{
				//����Dispose����
				pluginOn.Instance.Dispose(); 
				
				pluginOn.Instance = null;
			}
			
			//����б�
			colAvailablePlugins.Clear();
		}
		
		private void AddPlugin(string FileName)
		{
			//�������
			Assembly pluginAssembly = Assembly.LoadFrom(FileName);
			
			//��ȡ��������
			foreach (Type pluginType in pluginAssembly.GetTypes())
			{
				if (pluginType.IsPublic) //������ public
				{
					if (!pluginType.IsAbstract)  //����Ϊabstract types
					{
                        Type typeInterface = pluginType.GetInterface("Svr.Plugin.Interface.IPlugin", true);
						
						//ȷ������ʵ��PluginInterface.IPlugin����
						if (typeInterface != null)
						{
							//����һ��ָ�����
							Types.AvailablePlugin newPlugin = new Types.AvailablePlugin();
							
							newPlugin.AssemblyPath = FileName;
							
							newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
                            //���ò����KEY sunlq
                            newPlugin.Instance.Key = System.IO.Path.GetFileNameWithoutExtension(FileName);
							//���ó�ʼ������
							newPlugin.Instance.Initialize();
							
							//��ǰ������뵽�������
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
		/// �������
		/// </summary>
		public class AvailablePlugins : System.Collections.CollectionBase
		{

			/// <summary>
			/// �Ӷ����в���ָ�����
			/// </summary>
			/// <param name="pluginToAdd">��������</param>
			public void Add(Types.AvailablePlugin pluginToAdd)
			{
				this.List.Add(pluginToAdd); 
			}
		
			/// <summary>
			/// �Ӷ�����ɾ��ָ�����
			/// </summary>
			/// <param name="pluginToRemove">��ɾ�����</param>
			public void Remove(Types.AvailablePlugin pluginToRemove)
			{
				this.List.Remove(pluginToRemove);
			}
		
			/// <summary>
			/// ����ָ�����
			/// </summary>
			/// <param name="pluginNameOrPath">ָ��·�����߲����</param>
			/// <returns>�ҵ��Ĳ�����߷���NULL</returns>
			public Types.AvailablePlugin Find(string pluginNameOrPath)
			{
				Types.AvailablePlugin toReturn = null;
			
				//ѭ������
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
		/// �������
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

