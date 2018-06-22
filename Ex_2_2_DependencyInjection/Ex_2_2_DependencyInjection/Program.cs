using Ex_2_2_DependencyInjectionServices.Definitions;
using Ex_2_2_DependencyInjectionServices.Models;
using Ex_2_2_DependencyInjectionServices.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Ex_2_2_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceCollection class is a part of Microsoft.Extensions.DependencyInjection assembly
            //IServiceCollection interface is a part of Microsoft.Extensions.DepenedencyInjection.Abstractions assembly

            //Create an instance of ServiceCollection used in the application
            IServiceCollection svcCollection = new ServiceCollection();

            //Add new services to an existing collection with selected lifetime. The interface provides a common implementation standards for various services
            svcCollection.AddScoped<ICoffeeMaker, PressoMachine>();
            svcCollection.AddScoped<ICoffeeMaker, CapsuleCoffeemaker>();

            //Create and build a service provider
            var provider = svcCollection.BuildServiceProvider();


            // Janci is a company's employee. Between the company and an employee there is a weak relationship (no pun intended :) )
            // In ideal case, we would have a class describing companies/company with its set of objects - employees, also set with DI - association relation.

            //We can select the service with the employee will use if he wants to make a coffee
            Employee janciTheEmployee = new Employee(provider.GetServices<ICoffeeMaker>().FirstOrDefault(x=>x.GetType() == typeof(CapsuleCoffeemaker)));

            //Invokes the method within Janci to make him a decent coffee.
            janciTheEmployee.MakeCoffee();

            Console.Read();
        }
    }
}
