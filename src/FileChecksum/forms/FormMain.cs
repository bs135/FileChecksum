using AutoUpdate;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FileChecksum
{
    public partial class FormMain : Form, IAutoUpdatable
    {
        AutoUpdater updater;

        public FormMain()
        {
            InitializeComponent();
            updater = new AutoUpdater(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            updater.DoUpdate(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            //RegistryKey key;
            //key = Registry.ClassesRoot.CreateSubKey(@"File\shell\MD5 Checksum");
            //key = Registry.ClassesRoot.CreateSubKey(@"File\shell\MD5 Checksum\command");
            //key.SetValue("", Application.ExecutablePath + " %1");

            RegistryKey key;
            key = Registry.ClassesRoot.CreateSubKey(@"*\shell\MD5 Checksum");
            key = Registry.ClassesRoot.CreateSubKey(@"*\shell\MD5 Checksum\command");
            key.SetValue("", Application.ExecutablePath + " \"%1\"");

        }
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            //Registry.ClassesRoot.DeleteSubKeyTree(@"File\shell\MD5 Checksum");
            //Registry.ClassesRoot.DeleteSubKey(@"Folder\shell\MD5 Checksum\command");

            Registry.ClassesRoot.DeleteSubKeyTree(@"*\shell\MD5 Checksum\command");
        }

        #region AutoUpdate
        public string ApplicationName
        {
            get { return "FileChecksum"; }
        }

        public string ApplicationID
        {
            get { return "BS135-FileChecksum"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://github.com/bs135/FileChecksum/raw/master/ReleaseDownload/appinfo.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }

        private bool showMsg = true;
        public bool ShowMsg
        {
            get
            {
                return showMsg;
            }
            set
            {
                showMsg = value;
            }
        }

        #endregion

    }
}
