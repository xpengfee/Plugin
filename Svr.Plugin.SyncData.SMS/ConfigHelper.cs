using System;
using System.Configuration;
using THS.Config;
using System.IO;
using System.Text;
namespace Svr.Plugin.SyncData.SMS
{
    /// <summary>
    /// ConfigHelper 的摘要说明。
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

        #region 原有属性
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
        /// 是否自动运行
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
        /// 是否显示运行状态
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
        /// 是否仅工作时间同步
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
        /// 是否自动同步出错信息
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

        #region 新增属性 Sn/SnPwd/DbConnection/TableName/ColumnName....

        /// <summary>
        /// 短信序列号
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
        /// 短信序列号 密码
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

        #region 短信 数据库链接，表名、列名

        /// <summary>
        /// 数据库连接地址（短信表所在数据库）
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
        /// 短信表名称
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
        /// 短信表_主键
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
        /// 短信表_主键是否自增
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
        /// 短信表_手机号
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
        /// 短信表_短信内容
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
        /// 短信表_入表时间
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
        /// 短信表_发送状态
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
        /// 短信表_发送状态描述
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

        #region 短信发送状态

        /// <summary>
        /// 发送状态枚举值_待发送
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
        /// 发送状态枚举值_发送成功
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
        /// 发送状态枚举值_发送失败
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

        #region 短信签名信息

        /// <summary>
        /// 短信签名_是否启用
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
        /// 短信签名_签名内容
        /// </summary>
        public string SMSSign_Content
        {
            get
            {
                return config.GetValue(Key, "SMSSign_Content", "【签名内容】");
            }
            set
            {
                config.SetValue(Key, "SMSSign_Content", value);
            }
        }
        #endregion

        #region 注册窗体所用信息
        /// <summary>
        /// 注册窗体所用信息_企业(用户）名称
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
        /// 注册窗体所用信息_联系人姓名
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
        /// 注册窗体所用信息_联系人手机
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
        /// 注册窗体所用信息_联系人电话
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
        /// 注册窗体所用信息_联系人传真
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
        /// 注册窗体所用信息_联系人电子邮件
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
        /// 注册窗体所用信息_邮政编码
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
        /// 注册窗体所用信息_公司地址
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
