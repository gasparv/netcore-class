using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;

namespace Ex_Ad_6_2_KestrelCustomization
{
    public class CustomServerContext : HttpContext
    {
        //Minimum necessary implementation of the custom server requires Features specification, request and response
        public override IFeatureCollection Features { get; }
        public override HttpRequest Request { get; }
        public override HttpResponse Response { get; }

        private readonly IFeatureCollection _features;
        private readonly HttpRequest _req;
        private readonly HttpResponse _res;
        private readonly ILogger<CustomServer> _logger;

        public CustomServerContext(IFeatureCollection features, string path)
        {
            _features = features;
            _req = new FileReq(this, path);
            _res = new FileRes(this, path);
        }

        //These context functionalities do not need to be necessarily implemented
        public override ConnectionInfo Connection => throw new NotImplementedException();

        public override WebSocketManager WebSockets => throw new NotImplementedException();

        public override AuthenticationManager Authentication => throw new NotImplementedException();

        public override ClaimsPrincipal User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IDictionary<object, object> Items { get; set; }
        public override IServiceProvider RequestServices { get ; set; }
        public override CancellationToken RequestAborted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string TraceIdentifier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ISession Session { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Abort()
        {
            throw new NotImplementedException();
        }
    }
}
