#region Copyright
//----------------------------------------------------------------
// Copyright (C) 2014 xpengfee 版权所有。 
//
// 文件名 EmayHelper2
//
// 文件功能描述
// TODO
// 
// 创建标识：xupeng Create at 2014/7/15 15:18:46
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

namespace Svr.Plugin.SyncData.SMS
{
    public class EmayHelper2
    {
        private static EmayHelper2 instance = new EmayHelper2();
        private static EmayService.SDKClientClient sdkService = new EmayService.SDKClientClient();

        public static EmayHelper2 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// 调用亿美软通-WebService接口,进行注册
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

            int iRegister = sdkService.registEx(sn, snPwd, snPwd);
            if (iRegister == 0)
            {
                int iReturn = sdkService.registDetailInfo(sn, snPwd, userName, contactName, contactPhone, contactMobile, contactEmail, contactFax,
                contactAddress, contactZipcode);

                if (iReturn == 0)
                {
                    result = true;
                    msg = "注册成功";
                }
                else if (iReturn == -1)
                    msg = "注册企业信息不符合要求";
                else if (iReturn == 11)
                    msg = "企业信息注册失败";
                else if (iReturn == 303)
                    msg = "客户端网络故障";
                else if (iReturn == 305)
                    msg = "服务器端返回错误，错误的返回值（返回值不是数字字符串）";
                else if (iReturn == 307)
                    msg = "目标电话号码不符合规则，电话号码必须是以0、1开头";
                else if (iReturn == 999)
                    msg = "调用频率过快";
                else
                {
                    msg = "其他故障值：" + iReturn.ToString();
                }
            }
            else if (iRegister == 10)
                msg = "客户端注册失败";
            else if (iRegister == 303)
                msg = "客户端网络故障";
            else if (iRegister == 305)
                msg = "服务器端返回错误，错误的返回值（返回值不是数字字符串）";
            else if (iRegister == 999)
                msg = "操作频繁";
            else
            {
                msg = "其他故障值：" + iRegister.ToString();
            }

            

            return result;
        }


        /// <summary>
        /// 调用亿美软通-WebService接口,注销帐号
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="sn"></param>
        /// <returns></returns>
        public bool SvrUnRegister(out string msg, string sn, string snPwd)
        {
            bool result = false;
            msg = "注销失败";

            //注销序列号            注册号
            int iReturn = sdkService.logout(sn, snPwd);
            if (iReturn == 0)
            {
                msg = "注销成功";
                result = true;
            }
            //else if (iReturn == 101)
            //    msg = "网络故障";
            //else if (iReturn == 113)
            //    msg = "调用接口失败";
            else if (iReturn == 22)
                msg = "注销失败";
            else if (iReturn == 303)
                msg = "客户端网络故障";
            else if (iReturn == 305)
                msg = "服务器端返回错误，错误的返回值（返回值不是数字字符串）";
            else if (iReturn == 999)
                msg = "调用频率过快";
            //else if (iReturn == -1)
            //    msg = "系统异常";
            //else if (iReturn == -2)
            //    msg = "客户端异常";
            //else if (iReturn == -122)
            //    msg = "号码注销激活失败";
            //else if (iReturn == -1100)
            //    msg = "序列号错误，序列号不存在内存中，或尝试攻击户的用";
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
        public bool SvrCharge(out string msg, string sn, string snPwd, string acco, string pass)
        {
            bool result = false;
            msg = "充值错误";

            //充值               注册号   密码       卡号         卡密码
            int iReturn = sdkService.chargeUp(sn, snPwd, acco, pass);

            if (iReturn == 0)
            {
                result = true;
                msg = "充值成功";
            }
            //else if (iReturn == 101)
            //    msg = "网络故障";
            //else if (iReturn == 113)
            //    msg = "调用接口失败";
            //else if (iReturn == 999)
            //    msg = "调用频率过快";
            else if (iReturn == 13)
                msg = "充值失败";
            else if (iReturn == 303)
                msg = "客户端网络故障";
            else if (iReturn == 305)
                msg = "服务器端返回错误，错误的返回值（返回值不是数字字符串）";
            else if (iReturn == 999)
                msg = "操作频繁";
            //else if (iReturn == -1131)
            //    msg = "充值卡无效";
            //else if (iReturn == -1132)
            //    msg = "充值密码无效";
            //else if (iReturn == -1133)
            //    msg = "充值卡绑定异常";
            //else if (iReturn == -1134)
            //    msg = "充值状态无效";
            //else if (iReturn == -9023)
            //    msg = "充值卡号格式错误";
            //else if (iReturn == -9024)
            //    msg = "充值密码格式错误";
            else
                msg = "其他故障值：" + iReturn.ToString();

            return result;
        }

        /// <summary>
        /// 调用亿美软通接口,查询余额
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        public string SvrGetBalance(string sn, string snPwd)
        {
            string result = string.Empty;

            //得到余额            注册号     PWD    余额
            double balance = sdkService.getBalance(sn, snPwd);

            result = string.Format("您的余额为{0}元", balance);

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
        public int SvrSendSMS(out string msg, string sn, string snPwd, string mobile, string content, int priority = 5)
        {
            //                sn   pwd  发送时间        手机号       内容  扩展号  编码 优先级

            int result = sdkService.sendSMS(sn, snPwd, "", new string[1] { mobile }, content, "", "GBK", priority, 2);

            switch (result)
            {
                case 0:
                    msg = "短信发送成功";
                    break;
                case 17:
                    msg = "发送信息失败";
                    break;
                case 303:
                    msg = "客户端网络故障";
                    break;
                case 305:
                    msg = "服务器端返回错误，错误的返回值（返回值不是数字字符串）";
                    break;
                case 307:
                    msg = "目标电话号码不符合规则，电话号码必须是以0、1开头";
                    break;
                case 997:
                    msg = "平台返回找不到超时的短信，该信息是否成功无法确定";
                    break;
                case 998:
                    msg = "由于客户端网络问题导致信息发送超时，该信息是否成功下发无法确定";
                    break;
                //case -1:
                //    msg = "系统异常";
                //    break;
                //case -104:
                //    msg = "请求超过限制";
                //    break;
                //case -117:
                //    msg = "发送短信失败";
                //    break;
                //case -9001:
                //    msg = "序列号格式错误";
                //    break;
                //case -9016:
                //    msg = "发送短信包大小超出范围";
                //    break;
                //case -9020:
                //    msg = "发送短信手机号格式错误";
                //    break;
                //case -9019:
                //    msg = "发送短信优先级格式错误";
                //    break;
                //case -9022:
                //    msg = "发送短信唯一序列值错误";
                //    break;
                //case -9017:
                //    msg = "发送短信内容格式错误";
                //    break;
                default:
                    msg = "未知错误";
                    break;
            }

            return result;
        }
    }
}