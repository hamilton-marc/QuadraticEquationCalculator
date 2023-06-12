using MathNet.Numerics;
using Microsoft.Extensions.Logging;
using Moq;
using QuadraticEquationCalculator.Server.Controllers;
using QuadraticEquationCalculator.Server.Services;
using QuadraticEquationCalculator.Shared;
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

        private QuadraticRoot AssertValidRoot(QuadraticRoot? root)
        {
            Assert.NotNull(root);
            Assert.False(Double.IsNaN(root.Real));
            Assert.False(Double.IsNaN(root.Real));

            return root;
        }

        [Fact]
        public void Get_ValidInputs_ReturnsTwoValidRoots()
        {
            var mockLogger = Mock.Of<ILogger<QuadraticEquationCalculatorController>>();
            var mockCalcService = CreateMockCalculatorService();
            var controller = new QuadraticEquationCalculatorController(mockLogger, mockCalcService);

            var result = controller.Get(1, 2, 3);

            Assert.NotNull(result);
            AssertValidRoot(result.Root1);
            AssertValidRoot(result.Root2);
        }
    }
}
