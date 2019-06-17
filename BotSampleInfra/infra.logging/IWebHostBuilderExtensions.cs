using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace BotSample.Monitoring
{
    public static class IWebHostBuilderExtensions
    {
        public static IWebHostBuilder ConfigureBotSampleMonitoring(this IWebHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureServices((webHostBuilderContext, serviceCollection) =>
            {
                var appInsightsKey = webHostBuilderContext.Configuration.GetSection("ApplicationInsights:instrumentationKey");
                serviceCollection.AddAppInsightsTelemetry(appInsightsKey.Value);
            });
        }

        public static IWebHostBuilder ConfigureBotSampleLogging(this IWebHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureLogging((webHostBuilderContext, logging) =>
             {
                 logging.AddFilter<Microsoft.Extensions.Logging.ApplicationInsights.ApplicationInsightsLoggerProvider>
                        ("", LogLevel.Trace);
             });
        }
    }
}
