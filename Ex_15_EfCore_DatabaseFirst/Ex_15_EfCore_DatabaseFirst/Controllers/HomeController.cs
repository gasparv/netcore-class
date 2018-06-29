using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_15_EfCore_DatabaseFirst.Models;
using Ex_15_EfCore_DatabaseFirst.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Ex_15_EfCore_DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly db1007848_coffeeContext _db;
        public HomeController(db1007848_coffeeContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var model = _db.Coffee.Include(x => x.EmployeeCoffee).ThenInclude(x => x.Employee);
            return View(model);
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
