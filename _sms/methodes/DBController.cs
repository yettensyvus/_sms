using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sms.methodes
{
    internal class DBController
    {
        SqlConnection connection;

        public SqlConnection OpenConection()
        {
            connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = " + Program.database_name + "; Integrated Security = True");

            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
                else
                {
                    connection.Open();
                }
            }
            catch(Exception ex)
            {
                messagebox.frm_messagebox.Show(ex.Message, "Ooops! Something is wrong!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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


        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, OpenConection());
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool ExecuteParameter(string query, string name, SqlDbType type, string value)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, OpenConection());
                SqlParameter parameter = new SqlParameter(name, type);
                parameter.Value = value;
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
