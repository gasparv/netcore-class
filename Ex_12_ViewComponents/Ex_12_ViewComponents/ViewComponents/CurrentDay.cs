using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_12_ViewComponents.ViewComponents
{
    public class CurrentDay:ViewComponent
    {
        public IViewComponentResult Invoke(DateTime currentDateTime)
        {
            return View("Day",currentDateTime.DayOfWeek.ToString());
        }
    }
}
