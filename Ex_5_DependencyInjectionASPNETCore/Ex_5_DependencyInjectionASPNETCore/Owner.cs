using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_5_DependencyInjectionASPNETCore
{
    public class Owner
    {
        public void MakeCoffee(ICoffeMachine _coffeeMachine)
        {
            _coffeeMachine.MakeCoffee();
        }
    }
}
