using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ex_3_KestrelWebHost
{
    public class Startup
    {
        //Usually IConfiguration and IHostingEnvironment are also injected in the context using the constructor injection method
        //IConfiguration is used to store and load different configurations from a special json configuration file - discussed later in lectures
        //IHostingEnvironment is used to manage hosting environments and behaviour of the application in different deployments (production, staging, development, etc.) - discussed later in lectures
        /*
        public IHostingEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }
        public Startup(IHostingEnvironment env, IConfiguration config)
        {
            HostingEnvironment = env;
            Configuration = config;
        }
        */

        //Requires Microsoft.Extensions.DependencyInjection nuget package
        //This method serves for all service injections in Asp.Net core - notice the IServiceCollection as the input of the method
        public void ConfigureServices(IServiceCollection services)
        {
            //Requires Microsoft.AspNetCore.Mvc nuget package
            //Registers multiple services that allow the usage of Mvc
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            //configures the MVC as a terminating middleware
            app.UseMvc();
        }
    }
}
