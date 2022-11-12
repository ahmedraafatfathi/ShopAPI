using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FeedProcessor
{
    public class EmailProcessor : BackgroundService
    {
        private readonly ILogger<EmailProcessor> _logger;
        private readonly IHostApplicationLifetime _appLifetime;

        public EmailProcessor(ILogger<EmailProcessor> logger,
              IHostApplicationLifetime appLifetime)
        {
            _logger = logger;
            _appLifetime = appLifetime;

            // Register onStopping Event
            _appLifetime.ApplicationStopping.Register(OnStopping);

        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                _logger.LogInformation("Start Email Feed Service");
                while (!stoppingToken.IsCancellationRequested)
                {

                    Thread.Sleep(5000);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception Occurred: ", ex);
                return Task.FromCanceled(stoppingToken);
            }
            return Task.CompletedTask;
        }

        private void OnStopping()
        {
            _logger.LogInformation("Email Processor is Stopping.");
        }



    }

}
