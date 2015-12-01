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
    public partial class frmSendSMS : Form
    {
        public frmSendSMS()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMobile.Text) || string.IsNullOrEmpty(tbContent.Text))
            {
                MessageBox.Show("请填写手机号及短信内容");
            }
            else
            {
                string msg = string.Empty;
                try
                {
                    string content = tbContent.Text;
                    if (ConfigHelper.Instance.SMSSign_Enable && (!string.IsNullOrEmpty(ConfigHelper.Instance.SMSSign_Content)))
                    {
                        content = ConfigHelper.Instance.SMSSign_Content + content;
                    }

                    bool result = SMSManagement.Instance.SendTestSMS(ConfigHelper.Instance.DbConnection, ConfigHelper.Instance.TableName,
                        ConfigHelper.Instance.ColMobile, tbMobile.Text, ConfigHelper.Instance.ColContent, content,
                        ConfigHelper.Instance.ColState, ConfigHelper.Instance.StateToSend, out msg);

                    MessageBox.Show(msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发送测试短信失败，原因：" + ex.ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
