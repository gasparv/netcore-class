using Ex_2_2_DependencyInjectionServices.Definitions;

namespace Ex_2_2_DependencyInjectionServices.Models
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
