using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace Ex_3_KestrelWebHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requires Microsoft.AspNetCore and Microsoft.AspNetCore.Hosting nuget packages
            WebHost
                //Allows to bing various startup arguments
                .CreateDefaultBuilder(args)
                //Specifies that kestrel server will be used. Here you can add configurations with a lambda expression
                .UseKestrel()
                //Mandatory specification of a Startup class
                .UseStartup<Startup>()              
                //Builds the webhost
                .Build()
                //Runs the webhost in an infinite loop (http request listener)
                .Run();
        }
    }
}
