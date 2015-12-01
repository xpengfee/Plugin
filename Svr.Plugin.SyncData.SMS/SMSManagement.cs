#region Copyright
//----------------------------------------------------------------
// Copyright (C) 2014 xpengfee 版权所有。 
//
// 文件名 SMSManagement
//
// 文件功能描述
// TODO
// 
// 创建标识：xupeng Create at 2014/6/19 13:21:29
// 修改标识：
// 修改描述：
//
// 修改标识：
// 修改描述：
//----------------------------------------------------------------
#endregion
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Svr.Plugin.SyncData.SMS
{
    public sealed class SMSManagement
    {
        #region 构造函数  --单例
        /// <summary>
        /// 信息同步类生成, 唯一实例
        /// </summary>
        private static readonly SMSManagement instance = new SMSManagement();


        /// <summary>
        /// Prevents a default instance of the SettleManagement class from being created.
        /// </summary>
        private SMSManagement()
        {
        }

        /// <summary>
        /// Gets a value Instance whether the item is enabled.
        /// </summary>
        public static SMSManagement Instance
        {
            get { return instance; }
        }
        #endregion

        /// <summary>
        /// 根据状态获取待发送短信
        /// </summary>
        /// <param name="dbConncection"></param>
        /// <param name="tableName"></param>
        /// <param name="colID"></param>
        /// <param name="colMobile"></param>
        /// <param name="colContent"></param>
        /// <param name="colState"></param>
        /// <param name="stateToSend">待发送、发送失败</param>
        /// <returns></returns>
        public DataTable GetToSendSMS(string dbConncection, string tableName, string colID, string colMobile, string colContent,
            string colState, string stateValue)
        {
            string strSqlFormat = "SELECT {0},{1},{2} FROM {3} WHERE {4}='{5}'";
            string strSql = string.Format(strSqlFormat, colID, colMobile, colContent, tableName, colState, stateValue);

            DataTable dt = SqlHelper.ExecuteTable(dbConncection, strSql);


            return dt;
        }

        /// <summary>
        /// 短信发送结果保存到数据库
        /// </summary>
        /// <param name="dbConncection"></param>
        /// <param name="tableName"></param>
        /// <param name="colID"></param>
        /// <param name="colState"></param>
        /// <param name="colStateDesc"></param>
        /// <param name="list"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool SaveSMSResult(string dbConncection, string tableName, string colID, string colState,
            string colStateDesc, List<SMSSendResult> list, out string msg)
        {
            bool result = false;
            msg = "短信发送结果保存到数据库失败";


            System.Collections.Hashtable htQuery = new System.Collections.Hashtable();

            for (int i = 0; i < list.Count; i++)
            {
                string strSQL = string.Format(
                        "/*{0}.*/UPDATE {1} SET {2}='{3}',{4}='{5}' WHERE {6}='{7}'",
                        i + 1, tableName, colState, list[i].State, colStateDesc, list[i].Msg, colID, list[i].ID);


                htQuery.Add(strSQL, strSQL);
            }

            string exeSqlMsg = string.Empty;

            if (SqlHelper.ExecuteSqlTran_old(dbConncection, htQuery, out exeSqlMsg))
            {
                result = true;
                msg = "短信发送结果保存到数据库成功,共更新：" + list.Count.ToString() + "条记录";

            }
            else
            {
                msg = "短信发送结果保存到数据库失败，错误信息：" + exeSqlMsg;
            }


            return result;
        }

        /// <summary>
        /// 测试短信保存到数据库
        /// </summary>
        /// <param name="dbConncection"></param>
        /// <param name="tableName"></param>
        /// <param name="colMobile"></param>
        /// <param name="mobile"></param>
        /// <param name="colContent"></param>
        /// <param name="content"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool SendTestSMS(string dbConncection, string tableName, string colMobile, string mobile,
            string colContent, string content, string colState, string state, out string msg)
        {

            bool result = false;
            msg = "测试短信保存到数据库失败";

            string strSQL = string.Format(
                       "/*1.*/INSERT INTO {0} ({1},{2},{3}) VALUES ('{4}','{5}','{6}')",
                       tableName, colMobile, colContent, colState, mobile, content, state);

            int iReturn = SqlHelper.ExecuteSql(dbConncection, strSQL);

            if (iReturn > 0)
            {
                result = true;
                msg = "测试短信保存到数据库成功";
            }

            return result;
        }

    }
}