using Ex_17_xunit.Definitions;
using Ex_17_xunit.Exceptions;
using Ex_17_xunit.Services;

namespace Ex_17_xunit.Models
{
    public class Employee
    {
        //Private readonly instance of the ICoffeeMaker to be injected within the newly instantiated employee.
        //This variable and the constructor perform a so called constructor injection method.
        //Interface provides possible implementation for various types of different ICoffeeMaker polymorphed classes
        private readonly ICoffeeMaker _coffeeMaker;
        public Employee(ICoffeeMaker coffeeMaker)
        {
            _coffeeMaker = coffeeMaker;
        }

        //Exposed public property of the employee to enable his ability to make his coffee.
        public void MakeCoffee()
        {
            //Invoke the MakeCoffee method of the 
            _coffeeMaker?.MakeCoffee();
        }
    }
}
