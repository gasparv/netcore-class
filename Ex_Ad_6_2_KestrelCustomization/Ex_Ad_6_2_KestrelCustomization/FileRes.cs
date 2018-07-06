using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Ad_6_2_KestrelCustomization
{
    public class FileRes : HttpResponse
    {
        public FileRes(HttpContext httpContext, string path)
        {
        }
        public override HttpContext HttpContext {get; }

        public override int StatusCode { get; set; }

        public override IHeaderDictionary Headers => new HeaderDictionary();

        public override Stream Body { get; set; } = new MemoryStream();
        public override long? ContentLength { get; set; }
        public override string ContentType { get; set; }

        public override IResponseCookies Cookies => throw new NotImplementedException();

        public override bool HasStarted => true;

        public override void OnCompleted(Func<object, Task> callback, object state)
        {
            using (var reader = new StreamReader(Body))
            {
                Body.Position = 0;
                var text = reader.ReadToEnd();
                Console.WriteLine($"{StatusCode} a {text}");
                //_logger.LogInformation($"\r\n\r\n--\r\n{StatusCode}\r\n{text}");
                Body.Flush();
                Body.Dispose();
            }
        }

        public override void OnStarting(Func<object, Task> callback, object state) { }
        public override void Redirect(string location, bool permanent) { }
    }
}
