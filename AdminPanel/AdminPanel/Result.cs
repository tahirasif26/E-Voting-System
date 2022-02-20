using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace AdminPanel
{
    public partial class Result : Form
    {
        string con = @"data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string status = "Accepted";
        public Result()
        {
            InitializeComponent();
            showdata();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void showdata()
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {
                string querry = "Select * from tbl_candidate where status=@status";

                SqlCommand cmd = new SqlCommand(querry, connection);
                cmd.Parameters.AddWithValue("@status", status);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    class Voter
    {
        public string VoterID { set; get; }
        public string Voted_For { set; get; }
        public string Voted_As { set; get; }

    }
}
