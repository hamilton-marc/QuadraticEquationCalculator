using MathNet.Numerics;
using QuadraticEquationCalculator.Server.Services;
using Xunit.Abstractions;

namespace QuadraticEquationCalculator.Tests
{
    public class QuadraticEquationCalculatorServiceTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public QuadraticEquationCalculatorServiceTests(ITestOutputHelper output)
        {
            this._outputHelper = output;
        }

        [Fact]
        public void Constructor_ClassExists_ReturnsInstance()
        {
            var calculator = new QuadraticEquationCalcuatorService();

            Assert.NotNull(calculator);
        }

        [Fact]
        public void CalculateQuadraticRoots_ValidInputs_ReturnsTwoValidRoots()
        {
            var calculator = new QuadraticEquationCalcuatorService();

            var result = calculator.CalculateQuadraticRoots(1, -3, 2);

            Assert.False(result.Item1.IsNaN());
            Assert.False(result.Item2.IsNaN());

            _outputHelper.WriteLine("Roots: " + result.ToString());
        }
    }
}