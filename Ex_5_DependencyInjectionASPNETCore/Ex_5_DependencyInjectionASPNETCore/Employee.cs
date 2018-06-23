using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;

namespace Ex_5_DependencyInjectionASPNETCore
{
    public class Employee
    {
        private readonly ICoffeMachine _coffeeMachine;
        public Employee(ICoffeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }
        public void MakeCoffee()
        {
            _coffeeMachine.MakeCoffee();
        }
    }
}
