using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex_Ad_6_1_GenericHost
{
    //Workers that should run over the generic host should be implemented using the IHostedService interface. 
    //Because I use a timer that is directly instantiated and will not be released after the service ends I also need to implement IDisposable
    //By conventions, the Timer could also be run as a service without the need to implement the IDisposable
    public class CoffeeWorkerService : IHostedService, IDisposable
    {
        //I inject the logger to be able to log results of my worker into the console
        private readonly ILogger _logger;
        //I inject a section of appsettings so that the configuration can be later read
        private readonly IOptions<CoffeeSettings> _coffeeOptions;
        //I inject the configuration provider just to be able to retrieve the in-memory settings
        private readonly IConfiguration _configuration;

        private Timer _timer;

        public CoffeeWorkerService(ILogger<CoffeeWorkerService> logger, IOptions<CoffeeSettings> coffeeOptions, IConfiguration configuration)
        {
            _logger = logger;
            _coffeeOptions = coffeeOptions;
            _configuration = configuration;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The worker is starting...");

            _timer = new Timer(MakeCoffee, null, TimeSpan.Zero,
              TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void MakeCoffee(object state)
        {
            _logger.LogInformation($"Max coffee making time from in memory configuration provider: {_configuration.GetValue<string>("MAX_COFFEE_MAKING_TIME")}");
            _logger.LogError($"Current timeout for making coffee: {_coffeeOptions.Value.MaxCoffeeMakingTimeout}");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The worker is stopping...");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
