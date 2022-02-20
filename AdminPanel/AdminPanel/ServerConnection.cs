using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdminPanel
{
    class ServerConnection
    {
        public static string stringConnection = "Data Source=DESKTOP-352LET9\\SQL_EXPRESS; Initial Catalog=LoginDatabse; Integrated Security=True";
        public static DataTable executeSQL(string sql)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);

                connection.Close();
                connection = null;
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " +
                ex.Message, "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dt = null;
            }
            return dt;

        }
    }
}

