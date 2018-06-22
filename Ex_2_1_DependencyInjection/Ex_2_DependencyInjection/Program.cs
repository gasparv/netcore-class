using Ex_2_1_DependencyInjectionServices.Models;
using Ex_2_1_DependencyInjectionServices.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ex_2_1_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceCollection class is a part of Microsoft.Extensions.DependencyInjection assembly
            //IServiceCollection interface is a part of Microsoft.Extensions.DepenedencyInjection.Abstractions assembly

            //Create an instance of ServiceCollection used in the application
            IServiceCollection svcCollection = new ServiceCollection();

            //Add a new service to an existing collection with selected lifetime
            svcCollection.AddScoped<PressoMachine>();

            //Create and build a service provider
            var provider = svcCollection.BuildServiceProvider();

            // Janci is a company's employee. Between the company and an employee there is a weak relationship (no pun intended :) )
            // In ideal case, we would have a class describing companies/company with its set of objects - employees, also set with DI - association relation.
            Employee janciTheEmployee = new Employee(provider.GetService<PressoMachine>());

            //Invokes the method within Janci to make him a decent coffee.
            janciTheEmployee.MakeCoffee();

            Console.Read();
        }
    }
}
