using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_6_2_KestrelCustomization.Extensions
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseCustomServer(this IWebHostBuilder hostBuilder, Action<ServerSettings> options)
        {
            return hostBuilder.ConfigureServices(services =>
            {
                services.Configure(options);
                services.AddLogging();
                services.AddSingleton<IServer, CustomServer>();
            });
        }
    }
}
