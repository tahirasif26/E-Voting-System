using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using EVoting.Models;
using System.Data;
using System.Web.Security;

namespace EVoting.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
        }
        //string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        //SqlConnection con = new SqlConnection(strcon);

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Register acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            var valueBytes = Encoding.UTF8.GetBytes(acc.password);
            var decodedPass = Convert.ToBase64String(valueBytes);
            com.CommandText = "SELECT * from tbl_register where rollno='" + acc.rollno + "' and password='" + decodedPass + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                var register = new Register();
                register.name = dr["username"].ToString();
                register.rollno = dr["rollno"].ToString();
                register.pno = dr["phonenumber"].ToString();
                register.cnic = dr["cnic"].ToString();
                register.batch = dr["batch"].ToString();
                register.section = dr["section"].ToString();
                register.degree = dr["degree"].ToString();
                Session["username"] = dr["username"].ToString();
                Session["rollno"] = dr["rollno"].ToString();

                ViewData["Message"] = register;
                ViewData["user"] = register;
                TempData["mydata"] = register;
                con.Close();
                return View("Create");
            }
            else
            {
                con.Close();
                Response.Write("<script>alert('Incorrect NU ID or Password');</script>");
                return View("Login");
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