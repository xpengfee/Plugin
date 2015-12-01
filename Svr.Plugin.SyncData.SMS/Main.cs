using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Svr.Plugin.Interface;

namespace Svr.Plugin.SyncData.SMS
{

    public class Main : IPlugin
    {
        ctlMain ctlMainInterface = null;
        private string cCName;
        private string cEName;
        private string cDescription;
        private string cAuthor;
        private float fVersion;
        private string cKey;
        #region Main
        public Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            object[] attrib = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            cCName = ((AssemblyTitleAttribute)attrib[0]).Title;

            cEName = assembly.GetName().Name;

            attrib = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            cDescription = ((AssemblyDescriptionAttribute)attrib[0]).Description;

            attrib = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            cAuthor = ((AssemblyCompanyAttribute)attrib[0]).Company;

            cKey = System.IO.Path.GetFileNameWithoutExtension(assembly.Location);

            fVersion = float.Parse(assembly.GetName().Version.Major.ToString() + "." + assembly.GetName().Version.Minor.ToString());
        }
        #endregion

        #region IPlugin 成员

        public string CName
        {
            get
            {
                return cCName;
            }
        }

        public string EName
        {
            get
            {
                return cEName;
            }
        }

        public string Key
        {
            set
            {
                cKey = value;
            }
            get
            {
                return cKey;
            }
        }

        public string Description
        {
            get
            {
                return cDescription;
            }
        }

        public string Author
        {
            get
            {
                return cAuthor;
            }
        }

        public float Version
        {
            get
            {
                return fVersion;
            }
        }

        public System.Windows.Forms.UserControl MainControl
        {
            get
            {
                return ctlMainInterface;
            }
        }




        public void Initialize()
        {
            if (ctlMainInterface == null)
                ctlMainInterface = new ctlMain();
        }


        public void Start()
        {
            if (ctlMainInterface != null)
                ctlMainInterface.StartSyncTimer();
        }

        public void Stop()
        {
            if (ctlMainInterface != null)
                ctlMainInterface.StopSyncTimer();
        }
        public void Dispose()
        {
            if (ctlMainInterface != null)
            {
                ctlMainInterface.StopSyncTimer();
                ctlMainInterface.Dispose();
                ctlMainInterface = null;
            }
        }
        #endregion
    }
}
