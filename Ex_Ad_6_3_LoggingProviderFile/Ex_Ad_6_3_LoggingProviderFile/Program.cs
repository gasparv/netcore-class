using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Ex_Ad_6_3_LoggingProviderFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }


        //Package used to log to file is added as a Nuget - it uses ILoggerFactory and ILoggerProvider with Batching logger used in Azure services for logging to file.
        //The source of its particular implementation can be found @ https://github.com/andrewlock/NetEscapades.Extensions.Logging/tree/master/src/NetEscapades.Extensions.Logging.RollingFile
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(conf =>
            {
                conf.AddFile("logs.log");
            })
                .UseStartup<Startup>();
    }
}
