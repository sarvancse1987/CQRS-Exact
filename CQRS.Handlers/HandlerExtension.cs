using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Handlers
{
    public static class HandlerExtension
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            return services;
        }
    }
}
