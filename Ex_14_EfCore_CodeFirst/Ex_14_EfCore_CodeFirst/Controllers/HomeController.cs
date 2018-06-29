using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_14_EfCore_CodeFirst.Models;
using Ex_14_EfCore_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Ex_14_EfCore_CodeFirst.Models.DbModels;
using System.Security.Cryptography.X509Certificates;

namespace Ex_14_EfCore_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoffeeDbContext _db;
        private readonly CoffeeDbContextLite _dbLite;
        public HomeController(CoffeeDbContext db, CoffeeDbContextLite dbLite)
        {
            _db = db;
            _dbLite = dbLite;
        }
        public IActionResult Index()
        {
            var model = _db.Coffee.Include(x => x.EmployeeCoffee).ThenInclude(y => y.Employee);
            return View(model);
        }

        public IActionResult About()
        {
            var model = _dbLite.Coffee;
            

            
            return View(model);
        }

        public IActionResult Contact()
        {
            

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
