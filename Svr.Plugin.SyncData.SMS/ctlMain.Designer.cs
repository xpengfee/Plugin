namespace Svr.Plugin.SyncData.SMS
{
    partial class ctlMain
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpRunInfo = new System.Windows.Forms.TabPage();
            this.lvSyncMessage = new System.Windows.Forms.ListView();
            this.colImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvImageList = new System.Windows.Forms.ImageList(this.components);
            this.tbRun = new System.Windows.Forms.ToolBar();
            this.tbStartSync = new System.Windows.Forms.ToolBarButton();
            this.tbClearMessage = new System.Windows.Forms.ToolBarButton();
            this.tbImageList = new System.Windows.Forms.ImageList(this.components);
            this.tpErrorInfo = new System.Windows.Forms.TabPage();
            this.lvErrorList = new System.Windows.Forms.ListView();
            this.colCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBikeBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUpMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbError = new System.Windows.Forms.ToolBar();
            this.tbRefreash = new System.Windows.Forms.ToolBarButton();
            this.tbSelectAll = new System.Windows.Forms.ToolBarButton();
            this.tbErrorSync = new System.Windows.Forms.ToolBarButton();
            this.tpSet = new System.Windows.Forms.TabPage();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRunOption = new System.Windows.Forms.GroupBox();
            this.lblSleepGap = new System.Windows.Forms.Label();
            this.nudSleepGap = new System.Windows.Forms.NumericUpDown();
            this.lblSyncErrorEnd = new System.Windows.Forms.Label();
            this.dtpErrorTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpErrorTimeStart = new System.Windows.Forms.DateTimePicker();
            this.chkSyncError = new System.Windows.Forms.CheckBox();
            this.lblSyncErrorStart = new System.Windows.Forms.Label();
            this.rbWorkTime = new System.Windows.Forms.RadioButton();
            this.rbAllTime = new System.Windows.Forms.RadioButton();
            this.cmbSyncGap = new System.Windows.Forms.ComboBox();
            this.lblSyncGap = new System.Windows.Forms.Label();
            this.dtpWorkTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.nudDispNum = new System.Windows.Forms.NumericUpDown();
            this.lblWorkTimeEnd = new System.Windows.Forms.Label();
            this.lblDispRow = new System.Windows.Forms.Label();
            this.dtpWorkTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lblWorkTimeStart = new System.Windows.Forms.Label();
            this.gbStartOption = new System.Windows.Forms.GroupBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.cbShowRunStatu = new System.Windows.Forms.CheckBox();
            this.cbAutoRunWhenLoad = new System.Windows.Forms.CheckBox();
            this.tbSMSSetting = new System.Windows.Forms.TabPage();
            this.btnSendTest = new System.Windows.Forms.Button();
            this.btnSMSSave = new System.Windows.Forms.Button();
            this.gbSMSSoftware = new System.Windows.Forms.GroupBox();
            this.btnQueryBalance = new System.Windows.Forms.Button();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbSign = new System.Windows.Forms.GroupBox();
            this.cbSign = new System.Windows.Forms.CheckBox();
            this.tbSign = new System.Windows.Forms.TextBox();
            this.lblSign = new System.Windows.Forms.Label();
            this.gbState = new System.Windows.Forms.GroupBox();
            this.tbSendFail = new System.Windows.Forms.TextBox();
            this.lblSendFail = new System.Windows.Forms.Label();
            this.tbSendSuccess = new System.Windows.Forms.TextBox();
            this.lblSendSuccess = new System.Windows.Forms.Label();
            this.tbToSend = new System.Windows.Forms.TextBox();
            this.lblToSend = new System.Windows.Forms.Label();
            this.gbDB = new System.Windows.Forms.GroupBox();
            this.tbColStateDesc = new System.Windows.Forms.TextBox();
            this.lblColStateDesc = new System.Windows.Forms.Label();
            this.tbColState = new System.Windows.Forms.TextBox();
            this.lblColState = new System.Windows.Forms.Label();
            this.tbColCreatetime = new System.Windows.Forms.TextBox();
            this.lblColCreatetime = new System.Windows.Forms.Label();
            this.tbColContent = new System.Windows.Forms.TextBox();
            this.lblColContent = new System.Windows.Forms.Label();
            this.tbColMobile = new System.Windows.Forms.TextBox();
            this.lblColMobile = new System.Windows.Forms.Label();
            this.tbColID = new System.Windows.Forms.TextBox();
            this.lblColID = new System.Windows.Forms.Label();
            this.cbIncrement = new System.Windows.Forms.CheckBox();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.tbDBConnection = new System.Windows.Forms.TextBox();
            this.lblDBConnection = new System.Windows.Forms.Label();
            this.timerSync = new System.Windows.Forms.Timer(this.components);
            this.tcMain.SuspendLayout();
            this.tpRunInfo.SuspendLayout();
            this.tpErrorInfo.SuspendLayout();
            this.tpSet.SuspendLayout();
            this.gbRunOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDispNum)).BeginInit();
            this.gbStartOption.SuspendLayout();
            this.tbSMSSetting.SuspendLayout();
            this.gbSMSSoftware.SuspendLayout();
            this.gbSign.SuspendLayout();
            this.gbState.SuspendLayout();
            this.gbDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpRunInfo);
            this.tcMain.Controls.Add(this.tpErrorInfo);
            this.tcMain.Controls.Add(this.tpSet);
            this.tcMain.Controls.Add(this.tbSMSSetting);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(607, 440);
            this.tcMain.TabIndex = 0;
            // 
            // tpRunInfo
            // 
            this.tpRunInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tpRunInfo.Controls.Add(this.lvSyncMessage);
            this.tpRunInfo.Controls.Add(this.tbRun);
            this.tpRunInfo.Location = new System.Drawing.Point(4, 22);
            this.tpRunInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tpRunInfo.Name = "tpRunInfo";
            this.tpRunInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpRunInfo.Size = new System.Drawing.Size(599, 414);
            this.tpRunInfo.TabIndex = 0;
            this.tpRunInfo.Text = "同步结果";
            // 
            // lvSyncMessage
            // 
            this.lvSyncMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImg,
            this.colTime,
            this.colContent});
            this.lvSyncMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvSyncMessage.FullRowSelect = true;
            this.lvSyncMessage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSyncMessage.Location = new System.Drawing.Point(3, 43);
            this.lvSyncMessage.Name = "lvSyncMessage";
            this.lvSyncMessage.Size = new System.Drawing.Size(593, 368);
            this.lvSyncMessage.SmallImageList = this.lvImageList;
            this.lvSyncMessage.TabIndex = 3;
            this.lvSyncMessage.UseCompatibleStateImageBehavior = false;
            this.lvSyncMessage.View = System.Windows.Forms.View.Details;
            // 
            // colImg
            // 
            this.colImg.Text = "";
            this.colImg.Width = 29;
            // 
            // colTime
            // 
            this.colTime.Text = "时间";
            this.colTime.Width = 140;
            // 
            // colContent
            // 
            this.colContent.Text = "内容";
            this.colContent.Width = 400;
            // 
            // lvImageList
            // 
            this.lvImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lvImageList.ImageStream")));
            this.lvImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.lvImageList.Images.SetKeyName(0, "");
            this.lvImageList.Images.SetKeyName(1, "");
            this.lvImageList.Images.SetKeyName(2, "");
            // 
            // tbRun
            // 
            this.tbRun.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbRun.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbStartSync,
            this.tbClearMessage});
            this.tbRun.DropDownArrows = true;
            this.tbRun.ImageList = this.tbImageList;
            this.tbRun.Location = new System.Drawing.Point(3, 3);
            this.tbRun.Name = "tbRun";
            this.tbRun.ShowToolTips = true;
            this.tbRun.Size = new System.Drawing.Size(593, 44);
            this.tbRun.TabIndex = 1;
            this.tbRun.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbRun_ButtonClick);
            // 
            // tbStartSync
            // 
            this.tbStartSync.ImageIndex = 0;
            this.tbStartSync.Name = "tbStartSync";
            // 
            // tbClearMessage
            // 
            this.tbClearMessage.ImageIndex = 2;
            this.tbClearMessage.Name = "tbClearMessage";
            // 
            // tbImageList
            // 
            this.tbImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tbImageList.ImageStream")));
            this.tbImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tbImageList.Images.SetKeyName(0, "");
            this.tbImageList.Images.SetKeyName(1, "");
            this.tbImageList.Images.SetKeyName(2, "");
            this.tbImageList.Images.SetKeyName(3, "CheckAll.png");
            this.tbImageList.Images.SetKeyName(4, "UnCheckAll.png");
            this.tbImageList.Images.SetKeyName(5, "Refeash.png");
            // 
            // tpErrorInfo
            // 
            this.tpErrorInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tpErrorInfo.Controls.Add(this.lvErrorList);
            this.tpErrorInfo.Controls.Add(this.tbError);
            this.tpErrorInfo.Location = new System.Drawing.Point(4, 22);
            this.tpErrorInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tpErrorInfo.Name = "tpErrorInfo";
            this.tpErrorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpErrorInfo.Size = new System.Drawing.Size(599, 414);
            this.tpErrorInfo.TabIndex = 2;
            this.tpErrorInfo.Text = "错误列表";
            // 
            // lvErrorList
            // 
            this.lvErrorList.CheckBoxes = true;
            this.lvErrorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCheckBox,
            this.colOrderCode,
            this.colBikeBarcode,
            this.colUpMessage});
            this.lvErrorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvErrorList.FullRowSelect = true;
            this.lvErrorList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvErrorList.Location = new System.Drawing.Point(3, 43);
            this.lvErrorList.Name = "lvErrorList";
            this.lvErrorList.Size = new System.Drawing.Size(593, 368);
            this.lvErrorList.TabIndex = 4;
            this.lvErrorList.UseCompatibleStateImageBehavior = false;
            this.lvErrorList.View = System.Windows.Forms.View.Details;
            // 
            // colCheckBox
            // 
            this.colCheckBox.Text = "";
            this.colCheckBox.Width = 29;
            // 
            // colOrderCode
            // 
            this.colOrderCode.Text = "ID编号";
            this.colOrderCode.Width = 100;
            // 
            // colBikeBarcode
            // 
            this.colBikeBarcode.Text = "手机号";
            this.colBikeBarcode.Width = 100;
            // 
            // colUpMessage
            // 
            this.colUpMessage.Text = "内容";
            this.colUpMessage.Width = 350;
            // 
            // tbError
            // 
            this.tbError.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbError.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbRefreash,
            this.tbSelectAll,
            this.tbErrorSync});
            this.tbError.DropDownArrows = true;
            this.tbError.ImageList = this.tbImageList;
            this.tbError.Location = new System.Drawing.Point(3, 3);
            this.tbError.Name = "tbError";
            this.tbError.ShowToolTips = true;
            this.tbError.Size = new System.Drawing.Size(593, 44);
            this.tbError.TabIndex = 2;
            this.tbError.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbError_ButtonClick);
            // 
            // tbRefreash
            // 
            this.tbRefreash.ImageIndex = 5;
            this.tbRefreash.Name = "tbRefreash";
            // 
            // tbSelectAll
            // 
            this.tbSelectAll.ImageIndex = 3;
            this.tbSelectAll.Name = "tbSelectAll";
            // 
            // tbErrorSync
            // 
            this.tbErrorSync.ImageIndex = 0;
            this.tbErrorSync.Name = "tbErrorSync";
            // 
            // tpSet
            // 
            this.tpSet.BackColor = System.Drawing.SystemColors.Control;
            this.tpSet.Controls.Add(this.btnCancle);
            this.tpSet.Controls.Add(this.btnSave);
            this.tpSet.Controls.Add(this.gbRunOption);
            this.tpSet.Controls.Add(this.gbStartOption);
            this.tpSet.Location = new System.Drawing.Point(4, 22);
            this.tpSet.Margin = new System.Windows.Forms.Padding(0);
            this.tpSet.Name = "tpSet";
            this.tpSet.Padding = new System.Windows.Forms.Padding(3);
            this.tpSet.Size = new System.Drawing.Size(599, 414);
            this.tpSet.TabIndex = 1;
            this.tpSet.Text = "系统配置";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(319, 264);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取 消";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(199, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保 存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRunOption
            // 
            this.gbRunOption.Controls.Add(this.lblSleepGap);
            this.gbRunOption.Controls.Add(this.nudSleepGap);
            this.gbRunOption.Controls.Add(this.lblSyncErrorEnd);
            this.gbRunOption.Controls.Add(this.dtpErrorTimeEnd);
            this.gbRunOption.Controls.Add(this.dtpErrorTimeStart);
            this.gbRunOption.Controls.Add(this.chkSyncError);
            this.gbRunOption.Controls.Add(this.lblSyncErrorStart);
            this.gbRunOption.Controls.Add(this.rbWorkTime);
            this.gbRunOption.Controls.Add(this.rbAllTime);
            this.gbRunOption.Controls.Add(this.cmbSyncGap);
            this.gbRunOption.Controls.Add(this.lblSyncGap);
            this.gbRunOption.Controls.Add(this.dtpWorkTimeEnd);
            this.gbRunOption.Controls.Add(this.nudDispNum);
            this.gbRunOption.Controls.Add(this.lblWorkTimeEnd);
            this.gbRunOption.Controls.Add(this.lblDispRow);
            this.gbRunOption.Controls.Add(this.dtpWorkTimeStart);
            this.gbRunOption.Controls.Add(this.lblWorkTimeStart);
            this.gbRunOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbRunOption.Location = new System.Drawing.Point(19, 77);
            this.gbRunOption.Name = "gbRunOption";
            this.gbRunOption.Size = new System.Drawing.Size(544, 173);
            this.gbRunOption.TabIndex = 2;
            this.gbRunOption.TabStop = false;
            this.gbRunOption.Text = "同步选项 ";
            // 
            // lblSleepGap
            // 
            this.lblSleepGap.AutoSize = true;
            this.lblSleepGap.Location = new System.Drawing.Point(229, 57);
            this.lblSleepGap.Name = "lblSleepGap";
            this.lblSleepGap.Size = new System.Drawing.Size(65, 12);
            this.lblSleepGap.TabIndex = 32;
            this.lblSleepGap.Text = "同步等待：";
            this.lblSleepGap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudSleepGap
            // 
            this.nudSleepGap.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSleepGap.Location = new System.Drawing.Point(300, 53);
            this.nudSleepGap.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSleepGap.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSleepGap.Name = "nudSleepGap";
            this.nudSleepGap.Size = new System.Drawing.Size(80, 21);
            this.nudSleepGap.TabIndex = 31;
            this.nudSleepGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSleepGap.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblSyncErrorEnd
            // 
            this.lblSyncErrorEnd.AutoSize = true;
            this.lblSyncErrorEnd.Location = new System.Drawing.Point(277, 146);
            this.lblSyncErrorEnd.Name = "lblSyncErrorEnd";
            this.lblSyncErrorEnd.Size = new System.Drawing.Size(17, 12);
            this.lblSyncErrorEnd.TabIndex = 23;
            this.lblSyncErrorEnd.Text = "至";
            this.lblSyncErrorEnd.Visible = false;
            // 
            // dtpErrorTimeEnd
            // 
            this.dtpErrorTimeEnd.CustomFormat = "HH:mm";
            this.dtpErrorTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpErrorTimeEnd.Location = new System.Drawing.Point(300, 142);
            this.dtpErrorTimeEnd.Name = "dtpErrorTimeEnd";
            this.dtpErrorTimeEnd.ShowUpDown = true;
            this.dtpErrorTimeEnd.Size = new System.Drawing.Size(80, 21);
            this.dtpErrorTimeEnd.TabIndex = 22;
            this.dtpErrorTimeEnd.Visible = false;
            // 
            // dtpErrorTimeStart
            // 
            this.dtpErrorTimeStart.CustomFormat = "HH:mm";
            this.dtpErrorTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpErrorTimeStart.Location = new System.Drawing.Point(184, 142);
            this.dtpErrorTimeStart.Name = "dtpErrorTimeStart";
            this.dtpErrorTimeStart.ShowUpDown = true;
            this.dtpErrorTimeStart.Size = new System.Drawing.Size(80, 21);
            this.dtpErrorTimeStart.TabIndex = 21;
            this.dtpErrorTimeStart.Visible = false;
            // 
            // chkSyncError
            // 
            this.chkSyncError.AutoSize = true;
            this.chkSyncError.Location = new System.Drawing.Point(98, 144);
            this.chkSyncError.Name = "chkSyncError";
            this.chkSyncError.Size = new System.Drawing.Size(72, 16);
            this.chkSyncError.TabIndex = 20;
            this.chkSyncError.Text = "自动同步";
            this.chkSyncError.UseVisualStyleBackColor = true;
            this.chkSyncError.Visible = false;
            this.chkSyncError.CheckedChanged += new System.EventHandler(this.chkSyncError_CheckedChanged);
            // 
            // lblSyncErrorStart
            // 
            this.lblSyncErrorStart.AutoSize = true;
            this.lblSyncErrorStart.Location = new System.Drawing.Point(15, 146);
            this.lblSyncErrorStart.Name = "lblSyncErrorStart";
            this.lblSyncErrorStart.Size = new System.Drawing.Size(65, 12);
            this.lblSyncErrorStart.TabIndex = 19;
            this.lblSyncErrorStart.Text = "出错信息：";
            this.lblSyncErrorStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSyncErrorStart.Visible = false;
            // 
            // rbWorkTime
            // 
            this.rbWorkTime.AutoSize = true;
            this.rbWorkTime.Location = new System.Drawing.Point(98, 112);
            this.rbWorkTime.Name = "rbWorkTime";
            this.rbWorkTime.Size = new System.Drawing.Size(71, 16);
            this.rbWorkTime.TabIndex = 18;
            this.rbWorkTime.Text = "工作时间";
            this.rbWorkTime.UseVisualStyleBackColor = true;
            this.rbWorkTime.CheckedChanged += new System.EventHandler(this.rbWorkTime_CheckedChanged);
            // 
            // rbAllTime
            // 
            this.rbAllTime.AutoSize = true;
            this.rbAllTime.Checked = true;
            this.rbAllTime.Location = new System.Drawing.Point(98, 88);
            this.rbAllTime.Name = "rbAllTime";
            this.rbAllTime.Size = new System.Drawing.Size(47, 16);
            this.rbAllTime.TabIndex = 17;
            this.rbAllTime.TabStop = true;
            this.rbAllTime.Text = "全天";
            this.rbAllTime.UseVisualStyleBackColor = true;
            this.rbAllTime.CheckedChanged += new System.EventHandler(this.rbAllTime_CheckedChanged);
            // 
            // cmbSyncGap
            // 
            this.cmbSyncGap.FormattingEnabled = true;
            this.cmbSyncGap.Location = new System.Drawing.Point(98, 53);
            this.cmbSyncGap.Name = "cmbSyncGap";
            this.cmbSyncGap.Size = new System.Drawing.Size(80, 20);
            this.cmbSyncGap.TabIndex = 16;
            // 
            // lblSyncGap
            // 
            this.lblSyncGap.AutoSize = true;
            this.lblSyncGap.Location = new System.Drawing.Point(15, 57);
            this.lblSyncGap.Name = "lblSyncGap";
            this.lblSyncGap.Size = new System.Drawing.Size(65, 12);
            this.lblSyncGap.TabIndex = 15;
            this.lblSyncGap.Text = "同步间隔：";
            this.lblSyncGap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpWorkTimeEnd
            // 
            this.dtpWorkTimeEnd.CustomFormat = "HH:mm";
            this.dtpWorkTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkTimeEnd.Location = new System.Drawing.Point(300, 110);
            this.dtpWorkTimeEnd.Name = "dtpWorkTimeEnd";
            this.dtpWorkTimeEnd.ShowUpDown = true;
            this.dtpWorkTimeEnd.Size = new System.Drawing.Size(80, 21);
            this.dtpWorkTimeEnd.TabIndex = 9;
            // 
            // nudDispNum
            // 
            this.nudDispNum.Location = new System.Drawing.Point(98, 20);
            this.nudDispNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDispNum.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDispNum.Name = "nudDispNum";
            this.nudDispNum.Size = new System.Drawing.Size(80, 21);
            this.nudDispNum.TabIndex = 14;
            this.nudDispNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDispNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblWorkTimeEnd
            // 
            this.lblWorkTimeEnd.AutoSize = true;
            this.lblWorkTimeEnd.Location = new System.Drawing.Point(277, 114);
            this.lblWorkTimeEnd.Name = "lblWorkTimeEnd";
            this.lblWorkTimeEnd.Size = new System.Drawing.Size(17, 12);
            this.lblWorkTimeEnd.TabIndex = 8;
            this.lblWorkTimeEnd.Text = "至";
            // 
            // lblDispRow
            // 
            this.lblDispRow.AutoSize = true;
            this.lblDispRow.Location = new System.Drawing.Point(15, 24);
            this.lblDispRow.Name = "lblDispRow";
            this.lblDispRow.Size = new System.Drawing.Size(65, 12);
            this.lblDispRow.TabIndex = 13;
            this.lblDispRow.Text = "显示条数：";
            this.lblDispRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpWorkTimeStart
            // 
            this.dtpWorkTimeStart.CustomFormat = "HH:mm";
            this.dtpWorkTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkTimeStart.Location = new System.Drawing.Point(184, 110);
            this.dtpWorkTimeStart.Name = "dtpWorkTimeStart";
            this.dtpWorkTimeStart.ShowUpDown = true;
            this.dtpWorkTimeStart.Size = new System.Drawing.Size(80, 21);
            this.dtpWorkTimeStart.TabIndex = 7;
            // 
            // lblWorkTimeStart
            // 
            this.lblWorkTimeStart.AutoSize = true;
            this.lblWorkTimeStart.Location = new System.Drawing.Point(15, 90);
            this.lblWorkTimeStart.Name = "lblWorkTimeStart";
            this.lblWorkTimeStart.Size = new System.Drawing.Size(65, 12);
            this.lblWorkTimeStart.TabIndex = 6;
            this.lblWorkTimeStart.Text = "同步时间：";
            this.lblWorkTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbStartOption
            // 
            this.gbStartOption.Controls.Add(this.btnSync);
            this.gbStartOption.Controls.Add(this.cbShowRunStatu);
            this.gbStartOption.Controls.Add(this.cbAutoRunWhenLoad);
            this.gbStartOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbStartOption.Location = new System.Drawing.Point(19, 18);
            this.gbStartOption.Name = "gbStartOption";
            this.gbStartOption.Size = new System.Drawing.Size(544, 48);
            this.gbStartOption.TabIndex = 1;
            this.gbStartOption.TabStop = false;
            this.gbStartOption.Text = " 启动选项 ";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(448, 16);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "立即同步";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // cbShowRunStatu
            // 
            this.cbShowRunStatu.Location = new System.Drawing.Point(215, 16);
            this.cbShowRunStatu.Name = "cbShowRunStatu";
            this.cbShowRunStatu.Size = new System.Drawing.Size(115, 24);
            this.cbShowRunStatu.TabIndex = 2;
            this.cbShowRunStatu.Text = "显示同步结果";
            // 
            // cbAutoRunWhenLoad
            // 
            this.cbAutoRunWhenLoad.Location = new System.Drawing.Point(16, 16);
            this.cbAutoRunWhenLoad.Name = "cbAutoRunWhenLoad";
            this.cbAutoRunWhenLoad.Size = new System.Drawing.Size(115, 24);
            this.cbAutoRunWhenLoad.TabIndex = 0;
            this.cbAutoRunWhenLoad.Text = "加载后自动运行";
            // 
            // tbSMSSetting
            // 
            this.tbSMSSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tbSMSSetting.Controls.Add(this.btnSendTest);
            this.tbSMSSetting.Controls.Add(this.btnSMSSave);
            this.tbSMSSetting.Controls.Add(this.gbSMSSoftware);
            this.tbSMSSetting.Controls.Add(this.gbSign);
            this.tbSMSSetting.Controls.Add(this.gbState);
            this.tbSMSSetting.Controls.Add(this.gbDB);
            this.tbSMSSetting.Location = new System.Drawing.Point(4, 22);
            this.tbSMSSetting.Name = "tbSMSSetting";
            this.tbSMSSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tbSMSSetting.Size = new System.Drawing.Size(599, 414);
            this.tbSMSSetting.TabIndex = 3;
            this.tbSMSSetting.Text = "短信发送配置";
            // 
            // btnSendTest
            // 
            this.btnSendTest.Location = new System.Drawing.Point(452, 283);
            this.btnSendTest.Name = "btnSendTest";
            this.btnSendTest.Size = new System.Drawing.Size(82, 23);
            this.btnSendTest.TabIndex = 19;
            this.btnSendTest.Text = "发送测试短信";
            this.btnSendTest.UseVisualStyleBackColor = true;
            this.btnSendTest.Click += new System.EventHandler(this.btnSendTest_Click);
            // 
            // btnSMSSave
            // 
            this.btnSMSSave.Location = new System.Drawing.Point(194, 272);
            this.btnSMSSave.Name = "btnSMSSave";
            this.btnSMSSave.Size = new System.Drawing.Size(174, 34);
            this.btnSMSSave.TabIndex = 18;
            this.btnSMSSave.Text = "保 存 配 置";
            this.btnSMSSave.UseVisualStyleBackColor = true;
            this.btnSMSSave.Click += new System.EventHandler(this.btnSMSSave_Click);
            // 
            // gbSMSSoftware
            // 
            this.gbSMSSoftware.Controls.Add(this.btnQueryBalance);
            this.gbSMSSoftware.Controls.Add(this.btnRecharge);
            this.gbSMSSoftware.Controls.Add(this.btnCancel);
            this.gbSMSSoftware.Controls.Add(this.btnRegister);
            this.gbSMSSoftware.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSMSSoftware.Location = new System.Drawing.Point(6, 320);
            this.gbSMSSoftware.Name = "gbSMSSoftware";
            this.gbSMSSoftware.Size = new System.Drawing.Size(578, 62);
            this.gbSMSSoftware.TabIndex = 17;
            this.gbSMSSoftware.TabStop = false;
            this.gbSMSSoftware.Text = "软件管理";
            // 
            // btnQueryBalance
            // 
            this.btnQueryBalance.Location = new System.Drawing.Point(453, 27);
            this.btnQueryBalance.Name = "btnQueryBalance";
            this.btnQueryBalance.Size = new System.Drawing.Size(75, 23);
            this.btnQueryBalance.TabIndex = 3;
            this.btnQueryBalance.Text = "查询余额";
            this.btnQueryBalance.UseVisualStyleBackColor = true;
            this.btnQueryBalance.Click += new System.EventHandler(this.btnQueryBalance_Click);
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(326, 27);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(75, 23);
            this.btnRecharge.TabIndex = 2;
            this.btnRecharge.Text = "充 值";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "序列号注销";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(61, 27);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "序列号注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbSign
            // 
            this.gbSign.Controls.Add(this.cbSign);
            this.gbSign.Controls.Add(this.tbSign);
            this.gbSign.Controls.Add(this.lblSign);
            this.gbSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSign.Location = new System.Drawing.Point(6, 199);
            this.gbSign.Name = "gbSign";
            this.gbSign.Size = new System.Drawing.Size(578, 62);
            this.gbSign.TabIndex = 16;
            this.gbSign.TabStop = false;
            this.gbSign.Text = "短信签名";
            // 
            // cbSign
            // 
            this.cbSign.Location = new System.Drawing.Point(10, 22);
            this.cbSign.Name = "cbSign";
            this.cbSign.Size = new System.Drawing.Size(115, 24);
            this.cbSign.TabIndex = 15;
            this.cbSign.Text = "使用短信签名";
            // 
            // tbSign
            // 
            this.tbSign.Location = new System.Drawing.Point(215, 24);
            this.tbSign.Name = "tbSign";
            this.tbSign.Size = new System.Drawing.Size(213, 21);
            this.tbSign.TabIndex = 12;
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(151, 27);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(65, 12);
            this.lblSign.TabIndex = 11;
            this.lblSign.Text = "签名内容：";
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.tbSendFail);
            this.gbState.Controls.Add(this.lblSendFail);
            this.gbState.Controls.Add(this.tbSendSuccess);
            this.gbState.Controls.Add(this.lblSendSuccess);
            this.gbState.Controls.Add(this.tbToSend);
            this.gbState.Controls.Add(this.lblToSend);
            this.gbState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbState.Location = new System.Drawing.Point(6, 129);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(578, 62);
            this.gbState.TabIndex = 15;
            this.gbState.TabStop = false;
            this.gbState.Text = "定义状态值";
            // 
            // tbSendFail
            // 
            this.tbSendFail.Location = new System.Drawing.Point(361, 24);
            this.tbSendFail.Name = "tbSendFail";
            this.tbSendFail.Size = new System.Drawing.Size(67, 21);
            this.tbSendFail.TabIndex = 14;
            // 
            // lblSendFail
            // 
            this.lblSendFail.AutoSize = true;
            this.lblSendFail.Location = new System.Drawing.Point(297, 27);
            this.lblSendFail.Name = "lblSendFail";
            this.lblSendFail.Size = new System.Drawing.Size(65, 12);
            this.lblSendFail.TabIndex = 13;
            this.lblSendFail.Text = "发送失败：";
            // 
            // tbSendSuccess
            // 
            this.tbSendSuccess.Location = new System.Drawing.Point(215, 24);
            this.tbSendSuccess.Name = "tbSendSuccess";
            this.tbSendSuccess.Size = new System.Drawing.Size(67, 21);
            this.tbSendSuccess.TabIndex = 12;
            // 
            // lblSendSuccess
            // 
            this.lblSendSuccess.AutoSize = true;
            this.lblSendSuccess.Location = new System.Drawing.Point(151, 27);
            this.lblSendSuccess.Name = "lblSendSuccess";
            this.lblSendSuccess.Size = new System.Drawing.Size(65, 12);
            this.lblSendSuccess.TabIndex = 11;
            this.lblSendSuccess.Text = "发送成功：";
            // 
            // tbToSend
            // 
            this.tbToSend.Location = new System.Drawing.Point(71, 24);
            this.tbToSend.Name = "tbToSend";
            this.tbToSend.Size = new System.Drawing.Size(67, 21);
            this.tbToSend.TabIndex = 10;
            // 
            // lblToSend
            // 
            this.lblToSend.AutoSize = true;
            this.lblToSend.Location = new System.Drawing.Point(8, 27);
            this.lblToSend.Name = "lblToSend";
            this.lblToSend.Size = new System.Drawing.Size(53, 12);
            this.lblToSend.TabIndex = 9;
            this.lblToSend.Text = "待发送：";
            // 
            // gbDB
            // 
            this.gbDB.Controls.Add(this.tbColStateDesc);
            this.gbDB.Controls.Add(this.lblColStateDesc);
            this.gbDB.Controls.Add(this.tbColState);
            this.gbDB.Controls.Add(this.lblColState);
            this.gbDB.Controls.Add(this.tbColCreatetime);
            this.gbDB.Controls.Add(this.lblColCreatetime);
            this.gbDB.Controls.Add(this.tbColContent);
            this.gbDB.Controls.Add(this.lblColContent);
            this.gbDB.Controls.Add(this.tbColMobile);
            this.gbDB.Controls.Add(this.lblColMobile);
            this.gbDB.Controls.Add(this.tbColID);
            this.gbDB.Controls.Add(this.lblColID);
            this.gbDB.Controls.Add(this.cbIncrement);
            this.gbDB.Controls.Add(this.tbTableName);
            this.gbDB.Controls.Add(this.lblTableName);
            this.gbDB.Controls.Add(this.tbDBConnection);
            this.gbDB.Controls.Add(this.lblDBConnection);
            this.gbDB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbDB.Location = new System.Drawing.Point(6, 9);
            this.gbDB.Name = "gbDB";
            this.gbDB.Size = new System.Drawing.Size(578, 114);
            this.gbDB.TabIndex = 2;
            this.gbDB.TabStop = false;
            this.gbDB.Text = "数据库设置";
            // 
            // tbColStateDesc
            // 
            this.tbColStateDesc.Location = new System.Drawing.Point(504, 81);
            this.tbColStateDesc.Name = "tbColStateDesc";
            this.tbColStateDesc.Size = new System.Drawing.Size(67, 21);
            this.tbColStateDesc.TabIndex = 16;
            // 
            // lblColStateDesc
            // 
            this.lblColStateDesc.AutoSize = true;
            this.lblColStateDesc.Location = new System.Drawing.Point(419, 84);
            this.lblColStateDesc.Name = "lblColStateDesc";
            this.lblColStateDesc.Size = new System.Drawing.Size(89, 12);
            this.lblColStateDesc.TabIndex = 15;
            this.lblColStateDesc.Text = "发送状态描述：";
            // 
            // tbColState
            // 
            this.tbColState.Location = new System.Drawing.Point(347, 81);
            this.tbColState.Name = "tbColState";
            this.tbColState.Size = new System.Drawing.Size(67, 21);
            this.tbColState.TabIndex = 14;
            // 
            // lblColState
            // 
            this.lblColState.AutoSize = true;
            this.lblColState.Location = new System.Drawing.Point(286, 84);
            this.lblColState.Name = "lblColState";
            this.lblColState.Size = new System.Drawing.Size(65, 12);
            this.lblColState.TabIndex = 13;
            this.lblColState.Text = "发送状态：";
            // 
            // tbColCreatetime
            // 
            this.tbColCreatetime.Location = new System.Drawing.Point(207, 81);
            this.tbColCreatetime.Name = "tbColCreatetime";
            this.tbColCreatetime.Size = new System.Drawing.Size(67, 21);
            this.tbColCreatetime.TabIndex = 12;
            // 
            // lblColCreatetime
            // 
            this.lblColCreatetime.AutoSize = true;
            this.lblColCreatetime.Location = new System.Drawing.Point(146, 84);
            this.lblColCreatetime.Name = "lblColCreatetime";
            this.lblColCreatetime.Size = new System.Drawing.Size(65, 12);
            this.lblColCreatetime.TabIndex = 11;
            this.lblColCreatetime.Text = "入表时间：";
            // 
            // tbColContent
            // 
            this.tbColContent.Location = new System.Drawing.Point(69, 81);
            this.tbColContent.Name = "tbColContent";
            this.tbColContent.Size = new System.Drawing.Size(67, 21);
            this.tbColContent.TabIndex = 10;
            // 
            // lblColContent
            // 
            this.lblColContent.AutoSize = true;
            this.lblColContent.Location = new System.Drawing.Point(8, 84);
            this.lblColContent.Name = "lblColContent";
            this.lblColContent.Size = new System.Drawing.Size(65, 12);
            this.lblColContent.TabIndex = 9;
            this.lblColContent.Text = "短信内容：";
            // 
            // tbColMobile
            // 
            this.tbColMobile.Location = new System.Drawing.Point(437, 50);
            this.tbColMobile.Name = "tbColMobile";
            this.tbColMobile.Size = new System.Drawing.Size(67, 21);
            this.tbColMobile.TabIndex = 8;
            // 
            // lblColMobile
            // 
            this.lblColMobile.AutoSize = true;
            this.lblColMobile.Location = new System.Drawing.Point(386, 53);
            this.lblColMobile.Name = "lblColMobile";
            this.lblColMobile.Size = new System.Drawing.Size(53, 12);
            this.lblColMobile.TabIndex = 7;
            this.lblColMobile.Text = "手机号：";
            // 
            // tbColID
            // 
            this.tbColID.Location = new System.Drawing.Point(299, 50);
            this.tbColID.Name = "tbColID";
            this.tbColID.Size = new System.Drawing.Size(67, 21);
            this.tbColID.TabIndex = 6;
            // 
            // lblColID
            // 
            this.lblColID.AutoSize = true;
            this.lblColID.Location = new System.Drawing.Point(254, 53);
            this.lblColID.Name = "lblColID";
            this.lblColID.Size = new System.Drawing.Size(41, 12);
            this.lblColID.TabIndex = 5;
            this.lblColID.Text = "主键：";
            // 
            // cbIncrement
            // 
            this.cbIncrement.Location = new System.Drawing.Point(136, 50);
            this.cbIncrement.Name = "cbIncrement";
            this.cbIncrement.Size = new System.Drawing.Size(115, 24);
            this.cbIncrement.TabIndex = 4;
            this.cbIncrement.Text = "主键是否自增长";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(52, 50);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(67, 21);
            this.tbTableName.TabIndex = 3;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(7, 53);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(41, 12);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "表名：";
            // 
            // tbDBConnection
            // 
            this.tbDBConnection.Location = new System.Drawing.Point(115, 19);
            this.tbDBConnection.Name = "tbDBConnection";
            this.tbDBConnection.Size = new System.Drawing.Size(451, 21);
            this.tbDBConnection.TabIndex = 1;
            // 
            // lblDBConnection
            // 
            this.lblDBConnection.AutoSize = true;
            this.lblDBConnection.Location = new System.Drawing.Point(7, 23);
            this.lblDBConnection.Name = "lblDBConnection";
            this.lblDBConnection.Size = new System.Drawing.Size(113, 12);
            this.lblDBConnection.TabIndex = 0;
            this.lblDBConnection.Text = "数据库连接字符串：";
            // 
            // timerSync
            // 
            this.timerSync.Tick += new System.EventHandler(this.timerSync_Tick);
            // 
            // ctlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(607, 440);
            this.tcMain.ResumeLayout(false);
            this.tpRunInfo.ResumeLayout(false);
            this.tpRunInfo.PerformLayout();
            this.tpErrorInfo.ResumeLayout(false);
            this.tpErrorInfo.PerformLayout();
            this.tpSet.ResumeLayout(false);
            this.gbRunOption.ResumeLayout(false);
            this.gbRunOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleepGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDispNum)).EndInit();
            this.gbStartOption.ResumeLayout(false);
            this.tbSMSSetting.ResumeLayout(false);
            this.gbSMSSoftware.ResumeLayout(false);
            this.gbSign.ResumeLayout(false);
            this.gbSign.PerformLayout();
            this.gbState.ResumeLayout(false);
            this.gbState.PerformLayout();
            this.gbDB.ResumeLayout(false);
            this.gbDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpRunInfo;
        private System.Windows.Forms.TabPage tpSet;
        private System.Windows.Forms.ImageList tbImageList;
        private System.Windows.Forms.ImageList lvImageList;
        private System.Windows.Forms.ToolBar tbRun;
        private System.Windows.Forms.ListView lvSyncMessage;
        private System.Windows.Forms.ColumnHeader colImg;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.GroupBox gbStartOption;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.CheckBox cbShowRunStatu;
        private System.Windows.Forms.CheckBox cbAutoRunWhenLoad;
        private System.Windows.Forms.GroupBox gbRunOption;
        private System.Windows.Forms.DateTimePicker dtpWorkTimeEnd;
        private System.Windows.Forms.NumericUpDown nudDispNum;
        private System.Windows.Forms.Label lblWorkTimeEnd;
        private System.Windows.Forms.Label lblDispRow;
        private System.Windows.Forms.DateTimePicker dtpWorkTimeStart;
        private System.Windows.Forms.Label lblWorkTimeStart;
        private System.Windows.Forms.Label lblSyncGap;
        private System.Windows.Forms.ComboBox cmbSyncGap;
        private System.Windows.Forms.ToolBarButton tbStartSync;
        private System.Windows.Forms.ToolBarButton tbClearMessage;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbAllTime;
        private System.Windows.Forms.RadioButton rbWorkTime;
        private System.Windows.Forms.Timer timerSync;
        private System.Windows.Forms.TabPage tpErrorInfo;
        private System.Windows.Forms.ToolBar tbError;
        private System.Windows.Forms.ToolBarButton tbErrorSync;
        private System.Windows.Forms.ToolBarButton tbRefreash;
        private System.Windows.Forms.ListView lvErrorList;
        private System.Windows.Forms.ColumnHeader colBikeBarcode;
        private System.Windows.Forms.ColumnHeader colUpMessage;
        private System.Windows.Forms.ToolBarButton tbSelectAll;
        private System.Windows.Forms.ColumnHeader colCheckBox;
        private System.Windows.Forms.ColumnHeader colOrderCode;
        private System.Windows.Forms.Label lblSyncErrorStart;
        private System.Windows.Forms.CheckBox chkSyncError;
        private System.Windows.Forms.DateTimePicker dtpErrorTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpErrorTimeStart;
        private System.Windows.Forms.Label lblSyncErrorEnd;
        private System.Windows.Forms.Label lblSleepGap;
        private System.Windows.Forms.NumericUpDown nudSleepGap;
        private System.Windows.Forms.TabPage tbSMSSetting;
        private System.Windows.Forms.GroupBox gbDB;
        private System.Windows.Forms.TextBox tbColCreatetime;
        private System.Windows.Forms.Label lblColCreatetime;
        private System.Windows.Forms.TextBox tbColContent;
        private System.Windows.Forms.Label lblColContent;
        private System.Windows.Forms.TextBox tbColMobile;
        private System.Windows.Forms.Label lblColMobile;
        private System.Windows.Forms.TextBox tbColID;
        private System.Windows.Forms.Label lblColID;
        private System.Windows.Forms.CheckBox cbIncrement;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox tbDBConnection;
        private System.Windows.Forms.Label lblDBConnection;
        private System.Windows.Forms.TextBox tbColState;
        private System.Windows.Forms.Label lblColState;
        private System.Windows.Forms.GroupBox gbState;
        private System.Windows.Forms.TextBox tbSendFail;
        private System.Windows.Forms.Label lblSendFail;
        private System.Windows.Forms.TextBox tbSendSuccess;
        private System.Windows.Forms.Label lblSendSuccess;
        private System.Windows.Forms.TextBox tbToSend;
        private System.Windows.Forms.Label lblToSend;
        private System.Windows.Forms.GroupBox gbSign;
        private System.Windows.Forms.CheckBox cbSign;
        private System.Windows.Forms.TextBox tbSign;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.GroupBox gbSMSSoftware;
        private System.Windows.Forms.Button btnQueryBalance;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbColStateDesc;
        private System.Windows.Forms.Label lblColStateDesc;
        private System.Windows.Forms.Button btnSMSSave;
        private System.Windows.Forms.Button btnSendTest;
    }
}
