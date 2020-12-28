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
    public partial class frmGUID : Form
    {
        public frmGUID()
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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbxFilePath.SelectAll();
            tbxFilePath.Copy();
        }

        private void tbxFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                tbxResult.Clear();
                for (int i = 0; i < nbdCount.Value; i++)
                {
                    string NewGUID = "";
                    string[] Values = tbxFormat.Text.Split('&');
                    foreach (string item in Values)
                    {
                        if (item.ToUpper() == "N" || item.ToUpper() == "D" || item.ToUpper() == "B" || item.ToUpper() == "P" || item.ToUpper() == "X")
                            NewGUID += Guid.NewGuid().ToString(item);
                        else NewGUID += DateTime.Now.ToString(item);
                    }
                    if (i <= 0) tbxFilePath.Text = NewGUID;
                    tbxResult.AppendText(NewGUID + "\r\n");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error", Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
