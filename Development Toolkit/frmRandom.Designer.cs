namespace Development_Toolkit
{
    partial class frmRandom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandom));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.tbxFileInfo = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.tbxMD5 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.pnlFormat = new System.Windows.Forms.Panel();
            this.tbxFormat = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.nbdCount = new System.Windows.Forms.NumericUpDown();
            this.lbFormat = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.cbxSign = new System.Windows.Forms.CheckBox();
            this.cbxUpper = new System.Windows.Forms.CheckBox();
            this.cbxLower = new System.Windows.Forms.CheckBox();
            this.cbxNum = new System.Windows.Forms.CheckBox();
            this.pnlTitle.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.gpbResult.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.pnlFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbdCount)).BeginInit();
            this.pnlSetting.SuspendLayout();
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
            this.pnlTitle.TabIndex = 3;
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
            this.lbTitle.Text = "随机数生成";
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
            this.pnlMain.Controls.Add(this.gpbResult);
            this.pnlMain.Controls.Add(this.lb2);
            this.pnlMain.Controls.Add(this.pnlResult);
            this.pnlMain.Controls.Add(this.lb1);
            this.pnlMain.Controls.Add(this.pnlFormat);
            this.pnlMain.Controls.Add(this.lb4);
            this.pnlMain.Controls.Add(this.pnlSetting);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(410, 210);
            this.pnlMain.TabIndex = 5;
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.tbxFileInfo);
            this.gpbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbResult.Location = new System.Drawing.Point(0, 112);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Padding = new System.Windows.Forms.Padding(7);
            this.gpbResult.Size = new System.Drawing.Size(410, 98);
            this.gpbResult.TabIndex = 13;
            this.gpbResult.TabStop = false;
            this.gpbResult.Text = "历史结果";
            // 
            // tbxFileInfo
            // 
            this.tbxFileInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFileInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxFileInfo.Location = new System.Drawing.Point(7, 29);
            this.tbxFileInfo.Multiline = true;
            this.tbxFileInfo.Name = "tbxFileInfo";
            this.tbxFileInfo.ReadOnly = true;
            this.tbxFileInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxFileInfo.Size = new System.Drawing.Size(396, 62);
            this.tbxFileInfo.TabIndex = 8;
            this.tbxFileInfo.WordWrap = false;
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb2.Location = new System.Drawing.Point(0, 107);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(410, 5);
            this.lb2.TabIndex = 12;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.tbxMD5);
            this.pnlResult.Controls.Add(this.lb3);
            this.pnlResult.Controls.Add(this.btnCopy);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResult.Location = new System.Drawing.Point(0, 76);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Padding = new System.Windows.Forms.Padding(5);
            this.pnlResult.Size = new System.Drawing.Size(410, 31);
            this.pnlResult.TabIndex = 11;
            // 
            // tbxMD5
            // 
            this.tbxMD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxMD5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMD5.Location = new System.Drawing.Point(5, 5);
            this.tbxMD5.Name = "tbxMD5";
            this.tbxMD5.ReadOnly = true;
            this.tbxMD5.Size = new System.Drawing.Size(325, 21);
            this.tbxMD5.TabIndex = 13;
            this.tbxMD5.Text = "点击生成随机数";
            this.tbxMD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxMD5.Click += new System.EventHandler(this.tbxMD5_Click);
            // 
            // lb3
            // 
            this.lb3.AutoEllipsis = true;
            this.lb3.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb3.Location = new System.Drawing.Point(330, 5);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(10, 21);
            this.lb3.TabIndex = 12;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopy.Location = new System.Drawing.Point(340, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(65, 21);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lb1
            // 
            this.lb1.AutoEllipsis = true;
            this.lb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb1.Location = new System.Drawing.Point(0, 71);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(410, 5);
            this.lb1.TabIndex = 10;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFormat
            // 
            this.pnlFormat.Controls.Add(this.tbxFormat);
            this.pnlFormat.Controls.Add(this.lbCount);
            this.pnlFormat.Controls.Add(this.nbdCount);
            this.pnlFormat.Controls.Add(this.lbFormat);
            this.pnlFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormat.Location = new System.Drawing.Point(0, 40);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFormat.Size = new System.Drawing.Size(410, 31);
            this.pnlFormat.TabIndex = 9;
            // 
            // tbxFormat
            // 
            this.tbxFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFormat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFormat.Location = new System.Drawing.Point(85, 5);
            this.tbxFormat.Name = "tbxFormat";
            this.tbxFormat.Size = new System.Drawing.Size(203, 21);
            this.tbxFormat.TabIndex = 11;
            this.tbxFormat.Text = "NLU";
            // 
            // lbCount
            // 
            this.lbCount.AutoEllipsis = true;
            this.lbCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCount.Location = new System.Drawing.Point(288, 5);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(53, 21);
            this.lbCount.TabIndex = 10;
            this.lbCount.Text = "长度:";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nbdCount
            // 
            this.nbdCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.nbdCount.Font = new System.Drawing.Font("宋体", 12F);
            this.nbdCount.Location = new System.Drawing.Point(341, 5);
            this.nbdCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbdCount.Name = "nbdCount";
            this.nbdCount.Size = new System.Drawing.Size(64, 26);
            this.nbdCount.TabIndex = 9;
            this.nbdCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lbFormat
            // 
            this.lbFormat.AutoEllipsis = true;
            this.lbFormat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFormat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFormat.Location = new System.Drawing.Point(5, 5);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(80, 21);
            this.lbFormat.TabIndex = 2;
            this.lbFormat.Text = "生成规则:";
            this.lbFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb4
            // 
            this.lb4.AutoEllipsis = true;
            this.lb4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb4.Location = new System.Drawing.Point(0, 35);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(410, 5);
            this.lb4.TabIndex = 8;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.cbxSign);
            this.pnlSetting.Controls.Add(this.cbxUpper);
            this.pnlSetting.Controls.Add(this.cbxLower);
            this.pnlSetting.Controls.Add(this.cbxNum);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSetting.Size = new System.Drawing.Size(410, 35);
            this.pnlSetting.TabIndex = 4;
            // 
            // cbxSign
            // 
            this.cbxSign.AutoSize = true;
            this.cbxSign.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxSign.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cbxSign.Location = new System.Drawing.Point(239, 5);
            this.cbxSign.Name = "cbxSign";
            this.cbxSign.Size = new System.Drawing.Size(58, 25);
            this.cbxSign.TabIndex = 3;
            this.cbxSign.Tag = "S";
            this.cbxSign.Text = "符号";
            this.cbxSign.UseVisualStyleBackColor = true;
            this.cbxSign.CheckedChanged += new System.EventHandler(this.cbxSign_CheckedChanged);
            // 
            // cbxUpper
            // 
            this.cbxUpper.AutoSize = true;
            this.cbxUpper.Checked = true;
            this.cbxUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUpper.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxUpper.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cbxUpper.Location = new System.Drawing.Point(151, 5);
            this.cbxUpper.Name = "cbxUpper";
            this.cbxUpper.Size = new System.Drawing.Size(88, 25);
            this.cbxUpper.TabIndex = 2;
            this.cbxUpper.Tag = "U";
            this.cbxUpper.Text = "大写字母";
            this.cbxUpper.UseVisualStyleBackColor = true;
            this.cbxUpper.CheckedChanged += new System.EventHandler(this.cbxSign_CheckedChanged);
            // 
            // cbxLower
            // 
            this.cbxLower.AutoSize = true;
            this.cbxLower.Checked = true;
            this.cbxLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLower.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxLower.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cbxLower.Location = new System.Drawing.Point(63, 5);
            this.cbxLower.Name = "cbxLower";
            this.cbxLower.Size = new System.Drawing.Size(88, 25);
            this.cbxLower.TabIndex = 1;
            this.cbxLower.Tag = "L";
            this.cbxLower.Text = "小写字母";
            this.cbxLower.UseVisualStyleBackColor = true;
            this.cbxLower.CheckedChanged += new System.EventHandler(this.cbxSign_CheckedChanged);
            // 
            // cbxNum
            // 
            this.cbxNum.AutoSize = true;
            this.cbxNum.Checked = true;
            this.cbxNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxNum.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cbxNum.Location = new System.Drawing.Point(5, 5);
            this.cbxNum.Name = "cbxNum";
            this.cbxNum.Size = new System.Drawing.Size(58, 25);
            this.cbxNum.TabIndex = 0;
            this.cbxNum.Tag = "N";
            this.cbxNum.Text = "数字";
            this.cbxNum.UseVisualStyleBackColor = true;
            this.cbxNum.CheckedChanged += new System.EventHandler(this.cbxSign_CheckedChanged);
            // 
            // frmRandom
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
            this.Name = "frmRandom";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random";
            this.TopMost = true;
            this.pnlTitle.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.gpbResult.ResumeLayout(false);
            this.gpbResult.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbdCount)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel pnlFormat;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.GroupBox gpbResult;
        private System.Windows.Forms.TextBox tbxFileInfo;
        private System.Windows.Forms.TextBox tbxFormat;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.NumericUpDown nbdCount;
        private System.Windows.Forms.TextBox tbxMD5;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbxSign;
        private System.Windows.Forms.CheckBox cbxUpper;
        private System.Windows.Forms.CheckBox cbxLower;
        private System.Windows.Forms.CheckBox cbxNum;
    }
}