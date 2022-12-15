using _sms.methodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sms
{
    public partial class frm_management : Form
    {
        public frm_management()
        {
            InitializeComponent();
        }

        private void frm_management_Load(object sender, EventArgs e)
        {
            try
            {
                DBController controller = new DBController();

                frm_dashboard f = new frm_dashboard();

                string query =  "SELECT role, COUNT( id_user) AS count FROM users_view " +
                                "WHERE (role = 'admin') OR (role = 'teacher') OR (role = 'student')" +
                                "GROUP BY role";

                DataTable dtbl = new DataTable();
                dtbl = controller.ExecuteReader(query);

                foreach (DataRow row in dtbl.Rows)
                {
                    if (row["role"].ToString() == "admin")
                    {
                        lbl_admins_count.Text = row["count"].ToString();
                    }
                    if (row["role"].ToString() == "teacher")
                    {
                        lbl_teachers_count.Text = row["count"].ToString();
                    }
                    if (row["role"].ToString() == "student")
                    {
                        lbl_students_count.Text = row["count"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                messagebox.frm_messagebox.Show(ex.Message, "Alert! Somethig is wrong!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_admins_list_Click(object sender, EventArgs e)
        {
            frm_admin_list f = new frm_admin_list();
            frm_dashboard frm_ = new frm_dashboard();
            frm_.OpenChildForm(f, pnl_child);
        }

    }
}
