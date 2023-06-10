using System.Numerics;
using MathNet.Numerics;

namespace QuadraticEquationCalculator.Server.Services
{
    public class QuadraticEquationCalcuatorService : IQuadraditicEquationCalculatorService
    {
        public ValueTuple<Complex, Complex> CalculateQuadraticRoots(double coefficient_a, double coefficient_b, double constant_c)
        {
            var result = FindRoots.Quadratic(constant_c, coefficient_b, coefficient_a);

            return result;
        }
    }
}
