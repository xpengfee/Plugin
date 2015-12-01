#region Copyright
//----------------------------------------------------------------
// Copyright (C) 2014 xpengfee 版权所有。 
//
// 文件名 EmayHelper
//
// 文件功能描述
// TODO
// 
// 创建标识：xupeng Create at 2014/6/19 10:01:57
// 修改标识：
// 修改描述：
//
// 修改标识：
// 修改描述：
//----------------------------------------------------------------
#endregion
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Svr.Plugin.SyncData.SMS
{
    public class EmayHelper
    {
        #region DllImport EUCPComm.dll

        //调用dll方法
        [DllImport("EUCPComm.dll", EntryPoint = "SendSMS")]  //即时发送
        public static extern int SendSMS(string sn, string mn, string ct, string priority);

        [DllImport("EUCPComm.dll", EntryPoint = "SendSMSEx")]  //即时发送(扩展)
        public static extern int SendSMSEx(string sn, string mn, string ct, string addi, string priority);

        [DllImport("EUCPComm.dll", EntryPoint = "SendScheSMS")]  // 定时发送
        public static extern int SendScheSMS(string sn, string mn, string ct, string ti, string priority);

        [DllImport("EUCPComm.dll", EntryPoint = "SendScheSMSEx")]  // 定时发送(扩展)
        public static extern int SendScheSMSEx(string sn, string mn, string ct, string ti, string addi, string priority);

        [DllImport("EUCPComm.dll", EntryPoint = "ReceiveSMS")]  // 接收短信
        public static extern int ReceiveSMS(string sn, deleSQF mySmsContent);

        [DllImport("EUCPComm.dll", EntryPoint = "ReceiveSMSEx")]  // 接收短信
        public static extern int ReceiveSMSEx(string sn, deleSQF mySmsContent);

        [DllImport("EUCPComm.dll", EntryPoint = "ReceiveStatusReport")]  // 接收短信报告
        public static extern int ReceiveStatusReport(string sn, delegSMSReport mySmsReport);

        [DllImport("EUCPComm.dll", EntryPoint = "ReceiveStatusReportEx")]  // 接收短信报告(带批量ID)
        public static extern int ReceiveStatusReportEx(string sn, delegSMSReportEx mySmsReportEx);

        [DllImport("EUCPComm.dll", EntryPoint = "Register")]   // 注册 
        public static extern int Register(string sn, string pwd, string EntName, string LinkMan, string Phone, string Mobile, string Email, string Fax, string sAddress, string Postcode);

        [DllImport("EUCPComm.dll", EntryPoint = "GetBalance", CallingConvention = CallingConvention.Winapi)] // 余额 
        public static extern int GetBalance(string m, System.Text.StringBuilder balance);


        [DllImport("EUCPComm.dll", EntryPoint = "ChargeUp")]  // 存值
        public static extern int ChargeUp(string sn, string acco, string pass);

        [DllImport("EUCPComm.dll", EntryPoint = "GetPrice")]  // 价格
        public static extern int GetPrice(string m, System.Text.StringBuilder balance);

        [DllImport("EUCPComm.dll", EntryPoint = "RegistryTransfer")]  //申请转接
        public static extern int RegistryTransfer(string sn, string mn);

        [DllImport("EUCPComm.dll", EntryPoint = "CancelTransfer")]  // 注销转接
        public static extern int CancelTransfer(string sn);

        [DllImport("EUCPComm.dll", EntryPoint = "UnRegister")]  // 注销
        public static extern int UnRegister(string sn);

        [DllImport("EUCPComm.dll", EntryPoint = "SetProxy")]  // 设置代理服务器 
        public static extern int SetProxy(string IP, string Port, string UserName, string PWD);

        [DllImport("EUCPComm.dll", EntryPoint = "RegistryPwdUpd")]  // 修改序列号密码
        public static extern int RegistryPwdUpd(string sn, string oldPWD, string newPWD);




        //回调(接收短信)
        /*回调函数参数说明(收到上行短信的各参数值)
		    mobile：手机号码（当falg=1时有内容）
		    senderaddi：发送者附加号码（当falg=1时有内容），无此项
		    recvaddi：接收者附加号码（当falg=1时有内容），无此项
		    ct：短信内容（当falg=1时有内容）
		    sd：接收时间（当falg=1时有内容，格式：yyyymmddhhnnss）
		    flag：1表示有短信，0表示无短信（不用在处理信息了）
         */
        static void getSMSContent(string mobile, string senderaddi, string recvaddi, string ct, string sd, ref int flag)
        {
            string mob = mobile;
            string content = ct;
            int myflag = flag;
        }

        //声明委托，对回调函数进行封装。
        public delegate void deleSQF(string mobile, string senderaddi, string recvaddi, string ct, string sd, ref int flag);
        deleSQF mySmsContent = new deleSQF(getSMSContent);

        //回调(接收状态报告)
        static void getSMSReport(string mobile, string errorCode, string serviceCodeAdd, string reportType, ref int flag)
        {
            string mob = mobile;
            int myflag = flag;
        }
        public delegate void delegSMSReport(string mobile, string errorCode, string serviceCodeAdd, string reportType, ref int flag);
        delegSMSReport mySmsReport = new delegSMSReport(getSMSReport);

        //回调(接收状态报告)带批量ID
        static void getSMSReportEx(ref long seq, string mobile, string errorCode, string serviceCodeAdd, string reportType, ref int flag)
        {
            string mob = mobile;
            int myflag = flag;
        }
        public delegate void delegSMSReportEx(ref long seq, string mobile, string errorCode, string serviceCodeAdd, string reportType, ref int flag);
        delegSMSReportEx mySmsReportEx = new delegSMSReportEx(getSMSReportEx);

        #endregion

        private static EmayHelper instance = new EmayHelper();

        public static EmayHelper Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// 调用亿美软通接口,进行注册
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="sn"></param>
        /// <param name="snPwd"></param>
        /// <param name="userName"></param>
        /// <param name="contactName"></param>
        /// <param name="contactMobile"></param>
        /// <param name="contactPhone"></param>
        /// <param name="contactEmail"></param>
        /// <param name="contactFax"></param>
        /// <param name="contactAddress"></param>
        /// <param name="contactZipcode"></param>
        /// <returns></returns>
        public bool SvrRegister(out string msg, string sn, string snPwd, string userName, string contactName, string contactMobile, string contactPhone,
            string contactEmail, string contactFax, string contactAddress, string contactZipcode)
        {
            bool result = false;
            msg = "注册失败";

            int iReturn = Register(sn, snPwd, userName, contactName, contactPhone, contactMobile, contactEmail, contactFax,
                contactAddress, contactZipcode);

            if (iReturn == 1)
            {
                result = true;
                msg = "注册成功";
            }
            else if (iReturn == 101)
                msg = "网络故障";
            else if (iReturn == 999)
                msg = "调用频率过快";
            else if (iReturn == -1)
                msg = "系统异常";
            else if (iReturn == -2)
                msg = "客户端异常";
            else if (iReturn == -101)
                msg = "命令不被支持";
            else if (iReturn == -110)
                msg = "号码注册激活失败";
            else if (iReturn == -1100)
                msg = "序列号错误，序列号不存在内存中，或尝试攻击的用户";
            else if (iReturn == -1103)
                msg = "序列号Key错误";
            else if (iReturn == -1102)
                msg = "序列号密码错误";
            else
            {
                msg = "其他故障值：" + iReturn.ToString();
            }

            return result;
        }

        /// <summary>
        /// 调用亿美软通接口,注销帐号
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="sn"></param>
        /// <returns></returns>
        public bool SvrUnRegister(out string msg, string sn)
        {
            bool result = false;
            msg = "注销失败";

            //注销序列号            注册号
            int iReturn = UnRegister(sn);
            if (iReturn == 1)
            {
                msg = "注销成功";
                result = true;
            }
            else if (iReturn == 101)
                msg = "网络故障";
            else if (iReturn == 113)
                msg = "调用接口失败";
            else if (iReturn == 999)
                msg = "调用频率过快";
            else if (iReturn == -1)
                msg = "系统异常";
            else if (iReturn == -2)
                msg = "客户端异常";
            else if (iReturn == -122)
                msg = "号码注销激活失败";
            else if (iReturn == -1100)
                msg = "序列号错误，序列号不存在内存中，或尝试攻击户的用";
            else
                msg = "其他故障值：" + iReturn.ToString();

            return result;
        }

        /// <summary>
        /// 调用亿美软通接口,进行充值
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="sn"></param>
        /// <param name="acco"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool SvrCharge(out string msg, string sn, string acco, string pass)
        {
            bool result = false;
            msg = "充值错误";

            //充值               注册号          卡号         密码
            int iReturn = ChargeUp(sn, acco, pass);

            if (iReturn == 1)
            {
                result = true;
                msg = "充值成功";
            }
            else if (iReturn == 101)
                msg = "网络故障";
            else if (iReturn == 113)
                msg = "调用接口失败";
            else if (iReturn == 999)
                msg = "调用频率过快";
            else if (iReturn == -113)
                msg = "充值失败";
            else if (iReturn == -1131)
                msg = "充值卡无效";
            else if (iReturn == -1132)
                msg = "充值密码无效";
            else if (iReturn == -1133)
                msg = "充值卡绑定异常";
            else if (iReturn == -1134)
                msg = "充值状态无效";
            else if (iReturn == -9023)
                msg = "充值卡号格式错误";
            else if (iReturn == -9024)
                msg = "充值密码格式错误";
            else
                msg = "其他故障值：" + iReturn.ToString();

            return result;
        }

        /// <summary>
        /// 调用亿美软通接口,查询余额
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        public string SvrGetBalance(string sn)
        {
            string result = string.Empty;

            System.Text.StringBuilder balance = new System.Text.StringBuilder(0, 20);
            //得到余额            注册号         余额
            int iReturn = GetBalance(sn, balance);
            string mybalance = balance.ToString(0, balance.Length - 1);
            if (iReturn == 1)
            {
                result = "您的余额为"+mybalance + " 元";
            }
            else if (iReturn == 101)
                result = "网络故障";
            else if (iReturn == 105)
                result = "参数balance指针为空";
            else if (iReturn == 125)
                result = "初始化通讯SOCKET失败";
            else if (iReturn == -1)
                result = "系统异常";
            else if (iReturn == -124)
                result = "查询余额失败";
            else if (iReturn == -2)
                result = "客户端异常";
            else if (iReturn == -9002)
                result = "密码格式错误";
            else if (iReturn == -1100)
                result = "序列号错误,序列号哦不存在内存中,或尝试攻击的用户";
            else
                result = "其他故障值:" + iReturn.ToString();

            return result;
        }

        /// <summary>
        /// 调用亿美软通接口，发送短信
        /// </summary>
        /// <param name="sn">软件序列号</param>
        /// <param name="mobile">手机号</param>
        /// <param name="content">短信内容</param>
        /// <param name="priority">优先级（默认5）</param>
        /// <returns></returns>
        public int SvrSendSMS(out string msg, string sn, string mobile, string content, string priority = "5")
        {
            int result = SendSMS(sn, mobile, content, priority);

            switch (result)
            {
                case 1:
                    msg = "发送成功";
                    break;
                case 101:
                    msg = "网络故障";
                    break;
                case 110:
                    msg = "短信内容为空或超长";
                    break;
                case 998:
                    msg = "超时(长时间没有得到响应消息)";
                    break;
                case -1:
                    msg = "系统异常";
                    break;
                case -104:
                    msg = "请求超过限制";
                    break;
                case -117:
                    msg = "发送短信失败";
                    break;
                case -9001:
                    msg = "序列号格式错误";
                    break;
                case -9016:
                    msg = "发送短信包大小超出范围";
                    break;
                case -9020:
                    msg = "发送短信手机号格式错误";
                    break;
                case -9019:
                    msg = "发送短信优先级格式错误";
                    break;
                case -9022:
                    msg = "发送短信唯一序列值错误";
                    break;
                case -9017:
                    msg = "发送短信内容格式错误";
                    break;
                default:
                    msg = "未知错误";
                    break;
            }

            return result;
        }
    }
}