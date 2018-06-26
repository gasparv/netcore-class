using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_10_DefaultTagHelpers.Models;
using Microsoft.AspNetCore.Http;

namespace Ex_10_DefaultTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View(new DemonstrationTagHelperViewModel());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact(string contactName)
        {
            if(String.IsNullOrEmpty(contactName))
                ViewData["Message"] = $"This is the contact page.";
            else
                ViewData["Message"] = $"This is your contact page {contactName}.";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        /// <summary>
        /// //Action decorated by HttpPost for form submission calling the Index action
        /// </summary>
        /// <param name="data">data sent from the front-end form by submission</param>
        /// <returns>Error status code 418 ImATeapot - just for fun :)</returns>
        [HttpPost]
        public IActionResult Index(DemonstrationTagHelperViewModel model)
        {
            if(ModelState.IsValid)
            return StatusCode(StatusCodes.Status418ImATeapot);
            else
                return StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}
