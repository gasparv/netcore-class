using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ex_7_1_ConfiguringMiddleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAuthorization();
        }


        //This function has been set to ConfigureDevelopment, in order to prevent the application from running the middleware that is not defined
        //in the env.IsDevelopment() condition. This would have different oucomes by means of routes and terminating middleware
        //UseMvc is generally a termination middleware
        public void ConfigureDevelopment(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }


        //Middleware function that does not call next middleware - is terminal delegate
        private static void FirstMiddlewareDelegate(IApplicationBuilder app)
        {
            
            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("First middleware is writing the response \n");
                Console.WriteLine("FIRST MIDDLEWARE WAS CALLED");
            });
            
        }

        //Middleware function that invokes next delegate
        private static void SecondMiddlewareDelegate(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second middleware is writing the response \n");

                await next.Invoke();
                Console.WriteLine("SECOND MIDDLEWARE WAS CALLED");
            });

        }

        //Middleware function that does not call next middleware - is terminal delegate
        private static void ThirdMiddlewareDelegate(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Third middleware is writing the response \n");
                Console.WriteLine("THIRD MIDDLEWARE WAS CALLED");
            });
        }

        //Production configuration function to separate middleware execution from development entirely
        public void ConfigureProduction(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsProduction())
            {
                //Conditional terminating middleware - exception ocurrence is the execution predicate
                app.UseExceptionHandler("/Home/Error");


                //Terminating middleware with direct path mapping
                app.Map("/alpha", FirstMiddlewareDelegate);
                //Non-terminating middleware with conditional execution
                app.UseWhen(context => context.Request.Query.ContainsKey("beta"), SecondMiddlewareDelegate);
                // Terminating middleware with conditional execution
                app.MapWhen(context => context.Request.Query.ContainsKey("gamma"), ThirdMiddlewareDelegate);

                //Last middleware in pipeline executes if the middleware beforehand do not terminate the pipeline execution.
                app.Run(async context =>
                {
                    await context.Response.WriteAsync("Production environment has not yet been set.");
                });
            }
        }
    }
}
