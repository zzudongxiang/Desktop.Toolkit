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
    public partial class frmBase64 : Form
    {
        public frmBase64()
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

        private void btnCode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(tbxValue.Text);
                tbxPassWord.Text = Convert.ToBase64String(bytes);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnCode_Click(object sender, EventArgs e)
        {
            try
            {
                string Value = tbxValue.Text.Replace(" ", "+");
                byte[] bytes = Convert.FromBase64String(Value);
                tbxPassWord.Text = Encoding.UTF8.GetString(bytes);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
