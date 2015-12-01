using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Svr.Plugin.SyncData.SMS
{
    public partial class frmSMSRegister : Form
    {
        private ConfigHelper m_config = ConfigHelper.Instance;
        private static log4net.ILog log = null;

        public frmSMSRegister()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            try
            {
                if (log == null)
                    log = log4net.LogManager.GetLogger(ConfigHelper.Instance.Key);

                LoadConfig();
            }
            catch (System.Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void LoadConfig()
        {
            tbSerialNo.Text = m_config.Sn;
            tbSerialPwd.Text = "";//密码不显示

            tbUserName.Text = m_config.Register_UserName;
            tbContactName.Text = m_config.Register_ContactName;
            tbContactMobile.Text = m_config.Register_ContactMobile;
            tbContactPhone.Text = m_config.Register_ContactPhone;
            tbContactFax.Text = m_config.Register_ContactFax;
            tbContactEmail.Text = m_config.Register_ContactEmail;
            tbContactZipcode.Text = m_config.Register_ContactZipcode;
            tbContactAddress.Text = m_config.Register_ContactAddress;
        }

        private void SaveConfig()
        {
            m_config.Sn = tbSerialNo.Text;
            m_config.SnPwd = tbSerialPwd.Text;

            m_config.Register_UserName = tbUserName.Text;
            m_config.Register_ContactName = tbContactName.Text;
            m_config.Register_ContactMobile = tbContactMobile.Text;
            m_config.Register_ContactPhone = tbContactPhone.Text;
            m_config.Register_ContactFax = tbContactFax.Text;
            m_config.Register_ContactEmail = tbContactEmail.Text;
            m_config.Register_ContactZipcode = tbContactZipcode.Text;
            m_config.Register_ContactAddress = tbContactAddress.Text;
        }

        //注册
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string msg=string.Empty;
            bool result=EmayHelper2.Instance.SvrRegister(out msg, tbSerialNo.Text, tbSerialPwd.Text, tbUserName.Text, tbContactName.Text,
                tbContactMobile.Text, tbContactPhone.Text, tbContactEmail.Text, tbContactFax.Text, tbContactAddress.Text, tbContactZipcode.Text);
            if (result)
            {
                SaveConfig();
                MessageBox.Show(msg);
                this.Close();
            }
            else
            {
                MessageBox.Show(msg);
            }

        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
