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
    public partial class frmIcon : Form
    {
        public frmIcon()
        {
            InitializeComponent();
            btnIcon.Tag = true;
            MinimumSize = new Size(Width, pnlIcon.Height);
            int MaxHeight = pnlIcon.Height + lb1.Height + pnlMenu.Padding.Top + pnlMenu.Padding.Bottom + 2;
            foreach (Control item in pnlMenu.Controls) MaxHeight += item.Height;
            MaximumSize = new Size(Width, MaxHeight);
            btnIcon_MouseLeave(btnIcon, null);
            lbFileMD5.Tag = new frmFileMD5();
            lbDUID.Tag = new frmGUID();
            lbRandom.Tag = new frmRandom();
            lbRegex.Tag = new frmRegex();
            lbBase64.Tag = new frmBase64();
        }

        private bool IsDown = false;

        private Point CurrentPosition = new Point(0, 0);

        private void TimerOpen_Tick(object sender, EventArgs e)
        {
            TopMost = true;
            bool IsOpen = Convert.ToBoolean(btnIcon.Tag);
            int Speed = 15;
            int height = Height;
            if (IsOpen)
            {
                height = Height + Speed;
                if (height >= MaximumSize.Height)
                {
                    height = MaximumSize.Height;
                    TimerOpen.Enabled = false;
                }

            }
            else
            {
                height = Height - Speed;
                if (height <= MinimumSize.Height)
                {
                    height = MinimumSize.Height;
                    TimerOpen.Enabled = false;
                }
            }
            Height = height;
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

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnIcon.Tag = true;
            TimerOpen.Enabled = true;
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_Click(object sender, EventArgs e)
        {
            if (sender is Label lb && lb.Tag is Form f)
            {
                btnIcon.Tag = false;
                TimerOpen.Enabled = true;
                f.ShowDialog();
            }
        }

        private void btnIcon_MouseEnter(object sender, EventArgs e)
        {
            btnIcon.Tag = true;
            TimerOpen.Enabled = true;
        }

        private void btnIcon_MouseLeave(object sender, EventArgs e)
        {
            btnIcon.Tag = false;
            TimerOpen.Enabled = true;
        }
    }
}
