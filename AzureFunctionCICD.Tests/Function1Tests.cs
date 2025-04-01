using Xunit;
using Microsoft.AspNetCore.Mvc;
using AzureFunctionCICD;

namespace AzureFunctionCICD.Tests
{
    public class Function1Tests
    {
        [Fact]
        public void Function1_ReturnsHelloWorld()
        {
            // Arrange
            var req = new Microsoft.AspNetCore.Http.DefaultHttpContext().Request;
            var log = new Microsoft.Extensions.Logging.NullLogger<Function1>();

            // Act
            var result = Function1.Run(req, log).Result;

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Hello, world!", okResult.Value);
        }
    }
} 