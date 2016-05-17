using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChecksum
{
    public partial class FormResult : Form
    {
        public FormResult(string[] arg)
        {
            InitializeComponent();

            string filePath = arg[0];

            if (!File.Exists(filePath))
            {
                MessageBox.Show(filePath);
                Application.Exit();
            }

            string md5Checksum = GetChecksumValue(filePath);

            txtCurrentChecksum.Text = md5Checksum;
            txtFilePath.Text = filePath;
            lblMatched.Text = "";
        }

        private void FormResult_Load(object sender, EventArgs e)
        {

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
    }
}
