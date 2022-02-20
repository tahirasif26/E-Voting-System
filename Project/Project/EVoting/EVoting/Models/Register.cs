using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVoting.Models
{
    public class Register
    {
        public string rollno { get; set; }
        public string name { get; set; }
        public string section { get; set; }
        public string degree { get; set; }
        public string batch { get; set; }
        public string pno { get; set; }
        public string cnic{ get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
    }
}