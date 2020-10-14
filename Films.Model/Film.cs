using System;
using System.Collections.Generic;
using System.Text;

namespace Films.Model
{
    public class Film
    {
        public int id { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public DateTime releaseDate { get; set; }

    }
}
