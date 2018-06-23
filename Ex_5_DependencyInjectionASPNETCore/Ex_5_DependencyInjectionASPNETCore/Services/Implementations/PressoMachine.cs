using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_5_DependencyInjectionASPNETCore.Services.Implementations
{
    public class PressoMachine : ICoffeMachine
    {
        public void MakeCoffee()
        {
            Debug.WriteLine("Making you an expensive presso. Hope you like it...");
        }
    }
}
