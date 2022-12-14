using _sms.methodes;
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
    public partial class frm_database : Form
    {
        public frm_database()
        {
            InitializeComponent();
        }

        private void frm_database_Load(object sender, EventArgs e)
        {
            try
            {
                DBController controller = new DBController();

                string query = "SELECT * FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";

                DataTable dtbl = new DataTable();
                dtbl = controller.ExecuteReader(query);

                foreach (DataRow row in dtbl.Rows)
                {
                    cmb_databaselist.Items.Add(row["name"].ToString());
                }

                cmb_databaselist.StartIndex = 0;
            }
            catch(Exception ex)
            {
                messagebox.frm_messagebox.Show(ex.Message, "Ooops! Check your SQL Server!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                DBController controller = new DBController();

                Program.database_name = cmb_databaselist.Text.ToString();

                if(controller.OpenConection().State == ConnectionState.Open)
                {
                    notification.frm_notification.Alert("Success!", notification.frm_notification.alertTypeEnum.Success);

                    this.Hide();
                    frm_login f = new frm_login();
                    f.Show();
                }
                else
                {
                    notification.frm_notification.Alert("Ooops! Check your database!", notification.frm_notification.alertTypeEnum.Error);
                    cmb_databaselist.Focus();
                }
            }
            catch (Exception ex)
            {
                messagebox.frm_messagebox.Show(ex.Message, "Ooops! Check your SQL Server!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
