using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FeedProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("init main");
                var builder = CreateHostBuilder(args);
                var host = builder.Build();
                host.Run();
            }
            catch (Exception exception)
            {
                //NLog: catch setup errors
                logger.Error(exception, "Stopped program because of exception");
                throw;
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseWindowsService()
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                var runDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var env = hostingContext.HostingEnvironment;
                config.AddJsonFile("appsettings.json", optional: true);
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole().AddEventLog();
                logging.SetMinimumLevel(LogLevel.Trace);
            }).UseNLog()
            .ConfigureServices((hostContext, services) =>
            {
                /// Added for conditional engine
                
                services.AddAutoMapper((_serviceProvider, cfg) =>
                {
                }, typeof(Program));


                services.AddHostedService<EmailProcessor>();
            });
    }

}
