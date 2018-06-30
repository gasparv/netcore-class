using Ex_17_xunit.Definitions;
using System;

namespace Ex_17_xunit.Services
{
   public class CapsuleCoffeemaker : ICoffeeMaker
    {
        public CapsuleCoffeemaker()
        {

        }
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
