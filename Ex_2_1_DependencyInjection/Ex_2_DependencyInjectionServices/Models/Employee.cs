using Ex_2_1_DependencyInjectionServices.Services;

namespace Ex_2_1_DependencyInjectionServices.Models
{
    public class Employee
    {

        //Private readonly instance of the PressoMachine to be injected within the newly instantiated employee.
        //This variable and the constructor perform a so called constructor injection method.
        private readonly PressoMachine _pressoMachine;
        public Employee(PressoMachine pressoMachine)
        {
            _pressoMachine = pressoMachine;
        }

        //Exposed public property of the employee to enable his ability to make his coffee.
        public void MakeCoffee()
        {
            //Invoke the MakeCoffee method of the 
            _pressoMachine.MakeCoffee();
        }
    }
}
