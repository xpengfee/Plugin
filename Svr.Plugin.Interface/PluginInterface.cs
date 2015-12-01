using System;
namespace Svr.Plugin.Interface
{
	public interface IPlugin
	{
		#region 基本属性
		/// <summary>
		/// 中文名称
		/// </summary>
		string CName {get;}
		/// <summary>
		/// 英文名称
		/// </summary>
		string EName {get;}
		/// <summary>
		/// 唯一标示,由调用主程序根据需求赋予，各插件可选择是否使用
		/// </summary>
        string Key { set; get; }
		/// <summary>
		/// 描述
		/// </summary>
		string Description {get;}
		/// <summary>
		/// 作者
		/// </summary>
		string Author {get;}
		/// <summary>
		/// 版本
		/// </summary>
		float Version {get;}
		#endregion


		/// <summary>
		/// 初始化
		/// </summary>
		void Initialize();
		/// <summary>
		/// 释放资源
		/// </summary>
		void Dispose();
		/// <summary>
		/// 启动
		/// </summary>
		void Start();
		/// <summary>
		/// 停止
		/// </summary>
		void Stop();		
		/// <summary>
		/// 主界面
		/// </summary>
		System.Windows.Forms.UserControl MainControl {get;}

	}

}
