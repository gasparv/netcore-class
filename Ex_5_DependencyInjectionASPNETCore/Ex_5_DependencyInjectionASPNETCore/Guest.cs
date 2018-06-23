using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_5_DependencyInjectionASPNETCore
{
    public class Guest
    {
        public ICoffeMachine _CoffeeMachine { get; set; }
        public void MakeCoffee()
        {
            _CoffeeMachine.MakeCoffee();
        }
    }
}
