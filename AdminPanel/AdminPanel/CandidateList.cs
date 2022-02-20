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

namespace AdminPanel
{
    public partial class CandidateList : Form
    {
        string con = @"data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public CandidateList()
        {
            InitializeComponent();
            
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void showdata()
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {
                string querry = "Select name,id,email,pno,position,cgpa,past_exp,status from tbl_candidate";
                SqlCommand cmd = new SqlCommand(querry, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGrid.DataSource = dt;
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

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].HeaderText == "Approve")
            {
                //DialogResult confirm = MessageBox.Show("Are u sure to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                    string id;
                    id = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["IDColumn"].Value);
                    /*MessageBox.Show(id);*/
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    try
                    {
                    
                        string querry = "Update tbl_candidate Set Status='Accepted' where ID=@id";
                        SqlCommand cmd = new SqlCommand(querry, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show(id + " Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show(id + "not Updated");
                        }
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
            if (DataGrid.Columns[e.ColumnIndex].HeaderText == "Reject")
            {
                //DialogResult confirm = MessageBox.Show("Are u sure to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                string id;
                id = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["IDColumn"].Value);
                /*MessageBox.Show(id);*/
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                try
                {

                    string querry = "Update tbl_candidate Set Status='Rejected' where ID=@id";
                    SqlCommand cmd = new SqlCommand(querry, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(id + " Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show(id + "not Updated");
                    }
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
        }

        private void CandidateList_Activated(object sender, EventArgs e)
        {
            showdata();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard obj = new Dashboard();
            obj.Show();
        }
    }
}
