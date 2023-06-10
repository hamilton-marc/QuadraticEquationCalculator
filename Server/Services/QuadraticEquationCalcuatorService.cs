using System.Numerics;

namespace QuadraticEquationCalculator.Server.Services
{
    public class QuadraticEquationCalcuatorService : IQuadraditicEquationCalculatorService
    {
        public Complex[] CalculateQuadraticRoots(double coefficient_a, double coefficient_b, double coefficient_c)
        {
            return new Complex[] { 1, 2 };
        }
    }
}
