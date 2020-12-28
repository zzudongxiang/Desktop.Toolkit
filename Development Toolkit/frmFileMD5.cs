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

namespace Development_Toolkit
{
    public partial class frmFileMD5 : Form
    {
        public frmFileMD5()
        {
            InitializeComponent();
            pbxExit.Tag = lbExit;
        }

        #region TitleCommon

        private bool IsDown = false;

        private Point CurrentPosition = new Point(0, 0);

        private void lb_MouseEnter(object sender, EventArgs e)
        {
            Label lb;
            if (sender is PictureBox pbx)
                lb = pbx.Tag as Label;
            else lb = sender as Label;
            lb.ForeColor = Color.Red;
        }

        private void lb_MouseLeave(object sender, EventArgs e)
        {
            Label lb;
            if (sender is PictureBox pbx)
                lb = pbx.Tag as Label;
            else lb = sender as Label;
            lb.ForeColor = Color.FromArgb(128, 255, 128);
        }

        private void lb_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown = true;
            CurrentPosition = MousePosition;
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                this.Left += MousePosition.X - CurrentPosition.X;
                this.Top += MousePosition.Y - CurrentPosition.Y;
                CurrentPosition = MousePosition;
            }
        }

        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
        }


        #endregion

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Multiselect = false,
                    Title = "选择文件",
                    Filter = "所有文件|*.*",
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbxFilePath.Text = dialog.FileName;
                    tbxMD5.Text = GetFileMD5(dialog.FileName);
                    cbxFormat_CheckedChanged(cbxFormat, new EventArgs());
                    FileInfo fi = new FileInfo(tbxFilePath.Text);
                    tbxFileInfo.Clear();
                    tbxFileInfo.Text += "文件名:" + GetFileName(fi.Name) + "\r\n";
                    tbxFileInfo.Text += "文件类型:" + GetFileExtension(fi.Name) + "\r\n";
                    tbxFileInfo.Text += "文件大小:" + GetFileSize(fi.Length) + "\r\n";
                    tbxFileInfo.Text += "创建时间:" + fi.CreationTime.ToString() + "\r\n";
                    tbxFileInfo.Text += "修改时间:" + fi.LastWriteTime.ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error", Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFileName(string fileName)
        {
            string extension = GetFileExtension(fileName);
            return fileName.Replace(string.Format(".{0}", extension), string.Empty);
        }

        private string GetFileExtension(string fileName)
        {
            return fileName.Split('.').Last();
        }

        public static string GetFileSize(long bit)
        {
            const int GB = 1024 * 1024 * 1024;
            const int MB = 1024 * 1024;
            const int KB = 1024;
            if (bit / GB >= 1)
                return Math.Round(bit / (float)GB, 2) + "GB";
            if (bit / MB >= 1)
                return Math.Round(bit / (float)MB, 2) + "MB";
            if (bit / KB >= 1)
                return Math.Round(bit / (float)KB, 2) + "KB";
            return bit + "B";
        }

        private string GetFileMD5(string filepath)
        {
            try
            {
                FileStream file = new FileStream(filepath, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error", Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        private void cbxFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFormat.Checked)
                tbxMD5.Text = tbxMD5.Text.ToLower();
            else
                tbxMD5.Text = tbxMD5.Text.ToUpper();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbxMD5.SelectAll();
            tbxMD5.Copy();
        }
    }
}
