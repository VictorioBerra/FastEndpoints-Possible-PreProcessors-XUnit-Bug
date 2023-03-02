namespace MaybeBugFEXunit;

using FluentValidation.Results;

public class SamplePreProcessor1<TRequest> : IPreProcessor<TRequest>
{
    public Task PreProcessAsync(
        TRequest req,
        HttpContext ctx,
        List<ValidationFailure> failures,
        CancellationToken ct)
    {
        return Task.CompletedTask;
    }
}
