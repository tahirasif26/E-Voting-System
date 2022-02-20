using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EVoting.Models;

namespace EVoting.Controllers
{
    public class CandidatesRegistrationController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: CandidatesRegistration
        public ActionResult CandidatesRegistration()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
        }
        [HttpPost]
        public ActionResult CandidateDetails(CandidateList cand)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            Register reg = ViewData["mydata"] as Register;
            cand.name = Session["username"].ToString();
            cand.id = Session["rollno"].ToString();
            cand.status = "Pending";
            cand.votes = 0;
            com.CommandText = "Insert into tbl_candidate (name,id,email,pno,position,cgpa,past_exp,status,votes) VALUES ('" + cand.name + "','" + cand.id + "','" + cand.email + "','" + cand.pno + "','" + cand.position + "','" + cand.cgpa + "','" + cand.past_exp + "','" + cand.status + "','"+cand.votes+"')";


            dr = com.ExecuteReader();
            if (dr.Read())
            {
                ViewData["mydata"] = cand;
                con.Close();
                Response.Write("<script>alert('Your Request not Send');</script>");
                return View("CandidatesRegistration");
                //return View("CandidateDetails");
            }
            else
            {
                ViewData["mydata"] = cand;
                con.Close();
                Response.Write("<script>alert('Your Request Successfully Send');</script>");
                //return View("CandidateDetails");
                return View("CandidatesRegistration");
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