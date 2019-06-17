using Microsoft.Extensions.DependencyInjection;

namespace BotSample.Monitoring
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddAppInsightsTelemetry(this IServiceCollection services, string appInsightsKey)
        {
            services.AddApplicationInsightsTelemetry(appInsightsKey);
            return services;
        }
    }
}
