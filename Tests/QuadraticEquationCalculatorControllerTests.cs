using MathNet.Numerics;
using Microsoft.Extensions.Logging;
using Moq;
using QuadraticEquationCalculator.Server.Controllers;
using QuadraticEquationCalculator.Server.Services;
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

        private IQuadraditicEquationCalculatorService CreateMockCalculatorService()
        {
            var mockCalcService = new Mock<IQuadraditicEquationCalculatorService>();

            // Don't care if this is the right answer or not... we just need a mock
            mockCalcService.Setup(repo => repo.CalculateQuadraticRoots(1, 2, 3)).Returns(ValueTuple.Create(1, 2));

            return mockCalcService.Object;
        }

        [Fact]
        public void Constructor_ClassExists_ReturnsInstance()
        {
            var mockLogger = Mock.Of<ILogger<QuadraticEquationCalculatorController>>();
            var mockCalcService = CreateMockCalculatorService();

            var controller = new QuadraticEquationCalculatorController(mockLogger, mockCalcService);

            Assert.NotNull(controller);
        }

        [Fact]
        public void Get_ValidInputs_ReturnsTwoValidRoots()
        {
            var mockLogger = Mock.Of<ILogger<QuadraticEquationCalculatorController>>();
            var mockCalcService = CreateMockCalculatorService();
            var controller = new QuadraticEquationCalculatorController(mockLogger, mockCalcService);

            var result = controller.Get(1, 2, 3);

            Assert.False(result.Item1.IsNaN());
            Assert.False(result.Item2.IsNaN());
        }
    }
}
