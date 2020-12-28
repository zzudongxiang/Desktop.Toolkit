namespace Development_Toolkit
{
    partial class frmBase64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase64));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pblBtn = new System.Windows.Forms.Panel();
            this.btnUnCode = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.pnlPassWord = new System.Windows.Forms.Panel();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pblBtn.SuspendLayout();
            this.pnlPassWord.SuspendLayout();
            this.pnlValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
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
            this.lbTitle.Text = "Base64编码解码";
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMain.Controls.Add(this.pblBtn);
            this.pnlMain.Controls.Add(this.pnlPassWord);
            this.pnlMain.Controls.Add(this.pnlValue);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(410, 210);
            this.pnlMain.TabIndex = 5;
            // 
            // pblBtn
            // 
            this.pblBtn.Controls.Add(this.btnUnCode);
            this.pblBtn.Controls.Add(this.btnCode);
            this.pblBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblBtn.Location = new System.Drawing.Point(0, 100);
            this.pblBtn.Name = "pblBtn";
            this.pblBtn.Padding = new System.Windows.Forms.Padding(70, 7, 70, 7);
            this.pblBtn.Size = new System.Drawing.Size(410, 37);
            this.pblBtn.TabIndex = 2;
            // 
            // btnUnCode
            // 
            this.btnUnCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUnCode.Location = new System.Drawing.Point(245, 7);
            this.btnUnCode.Name = "btnUnCode";
            this.btnUnCode.Size = new System.Drawing.Size(95, 23);
            this.btnUnCode.TabIndex = 1;
            this.btnUnCode.Text = "Base64解码";
            this.btnUnCode.UseVisualStyleBackColor = true;
            this.btnUnCode.Click += new System.EventHandler(this.btnUnCode_Click);
            // 
            // btnCode
            // 
            this.btnCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCode.Location = new System.Drawing.Point(70, 7);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(95, 23);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Base64编码";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // pnlPassWord
            // 
            this.pnlPassWord.Controls.Add(this.tbxPassWord);
            this.pnlPassWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPassWord.Location = new System.Drawing.Point(0, 137);
            this.pnlPassWord.Name = "pnlPassWord";
            this.pnlPassWord.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPassWord.Size = new System.Drawing.Size(410, 73);
            this.pnlPassWord.TabIndex = 1;
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPassWord.Location = new System.Drawing.Point(5, 5);
            this.tbxPassWord.Multiline = true;
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.ReadOnly = true;
            this.tbxPassWord.Size = new System.Drawing.Size(400, 63);
            this.tbxPassWord.TabIndex = 1;
            // 
            // pnlValue
            // 
            this.pnlValue.Controls.Add(this.tbxValue);
            this.pnlValue.Controls.Add(this.label1);
            this.pnlValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValue.Location = new System.Drawing.Point(0, 0);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Padding = new System.Windows.Forms.Padding(5);
            this.pnlValue.Size = new System.Drawing.Size(410, 100);
            this.pnlValue.TabIndex = 0;
            // 
            // tbxValue
            // 
            this.tbxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxValue.Location = new System.Drawing.Point(5, 23);
            this.tbxValue.Multiline = true;
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(400, 72);
            this.tbxValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入待编码或待解码信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // frmBase64
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
            this.Name = "frmBase64";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64";
            this.TopMost = true;
            this.pnlTitle.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pblBtn.ResumeLayout(false);
            this.pnlPassWord.ResumeLayout(false);
            this.pnlPassWord.PerformLayout();
            this.pnlValue.ResumeLayout(false);
            this.pnlValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
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
        private System.Windows.Forms.Panel pblBtn;
        private System.Windows.Forms.Button btnUnCode;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Panel pnlPassWord;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label label1;
    }
}