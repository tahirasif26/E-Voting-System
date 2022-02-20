using EVoting.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EVoting.Controllers
{
    public class VotingResultController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: VotingResult
        public ActionResult VotingResult()
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
                com.CommandText = "SELECT * from tbl_candidate where status='Accepted'";
                List<CandidateList> cand = new List<CandidateList>();
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    if (reader.HasRows == false)
                    {
                        Response.Write("<script>alert('Could not find data');</script>");
                        return View("CandidatesList");
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
                    ViewData["candidateresult"] = cand;
                    return View();
                }
                dr.Close();
                con.Close();
            }
            else
            {
                return View("NoStarted");
                dr.Close();
            }
            
        }

        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
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