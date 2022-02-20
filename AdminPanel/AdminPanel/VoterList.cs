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
    public partial class VoterList : Form
    {
        string con = @"data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public VoterList()
        {
            InitializeComponent();
            
        }

        private void VoterList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminLoginDataSet.VotersList' table. You can move, or remove it, as needed.
           /* this.votersListTableAdapter.Fill(this.adminLoginDataSet.VotersList);*/
           // showdata();
            
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                MessageBox.Show("Clicked on delete");
                
            }
        }

        
        private void showdata()
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {
                string querry = "Select * from tbl_register";
                SqlCommand cmd = new SqlCommand(querry,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGrid.DataSource = dt;
            }
            catch(Exception ex)
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
            if (DataGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are u sure to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string rollno;
                    rollno = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["RollNoColumn"].Value);
                    /*MessageBox.Show(id);*/
                    SqlConnection connection = new SqlConnection(con);
                    connection.Open();
                    try
                    {
                        string querry = "Delete from tbl_register where rollno=@rollno";
                        SqlCommand cmd = new SqlCommand(querry, connection);
                        cmd.Parameters.AddWithValue("@rollno", rollno);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Data not Deleted");
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
            if (DataGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                string rollno, username, section, batch, degree, phonenumber, cnic, password;
                rollno = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["RollNoColumn"].Value);
                username = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["usernameColumn"].Value);
                section = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["sectionColumn"].Value);
                batch = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["batchColumn"].Value);
                degree= Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["degreeColumn"].Value);
                phonenumber = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["phonenumberColumn"].Value);
                cnic =  Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["cnicColumn"].Value);
                password = Convert.ToString(DataGrid.Rows[e.RowIndex].Cells["passwordColumn"].Value);
                Update obj = new Update(rollno, username, section, batch, degree, phonenumber, cnic, password);
                obj.Show();
            }
                
        }

        private void VoterList_Activated(object sender, EventArgs e)
        {
            showdata();
        }

        private void DataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard obj = new Dashboard();
            obj.Show();
        }
    }
}
