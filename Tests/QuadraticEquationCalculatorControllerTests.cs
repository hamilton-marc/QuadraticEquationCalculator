using Microsoft.Extensions.Logging;
using Moq;
using QuadraticEquationCalculator.Server.Controllers;
using Xunit.Abstractions;

namespace QuadraticEquationCalculator.Tests
{
    public class QuadraticEquationCalculatorControllerTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public QuadraticEquationCalculatorControllerTests(ITestOutputHelper output)
        {
            this._outputHelper = output;
        }

        [Fact]
        public void Constructor_ClassExists_ReturnsInstance()
        {
            var mockLogger = Mock.Of<ILogger<QuadraticEquationCalculatorController>>();
            var controller = new QuadraticEquationCalculatorController(mockLogger);

            Assert.NotNull(controller);
        }
    }
}
