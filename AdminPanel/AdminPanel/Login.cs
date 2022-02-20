using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AdminPanel
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Login()
        {

            InitializeComponent();
            con.ConnectionString = @"data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*            TextboxUsername*/
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_Authentication";
            SqlDataReader dr = com.ExecuteReader();
            
            if (dr.Read())
            {
                if (TextboxUsername.Text.Equals(dr["Username"].ToString()) && TextboxPassword.Text.Equals(dr["Password"].ToString()))
                {
                    this.Hide();
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    
                }
                else
                {
                    MessageBox.Show("Enter Valid Username and Password", "Error");
                }
            }
            con.Close();
        }

            private void bunifuCustomLabel1_Click(object sender, EventArgs e)
            {

            }

            private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
            {
                /*if (Checkbox1.Checked == true)
                {
                    TextboxPassword.Visible = true;
                }*/
            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void ButtonExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void TextboxUsername_Enter(object sender, EventArgs e)
            {

            }

            private void txtUserEnter(object sender, EventArgs e)
            {
                if (TextboxUsername.Text.Equals(@"Username"))
                {
                    TextboxUsername.Text = "";
                }
            }

            private void txtUserLeave(object sender, EventArgs e)
            {
                if (TextboxUsername.Text.Equals(""))
                {
                    TextboxUsername.Text = @"Username";
                }
            }

            private void txtPassEnter(object sender, EventArgs e)
            {
                if (TextboxPassword.Text.Equals(@"Password"))
                {
                    TextboxPassword.Text = "";
                }
            }

            private void txtPassLeave(object sender, EventArgs e)
            {
                if (TextboxPassword.Text.Equals(""))
                {
                    TextboxPassword.Text = @"Password";
                }
            }

        private void chechbox(object sender, EventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {

        }
    }
    }
