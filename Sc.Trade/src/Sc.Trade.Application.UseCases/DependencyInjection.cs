using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Sc.Trade.Application.UseCases.Commons.Behaviors;
using System.Reflection;

namespace Sc.Trade.Application.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            });
            return services;
        }
    }
}
