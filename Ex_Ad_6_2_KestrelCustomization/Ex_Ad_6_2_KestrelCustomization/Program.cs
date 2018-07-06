using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ex_Ad_6_2_KestrelCustomization.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Ex_Ad_6_2_KestrelCustomization
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IWebHost webHost = WebHost.CreateDefaultBuilder(args)
                .CaptureStartupErrors(true)
                .ConfigureServices(services =>
                {
                    services.AddLogging();
                    services.AddHttpContextAccessor();
                })
                .ConfigureAppConfiguration(appConfigs =>
                {
                    // Specifies a configuration entry that is represented by a file. Key is the filename, value is the file content
                    //appConfigs.AddKeyPerFile
                    //This method is to provide secret keys for development purposes in a secure key store locatate on a local machine outside the project
                    //For production purpose, using the Azure Key Vault is the recommended approach
                    appConfigs.AddUserSecrets("7ebc2735-bbdf-472a-9f86-3596895f099e");

                })

                //Mandatory method that specifies the Startup class
                .UseStartup<Startup>()

                //Specifies the folder that contains static files
                .UseWebRoot(Path.Combine(Environment.CurrentDirectory, "staticfiles"))
                //Specifies the folder that contains the entire application
                .UseContentRoot(Environment.CurrentDirectory)
                //Priority of here specified URLs for listening will be higher than convention's
                .PreferHostingUrls(true)


                //Apart from Kestrel, it is possible to use HTTP.sys server instead. It is a windows specific server, thus it is not possible to use this server
                //for cross-platform deployment. It allows Windows Auth

                /*
                
                .UseHttpSys(httpSysOptions =>
                {
                    httpSysOptions.EnableResponseCaching = true;
                    httpSysOptions.RequestQueueLimit = 100;
                    httpSysOptions.MaxRequestBodySize = null;
                    httpSysOptions.MaxConnections = -1;
                })
                
                 */

                //Allows using AspNetCore module within the IIS deployment
                //.UseIISIntegration()
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                    logging.AddDebug();
                })
                
                //.UseCustomServer(options => options.FolderToListen = @"E:\LISTENER_TEST")

                .UseKestrel(kestrelOptions =>
                {
                    //Add server header in the response
                    kestrelOptions.AddServerHeader = true;
                    //Way of scheduling user callbacks. Inline = in current thread ; Default = uses ApplicationScheduler ; ThreadPool = uses multiple threads - threadpool
                    kestrelOptions.ApplicationSchedulingMode = Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions.Internal.SchedulingMode.ThreadPool;

                    //This setting is overriden in launchprofile!!
                    kestrelOptions.ListenAnyIP(5008);
                    //Specify various limits for Kestrel
                    kestrelOptions.Limits.MaxConcurrentConnections = 1000;

                })
                .Build()
                ;
                
            await webHost.RunAsync();
        }

    }
}
