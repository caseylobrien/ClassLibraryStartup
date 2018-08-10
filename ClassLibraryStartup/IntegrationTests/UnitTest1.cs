using ClassLibrary;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public UnitTest1(WebApplicationFactory<ClassLibrary.Startup> factory)
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
