using FastEndpoints;

public class MyRequestLogger<TRequest> : IPreProcessor<TRequest>
{
    public Task PreProcessAsync(IPreProcessorContext<TRequest> ctx, CancellationToken ct)
    {
        var logger = ctx.HttpContext.Resolve<ILogger<TRequest>>();

        logger.LogInformation(
            $"request:{ctx.Request.GetType().FullName} path: {ctx.HttpContext.Request.Path}");

        return Task.CompletedTask;
    }
}