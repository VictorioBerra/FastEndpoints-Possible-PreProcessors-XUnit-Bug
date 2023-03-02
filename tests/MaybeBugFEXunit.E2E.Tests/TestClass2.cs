using FluentAssertions;
using MaybeBugFEXunit.E2E.Tests.Fixtures;
using Xunit;

namespace MaybeBugFEXunit.E2E.Tests
{
    public class TestClass2 :
        IClassFixture<CustomWebAppFac<Program>>
    {
        public TestClass2(CustomWebAppFac<Program> factory)
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