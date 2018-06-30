using Ex_17_xunit.Definitions;
using Ex_17_xunit.Exceptions;
using System;

namespace Ex_17_xunit.Services
{
    public class PressoMachine : ICoffeeMaker
    {
        public PressoMachine()
        {

        }
        //Publicly exposed method of the PressoMachine - to be called from the employee class.
        public void MakeCoffee()
        {
            StartDutyCycle();
        }

        //Machine specific method - the naming convention does not say that the machine is making a coffe but can is of a contextual benefit.
        //The coffee making process can be later e.g. split to elementary methods, i.e. SelfClean(), IsCoffeeAvailable(), IsIdle(), ...
        private void StartDutyCycle()
        {
            throw new CoffeeTypeNotAllowedException();
            //Console.WriteLine("The presso machine is making your morning surprise :) ...");
        }
    }
}
