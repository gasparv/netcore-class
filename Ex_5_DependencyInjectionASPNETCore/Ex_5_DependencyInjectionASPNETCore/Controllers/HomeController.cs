using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_5_DependencyInjectionASPNETCore.Models;
using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;
using Microsoft.Extensions.Logging;
using Ex_5_DependencyInjectionASPNETCore.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Ex_5_DependencyInjectionASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceProvider _serviceProvider;
        public HomeController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IActionResult Index()
        {
            IEnumerable<ICoffeMachine> services = _serviceProvider.GetServices<ICoffeMachine>();

            Employee Janci = new Employee(services.FirstOrDefault(x=>typeof(CoffeeKettle) == x.GetType()));
            Janci.MakeCoffee();

            Guest Jozi = new Guest();
            Jozi._CoffeeMachine = services.FirstOrDefault(x => typeof(CapsuleCoffemaker) == x.GetType());
            Jozi.MakeCoffee();

            Owner theBoss = new Owner();
            theBoss.MakeCoffee(services.FirstOrDefault(x => typeof(PressoMachine) == x.GetType()));

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
