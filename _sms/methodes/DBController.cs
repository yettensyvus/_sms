using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _sms.methodes
{
    internal class DBController
    {
        SqlConnection connection;

        public SqlConnection OpenConection()
        {
            connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = " + Program.database_name + "; Integrated Security = True");

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
            else
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

    }
}
