using MediatR;
using Microsoft.Extensions.Logging;

namespace My_Shop.Application.Core.Behaviors;

internal sealed class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : class
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting request {@RequestName}, {@DateTime}", typeof(TRequest).Name, DateTime.UtcNow);

        var response = await next();

        _logger.LogInformation("Completed request {@RequestName}, {@DateTime}", typeof(TRequest).Name, DateTime.UtcNow);

        return response;
    }
}
