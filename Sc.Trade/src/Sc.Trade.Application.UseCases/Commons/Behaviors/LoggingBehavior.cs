using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Sc.Trade.Application.UseCases.Commons.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var correlationId = Guid.NewGuid();
            _logger.LogInformation("SC - Request: { @correlationId } { name } { @request }", correlationId, typeof(TRequest).Name, JsonSerializer.Serialize(request));
            var response = await next();
            _logger.LogInformation("SC - Response: { @correlationId } { name } { @response }", correlationId, typeof(TResponse).Name, JsonSerializer.Serialize(response));
            return response;
        }
    }
}
