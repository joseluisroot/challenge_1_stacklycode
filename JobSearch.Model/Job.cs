using System;
using System.Collections.Generic;
using System.Text;

namespace JobSearch.Model
{
    public class Job
    {
        public int idJob { get; set; }
        public string nameJob { get; set; }
        public string company { get; set; }
        public string place { get; set; }
        public string finalDate { get; set; }
        public string type { get; set; }
        public string description { get; set; }

    }
}
