using Ex_7_2_ClassMiddleware.Middleware;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_7_2_ClassMiddleware.Extensions
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseIPFiltering(this IApplicationBuilder builder, params object[] constructorParams)
        {
            return builder.UseMiddleware<IPFilteringMiddleware>(constructorParams);
        }
    }
}
