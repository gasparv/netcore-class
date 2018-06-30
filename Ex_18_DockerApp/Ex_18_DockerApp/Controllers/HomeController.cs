using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_18_DockerApp.Models;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Ex_18_DockerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _conf;
        public HomeController(IConfiguration conf)
        {
            _conf = conf;
        }
        public IActionResult Index()
        {
            SqlConnection conn = new SqlConnection(_conf.GetConnectionString("DockerConnection"));
            conn.Open();
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
