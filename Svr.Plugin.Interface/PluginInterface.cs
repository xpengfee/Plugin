using System;
namespace Svr.Plugin.Interface
{
	public interface IPlugin
	{
		#region ��������
		/// <summary>
		/// ��������
		/// </summary>
		string CName {get;}
		/// <summary>
		/// Ӣ������
		/// </summary>
		string EName {get;}
		/// <summary>
		/// Ψһ��ʾ,�ɵ�����������������裬�������ѡ���Ƿ�ʹ��
		/// </summary>
        string Key { set; get; }
		/// <summary>
		/// ����
		/// </summary>
		string Description {get;}
		/// <summary>
		/// ����
		/// </summary>
		string Author {get;}
		/// <summary>
		/// �汾
		/// </summary>
		float Version {get;}
		#endregion


		/// <summary>
		/// ��ʼ��
		/// </summary>
		void Initialize();
		/// <summary>
		/// �ͷ���Դ
		/// </summary>
		void Dispose();
		/// <summary>
		/// ����
		/// </summary>
		void Start();
		/// <summary>
		/// ֹͣ
		/// </summary>
		void Stop();		
		/// <summary>
		/// ������
		/// </summary>
		System.Windows.Forms.UserControl MainControl {get;}

	}

}
