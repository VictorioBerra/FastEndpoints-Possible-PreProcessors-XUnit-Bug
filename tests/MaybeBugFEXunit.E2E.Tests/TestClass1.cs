using FluentAssertions;
using MaybeBugFEXunit.E2E.Tests.Fixtures;

using Xunit;

namespace MaybeBugFEXunit.E2E.Tests
{
    public class TestClass1 :
        IClassFixture<CustomWebAppFac<Program>>
    {
        public TestClass1(CustomWebAppFac<Program> factory)
        {
            factory.CreateClient();
        }

        [Fact]
        public void Should_Be_Successful()
        {
            true.Should().Be(true);
        }
    }
}