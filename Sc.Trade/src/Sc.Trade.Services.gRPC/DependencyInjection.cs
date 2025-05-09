using Sc.Trade.Services.gRPC.Commons.GlobalException;
using System.Reflection;

namespace Sc.Trade.Services.gRPC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddGrpc(options =>
            {
                options.Interceptors.Add<GlobalExceptionHandler>();
            });
            return services;
        }
    }
}
