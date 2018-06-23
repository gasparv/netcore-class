using Ex_5_DependencyInjectionASPNETCore.Services.Definitions;
using System.Diagnostics;

namespace Ex_5_DependencyInjectionASPNETCore.Services.Implementations
{
    public class CapsuleCoffemaker : ICoffeMachine
    {
        public void MakeCoffee()
        {
            Debug.WriteLine("Making you a hot capsule coffee.");
        }
    }
}
