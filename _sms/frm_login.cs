using _sms.methodes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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

            try 
            {
                DBController controller = new DBController();

                frm_dashboard f = new frm_dashboard();

                string query = "SELECT * FROM users_view WHERE username = '" + txt_username.Text.Trim() + "' AND password = '" + AesCrypt.Encrypt(txt_password.Text.Trim()) + "'";

                DataTable dtbl = new DataTable();
                MemoryStream ms = new MemoryStream();
                byte[] x = null;

                dtbl = controller.ExecuteReader(query);

                if (dtbl == null)
                {
                    notification.frm_notification.Alert("Check your username and password", notification.frm_notification.alertTypeEnum.Error);
                    link_forgot.Visible = true;
                    return;
                }

                if (dtbl.Rows.Count == 1 && dtbl.Rows[0]["role"].ToString() == "admin")
                {
                    Program.frm_state = "Admin";
                    Program.user_name = dtbl.Rows[0]["full_name"].ToString();

                    x = (byte[])dtbl.Rows[0]["photo"];
                    ms = new MemoryStream(x);
                    f.pic_user.BackgroundImage = Image.FromStream(ms);
                    f.pic_user.Image = Image.FromStream(ms);

                    f.lbl_username.Text = Program.user_name;

                    this.Hide();
                    f.Show();
                }

                if (dtbl.Rows.Count == 1 && dtbl.Rows[0]["role"].ToString() == "teacher")
                {
                    Program.frm_state = "Teacher";
                    Program.user_name = dtbl.Rows[0]["full_name"].ToString();

                    x = (byte[])dtbl.Rows[0]["photo"];
                    ms = new MemoryStream(x);
                    f.pic_user.BackgroundImage = Image.FromStream(ms);
                    f.pic_user.Image = Image.FromStream(ms);

                    f.lbl_username.Text = Program.user_name;

                    this.Hide();
                    f.Show();
                }

                if (dtbl.Rows.Count == 1 && dtbl.Rows[0]["role"].ToString() == "student")
                {
                    Program.frm_state = "Student";
                    Program.user_name = dtbl.Rows[0]["full_name"].ToString();

                    x = (byte[])dtbl.Rows[0]["photo"];
                    ms = new MemoryStream(x);
                    f.pic_user.BackgroundImage = Image.FromStream(ms);
                    f.pic_user.Image = Image.FromStream(ms);

                    f.lbl_username.Text = Program.user_name;

                    this.Hide();
                    f.Show();
                }
            }

            catch (Exception ex)
            {
                messagebox.frm_messagebox.Show(ex.Message, "Ooops! Somethig is wrong!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
