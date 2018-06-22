using Ex_2_2_DependencyInjectionServices.Definitions;
using System;

namespace Ex_2_2_DependencyInjectionServices.Services
{
   public class CapsuleCoffeemaker : ICoffeeMaker
    {
        public void MakeCoffee()
        {
            StartDutyCycle();
        }

        private void StartDutyCycle()
        {
            Console.WriteLine("Distiling some black gold from the capsule :) ...");
        }
    }
}
