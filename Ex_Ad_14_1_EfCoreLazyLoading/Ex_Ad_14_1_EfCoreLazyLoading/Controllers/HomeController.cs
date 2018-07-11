using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_Ad_14_1_EfCoreLazyLoading.Models;
using Ex_Ad_14_1_EfCoreLazyLoading.Data;
using Microsoft.EntityFrameworkCore;
using Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoffeeDbContext _db;
        public HomeController(CoffeeDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ICollection<Coffee> coffees = 
                _db
                .Coffee
                .FromSql("GetCoffeeByCode 'AZET'")
                .AsNoTracking()
                .ToList();
            return View(coffees);
        }

        public IActionResult About()
        {
            IEnumerable<DrinkCoffeesCountView> list = _db.VDrinkCoffees.ToList();
            ViewData["Message"] = "Your application description page.";

            return View(list);
        }

        public IActionResult Contact()
        {
            ICollection<Coffee> coffees = _db.Coffee.ToList();
            ViewData["Message"] = "Your contact page.";

            return View(coffees);
        }

        public IActionResult EFLike()
        {
            //Does not work ... hmmm ... dont know why ... can u fix it?
            var list = _db.Employee.Where(x=>EF.Functions.Like(x.Name, "%a%"));
            return View(list);
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
