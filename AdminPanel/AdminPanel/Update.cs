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
    public partial class Update : Form
    {

        string rollno, username, section, batch, degree, phonenumber, cnic, password;
        string con = @"data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        public Update()
        {

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            
            username = Convert.ToString(bunifuMaterialTextbox2.Text);
            section = Convert.ToString(bunifuMaterialTextbox3.Text);
            batch = Convert.ToString(bunifuMaterialTextbox4.Text);
            degree = Convert.ToString(bunifuMaterialTextbox5.Text);
            phonenumber = Convert.ToString(bunifuMaterialTextbox6.Text);
            cnic = Convert.ToString(bunifuMaterialTextbox7.Text);
            password = Convert.ToString(bunifuMaterialTextbox8.Text);

            /*MessageBox.Show(id);*/
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {
                string querry = "Update tbl_register SET username = @username, section=@section, batch=@batch, degree=@degree, phonenumber=@phonenumber, cnic=@cnic,password=@password WHERE rollno=@rollno";
                SqlCommand cmd = new SqlCommand(querry, connection);
                cmd.Parameters.AddWithValue("@rollno", rollno);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@batch", batch);
                cmd.Parameters.AddWithValue("@degree", degree);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@password", password);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Data not Updated");
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

        public Update(string rollno, string username, string section, string batch,string degree, string phonenumber, string cnic, string password)
        {
            InitializeComponent();
            this.rollno = rollno;
            this.username = username;
            this.section = section;
            this.batch = batch;
            this.degree = degree;
            this.phonenumber = phonenumber;
            this.cnic = cnic;
            this.password = password;
        }

        private void Update_Load(object sender, EventArgs e)
        {

            bunifuCustomLabel1.Text = rollno;
            bunifuMaterialTextbox2.Text = username.ToString();
            bunifuMaterialTextbox3.Text = section.ToString();
            bunifuMaterialTextbox4.Text = batch.ToString();
            bunifuMaterialTextbox5.Text = degree.ToString();
            bunifuMaterialTextbox6.Text = phonenumber.ToString();
            bunifuMaterialTextbox7.Text = cnic.ToString();
            bunifuMaterialTextbox8.Text = password.ToString();



        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
