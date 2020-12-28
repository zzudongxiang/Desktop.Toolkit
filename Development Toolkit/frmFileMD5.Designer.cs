namespace Development_Toolkit
{
    partial class frmFileMD5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileMD5));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gpbFileInfo = new System.Windows.Forms.GroupBox();
            this.tbxFileInfo = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.tbxMD5 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.cbxFormat = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbMD5 = new System.Windows.Forms.Label();
            this.pnlFile = new System.Windows.Forms.Panel();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.gpbFileInfo.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.pnlFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTitle.Controls.Add(this.pnlText);
            this.pnlTitle.Controls.Add(this.pnlExit);
            this.pnlTitle.Controls.Add(this.pbxLogo);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(5, 5);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTitle.Size = new System.Drawing.Size(410, 80);
            this.pnlTitle.TabIndex = 0;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.lbAuthor);
            this.pnlText.Controls.Add(this.lbTitle);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(85, 5);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(238, 70);
            this.pnlText.TabIndex = 2;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoEllipsis = true;
            this.lbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAuthor.ForeColor = System.Drawing.Color.Gray;
            this.lbAuthor.Location = new System.Drawing.Point(0, 50);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(238, 20);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "该工具由zzudongxiang@163.com创建";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAuthor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.lbAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.lbAuthor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(238, 50);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "文件MD5";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.pbxExit);
            this.pnlExit.Controls.Add(this.lbExit);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExit.Location = new System.Drawing.Point(323, 5);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Padding = new System.Windows.Forms.Padding(0, 20, 5, 20);
            this.pnlExit.Size = new System.Drawing.Size(82, 70);
            this.pnlExit.TabIndex = 1;
            this.pnlExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.pnlExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.pnlExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // pbxExit
            // 
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxExit.Image = global::Development_Toolkit.Properties.Resources.Exit;
            this.pbxExit.Location = new System.Drawing.Point(0, 20);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(21, 30);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 1;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.lb_Click);
            this.pbxExit.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.pbxExit.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // lbExit
            // 
            this.lbExit.AutoEllipsis = true;
            this.lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbExit.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbExit.Location = new System.Drawing.Point(21, 20);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(56, 30);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "Exit";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExit.Click += new System.EventHandler(this.lb_Click);
            this.lbExit.MouseEnter += new System.EventHandler(this.lb_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lb_MouseLeave);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxLogo.Image = global::Development_Toolkit.Properties.Resources.Logo;
            this.pbxLogo.Location = new System.Drawing.Point(5, 5);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(80, 70);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.pbxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMain.Controls.Add(this.gpbFileInfo);
            this.pnlMain.Controls.Add(this.pnlResult);
            this.pnlMain.Controls.Add(this.pnlFile);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(410, 210);
            this.pnlMain.TabIndex = 3;
            // 
            // gpbFileInfo
            // 
            this.gpbFileInfo.Controls.Add(this.tbxFileInfo);
            this.gpbFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbFileInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbFileInfo.Location = new System.Drawing.Point(0, 31);
            this.gpbFileInfo.Name = "gpbFileInfo";
            this.gpbFileInfo.Padding = new System.Windows.Forms.Padding(7);
            this.gpbFileInfo.Size = new System.Drawing.Size(410, 148);
            this.gpbFileInfo.TabIndex = 2;
            this.gpbFileInfo.TabStop = false;
            this.gpbFileInfo.Text = "文件信息";
            // 
            // tbxFileInfo
            // 
            this.tbxFileInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFileInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxFileInfo.Location = new System.Drawing.Point(7, 29);
            this.tbxFileInfo.Multiline = true;
            this.tbxFileInfo.Name = "tbxFileInfo";
            this.tbxFileInfo.ReadOnly = true;
            this.tbxFileInfo.Size = new System.Drawing.Size(396, 112);
            this.tbxFileInfo.TabIndex = 8;
            this.tbxFileInfo.Text = "文件名:\r\n文件类型:\r\n文件大小:\r\n创建时间:\r\n修改时间:";
            this.tbxFileInfo.WordWrap = false;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.tbxMD5);
            this.pnlResult.Controls.Add(this.lb2);
            this.pnlResult.Controls.Add(this.cbxFormat);
            this.pnlResult.Controls.Add(this.btnCopy);
            this.pnlResult.Controls.Add(this.lbMD5);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResult.Location = new System.Drawing.Point(0, 179);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Padding = new System.Windows.Forms.Padding(5);
            this.pnlResult.Size = new System.Drawing.Size(410, 31);
            this.pnlResult.TabIndex = 1;
            // 
            // tbxMD5
            // 
            this.tbxMD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMD5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMD5.Location = new System.Drawing.Point(52, 5);
            this.tbxMD5.Name = "tbxMD5";
            this.tbxMD5.ReadOnly = true;
            this.tbxMD5.Size = new System.Drawing.Size(237, 21);
            this.tbxMD5.TabIndex = 7;
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb2.Location = new System.Drawing.Point(289, 5);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(3, 21);
            this.lb2.TabIndex = 6;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxFormat
            // 
            this.cbxFormat.AutoSize = true;
            this.cbxFormat.Checked = true;
            this.cbxFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFormat.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbxFormat.Location = new System.Drawing.Point(292, 5);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(48, 21);
            this.cbxFormat.TabIndex = 5;
            this.cbxFormat.Text = "小写";
            this.cbxFormat.UseVisualStyleBackColor = true;
            this.cbxFormat.CheckedChanged += new System.EventHandler(this.cbxFormat_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopy.Location = new System.Drawing.Point(340, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(65, 21);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbMD5
            // 
            this.lbMD5.AutoEllipsis = true;
            this.lbMD5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMD5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMD5.Location = new System.Drawing.Point(5, 5);
            this.lbMD5.Name = "lbMD5";
            this.lbMD5.Size = new System.Drawing.Size(47, 21);
            this.lbMD5.TabIndex = 1;
            this.lbMD5.Text = "MD5";
            this.lbMD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFile
            // 
            this.pnlFile.Controls.Add(this.tbxFilePath);
            this.pnlFile.Controls.Add(this.lb1);
            this.pnlFile.Controls.Add(this.btnOpen);
            this.pnlFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFile.Location = new System.Drawing.Point(0, 0);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFile.Size = new System.Drawing.Size(410, 31);
            this.pnlFile.TabIndex = 0;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilePath.Location = new System.Drawing.Point(90, 5);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.ReadOnly = true;
            this.tbxFilePath.Size = new System.Drawing.Size(315, 21);
            this.tbxFilePath.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoEllipsis = true;
            this.lb1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb1.Location = new System.Drawing.Point(80, 5);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(10, 21);
            this.lb1.TabIndex = 1;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpen.Location = new System.Drawing.Point(5, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 21);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "选择文件";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmFileMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "frmFileMD5";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileMD5";
            this.TopMost = true;
            this.pnlTitle.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.gpbFileInfo.ResumeLayout(false);
            this.gpbFileInfo.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lbMD5;
        private System.Windows.Forms.CheckBox cbxFormat;
        private System.Windows.Forms.TextBox tbxMD5;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.GroupBox gpbFileInfo;
        private System.Windows.Forms.TextBox tbxFileInfo;
    }
}