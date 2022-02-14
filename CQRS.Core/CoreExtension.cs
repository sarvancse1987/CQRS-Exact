using CQRS.Core.CQ;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace CQRS.Core
{
    public static class CoreExtension
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration, params Type[] types)
        {
            var assemblies = types.Select(type => type.GetTypeInfo().Assembly);
            foreach (var assembly in assemblies)
            {
                services.AddMediatR(assembly);
            }
            services.AddScoped<IQueryBus, QueryBus>();
            services.AddScoped<ICommandBus, CommandBus>();
            return services;
        }
    }
}
