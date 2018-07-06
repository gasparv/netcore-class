using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Ex_Ad_6_2_KestrelCustomization
{
    public class CustomServer : IServer
    {
        public CustomServer(IServiceProvider svcProvider, IOptions<ServerSettings> settings)
        {
            var serverAddrFeature = new ServerAddressesFeature();
            serverAddrFeature.Addresses.Add(settings.Value.FolderToListen);
            Features.Set<IHttpRequestFeature>(new HttpRequestFeature());
            Features.Set<IHttpResponseFeature>(new HttpResponseFeature());
            Features.Set<IServerAddressesFeature>(serverAddrFeature);
        }
        public IFeatureCollection Features { get; } = new FeatureCollection();

        public void Dispose()
        {
        }

        public Task StartAsync<TContext>(IHttpApplication<TContext> application, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                //var context = application.CreateContext(Features);
                //application.ProcessRequestAsync(context);

                CustomServerListener<TContext> listener = new CustomServerListener<TContext>(application,Features);
                listener.Listen();
            });
            
            /*
            return Task.Run(async () =>
            {
                var listener = new CustomServerListener<TContext>(application, Features);
                await listener.Listen();
            });
            */
            
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
