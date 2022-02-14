using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NTWetterWeb.UI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NTWetterWeb.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
         
        }

        public IActionResult Index()
        {

            return View();
        }

       
        public IActionResult WetterGet(string city)
        {

            var client = new RestClient("http://localhost:8559/api/Wetter?city="+city);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<ApiResponse>(response.Content);

                if (content.Code == 200)
                {

                    var custs = JsonConvert.DeserializeObject<WetterResponseViewModel>(content.Set.ToString());


                    return Json(custs);
                }
                else if(content.Code == 300) {

                    return Json("1");
                }
                else
                {
                    return Json("0");
                }
            }

            return Json("0");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
