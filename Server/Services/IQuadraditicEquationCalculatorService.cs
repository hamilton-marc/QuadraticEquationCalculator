using System.Numerics;

namespace QuadraticEquationCalculator.Server.Services
{
    public interface IQuadraditicEquationCalculatorService
    {
        Complex[] CalculateQuadraticRoots(double coefficient_a, double coefficient_b, double coefficient_c);
    }
}
