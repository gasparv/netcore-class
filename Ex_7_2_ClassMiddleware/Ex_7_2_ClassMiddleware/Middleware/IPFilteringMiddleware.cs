using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Ex_7_2_ClassMiddleware.Middleware
{
    public class IPFilteringMiddleware
    {
        private readonly RequestDelegate _next;
        public IPFilteringMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        // Injecting of services into Invoke method is the recommended way of passing configurations to Middleware
        //Other parameters should be added as input params within the UseMiddleware method call and handled in the public constructor
        public Task Invoke(HttpContext context, IConfiguration configuration, IHostingEnvironment env)
        {
            //Retirieves a configuration entry from appsettings.json file
            var localSegmentConfig = configuration["AllowedSegments:Local"].ToString();
            
            //Retirieves a configuration entry from appsettings.json file
            var remoteSegmentConfig = configuration["AllowedSegments:Remote"].ToString();

            //Gets the local IP address from the request
            var ip = context.Connection.LocalIpAddress.ToString();
            string[] ipParts = ip.Split('.');
            
            //If environment is development uses the local IP address segment for comparison
            if (env.IsDevelopment())
                return MiddlewareReponse(context, ipParts, localSegmentConfig);

            //If environment is production uses the remote IP address segment for comparison
            else if (env.IsProduction())
                return MiddlewareReponse(context, ipParts, remoteSegmentConfig);
            else
            //If any other environment is used, the middleware pipeline is terminated with a direct response.
                return context.Response.WriteAsync("Unsupported hosing environment");

        }
        private Task MiddlewareReponse(HttpContext context, string[] ipParts, string allowedSegment)
        {
            string[] segmentParts = allowedSegment.Split('.');
            if (segmentParts.Length != 2)
                return context.Response.WriteAsync($"Malformed segment definition {allowedSegment} in appsettings.json");
            else
            {
                ipParts[0] = "147";
                ipParts[1] = "232";
                if (ipParts.Length == 4)
                {
                    if (ipParts[0] == segmentParts[0] && ipParts[1] == segmentParts[1])
                        //If segments match, the context is passed to following middleware.
                        return _next(context);
                    else
                        //If segments do not match the middleware pipeline is terminated with direct response.
                        return context.Response.WriteAsync("Your IP is not allowed...");
                }
                else
                    //If segments do not match the IP address format the middleware pipeline is terminated with direct response.
                    return context.Response.WriteAsync("Malformed IP address ...");
            }
        }
    }
}
