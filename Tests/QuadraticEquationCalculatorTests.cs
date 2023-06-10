using QuadraticEquationCalculator.Server.Services;

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
    }
}