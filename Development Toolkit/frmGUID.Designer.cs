namespace Development_Toolkit
{
    partial class frmGUID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUID));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.lbExit = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.tbxFormat = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.nbdCount = new System.Windows.Forms.NumericUpDown();
            this.lbMD5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.pnlGetGUID = new System.Windows.Forms.Panel();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlAll.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbdCount)).BeginInit();
            this.pnlGetGUID.SuspendLayout();
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
            this.lbTitle.Text = "GUID生成";
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
            this.pnlMain.Controls.Add(this.pnlAll);
            this.pnlMain.Controls.Add(this.lb2);
            this.pnlMain.Controls.Add(this.pnlSetting);
            this.pnlMain.Controls.Add(this.lb1);
            this.pnlMain.Controls.Add(this.pnlGetGUID);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(410, 210);
            this.pnlMain.TabIndex = 5;
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.tbxResult);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAll.Location = new System.Drawing.Point(0, 73);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAll.Size = new System.Drawing.Size(410, 137);
            this.pnlAll.TabIndex = 4;
            // 
            // tbxResult
            // 
            this.tbxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxResult.Location = new System.Drawing.Point(5, 5);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(400, 127);
            this.tbxResult.TabIndex = 8;
            this.tbxResult.Text = "生成结果";
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb2.Location = new System.Drawing.Point(0, 68);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(410, 5);
            this.lb2.TabIndex = 3;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.tbxFormat);
            this.pnlSetting.Controls.Add(this.lbCount);
            this.pnlSetting.Controls.Add(this.nbdCount);
            this.pnlSetting.Controls.Add(this.lbMD5);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 36);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSetting.Size = new System.Drawing.Size(410, 32);
            this.pnlSetting.TabIndex = 2;
            // 
            // tbxFormat
            // 
            this.tbxFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFormat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFormat.Location = new System.Drawing.Point(52, 5);
            this.tbxFormat.Name = "tbxFormat";
            this.tbxFormat.Size = new System.Drawing.Size(239, 21);
            this.tbxFormat.TabIndex = 8;
            this.tbxFormat.Text = "D&-yyMMddHHmm";
            // 
            // lbCount
            // 
            this.lbCount.AutoEllipsis = true;
            this.lbCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCount.Location = new System.Drawing.Point(291, 5);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(64, 22);
            this.lbCount.TabIndex = 4;
            this.lbCount.Text = "数量:";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nbdCount
            // 
            this.nbdCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.nbdCount.Font = new System.Drawing.Font("宋体", 12F);
            this.nbdCount.Location = new System.Drawing.Point(355, 5);
            this.nbdCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbdCount.Name = "nbdCount";
            this.nbdCount.Size = new System.Drawing.Size(50, 26);
            this.nbdCount.TabIndex = 3;
            this.nbdCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbMD5
            // 
            this.lbMD5.AutoEllipsis = true;
            this.lbMD5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMD5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMD5.Location = new System.Drawing.Point(5, 5);
            this.lbMD5.Name = "lbMD5";
            this.lbMD5.Size = new System.Drawing.Size(47, 22);
            this.lbMD5.TabIndex = 2;
            this.lbMD5.Text = "格式:";
            this.lbMD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb1
            // 
            this.lb1.AutoEllipsis = true;
            this.lb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb1.Location = new System.Drawing.Point(0, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(410, 5);
            this.lb1.TabIndex = 1;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGetGUID
            // 
            this.pnlGetGUID.Controls.Add(this.tbxFilePath);
            this.pnlGetGUID.Controls.Add(this.lb3);
            this.pnlGetGUID.Controls.Add(this.btnCopy);
            this.pnlGetGUID.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGetGUID.Location = new System.Drawing.Point(0, 0);
            this.pnlGetGUID.Name = "pnlGetGUID";
            this.pnlGetGUID.Padding = new System.Windows.Forms.Padding(5);
            this.pnlGetGUID.Size = new System.Drawing.Size(410, 31);
            this.pnlGetGUID.TabIndex = 0;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFilePath.Location = new System.Drawing.Point(5, 5);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.ReadOnly = true;
            this.tbxFilePath.Size = new System.Drawing.Size(330, 21);
            this.tbxFilePath.TabIndex = 6;
            this.tbxFilePath.Text = "点击生成一组GUID";
            this.tbxFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFilePath.Click += new System.EventHandler(this.tbxFilePath_Click);
            // 
            // lb3
            // 
            this.lb3.AutoEllipsis = true;
            this.lb3.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb3.Location = new System.Drawing.Point(335, 5);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(5, 21);
            this.lb3.TabIndex = 5;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopy.Location = new System.Drawing.Point(340, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(65, 21);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmGUID
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
            this.Name = "frmGUID";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID";
            this.TopMost = true;
            this.pnlTitle.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbdCount)).EndInit();
            this.pnlGetGUID.ResumeLayout(false);
            this.pnlGetGUID.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel pnlGetGUID;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.NumericUpDown nbdCount;
        private System.Windows.Forms.Label lbMD5;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.TextBox tbxFormat;
    }
}