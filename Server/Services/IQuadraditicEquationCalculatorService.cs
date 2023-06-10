using System.Numerics;

namespace QuadraticEquationCalculator.Server.Services
{
    public interface IQuadraditicEquationCalculatorService
    {
        ValueTuple<Complex, Complex> CalculateQuadraticRoots(double coefficient_a, double coefficient_b, double constant_c);
    }
}
