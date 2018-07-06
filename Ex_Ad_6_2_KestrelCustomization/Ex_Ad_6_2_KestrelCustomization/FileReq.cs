using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Ex_Ad_6_2_KestrelCustomization
{
    public class FileReq : HttpRequest
    {
        public FileReq(HttpContext httpContext, string path)
        {
            var lines = File.ReadAllText(path).Split('\n');
            var request = lines[0].Split(' ');
            Method = request[0];
            //Path = request[1];
            this.HttpContext = httpContext;
        }
        public override HttpContext HttpContext { get; }

        public override string Method { get; set; }
        public override string Scheme { get; set; } = "file";
        public override bool IsHttps { get ; set ; }
        public override HostString Host { get ; set ; }
        public override PathString PathBase { get; set; }
        public override PathString Path { get; set; }
        public override QueryString QueryString { get; set; }
        public override IQueryCollection Query { get; set; }
        public override string Protocol { get; set; }

        public override IHeaderDictionary Headers =>  new HeaderDictionary();

        public override IRequestCookieCollection Cookies { get; set; }
        public override long? ContentLength { get; set; }
        public override string ContentType { get; set; }
        public override Stream Body { get; set; }

        public override bool HasFormContentType => throw new NotImplementedException();

        public override IFormCollection Form { get; set; }

        public override Task<IFormCollection> ReadFormAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }
}
