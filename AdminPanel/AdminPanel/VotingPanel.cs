using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;


namespace AdminPanel
{
    public partial class VotingPanel : Form
    {
        string Status_On = "ON";
        string Status_OFF = "OFF";
        string con = @"data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private int h, m, s=60;
        //int hr,sec, min;
        public VotingPanel()
        {
            InitializeComponent();
        }

        private void VotingPanel_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Start.Enabled = false;
            this.Stop.Enabled = true;
            h = this.comboBox1.SelectedIndex+1;
            m = this.comboBox2.SelectedIndex;
            timer1.Start();

            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {

                string querry = "Update tbl_Election_Status Set Status=@Status";
                SqlCommand cmd = new SqlCommand(querry, connection);
                cmd.Parameters.AddWithValue("@Status", Status_On);


                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Voting Started Successfully");
                }
                else
                {
                    MessageBox.Show("Voting didn't started");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Stop.Enabled = false;
            this.Start.Enabled = true;

            timer1.Stop();

            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            try
            {
                
                string querry = "Update tbl_Election_Status Set Status=@Status";
                SqlCommand cmd = new SqlCommand(querry, connection);
                cmd.Parameters.AddWithValue("@Status", Status_OFF);
                

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Voting Finshed Successfully");
                }
                else
                {
                    MessageBox.Show("Voting Finshed Unsuccessfully");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            
            if (s < 0)
            {
                s = 59;
                m--;
            }
            
            if (m < 0)
            {
                m = 59;
                h--;

            }
            if (h < 0)
            {
                timer1.Stop();
            }
            SecLabel.Text = s.ToString();
            MinLabel.Text = m.ToString();
            /*s++;
            SecLabel.Text = s.ToString();
            if (s >= 60)
            {
                s = 0;
                m++;
            }
            MinLabel.Text = m.ToString();
            if (m >= 60)
            {
                m = 0;
                h++;

            }*/
            /*if (m == min)
            {
                timer1.Stop();
            }*/
            HrLabel.Text = h.ToString();
        }
    }
}
