using System;

namespace Ex_2_1_DependencyInjectionServices.Services
{
    public class PressoMachine
    {
        
        //Publicly exposed method of the PressoMachine - to be called from the employee class.
        public void MakeCoffee()
        {
            StartDutyCycle();
        }

        //Machine specific method - the naming convention does not say that the machine is making a coffe but can is of a contextual benefit.
        //The coffee making process can be later e.g. split to elementary methods, i.e. SelfClean(), IsCoffeeAvailable(), IsIdle(), ...
        private void StartDutyCycle()
        {
            Console.WriteLine("The presso machine is making your morning surprise :) ...");
        }
    }
}
