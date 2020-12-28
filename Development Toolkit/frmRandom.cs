using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Development_Toolkit
{
    public partial class frmRandom : Form
    {
        public frmRandom()
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

        private void tbxMD5_Click(object sender, EventArgs e)
        {
            tbxMD5.Text = GetRandomString((int)nbdCount.Value, tbxFormat.Text);
            tbxFileInfo.AppendText(tbxMD5.Text + "\r\n");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbxMD5.SelectAll();
            tbxMD5.Copy();
        }

        public static string GetRandomString(int length, string format)
        {
            string Number = "0123456789";
            string Lower = "abcdefghijklmnopqrstuvwxyz";
            string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Sign = "!@#$%^&*.";
            string RandomSeed = string.Empty;
            if (format is null) format = "N";
            format = format.ToUpper();
            foreach (char item in format)
            {
                if (item == 'U') RandomSeed += Upper;
                else if (item == 'L') RandomSeed += Lower;
                else if (item == 'N') RandomSeed += Number;
                else if (item == 'S') RandomSeed += Sign;
            }
            if (RandomSeed.Length <= 0) RandomSeed += Number;
            Random random = new Random((int)DateTime.Now.Ticks);
            string result = string.Empty;
            for (int j = 0; j < length; j++)
                result += RandomSeed[random.Next(RandomSeed.Length)];
            return result;
        }

        private void cbxSign_CheckedChanged(object sender, EventArgs e)
        {
            string format = "";
            foreach (Control item in pnlSetting.Controls)
            {
                if (item is CheckBox cbx && cbx.Checked)
                    format += cbx.Tag;
            }
            tbxFormat.Text = format;
        }
    }
}
