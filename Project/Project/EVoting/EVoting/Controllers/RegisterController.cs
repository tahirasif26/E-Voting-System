using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using EVoting.Models;
using System.Text.RegularExpressions;

namespace E_Voting.Controllers
{
    public class RegisterController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source =evoting-sqlserver.database.windows.net; database=EVoting-DB; User ID=bilal;Password=admin123/;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
        }
        [HttpPost]
        public void SaveDetails(Register reg)
        {

            if (IsValid_passwordlength(reg.password) == false)
            {
                Response.Write("<script>alert('Password Should be greater than 8 characters');</script>");
            }
            else if (Match_passwords(reg.password, reg.confirm_password) == true)
            {
                Response.Write("<script>alert('Password not matched');</script>");
                //return View("Register");
            }
            else if (IsValid_rollno(reg.rollno) == false)
            {
                Response.Write("<script>alert('NU ID pattren is incorrect');</script>");
            }
            else if (IsValid_pno(reg.pno) == false)
            {
                Response.Write("<script>alert('Phone number pattren is incorrect');</script>");
            }
            else if (IsValid_CNIC(reg.cnic) == false)
            {
                Response.Write("<script>alert('CNIC number pattren is incorrect');</script>");
            }
            else
            {
                connectionString();
                con.Open();
                com.Connection = con;
                var valueBytes = Encoding.UTF8.GetBytes(reg.password);
                var pass = Convert.ToBase64String(valueBytes);
                
                com.CommandText = "INSERT INTO tbl_register (rollno, username, section, batch, degree, phonenumber, cnic, password,isVote) VALUES ('" + reg.rollno + "','" + reg.name + "','" + reg.section + "','" + reg.batch + "','" + reg.degree + "','" + reg.pno + "','" + reg.cnic + "','" + pass + "','" + "false" + "'  ) ";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    Response.Write("<script>alert('Record successfully not add');</script>");
                    //return View("Register");
                }
                else
                {
                    con.Close();
                    //return View("Register");
                    Response.Write("<script>alert('Record successfully add');</script>");
                }
            }
            
        }

        private bool IsValid_passwordlength(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Match_passwords(string pass,string con_pass)
        {
            if (pass == con_pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValid_rollno(string rno)
        {
            Regex check = new Regex(@"^[0-9]{2}[K,k,L,l,F,f,I,i]-[0-9]{4}$");
            bool valid = false;
            valid = check.IsMatch(rno);
            return valid;
        }

        private bool IsValid_pno(string pno)
        {
            Regex check = new Regex(@"^[0-9]{11}$");
            bool valid = false;
            valid = check.IsMatch(pno);
            return valid;
        }

        private bool IsValid_CNIC(string cnic)
        {
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(cnic);
            return valid;
        }


    }
}