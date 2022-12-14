using System;
using System.Windows.Forms;

namespace _sms
{
    internal static class Program
    {
        public static string database_name = "school_management";
        public static string frm_state;
        public static string user_name;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_database());
        }
    }
}
