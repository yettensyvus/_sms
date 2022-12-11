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
            if (name_textbox.Text.Length == 0)
            {
                Notification.Alert("Please Enter Username", custom_controls.frm_notification.alertTypeEnum.Warning);
                name_textbox.Focus();
                return;
            }
            if (name_textbox.Text.Length < 5)
            {
                Notification.Alert("Minimum 5 Characters Long", custom_controls.frm_notification.alertTypeEnum.Info);
                name_textbox.Focus();
                return;
            }
            if (password_textbox.Text.Length == 0)
            {
                Notification.Alert("Please Enter Password", custom_controls.frm_notification.alertTypeEnum.Warning);
                password_textbox.Focus();
                return;
            }
            if (password_textbox.Text.Length < 5)
            {
                Notification.Alert("Minimum 5 Characters Long", custom_controls.frm_notification.alertTypeEnum.Info);
                password_textbox.Focus();
                return;
            }
        }
    }
}
