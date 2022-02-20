using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVoting.Models
{
    public class CandidateList
    {
        public string name { get; set; }
        public string id { get; set; }
        public string email { get; set; }
        public string pno { get; set; }
        public string position { get; set; }
        public float cgpa { get; set; }
        public string past_exp { get; set; }
        public string status { get; set; }
        public int votes { get; set; }

    }
}