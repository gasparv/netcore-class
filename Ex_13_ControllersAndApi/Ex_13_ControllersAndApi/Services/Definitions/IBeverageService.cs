using Ex_13_ControllersAndApi.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_13_ControllersAndApi.Services.Definitions
{
   public interface IBeverageService
    {
        IEnumerable<Beverage> All();
        Beverage SingleById(int Id);
        Beverage SingleByName(string name);
        IEnumerable<Beverage> FindByName(string name);

    }
}
