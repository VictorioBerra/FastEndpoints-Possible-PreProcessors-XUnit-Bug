using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace MaybeBugFEXunit.E2E.Tests.Fixtures
{
    public class CustomWebAppFac<TEntryPoint> :
        WebApplicationFactory<Program>
        where TEntryPoint : class
    {

        // We set up our test API server with this override
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            // TODO check Boxed.Api Tests for logging and other helpful stuff

            // We configure our services for testing
            builder.ConfigureServices(services =>
            {
            });

            builder.ConfigureTestServices(services =>
            {
            });

            builder.UseEnvironment("Development");
        }
    }
}