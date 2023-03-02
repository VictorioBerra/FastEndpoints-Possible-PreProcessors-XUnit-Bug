namespace MaybeBugFEXunit.Endpoints;

public class IndexRequest
{
    public int MyId { get; set; }
}

public class IndexResponse
{
    public string Message { get; set; } = default!;
}

public class IndexEndpoint : Endpoint<IndexRequest, IndexResponse>
{
    public override void Configure()
    {
        Get("/");
        AllowAnonymous();

        // Comment me out, and both tests will pass when clicking "Run All" in the test explorer.
        PreProcessors(
            new SamplePreProcessor1<IndexRequest>(),
            new SamplePreProcessor2<IndexRequest>());
    }

    public override async Task HandleAsync(IndexRequest req, CancellationToken ct)
    {
        await SendOkAsync(new IndexResponse
        {
            Message = "Hello Fast Endpoints"
        }, ct);
    }
}
