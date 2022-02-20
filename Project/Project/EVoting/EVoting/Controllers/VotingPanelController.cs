using EVoting.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EVoting.Controllers
{
    public class VotingPanelController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]

        // GET: VotingPanel
        public ActionResult VotingPanel()
        {
            connectionString();
            con.Open();
            com.Connection = con;
            //com.CommandText = "SELECT * from tbl_register where isVote='true' and rollno= '" + Session["rollno"].ToString() + "'";
            com.CommandText = "SELECT * from tbl_Election_Status where status='ON'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                com.CommandText = "SELECT * from tbl_register where isVote='true' and rollno= '" + Session["rollno"].ToString() + "'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    return View("AlreadyVoted");
                    dr.Close();
                }
                else
                {
                    con.Close();
                    dr.Close();
                    con.Open();
                    com.Connection = con;

                    com.CommandText = "SELECT * from tbl_candidate where status='Accepted'";
                    List<CandidateList> cand = new List<CandidateList>();
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows == false)
                        {
                            Response.Write("<script>alert('Could not find data');</script>");
                            return View("VotingPanel");
                        }
                        while (reader.Read())
                        {
                            var c = new CandidateList();
                            c.name = reader["name"].ToString();
                            c.id = reader["id"].ToString();
                            c.pno = reader["pno"].ToString();
                            c.position = reader["position"].ToString();
                            c.status = reader["status"].ToString();
                            c.past_exp = reader["past_exp"].ToString();
                            c.email = reader["email"].ToString();
                            c.votes = Convert.ToInt32(reader["votes"]);
                            cand.Add(c);
                        }
                        ViewData["candidate"] = cand;
                        return View("VotingPanel");
                    }
                }

            }
            else
            {
                return View("NotFound");
            }



        }

        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
        }

        [HttpPost]
        public void voting(string ans)
        {
            string[] a = ans.Split(',');
            List<CandidateList> cand = new List<CandidateList>();
            connectionString();
            con.Open();
            com.Connection = con;
            CandidateList vote = new CandidateList();
            vote.name = a[0];
            vote.id = a[1];
            vote.position = a[2];
            vote.votes = Convert.ToInt32(a[3]) + 1;

            com.CommandText = "Update tbl_register SET isVote='true' where rollno =('" + Session["rollno"].ToString() + "')";
            dr = com.ExecuteReader();
            dr.Close();

            com.CommandText = "UPDATE tbl_Candidate SET votes =('" + vote.votes + "')  WHERE id=('" + vote.id + "') and  position=('" + vote.position + "')  ";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                Response.Write("<script>alert('Record successfully not add');</script>");
            }
            else
            {
                con.Close();
                Response.Write("<script>alert('Record successfully add');</script>");
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}