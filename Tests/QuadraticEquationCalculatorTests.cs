using QuadraticEquationCalculator.Server.Services;
using System.Numerics;

namespace QuadraticEquationCalculator.Tests
{
    public class QuadraticEquationCalculatorServiceTests
    {
        [Fact]
        public void Constructor_ClassExists_ReturnsInstance()
        {
            var calculator = new QuadraticEquationCalcuatorService();

            Assert.NotNull(calculator);
        }

        [Fact]
        public void Calculate_ValidCoefficients_ReturnsNonEmptyArray()
        {
            var calculator = new QuadraticEquationCalcuatorService();

            var result = calculator.CalculateQuadraticRoots(1, 2, 3);

            Assert.NotEmpty(result);
        }

        [Fact]
        public void Calculate_ValidCoefficients_ReturnsTwoRoots()
        {
            var calculator = new QuadraticEquationCalcuatorService();

            var result = calculator.CalculateQuadraticRoots(1, 2, 3);

            Assert.Equal(2, result.Length);
        }
    }
}