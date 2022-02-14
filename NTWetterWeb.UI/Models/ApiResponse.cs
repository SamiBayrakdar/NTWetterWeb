using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTWetterWeb.UI.Models
{
    public class ApiResponse
    {
        public string Message { get; set; }
        public int Code { get; set; }
        public object Set { get; set; }

    }
}
