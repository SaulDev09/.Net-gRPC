using FluentValidation;
using FluentValidation.Resources;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Sc.Trade.Application.UseCases.Commons.Behaviors;
using System.Globalization;
using System.Reflection;

namespace Sc.Trade.Application.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            ValidatorOptions.Global.LanguageManager = new LanguageManager();
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("en");

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehavior<,>));
            });

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
