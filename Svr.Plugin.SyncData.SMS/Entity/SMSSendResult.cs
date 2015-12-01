#region Copyright
//----------------------------------------------------------------
// Copyright (C) 2014 xpengfee 版权所有。 
//
// 文件名 SMSSendResult
//
// 文件功能描述
// TODO
// 
// 创建标识：xupeng Create at 2014/6/19 15:30:49
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
    public class ErrorMsg
    {
        public string ID { get; set; }
        public string Mobile { get; set; }
        public string Content { get; set; }
    }

    public class SMSSendResult
    {
        public string ID { get; set; }
        public string State { get; set; }
        public string Msg { get; set; }

        public SMSSendResult(string id,string state,string msg)
        {
            ID = id;
            State = state;
            Msg = msg;
        }
    }
}