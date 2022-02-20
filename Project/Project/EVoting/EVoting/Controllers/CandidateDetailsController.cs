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
    public class CandidateDetailsController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: CandidateDetails
        public ActionResult CandidateStatus()
        {
            connectionString();
            con.Open();
            com.Connection = con;
            List<CandidateList> cand = new List<CandidateList>();
            com.CommandText = "SELECT * from tbl_CandidateList where rollno='" + Session["rollno"].ToString() + "' and status='Pending'";

            using (SqlDataReader reader = com.ExecuteReader())
            {
                if (reader.HasRows == false)
                {
                    Response.Write("<script>alert('Could not find data');</script>");
                    return View("CandidatesRegistration");
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
                ViewData["candidatestatus"] = cand;
                return View();
            }
        }
        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
        }

        [HttpPost]
        public ActionResult CandidateStatuss()
        {
            connectionString();
            con.Open();
            com.Connection = con;
            List<CandidateList> cand = new List<CandidateList>();
            com.CommandText = "SELECT * from tbl_CandidateList where rollno='" + Session["rollno"].ToString() + "' and status='Pending'";

            using (SqlDataReader reader = com.ExecuteReader())
            {
                if (reader.HasRows == false)
                {
                    Response.Write("<script>alert('Could not find data');</script>");
                    return View("CandidatesRegistration");
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
                ViewData["candidatestatus"] = cand;
                return View("CandidateDetails");
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