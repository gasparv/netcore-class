using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;
using Ex_4_2_ConfigurationIOption.Models;

namespace Ex_4_2_ConfigurationIOption.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherApiSettings _configuration;
        public HomeController(IOptions<WeatherApiSettings> configuration)
        {
            _configuration = configuration.Value;
        }
        
        public IActionResult Index()
        {
            string apiKey = _configuration.WeatherApiKey;
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
