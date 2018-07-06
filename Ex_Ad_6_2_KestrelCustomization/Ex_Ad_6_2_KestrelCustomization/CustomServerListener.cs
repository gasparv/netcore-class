using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_6_2_KestrelCustomization
{
    public class CustomServerListener<TContext>
    {
        private readonly FileSystemWatcher _listener;
        private readonly IHttpApplication<TContext> _app;
        private readonly IFeatureCollection _features;

        public CustomServerListener(IHttpApplication<TContext> app, IFeatureCollection features)
        {
            var path = features.Get<IServerAddressesFeature>().Addresses.FirstOrDefault();
            _listener = new FileSystemWatcher(path);
            _listener.EnableRaisingEvents = true;
            _app = app;
            _features = features;
        }

        public void Listen()
        {
            _listener.Created += async (s, e) =>
            {
                _app.CreateContext(_features);
                //context.HttpContext = new CustomServerContext(_features, e.FullPath);
                await _app.ProcessRequestAsync(_app.CreateContext(_features));
                //context.HttpContext.Response.OnCompleted(null, null);
            };
            Task.Run(() => _listener.WaitForChanged(WatcherChangeTypes.All));
        }
    }
}
