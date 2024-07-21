using MediatR;
using Microsoft.Extensions.Logging;
using My_Shop.Domain.Core.BaseType.Result;

namespace My_Shop.Application.Core.Behaviors;

internal class ExceptionHandlingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : class
    where TResponse : Result
{
    private readonly ILogger<ExceptionHandlingBehavior<TRequest, TResponse>> _logger;

    public ExceptionHandlingBehavior(ILogger<ExceptionHandlingBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch(Exception)
        {
            _logger.LogError("Unhandle Exception for {@RequestName}", typeof(TRequest).Name);

            throw;
        }
    }
}
