namespace QuadraticEquationCalculator.Shared
{
    public class QuadraticRoot
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
    }

    public class QuadraticRoots
    {
        public required QuadraticRoot Root1 { get; set; }
        public required QuadraticRoot Root2 { get; set; }
    }
}
