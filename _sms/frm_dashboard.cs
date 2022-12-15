using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sms
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        int lx, ly;
        int sw, sh;

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btn_max.Visible = false;
            btn_normal.Visible = true;
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btn_normal.Visible = false;
            btn_max.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (messagebox.frm_messagebox.Show("Do you want to logout?", "Oooops!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frm_login fm = new frm_login();
                fm.Show();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (messagebox.frm_messagebox.Show("Do you want to exit?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btn_toggle_Click(object sender, EventArgs e)
        {
            if (pnl_drawer.Width > 50)
            {
                pnl_drawer.Width = 50;
                pnl_toggle.BackColor = Color.FromArgb(11, 11, 11);
                pnl_user_data.Height = 50;
                pic_user.Hide();
                lbl_username.Visible = false;

            }
            else
            {
                pnl_drawer.Width = 200;
                pnl_toggle.BackColor = Color.FromArgb(32, 32, 36);
                pnl_user_data.Height = 240;
                pic_user.Show();
                lbl_username.Visible = true;
            }
        }
    }
}
