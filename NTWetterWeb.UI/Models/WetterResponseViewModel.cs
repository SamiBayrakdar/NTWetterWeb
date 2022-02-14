using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTWetterWeb.UI.Models
{
    public class WetterResponseViewModel
    {
        public City city { get; set; }
        public Time time { get; set; }

        public Main main { get; set; }

        public Wind wind { get; set; }

        public Clouds clouds { get; set; }
        public List<Weather> weather { get; set; }
    }
}
