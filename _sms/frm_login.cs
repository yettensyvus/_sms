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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (messagebox.frm_messagebox.Show("Do you want to exit?", "Ooops!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                notification.frm_notification.Alert("Please Enter Username", notification.frm_notification.alertTypeEnum.Warning);
                txt_username.Focus();
                return;
            }
            if (txt_username.Text.Length < 5)
            {
                notification.frm_notification.Alert("Minimum 5 Characters Long", notification.frm_notification.alertTypeEnum.Info);
                txt_username.Focus();
                return;
            }
            if (txt_password.Text.Length == 0)
            {
                notification.frm_notification.Alert("Please Enter Password", notification.frm_notification.alertTypeEnum.Warning);
                txt_password.Focus();
                return;
            }
            if (txt_password.Text.Length < 5)
            {
                notification.frm_notification.Alert("Minimum 5 Characters Long", notification.frm_notification.alertTypeEnum.Info);
                txt_password.Focus();
                return;
            }


        }
    }
}
