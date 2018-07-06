using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Ex_Ad_6_1_GenericHost
{
    class Program
    {
        //async task main can be used within c# 7.1
        static async Task Main(string[] args)
        {
            /*
           * There are two types of Hosts available in .NET Core.
           * 1. Generic host - HostBuilder by IHostBuilder (Microsoft.Extensions.Hosting) @ https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-2.1
           * 2. Web host - WebHostBuilder by IWebHostBuilder (Microsoft.AspNetCore.Hosting) @ https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host?view=aspnetcore-2.1&tabs=aspnetcore2x
           * 
           * Generic host does not take care of HTTP requests by default and does not provide an extension method for Startup class. 
           * This is why all services need to be configures in context of the hostbuilder object.
           * Example of Generic host configuration can be found @ https://www.stevejgordon.co.uk/using-generic-host-in-dotnet-core-console-based-microserviceshttps://www.stevejgordon.co.uk/using-generic-host-in-dotnet-core-console-based-microservices
           * 
           * Extension method for various built-it services are in:
           * a) Microsoft.Extensions.DependencyInjection
           * b) Microsoft.EntityFramework - AddDbContext
           * c) Microsoft.Extensions.Configuration.*
           * d) Microsoft.Extensions.Logging.*
           */


            //var iocContainer = new ContainerBuilder();

            var host = new HostBuilder().ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                //Sets the base path for configuration entries
                configuration.SetBasePath(Environment.CurrentDirectory);
                //Creates a new configuration settings file provider in specified location -> the environment specific build folder
                configuration.SetFileProvider(new Microsoft.Extensions.FileProviders.PhysicalFileProvider(Environment.CurrentDirectory, Microsoft.Extensions.FileProviders.Physical.ExclusionFilters.System));

                //Adds a json file as a configuration entry provider
                configuration.AddJsonFile($"appsettings.json", true);
                //Can configure environment variable prefix with delegate option Prefix or second overload with string prefix
                //According to docs, the prefix is removed @ runtime.
                configuration.AddEnvironmentVariables();


                if (hostingContext.HostingEnvironment.IsDevelopment())
                {
                    //Adds a json file as a configuration entry provider
                    configuration.AddJsonFile($"appsettings{hostingContext.HostingEnvironment.EnvironmentName}.json", true);
                }

                // Adds an in memory collection of setting entries using a string-string dictionary
                configuration.AddInMemoryCollection(new Dictionary<string, string>() {
                        {"MAX_COFFEE_MAKING_TIME", "10"},
                        {"MIN_COFFEE_AMOUNT", "1"}
                    });
            })


                //Same possibilities for configuration as in ConfigureAppConfiguration. The difference is that the Host itself is aware of the configuration - not only the application.
                .ConfigureHostConfiguration(hostConfiguration =>
                {
                    hostConfiguration.AddCommandLine(args);
                })


                // Adds services to the native .NET Core IoC container
                // Other IoC service providers (Autofac, DryIOC, LightInject, StructureMap) can be used -> for their implementation see https://dotnetcoretutorials.com/2017/03/30/third-party-dependency-injection-asp-net-core/
                // Implementing Windsor is not fairly straightforward, although the support exists -> for implementaion see https://github.com/fir3pho3nixx/Windsor/blob/aspnet-core-windsor-final/docs/aspnetcore-facility.md
                .ConfigureServices((hostingContext, services) =>
                {
                    services.AddOptions();
                    services.Configure<CoffeeSettings>(hostingContext.Configuration.GetSection("CoffeeSettings"));
                    services.AddLogging();
                    services.AddDbContext<DatabaseContext>(dbContextOptions =>
                    {
                        dbContextOptions.UseSqlServer("Connection string that should be inserted to a configuration file ... e.g. appsettings.json");
                    }
                    );
                    services.AddSingleton<IHostedService, CoffeeWorkerService>();

                })

                .ConfigureLogging((hostingContext, loggingExtension) =>
                {
                    //Configures the logging
                    loggingExtension.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    //Configures the console as the target of the logging
                    loggingExtension.AddConsole();
                    //Configures the debug window as the target of the logging
                    loggingExtension.AddDebug();
                })


                //Properties of the hostbuilder - Specified default directory for the Host to search files in
                .UseContentRoot(Directory.GetCurrentDirectory())

                //Sets the environment variable ASPNETCORE_ENVIRONMENT
                .UseEnvironment("Production")
                ;
            await host.RunConsoleAsync();
            
        }
    }
}
