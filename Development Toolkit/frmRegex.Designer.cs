namespace Development_Toolkit
{
    partial class frmRegex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegex));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMatch = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lb4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.tbxFormat = new System.Windows.Forms.TextBox();
            this.lbMD5 = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlAll.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lbTitle.Text = "正则表达式验证";
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
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lb4);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.lb1);
            this.pnlMain.Controls.Add(this.pnlSetting);
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
            this.pnlAll.Location = new System.Drawing.Point(0, 113);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAll.Size = new System.Drawing.Size(410, 97);
            this.pnlAll.TabIndex = 10;
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
            this.tbxResult.Size = new System.Drawing.Size(400, 87);
            this.tbxResult.TabIndex = 8;
            this.tbxResult.Text = "匹配结果";
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb2.Location = new System.Drawing.Point(0, 108);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(410, 5);
            this.lb2.TabIndex = 9;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMatch);
            this.panel2.Controls.Add(this.lbResult);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(410, 36);
            this.panel2.TabIndex = 8;
            // 
            // lbMatch
            // 
            this.lbMatch.AutoEllipsis = true;
            this.lbMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMatch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMatch.ForeColor = System.Drawing.Color.DimGray;
            this.lbMatch.Location = new System.Drawing.Point(153, 5);
            this.lbMatch.Name = "lbMatch";
            this.lbMatch.Size = new System.Drawing.Size(252, 26);
            this.lbMatch.TabIndex = 5;
            this.lbMatch.Text = "Match:";
            this.lbMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResult
            // 
            this.lbResult.AutoEllipsis = true;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Green;
            this.lbResult.Location = new System.Drawing.Point(90, 5);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(63, 26);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "False";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.AutoEllipsis = true;
            this.lb3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb3.Location = new System.Drawing.Point(80, 5);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(10, 26);
            this.lb3.TabIndex = 3;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpen.Location = new System.Drawing.Point(5, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 26);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "验证数据";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lb4
            // 
            this.lb4.AutoEllipsis = true;
            this.lb4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb4.Location = new System.Drawing.Point(0, 67);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(410, 5);
            this.lb4.TabIndex = 7;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxValue);
            this.panel1.Controls.Add(this.lbValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(410, 31);
            this.panel1.TabIndex = 5;
            // 
            // tbxValue
            // 
            this.tbxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxValue.Location = new System.Drawing.Point(105, 5);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(300, 21);
            this.tbxValue.TabIndex = 7;
            // 
            // lbValue
            // 
            this.lbValue.AutoEllipsis = true;
            this.lbValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbValue.Location = new System.Drawing.Point(5, 5);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(100, 21);
            this.lbValue.TabIndex = 2;
            this.lbValue.Text = "验证数值";
            this.lbValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb1
            // 
            this.lb1.AutoEllipsis = true;
            this.lb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb1.Location = new System.Drawing.Point(0, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(410, 5);
            this.lb1.TabIndex = 4;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.tbxFormat);
            this.pnlSetting.Controls.Add(this.lbMD5);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSetting.Size = new System.Drawing.Size(410, 31);
            this.pnlSetting.TabIndex = 3;
            // 
            // tbxFormat
            // 
            this.tbxFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFormat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFormat.Location = new System.Drawing.Point(105, 5);
            this.tbxFormat.Name = "tbxFormat";
            this.tbxFormat.Size = new System.Drawing.Size(300, 21);
            this.tbxFormat.TabIndex = 7;
            // 
            // lbMD5
            // 
            this.lbMD5.AutoEllipsis = true;
            this.lbMD5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMD5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMD5.Location = new System.Drawing.Point(5, 5);
            this.lbMD5.Name = "lbMD5";
            this.lbMD5.Size = new System.Drawing.Size(100, 21);
            this.lbMD5.TabIndex = 2;
            this.lbMD5.Text = "正则表达式:";
            this.lbMD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRegex
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
            this.Name = "frmRegex";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regex";
            this.pnlTitle.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox tbxFormat;
        private System.Windows.Forms.Label lbMD5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lbMatch;
        private System.Windows.Forms.Label lbResult;
    }
}