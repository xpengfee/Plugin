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
    public partial class frmChargeUp : Form
    {
        public frmChargeUp()
        {
            InitializeComponent();
        }

        private void btnChargeUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfigHelper.Instance.Sn))
            {
                MessageBox.Show("请注册后在进行充值");
            }
            else
            {
                string msg = string.Empty;
                bool result = EmayHelper2.Instance.SvrCharge(out msg, ConfigHelper.Instance.Sn, ConfigHelper.Instance.SnPwd,tbCardNo.Text, tbPwd.Text);

                MessageBox.Show(msg);
                if (result)
                    this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
