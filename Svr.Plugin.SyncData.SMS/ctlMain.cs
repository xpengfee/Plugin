using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace Svr.Plugin.SyncData.SMS
{
    public partial class ctlMain : UserControl
    {
        private ConfigHelper m_config = ConfigHelper.Instance;
        private Boolean bIsNormalBusySync = false;
        private Boolean bIsErrorBusySync = false;
        private static log4net.ILog log = null;
        private List<ErrorMsg> errorMsgList = new List<ErrorMsg>();
        private String cOldSyncServerAddress = null;
        private System.ServiceModel.EndpointAddress eaSyncAddress = null;

        public ctlMain()
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

                InitSyncGapControl();
                LoadConfig();
                CheckSyncServerAddres();
                if (m_config.AutoRun)
                    StartSyncTimer();
            }
            catch (System.Exception ex)
            {
                AddSyncMessage(SyncResultLevel.Error, "模块初始失败！" + ex.Message);
            }
        }
        private void InitSyncGapControl()
        {
            cmbSyncGap.Items.Clear();
            cmbSyncGap.Items.Add(new ComboBoxItem(1, "1分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(2, "2分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(3, "3分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(4, "4分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(5, "5分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(10, "10分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(15, "15分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(30, "30分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(45, "45分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(60, "60分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(90, "90分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(120, "120分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(150, "150分钟"));
            cmbSyncGap.Items.Add(new ComboBoxItem(180, "180分钟"));
        }
        private void CheckSyncServerAddres()
        {
            if ((!String.IsNullOrEmpty(m_config.SyncServerAddress)) || (cOldSyncServerAddress != m_config.SyncServerAddress))
            {
                eaSyncAddress = new System.ServiceModel.EndpointAddress(m_config.SyncServerAddress);
                cOldSyncServerAddress = m_config.SyncServerAddress;
            }
        }
        private void LoadConfig()
        {
            if (!String.IsNullOrEmpty(m_config.SyncServerAddress))
            {
                eaSyncAddress = new System.ServiceModel.EndpointAddress(m_config.SyncServerAddress);
            }
            cbAutoRunWhenLoad.Checked = m_config.AutoRun;
            cbShowRunStatu.Checked = m_config.ShowStatu;
            rbWorkTime.Checked = m_config.OnlyWorkTime;
            dtpWorkTimeStart.Enabled = rbWorkTime.Checked;
            dtpWorkTimeEnd.Enabled = rbWorkTime.Checked;
            dtpWorkTimeStart.Text = m_config.WorkTimeStart;
            dtpWorkTimeEnd.Text = m_config.WorkTimeEnd;
            nudDispNum.Value = m_config.DispNum;
            nudSleepGap.Value = m_config.SleepGap;

            chkSyncError.Checked = m_config.AutoSyncError;
            dtpErrorTimeStart.Enabled = chkSyncError.Checked;
            dtpErrorTimeEnd.Enabled = chkSyncError.Checked;
            dtpErrorTimeStart.Text = m_config.SyncErrorTimeStart;
            dtpErrorTimeEnd.Text = m_config.SyncErrorTimeEnd;

            cmbSyncGap.SelectedIndex = 0;
            for (Int32 iLoop = 0; iLoop < cmbSyncGap.Items.Count; iLoop++)
            {
                if (((ComboBoxItem)cmbSyncGap.Items[iLoop]).Value == m_config.SyncGap)
                {
                    cmbSyncGap.SelectedIndex = iLoop;
                    break;
                }
            }
            timerSync.Interval = m_config.SyncGap * 60 * 1000;

            #region 新增属性--短信配置
            tbDBConnection.Text = m_config.DbConnection;
            tbTableName.Text = m_config.TableName;
            cbIncrement.Checked = m_config.ColID_IsIncre;
            tbColID.Text = m_config.ColID;
            tbColMobile.Text = m_config.ColMobile;
            tbColContent.Text = m_config.ColContent;
            tbColCreatetime.Text = m_config.ColCreatetime;
            tbColState.Text = m_config.ColState;
            tbColStateDesc.Text = m_config.ColStateDesc;

            tbToSend.Text = m_config.StateToSend;
            tbSendSuccess.Text = m_config.StateSendSuccess;
            tbSendFail.Text = m_config.StateSendFail;

            cbSign.Checked = m_config.SMSSign_Enable;
            tbSign.Text = m_config.SMSSign_Content;
            #endregion
        }

        private void SaveConfig()
        {
            DateTime dtWorkTimeStart = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + dtpWorkTimeStart.Text);
            DateTime dtWorkTimeEnd = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + dtpWorkTimeEnd.Text);

            DateTime dtSyncErrorTimeStart = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + dtpErrorTimeStart.Text);
            DateTime dtSyncErrorTimeEnd = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + dtpErrorTimeEnd.Text);

            if (dtWorkTimeStart > dtWorkTimeEnd)
            {
                MessageBox.Show("自动同步的开始时间不能大于结束时间");
                return;
            }

            if (dtSyncErrorTimeStart > dtSyncErrorTimeEnd)
            {
                MessageBox.Show("自动同步出错信息的开始时间不能大于结束时间");
                return;
            }

            m_config.AutoRun = cbAutoRunWhenLoad.Checked;
            m_config.ShowStatu = cbShowRunStatu.Checked;
            m_config.OnlyWorkTime = rbWorkTime.Checked;
            m_config.WorkTimeStart = dtpWorkTimeStart.Text;
            m_config.WorkTimeEnd = dtpWorkTimeEnd.Text;
            m_config.DispNum = Int32.Parse(nudDispNum.Value.ToString());
            m_config.SleepGap = Int32.Parse(nudSleepGap.Value.ToString());
            ComboBoxItem cbItem = (ComboBoxItem)cmbSyncGap.SelectedItem;
            m_config.SyncGap = cbItem.Value;
            m_config.AutoSyncError = chkSyncError.Checked;
            m_config.SyncErrorTimeStart = dtpErrorTimeStart.Text;
            m_config.SyncErrorTimeEnd = dtpErrorTimeEnd.Text;
            timerSync.Interval = m_config.SyncGap * 60 * 1000;

            #region 新增属性--短信配置
            m_config.DbConnection = tbDBConnection.Text;
            m_config.TableName = tbTableName.Text;
            m_config.ColID_IsIncre = cbIncrement.Checked;
            m_config.ColID = tbColID.Text;
            m_config.ColMobile = tbColMobile.Text;
            m_config.ColContent = tbColContent.Text;
            m_config.ColCreatetime = tbColCreatetime.Text;
            m_config.ColState = tbColState.Text;
            m_config.ColStateDesc = tbColStateDesc.Text;

            m_config.StateToSend = tbToSend.Text;
            m_config.StateSendSuccess = tbSendSuccess.Text;
            m_config.StateSendFail = tbSendFail.Text;

            m_config.SMSSign_Enable = cbSign.Checked;
            m_config.SMSSign_Content = tbSign.Text;
            #endregion

        }

        private void rbAllTime_CheckedChanged(object sender, EventArgs e)
        {
            rbWorkTime.Checked = !rbAllTime.Checked;
            dtpWorkTimeStart.Enabled = rbWorkTime.Checked;
            dtpWorkTimeEnd.Enabled = rbWorkTime.Checked;
        }

        private void rbWorkTime_CheckedChanged(object sender, EventArgs e)
        {
            rbAllTime.Checked = !rbWorkTime.Checked;
            dtpWorkTimeStart.Enabled = rbWorkTime.Checked;
            dtpWorkTimeEnd.Enabled = rbWorkTime.Checked;
        }

        private void chkSyncError_CheckedChanged(object sender, EventArgs e)
        {
            dtpErrorTimeStart.Enabled = chkSyncError.Checked;
            dtpErrorTimeEnd.Enabled = chkSyncError.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        #region lvSyncMessage 控件
        public enum SyncResultLevel { Informaintion, Warning, Error };
        private void AddSyncMessage(SyncResultLevel olItem, String cRunMessage)
        {
            if (!m_config.ShowStatu)
                return;
            ListViewItem lviItem = new ListViewItem(
                new string[] { "", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), cRunMessage },
                0);
            lviItem.ImageIndex = (int)olItem;
            switch (olItem)
            {
                case SyncResultLevel.Error:
                    if (log.IsErrorEnabled) log.Error(cRunMessage);
                    break;
                case SyncResultLevel.Informaintion:
                    if (log.IsInfoEnabled) log.Info(cRunMessage);
                    break;
                case SyncResultLevel.Warning:
                    if (log.IsWarnEnabled) log.Warn(cRunMessage);
                    break;
            }

            lock (lvSyncMessage)
            {
                if (this.InvokeRequired)
                {
                    object[] args = { 0, lviItem };
                    lvSyncMessage.BeginInvoke(new SetSyncMessageValueEventHandler(SetSyncMessageValue), args);
                }
                else
                {
                    SetSyncMessageValue(0, lviItem);
                }
            }

        }
        public delegate void SetSyncMessageValueEventHandler(int index, ListViewItem lviItem);

        public void SetSyncMessageValue(int index, ListViewItem lviItem)
        {
            if (lvSyncMessage.Items.Count > m_config.DispNum)
                lvSyncMessage.Items.RemoveAt(m_config.DispNum);
            lvSyncMessage.Items.Insert(index, lviItem);
        }
        #endregion

        private void timerSync_Tick(object sender, EventArgs e)
        {
            CheckSyncServerAddres();
            SendSms();
        }


        #region 访问短信发送接口进行短信发送

        /// <summary>
        /// 线程方式 调用短信发送接口发送短信
        /// </summary>
        private void SendSmsThread()
        {
            String cSendMessage = "";
            Boolean bSend = false;
            bIsNormalBusySync = true;

            List<SMSSendResult> listSendResult = new List<SMSSendResult>();
            try
            {
                //1.获取待发送短信
                DataTable dtToSendSMS = SMSManagement.Instance.GetToSendSMS(m_config.DbConnection, m_config.TableName,
                    m_config.ColID, m_config.ColMobile, m_config.ColContent, m_config.ColState, m_config.StateToSend);
                if ((dtToSendSMS != null) && (dtToSendSMS.Rows.Count > 0))
                {
                    foreach (DataRow drSMS in dtToSendSMS.Rows)
                    {
                        //2.调用发送接口发送短信
                        int sendState = EmayHelper2.Instance.SvrSendSMS(out cSendMessage, m_config.Sn,ConfigHelper.Instance.SnPwd, drSMS[m_config.ColMobile].ToString(), drSMS[m_config.ColContent].ToString());
                        bSend = sendState == 0 ? true : false;

                        string reSendState = sendState == 0 ? m_config.StateSendSuccess : m_config.StateSendFail;

                        AddSyncMessage(bSend ? SyncResultLevel.Informaintion : SyncResultLevel.Error, cSendMessage);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(m_config.SleepGap);

                        listSendResult.Add(new SMSSendResult(drSMS[m_config.ColID].ToString(), reSendState, cSendMessage));
                    }
                }
                else
                {
                    AddSyncMessage(SyncResultLevel.Informaintion, "没有待发送的短信");
                }
                if (dtToSendSMS != null)
                    dtToSendSMS.Dispose();

                //3.同步发送结果
                if (listSendResult != null && listSendResult.Count > 0)
                {
                    string saveMsg = string.Empty;
                    SMSManagement.Instance.SaveSMSResult(m_config.DbConnection, m_config.TableName, m_config.ColID,
                        m_config.ColState, m_config.ColStateDesc, listSendResult, out saveMsg);
                }
            }
            catch (Exception ex)
            {
                bSend = false;
                cSendMessage = ex.Message;
                AddSyncMessage(SyncResultLevel.Error, cSendMessage);
            }
            //当前活动的 TAB 不为 错误页，则刷新错误列表
            if (tcMain.SelectedTab != tpErrorInfo)
            {
                ReloadSendErrorSMS(false);
            }
            bIsNormalBusySync = false;
        }

        private void SendSms()
        {
            //仅在工作时间同步时，判断当前是否在工作时间
            if (m_config.OnlyWorkTime)
            {
                DateTime dtWorkTimeStart = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + m_config.WorkTimeStart);
                DateTime dtWorkTimeEnd = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + m_config.WorkTimeEnd);
                //结束时间大于开始时间
                if ((System.DateTime.Compare(System.DateTime.Now, dtWorkTimeStart) < 0) || (System.DateTime.Compare(System.DateTime.Now, dtWorkTimeEnd) > 0))
                    return;
            }
            if (bIsNormalBusySync)
                return;
            //使用线程开始进行同步
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(SendSmsThread));
            thread.Start();

        }
        #endregion

        //#region 访问短信发送接口重新发送出错短信
        //private void SendErrorSMSThread()
        //{
        //    String cSendMessage = "";
        //    Boolean bSend = false;
        //    bIsErrorBusySync = true;
        //    List<SMSSendResult> listSendResult = new List<SMSSendResult>();

        //    try
        //    {
        //        //1.获取待发送短信
        //        DataTable dtToSendSMS = SMSManagement.Instance.GetToSendSMS(m_config.DbConnection, m_config.TableName,
        //            m_config.ColID, m_config.ColMobile, m_config.ColContent, m_config.ColState, m_config.StateSendFail);
        //        if ((dtToSendSMS != null) && (dtToSendSMS.Rows.Count > 0))
        //        {
        //            foreach (DataRow drSMS in dtToSendSMS.Rows)
        //            {
        //                //2.调用发送接口发送短信
        //                int sendState = EmayHelper2.Instance.SvrSendSMS(out cSendMessage, m_config.Sn, drSMS[m_config.ColMobile].ToString(), drSMS[m_config.ColContent].ToString());
        //                bSend = sendState == 1 ? true : false;

        //                string reSendState = sendState == 1 ? m_config.StateSendSuccess : m_config.StateSendFail;

        //                AddSyncMessage(bSend ? SyncResultLevel.Informaintion : SyncResultLevel.Error, cSendMessage);
        //                Application.DoEvents();
        //                System.Threading.Thread.Sleep(m_config.SleepGap);

        //                listSendResult.Add(new SMSSendResult(drSMS[m_config.ColID].ToString(), reSendState, cSendMessage));
        //            }
        //        }
        //        else
        //        {
        //            AddSyncMessage(SyncResultLevel.Informaintion, "没有待发送的短信");
        //        }
        //        if (dtToSendSMS != null)
        //            dtToSendSMS.Dispose();

        //        //3.同步发送结果
        //        if (listSendResult != null && listSendResult.Count > 0)
        //        {
        //            string saveMsg = string.Empty;
        //            SMSManagement.Instance.SaveSMSResult(m_config.DbConnection, m_config.TableName, m_config.ColID,
        //                m_config.ColState, m_config.ColStateDesc, listSendResult, out saveMsg);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        bSend = false;
        //        cSendMessage = ex.Message;
        //        AddSyncMessage(SyncResultLevel.Error, cSendMessage);
        //    }
        //    //当前活动的 TAB 不为 错误页，则刷新错误列表
        //    if (tcMain.SelectedTab != tpErrorInfo)
        //    {
        //        ReloadSendErrorSMS(false);
        //    }
        //    bIsErrorBusySync = false;
        //}
        
        //private void SendErrorSMS()
        //{
        //    if (!m_config.AutoSyncError)
        //        return;
        //    DateTime dtSyncErrorTimeStart = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + m_config.SyncErrorTimeStart);
        //    DateTime dtSyncErrorTimeEnd = DateTime.Parse(System.DateTime.Now.ToString("yyyy-MM-dd") + " " + m_config.SyncErrorTimeEnd);
        //    //结束时间大于开始时间
        //    if ((System.DateTime.Compare(System.DateTime.Now, dtSyncErrorTimeStart) < 0) || (System.DateTime.Compare(System.DateTime.Now, dtSyncErrorTimeEnd) > 0))
        //        return;
        //    if (bIsErrorBusySync)
        //        return;
        //    //使用线程开始进行同步
        //    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(SendErrorSMSThread));
        //    thread.Start();
        //}
        //#endregion

        public void StartSyncTimer()
        {
            CheckSyncServerAddres();
            timerSync.Interval = m_config.SyncGap * 60 * 1000;
            timerSync.Enabled = true;
            tbStartSync.ImageIndex = 1;
            tbRun.Refresh();
            SendSms();
        }
        public void StopSyncTimer()
        {
            timerSync.Enabled = false;
            tbStartSync.ImageIndex = 0;
            tbRun.Refresh();
        }

        private void tbRun_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == tbStartSync)
            {
                if (!timerSync.Enabled)
                {
                    StartSyncTimer();
                }
                else
                {
                    StopSyncTimer();
                }
            }
            if (e.Button == tbClearMessage)
            {
                lvSyncMessage.Items.Clear();
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SendSms();
        }

        /// <summary>
        /// 加载发送失败的短信
        /// </summary>
        /// <param name="bShowNoResultMsg"></param>
        private void ReloadSendErrorSMS(Boolean bShowNoResultMsg)
        {
            lvErrorList.Items.Clear();
            tbSelectAll.ImageIndex = 3;
            try
            {
                //1.获取发送失败的短信
                DataTable dtSendError = SMSManagement.Instance.GetToSendSMS(m_config.DbConnection, m_config.TableName,
                    m_config.ColID, m_config.ColMobile, m_config.ColContent, m_config.ColState, m_config.StateSendFail);
                if ((dtSendError != null) && (dtSendError.Rows.Count > 0))
                {
                    foreach (DataRow drSync in dtSendError.Rows)
                    {
                        ListViewItem lviItem = new ListViewItem(new String[] { "", drSync[m_config.ColID].ToString(), 
                            drSync[m_config.ColMobile].ToString(), drSync[m_config.ColContent].ToString() });
                        lvErrorList.Items.Add(lviItem);
                    }
                }
                else
                {
                    if (bShowNoResultMsg)
                        MessageBox.Show("不存在发送失败的的短信信息");
                }
                dtSendError.Dispose();
            }
            catch
            {
            }
        }

        private void SwitchErrorListCheckStatus()
        {
            if (tbSelectAll.ImageIndex == 3)
            {
                foreach (ListViewItem lviItem in lvErrorList.Items)
                {
                    lviItem.Checked = true;
                }
                tbSelectAll.ImageIndex = 4;
            }
            else
            {
                foreach (ListViewItem lviItem in lvErrorList.Items)
                {
                    lviItem.Checked = false;
                }
                tbSelectAll.ImageIndex = 3;
            }
        }

        private void SendErrorMsgThread()
        {
            String cSendMessage = "";
            Boolean bReturnValue = false;
            bIsErrorBusySync = true;

            List<SMSSendResult> listSendResult = new List<SMSSendResult>();
            try
            {
                //重新发送错误短信
                if (errorMsgList != null && errorMsgList.Count > 0)
                {
                    foreach (ErrorMsg msg in errorMsgList)
                    {
                        //1.调用发送接口发送短信
                        int sendState = EmayHelper2.Instance.SvrSendSMS(out cSendMessage, m_config.Sn, ConfigHelper.Instance.SnPwd,msg.Mobile, msg.Content);
                        bReturnValue = sendState == 0 ? true : false;

                        string reSendState = sendState == 0 ? m_config.StateSendSuccess : m_config.StateSendFail;

                        AddSyncMessage(bReturnValue ? SyncResultLevel.Informaintion : SyncResultLevel.Error, cSendMessage);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(m_config.SleepGap);

                        listSendResult.Add(new SMSSendResult(msg.ID, reSendState, cSendMessage));
                    }
                }
                else
                {
                    AddSyncMessage(SyncResultLevel.Informaintion, "没有待发送的短信");
                }

                //2.同步发送结果
                if (listSendResult != null && listSendResult.Count > 0)
                {
                    string saveMsg = string.Empty;
                    SMSManagement.Instance.SaveSMSResult(m_config.DbConnection, m_config.TableName, m_config.ColID,
                        m_config.ColState, m_config.ColStateDesc, listSendResult, out saveMsg);
                }
            }
            catch (Exception ex)
            {
                bReturnValue = false;
                cSendMessage = ex.Message;
                AddSyncMessage(SyncResultLevel.Error, cSendMessage);
            }
            //同步错误列表后重新刷新
            ReloadSendErrorSMS(false);
            bIsErrorBusySync = false;
        }

        private void SendErrorMsg()
        {
            errorMsgList.Clear();
            foreach (ListViewItem lviItem in lvErrorList.Items)
            {
                if (lviItem.Checked)
                {
                    ErrorMsg msg = new ErrorMsg();
                    msg.ID = lviItem.SubItems[1].Text;
                    msg.Mobile = lviItem.SubItems[2].Text;
                    msg.Content = lviItem.SubItems[3].Text;

                    errorMsgList.Add(msg);
                }
            }

            if (errorMsgList.Count > 0)
            {
                if (bIsErrorBusySync)
                    return;
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(SendErrorMsgThread));
                thread.Start();
            }
            else
            {
                MessageBox.Show("尚未选择任何待同步的短信");
                return;
            }
        }

        private void tbError_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            //刷新同步错误的数据
            CheckSyncServerAddres();
            if (e.Button == tbRefreash)
            {
                ReloadSendErrorSMS(true);
            }
            if (e.Button == tbSelectAll)
            {
                SwitchErrorListCheckStatus();
            }
            if (e.Button == tbErrorSync)
            {
                SendErrorMsg();
            }
        }

        #region 短信发送设置
        //注册
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmSMSRegister frm = new frmSMSRegister();
            frm.ShowDialog();
        }

        //注销
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            Cursor.Current = Cursors.WaitCursor;
            bool result = EmayHelper2.Instance.SvrUnRegister(out msg, m_config.Sn, ConfigHelper.Instance.SnPwd);
            Cursor.Current = Cursors.Default;

            if (result)
                MessageBox.Show("已成功注销短信序列号");
            else
                MessageBox.Show("注销失败，原因：" + msg);
        }

        //充值
        private void btnRecharge_Click(object sender, EventArgs e)
        {
            frmChargeUp frm = new frmChargeUp();
            frm.ShowDialog();
        }

        //查询余额
        private void btnQueryBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的余额为：" + EmayHelper2.Instance.SvrGetBalance(m_config.Sn, ConfigHelper.Instance.SnPwd));
        }
        #endregion

        private void btnSMSSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        //发送测试短信
        private void btnSendTest_Click(object sender, EventArgs e)
        {
            if (m_config.ColID_IsIncre)
            {
                frmSendSMS frm = new frmSendSMS();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("测试短信发送失败，原因：测试短信只针对主键自增长的表结构");
            }
        }

    }
}
