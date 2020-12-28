namespace Development_Toolkit
{
    partial class frmIcon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIcon));
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbFileMD5 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbDUID = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbRandom = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lbRegex = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lbBase64 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.DTnotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerOpen = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnIcon = new System.Windows.Forms.PictureBox();
            this.pnlIcon.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.btnIcon);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Padding = new System.Windows.Forms.Padding(5);
            this.pnlIcon.Size = new System.Drawing.Size(90, 75);
            this.pnlIcon.TabIndex = 0;
            this.pnlIcon.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.pnlIcon.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(155, 48);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Image = global::Development_Toolkit.Properties.Resources.Logo;
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面(&O)";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Image = global::Development_Toolkit.Properties.Resources.Exit;
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // lb1
            // 
            this.lb1.AutoEllipsis = true;
            this.lb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb1.Location = new System.Drawing.Point(0, 75);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(90, 5);
            this.lb1.TabIndex = 4;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFileMD5
            // 
            this.lbFileMD5.AutoEllipsis = true;
            this.lbFileMD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.lbFileMD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFileMD5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFileMD5.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFileMD5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbFileMD5.Location = new System.Drawing.Point(2, 2);
            this.lbFileMD5.Name = "lbFileMD5";
            this.lbFileMD5.Size = new System.Drawing.Size(84, 30);
            this.lbFileMD5.TabIndex = 15;
            this.lbFileMD5.Text = "FileMD5";
            this.lbFileMD5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lbFileMD5, "生成文件MD5校验码");
            this.lbFileMD5.Click += new System.EventHandler(this.lb_Click);
            this.lbFileMD5.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lbFileMD5.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.lb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb2.Location = new System.Drawing.Point(2, 32);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(84, 3);
            this.lb2.TabIndex = 16;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb2.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lb2.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lbDUID
            // 
            this.lbDUID.AutoEllipsis = true;
            this.lbDUID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.lbDUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDUID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDUID.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbDUID.Location = new System.Drawing.Point(2, 35);
            this.lbDUID.Name = "lbDUID";
            this.lbDUID.Size = new System.Drawing.Size(84, 30);
            this.lbDUID.TabIndex = 17;
            this.lbDUID.Text = "GUID";
            this.lbDUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lbDUID, "生成一组随机数");
            this.lbDUID.Click += new System.EventHandler(this.lb_Click);
            this.lbDUID.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lbDUID.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lb3
            // 
            this.lb3.AutoEllipsis = true;
            this.lb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.lb3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb3.Location = new System.Drawing.Point(2, 65);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(84, 3);
            this.lb3.TabIndex = 18;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb3.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lb3.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lbRandom
            // 
            this.lbRandom.AutoEllipsis = true;
            this.lbRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.lbRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRandom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRandom.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRandom.Location = new System.Drawing.Point(2, 68);
            this.lbRandom.Name = "lbRandom";
            this.lbRandom.Size = new System.Drawing.Size(84, 30);
            this.lbRandom.TabIndex = 19;
            this.lbRandom.Text = "Random";
            this.lbRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lbRandom, "生成一组随机数");
            this.lbRandom.Click += new System.EventHandler(this.lb_Click);
            this.lbRandom.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lbRandom.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lb4
            // 
            this.lb4.AutoEllipsis = true;
            this.lb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.lb4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb4.Location = new System.Drawing.Point(2, 98);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(84, 3);
            this.lb4.TabIndex = 20;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb4.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lb4.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lbRegex
            // 
            this.lbRegex.AutoEllipsis = true;
            this.lbRegex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.lbRegex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRegex.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRegex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRegex.Location = new System.Drawing.Point(2, 101);
            this.lbRegex.Name = "lbRegex";
            this.lbRegex.Size = new System.Drawing.Size(84, 30);
            this.lbRegex.TabIndex = 21;
            this.lbRegex.Text = "Regex";
            this.lbRegex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lbRegex, "正则表达式匹配");
            this.lbRegex.Click += new System.EventHandler(this.lb_Click);
            this.lbRegex.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lbRegex.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lb5
            // 
            this.lb5.AutoEllipsis = true;
            this.lb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.lb5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb5.Location = new System.Drawing.Point(2, 131);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(84, 3);
            this.lb5.TabIndex = 22;
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb5.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lb5.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // lbBase64
            // 
            this.lbBase64.AutoEllipsis = true;
            this.lbBase64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.lbBase64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBase64.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBase64.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBase64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbBase64.Location = new System.Drawing.Point(2, 134);
            this.lbBase64.Name = "lbBase64";
            this.lbBase64.Size = new System.Drawing.Size(84, 30);
            this.lbBase64.TabIndex = 23;
            this.lbBase64.Text = "Base64";
            this.lbBase64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lbBase64, "Base64编码与解码");
            this.lbBase64.Click += new System.EventHandler(this.lb_Click);
            this.lbBase64.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.lbBase64.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lbBase64);
            this.pnlMenu.Controls.Add(this.lb5);
            this.pnlMenu.Controls.Add(this.lbRegex);
            this.pnlMenu.Controls.Add(this.lb4);
            this.pnlMenu.Controls.Add(this.lbRandom);
            this.pnlMenu.Controls.Add(this.lb3);
            this.pnlMenu.Controls.Add(this.lbDUID);
            this.pnlMenu.Controls.Add(this.lb2);
            this.pnlMenu.Controls.Add(this.lbFileMD5);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 80);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Size = new System.Drawing.Size(90, 200);
            this.pnlMenu.TabIndex = 5;
            this.pnlMenu.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.pnlMenu.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            // 
            // DTnotifyIcon
            // 
            this.DTnotifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.DTnotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("DTnotifyIcon.Icon")));
            this.DTnotifyIcon.Text = "zzudongxiang@163.com";
            this.DTnotifyIcon.Visible = true;
            // 
            // TimerOpen
            // 
            this.TimerOpen.Interval = 30;
            this.TimerOpen.Tag = "";
            this.TimerOpen.Tick += new System.EventHandler(this.TimerOpen_Tick);
            // 
            // btnIcon
            // 
            this.btnIcon.ContextMenuStrip = this.contextMenuStrip;
            this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIcon.Image = global::Development_Toolkit.Properties.Resources.Logo;
            this.btnIcon.Location = new System.Drawing.Point(5, 5);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(80, 65);
            this.btnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIcon.TabIndex = 1;
            this.btnIcon.TabStop = false;
            this.btnIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.btnIcon.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
            this.btnIcon.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
            this.btnIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.btnIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // frmIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(90, 280);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pnlIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIcon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开发辅助工具";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.pnlIcon.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbFileMD5;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbDUID;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbRandom;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lbRegex;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lbBase64;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.NotifyIcon DTnotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.Timer TimerOpen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox btnIcon;
    }
}

