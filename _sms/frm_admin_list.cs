using _sms.methodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sms
{
    public partial class frm_admin_list : Form
    {
        public frm_admin_list()
        {
            InitializeComponent();
        }

        private void frm_admin_list_Load(object sender, EventArgs e)
        {
            try
            {
                DBController controller = new DBController();

                string query = "SELECT * FROM users_view";

                DataTable dtbl = new DataTable();

                dtbl = controller.ExecuteReader(query);

                data_grid.DataSource = dtbl;

            }
            catch (Exception ex)
            {
                messagebox.frm_messagebox.Show(ex.Message, "Alert! Somethig is wrong!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            frm_management f = new frm_management();
            frm_dashboard frm_ = new frm_dashboard();
            frm_.OpenChildForm(f, pnl_child);
        }
    }
}
