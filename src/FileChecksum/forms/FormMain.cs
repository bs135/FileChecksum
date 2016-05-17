using AutoUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            get { return new Uri("https://github.com/bs135/FileChecksum/raw/master/src/FileChecksum/appinfo.xml"); }
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

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updater.DoUpdate(false);
        }
    }
}
