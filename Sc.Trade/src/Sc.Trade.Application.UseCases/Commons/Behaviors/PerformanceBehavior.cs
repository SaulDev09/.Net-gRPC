using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;

namespace Sc.Trade.Application.UseCases.Commons.Behaviors
{
    public class PerformanceBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
    {
        private readonly Stopwatch _stopwatch;
        private readonly ILogger<TRequest> _logger;

        public PerformanceBehavior(ILogger<TRequest> logger)
        {
            _stopwatch = new();
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _stopwatch.Start();
            var response = await next();
            _stopwatch.Stop();

            var timeElapsed = _stopwatch.ElapsedMilliseconds;

            if (timeElapsed > 10)
            {
                _logger.LogInformation("SC - Performance: { name } { timeElapsed } milliseconds { @request }", typeof(TRequest).Name, timeElapsed, JsonSerializer.Serialize(request));
            }

            return response;
        }
    }
}
