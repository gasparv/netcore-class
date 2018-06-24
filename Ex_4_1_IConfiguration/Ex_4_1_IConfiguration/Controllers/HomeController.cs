using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_4_1_IConfiguration.Models;
using Microsoft.Extensions.Configuration;

namespace Ex_4_1_IConfiguration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {

            //One way to retrieve the configuration item is by using the tree syntax with plain text key identifiers
            string apiKey = _configuration["WeatherApiSettings:WeatherApiKey"].ToString();

            //Second approach is to use the GetSection and GetValue methods also with the plain text key identifiers
            int apiVersion = _configuration.GetSection("WeatherApiSettings").GetValue<int>("WeatherApiVersion");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
