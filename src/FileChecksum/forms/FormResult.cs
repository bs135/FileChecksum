using AutoUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChecksum
{
    public partial class FormResult : Form, IAutoUpdatable
    {
        AutoUpdater updater;

        public FormResult(string[] arg)
        {
            InitializeComponent();
            updater = new AutoUpdater(this);

            string filePath = arg[0];

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Error! File not found: " + filePath);
                Application.Exit();
            }

            string md5Checksum = GetChecksumValue(filePath);

            txtCurrentChecksum.Text = md5Checksum;
            txtFilePath.Text = filePath;
            lblMatched.Text = "";
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            updater.DoUpdate(false);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtCurrentChecksum.Text.Trim().ToLower() == txtOriginalChecksum.Text.Trim().ToLower())
            {
                lblMatched.Text = "Matched";
            }
            else
            {
                lblMatched.Text = "NOT Matched";
            }
        }

        private string GetChecksumValue(string filePath)
        {
            return MakeHashString(MD5.Create().ComputeHash(new FileStream(filePath, FileMode.Open)));
        }

        private string MakeHashString(byte[] hash)
        {
            StringBuilder s = new StringBuilder();

            foreach (byte b in hash)
                s.Append(b.ToString("x2").ToLower());

            return s.ToString();
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
