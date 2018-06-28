using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_12_ViewComponents.ViewComponents
{
    [ViewComponent]
    public class CurrentTimeViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Time",DateTime.Now.ToShortTimeString());
        }
    }
}
