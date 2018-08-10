using System;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1 : IClassFixture<WebApplicationTestFactory>
    {
        private readonly WebApplicationTestFactory _factory;

        public UnitTest1(WebApplicationTestFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public void Test1()
        {
            Action createClient = () => _factory.CreateClient();

            Assert.Throws<NullReferenceException>(createClient);
        }
    }
}
