using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTWetterWeb.UI.Models
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public string findname { get; set; }
        public string country { get; set; }

        public Coord coord { get; set; }
        public int zoom { get; set; }
    }
}
