﻿using MediatR;
using Microsoft.Extensions.Logging;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Core.Behaviors;

public sealed class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : Result
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting request {@RequestName}, {@DateTime}", typeof(TRequest).Name, DateTime.UtcNow);

        var response = await next();

        if (response.IsFailure)
        {
            _logger.LogError("Failure Request {@RequestName}, {@DateTime}", typeof(TRequest).Name, DateTime.UtcNow);
        }

        _logger.LogInformation("Completed request {@RequestName}, {@DateTime}", typeof(TRequest).Name, DateTime.UtcNow);

        return response;
    }
}
