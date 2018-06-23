using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;
using System;
using System.Diagnostics;

namespace Ex_5_DependencyInjectionASPNETCore.Services.Implementations
{
    public class CoffeeKettle : ICoffeMachine
    {
        public void MakeCoffee()
        {
            Debug.WriteLine("Well here we are my friend. Another day at work ... Your kettle...");
        }
    }
}
