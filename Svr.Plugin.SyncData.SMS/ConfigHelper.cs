using System;
using System.Configuration;
using THS.Config;
using System.IO;
using System.Text;
namespace Svr.Plugin.SyncData.SMS
{
    /// <summary>
    /// ConfigHelper ��ժҪ˵����
    /// </summary>
    public class ConfigHelper
    {
        private THS.Config.Xml config = new Xml();
        private static ConfigHelper _Instance;
        private Main m_main = null;
        public ConfigHelper()
        {
            m_main = new Main();
        }
        static ConfigHelper()
        {
            _Instance = new ConfigHelper();
        }
        public static ConfigHelper Instance
        {
            get
            {
                return _Instance;
            }
        }

        #region ԭ������
        public string CName
        {
            get
            {
                return m_main.CName;
            }
        }
        public string EName
        {
            get
            {
                return m_main.EName;
            }
        }
        public string Key
        {
            get
            {
                if (string.IsNullOrEmpty(m_main.Key))
                    return m_main.EName;
                else
                    return m_main.Key;
            }
        }
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
        /// �Ƿ��Զ�����
        /// </summary>
        public bool AutoRun
        {
            get
            {
                return config.GetValue(Key, "AutoRun", false);
            }
            set
            {
                config.SetValue(Key, "AutoRun", value);
            }
        }

        /// <summary>
        /// �Ƿ���ʾ����״̬
        /// </summary>
        public bool ShowStatu
        {
            get
            {
                return config.GetValue(Key, "ShowStatu", true);
            }
            set
            {
                config.SetValue(Key, "ShowStatu", value);
            }
        }

        /// <summary>
        /// �Ƿ������ʱ��ͬ��
        /// </summary>
        public bool OnlyWorkTime
        {
            get
            {
                return config.GetValue(Key, "OnlyWorkTime", true);
            }
            set
            {
                config.SetValue(Key, "OnlyWorkTime", value);
            }
        }

        /// <summary>
        /// WorkTimeStart
        /// </summary>
        public string WorkTimeStart
        {
            get
            {
                return config.GetValue(Key, "WorkTimeStart", "08:00");
            }
            set
            {
                config.SetValue(Key, "WorkTimeStart", value);
            }
        }

        /// <summary>
        /// WorkTimeEnd
        /// </summary>
        public string WorkTimeEnd
        {
            get
            {
                return config.GetValue(Key, "WorkTimeEnd", "18:00");
            }
            set
            {
                config.SetValue(Key, "WorkTimeEnd", value);
            }
        }

        /// <summary>
        /// DispNum
        /// </summary>
        public int DispNum
        {
            get
            {
                return config.GetValue(Key, "DispNum", 100);
            }
            set
            {
                config.SetValue(Key, "DispNum", value);
            }
        }

        /// <summary>
        /// SleepGap
        /// </summary>
        public int SleepGap
        {
            get
            {
                return config.GetValue(Key, "SleepGap", 200);
            }
            set
            {
                config.SetValue(Key, "SleepGap", value);
            }
        }

        /// <summary>
        /// SyncGap
        /// </summary>
        public int SyncGap
        {
            get
            {
                return config.GetValue(Key, "SyncGap", 30);
            }
            set
            {
                config.SetValue(Key, "SyncGap", value);
            }
        }

        /// <summary>
        /// �Ƿ��Զ�ͬ��������Ϣ
        /// </summary>
        public bool AutoSyncError
        {
            get
            {
                return config.GetValue(Key, "AutoSyncError", true);
            }
            set
            {
                config.SetValue(Key, "AutoSyncError", value);
            }
        }

        /// <summary>
        /// SyncErrorTimeStart
        /// </summary>
        public string SyncErrorTimeStart
        {
            get
            {
                return config.GetValue(Key, "SyncErrorTimeStart", "22:00");
            }
            set
            {
                config.SetValue(Key, "SyncErrorTimeStart", value);
            }
        }

        /// <summary>
        /// SyncErrorTimeEnd
        /// </summary>
        public string SyncErrorTimeEnd
        {
            get
            {
                return config.GetValue(Key, "SyncErrorTimeEnd", "23:00");
            }
            set
            {
                config.SetValue(Key, "SyncErrorTimeEnd", value);
            }
        }

        #endregion

        #region �������� Sn/SnPwd/DbConnection/TableName/ColumnName....

        /// <summary>
        /// �������к�
        /// </summary>
        public string Sn
        {
            get
            {
                return config.GetValue(Key, "Sn", "3SDK-JBX-0130-PHYMT");
            }
            set
            {
                config.SetValue(Key, "Sn", value);
            }
        }

        /// <summary>
        /// �������к� ����
        /// </summary>
        public string SnPwd
        {
            get
            {
                return config.GetValue(Key, "SnPwd", "123456");
            }
            set
            {
                config.SetValue(Key, "SnPwd", value);
            }
        }

        #region ���� ���ݿ����ӣ�����������

        /// <summary>
        /// ���ݿ����ӵ�ַ�����ű��������ݿ⣩
        /// </summary>
        public string DbConnection
        {
            get
            {
                return config.GetValue(Key, "DbConnection", "");
            }
            set
            {
                config.SetValue(Key, "DbConnection", value);
            }
        }

        /// <summary>
        /// ���ű�����
        /// </summary>
        public string TableName
        {
            get
            {
                return config.GetValue(Key, "TableName", "SMSSending");
            }
            set
            {
                config.SetValue(Key, "TableName", value);
            }
        }

        /// <summary>
        /// ���ű�_����
        /// </summary>
        public string ColID
        {
            get
            {
                return config.GetValue(Key, "ColID", "ID");
            }
            set
            {
                config.SetValue(Key, "ColID", value);
            }
        }

        /// <summary>
        /// ���ű�_�����Ƿ�����
        /// </summary>
        public bool ColID_IsIncre
        {
            get
            {
                return config.GetValue(Key, "ColID_IsIncre", true);
            }
            set
            {
                config.SetValue(Key, "ColID_IsIncre", value);
            }
        }

        /// <summary>
        /// ���ű�_�ֻ���
        /// </summary>
        public string ColMobile
        {
            get
            {
                return config.GetValue(Key, "ColMobile", "Mobile");
            }
            set
            {
                config.SetValue(Key, "ColMobile", value);
            }
        }

        /// <summary>
        /// ���ű�_��������
        /// </summary>
        public string ColContent
        {
            get
            {
                return config.GetValue(Key, "ColContent", "SMS_Content");
            }
            set
            {
                config.SetValue(Key, "ColContent", value);
            }
        }

        /// <summary>
        /// ���ű�_���ʱ��
        /// </summary>
        public string ColCreatetime
        {
            get
            {
                return config.GetValue(Key, "ColCreatetime", "Createtime");
            }
            set
            {
                config.SetValue(Key, "ColCreatetime", value);
            }
        }

        /// <summary>
        /// ���ű�_����״̬
        /// </summary>
        public string ColState
        {
            get
            {
                return config.GetValue(Key, "ColState", "SendState");
            }
            set
            {
                config.SetValue(Key, "ColState", value);
            }
        }

        /// <summary>
        /// ���ű�_����״̬����
        /// </summary>
        public string ColStateDesc
        {
            get
            {
                return config.GetValue(Key, "ColStateDesc", "SendStateDesc");
            }
            set
            {
                config.SetValue(Key, "ColStateDesc", value);
            }
        }
        #endregion

        #region ���ŷ���״̬

        /// <summary>
        /// ����״̬ö��ֵ_������
        /// </summary>
        public string StateToSend
        {
            get
            {
                return config.GetValue(Key, "StateToSend", "0");
            }
            set
            {
                config.SetValue(Key, "StateToSend", value);
            }
        }

        /// <summary>
        /// ����״̬ö��ֵ_���ͳɹ�
        /// </summary>
        public string StateSendSuccess
        {
            get
            {
                return config.GetValue(Key, "StateSendSuccess", "1");
            }
            set
            {
                config.SetValue(Key, "StateSendSuccess", value);
            }
        }

        /// <summary>
        /// ����״̬ö��ֵ_����ʧ��
        /// </summary>
        public string StateSendFail
        {
            get
            {
                return config.GetValue(Key, "StateSendFail", "6");
            }
            set
            {
                config.SetValue(Key, "StateSendFail", value);
            }
        }
        #endregion

        #region ����ǩ����Ϣ

        /// <summary>
        /// ����ǩ��_�Ƿ�����
        /// </summary>
        public bool SMSSign_Enable
        {
            get
            {
                return config.GetValue(Key, "SMSSign_Enable", false);
            }
            set
            {
                config.SetValue(Key, "SMSSign_Enable", value);
            }
        }

        /// <summary>
        /// ����ǩ��_ǩ������
        /// </summary>
        public string SMSSign_Content
        {
            get
            {
                return config.GetValue(Key, "SMSSign_Content", "��ǩ�����ݡ�");
            }
            set
            {
                config.SetValue(Key, "SMSSign_Content", value);
            }
        }
        #endregion

        #region ע�ᴰ��������Ϣ
        /// <summary>
        /// ע�ᴰ��������Ϣ_��ҵ(�û�������
        /// </summary>
        public string Register_UserName
        {
            get
            {
                return config.GetValue(Key, "Register_UserName", "");
            }
            set
            {
                config.SetValue(Key, "Register_UserName", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��ϵ������
        /// </summary>
        public string Register_ContactName
        {
            get
            {
                return config.GetValue(Key, "Register_ContactName", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactName", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��ϵ���ֻ�
        /// </summary>
        public string Register_ContactMobile
        {
            get
            {
                return config.GetValue(Key, "Register_ContactMobile", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactMobile", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��ϵ�˵绰
        /// </summary>
        public string Register_ContactPhone
        {
            get
            {
                return config.GetValue(Key, "Register_ContactPhone", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactPhone", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��ϵ�˴���
        /// </summary>
        public string Register_ContactFax
        {
            get
            {
                return config.GetValue(Key, "Register_ContactFax", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactFax", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��ϵ�˵����ʼ�
        /// </summary>
        public string Register_ContactEmail
        {
            get
            {
                return config.GetValue(Key, "Register_ContactEmail", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactEmail", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��������
        /// </summary>
        public string Register_ContactZipcode
        {
            get
            {
                return config.GetValue(Key, "Register_ContactZipcode", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactZipcode", value);
            }
        }

        /// <summary>
        /// ע�ᴰ��������Ϣ_��˾��ַ
        /// </summary>
        public string Register_ContactAddress
        {
            get
            {
                return config.GetValue(Key, "Register_ContactAddress", "");
            }
            set
            {
                config.SetValue(Key, "Register_ContactAddress", value);
            }
        }
        #endregion

        #endregion
    }
}
