namespace FileChecksum
{
    partial class FormResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this.txtCurrentChecksum = new System.Windows.Forms.TextBox();
            this.txtOriginalChecksum = new System.Windows.Forms.TextBox();
            this.lblCurrentChecksum = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblOriginalChecksum = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblMatched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtCurrentChecksum
            //
            this.txtCurrentChecksum.Location = new System.Drawing.Point(12, 82);
            this.txtCurrentChecksum.Name = "txtCurrentChecksum";
            this.txtCurrentChecksum.ReadOnly = true;
            this.txtCurrentChecksum.Size = new System.Drawing.Size(446, 20);
            this.txtCurrentChecksum.TabIndex = 0;
            //
            // txtOriginalChecksum
            //
            this.txtOriginalChecksum.Location = new System.Drawing.Point(12, 133);
            this.txtOriginalChecksum.Name = "txtOriginalChecksum";
            this.txtOriginalChecksum.Size = new System.Drawing.Size(446, 20);
            this.txtOriginalChecksum.TabIndex = 1;
            //
            // lblCurrentChecksum
            //
            this.lblCurrentChecksum.AutoSize = true;
            this.lblCurrentChecksum.Location = new System.Drawing.Point(12, 66);
            this.lblCurrentChecksum.Name = "lblCurrentChecksum";
            this.lblCurrentChecksum.Size = new System.Drawing.Size(138, 13);
            this.lblCurrentChecksum.TabIndex = 2;
            this.lblCurrentChecksum.Text = "Current file MD5 checksum:";
            //
            // btnVerify
            //
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerify.Location = new System.Drawing.Point(398, 159);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(60, 23);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            //
            // lblOriginalChecksum
            //
            this.lblOriginalChecksum.AutoSize = true;
            this.lblOriginalChecksum.Location = new System.Drawing.Point(12, 117);
            this.lblOriginalChecksum.Name = "lblOriginalChecksum";
            this.lblOriginalChecksum.Size = new System.Drawing.Size(231, 13);
            this.lblOriginalChecksum.TabIndex = 4;
            this.lblOriginalChecksum.Text = "Original file MD5 checksum (optional, for verify):";
            //
            // lblFilePath
            //
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 14);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(50, 13);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "File path:";
            //
            // txtFilePath
            //
            this.txtFilePath.Location = new System.Drawing.Point(12, 30);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(446, 20);
            this.txtFilePath.TabIndex = 5;
            //
            // lblMatched
            //
            this.lblMatched.AutoSize = true;
            this.lblMatched.Location = new System.Drawing.Point(12, 169);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(0, 13);
            this.lblMatched.TabIndex = 7;
            //
            // FormResult
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 195);
            this.Controls.Add(this.lblMatched);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblOriginalChecksum);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblCurrentChecksum);
            this.Controls.Add(this.txtOriginalChecksum);
            this.Controls.Add(this.txtCurrentChecksum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checksum Result";
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentChecksum;
        private System.Windows.Forms.TextBox txtOriginalChecksum;
        private System.Windows.Forms.Label lblCurrentChecksum;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblOriginalChecksum;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblMatched;
    }
}