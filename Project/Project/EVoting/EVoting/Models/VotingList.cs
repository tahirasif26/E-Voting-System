using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EVoting.Models
{
    public class VotingList
    {
        public string Cand_name { get; set; }
        public string Cand_id { get; set; }
        public string Cand_position { get; set; }
        public string Voters_name { get; set; }
        public int Voters_id { get; set; }

    }
}