using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Development_Toolkit
{
    public partial class frmRegex : Form
    {
        public frmRegex()
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
                Regex reg = new Regex(tbxFormat.Text);
                if (reg.IsMatch(tbxValue.Text))
                {
                    lbResult.Text = "True";
                    lbResult.ForeColor = Color.Green;
                }
                else
                {
                    lbResult.Text = "False";
                    lbResult.ForeColor = Color.Red;
                }
                lbMatch.Text = "Match:" + reg.Match(tbxValue.Text).Value;
                MatchCollection matchs = reg.Matches(tbxValue.Text);
                tbxResult.Clear();
                foreach (Match item in matchs) tbxResult.AppendText(item.Value + "\r\n");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error", Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
