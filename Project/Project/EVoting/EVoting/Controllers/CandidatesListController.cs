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
    public class CandidatesListController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
        }
        // GET: CandidatesList
        public ActionResult CandidatesList()
        {
            connectionString();
            con.Open();
            com.Connection = con;
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

                        cand.Add(c);
                    }
                    ViewData["candidate"] = cand;
                    return View("CandidatesList");
                }
        }
        

        [HttpPost]
        public void AcceptedCandidates()
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * from tbl_candidate where status='Accepted'";
            
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                ViewBag.cand = com.CommandText;
                con.Close();
            }
            else
            {
                con.Close();
                Response.Write("<script>alert('No Record with Accepting status.');</script>");
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