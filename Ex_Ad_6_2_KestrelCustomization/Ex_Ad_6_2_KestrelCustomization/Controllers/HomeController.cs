using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex_Ad_6_2_KestrelCustomization.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            string secretKey= _config.GetValue<string>("SecretApiKey");
            return View();
        }
    }
}
